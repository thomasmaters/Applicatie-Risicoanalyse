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
    public partial class ARA_SearchRiskStandard : Form
    {
        public ARA_SearchRiskStandard()
        {
            InitializeComponent();

            this.OpenProjectDataGrid.DataSource = this.search_Risk_StandardTableAdapter.GetData(this.OpenProjectTextBoxSearch.Text);
            this.OpenProjectDataGrid.Sort(this.OpenProjectDataGrid.Columns[0],ListSortDirection.Ascending);
        }

        private void OpenProjectTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            int tempScrollPosition = this.OpenProjectDataGrid.FirstDisplayedScrollingRowIndex;

            this.OpenProjectDataGrid.DataSource = this.search_Risk_StandardTableAdapter.GetData(this.OpenProjectTextBoxSearch.Text);

            if (tempScrollPosition != -1 && tempScrollPosition < this.OpenProjectDataGrid.Rows.Count)
            {
                this.OpenProjectDataGrid.FirstDisplayedScrollingRowIndex = tempScrollPosition;
            }
        }

        private void OpenProjectDataGrid_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int selectedRiskID = (Int32)this.OpenProjectDataGrid.Rows[e.RowIndex].Cells["riskIDDataGridViewTextBoxColumn"].Value;
                int selectedRiskDataID = (Int32)this.OpenProjectDataGrid.Rows[e.RowIndex].Cells["RiskDataID"].Value;
                int selectedRiskVersionID = (Int32)this.OpenProjectDataGrid.Rows[e.RowIndex].Cells["VersionID"].Value;
                bool isProjectSpecificRisk = false;

                //Open risk with its risk data.
                Globals.ARA_Events.onOpenContentFormEvent(new ARA_EditRiskBaseForm(selectedRiskID, selectedRiskVersionID, selectedRiskDataID, -1, isProjectSpecificRisk));
            }
        }
    }
}
