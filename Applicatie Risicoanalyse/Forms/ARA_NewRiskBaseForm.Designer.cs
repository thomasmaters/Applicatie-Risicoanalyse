using System.Diagnostics;

namespace Applicatie_Risicoanalyse.Forms
{
    partial class ARA_NewRiskBaseForm
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
                deleteControlIfItIsNotFilled();
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.arA_Button1 = new Applicatie_Risicoanalyse.Controls.ARA_Button();
            this.arA_NewRiskRiskGrouping1 = new Applicatie_Risicoanalyse.Controls.ARA_NewRiskRiskGrouping();
            this.arA_EditRiskExposedPersons1 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskExposedPersons();
            this.arA_EditRiskHazardIndentification1 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskHazardIndentification();
            this.arA_EditRiskRiskEstimation1 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskRiskEstimation();
            this.arA_EditRiskRiskReductionMesures1 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskRiskReductionMesures();
            this.arA_EditRiskRiskEstimation2 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskRiskEstimation();
            this.arA_EditRiskRiskReductionMesures2 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskRiskReductionMesures();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.get_RiskEstimation_In_RiskData_AfterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_RiskEstimation_In_RiskData_AfterTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskEstimation_In_RiskData_AfterTableAdapter();
            this.tableAdapterManager = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.get_RiskReduction_In_RiskDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_RiskReduction_In_RiskDataTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskReduction_In_RiskDataTableAdapter();
            this.get_MinimalAddition_In_RiskDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_MinimalAddition_In_RiskDataTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_MinimalAddition_In_RiskDataTableAdapter();
            this.get_RiskEstimation_In_RiskData_BeforeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_RiskEstimation_In_RiskData_BeforeTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskEstimation_In_RiskData_BeforeTableAdapter();
            this.get_ExposedPersons_In_RiskDataTableAdapter1 = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_ExposedPersons_In_RiskDataTableAdapter();
            this.tbl_RiskReduction_In_RiskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_RiskReduction_In_RiskTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_RiskReduction_In_RiskTableAdapter();
            this.tbl_MinimalAddition_In_RiskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MinimalAddition_In_RiskTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_MinimalAddition_In_RiskTableAdapter();
            this.tbl_Risk_DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Risk_DataTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_DataTableAdapter();
            this.queriesTableAdapter1 = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.QueriesTableAdapter();
            this.tbl_BLOB_StorageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_BLOB_StorageTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_BLOB_StorageTableAdapter();
            this.tbl_ExposedPersons_In_RiskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ExposedPersons_In_RiskTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_ExposedPersons_In_RiskTableAdapter();
            this.tbl_RiskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_RiskTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_RiskTableAdapter();
            this.create_New_Risk_VersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.create_New_Risk_VersionTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Create_New_Risk_VersionTableAdapter();
            this.get_Risks_In_Group_And_TypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_Risks_In_Group_And_TypeTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_Risks_In_Group_And_TypeTableAdapter();
            this.create_New_RiskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.create_New_RiskTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Create_New_RiskTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskEstimation_In_RiskData_AfterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskReduction_In_RiskDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_MinimalAddition_In_RiskDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskEstimation_In_RiskData_BeforeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_RiskReduction_In_RiskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_MinimalAddition_In_RiskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Risk_DataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_BLOB_StorageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ExposedPersons_In_RiskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_RiskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.create_New_Risk_VersionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Risks_In_Group_And_TypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.create_New_RiskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.arA_Button1);
            this.flowLayoutPanel1.Controls.Add(this.arA_NewRiskRiskGrouping1);
            this.flowLayoutPanel1.Controls.Add(this.arA_EditRiskExposedPersons1);
            this.flowLayoutPanel1.Controls.Add(this.arA_EditRiskHazardIndentification1);
            this.flowLayoutPanel1.Controls.Add(this.arA_EditRiskRiskEstimation1);
            this.flowLayoutPanel1.Controls.Add(this.arA_EditRiskRiskReductionMesures1);
            this.flowLayoutPanel1.Controls.Add(this.arA_EditRiskRiskEstimation2);
            this.flowLayoutPanel1.Controls.Add(this.arA_EditRiskRiskReductionMesures2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(730, 5000);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(730, 1838);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(741, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // arA_Button1
            // 
            this.arA_Button1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.arA_Button1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.arA_Button1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.arA_Button1.Location = new System.Drawing.Point(0, 275);
            this.arA_Button1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.arA_Button1.Name = "arA_Button1";
            this.arA_Button1.Selected = false;
            this.arA_Button1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.arA_Button1.SelectedTextColor = System.Drawing.Color.Black;
            this.arA_Button1.Size = new System.Drawing.Size(741, 44);
            this.arA_Button1.TabIndex = 7;
            this.arA_Button1.Text = "Upload new image for risk";
            this.arA_Button1.TextColor = System.Drawing.Color.Black;
            this.arA_Button1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.arA_Button1.Click += new System.EventHandler(this.arA_Button1_Click);
            // 
            // arA_NewRiskRiskGrouping1
            // 
            this.arA_NewRiskRiskGrouping1.AutoScroll = true;
            this.arA_NewRiskRiskGrouping1.BackColor = System.Drawing.Color.White;
            this.arA_NewRiskRiskGrouping1.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_NewRiskRiskGrouping1.HasControlBeenChanged = false;
            this.arA_NewRiskRiskGrouping1.IndicatorRectangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.arA_NewRiskRiskGrouping1.Location = new System.Drawing.Point(0, 344);
            this.arA_NewRiskRiskGrouping1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_NewRiskRiskGrouping1.MaximumSize = new System.Drawing.Size(750, 140);
            this.arA_NewRiskRiskGrouping1.Name = "arA_NewRiskRiskGrouping1";
            this.arA_NewRiskRiskGrouping1.Size = new System.Drawing.Size(750, 140);
            this.arA_NewRiskRiskGrouping1.TabIndex = 11;
            // 
            // arA_EditRiskExposedPersons1
            // 
            this.arA_EditRiskExposedPersons1.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_EditRiskExposedPersons1.HasControlBeenChanged = false;
            this.arA_EditRiskExposedPersons1.IndicatorRectangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.arA_EditRiskExposedPersons1.Location = new System.Drawing.Point(0, 484);
            this.arA_EditRiskExposedPersons1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_EditRiskExposedPersons1.Name = "arA_EditRiskExposedPersons1";
            this.arA_EditRiskExposedPersons1.Size = new System.Drawing.Size(750, 55);
            this.arA_EditRiskExposedPersons1.TabIndex = 0;
            // 
            // arA_EditRiskHazardIndentification1
            // 
            this.arA_EditRiskHazardIndentification1.AutoScroll = true;
            this.arA_EditRiskHazardIndentification1.BackColor = System.Drawing.Color.White;
            this.arA_EditRiskHazardIndentification1.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_EditRiskHazardIndentification1.HasControlBeenChanged = true;
            this.arA_EditRiskHazardIndentification1.IndicatorRectangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.arA_EditRiskHazardIndentification1.Location = new System.Drawing.Point(0, 539);
            this.arA_EditRiskHazardIndentification1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_EditRiskHazardIndentification1.MaximumSize = new System.Drawing.Size(750, 170);
            this.arA_EditRiskHazardIndentification1.Name = "arA_EditRiskHazardIndentification1";
            this.arA_EditRiskHazardIndentification1.Size = new System.Drawing.Size(750, 170);
            this.arA_EditRiskHazardIndentification1.TabIndex = 1;
            // 
            // arA_EditRiskRiskEstimation1
            // 
            this.arA_EditRiskRiskEstimation1.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_EditRiskRiskEstimation1.HasControlBeenChanged = false;
            this.arA_EditRiskRiskEstimation1.IndicatorRectangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.arA_EditRiskRiskEstimation1.Location = new System.Drawing.Point(0, 709);
            this.arA_EditRiskRiskEstimation1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_EditRiskRiskEstimation1.Name = "arA_EditRiskRiskEstimation1";
            this.arA_EditRiskRiskEstimation1.Size = new System.Drawing.Size(750, 316);
            this.arA_EditRiskRiskEstimation1.TabIndex = 2;
            this.arA_EditRiskRiskEstimation1.TitleText = "Risk Estimation";
            // 
            // arA_EditRiskRiskReductionMesures1
            // 
            this.arA_EditRiskRiskReductionMesures1.AutoSize = true;
            this.arA_EditRiskRiskReductionMesures1.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_EditRiskRiskReductionMesures1.HasControlBeenChanged = false;
            this.arA_EditRiskRiskReductionMesures1.IndicatorRectangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.arA_EditRiskRiskReductionMesures1.Location = new System.Drawing.Point(0, 1025);
            this.arA_EditRiskRiskReductionMesures1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_EditRiskRiskReductionMesures1.MaximumSize = new System.Drawing.Size(750, 2000);
            this.arA_EditRiskRiskReductionMesures1.Name = "arA_EditRiskRiskReductionMesures1";
            this.arA_EditRiskRiskReductionMesures1.Size = new System.Drawing.Size(725, 115);
            this.arA_EditRiskRiskReductionMesures1.TabIndex = 3;
            this.arA_EditRiskRiskReductionMesures1.TitleText = "Risk Reduction Mesures";
            // 
            // arA_EditRiskRiskEstimation2
            // 
            this.arA_EditRiskRiskEstimation2.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_EditRiskRiskEstimation2.HasControlBeenChanged = false;
            this.arA_EditRiskRiskEstimation2.IndicatorRectangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.arA_EditRiskRiskEstimation2.Location = new System.Drawing.Point(0, 1140);
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
            this.arA_EditRiskRiskReductionMesures2.HasControlBeenChanged = false;
            this.arA_EditRiskRiskReductionMesures2.IndicatorRectangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.arA_EditRiskRiskReductionMesures2.Location = new System.Drawing.Point(0, 1462);
            this.arA_EditRiskRiskReductionMesures2.Margin = new System.Windows.Forms.Padding(0);
            this.arA_EditRiskRiskReductionMesures2.MaximumSize = new System.Drawing.Size(725, 2000);
            this.arA_EditRiskRiskReductionMesures2.Name = "arA_EditRiskRiskReductionMesures2";
            this.arA_EditRiskRiskReductionMesures2.Size = new System.Drawing.Size(725, 115);
            this.arA_EditRiskRiskReductionMesures2.TabIndex = 5;
            this.arA_EditRiskRiskReductionMesures2.TitleText = "Minimal Addition";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
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
            this.tableAdapterManager.Tbl_RiskReductionMeasuresTableAdapter = null;
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
            // get_ExposedPersons_In_RiskDataTableAdapter1
            // 
            this.get_ExposedPersons_In_RiskDataTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_RiskReduction_In_RiskBindingSource
            // 
            this.tbl_RiskReduction_In_RiskBindingSource.DataMember = "Tbl_RiskReduction_In_Risk";
            this.tbl_RiskReduction_In_RiskBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // tbl_RiskReduction_In_RiskTableAdapter
            // 
            this.tbl_RiskReduction_In_RiskTableAdapter.ClearBeforeFill = true;
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
            // tbl_Risk_DataBindingSource
            // 
            this.tbl_Risk_DataBindingSource.DataMember = "Tbl_Risk_Data";
            this.tbl_Risk_DataBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // tbl_Risk_DataTableAdapter
            // 
            this.tbl_Risk_DataTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_BLOB_StorageBindingSource
            // 
            this.tbl_BLOB_StorageBindingSource.DataMember = "Tbl_BLOB_Storage";
            this.tbl_BLOB_StorageBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // tbl_BLOB_StorageTableAdapter
            // 
            this.tbl_BLOB_StorageTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_ExposedPersons_In_RiskBindingSource
            // 
            this.tbl_ExposedPersons_In_RiskBindingSource.DataMember = "Tbl_ExposedPersons_In_Risk";
            this.tbl_ExposedPersons_In_RiskBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // tbl_ExposedPersons_In_RiskTableAdapter
            // 
            this.tbl_ExposedPersons_In_RiskTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_RiskBindingSource
            // 
            this.tbl_RiskBindingSource.DataMember = "Tbl_Risk";
            this.tbl_RiskBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // tbl_RiskTableAdapter
            // 
            this.tbl_RiskTableAdapter.ClearBeforeFill = true;
            // 
            // create_New_Risk_VersionBindingSource
            // 
            this.create_New_Risk_VersionBindingSource.DataMember = "Create_New_Risk_Version";
            this.create_New_Risk_VersionBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // create_New_Risk_VersionTableAdapter
            // 
            this.create_New_Risk_VersionTableAdapter.ClearBeforeFill = true;
            // 
            // get_Risks_In_Group_And_TypeBindingSource
            // 
            this.get_Risks_In_Group_And_TypeBindingSource.DataMember = "Get_Risks_In_Group_And_Type";
            this.get_Risks_In_Group_And_TypeBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_Risks_In_Group_And_TypeTableAdapter
            // 
            this.get_Risks_In_Group_And_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // create_New_RiskBindingSource
            // 
            this.create_New_RiskBindingSource.DataMember = "Create_New_Risk";
            this.create_New_RiskBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // create_New_RiskTableAdapter
            // 
            this.create_New_RiskTableAdapter.ClearBeforeFill = true;
            // 
            // ARA_NewRiskBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(750, 488);
            this.Name = "ARA_NewRiskBaseForm";
            this.Text = "ARA_EditRiskInProject";
            this.Load += new System.EventHandler(this.ARA_EditRiskBaseForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskEstimation_In_RiskData_AfterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskReduction_In_RiskDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_MinimalAddition_In_RiskDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskEstimation_In_RiskData_BeforeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_RiskReduction_In_RiskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_MinimalAddition_In_RiskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Risk_DataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_BLOB_StorageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ExposedPersons_In_RiskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_RiskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.create_New_Risk_VersionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Risks_In_Group_And_TypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.create_New_RiskBindingSource)).EndInit();
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
        private Controls.ARA_EditRiskRiskReductionMesures arA_EditRiskRiskReductionMesures2;
        private System.Windows.Forms.BindingSource get_MinimalAddition_In_RiskDataBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_MinimalAddition_In_RiskDataTableAdapter get_MinimalAddition_In_RiskDataTableAdapter;
        private System.Windows.Forms.BindingSource get_RiskEstimation_In_RiskData_BeforeBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskEstimation_In_RiskData_BeforeTableAdapter get_RiskEstimation_In_RiskData_BeforeTableAdapter;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_ExposedPersons_In_RiskDataTableAdapter get_ExposedPersons_In_RiskDataTableAdapter1;
        private System.Windows.Forms.BindingSource tbl_RiskReduction_In_RiskBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_RiskReduction_In_RiskTableAdapter tbl_RiskReduction_In_RiskTableAdapter;
        private System.Windows.Forms.BindingSource tbl_MinimalAddition_In_RiskBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_MinimalAddition_In_RiskTableAdapter tbl_MinimalAddition_In_RiskTableAdapter;
        private System.Windows.Forms.BindingSource tbl_Risk_DataBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_DataTableAdapter tbl_Risk_DataTableAdapter;
        private LG_Analysis_DatabaseDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.ARA_Button arA_Button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource tbl_BLOB_StorageBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_BLOB_StorageTableAdapter tbl_BLOB_StorageTableAdapter;
        private System.Windows.Forms.BindingSource tbl_ExposedPersons_In_RiskBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_ExposedPersons_In_RiskTableAdapter tbl_ExposedPersons_In_RiskTableAdapter;
        private System.Windows.Forms.BindingSource tbl_RiskBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_RiskTableAdapter tbl_RiskTableAdapter;
        private System.Windows.Forms.BindingSource create_New_Risk_VersionBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Create_New_Risk_VersionTableAdapter create_New_Risk_VersionTableAdapter;
        private System.Windows.Forms.BindingSource get_Risks_In_Group_And_TypeBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_Risks_In_Group_And_TypeTableAdapter get_Risks_In_Group_And_TypeTableAdapter;
        private System.Windows.Forms.BindingSource create_New_RiskBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Create_New_RiskTableAdapter create_New_RiskTableAdapter;
        private Controls.ARA_NewRiskRiskGrouping arA_NewRiskRiskGrouping1;
    }
}