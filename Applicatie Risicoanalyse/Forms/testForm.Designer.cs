namespace Applicatie_Risicoanalyse.Forms
{
    partial class testForm
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
            this.tblRiskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_RiskTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_RiskTableAdapter();
            this.tbl_Risk_AnalysisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Risk_AnalysisTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_AnalysisTableAdapter();
            this.tableAdapterManager = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.tbl_Risks_In_ProjectTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risks_In_ProjectTableAdapter();
            this.tbl_Risks_In_ProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_Risks_With_RiskData_In_ProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_Risks_With_RiskData_In_ProjectTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_Risks_With_RiskData_In_ProjectTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRiskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Risk_AnalysisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Risks_In_ProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Risks_With_RiskData_In_ProjectBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.Tbl_RiskReductionMesuresTableAdapter = null;
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
            // testForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 511);
            this.Name = "testForm";
            this.Text = "testForm";
            this.Load += new System.EventHandler(this.testForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRiskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Risk_AnalysisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Risks_In_ProjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Risks_With_RiskData_In_ProjectBindingSource)).EndInit();
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
    }
}