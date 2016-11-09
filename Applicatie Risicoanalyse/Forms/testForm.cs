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
using Applicatie_Risicoanalyse.Controls;
using Applicatie_Risicoanalyse.Globals;
using Applicatie_Risicoanalyse.Reports.RiskAssesmentReport;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class testForm : Form
    {
        public testForm()
        {
            InitializeComponent();
            
        }

        private void testForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Risks_In_Project' table. You can move, or remove it, as needed.
            this.tbl_Risks_In_ProjectTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Risks_In_Project);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Risk_Analysis' table. You can move, or remove it, as needed.
            this.tbl_Risk_AnalysisTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Risk_Analysis);

            RiskAssesmentReport temp = new RiskAssesmentReport("RiskAssesmentReport.pdf");
            temp.documentCreateProcedure();

            //this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Project",this.tbl_Risk_AnalysisBindingSource));
            //this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("RiskInProject", this.tbl_Risks_In_ProjectBindingSource));
            //this.reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameter1","Test"));
            //this.reportViewer1.RefreshReport();
        }
    }
}
