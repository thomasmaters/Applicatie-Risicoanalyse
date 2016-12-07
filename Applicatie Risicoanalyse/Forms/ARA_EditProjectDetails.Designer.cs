namespace Applicatie_Risicoanalyse.Forms
{
    partial class ARA_EditProjectDetails
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
            this.tableAdapterManager = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.get_Newest_Added_ProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.createProjectDatabaseAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.QueriesTableAdapter();
            this.createProjectTextExtraInfo = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.editProjectDetailsInputExtraInfo = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            this.createProjectSpacer3 = new System.Windows.Forms.FlowLayoutPanel();
            this.createProjectButtonCreateProject = new Applicatie_Risicoanalyse.Controls.ARA_Button();
            this.createProjectSpacer2 = new System.Windows.Forms.Panel();
            this.createProjectControlBoxRight = new System.Windows.Forms.FlowLayoutPanel();
            this.get_Newest_Added_ProjectTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_Newest_Added_ProjectTableAdapter();
            this.editProjectDetailsInputOrderNumber = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            this.createProjectTextOrderNumber = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.editProjectDetailsInputMachineNumber = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            this.createProjectTextCustomer = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.editProjectDetailsInputCustomer = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            this.createProjectSpacer4 = new System.Windows.Forms.Panel();
            this.createProjectTextMachineType = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.createProjectSpacer5 = new System.Windows.Forms.Panel();
            this.editProjectDetailsInputMachineType = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            this.createProjectTextMachineNumber = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.createProjectSpacer1 = new System.Windows.Forms.Panel();
            this.createProjectControlBoxLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.createProjectContentBox = new System.Windows.Forms.FlowLayoutPanel();
            this.tbl_Risk_AnalysisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Risk_AnalysisTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_AnalysisTableAdapter();
            this.queriesTableAdapter1 = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.get_Newest_Added_ProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            this.createProjectControlBoxRight.SuspendLayout();
            this.createProjectControlBoxLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.createProjectContentBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Risk_AnalysisBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // get_Newest_Added_ProjectBindingSource
            // 
            this.get_Newest_Added_ProjectBindingSource.DataMember = "Get_Newest_Added_Project";
            this.get_Newest_Added_ProjectBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // lG_Analysis_DatabaseDataSet
            // 
            this.lG_Analysis_DatabaseDataSet.DataSetName = "LG_Analysis_DatabaseDataSet";
            this.lG_Analysis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.createProjectTextExtraInfo.TabIndex = 100;
            this.createProjectTextExtraInfo.Text = "Extra information";
            this.createProjectTextExtraInfo.VerticalAlignment = System.Drawing.StringAlignment.Far;
            // 
            // editProjectDetailsInputExtraInfo
            // 
            this.editProjectDetailsInputExtraInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.editProjectDetailsInputExtraInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.editProjectDetailsInputExtraInfo.BorderSize = 1;
            this.editProjectDetailsInputExtraInfo.Location = new System.Drawing.Point(0, 27);
            this.editProjectDetailsInputExtraInfo.Margin = new System.Windows.Forms.Padding(0);
            this.editProjectDetailsInputExtraInfo.MaximumSize = new System.Drawing.Size(345, 89);
            this.editProjectDetailsInputExtraInfo.MaxLength = 512;
            this.editProjectDetailsInputExtraInfo.Name = "editProjectDetailsInputExtraInfo";
            this.editProjectDetailsInputExtraInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.editProjectDetailsInputExtraInfo.Size = new System.Drawing.Size(345, 89);
            this.editProjectDetailsInputExtraInfo.TabIndex = 4;
            this.editProjectDetailsInputExtraInfo.Text = "";
            // 
            // createProjectSpacer3
            // 
            this.createProjectSpacer3.Location = new System.Drawing.Point(0, 116);
            this.createProjectSpacer3.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectSpacer3.Name = "createProjectSpacer3";
            this.createProjectSpacer3.Size = new System.Drawing.Size(344, 27);
            this.createProjectSpacer3.TabIndex = 100;
            // 
            // createProjectButtonCreateProject
            // 
            this.createProjectButtonCreateProject.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(185)))), ((int)(((byte)(72)))));
            this.createProjectButtonCreateProject.CanButtonBeToggled = false;
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
            this.createProjectButtonCreateProject.TabIndex = 5;
            this.createProjectButtonCreateProject.Text = "Save changes";
            this.createProjectButtonCreateProject.TextColor = System.Drawing.Color.White;
            this.createProjectButtonCreateProject.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.createProjectButtonCreateProject.Click += new System.EventHandler(this.createProjectButtonCreateProject_Click);
            // 
            // createProjectSpacer2
            // 
            this.createProjectSpacer2.AutoScroll = true;
            this.createProjectSpacer2.Location = new System.Drawing.Point(365, 0);
            this.createProjectSpacer2.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectSpacer2.MaximumSize = new System.Drawing.Size(20, 189);
            this.createProjectSpacer2.Name = "createProjectSpacer2";
            this.createProjectSpacer2.Size = new System.Drawing.Size(20, 189);
            this.createProjectSpacer2.TabIndex = 100;
            // 
            // createProjectControlBoxRight
            // 
            this.createProjectControlBoxRight.Controls.Add(this.createProjectTextExtraInfo);
            this.createProjectControlBoxRight.Controls.Add(this.editProjectDetailsInputExtraInfo);
            this.createProjectControlBoxRight.Controls.Add(this.createProjectSpacer3);
            this.createProjectControlBoxRight.Controls.Add(this.createProjectButtonCreateProject);
            this.createProjectControlBoxRight.Location = new System.Drawing.Point(385, 0);
            this.createProjectControlBoxRight.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectControlBoxRight.MaximumSize = new System.Drawing.Size(345, 190);
            this.createProjectControlBoxRight.Name = "createProjectControlBoxRight";
            this.createProjectControlBoxRight.Size = new System.Drawing.Size(345, 190);
            this.createProjectControlBoxRight.TabIndex = 100;
            // 
            // get_Newest_Added_ProjectTableAdapter
            // 
            this.get_Newest_Added_ProjectTableAdapter.ClearBeforeFill = true;
            // 
            // editProjectDetailsInputOrderNumber
            // 
            this.editProjectDetailsInputOrderNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editProjectDetailsInputOrderNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.editProjectDetailsInputOrderNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.editProjectDetailsInputOrderNumber.BorderSize = 1;
            this.editProjectDetailsInputOrderNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editProjectDetailsInputOrderNumber.Location = new System.Drawing.Point(184, 0);
            this.editProjectDetailsInputOrderNumber.Margin = new System.Windows.Forms.Padding(0);
            this.editProjectDetailsInputOrderNumber.MaximumSize = new System.Drawing.Size(162, 28);
            this.editProjectDetailsInputOrderNumber.MaxLength = 8;
            this.editProjectDetailsInputOrderNumber.Name = "editProjectDetailsInputOrderNumber";
            this.editProjectDetailsInputOrderNumber.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.editProjectDetailsInputOrderNumber.Size = new System.Drawing.Size(161, 28);
            this.editProjectDetailsInputOrderNumber.TabIndex = 3;
            this.editProjectDetailsInputOrderNumber.Text = "";
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
            this.createProjectTextOrderNumber.TabIndex = 100;
            this.createProjectTextOrderNumber.Text = "Order number";
            this.createProjectTextOrderNumber.VerticalAlignment = System.Drawing.StringAlignment.Far;
            // 
            // editProjectDetailsInputMachineNumber
            // 
            this.editProjectDetailsInputMachineNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.editProjectDetailsInputMachineNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.editProjectDetailsInputMachineNumber.BorderSize = 1;
            this.editProjectDetailsInputMachineNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editProjectDetailsInputMachineNumber.Location = new System.Drawing.Point(0, 0);
            this.editProjectDetailsInputMachineNumber.Margin = new System.Windows.Forms.Padding(0);
            this.editProjectDetailsInputMachineNumber.MaximumSize = new System.Drawing.Size(162, 28);
            this.editProjectDetailsInputMachineNumber.MaxLength = 8;
            this.editProjectDetailsInputMachineNumber.Name = "editProjectDetailsInputMachineNumber";
            this.editProjectDetailsInputMachineNumber.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.editProjectDetailsInputMachineNumber.Size = new System.Drawing.Size(162, 28);
            this.editProjectDetailsInputMachineNumber.TabIndex = 2;
            this.editProjectDetailsInputMachineNumber.Text = "";
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
            this.createProjectTextCustomer.TabIndex = 100;
            this.createProjectTextCustomer.Text = "Customer";
            this.createProjectTextCustomer.VerticalAlignment = System.Drawing.StringAlignment.Far;
            // 
            // editProjectDetailsInputCustomer
            // 
            this.editProjectDetailsInputCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.editProjectDetailsInputCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.editProjectDetailsInputCustomer.BorderSize = 1;
            this.editProjectDetailsInputCustomer.Location = new System.Drawing.Point(0, 27);
            this.editProjectDetailsInputCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.editProjectDetailsInputCustomer.MaximumSize = new System.Drawing.Size(345, 28);
            this.editProjectDetailsInputCustomer.MaxLength = 64;
            this.editProjectDetailsInputCustomer.Name = "editProjectDetailsInputCustomer";
            this.editProjectDetailsInputCustomer.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.editProjectDetailsInputCustomer.Size = new System.Drawing.Size(345, 28);
            this.editProjectDetailsInputCustomer.TabIndex = 0;
            this.editProjectDetailsInputCustomer.Text = "";
            // 
            // createProjectSpacer4
            // 
            this.createProjectSpacer4.Location = new System.Drawing.Point(0, 55);
            this.createProjectSpacer4.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectSpacer4.MaximumSize = new System.Drawing.Size(344, 3);
            this.createProjectSpacer4.Name = "createProjectSpacer4";
            this.createProjectSpacer4.Size = new System.Drawing.Size(344, 3);
            this.createProjectSpacer4.TabIndex = 100;
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
            this.createProjectTextMachineType.TabIndex = 100;
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
            this.createProjectSpacer5.TabIndex = 100;
            // 
            // editProjectDetailsInputMachineType
            // 
            this.editProjectDetailsInputMachineType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.editProjectDetailsInputMachineType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.editProjectDetailsInputMachineType.BorderSize = 1;
            this.editProjectDetailsInputMachineType.Location = new System.Drawing.Point(0, 88);
            this.editProjectDetailsInputMachineType.Margin = new System.Windows.Forms.Padding(0);
            this.editProjectDetailsInputMachineType.MaximumSize = new System.Drawing.Size(345, 28);
            this.editProjectDetailsInputMachineType.MaxLength = 32;
            this.editProjectDetailsInputMachineType.Name = "editProjectDetailsInputMachineType";
            this.editProjectDetailsInputMachineType.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.editProjectDetailsInputMachineType.Size = new System.Drawing.Size(345, 28);
            this.editProjectDetailsInputMachineType.TabIndex = 1;
            this.editProjectDetailsInputMachineType.Text = "";
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
            this.createProjectTextMachineNumber.TabIndex = 100;
            this.createProjectTextMachineNumber.Text = "Machine number";
            this.createProjectTextMachineNumber.VerticalAlignment = System.Drawing.StringAlignment.Far;
            // 
            // createProjectSpacer1
            // 
            this.createProjectSpacer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.createProjectSpacer1.Location = new System.Drawing.Point(0, 0);
            this.createProjectSpacer1.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectSpacer1.MaximumSize = new System.Drawing.Size(20, 189);
            this.createProjectSpacer1.Name = "createProjectSpacer1";
            this.createProjectSpacer1.Size = new System.Drawing.Size(20, 189);
            this.createProjectSpacer1.TabIndex = 100;
            // 
            // createProjectControlBoxLeft
            // 
            this.createProjectControlBoxLeft.Controls.Add(this.createProjectTextCustomer);
            this.createProjectControlBoxLeft.Controls.Add(this.editProjectDetailsInputCustomer);
            this.createProjectControlBoxLeft.Controls.Add(this.createProjectSpacer4);
            this.createProjectControlBoxLeft.Controls.Add(this.createProjectTextMachineType);
            this.createProjectControlBoxLeft.Controls.Add(this.createProjectSpacer5);
            this.createProjectControlBoxLeft.Controls.Add(this.editProjectDetailsInputMachineType);
            this.createProjectControlBoxLeft.Controls.Add(this.createProjectTextMachineNumber);
            this.createProjectControlBoxLeft.Controls.Add(this.createProjectTextOrderNumber);
            this.createProjectControlBoxLeft.Controls.Add(this.panel1);
            this.createProjectControlBoxLeft.Location = new System.Drawing.Point(20, 0);
            this.createProjectControlBoxLeft.Margin = new System.Windows.Forms.Padding(0);
            this.createProjectControlBoxLeft.MaximumSize = new System.Drawing.Size(345, 190);
            this.createProjectControlBoxLeft.Name = "createProjectControlBoxLeft";
            this.createProjectControlBoxLeft.Size = new System.Drawing.Size(345, 190);
            this.createProjectControlBoxLeft.TabIndex = 100;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editProjectDetailsInputOrderNumber);
            this.panel1.Controls.Add(this.editProjectDetailsInputMachineNumber);
            this.panel1.Location = new System.Drawing.Point(0, 143);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(345, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 28);
            this.panel1.TabIndex = 100;
            // 
            // createProjectContentBox
            // 
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
            this.createProjectContentBox.TabIndex = 101;
            // 
            // tbl_Risk_AnalysisBindingSource
            // 
            this.tbl_Risk_AnalysisBindingSource.DataMember = "Tbl_Risk_Analysis";
            this.tbl_Risk_AnalysisBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // tbl_Risk_AnalysisTableAdapter
            // 
            this.tbl_Risk_AnalysisTableAdapter.ClearBeforeFill = true;
            // 
            // ARA_EditProjectDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 190);
            this.Controls.Add(this.createProjectContentBox);
            this.Font = new System.Drawing.Font("Gotham Light", 15F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(750, 190);
            this.Name = "ARA_EditProjectDetails";
            this.Text = "ARA_EditProjectDetails";
            this.Load += new System.EventHandler(this.ARA_EditProjectDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.get_Newest_Added_ProjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            this.createProjectControlBoxRight.ResumeLayout(false);
            this.createProjectControlBoxLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.createProjectContentBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Risk_AnalysisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource get_Newest_Added_ProjectBindingSource;
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private LG_Analysis_DatabaseDataSetTableAdapters.QueriesTableAdapter createProjectDatabaseAdapter;
        private Controls.ARA_Text createProjectTextExtraInfo;
        private Controls.ARA_TextBox editProjectDetailsInputExtraInfo;
        private System.Windows.Forms.FlowLayoutPanel createProjectSpacer3;
        private Controls.ARA_Button createProjectButtonCreateProject;
        private System.Windows.Forms.Panel createProjectSpacer2;
        private System.Windows.Forms.FlowLayoutPanel createProjectControlBoxRight;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_Newest_Added_ProjectTableAdapter get_Newest_Added_ProjectTableAdapter;
        private Controls.ARA_TextBox editProjectDetailsInputOrderNumber;
        private Controls.ARA_Text createProjectTextOrderNumber;
        private Controls.ARA_TextBox editProjectDetailsInputMachineNumber;
        private Controls.ARA_Text createProjectTextCustomer;
        private Controls.ARA_TextBox editProjectDetailsInputCustomer;
        private System.Windows.Forms.Panel createProjectSpacer4;
        private Controls.ARA_Text createProjectTextMachineType;
        private System.Windows.Forms.Panel createProjectSpacer5;
        private Controls.ARA_TextBox editProjectDetailsInputMachineType;
        private Controls.ARA_Text createProjectTextMachineNumber;
        private System.Windows.Forms.Panel createProjectSpacer1;
        private System.Windows.Forms.FlowLayoutPanel createProjectControlBoxLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel createProjectContentBox;
        private System.Windows.Forms.BindingSource tbl_Risk_AnalysisBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_AnalysisTableAdapter tbl_Risk_AnalysisTableAdapter;
        private LG_Analysis_DatabaseDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}