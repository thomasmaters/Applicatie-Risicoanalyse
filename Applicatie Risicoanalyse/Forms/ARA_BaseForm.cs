using System;
using System.Windows.Forms;
using System.Diagnostics;
using Applicatie_Risicoanalyse.Globals;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class ARA_BaseForm : Form
    {
        public ARA_BaseForm()
        {
            InitializeComponent();
        }

        private void onApplicationLoad(object sender, EventArgs e)
        {
            //Add events.
            Applicatie_Risicoanalyse.Globals.ARA_Events.openContentFormEventHandler += onOpenContentFormEvent;

            //Set scaling.
            this.Font = new System.Drawing.Font("Gotham Light", Applicatie_Risicoanalyse.Globals.ARA_Globals.ARA_BaseFontSize); 

            //Add the sidebar to the application base on load.
            Applicatie_Risicoanalyse.Forms.ARA_SideBar SideBar = new ARA_SideBar();
            SideBar.TopLevel = false;
            SideBar.Font = Font;
            this.SidePanel.Controls.Add(SideBar);
            SideBar.Show();
        }

        private void onOpenContentFormEvent(object sender, OpenContentFormEventArgs e)
        {
            setContentPanelForm(e.Form);
        }
    }
}
