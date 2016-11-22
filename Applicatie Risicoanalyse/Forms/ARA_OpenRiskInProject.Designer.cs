namespace Applicatie_Risicoanalyse.Forms
{
    partial class ARA_OpenRiskInProject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OpenRiskInProjectDataGrid = new System.Windows.Forms.DataGridView();
            this.arA_TextBox1 = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            this.searchProjectRisksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.tableAdapterManager = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.get_RiskDataID_From_Risks_In_ProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.search_ProjectRisksTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Search_ProjectRisksTableAdapter();
            this.get_RiskDataID_From_Risks_In_ProjectTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskDataID_From_Risks_In_ProjectTableAdapter();
            this.riskIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HazardSituation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultRiskDataID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectRiskDataID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewedByUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OpenRiskInProjectDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProjectRisksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskDataID_From_Risks_In_ProjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenRiskInProjectDataGrid
            // 
            this.OpenRiskInProjectDataGrid.AllowUserToAddRows = false;
            this.OpenRiskInProjectDataGrid.AllowUserToDeleteRows = false;
            this.OpenRiskInProjectDataGrid.AllowUserToResizeColumns = false;
            this.OpenRiskInProjectDataGrid.AllowUserToResizeRows = false;
            this.OpenRiskInProjectDataGrid.AutoGenerateColumns = false;
            this.OpenRiskInProjectDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OpenRiskInProjectDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.OpenRiskInProjectDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.OpenRiskInProjectDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OpenRiskInProjectDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.riskIDDataGridViewTextBoxColumn,
            this.HazardSituation,
            this.GroupName,
            this.typeNameDataGridViewTextBoxColumn,
            this.DefaultRiskDataID,
            this.ProjectRiskDataID,
            this.VersionID,
            this.ReviewedByUser});
            this.OpenRiskInProjectDataGrid.DataSource = this.searchProjectRisksBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OpenRiskInProjectDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.OpenRiskInProjectDataGrid.GridColor = System.Drawing.Color.Silver;
            this.OpenRiskInProjectDataGrid.Location = new System.Drawing.Point(0, 32);
            this.OpenRiskInProjectDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.OpenRiskInProjectDataGrid.Name = "OpenRiskInProjectDataGrid";
            this.OpenRiskInProjectDataGrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OpenRiskInProjectDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OpenRiskInProjectDataGrid.RowHeadersVisible = false;
            this.OpenRiskInProjectDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.OpenRiskInProjectDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OpenRiskInProjectDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OpenRiskInProjectDataGrid.Size = new System.Drawing.Size(750, 309);
            this.OpenRiskInProjectDataGrid.TabIndex = 2;
            this.OpenRiskInProjectDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OpenRiskInProjectDataGrid_CellMouseDoubleClick);
            this.OpenRiskInProjectDataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.onDataGridRowAdded);
            this.OpenRiskInProjectDataGrid.SelectionChanged += new System.EventHandler(this.OpenRiskInProjectDataGrid_SelectionChanged);
            this.OpenRiskInProjectDataGrid.VisibleChanged += new System.EventHandler(this.OpenRiskInProjectDataGrid_VisabilityChanged);
            // 
            // arA_TextBox1
            // 
            this.arA_TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.arA_TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.arA_TextBox1.BorderSize = 1;
            this.arA_TextBox1.Location = new System.Drawing.Point(0, 0);
            this.arA_TextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_TextBox1.Name = "arA_TextBox1";
            this.arA_TextBox1.Size = new System.Drawing.Size(750, 32);
            this.arA_TextBox1.TabIndex = 1;
            this.arA_TextBox1.Text = "";
            this.arA_TextBox1.TextChanged += new System.EventHandler(this.arA_TextBox1_TextChanged);
            // 
            // searchProjectRisksBindingSource
            // 
            this.searchProjectRisksBindingSource.DataMember = "Search_ProjectRisks";
            this.searchProjectRisksBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // lG_Analysis_DatabaseDataSet
            // 
            this.lG_Analysis_DatabaseDataSet.DataSetName = "LG_Analysis_DatabaseDataSet";
            this.lG_Analysis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // get_RiskDataID_From_Risks_In_ProjectBindingSource
            // 
            this.get_RiskDataID_From_Risks_In_ProjectBindingSource.DataMember = "Get_RiskDataID_From_Risks_In_Project";
            this.get_RiskDataID_From_Risks_In_ProjectBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // search_ProjectRisksTableAdapter
            // 
            this.search_ProjectRisksTableAdapter.ClearBeforeFill = true;
            // 
            // get_RiskDataID_From_Risks_In_ProjectTableAdapter
            // 
            this.get_RiskDataID_From_Risks_In_ProjectTableAdapter.ClearBeforeFill = true;
            // 
            // riskIDDataGridViewTextBoxColumn
            // 
            this.riskIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.riskIDDataGridViewTextBoxColumn.DataPropertyName = "RiskID";
            this.riskIDDataGridViewTextBoxColumn.FillWeight = 10F;
            this.riskIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.riskIDDataGridViewTextBoxColumn.Name = "riskIDDataGridViewTextBoxColumn";
            this.riskIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.riskIDDataGridViewTextBoxColumn.Width = 56;
            // 
            // HazardSituation
            // 
            this.HazardSituation.DataPropertyName = "HazardSituation";
            this.HazardSituation.FillWeight = 60F;
            this.HazardSituation.HeaderText = "Action description";
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
            // 
            // DefaultRiskDataID
            // 
            this.DefaultRiskDataID.DataPropertyName = "DefaultRiskDataID";
            this.DefaultRiskDataID.HeaderText = "DefaultRiskDataID";
            this.DefaultRiskDataID.Name = "DefaultRiskDataID";
            this.DefaultRiskDataID.ReadOnly = true;
            this.DefaultRiskDataID.Visible = false;
            // 
            // ProjectRiskDataID
            // 
            this.ProjectRiskDataID.DataPropertyName = "ProjectRiskDataID";
            this.ProjectRiskDataID.HeaderText = "ProjectRiskDataID";
            this.ProjectRiskDataID.Name = "ProjectRiskDataID";
            this.ProjectRiskDataID.ReadOnly = true;
            this.ProjectRiskDataID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProjectRiskDataID.Visible = false;
            // 
            // VersionID
            // 
            this.VersionID.DataPropertyName = "VersionID";
            this.VersionID.HeaderText = "VersionID";
            this.VersionID.Name = "VersionID";
            this.VersionID.ReadOnly = true;
            this.VersionID.Visible = false;
            // 
            // ReviewedByUser
            // 
            this.ReviewedByUser.DataPropertyName = "ReviewedByUser";
            this.ReviewedByUser.HeaderText = "ReviewedByUser";
            this.ReviewedByUser.Name = "ReviewedByUser";
            this.ReviewedByUser.ReadOnly = true;
            this.ReviewedByUser.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ReviewedByUser.Visible = false;
            // 
            // ARA_OpenRiskInProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 350);
            this.Controls.Add(this.OpenRiskInProjectDataGrid);
            this.Controls.Add(this.arA_TextBox1);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(750, 350);
            this.Name = "ARA_OpenRiskInProject";
            this.Text = "ARA_OpenRiskInProject";
            ((System.ComponentModel.ISupportInitialize)(this.OpenRiskInProjectDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProjectRisksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskDataID_From_Risks_In_ProjectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.ARA_TextBox arA_TextBox1;
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private System.Windows.Forms.BindingSource searchProjectRisksBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Search_ProjectRisksTableAdapter search_ProjectRisksTableAdapter;
        private System.Windows.Forms.BindingSource get_RiskDataID_From_Risks_In_ProjectBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskDataID_From_Risks_In_ProjectTableAdapter get_RiskDataID_From_Risks_In_ProjectTableAdapter;
        private LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView OpenRiskInProjectDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn riskIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HazardSituation;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultRiskDataID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectRiskDataID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewedByUser;
    }
}