﻿using Applicatie_Risicoanalyse.Globals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class ARA_CreateProjectRevision : Form
    {
        public ARA_CreateProjectRevision()
        {
            InitializeComponent();

            //Add eventhandler.
            ARA_Events.NewProjectCreatedEventHandler += ARA_Events_NewProjectCreatedEventHandler;
            ARA_Events.ProjectStateChangedEventHandler += ARA_Events_ProjectStateChangedEventHandler;
            ARA_Events.NewProjectRevisionEventHandler += ARA_Events_NewProjectRevisionEventHandler;

            //Set form scaling.
            this.Font = new Font(ARA_Globals.ARA_Font, ARA_Globals.ARA_BaseFontSize);

            //Special scaling for datagrid.
            this.projectRevisionDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font(ARA_Globals.ARA_Font, ARA_Globals.ARA_BaseFontSize - 3);
            this.projectRevisionDataGrid.DefaultCellStyle.Font = new Font(ARA_Globals.ARA_Font, ARA_Globals.ARA_BaseFontSize - 5);
        }

        /// <summary>
        /// Handler when the user creates a new project revision.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ARA_Events_NewProjectRevisionEventHandler(object sender, NewProjectRevisionEvent e)
        {
            this.projectRevisionDataGrid.DataSource = this.get_Projects_For_ProjectRevisionTableAdapter.GetData();
        }

        /// <summary>
        /// Handler when the user changes a project state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ARA_Events_ProjectStateChangedEventHandler(object sender, ProjectStateChangedEvent e)
        {
            this.projectRevisionDataGrid.DataSource = this.get_Projects_For_ProjectRevisionTableAdapter.GetData();
        }

        /// <summary>
        /// Trigger when a new project is created, to keep the datagrid up to date.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ARA_Events_NewProjectCreatedEventHandler(object sender, NewProjectCreatedEvent e)
        {
            //Update the datagrid datasource.
            this.projectRevisionDataGrid.DataSource = this.get_Projects_For_ProjectRevisionTableAdapter.GetData();
        }

        private void createProjectRevision_Load(object sender, EventArgs e)
        {
            this.get_Projects_For_ProjectRevisionTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Get_Projects_For_ProjectRevision);
        }

        /// <summary>
        /// Handler when the user want to create a project revision of a project.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void projectRevisionButtonCreateRevision_Click(object sender, EventArgs e)
        {
            try
            {
                //Did the user select some row?
                if (this.projectRevisionDataGrid.SelectedRows.Count > 0)
                {
                    int selectedProjectID = (Int32)this.projectRevisionDataGrid.SelectedRows[0].Cells["projectIDDataGridViewTextBoxColumn"].Value;
                    int selectedRevision = Int32.Parse(this.projectRevisionDataGrid.SelectedRows[0].Cells["Revision"].Value.ToString()) + 1;
                    string selectedProjectName = this.projectRevisionDataGrid.SelectedRows[0].Cells["machineNumberDataGridViewTextBoxColumn"].Value.ToString();

                    //Execute procedure to create a project revision.
                    queriesTableAdapter1.Create_RiskProject_Revision(selectedProjectID, ARA_Globals.UserID);

                    //Log event.
                    ARA_Events.triggerNewProjectRevisionEvent(selectedProjectID, selectedRevision, selectedProjectName);

                    //Let the user know something happend.
                    MessageBox.Show(ARA_Constants.messageBoxProjectRevisionCreated, ARA_Constants.messageBoxProjectRevisionCreatedHeader, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ARA_Constants.messageBoxProjectRevisionFailed + ex, ARA_Constants.messageBoxProjectRevisionFailedHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
