using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;
using Applicatie_Risicoanalyse.Controls;
using Applicatie_Risicoanalyse.Globals;
using System.Windows.Documents;
using Applicatie_Risicoanalyse.Reports;
using System.IO;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class RiskAssesmentReport : Form
    {
        object missing = Type.Missing;
        object paramFalse                   = false;

        public RiskAssesmentReport(int projectID, string sortingKey, object newDocumentLocation, byte[] riskPageTemplateLocation, byte[] indexPageTemplateLocation, byte[] frontPageTemplateLocation)
        {
            InitializeComponent();

            // To report progress from the background worker we need to set this property.
            backgroundWorker1.WorkerReportsProgress = true;
            // Enabled cancelation of thread progress.
            backgroundWorker1.WorkerSupportsCancellation = true;
            // This event will be raised on the worker thread when the worker starts.
            DoWorkEventArgs eventArgs = new GenerateRiskReportEventArgs(projectID, sortingKey, newDocumentLocation,  riskPageTemplateLocation,  indexPageTemplateLocation,  frontPageTemplateLocation);
            backgroundWorker1.DoWork += (obj, e) => generateReport(obj, eventArgs);
            // This event will be raised when we call ReportProgress.
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            //Do something when the background worker completes.
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_WorkerCompleted);
        }

        private void backgroundWorker1_WorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(!e.Cancelled)
            {
                System.Windows.Forms.MessageBox.Show("Document generated!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // The progress percentage is a property of e
            RarProgressText.Text = e.UserState.ToString();
            RarProgressText.Invalidate();
            RarProgressBar.Value = e.ProgressPercentage;
        }

        private void testForm_Shown(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void RarButtonCancel_Click(object sender, EventArgs e)
        {
            if(backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void testForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_MinimalAddition_In_Risk' table. You can move, or remove it, as needed.
            this.tbl_MinimalAddition_In_RiskTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_MinimalAddition_In_Risk);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Danger_Source' table. You can move, or remove it, as needed.
            this.tbl_Danger_SourceTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Danger_Source);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Danger_Result' table. You can move, or remove it, as needed.
            this.tbl_Danger_ResultTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Danger_Result);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Danger' table. You can move, or remove it, as needed.
            this.tbl_DangerTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Danger);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Risk_Data' table. You can move, or remove it, as needed.
            this.tbl_Risk_DataTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Risk_Data);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Risks_In_Project' table. You can move, or remove it, as needed.
            this.tbl_Risks_In_ProjectTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Risks_In_Project);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Risk_Analysis' table. You can move, or remove it, as needed.
            this.tbl_Risk_AnalysisTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Risk_Analysis);
        }

        private void generateReport(object sender, DoWorkEventArgs args)
        {
            GenerateRiskReportEventArgs e = args as GenerateRiskReportEventArgs;
            if (e == null)
            {
                throw new Exception("No generate risk report event args parsed");
            }

            Document wordDocument = null;

            try
            {
                //Create a word interface so we can talk easylie to word.
                WordInterface wordInterface = new WordInterface();

                // Open a new document.
                //wordDocument = wordInterface.app.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                FileStream newDocument = File.Create((string)e.newDocumentLocation);
                newDocument.Close();
                newDocument = null;

                wordDocument = wordInterface.app.Documents.Open(e.newDocumentLocation);

                DataRow projectInfoRow = tbl_Risk_AnalysisTableAdapter.GetData().FindByProjectID(e.projectID);
                DataView riskDataRows = new DataView(this.get_Risks_With_RiskData_In_ProjectTableAdapter.GetData(e.projectID));
                riskDataRows.Sort = ARA_Globals.RiskSortingOptions[e.sortingKey];

                //Set generating process.

                backgroundWorker1.ReportProgress(5,(object)"Generating front page.");

                generateFrontPage(e.frontPageTemplateLocation,wordInterface,wordDocument,projectInfoRow);

                backgroundWorker1.ReportProgress(10, (object)"Generating page index.");

                generateIndexPage(e.indexPageTemplateLocation, wordInterface, wordDocument,riskDataRows);

                backgroundWorker1.ReportProgress(15, (object)"Generating risk pages.");

                generateRiskPages(e.riskPageTemplateLocation, wordInterface, wordDocument, riskDataRows, projectInfoRow);

                backgroundWorker1.ReportProgress(70, (object)"Saving the document.");

                wordInterface.saveDocument(wordDocument, (string)e.newDocumentLocation);

                backgroundWorker1.ReportProgress(90, (object)"Converting document to pdf.");

                //convertToPdf();

                backgroundWorker1.ReportProgress(100, (object)"Done generating.");

                //Do we need to cancel the backgroundworker?
                if (backgroundWorker1.CancellationPending)
                {
                    args.Cancel = true;
                }

                //Clean the word interface.
                wordInterface.Quit();
                wordInterface = null;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString(),"Something went wrong while generating.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

            // Close and release the Document object.
            if (wordDocument != null)
            {
                
                wordDocument = null;
            }
        }

        private void generateIndexPage(byte[] templateLocation, WordInterface wordInterface, Document wordDocument, DataView riskDataRows)
        {
            try
            {
                //Open the template
                String tempTemplateFile = Path.GetTempFileName();
                File.WriteAllBytes(tempTemplateFile, templateLocation);
                Document indexPageTemplate = wordInterface.app.Documents.Open(tempTemplateFile);

                //Copy template to main document.
                wordInterface.copyDocumentToOtherDocument(indexPageTemplate, wordDocument, true);
                wordDocument.Activate();

                //Find index table.
                Microsoft.Office.Interop.Word.Table indexTable = wordInterface.findTableWithTitle(wordDocument, "riskAssessmentIndex");
                if(indexTable == null)
                {
                    throw new Exception("Could not find riskAssessmentIndex table. Check your template.");
                }

                //Fill index table.
                foreach (DataRowView riskDataRow in riskDataRows)
                {
                    int riskDataID = riskDataRow["ProjectRiskDataID"] != DBNull.Value ? (Int32)riskDataRow["ProjectRiskDataID"] : (Int32)riskDataRow["DefaultRiskDataID"];

                    Row newTableRow = indexTable.Rows.Add(ref missing);
                    DataView minimalAdditionView = new DataView(this.tbl_MinimalAddition_In_RiskTableAdapter.GetData());
                    minimalAdditionView.RowFilter = string.Format("RiskDataID = '{0}'", riskDataID);

                    newTableRow.Cells[2].Range.Text = riskDataRow["HazardSituation"].ToString();
                    newTableRow.Cells[3].Range.Text = riskDataRow["RiskID"].ToString();
                    
                    //Insert a checkmark if it has remaining risk.
                    if (minimalAdditionView.Count > 0)
                    {
                        newTableRow.Cells[4].Range.Font.Name = "Wingdings";
                        newTableRow.Cells[4].Range.Font.Size = 12;
                        newTableRow.Cells[4].Range.Text = '\u00FC'.ToString();
                    }
                }

                //Add page numbers to index.
                int pageCount = wordDocument.ComputeStatistics(WdStatistic.wdStatisticPages, false);
                for (int i = 0; i < riskDataRows.Count; i++)
                {
                    indexTable.Rows[2 + i].Cells[1].Range.Text = (i + pageCount).ToString();
                }

                // Close and release the Document object.
                if (indexPageTemplate != null)
                {
                    ((_Document)indexPageTemplate).Close(ref paramFalse, ref missing,
                        ref missing);
                    File.Delete(tempTemplateFile);
                    indexPageTemplate = null;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void generateFrontPage(byte[] templateLocation, WordInterface wordInterface, Document wordDocument, DataRow projectInfoRow)
        {
            try
            {
                //Open the template
                String tempTemplateFile = Path.GetTempFileName();
                File.WriteAllBytes(tempTemplateFile, templateLocation);
                Document frontPageTemplate = wordInterface.app.Documents.Open(tempTemplateFile);

                //Copy document to main document.
                wordInterface.copyDocumentToOtherDocument(frontPageTemplate, wordDocument, true);
                wordDocument.Activate();

                //Set template data.
                wordInterface.searchAndReplace(wordInterface.app, "<CustomerName>"  , projectInfoRow["Customer"].ToString());
                wordInterface.searchAndReplace(wordInterface.app, "<MachineNumber>" , projectInfoRow["MachineNumber"].ToString());
                wordInterface.searchAndReplace(wordInterface.app, "<OrderNumber>"   , projectInfoRow["OrderNumber"].ToString());
                wordInterface.searchAndReplace(wordInterface.app, "<MachineType>"   , projectInfoRow["MachineType"].ToString());
                wordInterface.searchAndReplace(wordInterface.app, "<CurrentDate>"   , ARA_Globals.ARa_Date);

                //Remove template from memory.
                if (frontPageTemplate != null)
                {
                    ((_Document)frontPageTemplate).Close(ref paramFalse, ref missing,
                        ref missing);
                    File.Delete(tempTemplateFile);
                    frontPageTemplate = null;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void generateRiskPages(byte[] templateLocation, WordInterface wordInterface, Document wordDocument, DataView riskDataRows, DataRow projectInfoRow)
        {
            int currentRisk = 0;
            try
            {
                //Open template document.
                String tempTemplateFile = Path.GetTempFileName();
                File.WriteAllBytes(tempTemplateFile, templateLocation);
                Document riskTemplate = wordInterface.app.Documents.Open(tempTemplateFile);

                foreach (DataRowView riskDataRow in riskDataRows)
                {
                    //Set generating process
                    backgroundWorker1.ReportProgress(
                        33 + (Int32)((float)currentRisk / (float)riskDataRows.Count * 33),
                        (object)string.Format("Generating page {0} of {1}.", currentRisk + 1, riskDataRows.Count)
                    );
                    currentRisk++;

                    //Get the risk data id and set some variables.
                    int riskDataID                              = riskDataRow["ProjectRiskDataID"] != DBNull.Value ? (Int32)riskDataRow["ProjectRiskDataID"] : (Int32)riskDataRow["DefaultRiskDataID"];
                    Color[] riskEstimationColors                = { ARA_Colors.ARA_Green, ARA_Colors.ARA_Orange, ARA_Colors.ARA_Red };

                    //Get some more info about the risk.
                    DataRow riskData                            = this.tbl_Risk_DataTableAdapter.GetData().FindByRiskDataID(riskDataID);
                    DataRow dangerRow                           = this.tbl_DangerTableAdapter.GetData().FindByDangerID((Int32)riskData["DangerID"]);
                    DataRow dangerSourceRow                     = this.tbl_Danger_SourceTableAdapter.GetData().FindByDangerSourceID((Int32)riskData["DangerSourceID"]);

                    DataView dangerResults                      = new DataView(this.tbl_Danger_ResultTableAdapter.GetData());
                    DataView riskEstimationBeforeView           = new DataView(this.get_RiskEstimation_In_RiskData_BeforeTableAdapter.GetData(riskDataID));
                    DataView riskEstimationAfterView            = new DataView(this.get_RiskEstimation_In_RiskData_AfterTableAdapter.GetData(riskDataID));
                    DataView appliedRiskReductionMeasures       = new DataView(this.get_RiskReduction_In_RiskDataTableAdapter.GetData(riskDataID));
                    DataView minimalAdditionMeasures            = new DataView(this.get_MinimalAddition_In_RiskDataTableAdapter.GetData(riskDataID));

                    //Set some value's before copying document.
                    riskTemplate.Activate();
                    foreach (DataRow exposedPersonRow in this.get_ExposedPersons_In_RiskDataTableAdapter.GetData(riskDataID).Rows)
                    {
                        riskTemplate.SelectContentControlsByTitle(exposedPersonRow["PersonDescription"].ToString())[(object)1].Checked = exposedPersonRow["InProject"].ToString() == "1";
                    }

                    //Copy template.
                    wordInterface.copyDocumentToOtherDocument(riskTemplate, wordDocument, true);
                    wordDocument.Activate();

                    //Set values form newly added document.
                    dangerResults.RowFilter = string.Format("DangerSourceID = {0}", dangerSourceRow["DangerSourceID"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<Hazard>"                , dangerRow["DangerGroupName"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<HazardSource>"          , dangerSourceRow["DangerSourceName"].ToString());

                    if (dangerResults.Count > 0)
                    {
                        wordInterface.searchAndReplace(wordInterface.app, "<HazardResult1>"     , string.Format("{0}", dangerResults[0]["DangerResultName"].ToString()));
                    }
                    else
                    {
                        wordInterface.searchAndReplace(wordInterface.app, "<HazardResult1>"     , "");
                    }

                    if (dangerResults.Count > 1)
                    {
                        wordInterface.searchAndReplace(wordInterface.app, "<HazardResult2>"     , string.Format("{0}", dangerResults[1]["DangerResultName"].ToString()));
                    }
                    else
                    {
                        wordInterface.searchAndReplace(wordInterface.app, "<HazardResult2>"     , "");
                    }

                    //Search and replace headerinfo.
                    wordInterface.searchAndReplace(wordInterface.app, "<CustomerName>"          , projectInfoRow["Customer"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<MachineInfo>"           , string.Format("{0}/{1}", projectInfoRow["MachineNumber"].ToString(), projectInfoRow["OrderNumber"].ToString()));
                    wordInterface.searchAndReplace(wordInterface.app, "<RiskID>"                , riskDataRow["RiskID"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<BriefActionDescription>", riskDataRow["HazardSituation"].ToString(), ARA_Colors.ARA_Red);

                    //Search and replace riskdata.
                    wordInterface.searchAndReplace(wordInterface.app, "<RiskGroup>"             , string.Format("{0} - {1}",riskDataRow["GroupName"].ToString(), riskDataRow["TypeName"].ToString()));
                    wordInterface.searchAndReplace(wordInterface.app, "<ActionEvent>"           , riskData["HazardEvent"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<RiskReductionInfo>"     , riskData["RiskReductionInfo"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<MinimalAdditionInfo>"   , riskData["MinimalAdditionInfo"].ToString());

                    //Set the riskestimation fields.
                    ARA_EditRiskRiskEstimation temp = new ARA_EditRiskRiskEstimation();
                    temp.setControlData(riskEstimationBeforeView);

                    riskEstimationBeforeView.RowFilter = "InProject = '1'";
                    if (riskEstimationBeforeView.Count != 4)
                        throw new Exception("Cant generate report, because a risk isn't correctly filled in " + riskDataID.ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<SEDescriptionB>"        , riskEstimationBeforeView[0]["ItemDescription"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<FRDescriptionB>"        , riskEstimationBeforeView[1]["ItemDescription"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<PRDescriptionB>"        , riskEstimationBeforeView[2]["ItemDescription"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<AVDescriptionB>"        , riskEstimationBeforeView[3]["ItemDescription"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<SEWeightB>"             , riskEstimationBeforeView[0]["ItemWeight"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<FRWeightB>"             , riskEstimationBeforeView[1]["ItemWeight"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<PRWeightB>"             , riskEstimationBeforeView[2]["ItemWeight"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<AVWeightB>"             , riskEstimationBeforeView[3]["ItemWeight"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<RiskClassValueB>"       , temp.calculateRiskEstimationClass().ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<RiskClassDescriptionB>" , ARA_Globals.RiskClassDescription[temp.calculateRiskEstimationClass()], riskEstimationColors[temp.calculateRiskEstimationClass()]);

                    temp.setControlData(riskEstimationAfterView);
                    riskEstimationAfterView.RowFilter = "InProject = '1'";
                    if (riskEstimationAfterView.Count != 4)
                        throw new Exception("Cant generate report, because a risk isn't correctly filled in " + riskDataID.ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<SEDescriptionA>"        , riskEstimationAfterView[0]["ItemDescription"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<FRDescriptionA>"        , riskEstimationAfterView[1]["ItemDescription"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<PRDescriptionA>"        , riskEstimationAfterView[2]["ItemDescription"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<AVDescriptionA>"        , riskEstimationAfterView[3]["ItemDescription"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<SEWeightA>"             , riskEstimationAfterView[0]["ItemWeight"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<FRWeightA>"             , riskEstimationAfterView[1]["ItemWeight"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<PRWeightA>"             , riskEstimationAfterView[2]["ItemWeight"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<AVWeightA>"             , riskEstimationAfterView[3]["ItemWeight"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<RiskClassValueA>"       , temp.calculateRiskEstimationClass().ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<RiskClassDescriptionA>" , ARA_Globals.RiskClassDescription[temp.calculateRiskEstimationClass()], riskEstimationColors[temp.calculateRiskEstimationClass()]);

                    //Find table and do stuff with it.
                    Microsoft.Office.Interop.Word.Table appliedRiskReductionMeasuresTable       = wordInterface.findTableWithTitle(wordDocument, "AppliedRiskReductionMeasures");
                    appliedRiskReductionMeasures.RowFilter                                      = "InProject = '1'";
                    wordInterface.fillTableWithRiskReducingMeasures(wordDocument, appliedRiskReductionMeasuresTable, appliedRiskReductionMeasures, "MeasureSubGroup", "InProject");
                    appliedRiskReductionMeasuresTable.Title                                     = "";

                    Microsoft.Office.Interop.Word.Table minimalAdditionMeasuresTable            = wordInterface.findTableWithTitle(wordDocument, "MinimalAdditionMeasures");
                    minimalAdditionMeasures.RowFilter                                           = "InProject = '1'";
                    wordInterface.fillTableWithRiskReducingMeasures(wordDocument, minimalAdditionMeasuresTable, minimalAdditionMeasures, "MeasureSubGroup", "InProject");
                    minimalAdditionMeasuresTable.Title                                          = "";

                    //Clear some memory.
                    temp.Dispose();
                    temp = null;

                    //Do we need to cancel execution?
                    if (backgroundWorker1.CancellationPending)
                    {
                        break;
                    }
                }

                //Remove template from memory.
                if (riskTemplate != null)
                {
                    ((_Document)riskTemplate).Close(ref paramFalse, ref missing,
                        ref missing);
                    File.Delete(tempTemplateFile);
                    riskTemplate = null;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
