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

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class ARA_OpenProject : Form
    {
        public ARA_OpenProject()
        {
            InitializeComponent();
        }

        private void ARA_OpenProject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Risk_Analysis' table. You can move, or remove it, as needed.
            this.tbl_Risk_AnalysisTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Risk_Analysis);
            this.OpenProjectDataGrid.DataSource = new DataView(this.tbl_Risk_AnalysisTableAdapter.GetData());
            this.OpenProjectDataGrid.Sort(StateID, ListSortDirection.Ascending);
        }

        private void arA_TextBox1_TextChanged(object sender, EventArgs e)
        {
            int tempScrollPosition = this.OpenProjectDataGrid.FirstDisplayedScrollingRowIndex;

            (this.OpenProjectDataGrid.DataSource as DataView).RowFilter = 
                string.Format("Customer LIKE '%{0}%' OR MachineType LIKE '%{0}%' OR MachineNumber LIKE '%{0}%' OR OrderNumber LIKE '%{0}%'", this.OpenProjectTextBoxSearch.Text);

            if (tempScrollPosition != -1 && tempScrollPosition < this.OpenProjectDataGrid.Rows.Count)
            {
                this.OpenProjectDataGrid.FirstDisplayedScrollingRowIndex = tempScrollPosition;
            }
        }

        private void OpenProjectDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //Create a button for our sidebar.
                ARA_Button projectSideBarButton = new ARA_Button();
                projectSideBarButton.Text = this.OpenProjectDataGrid.Rows[e.RowIndex].Cells["machineNumberDataGridViewTextBoxColumn"].Value.ToString();

                //Get selected project id.
                int projectIDToOpen = (Int32)this.OpenProjectDataGrid.Rows[e.RowIndex].Cells["ProjectID"].Value;

                //Trigger event to add a button to the sidebar and attach this form to it.
                Applicatie_Risicoanalyse.Globals.ARA_Events.onSideBarAddNewButtonEvent(
                    projectSideBarButton,
                    Activator.CreateInstance(typeof(ARA_RiskProjectOverview), projectIDToOpen));
            }
        }

    }
}
