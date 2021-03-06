﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Applicatie_Risicoanalyse.Globals;
using System.Diagnostics;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class ARA_OpenRiskInProject : Form
    {
        private int projectID = 1;
        private string projectState = ARA_Constants.draft;

        public ARA_OpenRiskInProject(int projectID)
        {
            InitializeComponent();

            this.projectID = projectID;
            //Get project state.
            this.tbl_Risk_AnalysisTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Risk_Analysis);
            this.projectState = this.tbl_Risk_AnalysisTableAdapter.GetData().FindByProjectID(this.projectID)["StateName"].ToString();

            //Add events.
            ARA_Events.RiskAddedToProjectEventHandler += ARA_Events_AddRiskToProjectEventHandler;
            ARA_Events.ProjectSpecificRiskCreatedEventHandler += ARA_Events_ProjectSpecificRiskCreatedEventHandler;
            ARA_Events.RiskInProjectReviewedEventHandler += ARA_Events_RiskInProjectReviewedEventHandler;

            //On form load show datagrid items.
            this.openRiskInProjectDataGrid.DataSource = this.search_ProjectRisksTableAdapter.GetData(this.projectID, "");
            this.openRiskInProjectDataGrid.Refresh();

            //Scaling form and controls.
            this.Font = new Font(ARA_Globals.ARA_Font, ARA_Globals.ARA_BaseFontSize);
            this.openRiskInProjectDataGrid.DefaultCellStyle.Font = new Font(ARA_Globals.ARA_Font, ARA_Globals.ARA_BaseFontSize - 5);
            foreach (Control control in this.Controls)
            {
                //control.Font = this.Font;
            }
        }

        /// <summary>
        /// Update the datagrid row styles when the user reviews a risk.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ARA_Events_RiskInProjectReviewedEventHandler(object sender, RiskInProjectReviewedEvent e)
        {
            //Is the update for our project?
            if (e.projectID == this.projectID)
            {
                this.openRiskInProjectDataGrid.DataSource = this.search_ProjectRisksTableAdapter.GetData(this.projectID, this.arA_TextBox1.Text);
            }
        }

        /// <summary>
        /// Update the datagrid styling when a user creates a project specific risk.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ARA_Events_ProjectSpecificRiskCreatedEventHandler(object sender, ProjectSpecificRiskCreatedEvent e)
        {
            //Is the update for our project?
            if (e.projectID == this.projectID)
            {
                this.openRiskInProjectDataGrid.DataSource = this.search_ProjectRisksTableAdapter.GetData(this.projectID, this.arA_TextBox1.Text);
            }
        }

        /// <summary>
        /// Search database for a record(s) containing data the user has typed in.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arA_TextBox1_TextChanged(object sender, EventArgs e)
        {
            //Remember scroll position.
            int tempScrollPosition = this.openRiskInProjectDataGrid.FirstDisplayedScrollingRowIndex;

            this.openRiskInProjectDataGrid.DataSource = this.search_ProjectRisksTableAdapter.GetData(this.projectID, this.arA_TextBox1.Text);
            this.openRiskInProjectDataGrid.Refresh();

            if (tempScrollPosition != -1 && tempScrollPosition < this.openRiskInProjectDataGrid.Rows.Count)
            {
                //Reapply scroll position.
                this.openRiskInProjectDataGrid.FirstDisplayedScrollingRowIndex = tempScrollPosition;
            }
        }

        /// <summary>
        /// Handler when te user wants to open and edit the risk.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenRiskInProjectDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Did the user select a row?
            if (e.RowIndex != -1)
            {
                //Get some data before editing the risk.
                int selectedRiskID = (Int32)this.openRiskInProjectDataGrid.Rows[e.RowIndex].Cells["RiskID"].Value;
                int selectedRiskDataID = (Int32)this.openRiskInProjectDataGrid.Rows[e.RowIndex].Cells["DefaultRiskDataID"].Value;
                int selectedRiskVersionID = (Int32)this.openRiskInProjectDataGrid.Rows[e.RowIndex].Cells["VersionID"].Value;
                bool isProjectSpecificRisk = false;

                //Do we have a project specific risk?
                if (this.openRiskInProjectDataGrid.Rows[e.RowIndex].Cells["ProjectRiskDataID"].Value != DBNull.Value)
                {
                    selectedRiskDataID = (Int32)this.openRiskInProjectDataGrid.Rows[e.RowIndex].Cells["ProjectRiskDataID"].Value;
                    isProjectSpecificRisk = true;
                }

                //Open risk with its risk data.
                Globals.ARA_Events.triggerOpenContentFormEvent(new ARA_EditRiskBaseForm(selectedRiskID,selectedRiskVersionID,selectedRiskDataID,this.projectID, isProjectSpecificRisk));
            }
        }

        /// <summary>
        /// Update the datagrid when a risk is added to the current project of the form changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ARA_Events_AddRiskToProjectEventHandler(object sender, RiskAddedToProjectEvent e)
        {
            //Is the update for our project?
            if (e.projectID == this.projectID)
            {
                this.openRiskInProjectDataGrid.DataSource = this.search_ProjectRisksTableAdapter.GetData(this.projectID, this.arA_TextBox1.Text);
            }
        }

        /// <summary>
        /// Handler when there is a new record added to the datagrid. 
        /// When this happens apply cell style to it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onDataGridRowAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            addStyleToCells();
        }

        /// <summary>
        /// Styles the cells in the datagrid according to row values.
        /// </summary>
        private void addStyleToCells()
        {
            //Style the rows on datagrid values.
            foreach (DataGridViewRow row in this.openRiskInProjectDataGrid.Rows)
            {
                //Mark the cells blue if its a project specific risk.
                if (row.Cells["ProjectRiskDataID"].Value.ToString() != "")
                {
                    row.DefaultCellStyle.BackColor = ARA_Colors.ARA_Blue1;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }

                //Mark the first column red if its not reviewed by a user.
                if (row.Cells["ReviewedByUser"].Value == DBNull.Value)
                {
                    row.Cells[0].Style.BackColor = ARA_Colors.ARA_Red;
                }
                else
                {
                    row.Cells[0].Style.BackColor = Color.White;
                }
            }

            addStyleForOutOfDateRisks();
        }

        /// <summary>
        /// Color a row in the OpenRiskInProjectDataGrid if it is not the newest version of the risk.
        /// </summary>
        private void addStyleForOutOfDateRisks()
        {
            //If our project is closed add a color to the out of date risks.
            if (this.projectState == ARA_Constants.closed)
            {
                foreach (DataGridViewRow row in this.openRiskInProjectDataGrid.Rows)
                {
                    if (this.is_Risk_OldTableAdapter.GetData(
                        (Int32)row.Cells["RiskID"].Value,
                        (Int32)row.Cells["VersionID"].Value)[0]["IsRiskOld"].ToString() == "1")
                    {
                        row.Cells[0].Style.BackColor = ARA_Colors.ARA_Blue5;
                    }
                }
            }
        }

        /// <summary>
        /// Clear ugly selection when the user clicks a row.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenRiskInProjectDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            this.openRiskInProjectDataGrid.ClearSelection();
        }

        /// <summary>
        /// Handler when the users resorts the datagrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenRiskInProjectDataGrid_Sorted(object sender, EventArgs e)
        {
            addStyleToCells();
        }
    }
}
