namespace Applicatie_Risicoanalyse.Reports
{
    partial class PerformanceLevelReport
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
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.get_RiskAssessment_Index_DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_RiskAssessment_Index_DataTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskAssessment_Index_DataTableAdapter();
            this.tableAdapterManager = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.tbl_DangerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_Risks_With_PL_In_ProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_Risks_With_PL_In_ProjectTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_Risks_With_PL_In_ProjectTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskAssessment_Index_DataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DangerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Risks_With_PL_In_ProjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lG_Analysis_DatabaseDataSet
            // 
            this.lG_Analysis_DatabaseDataSet.DataSetName = "LG_Analysis_DatabaseDataSet";
            this.lG_Analysis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // get_RiskAssessment_Index_DataBindingSource
            // 
            this.get_RiskAssessment_Index_DataBindingSource.DataMember = "Get_RiskAssessment_Index_Data";
            this.get_RiskAssessment_Index_DataBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_RiskAssessment_Index_DataTableAdapter
            // 
            this.get_RiskAssessment_Index_DataTableAdapter.ClearBeforeFill = true;
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
            // tbl_DangerBindingSource
            // 
            this.tbl_DangerBindingSource.DataMember = "Tbl_Danger";
            this.tbl_DangerBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_Risks_With_PL_In_ProjectBindingSource
            // 
            this.get_Risks_With_PL_In_ProjectBindingSource.DataMember = "Get_Risks_With_PL_In_Project";
            this.get_Risks_With_PL_In_ProjectBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_Risks_With_PL_In_ProjectTableAdapter
            // 
            this.get_Risks_With_PL_In_ProjectTableAdapter.ClearBeforeFill = true;
            // 
            // PerformanceLevelReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.ClientSize = new System.Drawing.Size(412, 133);
            this.Name = "PerformanceLevelReport";
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskAssessment_Index_DataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DangerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Risks_With_PL_In_ProjectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private System.Windows.Forms.BindingSource get_RiskAssessment_Index_DataBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskAssessment_Index_DataTableAdapter get_RiskAssessment_Index_DataTableAdapter;
        private LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tbl_DangerBindingSource;
        private System.Windows.Forms.BindingSource get_Risks_With_PL_In_ProjectBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_Risks_With_PL_In_ProjectTableAdapter get_Risks_With_PL_In_ProjectTableAdapter;
    }
}
