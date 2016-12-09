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
using Applicatie_Risicoanalyse.Globals;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class ARA_CreateProject : Form
    {
        private ARA_Button projectSideBarButton;

        public ARA_CreateProject()
        {
            InitializeComponent();
        }

        private void onCreateProjectLoad(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Get_Newest_Added_Project' table. You can move, or remove it, as needed.
            this.get_Newest_Added_ProjectTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Get_Newest_Added_Project);
            //Set scaling.
            this.Font = new System.Drawing.Font(ARA_Globals.ARA_Font, Applicatie_Risicoanalyse.Globals.ARA_Globals.ARA_BaseFontSize);

            //Fix for text scaling of form.
            System.Drawing.Font textFont = new System.Drawing.Font(ARA_Globals.ARA_Font, Applicatie_Risicoanalyse.Globals.ARA_Globals.ARA_BaseFontSize - 3F);
            this.createProjectTextCustomer.Font = textFont;
            this.createProjectTextExtraInfo.Font = textFont;
            this.createProjectTextMachineNumber.Font = textFont;
            this.createProjectTextMachineType.Font = textFont;
            this.createProjectTextOrderNumber.Font = textFont;
        }

        /// <summary>
        /// //Click handler when the user clicks the create project button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onCreateProjectButtonClick(object sender, EventArgs e)
        {
            if (canProjectBeCreated())
            {

                //Executes procedure for adding an riskproject to the database.
                this.createProjectDatabaseAdapter.Create_RiskProject
                    (
                        ARA_Globals.UserID,
                        this.createProjectInputCustomer.Text,
                        this.createProjectInputMachineType.Text,
                        this.createProjectInputMachineNumber.Text,
                        this.createProjectInputOrderNumber.Text,
                        this.createProjectInputExtraInfo.Text
                    );

                int newestAddedProject = (Int32)this.get_Newest_Added_ProjectTableAdapter.GetData().Rows[0]["NewestProject"];
                this.projectSideBarButton = new ARA_Button();
                this.projectSideBarButton.Text = this.createProjectInputMachineNumber.Text;

                //Let other forms know that there is a new project.
                ARA_Events.triggerNewProjectCreatedEvent(newestAddedProject);

                //Trigger event to add a button to the sidebar and attach this form to it.
                Applicatie_Risicoanalyse.Globals.ARA_Events.triggerSideBarAddNewButtonEvent(
                    this.projectSideBarButton,
                    Activator.CreateInstance(typeof(ARA_RiskProjectOverview), newestAddedProject));

                clearInputFields();
            }
        }

        /// <summary>
        /// Clears all the input fields, so when a new project is created the old text doenst stay.
        /// </summary>
        private void clearInputFields()
        {
            //Clear fields for next use.
            this.createProjectInputCustomer.Text = "";
            this.createProjectInputMachineType.Text = "";
            this.createProjectInputMachineNumber.Text = "";
            this.createProjectInputOrderNumber.Text = "";
            this.createProjectInputExtraInfo.Text = "";
        }

        /// <summary>
        /// //Checks if all requirements are met, so the user can make a project.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onInputChanged(object sender, EventArgs e)
        {
            this.createProjectButtonCreateProject.Enabled = canProjectBeCreated();
        }

        /// <summary>
        /// Checks if the project can be created by checking the inputboxxes values.
        /// </summary>
        /// <returns></returns>
        private bool canProjectBeCreated()
        {
            return (
                    this.createProjectInputCustomer.Text.Length > 0 &&
                    this.createProjectInputMachineType.Text.Length > 0 &&
                    this.createProjectInputMachineNumber.Text.Length > 0 &&
                    this.createProjectInputOrderNumber.Text.Length > 0
                );
        }
    }
}
