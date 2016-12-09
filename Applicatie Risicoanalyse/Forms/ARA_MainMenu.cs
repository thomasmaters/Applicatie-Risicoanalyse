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
            this.mainMenuDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font(ARA_Globals.ARA_Font, ARA_Globals.ARA_BaseFontSize - 3);
            this.mainMenuDataGrid.DefaultCellStyle.Font = new Font(ARA_Globals.ARA_Font, ARA_Globals.ARA_BaseFontSize - 6);

            //Add event to update datagrid when a new logmessage is added.
            ARA_Events.NewLogMessageEventHandler += ARA_Events_NewLogMessageEventHandler;

            //Set datagrid datasource.
            this.mainMenuDataGrid.DataSource = this.get_Latest_ActivityTableAdapter.GetData();
        }

        private void ARA_Events_NewLogMessageEventHandler(object sender, NewLogMessageEvent e)
        {
            //Update datagrid datasource.
            this.mainMenuDataGrid.DataSource = this.get_Latest_ActivityTableAdapter.GetData();
        }

        public void loadPermissions()
        {
            this.mainMenuButtonOpenAdminPanel.Visible = ARA_ACL.getPermissionLevel("General.ButtonOpenAdminPanel") == ARA_Globals.PermissionLevel.All;
        }

        private void ARA_MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Get_Latest_Activity' table. You can move, or remove it, as needed.
            this.get_Latest_ActivityTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Get_Latest_Activity);

            //Set scaling.
            this.Font = new System.Drawing.Font(ARA_Globals.ARA_Font, Applicatie_Risicoanalyse.Globals.ARA_Globals.ARA_BaseFontSize);
        }

        /// <summary>
        /// Clear selection when the user tries to select a row.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onMainMenuTableSelectionChanged(object sender, EventArgs e)
        {
            this.mainMenuDataGrid.ClearSelection();
        }

        /// <summary>
        /// Handler when the user wants to open the admin panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainMenuButtonOpenAdminPanel_Click(object sender, EventArgs e)
        {
            ARA_Events.triggerOpenContentFormEvent(new ARA_AdministratorForm());
        }
    }
}
