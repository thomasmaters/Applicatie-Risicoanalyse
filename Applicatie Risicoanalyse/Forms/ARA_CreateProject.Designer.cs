namespace Applicatie_Risicoanalyse.Forms
{
    partial class ARA_CreateProject
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
            this.createProjectContentBox = new System.Windows.Forms.FlowLayoutPanel();
            this.createProjectSpacer1 = new System.Windows.Forms.Panel();
            this.createProjectControlBoxLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.createProjectTextCustomer = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.createProjectInputCustomer = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            this.createProjectSpacer4 = new System.Windows.Forms.Panel();
            this.createProjectTextMachineType = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.createProjectSpacer5 = new System.Windows.Forms.Panel();
            this.createProjectInputMachineType = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            this.createProjectTextMachineNumber = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.createProjectTextOrderNumber = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.panel1 = new System.Windows.Forms.Panel();
            this.createProjectInputOrderNumber = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            this.createProjectInputMachineNumber = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            this.createProjectSpacer2 = new System.Windows.Forms.Panel();
            this.createProjectControlBoxRight = new System.Windows.Forms.FlowLayoutPanel();
            this.createProjectTextExtraInfo = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.createProjectInputExtraInfo = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            this.createProjectSpacer3 = new System.Windows.Forms.FlowLayoutPanel();
            this.createProjectButtonCreateProject = new Applicatie_Risicoanalyse.Controls.ARA_Button();
            this.createProjectDatabaseAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.QueriesTableAdapter();
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.get_Newest_Added_ProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_Newest_Added_ProjectTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_Newest_Added_ProjectTableAdapter();
            this.tableAdapterManager = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.createProjectContentBox.SuspendLayout();
            this.createProjectControlBoxLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.createProjectControlBoxRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Newest_Added_ProjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // createProjectContentBox
            // 
            this.createProjectContentBox.AutoScroll = true;
            this.createProjectContentBox.BackColor = System.Drawing.Color.White;
            this.createProjectContentBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createProjectContentBox.Controls.Add(this.createProjectSpacer1);
            this.createProjectContentBox.Controls.Add(this.createProjectControlBoxLeft);
            this.createProjectContentBox.Controls.Add(this.createProjectSpacer2);
            this.createProjectContentBox.Controls.Add(this.createProjectControlBoxRight);
            this.createProjectContentBox.Location = new System.Drawing.Point(0, 0);
            this.createProjectContentBox.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectContentBox.MaximumSize = new System.Drawing.Size(750, 190);
            this.createProjectContentBox.Name = "createProjectContentBox";
            this.createProjectContentBox.Size = new System.Drawing.Size(750, 190);
            this.createProjectContentBox.TabIndex = 0;
            // 
            // createProjectSpacer1
            // 
            this.createProjectSpacer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.createProjectSpacer1.Location = new System.Drawing.Point(0, 0);
            this.createProjectSpacer1.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectSpacer1.MaximumSize = new System.Drawing.Size(20, 189);
            this.createProjectSpacer1.Name = "createProjectSpacer1";
            this.createProjectSpacer1.Size = new System.Drawing.Size(20, 189);
            this.createProjectSpacer1.TabIndex = 1;
            // 
            // createProjectControlBoxLeft
            // 
            this.createProjectControlBoxLeft.Controls.Add(this.createProjectTextCustomer);
            this.createProjectControlBoxLeft.Controls.Add(this.createProjectInputCustomer);
            this.createProjectControlBoxLeft.Controls.Add(this.createProjectSpacer4);
            this.createProjectControlBoxLeft.Controls.Add(this.createProjectTextMachineType);
            this.createProjectControlBoxLeft.Controls.Add(this.createProjectSpacer5);
            this.createProjectControlBoxLeft.Controls.Add(this.createProjectInputMachineType);
            this.createProjectControlBoxLeft.Controls.Add(this.createProjectTextMachineNumber);
            this.createProjectControlBoxLeft.Controls.Add(this.createProjectTextOrderNumber);
            this.createProjectControlBoxLeft.Controls.Add(this.panel1);
            this.createProjectControlBoxLeft.Location = new System.Drawing.Point(20, 0);
            this.createProjectControlBoxLeft.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectControlBoxLeft.MaximumSize = new System.Drawing.Size(345, 190);
            this.createProjectControlBoxLeft.Name = "createProjectControlBoxLeft";
            this.createProjectControlBoxLeft.Size = new System.Drawing.Size(345, 190);
            this.createProjectControlBoxLeft.TabIndex = 4;
            // 
            // createProjectTextCustomer
            // 
            this.createProjectTextCustomer.BackgroundColor = System.Drawing.Color.White;
            this.createProjectTextCustomer.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.createProjectTextCustomer.Location = new System.Drawing.Point(0, 0);
            this.createProjectTextCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectTextCustomer.MaximumSize = new System.Drawing.Size(344, 27);
            this.createProjectTextCustomer.Name = "createProjectTextCustomer";
            this.createProjectTextCustomer.Size = new System.Drawing.Size(344, 27);
            this.createProjectTextCustomer.TabIndex = 2;
            this.createProjectTextCustomer.Text = "Customer";
            this.createProjectTextCustomer.VerticalAlignment = System.Drawing.StringAlignment.Far;
            // 
            // createProjectInputCustomer
            // 
            this.createProjectInputCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.createProjectInputCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.createProjectInputCustomer.BorderSize = 1;
            this.createProjectInputCustomer.Location = new System.Drawing.Point(0, 27);
            this.createProjectInputCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectInputCustomer.MaximumSize = new System.Drawing.Size(345, 28);
            this.createProjectInputCustomer.MaxLength = 64;
            this.createProjectInputCustomer.Name = "createProjectInputCustomer";
            this.createProjectInputCustomer.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.createProjectInputCustomer.Size = new System.Drawing.Size(345, 28);
            this.createProjectInputCustomer.TabIndex = 0;
            this.createProjectInputCustomer.Text = "";
            this.createProjectInputCustomer.TextChanged += new System.EventHandler(this.canProjectBeCreated);
            // 
            // createProjectSpacer4
            // 
            this.createProjectSpacer4.Location = new System.Drawing.Point(0, 55);
            this.createProjectSpacer4.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectSpacer4.MaximumSize = new System.Drawing.Size(344, 3);
            this.createProjectSpacer4.Name = "createProjectSpacer4";
            this.createProjectSpacer4.Size = new System.Drawing.Size(344, 3);
            this.createProjectSpacer4.TabIndex = 9;
            // 
            // createProjectTextMachineType
            // 
            this.createProjectTextMachineType.BackgroundColor = System.Drawing.Color.White;
            this.createProjectTextMachineType.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.createProjectTextMachineType.Location = new System.Drawing.Point(0, 58);
            this.createProjectTextMachineType.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectTextMachineType.MaximumSize = new System.Drawing.Size(344, 27);
            this.createProjectTextMachineType.Name = "createProjectTextMachineType";
            this.createProjectTextMachineType.Size = new System.Drawing.Size(344, 27);
            this.createProjectTextMachineType.TabIndex = 4;
            this.createProjectTextMachineType.Text = "Machine type";
            this.createProjectTextMachineType.VerticalAlignment = System.Drawing.StringAlignment.Far;
            // 
            // createProjectSpacer5
            // 
            this.createProjectSpacer5.Location = new System.Drawing.Point(0, 85);
            this.createProjectSpacer5.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectSpacer5.MaximumSize = new System.Drawing.Size(344, 3);
            this.createProjectSpacer5.Name = "createProjectSpacer5";
            this.createProjectSpacer5.Size = new System.Drawing.Size(344, 3);
            this.createProjectSpacer5.TabIndex = 10;
            // 
            // createProjectInputMachineType
            // 
            this.createProjectInputMachineType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.createProjectInputMachineType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.createProjectInputMachineType.BorderSize = 1;
            this.createProjectInputMachineType.Location = new System.Drawing.Point(0, 88);
            this.createProjectInputMachineType.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectInputMachineType.MaximumSize = new System.Drawing.Size(345, 28);
            this.createProjectInputMachineType.MaxLength = 32;
            this.createProjectInputMachineType.Name = "createProjectInputMachineType";
            this.createProjectInputMachineType.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.createProjectInputMachineType.Size = new System.Drawing.Size(345, 28);
            this.createProjectInputMachineType.TabIndex = 11;
            this.createProjectInputMachineType.Text = "";
            this.createProjectInputMachineType.TextChanged += new System.EventHandler(this.canProjectBeCreated);
            // 
            // createProjectTextMachineNumber
            // 
            this.createProjectTextMachineNumber.BackgroundColor = System.Drawing.Color.White;
            this.createProjectTextMachineNumber.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.createProjectTextMachineNumber.Location = new System.Drawing.Point(0, 116);
            this.createProjectTextMachineNumber.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectTextMachineNumber.MaximumSize = new System.Drawing.Size(344, 27);
            this.createProjectTextMachineNumber.Name = "createProjectTextMachineNumber";
            this.createProjectTextMachineNumber.Size = new System.Drawing.Size(181, 27);
            this.createProjectTextMachineNumber.TabIndex = 5;
            this.createProjectTextMachineNumber.Text = "Machine number";
            this.createProjectTextMachineNumber.VerticalAlignment = System.Drawing.StringAlignment.Far;
            // 
            // createProjectTextOrderNumber
            // 
            this.createProjectTextOrderNumber.BackgroundColor = System.Drawing.Color.White;
            this.createProjectTextOrderNumber.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.createProjectTextOrderNumber.Location = new System.Drawing.Point(181, 116);
            this.createProjectTextOrderNumber.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectTextOrderNumber.MaximumSize = new System.Drawing.Size(344, 27);
            this.createProjectTextOrderNumber.Name = "createProjectTextOrderNumber";
            this.createProjectTextOrderNumber.Size = new System.Drawing.Size(164, 27);
            this.createProjectTextOrderNumber.TabIndex = 6;
            this.createProjectTextOrderNumber.Text = "Order number";
            this.createProjectTextOrderNumber.VerticalAlignment = System.Drawing.StringAlignment.Far;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.createProjectInputOrderNumber);
            this.panel1.Controls.Add(this.createProjectInputMachineNumber);
            this.panel1.Location = new System.Drawing.Point(0, 143);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(345, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 28);
            this.panel1.TabIndex = 10;
            // 
            // createProjectInputOrderNumber
            // 
            this.createProjectInputOrderNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createProjectInputOrderNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.createProjectInputOrderNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.createProjectInputOrderNumber.BorderSize = 1;
            this.createProjectInputOrderNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createProjectInputOrderNumber.Location = new System.Drawing.Point(184, 0);
            this.createProjectInputOrderNumber.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectInputOrderNumber.MaximumSize = new System.Drawing.Size(162, 28);
            this.createProjectInputOrderNumber.MaxLength = 8;
            this.createProjectInputOrderNumber.Name = "createProjectInputOrderNumber";
            this.createProjectInputOrderNumber.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.createProjectInputOrderNumber.Size = new System.Drawing.Size(161, 28);
            this.createProjectInputOrderNumber.TabIndex = 8;
            this.createProjectInputOrderNumber.Text = "";
            this.createProjectInputOrderNumber.TextChanged += new System.EventHandler(this.canProjectBeCreated);
            // 
            // createProjectInputMachineNumber
            // 
            this.createProjectInputMachineNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.createProjectInputMachineNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.createProjectInputMachineNumber.BorderSize = 1;
            this.createProjectInputMachineNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createProjectInputMachineNumber.Location = new System.Drawing.Point(0, 0);
            this.createProjectInputMachineNumber.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectInputMachineNumber.MaximumSize = new System.Drawing.Size(162, 28);
            this.createProjectInputMachineNumber.MaxLength = 8;
            this.createProjectInputMachineNumber.Name = "createProjectInputMachineNumber";
            this.createProjectInputMachineNumber.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.createProjectInputMachineNumber.Size = new System.Drawing.Size(162, 28);
            this.createProjectInputMachineNumber.TabIndex = 7;
            this.createProjectInputMachineNumber.Text = "";
            this.createProjectInputMachineNumber.TextChanged += new System.EventHandler(this.canProjectBeCreated);
            // 
            // createProjectSpacer2
            // 
            this.createProjectSpacer2.AutoScroll = true;
            this.createProjectSpacer2.Location = new System.Drawing.Point(365, 0);
            this.createProjectSpacer2.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectSpacer2.MaximumSize = new System.Drawing.Size(20, 189);
            this.createProjectSpacer2.Name = "createProjectSpacer2";
            this.createProjectSpacer2.Size = new System.Drawing.Size(20, 189);
            this.createProjectSpacer2.TabIndex = 2;
            // 
            // createProjectControlBoxRight
            // 
            this.createProjectControlBoxRight.Controls.Add(this.createProjectTextExtraInfo);
            this.createProjectControlBoxRight.Controls.Add(this.createProjectInputExtraInfo);
            this.createProjectControlBoxRight.Controls.Add(this.createProjectSpacer3);
            this.createProjectControlBoxRight.Controls.Add(this.createProjectButtonCreateProject);
            this.createProjectControlBoxRight.Location = new System.Drawing.Point(385, 0);
            this.createProjectControlBoxRight.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectControlBoxRight.MaximumSize = new System.Drawing.Size(345, 190);
            this.createProjectControlBoxRight.Name = "createProjectControlBoxRight";
            this.createProjectControlBoxRight.Size = new System.Drawing.Size(345, 190);
            this.createProjectControlBoxRight.TabIndex = 5;
            // 
            // createProjectTextExtraInfo
            // 
            this.createProjectTextExtraInfo.BackgroundColor = System.Drawing.Color.White;
            this.createProjectTextExtraInfo.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.createProjectTextExtraInfo.Location = new System.Drawing.Point(0, 0);
            this.createProjectTextExtraInfo.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectTextExtraInfo.MaximumSize = new System.Drawing.Size(344, 27);
            this.createProjectTextExtraInfo.Name = "createProjectTextExtraInfo";
            this.createProjectTextExtraInfo.Size = new System.Drawing.Size(344, 27);
            this.createProjectTextExtraInfo.TabIndex = 12;
            this.createProjectTextExtraInfo.Text = "Extra information";
            this.createProjectTextExtraInfo.VerticalAlignment = System.Drawing.StringAlignment.Far;
            // 
            // createProjectInputExtraInfo
            // 
            this.createProjectInputExtraInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.createProjectInputExtraInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.createProjectInputExtraInfo.BorderSize = 1;
            this.createProjectInputExtraInfo.Location = new System.Drawing.Point(0, 27);
            this.createProjectInputExtraInfo.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectInputExtraInfo.MaximumSize = new System.Drawing.Size(345, 89);
            this.createProjectInputExtraInfo.MaxLength = 512;
            this.createProjectInputExtraInfo.Name = "createProjectInputExtraInfo";
            this.createProjectInputExtraInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.createProjectInputExtraInfo.Size = new System.Drawing.Size(345, 89);
            this.createProjectInputExtraInfo.TabIndex = 12;
            this.createProjectInputExtraInfo.Text = "";
            // 
            // createProjectSpacer3
            // 
            this.createProjectSpacer3.Location = new System.Drawing.Point(0, 116);
            this.createProjectSpacer3.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectSpacer3.Name = "createProjectSpacer3";
            this.createProjectSpacer3.Size = new System.Drawing.Size(344, 27);
            this.createProjectSpacer3.TabIndex = 13;
            // 
            // createProjectButtonCreateProject
            // 
            this.createProjectButtonCreateProject.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(185)))), ((int)(((byte)(72)))));
            this.createProjectButtonCreateProject.CanButtonBeToggled = false;
            this.createProjectButtonCreateProject.Enabled = false;
            this.createProjectButtonCreateProject.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.createProjectButtonCreateProject.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(185)))), ((int)(((byte)(72)))));
            this.createProjectButtonCreateProject.Location = new System.Drawing.Point(0, 143);
            this.createProjectButtonCreateProject.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectButtonCreateProject.MaximumSize = new System.Drawing.Size(345, 27);
            this.createProjectButtonCreateProject.Name = "createProjectButtonCreateProject";
            this.createProjectButtonCreateProject.Selected = false;
            this.createProjectButtonCreateProject.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.createProjectButtonCreateProject.SelectedTextColor = System.Drawing.Color.White;
            this.createProjectButtonCreateProject.Size = new System.Drawing.Size(345, 27);
            this.createProjectButtonCreateProject.TabIndex = 14;
            this.createProjectButtonCreateProject.Text = "Create project";
            this.createProjectButtonCreateProject.TextColor = System.Drawing.Color.White;
            this.createProjectButtonCreateProject.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.createProjectButtonCreateProject.Click += new System.EventHandler(this.onCreateProjectButtonClick);
            // 
            // lG_Analysis_DatabaseDataSet
            // 
            this.lG_Analysis_DatabaseDataSet.DataSetName = "LG_Analysis_DatabaseDataSet";
            this.lG_Analysis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // get_Newest_Added_ProjectBindingSource
            // 
            this.get_Newest_Added_ProjectBindingSource.DataMember = "Get_Newest_Added_Project";
            this.get_Newest_Added_ProjectBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_Newest_Added_ProjectTableAdapter
            // 
            this.get_Newest_Added_ProjectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Tbl_BLOB_StorageTableAdapter = null;
            this.tableAdapterManager.Tbl_Component_GroupTableAdapter = null;
            this.tableAdapterManager.Tbl_Component_TypeTableAdapter = null;
            this.tableAdapterManager.Tbl_Danger_ResultTableAdapter = null;
            this.tableAdapterManager.Tbl_Danger_SourceTableAdapter = null;
            this.tableAdapterManager.Tbl_DangerTableAdapter = null;
            this.tableAdapterManager.Tbl_ExposedPersons_In_RiskTableAdapter = null;
            this.tableAdapterManager.Tbl_ExposedPersonsTableAdapter = null;
            this.tableAdapterManager.Tbl_LogTableAdapter = null;
            this.tableAdapterManager.Tbl_MinimalAddition_In_RiskTableAdapter = null;
            this.tableAdapterManager.Tbl_ProjectTableAdapter = null;
            this.tableAdapterManager.Tbl_Risk_AnalysisTableAdapter = null;
            this.tableAdapterManager.Tbl_Risk_DataTableAdapter = null;
            this.tableAdapterManager.Tbl_Risk_Project_StateTableAdapter = null;
            this.tableAdapterManager.Tbl_RiskEstimation_In_Risk_AfterTableAdapter = null;
            this.tableAdapterManager.Tbl_RiskEstimation_In_Risk_BeforeTableAdapter = null;
            this.tableAdapterManager.Tbl_RiskEstimationTableAdapter = null;
            this.tableAdapterManager.Tbl_RiskReduction_In_RiskTableAdapter = null;
            this.tableAdapterManager.Tbl_RiskReductionMeasuresTableAdapter = null;
            this.tableAdapterManager.Tbl_Risks_In_ProjectTableAdapter = null;
            this.tableAdapterManager.Tbl_RiskTableAdapter = null;
            this.tableAdapterManager.Tbl_User_PermissionsTableAdapter = null;
            this.tableAdapterManager.Tbl_UserTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ARA_CreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 190);
            this.Controls.Add(this.createProjectContentBox);
            this.Font = new System.Drawing.Font("Gotham Light", 15F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(750, 190);
            this.Name = "ARA_CreateProject";
            this.Text = "ARA_CreateProject";
            this.Load += new System.EventHandler(this.onCreateProjectLoad);
            this.createProjectContentBox.ResumeLayout(false);
            this.createProjectControlBoxLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.createProjectControlBoxRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Newest_Added_ProjectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel createProjectContentBox;
        private Controls.ARA_TextBox createProjectInputCustomer;
        private Controls.ARA_Text createProjectTextCustomer;
        private System.Windows.Forms.FlowLayoutPanel createProjectControlBoxLeft;
        private System.Windows.Forms.FlowLayoutPanel createProjectControlBoxRight;
        private System.Windows.Forms.Panel createProjectSpacer4;
        private Controls.ARA_Text createProjectTextMachineType;
        private System.Windows.Forms.Panel createProjectSpacer5;
        private Controls.ARA_Text createProjectTextMachineNumber;
        private Controls.ARA_Text createProjectTextOrderNumber;
        private Controls.ARA_TextBox createProjectInputMachineNumber;
        private Controls.ARA_TextBox createProjectInputOrderNumber;
        private System.Windows.Forms.Panel createProjectSpacer1;
        private Controls.ARA_TextBox createProjectInputMachineType;
        private Controls.ARA_TextBox createProjectInputExtraInfo;
        private System.Windows.Forms.Panel createProjectSpacer2;
        private Controls.ARA_Text createProjectTextExtraInfo;
        private System.Windows.Forms.FlowLayoutPanel createProjectSpacer3;
        private Controls.ARA_Button createProjectButtonCreateProject;
        private System.Windows.Forms.Panel panel1;
        private LG_Analysis_DatabaseDataSetTableAdapters.QueriesTableAdapter createProjectDatabaseAdapter;
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private System.Windows.Forms.BindingSource get_Newest_Added_ProjectBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_Newest_Added_ProjectTableAdapter get_Newest_Added_ProjectTableAdapter;
        private LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}