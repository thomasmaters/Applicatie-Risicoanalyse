using Applicatie_Risicoanalyse.Globals;
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
    public partial class ARA_AdministratorForm : Form
    {
        public ARA_AdministratorForm()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = this.tbl_UserTableAdapter.GetData();
        }

        private void ARA_AdministratorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_User' table. You can move, or remove it, as needed.
            this.tbl_UserTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_User);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_User_Permissions' table. You can move, or remove it, as needed.
            this.tbl_User_PermissionsTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_User_Permissions);

        }

        /// <summary>
        /// Handler when an admin wants to add a new user to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onAddNewUserClicked(object sender, EventArgs e)
        {
            //Check if the the input values are correct.
            if(this.adminComboBoxPermissionGroup.SelectedIndex != -1 && this.adminInputNewUsername.Text.Length > 0)
            {
                //Generate password and convert it to a hash.
                ARA_Login loginHandler = new ARA_Login();
                string randomPassword = loginHandler.generateRandomPassword(ARA_Constants.randomPasswordLength);
                byte[] passwordHash = loginHandler.getHashFromByteArray(loginHandler.GetBytes(randomPassword));

                //Insert new user in the database.
                this.tbl_UserTableAdapter.Insert((Int32)this.adminComboBoxPermissionGroup.SelectedValue, passwordHash, this.adminInputNewUsername.Text);
                this.dataGridView1.DataSource = this.tbl_UserTableAdapter.GetData();

                //Give the admin a pop-up and copy the new password to the users clipboard.
                MessageBox.Show(ARA_Constants.messageBoxLoginNewUser + randomPassword + ARA_Constants.messageBoxLoginNewUser1, ARA_Constants.messageBoxLoginNewUserHeader, MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Windows.Forms.Clipboard.SetText(randomPassword);

                //Clean the login handler form memory.
                loginHandler = null;
            }
        }

        /// <summary>
        /// Handler when the user wants to set the permissiongroup of a selected user in the datagrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onSetUserPermissionButtonClicked(object sender, EventArgs e)
        {
            //Did the user select a permission group and a user.
            if (this.comboBox2.SelectedValue != null && this.dataGridView1.SelectedRows.Count > 0)
            {
                //Get selected row in datagrid datasource.
                DataTable table = dataGridView1.DataSource as DataTable;
                DataRow temp = table.Rows[this.dataGridView1.SelectedRows[0].Index];

                //Set users permission id and execute a update query.
                temp["PermissionID"] = (Int32)this.comboBox2.SelectedValue;
                this.tbl_UserTableAdapter.Update(temp);

                //Update datagrid datasource.
                this.dataGridView1.DataSource = this.tbl_UserTableAdapter.GetData();
            }
        }
    }
}
