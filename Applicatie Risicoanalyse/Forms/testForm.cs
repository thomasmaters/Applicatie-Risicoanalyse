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

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class testForm : Form
    {
        object missing = Type.Missing;
        object paramFalse = false;

        /*public testForm()
        {
            InitializeComponent();

            // To report progress from the background worker we need to set this property
            backgroundWorker1.WorkerReportsProgress = true;
            // This event will be raised on the worker thread when the worker starts
            DoWorkEventArgs eventArgs = new GenerateRiskReportEventArgs(1,new object(), new object());
            backgroundWorker1.DoWork += (obj, e) => generateReport(obj, eventArgs);
            // This event will be raised when we call ReportProgress
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);

            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_WorkerCompleted);
        }

        private void backgroundWorker1_WorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Document generated!", "Completed", MessageBoxButtons.OK);
        }

        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // The progress percentage is a property of e
            progressBar1.Value = e.ProgressPercentage;
        }

        private void testForm_Load(object sender, EventArgs e)
        {
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
            GenerateRiskReportEventArgs e = (GenerateRiskReportEventArgs)args;
            if (e == null)
            {
                throw new Exception("No generate risk report event args parsed");
            }

            Document wordDocument = null;
            Object paramDocPath = "C:\\Users\\Thomas\\Desktop\\Test.docx";

            try
            {
                WordInterface wordInterface = new WordInterface();

                // Open a new document.
                wordDocument = wordInterface.app.Documents.Open(paramDocPath);

                DataRow projectInfoRow = tbl_Risk_AnalysisTableAdapter.GetData().FindByProjectID(e.projectID);

                Document doc2 = wordInterface.app.Documents.Open((object)"C:\\Users\\Thomas\\Desktop\\Test2.docx");
                DataRowCollection riskDataRows = this.get_Risks_With_RiskData_In_ProjectTableAdapter.GetData(e.projectID).Rows;

                //Set generating process.
                backgroundWorker1.ReportProgress(33);
                int currentRisk = 0;
                foreach (DataRow riskDataRow in riskDataRows)
                {
                    //Get the risk data id.
                    int riskDataID = riskDataRow["ProjectRiskDataID"] != DBNull.Value ? (Int32)riskDataRow["ProjectRiskDataID"] : (Int32)riskDataRow["DefaultRiskDataID"];

                    //Get some more info about the risk.
                    DataRow riskData = this.tbl_Risk_DataTableAdapter.GetData().FindByRiskDataID(riskDataID);

                    //Set checkbox controls selected or not.
                    foreach (DataRow exposedPersonRow in this.get_ExposedPersons_In_RiskDataTableAdapter.GetData(riskDataID).Rows)
                    {
                        doc2.SelectContentControlsByTitle(exposedPersonRow["PersonDescription"].ToString())[(object)1].Checked = exposedPersonRow["InProject"].ToString() == "1";
                    }

                    //Copy template.
                    wordInterface.copyDocumentToOtherDocument(doc2, wordDocument, true);
                    wordDocument.Activate();

                    DataRow dangerRow = this.tbl_DangerTableAdapter.GetData().FindByDangerID((Int32)riskData["DangerID"]);
                    DataRow dangerSourceRow = this.tbl_Danger_SourceTableAdapter.GetData().FindByDangerSourceID((Int32)riskData["DangerSourceID"]);
                    DataView dangerResults = new DataView(this.tbl_Danger_ResultTableAdapter.GetData());
                    dangerResults.RowFilter = string.Format("DangerSourceID = {0}", dangerSourceRow["DangerSourceID"].ToString());

                    wordInterface.searchAndReplace(wordInterface.app, "<Hazard>"                       , dangerRow["DangerGroupName"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<HazardSource>"                 , dangerSourceRow["DangerSourceName"].ToString());
                    if(dangerResults.Count > 0)
                        wordInterface.searchAndReplace(wordInterface.app, "<HazardResult1>"            , string.Format("{0}", dangerResults[0]["DangerResultName"].ToString()));
                    else
                        wordInterface.searchAndReplace(wordInterface.app, "<HazardResult1>"            , "");
                    if (dangerResults.Count > 1)
                        wordInterface.searchAndReplace(wordInterface.app, "<HazardResult2>"            , string.Format("{0}", dangerResults[1]["DangerResultName"].ToString()));
                    else
                        wordInterface.searchAndReplace(wordInterface.app, "<HazardResult2>"            , "");

                    //Search and replace headerinfo.
                    wordInterface.searchAndReplace(wordInterface.app, "<CustomerName>"                 , projectInfoRow["Customer"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<MachineInfo>"                  , string.Format("{0}/{1}",projectInfoRow["MachineNumber"].ToString(),projectInfoRow["OrderNumber"].ToString()));
                    wordInterface.searchAndReplace(wordInterface.app, "<RiskID>"                       , riskDataRow["RiskID"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<BriefActionDescription>"       , riskDataRow["HazardSituation"].ToString(),ARA_Colors.ARA_Red);

                    //Search and replace riskdata.
                    wordInterface.searchAndReplace(wordInterface.app, "<RiskGroup>"                    , riskDataRow["GroupName"].ToString() + " - " + riskDataRow["TypeName"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<ActionEvent>"                  , riskData["HazardEvent"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<RiskReductionInfo>"            , riskData["RiskReductionInfo"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<MinimalAdditionInfo>"          , riskData["MinimalAdditionInfo"].ToString());

                    //Set the riskestimation fields.
                    DataView riskEstimationBeforeView = new DataView(this.get_RiskEstimation_In_RiskData_BeforeTableAdapter.GetData(riskDataID));
                    ARA_EditRiskRiskEstimation temp = new ARA_EditRiskRiskEstimation();
                    Color[] riskEstimationColors = { ARA_Colors.ARA_Green, ARA_Colors.ARA_Orange, ARA_Colors.ARA_Red };
                    temp.setControlData(riskEstimationBeforeView);

                    riskEstimationBeforeView.RowFilter = "InProject = '1'";
                    if (riskEstimationBeforeView.Count != 4)
                        throw new Exception("Cant generate report, because a risk isn't correctly filled in " + riskDataID.ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<SEDescriptionB>"               , riskEstimationBeforeView[0]["ItemDescription"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<FRDescriptionB>"               , riskEstimationBeforeView[1]["ItemDescription"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<PRDescriptionB>"               , riskEstimationBeforeView[2]["ItemDescription"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<AVDescriptionB>"               , riskEstimationBeforeView[3]["ItemDescription"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<SEWeightB>"                    , riskEstimationBeforeView[0]["ItemWeight"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<FRWeightB>"                    , riskEstimationBeforeView[1]["ItemWeight"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<PRWeightB>"                    , riskEstimationBeforeView[2]["ItemWeight"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<AVWeightB>"                    , riskEstimationBeforeView[3]["ItemWeight"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<RiskClassValueB>"              , temp.calculateRiskEstimationClass().ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<RiskClassDescriptionB>"        , ARA_Globals.riskClassDescription[temp.calculateRiskEstimationClass()], riskEstimationColors[temp.calculateRiskEstimationClass()]);

                    DataView riskEstimationAfterView = new DataView(this.get_RiskEstimation_In_RiskData_AfterTableAdapter.GetData(riskDataID));
                    temp.setControlData(riskEstimationAfterView);
                    riskEstimationAfterView.RowFilter = "InProject = '1'";
                    if (riskEstimationAfterView.Count != 4)
                        throw new Exception("Cant generate report, because a risk isn't correctly filled in " + riskDataID.ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<SEDescriptionA>"               , riskEstimationAfterView[0]["ItemDescription"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<FRDescriptionA>"               , riskEstimationAfterView[1]["ItemDescription"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<PRDescriptionA>"               , riskEstimationAfterView[2]["ItemDescription"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<AVDescriptionA>"               , riskEstimationAfterView[3]["ItemDescription"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<SEWeightA>"                    , riskEstimationAfterView[0]["ItemWeight"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<FRWeightA>"                    , riskEstimationAfterView[1]["ItemWeight"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<PRWeightA>"                    , riskEstimationAfterView[2]["ItemWeight"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<AVWeightA>"                    , riskEstimationAfterView[3]["ItemWeight"].ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<RiskClassValueA>"              , temp.calculateRiskEstimationClass().ToString());
                    wordInterface.searchAndReplace(wordInterface.app, "<RiskClassDescriptionA>"        , ARA_Globals.riskClassDescription[temp.calculateRiskEstimationClass()], riskEstimationColors[temp.calculateRiskEstimationClass()]);

                    //Clear some memory.
                    temp.Dispose();
                    temp = null;

                    //Find table and do stuff with it.
                    Microsoft.Office.Interop.Word.Table appliedRiskReductionMeasuresTable   = wordInterface.findTableWithTitle(wordDocument, "AppliedRiskReductionMeasures");
                    DataView appliedRiskReductionMeasures                                   = new DataView(this.get_RiskReduction_In_RiskDataTableAdapter.GetData(riskDataID));
                    appliedRiskReductionMeasures.RowFilter                                  = "InProject = '1'";
                    wordInterface.fillTableWithRiskReducingMeasures(wordDocument, appliedRiskReductionMeasuresTable, appliedRiskReductionMeasures, "MeasureSubGroup", "InProject");
                    appliedRiskReductionMeasuresTable.Title                                 = "a";

                    Microsoft.Office.Interop.Word.Table minimalAdditionMeasuresTable        = wordInterface.findTableWithTitle(wordDocument, "MinimalAdditionMeasures");
                    DataView minimalAdditionMeasures                                        = new DataView(this.get_MinimalAddition_In_RiskDataTableAdapter.GetData(riskDataID));
                    minimalAdditionMeasures.RowFilter                                       = "InProject = '1'";
                    wordInterface.fillTableWithRiskReducingMeasures(wordDocument, minimalAdditionMeasuresTable, minimalAdditionMeasures, "MeasureSubGroup", "InProject");
                    minimalAdditionMeasuresTable.Title                                      = "a";

                    //Set generating process
                    backgroundWorker1.ReportProgress(33 + (Int32)((float)currentRisk / (float)riskDataRows.Count * 33));
                    currentRisk++;
                }
                backgroundWorker1.ReportProgress(90);
                doc2.Close();
                // Save the document.
                wordInterface.saveDocument(wordDocument, (string)paramDocPath);
                backgroundWorker1.ReportProgress(100);

                wordInterface.Quit();
                wordInterface = null;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString(),"Something went wrong wile generating.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close and release the Document object.
                if (wordDocument != null)
                {
                    ((_Document)wordDocument).Close(ref paramFalse, ref missing,
                        ref missing);
                    wordDocument = null;
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void testForm_Shown(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }*/
    }
}
