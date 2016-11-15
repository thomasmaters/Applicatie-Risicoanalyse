namespace Applicatie_Risicoanalyse.Controls
{
    partial class ARA_NewRiskRiskGrouping
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
            this.riskGroupingComboBoxComponentType = new System.Windows.Forms.ComboBox();
            this.riskGroupingComboBoxComponentGroup = new System.Windows.Forms.ComboBox();
            this.riskGroupingRectangleIndicator = new Applicatie_Risicoanalyse.Controls.ARA_Rectangle();
            this.HazardTextSource = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.HazardTextType = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.RiskGroupingText = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.tbl_Component_GroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Component_GroupTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Component_GroupTableAdapter();
            this.tableAdapterManager = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.tbl_Component_TypeTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Component_TypeTableAdapter();
            this.tbl_Component_TypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Component_GroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Component_TypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // riskGroupingComboBoxComponentType
            // 
            this.riskGroupingComboBoxComponentType.DisplayMember = "DangerSourceName";
            this.riskGroupingComboBoxComponentType.Font = new System.Drawing.Font("Gotham Light", 11F);
            this.riskGroupingComboBoxComponentType.FormattingEnabled = true;
            this.riskGroupingComboBoxComponentType.Location = new System.Drawing.Point(19, 97);
            this.riskGroupingComboBoxComponentType.Margin = new System.Windows.Forms.Padding(0);
            this.riskGroupingComboBoxComponentType.Name = "riskGroupingComboBoxComponentType";
            this.riskGroupingComboBoxComponentType.Size = new System.Drawing.Size(351, 26);
            this.riskGroupingComboBoxComponentType.TabIndex = 40;
            this.riskGroupingComboBoxComponentType.ValueMember = "DangerSourceName";
            this.riskGroupingComboBoxComponentType.SelectedIndexChanged += new System.EventHandler(this.riskGroupingComboBoxComponentType_SelectedIndexChanged);
            // 
            // riskGroupingComboBoxComponentGroup
            // 
            this.riskGroupingComboBoxComponentGroup.DisplayMember = "DangerGroupName";
            this.riskGroupingComboBoxComponentGroup.Font = new System.Drawing.Font("Gotham Light", 11F);
            this.riskGroupingComboBoxComponentGroup.FormattingEnabled = true;
            this.riskGroupingComboBoxComponentGroup.Location = new System.Drawing.Point(19, 51);
            this.riskGroupingComboBoxComponentGroup.Margin = new System.Windows.Forms.Padding(0);
            this.riskGroupingComboBoxComponentGroup.Name = "riskGroupingComboBoxComponentGroup";
            this.riskGroupingComboBoxComponentGroup.Size = new System.Drawing.Size(351, 26);
            this.riskGroupingComboBoxComponentGroup.TabIndex = 39;
            this.riskGroupingComboBoxComponentGroup.ValueMember = "DangerGroupName";
            // 
            // riskGroupingRectangleIndicator
            // 
            this.riskGroupingRectangleIndicator.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.riskGroupingRectangleIndicator.Location = new System.Drawing.Point(11, 28);
            this.riskGroupingRectangleIndicator.Margin = new System.Windows.Forms.Padding(0);
            this.riskGroupingRectangleIndicator.Name = "riskGroupingRectangleIndicator";
            this.riskGroupingRectangleIndicator.Size = new System.Drawing.Size(4, 100);
            this.riskGroupingRectangleIndicator.TabIndex = 38;
            this.riskGroupingRectangleIndicator.Text = "arA_Rectangle2";
            // 
            // HazardTextSource
            // 
            this.HazardTextSource.BackgroundColor = System.Drawing.Color.White;
            this.HazardTextSource.Font = new System.Drawing.Font("Gotham Light", 13F, System.Drawing.FontStyle.Italic);
            this.HazardTextSource.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.HazardTextSource.Location = new System.Drawing.Point(15, 77);
            this.HazardTextSource.Margin = new System.Windows.Forms.Padding(0);
            this.HazardTextSource.Name = "HazardTextSource";
            this.HazardTextSource.Size = new System.Drawing.Size(355, 20);
            this.HazardTextSource.TabIndex = 37;
            this.HazardTextSource.Text = "Sub-Group";
            this.HazardTextSource.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // HazardTextType
            // 
            this.HazardTextType.BackgroundColor = System.Drawing.Color.White;
            this.HazardTextType.Font = new System.Drawing.Font("Gotham Light", 13F, System.Drawing.FontStyle.Italic);
            this.HazardTextType.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.HazardTextType.Location = new System.Drawing.Point(15, 28);
            this.HazardTextType.Margin = new System.Windows.Forms.Padding(0);
            this.HazardTextType.Name = "HazardTextType";
            this.HazardTextType.Size = new System.Drawing.Size(355, 23);
            this.HazardTextType.TabIndex = 36;
            this.HazardTextType.Text = "Group";
            this.HazardTextType.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // RiskGroupingText
            // 
            this.RiskGroupingText.BackgroundColor = System.Drawing.Color.White;
            this.RiskGroupingText.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.RiskGroupingText.Location = new System.Drawing.Point(11, 5);
            this.RiskGroupingText.Margin = new System.Windows.Forms.Padding(0);
            this.RiskGroupingText.Name = "RiskGroupingText";
            this.RiskGroupingText.Size = new System.Drawing.Size(728, 23);
            this.RiskGroupingText.TabIndex = 35;
            this.RiskGroupingText.Text = "Risk Grouping";
            this.RiskGroupingText.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lG_Analysis_DatabaseDataSet
            // 
            this.lG_Analysis_DatabaseDataSet.DataSetName = "LG_Analysis_DatabaseDataSet";
            this.lG_Analysis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Component_GroupBindingSource
            // 
            this.tbl_Component_GroupBindingSource.DataMember = "Tbl_Component_Group";
            this.tbl_Component_GroupBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // tbl_Component_GroupTableAdapter
            // 
            this.tbl_Component_GroupTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tbl_BLOB_StorageTableAdapter = null;
            this.tableAdapterManager.Tbl_Component_GroupTableAdapter = this.tbl_Component_GroupTableAdapter;
            this.tableAdapterManager.Tbl_Component_TypeTableAdapter = this.tbl_Component_TypeTableAdapter;
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
            // tbl_Component_TypeTableAdapter
            // 
            this.tbl_Component_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Component_TypeBindingSource
            // 
            this.tbl_Component_TypeBindingSource.DataMember = "Tbl_Component_Type";
            this.tbl_Component_TypeBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // ARA_NewRiskRiskGrouping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.riskGroupingComboBoxComponentType);
            this.Controls.Add(this.riskGroupingComboBoxComponentGroup);
            this.Controls.Add(this.riskGroupingRectangleIndicator);
            this.Controls.Add(this.HazardTextSource);
            this.Controls.Add(this.HazardTextType);
            this.Controls.Add(this.RiskGroupingText);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(750, 140);
            this.Name = "ARA_NewRiskRiskGrouping";
            this.Size = new System.Drawing.Size(750, 140);
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Component_GroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Component_TypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox riskGroupingComboBoxComponentType;
        private System.Windows.Forms.ComboBox riskGroupingComboBoxComponentGroup;
        private ARA_Rectangle riskGroupingRectangleIndicator;
        private ARA_Text HazardTextSource;
        private ARA_Text HazardTextType;
        private ARA_Text RiskGroupingText;
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private System.Windows.Forms.BindingSource tbl_Component_GroupBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Component_GroupTableAdapter tbl_Component_GroupTableAdapter;
        private LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Component_TypeTableAdapter tbl_Component_TypeTableAdapter;
        private System.Windows.Forms.BindingSource tbl_Component_TypeBindingSource;
    }
}
