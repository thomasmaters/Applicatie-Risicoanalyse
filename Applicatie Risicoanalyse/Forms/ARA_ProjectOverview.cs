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
    public partial class ARA_ProjectOverview : Form
    {
        public ARA_ProjectOverview()
        {
            InitializeComponent();
            //Attach an layoutPanel to the button.
            this.projectOverviewButtonCreateProject.setConnectedPanel(this.projectOverviewPanelCreateProject);
            this.projectOverviewButtonCreateProjectRevision.setConnectedPanel(this.projectOverviewPanelCreateProjectRevision);
            this.projectOverviewButtonOpenProject.setConnectedPanel(this.projectOverviewPanelOpenProject);
            this.ProjectOverviewButtonRecentProjects.setConnectedPanel(this.ProjectOverviewPanelRecentProjects);
            this.projectOverviewButtonEditRiskStandard.setConnectedPanel(this.projectOverviewPanelEditRiskStandard);
            //Add Click event to hide all other buttons/panels when one opens.
            this.projectOverviewButtonCreateProject.Click += hideOtherPanels;
            this.projectOverviewButtonCreateProjectRevision.Click += hideOtherPanels;
            this.projectOverviewButtonOpenProject.Click += hideOtherPanels;
            this.ProjectOverviewButtonRecentProjects.Click += hideOtherPanels;

            loadPermissions();
        }
        private void loadPermissions()
        {
            this.projectOverviewButtonCreateProject.Visible         = ARA_ACL.getPermissionLevel("General.ButtonCreateProject") >= ARA_Globals.PermissionLevel.ReadOnly;
            this.ProjectOverviewButtonSpacer1.Visible               = ARA_ACL.getPermissionLevel("General.ButtonCreateProject") >= ARA_Globals.PermissionLevel.ReadOnly;
            this.projectOverviewPanelCreateProject.Enabled          = ARA_ACL.getPermissionLevel("General.ButtonCreateProject") == ARA_Globals.PermissionLevel.All;

            this.projectOverviewButtonOpenProject.Visible           = ARA_ACL.getPermissionLevel("General.ButtonOpenProject") >= ARA_Globals.PermissionLevel.ReadOnly;
            this.projectOverviewPanelOpenProject.Enabled            = ARA_ACL.getPermissionLevel("General.ButtonOpenProject") == ARA_Globals.PermissionLevel.All;

            this.ProjectOverviewButtonRecentProjects.Visible        = ARA_ACL.getPermissionLevel("General.ButtonRecentProjects") >= ARA_Globals.PermissionLevel.ReadOnly;
            this.ProjectOverviewPanelRecentProjects.Enabled         = ARA_ACL.getPermissionLevel("General.ButtonRecentProjects") == ARA_Globals.PermissionLevel.All;

            this.projectOverviewButtonCreateProjectRevision.Visible = ARA_ACL.getPermissionLevel("General.ButtonCreateProjectRevision") >= ARA_Globals.PermissionLevel.ReadOnly;
            this.projectOverviewPanelCreateProjectRevision.Enabled  = ARA_ACL.getPermissionLevel("General.ButtonCreateProjectRevision") == ARA_Globals.PermissionLevel.All;

            this.projectOverviewButtonEditRiskStandard.Visible      = ARA_ACL.getPermissionLevel("General.ButtonEditStandardRisks") >= ARA_Globals.PermissionLevel.ReadOnly;
            this.projectOverviewPanelEditRiskStandard.Enabled       = ARA_ACL.getPermissionLevel("General.ButtonEditStandardRisks") == ARA_Globals.PermissionLevel.All;

            this.projectOverviewButtonEditRiskStandard.Visible      = ARA_ACL.getPermissionLevel("General.ButtonEditRiskStandard") == ARA_Globals.PermissionLevel.All;
            this.projectOverviewPanelEditRiskStandard.Visible       = ARA_ACL.getPermissionLevel("General.ButtonEditRiskStandard") == ARA_Globals.PermissionLevel.All;

            this.projectOverviewButtonCreateNewRisk.Visible         = ARA_ACL.getPermissionLevel("General.ButtonCreateNewRisk") == ARA_Globals.PermissionLevel.All;
            this.projectOverviewButtonCreateNewRisk.Enabled         = ARA_ACL.getPermissionLevel("General.ButtonCreateNewRisk") == ARA_Globals.PermissionLevel.All;
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
            //Set scaling.
            this.Font = new System.Drawing.Font("Gotham Light", Applicatie_Risicoanalyse.Globals.ARA_Globals.ARA_BaseFontSize);

            this.addFormToPanel(this.projectOverviewPanelCreateProject, new ARA_CreateProject());

            this.addFormToPanel(this.projectOverviewPanelOpenProject, new ARA_OpenProject());

            this.addFormToPanel(this.projectOverviewPanelEditRiskStandard, new ARA_SearchRiskStandard());
        }

        private void projectOverviewButtonCreateNewRisk_Click(object sender, EventArgs e)
        {
            ARA_Events.onOpenContentFormEvent(new ARA_NewRiskBaseForm());
        }
    }
}
