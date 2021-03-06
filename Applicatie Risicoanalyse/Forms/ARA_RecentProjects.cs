﻿using Applicatie_Risicoanalyse.Controls;
using Applicatie_Risicoanalyse.Globals;
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
    public partial class ARA_RecentProjects : Form
    {
        private int amountOfRecentProjectsToShow = 20;

        public ARA_RecentProjects()
        {
            InitializeComponent();

            //Scaling form and controls.
            this.Font = new Font(ARA_Globals.ARA_Font, ARA_Globals.ARA_BaseFontSize);
            foreach (Control control in this.Controls)
            {
                control.Font = this.Font;
            }

            //Add events.
            ARA_Events.NewProjectRevisionEventHandler    += ARA_Events_NewProjectRevisionEventHandler;
            ARA_Events.NewProjectCreatedEventHandler     += ARA_Events_NewProjectCreatedEventHandler;
            ARA_Events.ProjectDetailsChangedEventHandler += ARA_Events_ProjectDetailsChangedEventHandler;
            ARA_Events.ProjectOpendEventHandler          += ARA_Events_ProjectOpendEventHandler;

            //Special scaling for the datagrid.
            this.recentProjectsDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font(ARA_Globals.ARA_Font, ARA_Globals.ARA_BaseFontSize - 3);
            this.recentProjectsDataGrid.DefaultCellStyle.Font              = new Font(ARA_Globals.ARA_Font, ARA_Globals.ARA_BaseFontSize - 5);
        }

        /// <summary>
        /// Handler when a project opens, set the project latest recent activity.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ARA_Events_ProjectOpendEventHandler(object sender, ProjectOpendEvent e)
        {
            this.queriesTableAdapter1.Update_Project_RecentActivity(e.projectID);
            this.recentProjectsDataGrid.DataSource = this.get_Recent_Risk_ProjectsTableAdapter.GetData(this.amountOfRecentProjectsToShow);
            recentProjectsDataGrid_RowsAdded(new object(), new DataGridViewRowsAddedEventArgs(0, 0));
        }

        private void ARA_Events_ProjectDetailsChangedEventHandler(object sender, ProjectDetailsChangedEvent e)
        {
            this.recentProjectsDataGrid.DataSource = this.get_Recent_Risk_ProjectsTableAdapter.GetData(this.amountOfRecentProjectsToShow);
            recentProjectsDataGrid_RowsAdded(new object(), new DataGridViewRowsAddedEventArgs(0, 0));
        }

        private void ARA_Events_NewProjectCreatedEventHandler(object sender, NewProjectCreatedEvent e)
        {
            this.recentProjectsDataGrid.DataSource = this.get_Recent_Risk_ProjectsTableAdapter.GetData(this.amountOfRecentProjectsToShow);
            recentProjectsDataGrid_RowsAdded(new object(), new DataGridViewRowsAddedEventArgs(0, 0));
        }

        private void ARA_Events_NewProjectRevisionEventHandler(object sender, NewProjectRevisionEvent e)
        {
            this.recentProjectsDataGrid.DataSource = this.get_Recent_Risk_ProjectsTableAdapter.GetData(this.amountOfRecentProjectsToShow);
            recentProjectsDataGrid_RowsAdded(new object(), new DataGridViewRowsAddedEventArgs(0, 0));
        }

        /// <summary>
        /// Handler when the user wants to open a specific project.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recentProjectsDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //Create a button for our sidebar.
                ARA_Button projectSideBarButton = new ARA_Button();
                projectSideBarButton.Text = this.recentProjectsDataGrid.Rows[e.RowIndex].Cells["machineNumberDataGridViewTextBoxColumn"].Value.ToString();

                //Get selected project id.
                int projectIDToOpen = (Int32)this.recentProjectsDataGrid.Rows[e.RowIndex].Cells["ProjectID"].Value;
                string projectName = (String)this.recentProjectsDataGrid.Rows[e.RowIndex].Cells["machineNumberDataGridViewTextBoxColumn"].Value;
                //Log this event.
                ARA_Events.triggerProjectOpendEvent(projectIDToOpen, projectName);

                //Trigger event to add a button to the sidebar and attach this form to it.
                Applicatie_Risicoanalyse.Globals.ARA_Events.triggerSideBarAddNewButtonEvent(
                    projectSideBarButton,
                    Activator.CreateInstance(typeof(ARA_RiskProjectOverview), projectIDToOpen));
            }
        }

        /// <summary>
        /// Add styling based on project state when rows are added to the datagrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recentProjectsDataGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in this.recentProjectsDataGrid.Rows)
            {
                string tempStateName = row.Cells["StateName"].Value.ToString();
                if (tempStateName == ARA_Constants.draft)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
                else if (tempStateName == ARA_Constants.forReview)
                {
                    row.DefaultCellStyle.BackColor = ARA_Colors.ARA_Orange;
                }
                else if (tempStateName == ARA_Constants.finalDraft)
                {
                    row.DefaultCellStyle.BackColor = ARA_Colors.ARA_Green;
                }
                else if (tempStateName == ARA_Constants.closed)
                {
                    row.DefaultCellStyle.BackColor = ARA_Colors.ARA_Gray2;
                }
            }
        }

        private void ARA_RecentProjects_Load(object sender, EventArgs e)
        {
            this.recentProjectsDataGrid.DataSource = this.get_Recent_Risk_ProjectsTableAdapter.GetData(this.amountOfRecentProjectsToShow);
        }
    }
}
