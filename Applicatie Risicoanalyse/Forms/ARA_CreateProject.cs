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
using Applicatie_Risicoanalyse.Controls;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class ARA_CreateProject : Form
    {
        private ARA_Button projectSideBarButton;
        private ARA_RiskProjectOverview projectContentView;

        public ARA_CreateProject()
        {
            InitializeComponent();
        }

        private void onCreateProjectLoad(object sender, EventArgs e)
        {
            //Set scaling.
            this.Font = new System.Drawing.Font("Gotham Light", Applicatie_Risicoanalyse.Globals.ARA_Globals.ARA_BaseFontSize);

            //Fix for text scaling of form.
            System.Drawing.Font textFont = new System.Drawing.Font("Gotham Light", Applicatie_Risicoanalyse.Globals.ARA_Globals.ARA_BaseFontSize - 3F);
            this.createProjectTextCustomer.Font = textFont;
            this.createProjectTextExtraInfo.Font = textFont;
            this.createProjectTextMachineNumber.Font = textFont;
            this.createProjectTextMachineType.Font = textFont;
            this.createProjectTextOrderNumber.Font = textFont;
        }

        //Click handler when the user clicks the create project button.
        private void onCreateProjectButtonClick(object sender, EventArgs e)
        {
            //Executes procedure for adding an riskproject to the database.
            this.createProjectDatabaseAdapter.Create_RiskProject
                (
                    1,//TODO USERID
                    this.createProjectInputCustomer.Text,
                    this.createProjectInputMachineType.Text,
                    this.createProjectInputMachineNumber.Text,
                    this.createProjectInputOrderNumber.Text,
                    this.createProjectInputExtraInfo.Text
                );
            this.createProjectButtonCreateProject.setButtonSelected(false);
            
            //Trigger events to open form and set sidebarbutton selected.
            //TODO Create button markup.
            this.projectContentView = new ARA_RiskProjectOverview();
            this.projectSideBarButton = new ARA_Button();
            this.projectSideBarButton.Text = this.createProjectInputMachineNumber.Text;
            this.projectSideBarButton.Click += sideBarProjectButtonClick;

            Applicatie_Risicoanalyse.Globals.ARA_Events.onOpenContentFormEvent(this.projectContentView);
            Applicatie_Risicoanalyse.Globals.ARA_Events.onSideBarAddNewButtonEvent(this.projectSideBarButton);
        }

        private void sideBarProjectButtonClick(object sender, EventArgs e)
        {
            Applicatie_Risicoanalyse.Globals.ARA_Events.onOpenContentFormEvent(this.projectContentView);
        }

        //Checks if all requirements are met, so the user can make a project.
        private void canProjectBeCreated(object sender, EventArgs e)
        {
            this.createProjectButtonCreateProject.Enabled = 
                (
                    this.createProjectInputCustomer.Text.Length > 0 &&
                    this.createProjectInputMachineType.Text.Length > 0 &&
                    this.createProjectInputMachineNumber.Text.Length > 0 &&
                    this.createProjectInputOrderNumber.Text.Length > 0
                );
        }
    }
}
