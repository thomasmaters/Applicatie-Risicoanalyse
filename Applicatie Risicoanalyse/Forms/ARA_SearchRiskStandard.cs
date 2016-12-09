using System;
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
    public partial class ARA_SearchRiskStandard : Form
    {
        public ARA_SearchRiskStandard()
        {
            InitializeComponent();
            this.Font = new System.Drawing.Font(ARA_Globals.ARA_Font, ARA_Globals.ARA_BaseFontSize);
            foreach (Control control in this.Controls)
            {
                control.Font = this.Font;
            }
            
            //Special scaling for datagrid.
            this.OpenProjectDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font(ARA_Globals.ARA_Font, ARA_Globals.ARA_BaseFontSize - 3);
            this.OpenProjectDataGrid.DefaultCellStyle.Font = new Font(ARA_Globals.ARA_Font, ARA_Globals.ARA_BaseFontSize - 5);
        }

        /// <summary>
        /// Executes a search query to search the risk standard when something is typed in the searchbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenProjectTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            int tempScrollPosition = this.OpenProjectDataGrid.FirstDisplayedScrollingRowIndex;

            this.OpenProjectDataGrid.DataSource = this.search_Risk_StandardTableAdapter.GetData(this.OpenProjectTextBoxSearch.Text);

            if (tempScrollPosition != -1 && tempScrollPosition < this.OpenProjectDataGrid.Rows.Count)
            {
                this.OpenProjectDataGrid.FirstDisplayedScrollingRowIndex = tempScrollPosition;
            }
        }

        /// <summary>
        /// Open the risk edit form when a new a users clicks on a datagrid row.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenProjectDataGrid_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int selectedRiskID = (Int32)this.OpenProjectDataGrid.Rows[e.RowIndex].Cells["riskIDDataGridViewTextBoxColumn"].Value;
                int selectedRiskDataID = (Int32)this.OpenProjectDataGrid.Rows[e.RowIndex].Cells["RiskDataID"].Value;
                int selectedRiskVersionID = (Int32)this.OpenProjectDataGrid.Rows[e.RowIndex].Cells["VersionID"].Value;
                bool isProjectSpecificRisk = false;

                //Open risk with its risk data.
                Globals.ARA_Events.triggerOpenContentFormEvent(new ARA_EditRiskBaseForm(selectedRiskID, selectedRiskVersionID, selectedRiskDataID, -1, isProjectSpecificRisk));
            }
        }

        /// <summary>
        /// Updates the risks in the datagrid when the datagrid's visability changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ARA_SearchRiskStandard_VisibleChanged(object sender, EventArgs e)
        {
            this.OpenProjectDataGrid.DataSource = this.search_Risk_StandardTableAdapter.GetData(this.OpenProjectTextBoxSearch.Text);
            this.OpenProjectDataGrid.Sort(this.OpenProjectDataGrid.Columns[0], ListSortDirection.Ascending);
        }
    }
}
