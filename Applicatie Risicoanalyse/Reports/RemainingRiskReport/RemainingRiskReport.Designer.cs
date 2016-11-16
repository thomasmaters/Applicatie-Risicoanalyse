namespace Applicatie_Risicoanalyse.Forms
{
    partial class RemainingRiskReport
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RarProgressBar = new System.Windows.Forms.ProgressBar();
            this.RarButtonCancel = new Applicatie_Risicoanalyse.Controls.ARA_Button();
            this.RarProgressText = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.tblRiskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_RiskTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_RiskTableAdapter();
            this.tbl_Risk_AnalysisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Risk_AnalysisTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_AnalysisTableAdapter();
            this.tableAdapterManager = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.tbl_Risks_In_ProjectTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risks_In_ProjectTableAdapter();
            this.tbl_Risks_In_ProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_Risks_With_RiskData_In_ProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_Risks_With_RiskData_In_ProjectTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_Risks_With_RiskData_In_ProjectTableAdapter();
            this.get_RiskReduction_In_RiskDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_RiskReduction_In_RiskDataTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskReduction_In_RiskDataTableAdapter();
            this.get_MinimalAddition_In_RiskDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_MinimalAddition_In_RiskDataTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_MinimalAddition_In_RiskDataTableAdapter();
            this.get_RiskEstimation_In_RiskData_AfterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_RiskEstimation_In_RiskData_AfterTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskEstimation_In_RiskData_AfterTableAdapter();
            this.get_RiskEstimation_In_RiskData_BeforeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_RiskEstimation_In_RiskData_BeforeTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskEstimation_In_RiskData_BeforeTableAdapter();
            this.get_ExposedPersons_In_RiskDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_ExposedPersons_In_RiskDataTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_ExposedPersons_In_RiskDataTableAdapter();
            this.tbl_Risk_DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Risk_DataTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_DataTableAdapter();
            this.tbl_DangerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_DangerTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_DangerTableAdapter();
            this.tbl_Danger_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Danger_ResultTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Danger_ResultTableAdapter();
            this.tbl_Danger_SourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Danger_SourceTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Danger_SourceTableAdapter();
            this.tbl_MinimalAddition_In_RiskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MinimalAddition_In_RiskTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_MinimalAddition_In_RiskTableAdapter();
            this.get_RemainingRisks_In_ProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_RemainingRisks_In_ProjectTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_RemainingRisks_In_ProjectTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRiskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Risk_AnalysisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Risks_In_ProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Risks_With_RiskData_In_ProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskReduction_In_RiskDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_MinimalAddition_In_RiskDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskEstimation_In_RiskData_AfterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskEstimation_In_RiskData_BeforeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_ExposedPersons_In_RiskDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Risk_DataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DangerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Danger_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Danger_SourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_MinimalAddition_In_RiskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RemainingRisks_In_ProjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RarProgressBar
            // 
            this.RarProgressBar.Location = new System.Drawing.Point(16, 13);
            this.RarProgressBar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.RarProgressBar.Name = "RarProgressBar";
            this.RarProgressBar.Size = new System.Drawing.Size(381, 40);
            this.RarProgressBar.TabIndex = 0;
            // 
            // RarButtonCancel
            // 
            this.RarButtonCancel.BaseColor = System.Drawing.Color.Maroon;
            this.RarButtonCancel.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.RarButtonCancel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.RarButtonCancel.Location = new System.Drawing.Point(16, 93);
            this.RarButtonCancel.Name = "RarButtonCancel";
            this.RarButtonCancel.Selected = false;
            this.RarButtonCancel.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.RarButtonCancel.SelectedTextColor = System.Drawing.Color.White;
            this.RarButtonCancel.Size = new System.Drawing.Size(381, 23);
            this.RarButtonCancel.TabIndex = 2;
            this.RarButtonCancel.Text = "Cancel";
            this.RarButtonCancel.TextColor = System.Drawing.Color.White;
            this.RarButtonCancel.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.RarButtonCancel.Click += new System.EventHandler(this.RarButtonCancel_Click);
            // 
            // RarProgressText
            // 
            this.RarProgressText.BackgroundColor = System.Drawing.Color.White;
            this.RarProgressText.Font = new System.Drawing.Font("Gotham Book", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RarProgressText.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.RarProgressText.Location = new System.Drawing.Point(16, 56);
            this.RarProgressText.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.RarProgressText.Name = "RarProgressText";
            this.RarProgressText.Size = new System.Drawing.Size(381, 28);
            this.RarProgressText.TabIndex = 1;
            this.RarProgressText.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lG_Analysis_DatabaseDataSet
            // 
            this.lG_Analysis_DatabaseDataSet.DataSetName = "LG_Analysis_DatabaseDataSet";
            this.lG_Analysis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRiskBindingSource
            // 
            this.tblRiskBindingSource.DataMember = "Tbl_Risk";
            this.tblRiskBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // tbl_RiskTableAdapter
            // 
            this.tbl_RiskTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Tbl_Risks_In_ProjectTableAdapter = this.tbl_Risks_In_ProjectTableAdapter;
            this.tableAdapterManager.Tbl_RiskTableAdapter = this.tbl_RiskTableAdapter;
            this.tableAdapterManager.Tbl_User_PermissionsTableAdapter = null;
            this.tableAdapterManager.Tbl_UserTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_Risks_In_ProjectTableAdapter
            // 
            this.tbl_Risks_In_ProjectTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Risks_In_ProjectBindingSource
            // 
            this.tbl_Risks_In_ProjectBindingSource.DataMember = "Tbl_Risks_In_Project";
            this.tbl_Risks_In_ProjectBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_Risks_With_RiskData_In_ProjectBindingSource
            // 
            this.get_Risks_With_RiskData_In_ProjectBindingSource.DataMember = "Get_Risks_With_RiskData_In_Project";
            this.get_Risks_With_RiskData_In_ProjectBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_Risks_With_RiskData_In_ProjectTableAdapter
            // 
            this.get_Risks_With_RiskData_In_ProjectTableAdapter.ClearBeforeFill = true;
            // 
            // get_RiskReduction_In_RiskDataBindingSource
            // 
            this.get_RiskReduction_In_RiskDataBindingSource.DataMember = "Get_RiskReduction_In_RiskData";
            this.get_RiskReduction_In_RiskDataBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_RiskReduction_In_RiskDataTableAdapter
            // 
            this.get_RiskReduction_In_RiskDataTableAdapter.ClearBeforeFill = true;
            // 
            // get_MinimalAddition_In_RiskDataBindingSource
            // 
            this.get_MinimalAddition_In_RiskDataBindingSource.DataMember = "Get_MinimalAddition_In_RiskData";
            this.get_MinimalAddition_In_RiskDataBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_MinimalAddition_In_RiskDataTableAdapter
            // 
            this.get_MinimalAddition_In_RiskDataTableAdapter.ClearBeforeFill = true;
            // 
            // get_RiskEstimation_In_RiskData_AfterBindingSource
            // 
            this.get_RiskEstimation_In_RiskData_AfterBindingSource.DataMember = "Get_RiskEstimation_In_RiskData_After";
            this.get_RiskEstimation_In_RiskData_AfterBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_RiskEstimation_In_RiskData_AfterTableAdapter
            // 
            this.get_RiskEstimation_In_RiskData_AfterTableAdapter.ClearBeforeFill = true;
            // 
            // get_RiskEstimation_In_RiskData_BeforeBindingSource
            // 
            this.get_RiskEstimation_In_RiskData_BeforeBindingSource.DataMember = "Get_RiskEstimation_In_RiskData_Before";
            this.get_RiskEstimation_In_RiskData_BeforeBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_RiskEstimation_In_RiskData_BeforeTableAdapter
            // 
            this.get_RiskEstimation_In_RiskData_BeforeTableAdapter.ClearBeforeFill = true;
            // 
            // get_ExposedPersons_In_RiskDataBindingSource
            // 
            this.get_ExposedPersons_In_RiskDataBindingSource.DataMember = "Get_ExposedPersons_In_RiskData";
            this.get_ExposedPersons_In_RiskDataBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_ExposedPersons_In_RiskDataTableAdapter
            // 
            this.get_ExposedPersons_In_RiskDataTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Risk_DataBindingSource
            // 
            this.tbl_Risk_DataBindingSource.DataMember = "Tbl_Risk_Data";
            this.tbl_Risk_DataBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // tbl_Risk_DataTableAdapter
            // 
            this.tbl_Risk_DataTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_DangerBindingSource
            // 
            this.tbl_DangerBindingSource.DataMember = "Tbl_Danger";
            this.tbl_DangerBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // tbl_DangerTableAdapter
            // 
            this.tbl_DangerTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Danger_ResultBindingSource
            // 
            this.tbl_Danger_ResultBindingSource.DataMember = "Tbl_Danger_Result";
            this.tbl_Danger_ResultBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // tbl_Danger_ResultTableAdapter
            // 
            this.tbl_Danger_ResultTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Danger_SourceBindingSource
            // 
            this.tbl_Danger_SourceBindingSource.DataMember = "Tbl_Danger_Source";
            this.tbl_Danger_SourceBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // tbl_Danger_SourceTableAdapter
            // 
            this.tbl_Danger_SourceTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_MinimalAddition_In_RiskBindingSource
            // 
            this.tbl_MinimalAddition_In_RiskBindingSource.DataMember = "Tbl_MinimalAddition_In_Risk";
            this.tbl_MinimalAddition_In_RiskBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // tbl_MinimalAddition_In_RiskTableAdapter
            // 
            this.tbl_MinimalAddition_In_RiskTableAdapter.ClearBeforeFill = true;
            // 
            // get_RemainingRisks_In_ProjectBindingSource
            // 
            this.get_RemainingRisks_In_ProjectBindingSource.DataMember = "Get_RemainingRisks_In_Project";
            this.get_RemainingRisks_In_ProjectBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_RemainingRisks_In_ProjectTableAdapter
            // 
            this.get_RemainingRisks_In_ProjectTableAdapter.ClearBeforeFill = true;
            // 
            // RemainingRiskReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(417, 123);
            this.Controls.Add(this.RarButtonCancel);
            this.Controls.Add(this.RarProgressText);
            this.Controls.Add(this.RarProgressBar);
            this.Font = new System.Drawing.Font("Gotham Book", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "RemainingRiskReport";
            this.Text = "Remaining Rest-Risk Report";
            this.Load += new System.EventHandler(this.testForm_Load);
            this.Shown += new System.EventHandler(this.testForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRiskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Risk_AnalysisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Risks_In_ProjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Risks_With_RiskData_In_ProjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskReduction_In_RiskDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_MinimalAddition_In_RiskDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskEstimation_In_RiskData_AfterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskEstimation_In_RiskData_BeforeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_ExposedPersons_In_RiskDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Risk_DataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DangerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Danger_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Danger_SourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_MinimalAddition_In_RiskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RemainingRisks_In_ProjectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private System.Windows.Forms.BindingSource tblRiskBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_RiskTableAdapter tbl_RiskTableAdapter;
        private System.Windows.Forms.BindingSource tbl_Risk_AnalysisBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_AnalysisTableAdapter tbl_Risk_AnalysisTableAdapter;
        private LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risks_In_ProjectTableAdapter tbl_Risks_In_ProjectTableAdapter;
        private System.Windows.Forms.BindingSource tbl_Risks_In_ProjectBindingSource;
        private System.Windows.Forms.BindingSource get_Risks_With_RiskData_In_ProjectBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_Risks_With_RiskData_In_ProjectTableAdapter get_Risks_With_RiskData_In_ProjectTableAdapter;
        private System.Windows.Forms.BindingSource get_RiskReduction_In_RiskDataBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskReduction_In_RiskDataTableAdapter get_RiskReduction_In_RiskDataTableAdapter;
        private System.Windows.Forms.BindingSource get_MinimalAddition_In_RiskDataBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_MinimalAddition_In_RiskDataTableAdapter get_MinimalAddition_In_RiskDataTableAdapter;
        private System.Windows.Forms.BindingSource get_RiskEstimation_In_RiskData_AfterBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskEstimation_In_RiskData_AfterTableAdapter get_RiskEstimation_In_RiskData_AfterTableAdapter;
        private System.Windows.Forms.BindingSource get_RiskEstimation_In_RiskData_BeforeBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskEstimation_In_RiskData_BeforeTableAdapter get_RiskEstimation_In_RiskData_BeforeTableAdapter;
        private System.Windows.Forms.BindingSource get_ExposedPersons_In_RiskDataBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_ExposedPersons_In_RiskDataTableAdapter get_ExposedPersons_In_RiskDataTableAdapter;
        private System.Windows.Forms.BindingSource tbl_Risk_DataBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_DataTableAdapter tbl_Risk_DataTableAdapter;
        private System.Windows.Forms.BindingSource tbl_DangerBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_DangerTableAdapter tbl_DangerTableAdapter;
        private System.Windows.Forms.BindingSource tbl_Danger_ResultBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Danger_ResultTableAdapter tbl_Danger_ResultTableAdapter;
        private System.Windows.Forms.BindingSource tbl_Danger_SourceBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Danger_SourceTableAdapter tbl_Danger_SourceTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar RarProgressBar;
        private Controls.ARA_Text RarProgressText;
        private Controls.ARA_Button RarButtonCancel;
        private System.Windows.Forms.BindingSource tbl_MinimalAddition_In_RiskBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_MinimalAddition_In_RiskTableAdapter tbl_MinimalAddition_In_RiskTableAdapter;
        private System.Windows.Forms.BindingSource get_RemainingRisks_In_ProjectBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_RemainingRisks_In_ProjectTableAdapter get_RemainingRisks_In_ProjectTableAdapter;
    }
}