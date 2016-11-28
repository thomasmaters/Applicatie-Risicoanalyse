using Applicatie_Risicoanalyse.Controls;
using Applicatie_Risicoanalyse.Globals;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Applicatie_Risicoanalyse.Reports.PerformanceLevelReport
{
    public partial class PerformanceLevelReport : Applicatie_Risicoanalyse.Forms.BaseReportGeneratorForm
    {
        public PerformanceLevelReport(int projectID, string sortingKey, object newDocumentLocation, byte[] riskPageTemplateLocation, byte[] frontPageTemplateLocation)
        {
            // This event will be raised on the worker thread when the worker starts.
            DoWorkEventArgs eventArgs = new GeneratePerformanceLevelReportEventArgs(projectID, sortingKey, newDocumentLocation, riskPageTemplateLocation, frontPageTemplateLocation);
            this.runBackgroundWorker(eventArgs);
            InitializeComponent();
        }

        protected override void generateReport(object sender, DoWorkEventArgs args)
        {
            GeneratePerformanceLevelReportEventArgs e = args as GeneratePerformanceLevelReportEventArgs;
            if (e == null)
            {
                throw new Exception("No generate performance level report event args parsed");
            }

            Document wordDocument = null;

            //Create a word interface so we can talk easilie to word.
            WordInterface wordInterface = new WordInterface();

            try
            {
                // Open a new document.
                FileStream newDocument = File.Create((string)e.newDocumentLocation);
                newDocument.Close();
                newDocument = null;

                //Create our output document.
                wordDocument = wordInterface.app.Documents.Open(e.newDocumentLocation);

                //Get some data out of the database.
                DataRow projectInfoRow = tbl_Risk_AnalysisTableAdapter.GetData().FindByProjectID(e.projectID);
                DataView riskDataRows = new DataView(this.get_Risks_With_PL_In_ProjectTableAdapter.GetData(e.projectID));
                riskDataRows.Sort = ARA_Globals.RiskSortingOptions[e.sortingKey];

                //Set generating process.

                backgroundWorker1.ReportProgress(5, (object)"Generating front page.");

                generateFrontPage(e.frontPageTemplateLocation, wordInterface, wordDocument, projectInfoRow);

                backgroundWorker1.ReportProgress(15, (object)"Generating PL pages.");

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
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString(), "Something went wrong while generating.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //Clean the word interface.
            wordInterface.Quit();
            wordInterface = null;
        }

        private void generateFrontPage(byte[] templateLocation, WordInterface wordInterface, Document wordDocument, DataRow projectInfoRow)
        {
            lock(this.threadLock)
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
                    wordInterface.searchAndReplace(wordInterface.app, "<CustomerName>", projectInfoRow["Customer"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<MachineNumber>", projectInfoRow["MachineNumber"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<OrderNumber>", projectInfoRow["OrderNumber"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<MachineType>", projectInfoRow["MachineType"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<CurrentDate>", ARA_Globals.ARa_Date);

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
        }

        private void generateRiskPages(byte[] templateLocation, WordInterface wordInterface, Document wordDocument, DataView riskDataRows, DataRow projectInfoRow)
        {
            lock (this.threadLock)
            {
                int currentRisk = 0;
                try
                {
                    //Open template document.
                    String tempTemplateFile = Path.GetTempFileName();
                    File.WriteAllBytes(tempTemplateFile, templateLocation);
                    Document riskTemplate = wordInterface.app.Documents.Open(tempTemplateFile);
                    PLCalculator plCalculator = new PLCalculator();

                    foreach (DataRowView riskDataRow in riskDataRows)
                    {
                        //Set generating process
                        backgroundWorker1.ReportProgress(
                        33 + (Int32)((float)currentRisk / (float)riskDataRows.Count * 33),
                        (object)string.Format("Generating page {0} of {1}.", currentRisk + 1, riskDataRows.Count)
                        );
                        currentRisk++;

                        //Get the risk data id and set some variables.
                        int riskDataID = riskDataRow["ProjectRiskDataID"] != DBNull.Value ? (Int32)riskDataRow["ProjectRiskDataID"] : (Int32)riskDataRow["DefaultRiskDataID"];
                        Color[] riskEstimationColors = { ARA_Colors.ARA_Green, ARA_Colors.ARA_Orange, ARA_Colors.ARA_Red };

                        //Get some more info about the risk.
                        DataRow riskData = this.tbl_Risk_DataTableAdapter.GetData().FindByRiskDataID(riskDataID);
                        DataRow dangerRow = this.tbl_DangerTableAdapter.GetData().FindByDangerID((Int32)riskData["DangerID"]);
                        DataRow dangerSourceRow = this.tbl_Danger_SourceTableAdapter.GetData().FindByDangerSourceID((Int32)riskData["DangerSourceID"]);

                        DataView dangerResults = new DataView(this.tbl_Danger_ResultTableAdapter.GetData());
                        DataView riskEstimationBeforeView = new DataView(this.get_RiskEstimation_In_RiskData_BeforeTableAdapter.GetData(riskDataID));
                        DataView riskEstimationAfterView = new DataView(this.get_RiskEstimation_In_RiskData_AfterTableAdapter.GetData(riskDataID));
                        DataView appliedRiskReductionMeasures = new DataView(this.get_RiskReduction_In_RiskDataTableAdapter.GetData(riskDataID));
                        DataView minimalAdditionMeasures = new DataView(this.get_MinimalAddition_In_RiskDataTableAdapter.GetData(riskDataID));

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
                        wordInterface.searchAndReplace(wordInterface.app, "<Hazard>", dangerRow["DangerGroupName"].ToString());
                        wordInterface.searchAndReplace(wordInterface.app, "<HazardSource>", dangerSourceRow["DangerSourceName"].ToString());

                        if (dangerResults.Count > 0)
                        {
                            wordInterface.searchAndReplace(wordInterface.app, "<HazardResult1>", string.Format("{0}", dangerResults[0]["DangerResultName"].ToString()));
                        }
                        else
                        {
                            wordInterface.searchAndReplace(wordInterface.app, "<HazardResult1>", "");
                        }

                        if (dangerResults.Count > 1)
                        {
                            wordInterface.searchAndReplace(wordInterface.app, "<HazardResult2>", string.Format("{0}", dangerResults[1]["DangerResultName"].ToString()));
                        }
                        else
                        {
                            wordInterface.searchAndReplace(wordInterface.app, "<HazardResult2>", "");
                        }

                        //Search and replace headerinfo.
                        wordInterface.searchAndReplace(wordInterface.app, "<CustomerName>", projectInfoRow["Customer"].ToString());
                        wordInterface.searchAndReplace(wordInterface.app, "<MachineInfo>", string.Format("{0}/{1}", projectInfoRow["MachineNumber"].ToString(), projectInfoRow["OrderNumber"].ToString()));
                        wordInterface.searchAndReplace(wordInterface.app, "<RiskID>", riskDataRow["RiskID"].ToString());
                        wordInterface.searchAndReplace(wordInterface.app, "<BriefActionDescription>", riskDataRow["HazardSituation"].ToString(), ARA_Colors.ARA_Red);

                        //Search and replace riskdata.
                        wordInterface.searchAndReplace(wordInterface.app, "<RiskGroup>", string.Format("{0} - {1}", riskDataRow["GroupName"].ToString(), riskDataRow["TypeName"].ToString()));
                        wordInterface.searchAndReplace(wordInterface.app, "<ActionEvent>", riskData["HazardEvent"].ToString());
                        wordInterface.searchAndReplace(wordInterface.app, "<RiskReductionInfo>", riskData["RiskReductionInfo"].ToString());
                        wordInterface.searchAndReplace(wordInterface.app, "<MinimalAdditionInfo>", riskData["MinimalAdditionInfo"].ToString());

                        //Set the riskestimation fields.
                        ARA_EditRiskRiskEstimation temp = new ARA_EditRiskRiskEstimation();
                        temp.setControlData(riskEstimationBeforeView);

                        riskEstimationBeforeView.RowFilter = "InProject = '1'";
                        if (riskEstimationBeforeView.Count != 4)
                            throw new Exception("Cant generate report, because a risk isn't correctly filled in " + riskDataID.ToString());
                        wordInterface.searchAndReplace(wordInterface.app, "<SEWeightB>", riskEstimationBeforeView[0]["ItemWeight"].ToString());
                        wordInterface.searchAndReplace(wordInterface.app, "<FRWeightB>", riskEstimationBeforeView[1]["ItemWeight"].ToString());
                        wordInterface.searchAndReplace(wordInterface.app, "<PRWeightB>", riskEstimationBeforeView[2]["ItemWeight"].ToString());
                        wordInterface.searchAndReplace(wordInterface.app, "<AVWeightB>", riskEstimationBeforeView[3]["ItemWeight"].ToString());

                        //Find riskReduction en minimalAddition tables and fill them.
                        Microsoft.Office.Interop.Word.Table appliedRiskReductionMeasuresTable = wordInterface.findTableWithTitle(wordDocument, "AppliedRiskReductionMeasures");
                        appliedRiskReductionMeasures.RowFilter = "InProject = '1'";
                        wordInterface.fillTableWithRiskReducingMeasures(wordDocument, appliedRiskReductionMeasuresTable, appliedRiskReductionMeasures, "MeasureSubGroup", "InProject");
                        appliedRiskReductionMeasuresTable.Title = "";

                        Microsoft.Office.Interop.Word.Table minimalAdditionMeasuresTable = wordInterface.findTableWithTitle(wordDocument, "MinimalAdditionMeasures");
                        minimalAdditionMeasures.RowFilter = "InProject = '1'";
                        wordInterface.fillTableWithRiskReducingMeasures(wordDocument, minimalAdditionMeasuresTable, minimalAdditionMeasures, "MeasureSubGroup", "InProject");
                        minimalAdditionMeasuresTable.Title = "";

                        //Calculated PL.
                        wordInterface.searchAndReplace(wordInterface.app, "<SEWeightPL>", plCalculator.plSeverityText((Int32)riskEstimationBeforeView[0]["ItemWeight"]));
                        wordInterface.searchAndReplace(wordInterface.app, "<FRWeightPL>", plCalculator.plFrequencyText((Int32)riskEstimationBeforeView[2]["ItemWeight"]));
                        wordInterface.searchAndReplace(wordInterface.app, "<AVWeightPL>", plCalculator.plPossabilityOfAvoidingText((Int32)riskEstimationBeforeView[3]["ItemWeight"]));

                        char PLr = plCalculator.calculatePerformanceLevel((Int32)riskEstimationBeforeView[0]["ItemWeight"], (Int32)riskEstimationBeforeView[2]["ItemWeight"], (Int32)riskEstimationBeforeView[3]["ItemWeight"]);
                        wordInterface.searchAndReplace(wordInterface.app, "<PerformanceLevel>", PLr.ToString());

                        //Clear some memory.
                        temp.Dispose();
                        temp = null;
                    }
                    //Do we need to cancel execution?
                    if (backgroundWorker1.CancellationPending)
                    {
                        return;
                    }

                    //Remove template from memory.
                    if (riskTemplate != null)
                    {
                        ((_Document)riskTemplate).Close(ref paramFalse, ref missing,
                            ref missing);
                        File.Delete(tempTemplateFile);
                        riskTemplate = null;
                        //Remove plCalculator from memory
                        plCalculator = null;
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.ToString(), "Something went wrong while generating risk pages.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
