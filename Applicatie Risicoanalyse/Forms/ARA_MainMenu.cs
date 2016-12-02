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
using Applicatie_Risicoanalyse.Globals;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class ARA_MainMenu : Form
    {
        public ARA_MainMenu()
        {
            InitializeComponent();

            loadPermissions();

            //Special scaling for the datagrid.
            this.mainMenuDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Gotham Light", ARA_Globals.ARA_BaseFontSize - 3);
            this.mainMenuDataGrid.DefaultCellStyle.Font = new Font("Gotham Light", ARA_Globals.ARA_BaseFontSize - 6);

            //Set datagrid sorting.
            DataView tempLogView = tbl_LogTableAdapter.GetData().DefaultView;
            tempLogView.Sort = "LogDate DESC";
            
            this.mainMenuDataGrid.DataSource = tempLogView;
        }

        public void loadPermissions()
        {
            this.arA_Button1.Visible = ARA_ACL.getPermissionLevel("General.ButtonOpenAdminPanel") == ARA_Globals.PermissionLevel.All;
        }

        private void ARA_MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Get_Latest_Activity' table. You can move, or remove it, as needed.
            this.get_Latest_ActivityTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Get_Latest_Activity);
            //Set scaling.
            this.Font = new System.Drawing.Font("Gotham Light", Applicatie_Risicoanalyse.Globals.ARA_Globals.ARA_BaseFontSize);

            //Load database data.
            this.tbl_LogTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Log);
        }

        private void onMainMenuTableSelectionChanged(object sender, EventArgs e)
        {
            this.mainMenuDataGrid.ClearSelection();
        }

        private void arA_Button1_Click(object sender, EventArgs e)
        {
            ARA_Events.triggerOpenContentFormEvent(new ARA_AdministratorForm());
        }
    }
}
