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
        }

        public void loadPermissions()
        {
            this.arA_Button1.Visible = ARA_ACL.getPermissionLevel("General.ButtonOpenAdminPanel") == ARA_Globals.PermissionLevel.All;
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

        private void arA_Button1_Click(object sender, EventArgs e)
        {
            ARA_Events.onOpenContentFormEvent(new ARA_AdministratorForm());
        }
    }
}
