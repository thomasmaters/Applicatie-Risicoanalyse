namespace Applicatie_Risicoanalyse.Forms
{
    partial class ARA_AdministratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.arA_Text5 = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.arA_Text1 = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.adminInputNewUsername = new System.Windows.Forms.TextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.arA_Text3 = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.adminComboBoxPermissionGroup = new System.Windows.Forms.ComboBox();
            this.tblUserPermissionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.adminButtonAddUser = new System.Windows.Forms.Button();
            this.arA_Text4 = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.adminSetPermissionGroup = new System.Windows.Forms.Button();
            this.tbl_User_PermissionsTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_User_PermissionsTableAdapter();
            this.tbl_UserTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_UserTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserPermissionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.arA_Text5);
            this.flowLayoutPanel1.Controls.Add(this.arA_Text1);
            this.flowLayoutPanel1.Controls.Add(this.splitter1);
            this.flowLayoutPanel1.Controls.Add(this.adminInputNewUsername);
            this.flowLayoutPanel1.Controls.Add(this.splitter2);
            this.flowLayoutPanel1.Controls.Add(this.arA_Text3);
            this.flowLayoutPanel1.Controls.Add(this.adminComboBoxPermissionGroup);
            this.flowLayoutPanel1.Controls.Add(this.splitter3);
            this.flowLayoutPanel1.Controls.Add(this.adminButtonAddUser);
            this.flowLayoutPanel1.Controls.Add(this.arA_Text4);
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Controls.Add(this.comboBox2);
            this.flowLayoutPanel1.Controls.Add(this.splitter4);
            this.flowLayoutPanel1.Controls.Add(this.adminSetPermissionGroup);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(750, 488);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // arA_Text5
            // 
            this.arA_Text5.BackgroundColor = System.Drawing.Color.White;
            this.arA_Text5.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.arA_Text5.Location = new System.Drawing.Point(0, 0);
            this.arA_Text5.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Text5.Name = "arA_Text5";
            this.arA_Text5.Size = new System.Drawing.Size(750, 23);
            this.arA_Text5.TabIndex = 12;
            this.arA_Text5.Text = "Add new user";
            this.arA_Text5.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // arA_Text1
            // 
            this.arA_Text1.BackgroundColor = System.Drawing.Color.White;
            this.arA_Text1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.arA_Text1.Location = new System.Drawing.Point(0, 23);
            this.arA_Text1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Text1.Name = "arA_Text1";
            this.arA_Text1.Size = new System.Drawing.Size(723, 23);
            this.arA_Text1.TabIndex = 2;
            this.arA_Text1.Text = "Username";
            this.arA_Text1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(726, 26);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 17);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // adminInputNewUsername
            // 
            this.adminInputNewUsername.Location = new System.Drawing.Point(0, 46);
            this.adminInputNewUsername.Margin = new System.Windows.Forms.Padding(0);
            this.adminInputNewUsername.Name = "adminInputNewUsername";
            this.adminInputNewUsername.Size = new System.Drawing.Size(199, 31);
            this.adminInputNewUsername.TabIndex = 1;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(202, 49);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 25);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // arA_Text3
            // 
            this.arA_Text3.BackgroundColor = System.Drawing.Color.White;
            this.arA_Text3.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.arA_Text3.Location = new System.Drawing.Point(0, 77);
            this.arA_Text3.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Text3.Name = "arA_Text3";
            this.arA_Text3.Size = new System.Drawing.Size(750, 23);
            this.arA_Text3.TabIndex = 8;
            this.arA_Text3.Text = "Permission group";
            this.arA_Text3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // adminComboBoxPermissionGroup
            // 
            this.adminComboBoxPermissionGroup.DataSource = this.tblUserPermissionsBindingSource;
            this.adminComboBoxPermissionGroup.DisplayMember = "PermissionName";
            this.adminComboBoxPermissionGroup.FormattingEnabled = true;
            this.adminComboBoxPermissionGroup.Location = new System.Drawing.Point(0, 100);
            this.adminComboBoxPermissionGroup.Margin = new System.Windows.Forms.Padding(0);
            this.adminComboBoxPermissionGroup.Name = "adminComboBoxPermissionGroup";
            this.adminComboBoxPermissionGroup.Size = new System.Drawing.Size(196, 32);
            this.adminComboBoxPermissionGroup.TabIndex = 7;
            this.adminComboBoxPermissionGroup.ValueMember = "PermissionID";
            // 
            // tblUserPermissionsBindingSource
            // 
            this.tblUserPermissionsBindingSource.DataMember = "Tbl_User_Permissions";
            this.tblUserPermissionsBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // lG_Analysis_DatabaseDataSet
            // 
            this.lG_Analysis_DatabaseDataSet.DataSetName = "LG_Analysis_DatabaseDataSet";
            this.lG_Analysis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(199, 103);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 26);
            this.splitter3.TabIndex = 9;
            this.splitter3.TabStop = false;
            // 
            // adminButtonAddUser
            // 
            this.adminButtonAddUser.Location = new System.Drawing.Point(205, 100);
            this.adminButtonAddUser.Margin = new System.Windows.Forms.Padding(0);
            this.adminButtonAddUser.Name = "adminButtonAddUser";
            this.adminButtonAddUser.Size = new System.Drawing.Size(202, 32);
            this.adminButtonAddUser.TabIndex = 0;
            this.adminButtonAddUser.Text = "Add user";
            this.adminButtonAddUser.UseVisualStyleBackColor = true;
            this.adminButtonAddUser.Click += new System.EventHandler(this.onAddNewUserClicked);
            // 
            // arA_Text4
            // 
            this.arA_Text4.BackgroundColor = System.Drawing.Color.White;
            this.arA_Text4.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.arA_Text4.Location = new System.Drawing.Point(0, 132);
            this.arA_Text4.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Text4.Name = "arA_Text4";
            this.arA_Text4.Size = new System.Drawing.Size(750, 23);
            this.arA_Text4.TabIndex = 11;
            this.arA_Text4.Text = "Change user permissions";
            this.arA_Text4.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.userIDDataGridViewTextBoxColumn,
            this.permissionIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblUserBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 158);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(742, 222);
            this.dataGridView1.TabIndex = 10;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.FillWeight = 60F;
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // permissionIDDataGridViewTextBoxColumn
            // 
            this.permissionIDDataGridViewTextBoxColumn.DataPropertyName = "PermissionID";
            this.permissionIDDataGridViewTextBoxColumn.FillWeight = 60F;
            this.permissionIDDataGridViewTextBoxColumn.HeaderText = "PermissionID";
            this.permissionIDDataGridViewTextBoxColumn.Name = "permissionIDDataGridViewTextBoxColumn";
            this.permissionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.permissionIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tblUserBindingSource
            // 
            this.tblUserBindingSource.DataMember = "Tbl_User";
            this.tblUserBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tblUserPermissionsBindingSource;
            this.comboBox2.DisplayMember = "PermissionName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(0, 383);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(196, 32);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.ValueMember = "PermissionID";
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(199, 386);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(3, 26);
            this.splitter4.TabIndex = 15;
            this.splitter4.TabStop = false;
            // 
            // adminSetPermissionGroup
            // 
            this.adminSetPermissionGroup.Location = new System.Drawing.Point(205, 383);
            this.adminSetPermissionGroup.Margin = new System.Windows.Forms.Padding(0);
            this.adminSetPermissionGroup.Name = "adminSetPermissionGroup";
            this.adminSetPermissionGroup.Size = new System.Drawing.Size(275, 32);
            this.adminSetPermissionGroup.TabIndex = 13;
            this.adminSetPermissionGroup.Text = "Set permission group";
            this.adminSetPermissionGroup.UseVisualStyleBackColor = true;
            this.adminSetPermissionGroup.Click += new System.EventHandler(this.onSetUserPermissionButtonClicked);
            // 
            // tbl_User_PermissionsTableAdapter
            // 
            this.tbl_User_PermissionsTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_UserTableAdapter
            // 
            this.tbl_UserTableAdapter.ClearBeforeFill = true;
            // 
            // ARA_AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "ARA_AdministratorForm";
            this.Text = "ARA_AdministratorForm";
            this.Load += new System.EventHandler(this.ARA_AdministratorForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserPermissionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controls.ARA_Text arA_Text1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox adminInputNewUsername;
        private System.Windows.Forms.Splitter splitter2;
        private Controls.ARA_Text arA_Text3;
        private System.Windows.Forms.ComboBox adminComboBoxPermissionGroup;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button adminButtonAddUser;
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private System.Windows.Forms.BindingSource tblUserPermissionsBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_User_PermissionsTableAdapter tbl_User_PermissionsTableAdapter;
        private Controls.ARA_Text arA_Text5;
        private Controls.ARA_Text arA_Text4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_UserTableAdapter tbl_UserTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Button adminSetPermissionGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionIDDataGridViewTextBoxColumn;
    }
}