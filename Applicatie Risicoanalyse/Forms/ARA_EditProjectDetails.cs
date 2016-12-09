using Applicatie_Risicoanalyse.Globals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class ARA_EditProjectDetails : Form
    {
        private int projectID = -1;

        public ARA_EditProjectDetails(int projectID)
        {
            this.projectID = projectID;

            InitializeComponent();

            //Set scaling.
            this.Font = new System.Drawing.Font(ARA_Globals.ARA_Font, Applicatie_Risicoanalyse.Globals.ARA_Globals.ARA_BaseFontSize);

            //Fix for text scaling of form.
            System.Drawing.Font textFont = new System.Drawing.Font(ARA_Globals.ARA_Font, Applicatie_Risicoanalyse.Globals.ARA_Globals.ARA_BaseFontSize - 3F);
            this.editProjectDetailsTextCustomer.Font = textFont;
            this.editProjectDetailsTextExtraInfo.Font = textFont;
            this.editProjectDetailsTextMachineNumber.Font = textFont;
            this.editProjectDetailsTextMachineType.Font = textFont;
            this.editProjectDetailsTextOrderNumber.Font = textFont;
        }

        /// <summary>
        /// Handler when the user wants to save the new project details.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createProjectButtonCreateProject_Click(object sender, EventArgs e)
        {
            if(canProjectDetailsBeChanged())
            {
                //Execute query for updating project details.
                this.queriesTableAdapter1.Update_ProjectDetails(this.projectID,
                    this.editProjectDetailsInputCustomer.Text,
                    this.editProjectDetailsInputMachineType.Text,
                    this.editProjectDetailsInputMachineNumber.Text,
                    this.editProjectDetailsInputOrderNumber.Text,
                    this.editProjectDetailsInputExtraInfo.Text);

                //Trigger event.
                ARA_Events.triggerProjectDetailsChangedEvent(this.projectID);

                //Let the user know we updated the project details.
                MessageBox.Show(ARA_Constants.messageBoxProjectDetailsSaved, ARA_Constants.messageBoxProjectDetailsSavedHeader, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Could not update the project details, some input fields are not correctly filled.
                MessageBox.Show(ARA_Constants.messageBoxProjectDetailsFailed, ARA_Constants.messageBoxProjectDetailsFailedHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ARA_EditProjectDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Risk_Analysis' table. You can move, or remove it, as needed.
            this.tbl_Risk_AnalysisTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Risk_Analysis);

            setProjectDataForControls();
        }

        /// <summary>
        /// Sets the project info for the controls.
        /// </summary>
        private void setProjectDataForControls()
        {
            DataRow projectData                            = this.tbl_Risk_AnalysisTableAdapter.GetData().FindByProjectID(this.projectID);
            this.editProjectDetailsInputCustomer.Text      = projectData["Customer"].ToString();
            this.editProjectDetailsInputMachineNumber.Text = projectData["MachineNumber"].ToString();
            this.editProjectDetailsInputMachineType.Text   = projectData["MachineType"].ToString();
            this.editProjectDetailsInputExtraInfo.Text     = projectData["Info"].ToString();
            this.editProjectDetailsInputOrderNumber.Text   = projectData["OrderNumber"].ToString();
        }

        /// <summary>
        /// Checks if the input fields are correctly filled.
        /// </summary>
        /// <returns></returns>
        private bool canProjectDetailsBeChanged()
        {
            return this.editProjectDetailsInputCustomer.Text.Length > 0 &&
                this.editProjectDetailsInputMachineNumber.Text.Length > 0 &&
                this.editProjectDetailsInputMachineType.Text.Length > 0 &&
                this.editProjectDetailsInputOrderNumber.Text.Length > 0;
        }
    }
}
