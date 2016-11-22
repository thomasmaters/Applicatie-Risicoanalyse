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
using System.Threading;
using Applicatie_Risicoanalyse.Globals;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class ARA_RiskProjectOverview : Form
    {
        private int projectID = 1;

        public ARA_RiskProjectOverview(int projectID)
        {
            this.projectID = projectID;
            InitializeComponent();

            //Attach an layoutPanel to the button.
            this.riskProjectOverviewButtonOpenRisk.setConnectedPanel(this.riskProjectOverviewPanelOpenRisk);
            this.riskProjectOverviewButtonAddRiskToProject.setConnectedPanel(this.riskProjectOverviewPanelAddRiskToProject);
            this.riskProjectOverviewButtonEditProjectDetails.setConnectedPanel(this.riskProjectOverviewPanelEditProjectDetails);
            this.riskProjectOverviewButtonGenerateReports.setConnectedPanel(this.riskProjectOverviewPanelGenerateReports);
            //Add Click event to hide all other buttons/panels when one opens.
            this.riskProjectOverviewButtonOpenRisk.Click += hideOtherPanels;
            this.riskProjectOverviewButtonAddRiskToProject.Click += hideOtherPanels;
            this.riskProjectOverviewButtonEditProjectDetails.Click += hideOtherPanels;
            this.riskProjectOverviewButtonGenerateReports.Click += hideOtherPanels;
        }

        private void loadPermissions()
        {
            this.riskProjectOverviewButtonAddRiskToProject.Visible      = ARA_ACL.getPermissionLevel("General.ButtonAddRiskToProject") >= ARA_Globals.PermissionLevel.ReadOnly;
            this.riskProjectOverviewPanelAddRiskToProject.Visible       = ARA_ACL.getPermissionLevel("General.ButtonAddRiskToProject") >= ARA_Globals.PermissionLevel.ReadOnly;
            this.riskProjectOverviewPanelAddRiskToProject.Enabled       = ARA_ACL.getPermissionLevel("General.ButtonAddRiskToProject") == ARA_Globals.PermissionLevel.All;

            this.riskProjectOverviewButtonEditProjectDetails.Visible    = ARA_ACL.getPermissionLevel("General.ButtonEditProjectDetails") >= ARA_Globals.PermissionLevel.ReadOnly;
            this.riskProjectOverviewPanelEditProjectDetails.Visible     = ARA_ACL.getPermissionLevel("General.ButtonEditProjectDetails") >= ARA_Globals.PermissionLevel.ReadOnly;
            this.riskProjectOverviewPanelEditProjectDetails.Enabled     = ARA_ACL.getPermissionLevel("General.ButtonEditProjectDetails") == ARA_Globals.PermissionLevel.All;

            this.riskProjectOverviewButtonOpenRisk.Visible              = ARA_ACL.getPermissionLevel("General.ButtonOpenRisk") >= ARA_Globals.PermissionLevel.ReadOnly;
            this.riskProjectOverviewPanelOpenRisk.Visible               = ARA_ACL.getPermissionLevel("General.ButtonOpenRisk") >= ARA_Globals.PermissionLevel.ReadOnly;
            this.riskProjectOverviewPanelOpenRisk.Enabled               = ARA_ACL.getPermissionLevel("General.ButtonOpenRisk") == ARA_Globals.PermissionLevel.All;
        }

        private void addFormToPanel(FlowLayoutPanel panel, System.Windows.Forms.Form form)
        {
            form.TopLevel = false;
            panel.Controls.Add(form);
            form.Show();
        }

        private void hideOtherPanels(object sender, EventArgs e)
        {
            foreach (var button in this.flowLayoutPanel1.Controls.OfType<Applicatie_Risicoanalyse.Controls.ARA_DropDownButton>())
            {
                if(button != sender)
                {
                    button.setButtonSelected(false);
                }
            }
        }

        private void onProjectOverviewLoad(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Project' table. You can move, or remove it, as needed.
            this.tbl_ProjectTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Project);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Risk_Analysis' table. You can move, or remove it, as needed.
            this.tbl_Risk_AnalysisTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Risk_Analysis);
            this.Font = new System.Drawing.Font("Gotham Light", Applicatie_Risicoanalyse.Globals.ARA_Globals.ARA_BaseFontSize);

            this.addFormToPanel(this.riskProjectOverviewPanelAddRiskToProject, new ARA_AddRisksToProject(projectID));
            this.addFormToPanel(this.riskProjectOverviewPanelOpenRisk, new ARA_OpenRiskInProject(projectID));
            this.addFormToPanel(this.riskProjectOverviewPanelGenerateReports, new ARA_GenerateReportsForm(projectID));

            loadPermissions();

            enableControlOnProjectState();
        }

        private void enableControlOnProjectState()
        {

            string projectState = this.tbl_Risk_AnalysisTableAdapter.GetData().FindByProjectID(this.projectID)["StateName"].ToString();
            int userID = (Int32)this.tbl_ProjectTableAdapter.GetData().FindByProjectID(this.projectID)["UserID"];
            if (projectState != ARA_Constants.draft)
            {
                this.riskProjectOverviewButtonAddRiskToProject.Enabled = false;
                this.riskProjectOverviewButtonEditProjectDetails.Enabled = false;
                this.riskProjectOverviewButtonGenerateReports.Enabled = true;
                this.riskProjectOverviewButtonOpenRisk.Enabled = ARA_Globals.UserID != userID;
            }

            //Enable or disable buttons to change project state.
            this.riskProjectOverviewButtonMarkClose.Visible = projectState == ARA_Constants.finalDraft;
            this.riskProjectOverviewButtonMarkDoneReview.Visible = projectState == ARA_Constants.forReview && ARA_Globals.UserID != userID;
            this.riskProjectOverviewButtonMarkReview.Visible = projectState == ARA_Constants.draft && ARA_Globals.UserID == userID;
        }

        private void riskProjectOverviewButtonMarkReview_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Are you sure to mark this project for review? You can't change any risks until another user has reviewed this project!", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.queriesTableAdapter1.Update_Project_State(this.projectID, ARA_Constants.forReview);

                //Hide the button when the project state changes.
                enableControlOnProjectState();
            }
        }

        private void riskProjectOverviewButtonMarkDoneReview_Click(object sender, EventArgs e)
        {
            if(System.Windows.Forms.MessageBox.Show("Are you sure to end the review sessie?", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if(this.is_ProjectReview_AcceptedTableAdapter.GetData(this.projectID).Rows[0]["IsProjectReviewAccepted"].ToString() == "1")
                {
                    this.queriesTableAdapter1.Update_Project_State(this.projectID, ARA_Constants.finalDraft);
                }
                else
                {
                    this.queriesTableAdapter1.Update_Project_State(this.projectID, ARA_Constants.draft);
                    this.queriesTableAdapter1.Increase_Project_DraftVersion(this.projectID);
                }

                //Hide the button when the project state changes.
                enableControlOnProjectState();
            }
        }

        private void riskProjectOverviewButtonMarkClose_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Are you sure you want to close the project? It can't be changed afterwards!", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.queriesTableAdapter1.Update_Project_State(this.projectID, ARA_Constants.closed);

                //Hide the button when the project state changes.
                enableControlOnProjectState();
            }
        }
    }
}
