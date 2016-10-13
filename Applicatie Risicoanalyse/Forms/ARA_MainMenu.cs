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

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class ARA_MainMenu : Form
    {
        public ARA_MainMenu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ARA_MainMenu_Load(object sender, EventArgs e)
        {
            //Set scaling.
            this.Font = new System.Drawing.Font("Gotham Light", Applicatie_Risicoanalyse.Globals.ARA_Globals.ARA_BaseFontSize);

            //Load database data.
            this.tbl_LogTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Log);
        }

        private void onMainMenuTableSelectionChanged(object sender, EventArgs e)
        {
            this.MainMenuTable.ClearSelection();
        }
    }
}
