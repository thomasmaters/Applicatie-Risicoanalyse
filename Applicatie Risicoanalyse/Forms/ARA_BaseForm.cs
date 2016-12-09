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
            ARA_Events.OpenContentFormEventHandler += onOpenContentFormEvent;
            ARA_Events.baseFormSetTopBarFormEventHandler += onBaseFormSetTopBarForm;

            //Set scaling.
            this.Font = new System.Drawing.Font(ARA_Globals.ARA_Font, ARA_Globals.ARA_BaseFontSize); 

            //Add the sidebar to the application base on load.
            setPanelForm(new ARA_SideBar(), this.SidePanel);
            setPanelForm(new ARA_MainMenu(), this.contentPanel);
        }

        /// <summary>
        /// Shows a form in a panel.
        /// </summary>
        /// <param name="aForm"></param>
        /// <param name="aPanel"></param>
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

        /// <summary>
        /// Handler when the the user wants to set the main content panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onOpenContentFormEvent(object sender, OpenContentFormEvent e)
        {
            //if (this.contentPanel.Controls[0] != e.Form)
            //{
                setPanelForm(e.Form, this.contentPanel);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            //}
        }

        /// <summary>
        /// Handle when a BaseFromSetTopBarFormEvent is triggerd.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            GC.WaitForPendingFinalizers();
        }
    }
}
