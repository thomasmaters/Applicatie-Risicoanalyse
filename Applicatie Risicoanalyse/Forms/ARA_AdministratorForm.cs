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

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbl_UserTableAdapter.Insert(this.textBox1.Text, this.textBox2.Text, (Int32)this.comboBox1.SelectedValue);
            this.dataGridView1.DataSource = this.tbl_UserTableAdapter.GetData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable table = dataGridView1.DataSource as DataTable;
            DataRow temp = table.Rows[this.dataGridView1.SelectedRows[0].Index];
            temp["PermissionID"] = (Int32)this.comboBox2.SelectedValue;
            this.tbl_UserTableAdapter.Update(temp);

            this.dataGridView1.DataSource = this.tbl_UserTableAdapter.GetData();
        }
    }
}