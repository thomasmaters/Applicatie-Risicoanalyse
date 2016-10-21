namespace Applicatie_Risicoanalyse.Forms
{
    partial class ARA_EditRiskBaseForm
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
            this.arA_EditRiskRiskEstimation1 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskRiskEstimation();
            this.arA_EditRiskHazardIndentification1 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskHazardIndentification();
            this.arA_EditRiskExposedPersons1 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskExposedPersons();
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.get_RiskEstimation_In_RiskData_AfterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_RiskEstimation_In_RiskData_AfterTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskEstimation_In_RiskData_AfterTableAdapter();
            this.tableAdapterManager = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskEstimation_In_RiskData_AfterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // arA_EditRiskRiskEstimation1
            // 
            this.arA_EditRiskRiskEstimation1.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_EditRiskRiskEstimation1.Location = new System.Drawing.Point(3, 237);
            this.arA_EditRiskRiskEstimation1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_EditRiskRiskEstimation1.Name = "arA_EditRiskRiskEstimation1";
            this.arA_EditRiskRiskEstimation1.Size = new System.Drawing.Size(750, 300);
            this.arA_EditRiskRiskEstimation1.TabIndex = 2;
            // 
            // arA_EditRiskHazardIndentification1
            // 
            this.arA_EditRiskHazardIndentification1.AutoScroll = true;
            this.arA_EditRiskHazardIndentification1.BackColor = System.Drawing.Color.White;
            this.arA_EditRiskHazardIndentification1.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_EditRiskHazardIndentification1.HasControlBeenChanged = true;
            this.arA_EditRiskHazardIndentification1.Location = new System.Drawing.Point(3, 67);
            this.arA_EditRiskHazardIndentification1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_EditRiskHazardIndentification1.MaximumSize = new System.Drawing.Size(750, 170);
            this.arA_EditRiskHazardIndentification1.Name = "arA_EditRiskHazardIndentification1";
            this.arA_EditRiskHazardIndentification1.Size = new System.Drawing.Size(750, 170);
            this.arA_EditRiskHazardIndentification1.TabIndex = 1;
            // 
            // arA_EditRiskExposedPersons1
            // 
            this.arA_EditRiskExposedPersons1.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_EditRiskExposedPersons1.Location = new System.Drawing.Point(3, 3);
            this.arA_EditRiskExposedPersons1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_EditRiskExposedPersons1.Name = "arA_EditRiskExposedPersons1";
            this.arA_EditRiskExposedPersons1.Size = new System.Drawing.Size(750, 64);
            this.arA_EditRiskExposedPersons1.TabIndex = 0;
            // 
            // lG_Analysis_DatabaseDataSet
            // 
            this.lG_Analysis_DatabaseDataSet.DataSetName = "LG_Analysis_DatabaseDataSet";
            this.lG_Analysis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.Tbl_RiskReductionMesuresTableAdapter = null;
            this.tableAdapterManager.Tbl_Risks_In_ProjectTableAdapter = null;
            this.tableAdapterManager.Tbl_RiskTableAdapter = null;
            this.tableAdapterManager.Tbl_User_PermissionsTableAdapter = null;
            this.tableAdapterManager.Tbl_UserTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ARA_EditRiskBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 743);
            this.Controls.Add(this.arA_EditRiskRiskEstimation1);
            this.Controls.Add(this.arA_EditRiskHazardIndentification1);
            this.Controls.Add(this.arA_EditRiskExposedPersons1);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(750, 1500);
            this.Name = "ARA_EditRiskBaseForm";
            this.Text = "ARA_EditRiskInProject";
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskEstimation_In_RiskData_AfterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ARA_EditRiskExposedPersons arA_EditRiskExposedPersons1;
        private Controls.ARA_EditRiskHazardIndentification arA_EditRiskHazardIndentification1;
        private Controls.ARA_EditRiskRiskEstimation arA_EditRiskRiskEstimation1;
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private System.Windows.Forms.BindingSource get_RiskEstimation_In_RiskData_AfterBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskEstimation_In_RiskData_AfterTableAdapter get_RiskEstimation_In_RiskData_AfterTableAdapter;
        private LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}