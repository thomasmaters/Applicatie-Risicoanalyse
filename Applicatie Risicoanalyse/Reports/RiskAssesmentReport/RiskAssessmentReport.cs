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
    public partial class RiskAssessmentReport : Applicatie_Risicoanalyse.Forms.BaseReportGeneratorForm
    {
        public RiskAssessmentReport(int projectID, string sortingKey, object newDocumentLocation, byte[] riskPageTemplateLocation, byte[] indexPageTemplateLocation, byte[] frontPageTemplateLocation)
        {
            // This event will be raised on the worker thread when the worker starts.
            DoWorkEventArgs eventArgs = new GenerateRiskReportEventArgs(projectID, sortingKey, newDocumentLocation, riskPageTemplateLocation, indexPageTemplateLocation, frontPageTemplateLocation);
            this.runBackgroundWorker(eventArgs);
            InitializeComponent();
        }

        protected override void generateReport(object sender, DoWorkEventArgs args)
        {
            GenerateRiskReportEventArgs e = args as GenerateRiskReportEventArgs;
            if (e == null)
            {
                throw new Exception("No generate risk report event args parsed");
            }

            Document wordDocument = null;

            //Create a word interface so we can talk easylie to word.
            WordInterface wordInterface = new WordInterface();

            try
            {
                // Open a new document.
                FileStream newDocument = File.Create((string)e.newDocumentLocation + ".docx");
                newDocument.Close();
                newDocument = null;

                wordDocument = wordInterface.app.Documents.Open(e.newDocumentLocation + ".docx");

                //Get some data out of the database.
                DataRow projectInfoRow = get_All_RiskProject_InfoTableAdapter.GetData(e.projectID).Rows[0];
                DataView riskDataRows = new DataView(this.get_Risks_With_RiskData_In_ProjectTableAdapter.GetData(e.projectID));
                riskDataRows.Sort = ARA_Globals.RiskSortingOptions[e.sortingKey];

                //Set generating process.

                backgroundWorker1.ReportProgress(5, (object)"Generating front page.");

                generateFrontPage(e.frontPageTemplateLocation, wordInterface, wordDocument, projectInfoRow);

                backgroundWorker1.ReportProgress(10, (object)"Generating index page.");

                generateIndexPage(e.indexPageTemplateLocation, wordInterface, wordDocument, e.projectID);

                backgroundWorker1.ReportProgress(15, (object)"Generating risk pages.");

                generateRiskPages(e.riskPageTemplateLocation, wordInterface, wordDocument, riskDataRows, projectInfoRow);

                backgroundWorker1.ReportProgress(68, (object)"Adding watermarks(if needed).");

                this.setWaterMark(wordInterface, wordDocument, projectInfoRow["StateName"].ToString(), projectInfoRow["DraftVersion"].ToString());

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
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ARA_Constants.messageBoxSomethingWrongWhileGenerating +  ex.ToString(), ARA_Constants.messageBoxSomethingWrongWhileGeneratingHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //Clean the word interface.
            wordInterface.Quit();
            wordInterface = null;
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

        private void generateIndexPage(byte[] templateLocation, WordInterface wordInterface, Document wordDocument, int projectID)
        {
            lock (this.threadLock)
            {
                try
                {
                    //Open the template from a temporary file.
                    String tempTemplateFile = Path.GetTempFileName();
                    File.WriteAllBytes(tempTemplateFile, templateLocation);
                    Document indexPageTemplate = wordInterface.app.Documents.Open(tempTemplateFile);

                    //Copy template to main document.
                    wordInterface.copyDocumentToOtherDocument(indexPageTemplate, wordDocument, false);
                    wordDocument.Activate();

                    //Find index table template.
                    Microsoft.Office.Interop.Word.Table tableTemplate = wordInterface.findTableWithTitle(wordDocument, "riskAssessmentIndex");
                    if (tableTemplate == null)
                    {
                        throw new Exception("Could not find riskAssessmentIndex table. Check your template.");
                    }

                    //Do not allow the column size to change.
                    tableTemplate.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitFixed);

                    //Get all dagners from the database.
                    DataView dangersView = new DataView(this.tbl_DangerTableAdapter.GetData());

                    //Loop throug the dangers.
                    foreach (DataRowView dangerRow in dangersView)
                    {
                        //Get some dangersource data from the database.
                        int oldPageCount = wordDocument.ComputeStatistics(WdStatistic.wdStatisticPages);
                        string lastDangerSourceName = "";
                        DataView dangerSourceView = new DataView(this.get_RiskAssessment_Index_DataTableAdapter.GetData(projectID, (Int32)dangerRow["DangerID"]));

                        //Copy table and set the header.
                        Table indexTable = wordInterface.copyTable(wordDocument, tableTemplate.Range);
                        indexTable.Rows[1].Range.Text = dangerRow["DangerGroupName"].ToString();

                        //Add danger sources to the danger group.
                        foreach (DataRowView dangerSourceRow in dangerSourceView)
                        {
                            Row newTableRow;
                            //Create new row when we get a different dangersource then the previous.
                            if (lastDangerSourceName != dangerSourceRow["DangerSourceName"].ToString())
                            {
                                lastDangerSourceName = dangerSourceRow["DangerSourceName"].ToString();
                                newTableRow = indexTable.Rows.Add(ref missing);
                            }
                            else
                            {
                                newTableRow = indexTable.Rows.Last;
                            }

                            newTableRow.Cells[1].Range.Text = lastDangerSourceName;
                            //Does this dangersource has an risk associated with it?
                            if (dangerSourceRow["RiskID"] != DBNull.Value)
                            {
                                newTableRow.Cells[2].Range.Text = "YES";
                                wordInterface.addTextToTableCell(newTableRow.Cells[3].Range, dangerSourceRow["RiskID"].ToString(), true);
                            }
                            else
                            {
                                newTableRow.Cells[2].Range.Text = "NO";
                            }

                            //Does this dangersource has risks with remaining risk?
                            if (dangerSourceRow["HasRemainingRisk"] != DBNull.Value)
                            {
                                wordInterface.addTextToTableCell(newTableRow.Cells[4].Range, dangerSourceRow["HasRemainingRisk"].ToString(), true);
                            }
                        }
                        //Delete our row template.
                        indexTable.Rows[3].Delete();
                        wordInterface.setAlternatingTableRowStyle(indexTable, ARA_Colors.ARA_Blue1,4);

                        //Set table on a new pages when it stretches over 2 pages.
                        if(oldPageCount < wordDocument.ComputeStatistics(WdStatistic.wdStatisticPages))
                        {
                            Range tableRange = indexTable.Range;
                            tableRange.SetRange(indexTable.Range.Start - 2, indexTable.Range.Start);
                            wordInterface.insertPageBreakAtRange(indexTable.Range);
                        }
                    }

                    //Delete a trailing enter after our template table.
                    Range rng = tableTemplate.Range;
                    rng.SetRange(rng.End, rng.End + 2);
                    rng.Delete();

                    //Delete our template table and insert a pagebreak.
                    tableTemplate.Delete();
                    wordInterface.insertPageBreakAtRange(wordDocument.Words.Last);

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
                    System.Windows.Forms.MessageBox.Show(ARA_Constants.messageBoxSomethingWrongWhileGenerating + ex.ToString(), ARA_Constants.messageBoxSomethingWrongWhileGeneratingHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        DataRow authorRow = this.tbl_UserTableAdapter.GetData().FindByUserID((Int32)projectInfoRow["UserID"]);

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

                        riskEstimationBeforeView.RowFilter = "InProject = '1'";
                        if (riskEstimationBeforeView.Count != 4)
                            throw new Exception("Cant generate report, because a risk isn't correctly filled in " + riskDataID.ToString());
                        wordInterface.searchAndReplace(wordDocument, "<SEDescriptionB>", riskEstimationBeforeView[0]["ItemDescription"].ToString());
                        wordInterface.searchAndReplace(wordDocument, "<FRDescriptionB>", riskEstimationBeforeView[1]["ItemDescription"].ToString());
                        wordInterface.searchAndReplace(wordDocument, "<PRDescriptionB>", riskEstimationBeforeView[2]["ItemDescription"].ToString());
                        wordInterface.searchAndReplace(wordDocument, "<AVDescriptionB>", riskEstimationBeforeView[3]["ItemDescription"].ToString());
                        wordInterface.searchAndReplace(wordDocument, "<SEWeightB>", riskEstimationBeforeView[0]["ItemWeight"].ToString());
                        wordInterface.searchAndReplace(wordDocument, "<FRWeightB>", riskEstimationBeforeView[1]["ItemWeight"].ToString());
                        wordInterface.searchAndReplace(wordDocument, "<PRWeightB>", riskEstimationBeforeView[2]["ItemWeight"].ToString());
                        wordInterface.searchAndReplace(wordDocument, "<AVWeightB>", riskEstimationBeforeView[3]["ItemWeight"].ToString());
                        wordInterface.searchAndReplace(wordDocument, "<RiskClassValueB>", temp.calculateRiskEstimationClass().ToString());
                        wordInterface.searchAndReplace(wordDocument, "<RiskClassDescriptionB>", ARA_Globals.RiskClassDescription[temp.calculateRiskEstimationClass()], riskEstimationColors[temp.calculateRiskEstimationClass()]);

                        temp.setControlData(riskEstimationAfterView);
                        riskEstimationAfterView.RowFilter = "InProject = '1'";
                        if (riskEstimationAfterView.Count != 4)
                            throw new Exception("Cant generate report, because a risk isn't correctly filled in " + riskDataID.ToString());
                        wordInterface.searchAndReplace(wordDocument, "<SEDescriptionA>", riskEstimationAfterView[0]["ItemDescription"].ToString());
                        wordInterface.searchAndReplace(wordDocument, "<FRDescriptionA>", riskEstimationAfterView[1]["ItemDescription"].ToString());
                        wordInterface.searchAndReplace(wordDocument, "<PRDescriptionA>", riskEstimationAfterView[2]["ItemDescription"].ToString());
                        wordInterface.searchAndReplace(wordDocument, "<AVDescriptionA>", riskEstimationAfterView[3]["ItemDescription"].ToString());
                        wordInterface.searchAndReplace(wordDocument, "<SEWeightA>", riskEstimationAfterView[0]["ItemWeight"].ToString());
                        wordInterface.searchAndReplace(wordDocument, "<FRWeightA>", riskEstimationAfterView[1]["ItemWeight"].ToString());
                        wordInterface.searchAndReplace(wordDocument, "<PRWeightA>", riskEstimationAfterView[2]["ItemWeight"].ToString());
                        wordInterface.searchAndReplace(wordDocument, "<AVWeightA>", riskEstimationAfterView[3]["ItemWeight"].ToString());
                        wordInterface.searchAndReplace(wordDocument, "<RiskClassValueA>", temp.calculateRiskEstimationClass().ToString());
                        wordInterface.searchAndReplace(wordDocument, "<RiskClassDescriptionA>", ARA_Globals.RiskClassDescription[temp.calculateRiskEstimationClass()], riskEstimationColors[temp.calculateRiskEstimationClass()]);

                        //Find table and do stuff with it.
                        Microsoft.Office.Interop.Word.Table appliedRiskReductionMeasuresTable = wordInterface.findTableWithTitle(wordDocument, "AppliedRiskReductionMeasures");
                        appliedRiskReductionMeasures.RowFilter = "InProject = '1'";
                        wordInterface.fillTableWithRiskReducingMeasures(wordDocument, appliedRiskReductionMeasuresTable, appliedRiskReductionMeasures, "MeasureSubGroup", "InProject");
                        appliedRiskReductionMeasuresTable.Title = "";

                        Microsoft.Office.Interop.Word.Table minimalAdditionMeasuresTable = wordInterface.findTableWithTitle(wordDocument, "MinimalAdditionMeasures");
                        minimalAdditionMeasures.RowFilter = "InProject = '1'";
                        wordInterface.fillTableWithRiskReducingMeasures(wordDocument, minimalAdditionMeasuresTable, minimalAdditionMeasures, "MeasureSubGroup", "InProject");
                        minimalAdditionMeasuresTable.Title = "";

                        //Set author en reviewer names.
                        wordInterface.searchAndReplace(wordDocument, "<AuthorName>", authorRow["UserName"].ToString(), new Color(), true);
                        //Did someone review this risk?
                        if (riskDataRow["ReviewedByUser"] != DBNull.Value)
                        {
                            DataRow reviewerRow = this.tbl_UserTableAdapter.GetData().FindByUserID((Int32)riskDataRow["ReviewedByUser"]);
                            wordInterface.searchAndReplace(wordDocument, "<ReviewerName>", reviewerRow["UserName"].ToString(), new Color(), true);
                        }
                        else
                        {
                            wordInterface.searchAndReplace(wordDocument, "<ReviewerName>", "NOT REVIEWED", new Color(), true);
                        }

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
                    System.Windows.Forms.MessageBox.Show(ARA_Constants.messageBoxSomethingWrongWhileGenerating +  ex.ToString(), ARA_Constants.messageBoxSomethingWrongWhileGeneratingHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
