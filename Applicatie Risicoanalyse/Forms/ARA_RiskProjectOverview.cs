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
            //Add Click event to hide all other buttons/panels when one opens.
            this.riskProjectOverviewButtonOpenRisk.Click += hideOtherPanels;
            this.riskProjectOverviewButtonAddRiskToProject.Click += hideOtherPanels;
            this.riskProjectOverviewButtonEditProjectDetails.Click += hideOtherPanels;
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
            this.Font = new System.Drawing.Font("Gotham Light", Applicatie_Risicoanalyse.Globals.ARA_Globals.ARA_BaseFontSize);

            this.addFormToPanel(this.riskProjectOverviewPanelAddRiskToProject, new ARA_AddRisksToProject(projectID));
            this.addFormToPanel(this.riskProjectOverviewPanelOpenRisk, new ARA_OpenRiskInProject(projectID));

            loadPermissions();
        }
    }
}
