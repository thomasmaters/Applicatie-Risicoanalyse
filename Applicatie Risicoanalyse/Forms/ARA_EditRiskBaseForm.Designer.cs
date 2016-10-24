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
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.get_RiskEstimation_In_RiskData_AfterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_RiskEstimation_In_RiskData_AfterTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskEstimation_In_RiskData_AfterTableAdapter();
            this.tableAdapterManager = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.get_RiskReduction_In_RiskDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_RiskReduction_In_RiskDataTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskReduction_In_RiskDataTableAdapter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.arA_EditRiskExposedPersons1 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskExposedPersons();
            this.arA_EditRiskHazardIndentification1 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskHazardIndentification();
            this.arA_EditRiskRiskEstimation1 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskRiskEstimation();
            this.arA_EditRiskRiskReductionMesures1 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskRiskReductionMesures();
            this.arA_EditRiskRiskEstimation2 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskRiskEstimation();
            this.arA_EditRiskRiskReductionMesures2 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskRiskReductionMesures();
            this.tbl_Risk_DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Risk_DataTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_DataTableAdapter();
            this.get_MinimalAddition_In_RiskDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_MinimalAddition_In_RiskDataTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_MinimalAddition_In_RiskDataTableAdapter();
            this.get_RiskEstimation_In_RiskData_BeforeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_RiskEstimation_In_RiskData_BeforeTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskEstimation_In_RiskData_BeforeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskEstimation_In_RiskData_AfterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskReduction_In_RiskDataBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Risk_DataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_MinimalAddition_In_RiskDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskEstimation_In_RiskData_BeforeBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // get_RiskReduction_In_RiskDataBindingSource
            // 
            this.get_RiskReduction_In_RiskDataBindingSource.DataMember = "Get_RiskReduction_In_RiskData";
            this.get_RiskReduction_In_RiskDataBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_RiskReduction_In_RiskDataTableAdapter
            // 
            this.get_RiskReduction_In_RiskDataTableAdapter.ClearBeforeFill = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.arA_EditRiskExposedPersons1);
            this.flowLayoutPanel1.Controls.Add(this.arA_EditRiskHazardIndentification1);
            this.flowLayoutPanel1.Controls.Add(this.arA_EditRiskRiskEstimation1);
            this.flowLayoutPanel1.Controls.Add(this.arA_EditRiskRiskReductionMesures1);
            this.flowLayoutPanel1.Controls.Add(this.arA_EditRiskRiskEstimation2);
            this.flowLayoutPanel1.Controls.Add(this.arA_EditRiskRiskReductionMesures2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(750, 1500);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(750, 1100);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // arA_EditRiskExposedPersons1
            // 
            this.arA_EditRiskExposedPersons1.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_EditRiskExposedPersons1.Location = new System.Drawing.Point(0, 0);
            this.arA_EditRiskExposedPersons1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_EditRiskExposedPersons1.Name = "arA_EditRiskExposedPersons1";
            this.arA_EditRiskExposedPersons1.Size = new System.Drawing.Size(750, 64);
            this.arA_EditRiskExposedPersons1.TabIndex = 0;
            // 
            // arA_EditRiskHazardIndentification1
            // 
            this.arA_EditRiskHazardIndentification1.AutoScroll = true;
            this.arA_EditRiskHazardIndentification1.BackColor = System.Drawing.Color.White;
            this.arA_EditRiskHazardIndentification1.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_EditRiskHazardIndentification1.HasControlBeenChanged = true;
            this.arA_EditRiskHazardIndentification1.Location = new System.Drawing.Point(0, 64);
            this.arA_EditRiskHazardIndentification1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_EditRiskHazardIndentification1.MaximumSize = new System.Drawing.Size(750, 170);
            this.arA_EditRiskHazardIndentification1.Name = "arA_EditRiskHazardIndentification1";
            this.arA_EditRiskHazardIndentification1.Size = new System.Drawing.Size(750, 170);
            this.arA_EditRiskHazardIndentification1.TabIndex = 1;
            // 
            // arA_EditRiskRiskEstimation1
            // 
            this.arA_EditRiskRiskEstimation1.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_EditRiskRiskEstimation1.Location = new System.Drawing.Point(0, 234);
            this.arA_EditRiskRiskEstimation1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_EditRiskRiskEstimation1.Name = "arA_EditRiskRiskEstimation1";
            this.arA_EditRiskRiskEstimation1.Size = new System.Drawing.Size(750, 300);
            this.arA_EditRiskRiskEstimation1.TabIndex = 2;
            this.arA_EditRiskRiskEstimation1.TitleText = "Risk Estimation";
            // 
            // arA_EditRiskRiskReductionMesures1
            // 
            this.arA_EditRiskRiskReductionMesures1.AutoSize = true;
            this.arA_EditRiskRiskReductionMesures1.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_EditRiskRiskReductionMesures1.Location = new System.Drawing.Point(0, 534);
            this.arA_EditRiskRiskReductionMesures1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_EditRiskRiskReductionMesures1.MaximumSize = new System.Drawing.Size(750, 500);
            this.arA_EditRiskRiskReductionMesures1.Name = "arA_EditRiskRiskReductionMesures1";
            this.arA_EditRiskRiskReductionMesures1.Size = new System.Drawing.Size(739, 114);
            this.arA_EditRiskRiskReductionMesures1.TabIndex = 3;
            this.arA_EditRiskRiskReductionMesures1.TitleText = "Hazard Identification";
            // 
            // arA_EditRiskRiskEstimation2
            // 
            this.arA_EditRiskRiskEstimation2.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_EditRiskRiskEstimation2.Location = new System.Drawing.Point(0, 648);
            this.arA_EditRiskRiskEstimation2.Margin = new System.Windows.Forms.Padding(0);
            this.arA_EditRiskRiskEstimation2.Name = "arA_EditRiskRiskEstimation2";
            this.arA_EditRiskRiskEstimation2.Size = new System.Drawing.Size(750, 322);
            this.arA_EditRiskRiskEstimation2.TabIndex = 4;
            this.arA_EditRiskRiskEstimation2.TitleText = "Risk Estimation(After risk reduction)";
            // 
            // arA_EditRiskRiskReductionMesures2
            // 
            this.arA_EditRiskRiskReductionMesures2.AutoSize = true;
            this.arA_EditRiskRiskReductionMesures2.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_EditRiskRiskReductionMesures2.Location = new System.Drawing.Point(0, 970);
            this.arA_EditRiskRiskReductionMesures2.Margin = new System.Windows.Forms.Padding(0);
            this.arA_EditRiskRiskReductionMesures2.MaximumSize = new System.Drawing.Size(750, 500);
            this.arA_EditRiskRiskReductionMesures2.Name = "arA_EditRiskRiskReductionMesures2";
            this.arA_EditRiskRiskReductionMesures2.Size = new System.Drawing.Size(739, 114);
            this.arA_EditRiskRiskReductionMesures2.TabIndex = 5;
            this.arA_EditRiskRiskReductionMesures2.TitleText = "Minimal Addition";
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
            // get_MinimalAddition_In_RiskDataBindingSource
            // 
            this.get_MinimalAddition_In_RiskDataBindingSource.DataMember = "Get_MinimalAddition_In_RiskData";
            this.get_MinimalAddition_In_RiskDataBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_MinimalAddition_In_RiskDataTableAdapter
            // 
            this.get_MinimalAddition_In_RiskDataTableAdapter.ClearBeforeFill = true;
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
            // ARA_EditRiskBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(750, 500);
            this.Name = "ARA_EditRiskBaseForm";
            this.Text = "ARA_EditRiskInProject";
            this.Load += new System.EventHandler(this.ARA_EditRiskBaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskEstimation_In_RiskData_AfterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskReduction_In_RiskDataBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Risk_DataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_MinimalAddition_In_RiskDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskEstimation_In_RiskData_BeforeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ARA_EditRiskExposedPersons arA_EditRiskExposedPersons1;
        private Controls.ARA_EditRiskHazardIndentification arA_EditRiskHazardIndentification1;
        private Controls.ARA_EditRiskRiskEstimation arA_EditRiskRiskEstimation1;
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private System.Windows.Forms.BindingSource get_RiskEstimation_In_RiskData_AfterBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskEstimation_In_RiskData_AfterTableAdapter get_RiskEstimation_In_RiskData_AfterTableAdapter;
        private LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Controls.ARA_EditRiskRiskReductionMesures arA_EditRiskRiskReductionMesures1;
        private System.Windows.Forms.BindingSource get_RiskReduction_In_RiskDataBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskReduction_In_RiskDataTableAdapter get_RiskReduction_In_RiskDataTableAdapter;
        private Controls.ARA_EditRiskRiskEstimation arA_EditRiskRiskEstimation2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.BindingSource tbl_Risk_DataBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_DataTableAdapter tbl_Risk_DataTableAdapter;
        private Controls.ARA_EditRiskRiskReductionMesures arA_EditRiskRiskReductionMesures2;
        private System.Windows.Forms.BindingSource get_MinimalAddition_In_RiskDataBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_MinimalAddition_In_RiskDataTableAdapter get_MinimalAddition_In_RiskDataTableAdapter;
        private System.Windows.Forms.BindingSource get_RiskEstimation_In_RiskData_BeforeBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskEstimation_In_RiskData_BeforeTableAdapter get_RiskEstimation_In_RiskData_BeforeTableAdapter;
    }
}