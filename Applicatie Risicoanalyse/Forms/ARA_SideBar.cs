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
using Applicatie_Risicoanalyse.Globals;
using Applicatie_Risicoanalyse.Controls;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class ARA_SideBar : Form
    {
        public ARA_SideBar()
        {
            InitializeComponent();
            this.Font = new System.Drawing.Font("Gotham Light", ARA_Globals.ARA_BaseFontSize );
            foreach (Control control in this.Controls)
            {
                control.Font = this.Font;
            }
        }

        private void onMainMenuLoad(object sender, EventArgs e)
        {
            //Add events.
            Applicatie_Risicoanalyse.Globals.ARA_Events.SetSideBarButtonSelectedEventHandler += onSetSideBarButtonSelectedEvent;
            Applicatie_Risicoanalyse.Globals.ARA_Events.SideBarAddNewButtonEventHandler += onAddNewButtonToSideBar;

            //Set application version form globals.
            this.SideBarApplicationVersion.Text = Applicatie_Risicoanalyse.Globals.ARA_Constants.applicationVersion;

            //Set current date.
            this.SideBarDate.Text = Applicatie_Risicoanalyse.Globals.ARA_Globals.ARa_Date;
        }

        private void onSetSideBarButtonSelectedEvent(object sender, SetSideBarButtonSelectedEventArgs e)
        {
            if(e.Index == "")
            {
                hideOtherPanels(new object(),e);
            }
            else
            {
                //Can we find our button?
                int buttonIndex = this.SideBarButtonContainer.Controls.IndexOfKey(e.Index);
                if(buttonIndex != -1) //Select button.
                {
                    hideOtherPanels(new object(), e);
                    ARA_Button temp = (ARA_Button)SideBarButtonContainer.Controls[buttonIndex];
                    temp.setButtonSelected(true);
                }
            }
        }

        public void onAddNewButtonToSideBar(object sender, SideBarAddNewButtonEvent e)
        {

            //Do we already have this project open?
            foreach (ARA_Button button in this.SideBarButtonContainer.Controls.OfType<ARA_Button>())
            {
                if (button.Text.ToString().Equals(e.Button.Text.ToString()))
                {
                    System.Windows.Forms.MessageBox.Show("This project is already opend!","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
            }

            //Try to open the form instance.
            try
            {
                Applicatie_Risicoanalyse.Globals.ARA_Events.onOpenContentFormEvent((Form)e.FormType);
            }
            catch (Exception)
            {
                throw;
            }

            //Add some style to the button.
            ARA_Button tempButton = e.Button;
            tempButton.Margin = new System.Windows.Forms.Padding(0);
            tempButton.MaximumSize = this.SideBarButtonMenu.MaximumSize;
            tempButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            tempButton.Size = this.SideBarButtonMenu.Size;

            //And a clickhandler.
            tempButton.Click += delegate (object senderr, EventArgs ev)
            {
                tempButton.setButtonSelected(true);
                this.hideOtherPanels(new object(), e);
                Applicatie_Risicoanalyse.Globals.ARA_Events.onOpenContentFormEvent((Form)e.FormType);
            };

            //Add the button to the sidebar.
            this.addButtonToSideBar(tempButton);
        }

        //Dynamicly add buttons to the sidebar.
        public void addButtonToSideBar(ARA_Button control)
        {
            if(control == null)
            {
                return;
            }
            this.SideBarButtonSpacer.Height -= control.Height;
            this.SideBarButtonContainer.Controls.Add(control);
            control.Click += hideOtherPanels;
            this.hideOtherPanels(control,new EventArgs());
            control.setButtonSelected(true);
        }

        //Dynamicly remove button from sidebar.
        public void removeButtonFromSideBar(Control control)
        {
            this.SideBarButtonContainer.Controls.Remove(control);
            this.SideBarButtonSpacer.Height += control.Height;
        }

        //MainMenu button click handler.
        private void onMenuButtonClick(object sender, EventArgs e)
        {
            this.SideBarButtonMenu.setButtonSelected(true);
            this.hideOtherPanels(new object(), e);
            Applicatie_Risicoanalyse.Globals.ARA_Events.onOpenContentFormEvent(new ARA_MainMenu());
        }

        //RiskAnalysis button click handler.
        private void onRiskAnalysisButtonClick(object sender, EventArgs e)
        {
            this.SideBarButtonMenu.setButtonSelected(true);
            this.hideOtherPanels(new object(), e);
            Applicatie_Risicoanalyse.Globals.ARA_Events.onOpenContentFormEvent(new ARA_ProjectOverview());
        }

        //Deselects all sidebar buttons except the event source.
        private void hideOtherPanels(object sender, EventArgs e)
        {
            ARA_Events.triggerBaseFormSetTopBarEvent(null);
            foreach (var button in this.SideBarButtonContainer.Controls.OfType<Applicatie_Risicoanalyse.Controls.ARA_Button>())
            {
                if (button != sender)
                {
                    button.setButtonSelected(false);
                }
            }
        }
    }
}
