﻿namespace Applicatie_Risicoanalyse.Controls
{
    partial class ARA_EditRiskHazardIndentification
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tbl_Danger_SourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.tbl_DangerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_DangerTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_DangerTableAdapter();
            this.tableAdapterManager = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.tbl_Danger_SourceTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Danger_SourceTableAdapter();
            this.tbl_Danger_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Danger_ResultTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Danger_ResultTableAdapter();
            this.tbl_Risk_DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Risk_DataTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_DataTableAdapter();
            this.hazardIndentificationRectangleIndicator = new Applicatie_Risicoanalyse.Controls.ARA_Rectangle();
            this.arA_TextBox2 = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            this.HazardTextEvent = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.arA_TextBox1 = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            this.HazardTextSituation = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.HazardTextConsequence2 = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.HazardTextConsequence1 = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.HazardTextSource = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.HazardTextType = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.HarzardTextTitle = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Danger_SourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DangerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Danger_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Risk_DataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "DangerGroupName";
            this.comboBox1.Font = new System.Drawing.Font("Gotham Light", 11F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 46);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(351, 26);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.ValueMember = "DangerGroupName";
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "DangerSourceName";
            this.comboBox2.Font = new System.Drawing.Font("Gotham Light", 11F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(19, 92);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(351, 26);
            this.comboBox2.TabIndex = 34;
            this.comboBox2.ValueMember = "DangerSourceName";
            // 
            // tbl_Danger_SourceBindingSource
            // 
            this.tbl_Danger_SourceBindingSource.DataMember = "Tbl_Danger_Source";
            this.tbl_Danger_SourceBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // lG_Analysis_DatabaseDataSet
            // 
            this.lG_Analysis_DatabaseDataSet.DataSetName = "LG_Analysis_DatabaseDataSet";
            this.lG_Analysis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tbl_BLOB_StorageTableAdapter = null;
            this.tableAdapterManager.Tbl_Component_GroupTableAdapter = null;
            this.tableAdapterManager.Tbl_Component_TypeTableAdapter = null;
            this.tableAdapterManager.Tbl_Danger_ResultTableAdapter = null;
            this.tableAdapterManager.Tbl_Danger_SourceTableAdapter = null;
            this.tableAdapterManager.Tbl_DangerTableAdapter = this.tbl_DangerTableAdapter;
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
            // tbl_Danger_SourceTableAdapter
            // 
            this.tbl_Danger_SourceTableAdapter.ClearBeforeFill = true;
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
            // tbl_Risk_DataBindingSource
            // 
            this.tbl_Risk_DataBindingSource.DataMember = "Tbl_Risk_Data";
            this.tbl_Risk_DataBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // tbl_Risk_DataTableAdapter
            // 
            this.tbl_Risk_DataTableAdapter.ClearBeforeFill = true;
            // 
            // hazardIndentificationRectangleIndicator
            // 
            this.hazardIndentificationRectangleIndicator.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.hazardIndentificationRectangleIndicator.Location = new System.Drawing.Point(11, 23);
            this.hazardIndentificationRectangleIndicator.Margin = new System.Windows.Forms.Padding(0);
            this.hazardIndentificationRectangleIndicator.Name = "hazardIndentificationRectangleIndicator";
            this.hazardIndentificationRectangleIndicator.Size = new System.Drawing.Size(4, 138);
            this.hazardIndentificationRectangleIndicator.TabIndex = 29;
            this.hazardIndentificationRectangleIndicator.Text = "arA_Rectangle2";
            // 
            // arA_TextBox2
            // 
            this.arA_TextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.arA_TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.arA_TextBox2.BorderSize = 1;
            this.arA_TextBox2.Font = new System.Drawing.Font("Gotham Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_TextBox2.Location = new System.Drawing.Point(383, 117);
            this.arA_TextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.arA_TextBox2.Name = "arA_TextBox2";
            this.arA_TextBox2.Size = new System.Drawing.Size(355, 44);
            this.arA_TextBox2.TabIndex = 28;
            this.arA_TextBox2.Text = "";
            this.arA_TextBox2.TextChanged += new System.EventHandler(this.arA_TextBox2_TextChanged);
            // 
            // HazardTextEvent
            // 
            this.HazardTextEvent.BackgroundColor = System.Drawing.Color.White;
            this.HazardTextEvent.Font = new System.Drawing.Font("Gotham Light", 13F, System.Drawing.FontStyle.Italic);
            this.HazardTextEvent.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.HazardTextEvent.Location = new System.Drawing.Point(382, 92);
            this.HazardTextEvent.Margin = new System.Windows.Forms.Padding(0);
            this.HazardTextEvent.Name = "HazardTextEvent";
            this.HazardTextEvent.Size = new System.Drawing.Size(356, 23);
            this.HazardTextEvent.TabIndex = 27;
            this.HazardTextEvent.Text = "Event description";
            this.HazardTextEvent.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // arA_TextBox1
            // 
            this.arA_TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.arA_TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.arA_TextBox1.BorderSize = 1;
            this.arA_TextBox1.Font = new System.Drawing.Font("Gotham Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_TextBox1.Location = new System.Drawing.Point(383, 46);
            this.arA_TextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_TextBox1.Name = "arA_TextBox1";
            this.arA_TextBox1.Size = new System.Drawing.Size(355, 46);
            this.arA_TextBox1.TabIndex = 26;
            this.arA_TextBox1.Text = "";
            this.arA_TextBox1.TextChanged += new System.EventHandler(this.arA_TextBox1_TextChanged);
            // 
            // HazardTextSituation
            // 
            this.HazardTextSituation.BackgroundColor = System.Drawing.Color.White;
            this.HazardTextSituation.Font = new System.Drawing.Font("Gotham Light", 13F, System.Drawing.FontStyle.Italic);
            this.HazardTextSituation.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.HazardTextSituation.Location = new System.Drawing.Point(383, 23);
            this.HazardTextSituation.Margin = new System.Windows.Forms.Padding(0);
            this.HazardTextSituation.Name = "HazardTextSituation";
            this.HazardTextSituation.Size = new System.Drawing.Size(356, 23);
            this.HazardTextSituation.TabIndex = 25;
            this.HazardTextSituation.Text = "Brief action description";
            this.HazardTextSituation.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // HazardTextConsequence2
            // 
            this.HazardTextConsequence2.BackgroundColor = System.Drawing.Color.White;
            this.HazardTextConsequence2.Font = new System.Drawing.Font("Gotham Light", 13F, System.Drawing.FontStyle.Italic);
            this.HazardTextConsequence2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.HazardTextConsequence2.Location = new System.Drawing.Point(15, 138);
            this.HazardTextConsequence2.Margin = new System.Windows.Forms.Padding(0);
            this.HazardTextConsequence2.Name = "HazardTextConsequence2";
            this.HazardTextConsequence2.Size = new System.Drawing.Size(355, 23);
            this.HazardTextConsequence2.TabIndex = 24;
            this.HazardTextConsequence2.Text = "Danger result 2";
            this.HazardTextConsequence2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // HazardTextConsequence1
            // 
            this.HazardTextConsequence1.BackgroundColor = System.Drawing.Color.White;
            this.HazardTextConsequence1.Font = new System.Drawing.Font("Gotham Light", 13F, System.Drawing.FontStyle.Italic);
            this.HazardTextConsequence1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.HazardTextConsequence1.Location = new System.Drawing.Point(15, 118);
            this.HazardTextConsequence1.Margin = new System.Windows.Forms.Padding(0);
            this.HazardTextConsequence1.Name = "HazardTextConsequence1";
            this.HazardTextConsequence1.Size = new System.Drawing.Size(355, 20);
            this.HazardTextConsequence1.TabIndex = 23;
            this.HazardTextConsequence1.Text = "Danger result 1";
            this.HazardTextConsequence1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // HazardTextSource
            // 
            this.HazardTextSource.BackgroundColor = System.Drawing.Color.White;
            this.HazardTextSource.Font = new System.Drawing.Font("Gotham Light", 13F, System.Drawing.FontStyle.Italic);
            this.HazardTextSource.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.HazardTextSource.Location = new System.Drawing.Point(15, 72);
            this.HazardTextSource.Margin = new System.Windows.Forms.Padding(0);
            this.HazardTextSource.Name = "HazardTextSource";
            this.HazardTextSource.Size = new System.Drawing.Size(355, 20);
            this.HazardTextSource.TabIndex = 22;
            this.HazardTextSource.Text = "Hazard Source";
            this.HazardTextSource.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // HazardTextType
            // 
            this.HazardTextType.BackgroundColor = System.Drawing.Color.White;
            this.HazardTextType.Font = new System.Drawing.Font("Gotham Light", 13F, System.Drawing.FontStyle.Italic);
            this.HazardTextType.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.HazardTextType.Location = new System.Drawing.Point(15, 23);
            this.HazardTextType.Margin = new System.Windows.Forms.Padding(0);
            this.HazardTextType.Name = "HazardTextType";
            this.HazardTextType.Size = new System.Drawing.Size(355, 23);
            this.HazardTextType.TabIndex = 20;
            this.HazardTextType.Text = "Hazard Type";
            this.HazardTextType.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // HarzardTextTitle
            // 
            this.HarzardTextTitle.BackgroundColor = System.Drawing.Color.White;
            this.HarzardTextTitle.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.HarzardTextTitle.Location = new System.Drawing.Point(11, 0);
            this.HarzardTextTitle.Margin = new System.Windows.Forms.Padding(0);
            this.HarzardTextTitle.Name = "HarzardTextTitle";
            this.HarzardTextTitle.Size = new System.Drawing.Size(728, 23);
            this.HarzardTextTitle.TabIndex = 19;
            this.HarzardTextTitle.Text = "Hazard Identification";
            this.HarzardTextTitle.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ARA_EditRiskHazardIndentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.hazardIndentificationRectangleIndicator);
            this.Controls.Add(this.arA_TextBox2);
            this.Controls.Add(this.HazardTextEvent);
            this.Controls.Add(this.arA_TextBox1);
            this.Controls.Add(this.HazardTextSituation);
            this.Controls.Add(this.HazardTextConsequence2);
            this.Controls.Add(this.HazardTextConsequence1);
            this.Controls.Add(this.HazardTextSource);
            this.Controls.Add(this.HazardTextType);
            this.Controls.Add(this.HarzardTextTitle);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(750, 170);
            this.Name = "ARA_EditRiskHazardIndentification";
            this.Size = new System.Drawing.Size(750, 170);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Danger_SourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DangerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Danger_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Risk_DataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ARA_Rectangle hazardIndentificationRectangleIndicator;
        private ARA_TextBox arA_TextBox2;
        private ARA_Text HazardTextEvent;
        private ARA_TextBox arA_TextBox1;
        private ARA_Text HazardTextSituation;
        private ARA_Text HazardTextConsequence2;
        private ARA_Text HazardTextConsequence1;
        private ARA_Text HazardTextSource;
        private ARA_Text HazardTextType;
        private ARA_Text HarzardTextTitle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource tbl_DangerBindingSource;
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_DangerTableAdapter tbl_DangerTableAdapter;
        private LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tbl_Danger_SourceBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Danger_SourceTableAdapter tbl_Danger_SourceTableAdapter;
        private System.Windows.Forms.BindingSource tbl_Danger_ResultBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Danger_ResultTableAdapter tbl_Danger_ResultTableAdapter;
        private System.Windows.Forms.BindingSource tbl_Risk_DataBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_DataTableAdapter tbl_Risk_DataTableAdapter;
    }
}
