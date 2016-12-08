namespace Applicatie_Risicoanalyse.Forms
{
    partial class ARA_RecentProjects
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Revision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recentProjectsDataGrid = new System.Windows.Forms.DataGridView();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getRecentRiskProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.getProjectsWithRevisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_Projects_With_RevisionTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_Projects_With_RevisionTableAdapter();
            this.search_ProjectsTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Search_ProjectsTableAdapter();
            this.search_ProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Risk_AnalysisTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_AnalysisTableAdapter();
            this.tblRiskAnalysisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.get_Recent_Risk_ProjectsTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_Recent_Risk_ProjectsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.recentProjectsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getRecentRiskProjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProjectsWithRevisionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_ProjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRiskAnalysisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Revision
            // 
            this.Revision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Revision.DataPropertyName = "Revision";
            this.Revision.HeaderText = "Revision";
            this.Revision.Name = "Revision";
            this.Revision.ReadOnly = true;
            this.Revision.Width = 118;
            // 
            // StateName
            // 
            this.StateName.DataPropertyName = "StateName";
            this.StateName.HeaderText = "StateName";
            this.StateName.Name = "StateName";
            this.StateName.ReadOnly = true;
            this.StateName.Visible = false;
            // 
            // ProjectID
            // 
            this.ProjectID.DataPropertyName = "ProjectID";
            this.ProjectID.HeaderText = "ProjectID";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.ReadOnly = true;
            this.ProjectID.Visible = false;
            // 
            // DateCreated
            // 
            this.DateCreated.DataPropertyName = "DateCreated";
            this.DateCreated.HeaderText = "DateCreated";
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.ReadOnly = true;
            this.DateCreated.Visible = false;
            // 
            // recentProjectsDataGrid
            // 
            this.recentProjectsDataGrid.AllowUserToAddRows = false;
            this.recentProjectsDataGrid.AllowUserToDeleteRows = false;
            this.recentProjectsDataGrid.AllowUserToResizeColumns = false;
            this.recentProjectsDataGrid.AllowUserToResizeRows = false;
            this.recentProjectsDataGrid.AutoGenerateColumns = false;
            this.recentProjectsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recentProjectsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.recentProjectsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.recentProjectsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recentProjectsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerDataGridViewTextBoxColumn,
            this.DateCreated,
            this.ProjectID,
            this.machineTypeDataGridViewTextBoxColumn,
            this.StateName,
            this.machineNumberDataGridViewTextBoxColumn,
            this.orderNumberDataGridViewTextBoxColumn,
            this.Revision});
            this.recentProjectsDataGrid.DataSource = this.getRecentRiskProjectsBindingSource;
            this.recentProjectsDataGrid.GridColor = System.Drawing.Color.Silver;
            this.recentProjectsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.recentProjectsDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.recentProjectsDataGrid.MultiSelect = false;
            this.recentProjectsDataGrid.Name = "recentProjectsDataGrid";
            this.recentProjectsDataGrid.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gotham Light", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recentProjectsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.recentProjectsDataGrid.RowHeadersVisible = false;
            this.recentProjectsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.recentProjectsDataGrid.RowTemplate.ReadOnly = true;
            this.recentProjectsDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.recentProjectsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recentProjectsDataGrid.ShowCellErrors = false;
            this.recentProjectsDataGrid.ShowRowErrors = false;
            this.recentProjectsDataGrid.Size = new System.Drawing.Size(730, 256);
            this.recentProjectsDataGrid.TabIndex = 6;
            this.recentProjectsDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.recentProjectsDataGrid_CellMouseDoubleClick);
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // machineTypeDataGridViewTextBoxColumn
            // 
            this.machineTypeDataGridViewTextBoxColumn.DataPropertyName = "MachineType";
            this.machineTypeDataGridViewTextBoxColumn.HeaderText = "MachineType";
            this.machineTypeDataGridViewTextBoxColumn.Name = "machineTypeDataGridViewTextBoxColumn";
            this.machineTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // machineNumberDataGridViewTextBoxColumn
            // 
            this.machineNumberDataGridViewTextBoxColumn.DataPropertyName = "MachineNumber";
            this.machineNumberDataGridViewTextBoxColumn.HeaderText = "MachineNumber";
            this.machineNumberDataGridViewTextBoxColumn.Name = "machineNumberDataGridViewTextBoxColumn";
            this.machineNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getRecentRiskProjectsBindingSource
            // 
            this.getRecentRiskProjectsBindingSource.DataMember = "Get_Recent_Risk_Projects";
            this.getRecentRiskProjectsBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // lG_Analysis_DatabaseDataSet
            // 
            this.lG_Analysis_DatabaseDataSet.DataSetName = "LG_Analysis_DatabaseDataSet";
            this.lG_Analysis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getProjectsWithRevisionBindingSource
            // 
            this.getProjectsWithRevisionBindingSource.DataMember = "Get_Projects_With_Revision";
            this.getProjectsWithRevisionBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_Projects_With_RevisionTableAdapter
            // 
            this.get_Projects_With_RevisionTableAdapter.ClearBeforeFill = true;
            // 
            // search_ProjectsTableAdapter
            // 
            this.search_ProjectsTableAdapter.ClearBeforeFill = true;
            // 
            // search_ProjectsBindingSource
            // 
            this.search_ProjectsBindingSource.DataMember = "Search_Projects";
            this.search_ProjectsBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // tbl_Risk_AnalysisTableAdapter
            // 
            this.tbl_Risk_AnalysisTableAdapter.ClearBeforeFill = true;
            // 
            // tblRiskAnalysisBindingSource
            // 
            this.tblRiskAnalysisBindingSource.DataMember = "Tbl_Risk_Analysis";
            this.tblRiskAnalysisBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
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
            this.tableAdapterManager.Tbl_Risk_AnalysisTableAdapter = this.tbl_Risk_AnalysisTableAdapter;
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
            // get_Recent_Risk_ProjectsTableAdapter
            // 
            this.get_Recent_Risk_ProjectsTableAdapter.ClearBeforeFill = true;
            // 
            // ARA_RecentProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 260);
            this.Controls.Add(this.recentProjectsDataGrid);
            this.Font = new System.Drawing.Font("Gotham Light", 15F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(750, 260);
            this.Name = "ARA_RecentProjects";
            this.Text = "ARA_RecentProjects";
            this.Load += new System.EventHandler(this.ARA_RecentProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recentProjectsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getRecentRiskProjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProjectsWithRevisionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_ProjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRiskAnalysisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LG_Analysis_DatabaseDataSetTableAdapters.Get_Projects_With_RevisionTableAdapter get_Projects_With_RevisionTableAdapter;
        private LG_Analysis_DatabaseDataSetTableAdapters.Search_ProjectsTableAdapter search_ProjectsTableAdapter;
        private System.Windows.Forms.BindingSource search_ProjectsBindingSource;
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_AnalysisTableAdapter tbl_Risk_AnalysisTableAdapter;
        private System.Windows.Forms.BindingSource tblRiskAnalysisBindingSource;
        private System.Windows.Forms.BindingSource getProjectsWithRevisionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Revision;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView recentProjectsDataGrid;
        private System.Windows.Forms.BindingSource getRecentRiskProjectsBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_Recent_Risk_ProjectsTableAdapter get_Recent_Risk_ProjectsTableAdapter;
    }
}