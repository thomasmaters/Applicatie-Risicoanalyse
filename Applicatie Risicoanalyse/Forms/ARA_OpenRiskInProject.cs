﻿using System;
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
    public partial class ARA_OpenRiskInProject : Form
    {
        public ARA_OpenRiskInProject()
        {
            InitializeComponent();

            //On form load show datagrid items.
            this.OpenRiskInProjectDataGrid.DataSource = this.search_ProjectRisksTableAdapter.GetData(1, "");
            this.OpenRiskInProjectDataGrid.Refresh();
        }

        private void arA_TextBox1_TextChanged(object sender, EventArgs e)
        {
            int tempScrollPosition = this.OpenRiskInProjectDataGrid.FirstDisplayedScrollingRowIndex;

            this.OpenRiskInProjectDataGrid.DataSource = this.search_ProjectRisksTableAdapter.GetData(1, this.arA_TextBox1.Text);
            this.OpenRiskInProjectDataGrid.Refresh();

            if (tempScrollPosition != -1 && tempScrollPosition < this.OpenRiskInProjectDataGrid.Rows.Count)
            {
                this.OpenRiskInProjectDataGrid.FirstDisplayedScrollingRowIndex = tempScrollPosition;
            }
        }

        private void OpenRiskInProjectDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {//TODO remove default value.
                Globals.ARA_Events.onOpenContentFormEvent(new ARA_EditRiskBaseForm(1/*(Int32)this.OpenRiskInProjectDataGrid.Rows[e.RowIndex].Cells["riskIDDataGridViewTextBoxColumn"].Value*/));
            }
        }
    }
}