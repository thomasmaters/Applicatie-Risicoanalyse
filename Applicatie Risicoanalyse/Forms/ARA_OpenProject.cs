using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Applicatie_Risicoanalyse.Controls;
using Applicatie_Risicoanalyse.Globals;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class ARA_OpenProject : Form
    {
        public ARA_OpenProject()
        {
            InitializeComponent();

            //Scaling form and controls.
            this.Font = new Font("Gotham Light", ARA_Globals.ARA_BaseFontSize);
            foreach (Control control in this.Controls)
            {
                control.Font = this.Font;
            }

            //Special scaling for the datagrid.
            this.OpenProjectDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Gotham Light", ARA_Globals.ARA_BaseFontSize - 3);
            this.OpenProjectDataGrid.DefaultCellStyle.Font = new Font("Gotham Light", ARA_Globals.ARA_BaseFontSize - 5);
        }

        private void ARA_OpenProject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Get_Projects_With_Revision' table. You can move, or remove it, as needed.
            this.get_Projects_With_RevisionTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Get_Projects_With_Revision);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Risk_Analysis' table. You can move, or remove it, as needed.
            this.tbl_Risk_AnalysisTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Risk_Analysis);
        }

        /// <summary>
        /// Update the datagrid when the user want to search.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arA_TextBox1_TextChanged(object sender, EventArgs e)
        {
            //Get current scrollposition.
            int tempScrollPosition = this.OpenProjectDataGrid.FirstDisplayedScrollingRowIndex;

            try
            {
                //Set datasource.
                this.OpenProjectDataGrid.DataSource = this.search_ProjectsTableAdapter.GetData("" + this.OpenProjectTextBoxSearch.Text);
                this.OpenProjectDataGrid.Refresh();

                //Scroll datagrid to the previous scrollposition.
                if (tempScrollPosition != -1 && tempScrollPosition < this.OpenProjectDataGrid.Rows.Count)
                {
                    this.OpenProjectDataGrid.FirstDisplayedScrollingRowIndex = tempScrollPosition;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Handler when the user wants to open a specific project.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenProjectDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //Create a button for our sidebar.
                ARA_Button projectSideBarButton = new ARA_Button();
                projectSideBarButton.Text = this.OpenProjectDataGrid.Rows[e.RowIndex].Cells["machineNumberDataGridViewTextBoxColumn"].Value.ToString();

                //Get selected project id.
                int projectIDToOpen = (Int32)this.OpenProjectDataGrid.Rows[e.RowIndex].Cells["ProjectID"].Value;

                //Log this event.
                ARA_Events.triggerProjectOpendEvent(projectIDToOpen);

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
        private void OpenProjectDataGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in this.OpenProjectDataGrid.Rows)
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

        /// <summary>
        /// Clear selection when the user sets the selection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenProjectDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            this.OpenProjectDataGrid.ClearSelection();
        }
    }
}
