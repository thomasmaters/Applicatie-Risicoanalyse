using Applicatie_Risicoanalyse.Globals;

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
            this.openRiskInProjectDataGrid = new System.Windows.Forms.DataGridView();
            this.RiskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HazardSituation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultRiskDataID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectRiskDataID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewedByUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchProjectRisksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.tableAdapterManager = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.get_RiskDataID_From_Risks_In_ProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.search_ProjectRisksTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Search_ProjectRisksTableAdapter();
            this.get_RiskDataID_From_Risks_In_ProjectTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskDataID_From_Risks_In_ProjectTableAdapter();
            this.tbl_Risk_AnalysisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Risk_AnalysisTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_AnalysisTableAdapter();
            this.is_Risk_OldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.is_Risk_OldTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Is_Risk_OldTableAdapter();
            this.arA_TextBox1 = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.openRiskInProjectDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProjectRisksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskDataID_From_Risks_In_ProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Risk_AnalysisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.is_Risk_OldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenRiskInProjectDataGrid
            // 
            this.openRiskInProjectDataGrid.AllowUserToAddRows = false;
            this.openRiskInProjectDataGrid.AllowUserToDeleteRows = false;
            this.openRiskInProjectDataGrid.AllowUserToResizeColumns = false;
            this.openRiskInProjectDataGrid.AllowUserToResizeRows = false;
            this.openRiskInProjectDataGrid.AutoGenerateColumns = false;
            this.openRiskInProjectDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.openRiskInProjectDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.openRiskInProjectDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.openRiskInProjectDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.openRiskInProjectDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RiskID,
            this.HazardSituation,
            this.GroupName,
            this.typeNameDataGridViewTextBoxColumn,
            this.DefaultRiskDataID,
            this.ProjectRiskDataID,
            this.VersionID,
            this.ReviewedByUser});
            this.openRiskInProjectDataGrid.DataSource = this.searchProjectRisksBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font(ARA_Globals.ARA_Font, 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.openRiskInProjectDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.openRiskInProjectDataGrid.GridColor = System.Drawing.Color.Silver;
            this.openRiskInProjectDataGrid.Location = new System.Drawing.Point(0, 32);
            this.openRiskInProjectDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.openRiskInProjectDataGrid.Name = "OpenRiskInProjectDataGrid";
            this.openRiskInProjectDataGrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font(ARA_Globals.ARA_Font, 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.openRiskInProjectDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.openRiskInProjectDataGrid.RowHeadersVisible = false;
            this.openRiskInProjectDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.openRiskInProjectDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.openRiskInProjectDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.openRiskInProjectDataGrid.Size = new System.Drawing.Size(732, 309);
            this.openRiskInProjectDataGrid.TabIndex = 2;
            this.openRiskInProjectDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OpenRiskInProjectDataGrid_CellMouseDoubleClick);
            this.openRiskInProjectDataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.onDataGridRowAdded);
            this.openRiskInProjectDataGrid.SelectionChanged += new System.EventHandler(this.OpenRiskInProjectDataGrid_SelectionChanged);
            this.openRiskInProjectDataGrid.Sorted += new System.EventHandler(this.OpenRiskInProjectDataGrid_Sorted);
            // 
            // RiskID
            // 
            this.RiskID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RiskID.DataPropertyName = "RiskID";
            this.RiskID.FillWeight = 10F;
            this.RiskID.HeaderText = "ID";
            this.RiskID.Name = "RiskID";
            this.RiskID.ReadOnly = true;
            this.RiskID.Width = 56;
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
            // tbl_Risk_AnalysisBindingSource
            // 
            this.tbl_Risk_AnalysisBindingSource.DataMember = "Tbl_Risk_Analysis";
            this.tbl_Risk_AnalysisBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // tbl_Risk_AnalysisTableAdapter
            // 
            this.tbl_Risk_AnalysisTableAdapter.ClearBeforeFill = true;
            // 
            // is_Risk_OldBindingSource
            // 
            this.is_Risk_OldBindingSource.DataMember = "Is_Risk_Old";
            this.is_Risk_OldBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // is_Risk_OldTableAdapter
            // 
            this.is_Risk_OldTableAdapter.ClearBeforeFill = true;
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
            // ARA_OpenRiskInProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(750, 350);
            this.Controls.Add(this.openRiskInProjectDataGrid);
            this.Controls.Add(this.arA_TextBox1);
            this.Font = new System.Drawing.Font(ARA_Globals.ARA_Font, 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(750, 350);
            this.Name = "ARA_OpenRiskInProject";
            this.Text = "ARA_OpenRiskInProject";
            ((System.ComponentModel.ISupportInitialize)(this.openRiskInProjectDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProjectRisksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskDataID_From_Risks_In_ProjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Risk_AnalysisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.is_Risk_OldBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView openRiskInProjectDataGrid;
        private System.Windows.Forms.BindingSource tbl_Risk_AnalysisBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_AnalysisTableAdapter tbl_Risk_AnalysisTableAdapter;
        private System.Windows.Forms.BindingSource is_Risk_OldBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Is_Risk_OldTableAdapter is_Risk_OldTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn RiskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HazardSituation;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultRiskDataID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectRiskDataID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewedByUser;
    }
}