using Applicatie_Risicoanalyse.Globals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class ARA_GenerateReportsForm : Form
    {
        private int projectID = 1;

        public ARA_GenerateReportsForm(int projectID)
        {
            this.projectID = projectID;

            InitializeComponent();

            //Set sorting options for listbox.
            foreach (KeyValuePair<string,string> sortingOption in ARA_Globals.RiskSortingOptions)
            {
                this.generateReportsComboBoxSort.Items.Add(sortingOption.Key as object);
            }

            //Scale form.
            this.Font = new Font("Gotham Light", ARA_Globals.ARA_BaseFontSize);
        }

        private void arA_Button2_Click(object sender, EventArgs e)
        {
            if(this.generateReportsComboBoxSort.SelectedItem == null)
            {
                System.Windows.Forms.MessageBox.Show("Select a sorting option before generating any report!", "Sorting option missing.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Debug.WriteLine(this.generateReportsComboBoxSort.SelectedItem);
                RiskAssesmentReport report = new RiskAssesmentReport(this.projectID, this.generateReportsComboBoxSort.SelectedItem.ToString(), this.folderBrowserDialog1.SelectedPath.ToString() + "\\RiskAssessmentReport.docx",
                     Applicatie_Risicoanalyse.Properties.Resources.RiskAssessmentRiskPageTemplate,
                     Applicatie_Risicoanalyse.Properties.Resources.RiskAssessmentIndexPageTemplate,
                     Applicatie_Risicoanalyse.Properties.Resources.RiskAssessmentFrontPageTemplate);
                 report.Show();
            }
        }
    }
}
