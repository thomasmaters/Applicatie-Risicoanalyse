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

namespace Applicatie_Risicoanalyse.Reports
{
    public partial class RemainingRiskReport : Applicatie_Risicoanalyse.Forms.BaseReportGeneratorForm
    {
        public RemainingRiskReport(int projectID, string sortingKey, object newDocumentLocation, byte[] remainingRiskHeaderPageTemplateLocation, byte[] remainingRiskPageTemplateLocation, byte[] indexPageTemplateLocation, byte[] frontPageTemplateLocation)
        {
            // This event will be raised on the worker thread when the worker starts.
            DoWorkEventArgs eventArgs = new GenerateRemainingRiskReportEvent(projectID, sortingKey, newDocumentLocation, remainingRiskHeaderPageTemplateLocation, remainingRiskPageTemplateLocation, indexPageTemplateLocation, frontPageTemplateLocation);
            this.runBackgroundWorker(eventArgs);
            InitializeComponent();
        }

        protected override void generateReport(object sender, DoWorkEventArgs args)
        {
            GenerateRemainingRiskReportEvent e = args as GenerateRemainingRiskReportEvent;
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
                FileStream newDocument = File.Create((string)e.newDocumentLocation + ".docx");
                newDocument.Close();
                newDocument = null;

                wordDocument = wordInterface.app.Documents.Open(e.newDocumentLocation + ".docx");

                DataRow projectInfoRow = this.tbl_Risk_AnalysisTableAdapter.GetData().FindByProjectID(e.projectID);
                DataView riskDataRows = new DataView(this.get_RemainingRisks_In_ProjectTableAdapter.GetData(e.projectID));

                riskDataRows.Sort = ARA_Globals.RiskSortingOptions[e.sortingKey];

                //Set generating process.

                backgroundWorker1.ReportProgress(5, (object)"Generating front page.");

                generateFrontPage(e.frontPageTemplateLocation, wordInterface, wordDocument, projectInfoRow);

                backgroundWorker1.ReportProgress(10, (object)"Generating page index.");

                //generateIndexPage(e.indexPageTemplateLocation, wordInterface, wordDocument,riskDataRows);

                backgroundWorker1.ReportProgress(15, (object)"Generating risk pages.");

                generateRemainingRiskPages(e.remainingRiskHeaderPageTemplateLocation, e.remainingRiskPageTemplateLocation, wordInterface, wordDocument, riskDataRows, projectInfoRow);

                backgroundWorker1.ReportProgress(68, (object)"Adding watermarks(if needed).");

                setWaterMark(wordInterface, wordDocument, projectInfoRow["StateName"].ToString(), projectInfoRow["DraftVersion"].ToString());

                backgroundWorker1.ReportProgress(70, (object)"Saving the document.");

                wordInterface.saveDocument(wordDocument, (string)e.newDocumentLocation);

                backgroundWorker1.ReportProgress(90, (object)"Converting document to pdf.");

                wordInterface.saveDocumentAsPdf(wordDocument, (string)e.newDocumentLocation);

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
                System.Windows.Forms.MessageBox.Show(ARA_Constants.messageBoxSomethingWrongWhileGenerating + ex.ToString(), ARA_Constants.messageBoxSomethingWrongWhileGeneratingHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                wordDocument.Close();
                wordDocument = null;
            }
        }

        private void generateIndexPage(byte[] templateLocation, WordInterface wordInterface, Document wordDocument, DataView riskDataRows)
        {
            lock (this.threadLock)
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
                    if (indexTable == null)
                    {
                        throw new Exception("Could not find riskAssessmentIndex table. Check your template.");
                    }

                    DataView minimalAdditionView = new DataView(this.tbl_MinimalAddition_In_RiskTableAdapter.GetData());

                    //Fill index table.
                    foreach (DataRowView riskDataRow in riskDataRows)
                    {
                        int riskDataID = riskDataRow["ProjectRiskDataID"] != DBNull.Value ? (Int32)riskDataRow["ProjectRiskDataID"] : (Int32)riskDataRow["DefaultRiskDataID"];

                        Row newTableRow = indexTable.Rows.Add(ref missing);
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
        }

        private void generateFrontPage(byte[] templateLocation, WordInterface wordInterface, Document wordDocument, DataRow projectInfoRow)
        {
            lock (this.threadLock)
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
                    wordInterface.searchAndReplace(wordDocument, "<CustomerName>", projectInfoRow["Customer"].ToString());
                    wordInterface.searchAndReplace(wordDocument, "<MachineNumber>", projectInfoRow["MachineNumber"].ToString());
                    wordInterface.searchAndReplace(wordDocument, "<OrderNumber>", projectInfoRow["OrderNumber"].ToString());
                    wordInterface.searchAndReplace(wordDocument, "<MachineType>", projectInfoRow["MachineType"].ToString());
                    wordInterface.searchAndReplace(wordDocument, "<CurrentDate>", ARA_Globals.ARa_Date);

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

        private void generateRemainingRiskPages(byte[] headerTemplateLocation, byte[] templateLocation, WordInterface wordInterface, Document wordDocument, DataView riskDataRows, DataRow projectInfoRow)
        {
            lock (this.threadLock)
            {
                int currentRisk = 0;
                try
                {
                    //Open template documents.
                    String tempHeaderTemplateFile = Path.GetTempFileName();
                    String tempTemplateFile = Path.GetTempFileName();
                    File.WriteAllBytes(tempHeaderTemplateFile, headerTemplateLocation);
                    File.WriteAllBytes(tempTemplateFile, templateLocation);
                    Document remainingRiskHeaderTemplate = wordInterface.app.Documents.Open(tempHeaderTemplateFile);
                    Document remainingRiskTemplate = wordInterface.app.Documents.Open(tempTemplateFile);

                    foreach (DataRowView riskDataRow in riskDataRows)
                    {
                        //Set generating process
                        backgroundWorker1.ReportProgress(
                            33 + (Int32)((float)currentRisk / (float)riskDataRows.Count * 33),
                            (object)string.Format("Generating page {0} of {1}.", currentRisk + 1, riskDataRows.Count)
                        );
                        currentRisk++;

                        //Get the risk data id and set some variables.
                        int riskDataID = (Int32)riskDataRow["RiskDataID"];
                        Color[] riskEstimationColors = { ARA_Colors.ARA_Green, ARA_Colors.ARA_Orange, ARA_Colors.ARA_Red };

                        //Get some more info about the risk.
                        DataRow riskData = this.tbl_Risk_DataTableAdapter.GetData().FindByRiskDataID(riskDataID);

                        DataView riskEstimationBeforeView = new DataView(this.get_RiskEstimation_In_RiskData_BeforeTableAdapter.GetData(riskDataID));
                        DataView riskEstimationAfterView = new DataView(this.get_RiskEstimation_In_RiskData_AfterTableAdapter.GetData(riskDataID));
                        DataView appliedRiskReductionMeasures = new DataView(this.get_RiskReduction_In_RiskDataTableAdapter.GetData(riskDataID));
                        DataView minimalAdditionMeasures = new DataView(this.get_MinimalAddition_In_RiskDataTableAdapter.GetData(riskDataID));

                        //Set some value's before copying document.
                        remainingRiskTemplate.Activate();
                        foreach (DataRow exposedPersonRow in this.get_ExposedPersons_In_RiskDataTableAdapter.GetData(riskDataID).Rows)
                        {
                            remainingRiskTemplate.SelectContentControlsByTitle(exposedPersonRow["PersonDescription"].ToString())[(object)1].Checked = exposedPersonRow["InProject"].ToString() == "1";
                        }

                        //Copy template.
                        if (currentRisk % 2 == 1)
                        {
                            wordInterface.copyDocumentToOtherDocument(remainingRiskHeaderTemplate, wordDocument, false);
                            wordInterface.copyDocumentToOtherDocument(remainingRiskTemplate, wordDocument, false);
                        }
                        else
                        {
                            wordInterface.copyDocumentToOtherDocument(remainingRiskTemplate, wordDocument, true);
                        }
                        wordDocument.Activate();

                        //Sets the risk hazard specifications.
                        generateHazardIndentification(wordInterface, wordDocument,(Int32)riskData["DangerID"], (Int32)riskData["DangerSourceID"]);

                        //Search and replace headerinfo.
                        wordInterface.searchAndReplace(wordDocument, "<CustomerName>", projectInfoRow["Customer"].ToString());
                        wordInterface.searchAndReplace(wordDocument, "<MachineInfo>", string.Format("{0}/{1}", projectInfoRow["MachineNumber"].ToString(), projectInfoRow["OrderNumber"].ToString()));
                        wordInterface.searchAndReplace(wordDocument, "<RiskID>", riskDataRow["RiskID"].ToString());
                        wordInterface.searchAndReplace(wordDocument, "<BriefActionDescription>", riskDataRow["HazardSituation"].ToString(), ARA_Colors.ARA_Red);

                        //Search and replace riskdata.
                        wordInterface.searchAndReplace(wordDocument, "<RiskGroup>", string.Format("{0} - {1}", riskDataRow["GroupName"].ToString(), riskDataRow["TypeName"].ToString()));
                        wordInterface.searchAndReplace(wordDocument, "<ActionEvent>", riskData["HazardEvent"].ToString());
                        wordInterface.searchAndReplace(wordDocument, "<RiskReductionInfo>", riskData["RiskReductionInfo"].ToString());
                        wordInterface.searchAndReplace(wordDocument, "<MinimalAdditionInfo>", riskData["MinimalAdditionInfo"].ToString());

                        //Set the riskestimation fields.
                        ARA_EditRiskRiskEstimation temp = new ARA_EditRiskRiskEstimation();
                        temp.setControlData(riskEstimationBeforeView);

                        //Set risk class fields.
                        riskEstimationBeforeView.RowFilter = "InProject = '1'";
                        if (riskEstimationBeforeView.Count != 4)
                            throw new Exception("Cant generate report, because a risk isn't correctly filled in " + riskDataID.ToString());
                        wordInterface.searchAndReplace(wordDocument, "<RiskClassValueB>", temp.calculateRiskEstimationClass().ToString());
                        wordInterface.searchAndReplace(wordDocument, "<RiskClassDescriptionB>", ARA_Globals.RiskClassDescription[temp.calculateRiskEstimationClass()], riskEstimationColors[temp.calculateRiskEstimationClass()]);

                        temp.setControlData(riskEstimationAfterView);
                        riskEstimationAfterView.RowFilter = "InProject = '1'";
                        if (riskEstimationAfterView.Count != 4)
                            throw new Exception("Cant generate report, because a risk isn't correctly filled in " + riskDataID.ToString());
                        wordInterface.searchAndReplace(wordDocument, "<RiskClassValueA>", temp.calculateRiskEstimationClass().ToString());
                        wordInterface.searchAndReplace(wordDocument, "<RiskClassDescriptionA>", ARA_Globals.RiskClassDescription[temp.calculateRiskEstimationClass()], riskEstimationColors[temp.calculateRiskEstimationClass()]);

                        //Find minimal addition options table and fill it.
                        Microsoft.Office.Interop.Word.Table minimalAdditionMeasuresTable = wordInterface.findTableWithTitle(wordDocument, "MinimalAdditionMeasures");
                        minimalAdditionMeasures.RowFilter = "InProject = '1'";
                        wordInterface.fillTableWithRiskReducingMeasures(wordDocument, minimalAdditionMeasuresTable, minimalAdditionMeasures, "MeasureSubGroup", "InProject");
                        minimalAdditionMeasuresTable.Title = "";

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
                    if (remainingRiskTemplate != null)
                    {
                        ((_Document)remainingRiskTemplate).Close(ref paramFalse, ref missing,
                            ref missing);
                        File.Delete(tempTemplateFile);
                        remainingRiskTemplate = null;
                    }
                    //Remove headerTemplate from memory.
                    if (remainingRiskHeaderTemplate != null)
                    {
                        ((_Document)remainingRiskHeaderTemplate).Close(ref paramFalse, ref missing,
                            ref missing);
                        File.Delete(tempHeaderTemplateFile);
                        remainingRiskHeaderTemplate = null;
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
