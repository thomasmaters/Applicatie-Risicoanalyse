using Applicatie_Risicoanalyse.Globals;

namespace Applicatie_Risicoanalyse.Forms
{
    partial class ARA_CopyRisksToProject
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
            this.copyRisksComboBoxProjects = new System.Windows.Forms.ComboBox();
            this.tblRiskAnalysisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.getRisksWithRiskDataInProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_Risks_With_RiskData_In_ProjectTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_Risks_With_RiskData_In_ProjectTableAdapter();
            this.tbl_Risk_AnalysisTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_AnalysisTableAdapter();
            this.queriesTableAdapter1 = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.QueriesTableAdapter();
            this.projectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hazardSituationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copyRisksDataGrid = new System.Windows.Forms.DataGridView();
            this.projectIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riskIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hazardSituationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defaultRiskDataIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectRiskDataIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copyRisksButtonCopyRisks = new Applicatie_Risicoanalyse.Controls.ARA_Button();
            this.copyRisksTextSelectProject = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.is_Risk_OldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.is_Risk_OldTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Is_Risk_OldTableAdapter();
            this.tableAdapterManager = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.tblRiskAnalysisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getRisksWithRiskDataInProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyRisksDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.is_Risk_OldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // copyRisksComboBoxProjects
            // 
            this.copyRisksComboBoxProjects.DataSource = this.tblRiskAnalysisBindingSource;
            this.copyRisksComboBoxProjects.DisplayMember = "MachineNumber";
            this.copyRisksComboBoxProjects.FormattingEnabled = true;
            this.copyRisksComboBoxProjects.Location = new System.Drawing.Point(504, 2);
            this.copyRisksComboBoxProjects.Margin = new System.Windows.Forms.Padding(0);
            this.copyRisksComboBoxProjects.Name = "copyRisksComboBoxProjects";
            this.copyRisksComboBoxProjects.Size = new System.Drawing.Size(226, 32);
            this.copyRisksComboBoxProjects.TabIndex = 0;
            this.copyRisksComboBoxProjects.ValueMember = "ProjectID";
            this.copyRisksComboBoxProjects.SelectedIndexChanged += new System.EventHandler(this.copyRisksComboBoxProjects_SelectedIndexChanged);
            // 
            // tblRiskAnalysisBindingSource
            // 
            this.tblRiskAnalysisBindingSource.DataMember = "Tbl_Risk_Analysis";
            this.tblRiskAnalysisBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // lG_Analysis_DatabaseDataSet
            // 
            this.lG_Analysis_DatabaseDataSet.DataSetName = "LG_Analysis_DatabaseDataSet";
            this.lG_Analysis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getRisksWithRiskDataInProjectBindingSource
            // 
            this.getRisksWithRiskDataInProjectBindingSource.DataMember = "Get_Risks_With_RiskData_In_Project";
            this.getRisksWithRiskDataInProjectBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_Risks_With_RiskData_In_ProjectTableAdapter
            // 
            this.get_Risks_With_RiskData_In_ProjectTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Risk_AnalysisTableAdapter
            // 
            this.tbl_Risk_AnalysisTableAdapter.ClearBeforeFill = true;
            // 
            // projectIDDataGridViewTextBoxColumn
            // 
            this.projectIDDataGridViewTextBoxColumn.DataPropertyName = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn.HeaderText = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn.Name = "projectIDDataGridViewTextBoxColumn";
            this.projectIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // projectIDDataGridViewTextBoxColumn1
            // 
            this.projectIDDataGridViewTextBoxColumn1.DataPropertyName = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn1.HeaderText = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn1.Name = "projectIDDataGridViewTextBoxColumn1";
            this.projectIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // hazardSituationDataGridViewTextBoxColumn
            // 
            this.hazardSituationDataGridViewTextBoxColumn.DataPropertyName = "HazardSituation";
            this.hazardSituationDataGridViewTextBoxColumn.HeaderText = "HazardSituation";
            this.hazardSituationDataGridViewTextBoxColumn.Name = "hazardSituationDataGridViewTextBoxColumn";
            this.hazardSituationDataGridViewTextBoxColumn.Width = 378;
            // 
            // projectIDDataGridViewTextBoxColumn2
            // 
            this.projectIDDataGridViewTextBoxColumn2.DataPropertyName = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn2.HeaderText = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn2.Name = "projectIDDataGridViewTextBoxColumn2";
            this.projectIDDataGridViewTextBoxColumn2.Width = 90;
            // 
            // versionIDDataGridViewTextBoxColumn
            // 
            this.versionIDDataGridViewTextBoxColumn.DataPropertyName = "VersionID";
            this.versionIDDataGridViewTextBoxColumn.HeaderText = "VersionID";
            this.versionIDDataGridViewTextBoxColumn.Name = "versionIDDataGridViewTextBoxColumn";
            this.versionIDDataGridViewTextBoxColumn.Width = 89;
            // 
            // copyRisksDataGrid
            // 
            this.copyRisksDataGrid.AllowUserToAddRows = false;
            this.copyRisksDataGrid.AllowUserToDeleteRows = false;
            this.copyRisksDataGrid.AllowUserToResizeColumns = false;
            this.copyRisksDataGrid.AllowUserToResizeRows = false;
            this.copyRisksDataGrid.AutoGenerateColumns = false;
            this.copyRisksDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.copyRisksDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.copyRisksDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.copyRisksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.copyRisksDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectIDDataGridViewTextBoxColumn3,
            this.riskIDDataGridViewTextBoxColumn,
            this.hazardSituationDataGridViewTextBoxColumn1,
            this.versionIDDataGridViewTextBoxColumn1,
            this.typeNameDataGridViewTextBoxColumn,
            this.groupNameDataGridViewTextBoxColumn,
            this.defaultRiskDataIDDataGridViewTextBoxColumn,
            this.projectRiskDataIDDataGridViewTextBoxColumn});
            this.copyRisksDataGrid.DataSource = this.getRisksWithRiskDataInProjectBindingSource;
            this.copyRisksDataGrid.Location = new System.Drawing.Point(9, 34);
            this.copyRisksDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.copyRisksDataGrid.Name = "copyRisksDataGrid";
            this.copyRisksDataGrid.ReadOnly = true;
            this.copyRisksDataGrid.RowHeadersVisible = false;
            this.copyRisksDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.copyRisksDataGrid.ShowEditingIcon = false;
            this.copyRisksDataGrid.Size = new System.Drawing.Size(721, 195);
            this.copyRisksDataGrid.TabIndex = 4;
            this.copyRisksDataGrid.Sorted += new System.EventHandler(this.copyRisksDataGrid_Sorted);
            // 
            // projectIDDataGridViewTextBoxColumn3
            // 
            this.projectIDDataGridViewTextBoxColumn3.DataPropertyName = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn3.HeaderText = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn3.Name = "projectIDDataGridViewTextBoxColumn3";
            this.projectIDDataGridViewTextBoxColumn3.ReadOnly = true;
            this.projectIDDataGridViewTextBoxColumn3.Visible = false;
            // 
            // riskIDDataGridViewTextBoxColumn
            // 
            this.riskIDDataGridViewTextBoxColumn.DataPropertyName = "RiskID";
            this.riskIDDataGridViewTextBoxColumn.FillWeight = 30F;
            this.riskIDDataGridViewTextBoxColumn.HeaderText = "RiskID";
            this.riskIDDataGridViewTextBoxColumn.Name = "riskIDDataGridViewTextBoxColumn";
            this.riskIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hazardSituationDataGridViewTextBoxColumn1
            // 
            this.hazardSituationDataGridViewTextBoxColumn1.DataPropertyName = "HazardSituation";
            this.hazardSituationDataGridViewTextBoxColumn1.HeaderText = "HazardSituation";
            this.hazardSituationDataGridViewTextBoxColumn1.Name = "hazardSituationDataGridViewTextBoxColumn1";
            this.hazardSituationDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // versionIDDataGridViewTextBoxColumn1
            // 
            this.versionIDDataGridViewTextBoxColumn1.DataPropertyName = "VersionID";
            this.versionIDDataGridViewTextBoxColumn1.HeaderText = "VersionID";
            this.versionIDDataGridViewTextBoxColumn1.Name = "versionIDDataGridViewTextBoxColumn1";
            this.versionIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.versionIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.FillWeight = 30F;
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            this.typeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupNameDataGridViewTextBoxColumn
            // 
            this.groupNameDataGridViewTextBoxColumn.DataPropertyName = "GroupName";
            this.groupNameDataGridViewTextBoxColumn.FillWeight = 30F;
            this.groupNameDataGridViewTextBoxColumn.HeaderText = "GroupName";
            this.groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
            this.groupNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // defaultRiskDataIDDataGridViewTextBoxColumn
            // 
            this.defaultRiskDataIDDataGridViewTextBoxColumn.DataPropertyName = "DefaultRiskDataID";
            this.defaultRiskDataIDDataGridViewTextBoxColumn.HeaderText = "DefaultRiskDataID";
            this.defaultRiskDataIDDataGridViewTextBoxColumn.Name = "defaultRiskDataIDDataGridViewTextBoxColumn";
            this.defaultRiskDataIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.defaultRiskDataIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // projectRiskDataIDDataGridViewTextBoxColumn
            // 
            this.projectRiskDataIDDataGridViewTextBoxColumn.DataPropertyName = "ProjectRiskDataID";
            this.projectRiskDataIDDataGridViewTextBoxColumn.HeaderText = "ProjectRiskDataID";
            this.projectRiskDataIDDataGridViewTextBoxColumn.Name = "projectRiskDataIDDataGridViewTextBoxColumn";
            this.projectRiskDataIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectRiskDataIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // arA_Button1
            // 
            this.copyRisksButtonCopyRisks.BaseColor = ARA_Colors.ARA_Turkois;
            this.copyRisksButtonCopyRisks.CanButtonBeToggled = false;
            this.copyRisksButtonCopyRisks.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.copyRisksButtonCopyRisks.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.copyRisksButtonCopyRisks.Location = new System.Drawing.Point(9, 232);
            this.copyRisksButtonCopyRisks.Margin = new System.Windows.Forms.Padding(0);
            this.copyRisksButtonCopyRisks.Name = "arA_Button1";
            this.copyRisksButtonCopyRisks.Selected = false;
            this.copyRisksButtonCopyRisks.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.copyRisksButtonCopyRisks.SelectedTextColor = System.Drawing.Color.White;
            this.copyRisksButtonCopyRisks.Size = new System.Drawing.Size(721, 26);
            this.copyRisksButtonCopyRisks.TabIndex = 3;
            this.copyRisksButtonCopyRisks.Text = "Copy selected risks in current project";
            this.copyRisksButtonCopyRisks.TextColor = System.Drawing.Color.White;
            this.copyRisksButtonCopyRisks.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.copyRisksButtonCopyRisks.Click += new System.EventHandler(this.onCopyRisksButtonClicked);
            // 
            // arA_Text1
            // 
            this.copyRisksTextSelectProject.BackgroundColor = System.Drawing.Color.White;
            this.copyRisksTextSelectProject.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.copyRisksTextSelectProject.Location = new System.Drawing.Point(9, -1);
            this.copyRisksTextSelectProject.Margin = new System.Windows.Forms.Padding(0);
            this.copyRisksTextSelectProject.Name = "arA_Text1";
            this.copyRisksTextSelectProject.Size = new System.Drawing.Size(495, 32);
            this.copyRisksTextSelectProject.TabIndex = 2;
            this.copyRisksTextSelectProject.Text = "Select risk from project:";
            this.copyRisksTextSelectProject.VerticalAlignment = System.Drawing.StringAlignment.Center;
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
            // ARA_CopyRisksToProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 265);
            this.Controls.Add(this.copyRisksDataGrid);
            this.Controls.Add(this.copyRisksButtonCopyRisks);
            this.Controls.Add(this.copyRisksTextSelectProject);
            this.Controls.Add(this.copyRisksComboBoxProjects);
            this.Font = new System.Drawing.Font(ARA_Globals.ARA_Font, 15F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(750, 265);
            this.Name = "ARA_CopyRisksToProject";
            this.Text = "testForm";
            ((System.ComponentModel.ISupportInitialize)(this.tblRiskAnalysisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getRisksWithRiskDataInProjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyRisksDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.is_Risk_OldBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox copyRisksComboBoxProjects;
        private Controls.ARA_Text copyRisksTextSelectProject;
        private System.Windows.Forms.BindingSource getRisksWithRiskDataInProjectBindingSource;
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_Risks_With_RiskData_In_ProjectTableAdapter get_Risks_With_RiskData_In_ProjectTableAdapter;
        private System.Windows.Forms.BindingSource tblRiskAnalysisBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_AnalysisTableAdapter tbl_Risk_AnalysisTableAdapter;
        private Controls.ARA_Button copyRisksButtonCopyRisks;
        private LG_Analysis_DatabaseDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RiskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hazardSituationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView copyRisksDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn riskIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hazardSituationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defaultRiskDataIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectRiskDataIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource is_Risk_OldBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Is_Risk_OldTableAdapter is_Risk_OldTableAdapter;
        private LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}