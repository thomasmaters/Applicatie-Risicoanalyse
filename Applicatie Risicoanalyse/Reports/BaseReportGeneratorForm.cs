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
    public partial class BaseReportGeneratorForm : Form
    {
        protected object missing = Type.Missing;
        protected object paramFalse = false;
        protected Object threadLock = new object();
        public BaseReportGeneratorForm()
        {
            InitializeComponent();
        }

        public void runBackgroundWorker(DoWorkEventArgs args)
        {
            // To report progress from the background worker we need to set this property.
            backgroundWorker1.WorkerReportsProgress = true;
            // Enabled cancelation of thread progress.
            backgroundWorker1.WorkerSupportsCancellation = true;
            //Attach eventargs to backgroundworker.
            backgroundWorker1.DoWork += (obj, e) => generateReport(obj, args);
            // This event will be raised when we call ReportProgress.
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            //Do something when the background worker completes.
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_WorkerCompleted);
        }

        private void backgroundWorker1_WorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                System.Windows.Forms.MessageBox.Show(ARA_Constants.messageBoxDocumentsGenerated, ARA_Constants.messageBoxDocumentsGeneratedHeader, MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        /// <summary>
        /// Sets the documents watermark based on the projectstate.
        /// </summary>
        /// <param name="wordInterface"></param>
        /// <param name="wordDocument"></param>
        /// <param name="projectState"></param>
        protected void setWaterMark(WordInterface wordInterface, Document wordDocument, string projectState, string draftVersion = "")
        {
            //Set watermark text based on project state.
            if (projectState == ARA_Constants.draft)
            {
                wordInterface.insertWatermarkText(wordDocument, "DRAFT-" + draftVersion);
            }
            else if (projectState == ARA_Constants.forReview)
            {
                wordInterface.insertWatermarkText(wordDocument, "REVIEW ");
            }
            else if (projectState == ARA_Constants.finalDraft)
            {
                wordInterface.insertWatermarkText(wordDocument, "FINAL DRAFT");
            }
        }

        private void RarButtonCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
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

        protected virtual void generateReport(object sender, DoWorkEventArgs args)
        {

        }
    }
}
