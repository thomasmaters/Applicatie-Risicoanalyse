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
        private int projectID = -1;

        public ARA_RiskProjectOverview(int projectID)
        {
            this.projectID = projectID;
            InitializeComponent();

            //Attach an layoutPanel to the button.
            this.riskProjectOverviewButtonOpenRisk.setConnectedPanel(this.riskProjectOverviewPanelOpenRisk);
            this.riskProjectOverviewButtonAddRiskToProject.setConnectedPanel(this.riskProjectOverviewPanelAddRiskToProject);
            this.riskProjectOverviewButtonEditProjectDetails.setConnectedPanel(this.riskProjectOverviewPanelEditProjectDetails);
            this.riskProjectOverviewButtonGenerateReports.setConnectedPanel(this.riskProjectOverviewPanelGenerateReports);
            this.riskProjectOverviewButtonCopyRisk.setConnectedPanel(this.riskProjectOverviewPanelCopyRisk);
            //Add Click event to hide all other buttons/panels when one opens.
            this.riskProjectOverviewButtonOpenRisk.Click           += hideOtherPanels;
            this.riskProjectOverviewButtonAddRiskToProject.Click   += hideOtherPanels;
            this.riskProjectOverviewButtonEditProjectDetails.Click += hideOtherPanels;
            this.riskProjectOverviewButtonGenerateReports.Click    += hideOtherPanels;
            this.riskProjectOverviewButtonCopyRisk.Click           += hideOtherPanels;
        }

        /// <summary>
        /// Loads the users permissions to see and use form elements.
        /// </summary>
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

            this.riskProjectOverviewButtonCopyRisk.Visible              = ARA_ACL.getPermissionLevel("General.ButtonCopyRisksToProject") >= ARA_Globals.PermissionLevel.ReadOnly;
            this.riskProjectOverviewPanelCopyRisk.Visible               = ARA_ACL.getPermissionLevel("General.ButtonCopyRisksToProject") >= ARA_Globals.PermissionLevel.ReadOnly;
            this.riskProjectOverviewPanelCopyRisk.Enabled               = ARA_ACL.getPermissionLevel("General.ButtonCopyRisksToProject") == ARA_Globals.PermissionLevel.All;

            this.riskProjectOverviewButtonGenerateReports.Visible       = ARA_ACL.getPermissionLevel("General.ButtonGenerateReports") >= ARA_Globals.PermissionLevel.ReadOnly;
            this.riskProjectOverviewPanelGenerateReports.Visible        = ARA_ACL.getPermissionLevel("General.ButtonGenerateReports") >= ARA_Globals.PermissionLevel.ReadOnly;
            this.riskProjectOverviewPanelGenerateReports.Enabled        = ARA_ACL.getPermissionLevel("General.ButtonGenerateReports") == ARA_Globals.PermissionLevel.All;

            this.riskProjectOverviewButtonMarkClose.Visible             = this.riskProjectOverviewButtonMarkClose.Visible && ARA_ACL.getPermissionLevel("General.ButtonMarkProjectClosed") == ARA_Globals.PermissionLevel.All;
            this.riskProjectOverviewButtonMarkReview.Visible            = this.riskProjectOverviewButtonMarkReview.Visible && ARA_ACL.getPermissionLevel("General.ButtonMarkProjectForReview") == ARA_Globals.PermissionLevel.All;
            this.riskProjectOverviewButtonMarkDoneReview.Visible        = this.riskProjectOverviewButtonMarkDoneReview.Visible && ARA_ACL.getPermissionLevel("General.ButtonMarkProjectDoneReviewing") == ARA_Globals.PermissionLevel.All;
        }

        /// <summary>
        /// Adds a subform to a panel and shows it.
        /// </summary>
        /// <param name="panel">Panel to connect the form to.</param>
        /// <param name="form">Form to connect to the panel.</param>
        private void addFormToPanel(FlowLayoutPanel panel, System.Windows.Forms.Form form)
        {
            form.TopLevel = false;
            panel.Controls.Add(form);
            form.Show();
        }

        /// <summary>
        /// Hides all ARA_DropDownButtons in the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Fill dataAdapters and add forms to panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            this.addFormToPanel(this.riskProjectOverviewPanelCopyRisk, new ARA_CopyRisksToProject(projectID));

            //Enable controls and reload permissions.
            enableControlOnProjectState();
        }

        /// <summary>
        /// Changes the availabilty of controls based on the project state. Call this function after loading the permissions.
        /// </summary>
        private void enableControlOnProjectState()
        {
            string projectState = this.tbl_Risk_AnalysisTableAdapter.GetData().FindByProjectID(this.projectID)["StateName"].ToString();
            int userID = (Int32)this.tbl_ProjectTableAdapter.GetData().FindByProjectID(this.projectID)["UserID"];
            if (projectState != ARA_Constants.draft)
            {
                this.riskProjectOverviewButtonAddRiskToProject.Enabled   = false;
                this.riskProjectOverviewButtonEditProjectDetails.Enabled = false;
                this.riskProjectOverviewButtonCopyRisk.Enabled           = false;
                this.riskProjectOverviewButtonGenerateReports.Enabled    = true;
                this.riskProjectOverviewButtonOpenRisk.Enabled           = true;
            }
            else
            {
                this.riskProjectOverviewButtonAddRiskToProject.Enabled   = true;
                this.riskProjectOverviewButtonEditProjectDetails.Enabled = true;
                this.riskProjectOverviewButtonCopyRisk.Enabled           = true;
            }

            //Enable or disable buttons to change project state.
            this.riskProjectOverviewButtonMarkClose.Visible      = projectState == ARA_Constants.finalDraft;
            this.riskProjectOverviewButtonMarkDoneReview.Visible = projectState == ARA_Constants.forReview && ARA_Globals.UserID != userID;
            this.riskProjectOverviewButtonMarkReview.Visible     = projectState == ARA_Constants.draft && ARA_Globals.UserID == userID;

            //Update the topbar form.
            setProjectInfoTopForm();

            //Reload permissions.
            loadPermissions();
        }

        /// <summary>
        /// Sets the topbar with project specific data.
        /// </summary>
        private void setProjectInfoTopForm()
        {
            //Construct text to display on topbar.
            DataRow riskAnalysisData = this.tbl_Risk_AnalysisTableAdapter.GetData().FindByProjectID(this.projectID);
            string leftText = string.Format("Customer: {0}\nProject state: {1}",
                riskAnalysisData["Customer"],
                riskAnalysisData["StateName"]);
            string rightText = string.Format("Draft version: {0}", 
                riskAnalysisData["DraftVersion"]);

            //Create topbar form.
            Form topBar = new ARA_TopBar(leftText, rightText);

            //Trigger event for displaying the form.
            ARA_Events.triggerBaseFormSetTopBarEvent(topBar);
        }

        /// <summary>
        /// Handler when the button is pressed to mark the project for review.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void riskProjectOverviewButtonMarkReview_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show(ARA_Constants.messageBoxConfirmProjectReview, ARA_Constants.messageBoxConfirmProjectReviewHeader, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.queriesTableAdapter1.Update_Project_State(this.projectID, ARA_Constants.forReview);

                //Log event.
                ARA_Events.triggerProjectStateChangedEvent(this.projectID, ARA_Constants.forReview);

                //Hide the button when the project state changes.
                enableControlOnProjectState();
            }
        }

        /// <summary>
        /// Handler when te button is pressed to mark the project as DRAFT if there need to be changes made or FINALDRAFT afterwards.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void riskProjectOverviewButtonMarkDoneReview_Click(object sender, EventArgs e)
        {
            if(this.is_ProjectReview_AcceptedTableAdapter.GetData(this.projectID).Rows[0]["IsProjectReviewAccepted"].ToString() == "1")
            {
                if (System.Windows.Forms.MessageBox.Show(ARA_Constants.messageBoxConfirmFinalDraft, ARA_Constants.messageBoxConfirmFinalDraftHeader, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.queriesTableAdapter1.Update_Project_State(this.projectID, ARA_Constants.finalDraft);

                    //Log event.
                    ARA_Events.triggerProjectStateChangedEvent(this.projectID, ARA_Constants.finalDraft);
                }
            }
            else
            {
                if (System.Windows.Forms.MessageBox.Show(ARA_Constants.messageBoxConfirmDraft, ARA_Constants.messageBoxConfirmDraftHeader, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.queriesTableAdapter1.Update_Project_State(this.projectID, ARA_Constants.draft);
                    this.queriesTableAdapter1.Increase_Project_DraftVersion(this.projectID);

                    //Log event.
                    ARA_Events.triggerProjectStateChangedEvent(this.projectID, ARA_Constants.draft);
                }
            }

            //Hide the button when the project state changes.
            enableControlOnProjectState();
        }

        /// <summary>
        /// Handler when the user wants to close the project.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void riskProjectOverviewButtonMarkClose_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show(ARA_Constants.messageBoxConfirmCloseProject, ARA_Constants.messageBoxConfirmCloseProjectHeader, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.queriesTableAdapter1.Update_Project_State(this.projectID, ARA_Constants.closed);

                //Log event.
                ARA_Events.triggerProjectStateChangedEvent(this.projectID, ARA_Constants.closed);

                //Hide the button when the project state changes.
                enableControlOnProjectState();
            }
        }

        private void ARA_RiskProjectOverview_Shown(object sender, EventArgs e)
        {
            this.setProjectInfoTopForm();
        }

        private void ARA_RiskProjectOverview_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == false)
            {
                this.setProjectInfoTopForm();
            }
        }
    }
}
