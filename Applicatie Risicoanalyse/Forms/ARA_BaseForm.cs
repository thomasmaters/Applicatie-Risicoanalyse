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
            ARA_Events.openContentFormEventHandler += onOpenContentFormEvent;
            ARA_Events.baseFormSetTopBarFormEventHandler += onBaseFormSetTopBarForm;

            //Set scaling.
            this.Font = new System.Drawing.Font("Gotham Light", ARA_Globals.ARA_BaseFontSize); 

            //Add the sidebar to the application base on load.
            setPanelForm(new ARA_SideBar(), this.SidePanel);
            setPanelForm(new ARA_MainMenu(), this.contentPanel);
        }

        //Set the content panels form.
        public void setPanelForm(Form aForm, Panel aPanel)
        {
            //Make it a subform.
            aForm.TopLevel = false;

            //Clear current form.
            aPanel.Controls.Clear();

            //Add the from.
            aPanel.Controls.Add(aForm);

            //Show the form.
            aForm.Show();
        }

        private void onOpenContentFormEvent(object sender, OpenContentFormEventArgs e)
        {
            setPanelForm(e.Form,this.contentPanel);
            GC.Collect();
        }

        private void onBaseFormSetTopBarForm(object sender, BaseFormSetTopBarFormEvent e)
        {
            if(e.Form != null)
            {
                setPanelForm(e.Form, this.TopBar);
            }
            else
            {
                this.TopBar.Controls.Clear();
            }
            GC.Collect();
        }
    }
}
