namespace Applicatie_Risicoanalyse.Forms
{
    partial class ARA_AddRisksToProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ARA_AddRisksToProject));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addRiskToProjectSearchTextBox = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            this.addRiskToProjectPanelContent = new System.Windows.Forms.FlowLayoutPanel();
            this.addRiskToProjectSearchDataGrid = new System.Windows.Forms.DataGridView();
            this.riskIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HazardSituation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inProjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchRisksInProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.fKComponentTypeComponentGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Component_GroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_Risks_In_Project_TypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Component_GroupTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Component_GroupTableAdapter();
            this.tableAdapterManager = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.tbl_Component_TypeTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Component_TypeTableAdapter();
            this.tbl_Component_TypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.queriesTableAdapter1 = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.QueriesTableAdapter();
            this.get_Risks_In_Project_GroupTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_Risks_In_Project_GroupTableAdapter();
            this.get_Risks_In_Project_TypeTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_Risks_In_Project_TypeTableAdapter();
            this.get_Risks_In_ProjectGroupTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_Risks_In_ProjectGroupTypeTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_Risks_In_ProjectGroupTypeTableAdapter();
            this.is_Risk_In_ProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.is_Risk_In_ProjectTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Is_Risk_In_ProjectTableAdapter();
            this.search_Risks_In_ProjectTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Search_Risks_In_ProjectTableAdapter();
            this.get_TypeNames_In_GroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_TypeNames_In_GroupTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_TypeNames_In_GroupTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            this.addRiskToProjectPanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addRiskToProjectSearchDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchRisksInProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKComponentTypeComponentGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Component_GroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Risks_In_Project_TypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Component_TypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Risks_In_ProjectGroupTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.is_Risk_In_ProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_TypeNames_In_GroupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.addRiskToProjectSearchTextBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(750, 38);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // addRiskToProjectSearchTextBox
            // 
            this.addRiskToProjectSearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.addRiskToProjectSearchTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.addRiskToProjectSearchTextBox.BorderSize = 1;
            this.addRiskToProjectSearchTextBox.Location = new System.Drawing.Point(3, 3);
            this.addRiskToProjectSearchTextBox.Name = "addRiskToProjectSearchTextBox";
            this.addRiskToProjectSearchTextBox.Size = new System.Drawing.Size(743, 31);
            this.addRiskToProjectSearchTextBox.TabIndex = 0;
            this.addRiskToProjectSearchTextBox.Text = "";
            this.addRiskToProjectSearchTextBox.TextChanged += new System.EventHandler(this.onSearchBarTextChanged);
            // 
            // addRiskToProjectPanelContent
            // 
            this.addRiskToProjectPanelContent.AutoScroll = true;
            this.addRiskToProjectPanelContent.BackColor = System.Drawing.Color.DimGray;
            this.addRiskToProjectPanelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addRiskToProjectPanelContent.Controls.Add(this.addRiskToProjectSearchDataGrid);
            this.addRiskToProjectPanelContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.addRiskToProjectPanelContent.Location = new System.Drawing.Point(0, 38);
            this.addRiskToProjectPanelContent.Margin = new System.Windows.Forms.Padding(0);
            this.addRiskToProjectPanelContent.MaximumSize = new System.Drawing.Size(750, 301);
            this.addRiskToProjectPanelContent.Name = "addRiskToProjectPanelContent";
            this.addRiskToProjectPanelContent.Size = new System.Drawing.Size(750, 301);
            this.addRiskToProjectPanelContent.TabIndex = 1;
            // 
            // addRiskToProjectSearchDataGrid
            // 
            this.addRiskToProjectSearchDataGrid.AllowUserToAddRows = false;
            this.addRiskToProjectSearchDataGrid.AllowUserToDeleteRows = false;
            this.addRiskToProjectSearchDataGrid.AllowUserToResizeColumns = false;
            this.addRiskToProjectSearchDataGrid.AllowUserToResizeRows = false;
            this.addRiskToProjectSearchDataGrid.AutoGenerateColumns = false;
            this.addRiskToProjectSearchDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addRiskToProjectSearchDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.addRiskToProjectSearchDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.addRiskToProjectSearchDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addRiskToProjectSearchDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.riskIDDataGridViewTextBoxColumn,
            this.HazardSituation,
            this.GroupName,
            this.typeNameDataGridViewTextBoxColumn,
            this.inProjectDataGridViewTextBoxColumn});
            this.addRiskToProjectSearchDataGrid.DataSource = this.searchRisksInProjectBindingSource;
            this.addRiskToProjectSearchDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.addRiskToProjectSearchDataGrid.GridColor = System.Drawing.Color.Silver;
            this.addRiskToProjectSearchDataGrid.Location = new System.Drawing.Point(0, 0);
            this.addRiskToProjectSearchDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.addRiskToProjectSearchDataGrid.Name = "addRiskToProjectSearchDataGrid";
            this.addRiskToProjectSearchDataGrid.ReadOnly = true;
            this.addRiskToProjectSearchDataGrid.RowHeadersVisible = false;
            this.addRiskToProjectSearchDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.addRiskToProjectSearchDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.addRiskToProjectSearchDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addRiskToProjectSearchDataGrid.Size = new System.Drawing.Size(734, 186);
            this.addRiskToProjectSearchDataGrid.TabIndex = 0;
            this.addRiskToProjectSearchDataGrid.Visible = false;
            this.addRiskToProjectSearchDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.onDataGridRowDoubleClick);
            this.addRiskToProjectSearchDataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.onDataGridRowAdded);
            this.addRiskToProjectSearchDataGrid.SelectionChanged += new System.EventHandler(this.onDataGridSelectionChanged);
            // 
            // riskIDDataGridViewTextBoxColumn
            // 
            this.riskIDDataGridViewTextBoxColumn.DataPropertyName = "RiskID";
            this.riskIDDataGridViewTextBoxColumn.FillWeight = 10F;
            this.riskIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.riskIDDataGridViewTextBoxColumn.Name = "riskIDDataGridViewTextBoxColumn";
            this.riskIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.riskIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // HazardSituation
            // 
            this.HazardSituation.DataPropertyName = "HazardSituation";
            this.HazardSituation.FillWeight = 60F;
            this.HazardSituation.HeaderText = "Brief event description";
            this.HazardSituation.Name = "HazardSituation";
            this.HazardSituation.ReadOnly = true;
            // 
            // GroupName
            // 
            this.GroupName.DataPropertyName = "GroupName";
            this.GroupName.FillWeight = 20F;
            this.GroupName.HeaderText = "GroupName";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.FillWeight = 20F;
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            this.typeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // inProjectDataGridViewTextBoxColumn
            // 
            this.inProjectDataGridViewTextBoxColumn.DataPropertyName = "InProject";
            this.inProjectDataGridViewTextBoxColumn.HeaderText = "InProject";
            this.inProjectDataGridViewTextBoxColumn.Name = "inProjectDataGridViewTextBoxColumn";
            this.inProjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.inProjectDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.inProjectDataGridViewTextBoxColumn.Visible = false;
            // 
            // searchRisksInProjectBindingSource
            // 
            this.searchRisksInProjectBindingSource.DataMember = "Search_Risks_In_Project";
            this.searchRisksInProjectBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // lG_Analysis_DatabaseDataSet
            // 
            this.lG_Analysis_DatabaseDataSet.DataSetName = "LG_Analysis_DatabaseDataSet";
            this.lG_Analysis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fKComponentTypeComponentGroupBindingSource
            // 
            this.fKComponentTypeComponentGroupBindingSource.DataMember = "FK_ComponentType_ComponentGroup";
            this.fKComponentTypeComponentGroupBindingSource.DataSource = this.tbl_Component_GroupBindingSource;
            // 
            // tbl_Component_GroupBindingSource
            // 
            this.tbl_Component_GroupBindingSource.DataMember = "Tbl_Component_Group";
            this.tbl_Component_GroupBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_Risks_In_Project_TypeBindingSource
            // 
            this.get_Risks_In_Project_TypeBindingSource.DataMember = "Get_Risks_In_Project_Type";
            this.get_Risks_In_Project_TypeBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // tbl_Component_GroupTableAdapter
            // 
            this.tbl_Component_GroupTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tbl_BLOB_StorageTableAdapter = null;
            this.tableAdapterManager.Tbl_Component_GroupTableAdapter = this.tbl_Component_GroupTableAdapter;
            this.tableAdapterManager.Tbl_Component_TypeTableAdapter = this.tbl_Component_TypeTableAdapter;
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
            // tbl_Component_TypeTableAdapter
            // 
            this.tbl_Component_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Component_TypeBindingSource
            // 
            this.tbl_Component_TypeBindingSource.DataMember = "Tbl_Component_Type";
            this.tbl_Component_TypeBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_Risks_In_Project_GroupTableAdapter
            // 
            this.get_Risks_In_Project_GroupTableAdapter.ClearBeforeFill = true;
            // 
            // get_Risks_In_Project_TypeTableAdapter
            // 
            this.get_Risks_In_Project_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // get_Risks_In_ProjectGroupTypeBindingSource
            // 
            this.get_Risks_In_ProjectGroupTypeBindingSource.DataMember = "Get_Risks_In_ProjectGroupType";
            this.get_Risks_In_ProjectGroupTypeBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_Risks_In_ProjectGroupTypeTableAdapter
            // 
            this.get_Risks_In_ProjectGroupTypeTableAdapter.ClearBeforeFill = true;
            // 
            // is_Risk_In_ProjectBindingSource
            // 
            this.is_Risk_In_ProjectBindingSource.DataMember = "Is_Risk_In_Project";
            this.is_Risk_In_ProjectBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // is_Risk_In_ProjectTableAdapter
            // 
            this.is_Risk_In_ProjectTableAdapter.ClearBeforeFill = true;
            // 
            // search_Risks_In_ProjectTableAdapter
            // 
            this.search_Risks_In_ProjectTableAdapter.ClearBeforeFill = true;
            // 
            // get_TypeNames_In_GroupBindingSource
            // 
            this.get_TypeNames_In_GroupBindingSource.DataMember = "Get_TypeNames_In_Group";
            this.get_TypeNames_In_GroupBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_TypeNames_In_GroupTableAdapter
            // 
            this.get_TypeNames_In_GroupTableAdapter.ClearBeforeFill = true;
            // 
            // ARA_AddRisksToProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 340);
            this.Controls.Add(this.addRiskToProjectPanelContent);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(750, 340);
            this.Name = "ARA_AddRisksToProject";
            this.Text = "ARA_RiskProjectOverview";
            this.Load += new System.EventHandler(this.ARA_AddRisksToProject_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.addRiskToProjectPanelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addRiskToProjectSearchDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchRisksInProjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKComponentTypeComponentGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Component_GroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Risks_In_Project_TypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Component_TypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Risks_In_ProjectGroupTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.is_Risk_In_ProjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_TypeNames_In_GroupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controls.ARA_TextBox addRiskToProjectSearchTextBox;
        private System.Windows.Forms.FlowLayoutPanel addRiskToProjectPanelContent;
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private System.Windows.Forms.BindingSource tbl_Component_GroupBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Component_GroupTableAdapter tbl_Component_GroupTableAdapter;
        private LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Component_TypeTableAdapter tbl_Component_TypeTableAdapter;
        private System.Windows.Forms.BindingSource tbl_Component_TypeBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_Risks_In_Project_GroupTableAdapter get_Risks_In_Project_GroupTableAdapter;
        private System.Windows.Forms.BindingSource get_Risks_In_Project_TypeBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_Risks_In_Project_TypeTableAdapter get_Risks_In_Project_TypeTableAdapter;
        private System.Windows.Forms.BindingSource get_Risks_In_ProjectGroupTypeBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_Risks_In_ProjectGroupTypeTableAdapter get_Risks_In_ProjectGroupTypeTableAdapter;
        private System.Windows.Forms.BindingSource is_Risk_In_ProjectBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Is_Risk_In_ProjectTableAdapter is_Risk_In_ProjectTableAdapter;
        private System.Windows.Forms.DataGridView addRiskToProjectSearchDataGrid;
        private System.Windows.Forms.BindingSource fKComponentTypeComponentGroupBindingSource;
        private System.Windows.Forms.BindingSource searchRisksInProjectBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Search_Risks_In_ProjectTableAdapter search_Risks_In_ProjectTableAdapter;
        private System.Windows.Forms.BindingSource get_TypeNames_In_GroupBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_TypeNames_In_GroupTableAdapter get_TypeNames_In_GroupTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn riskIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HazardSituation;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inProjectDataGridViewTextBoxColumn;
    }
}