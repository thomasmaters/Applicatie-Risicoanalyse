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
            //Add Click event to hide all other buttons/panels when one opens.
            this.projectOverviewButtonCreateProject.Click += hideOtherPanels;
            this.projectOverviewButtonCreateProjectRevision.Click += hideOtherPanels;
            this.projectOverviewButtonOpenProject.Click += hideOtherPanels;
            this.ProjectOverviewButtonRecentProjects.Click += hideOtherPanels;
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
        }
    }
}
