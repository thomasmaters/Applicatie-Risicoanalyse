namespace Applicatie_Risicoanalyse.Controls
{
    partial class ARA_EditRiskExposedPersons
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.arA_Rectangle1 = new Applicatie_Risicoanalyse.Controls.ARA_Rectangle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.arA_Text1 = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.tbl_ExposedPersons_In_RiskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ExposedPersons_In_RiskTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_ExposedPersons_In_RiskTableAdapter();
            this.tableAdapterManager = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ExposedPersons_In_RiskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(750, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 266);
            this.panel1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.arA_Rectangle1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.arA_Text1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(761, 266);
            this.panel3.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 23);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(724, 28);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // arA_Rectangle1
            // 
            this.arA_Rectangle1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.arA_Rectangle1.Location = new System.Drawing.Point(11, 23);
            this.arA_Rectangle1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Rectangle1.Name = "arA_Rectangle1";
            this.arA_Rectangle1.Size = new System.Drawing.Size(4, 28);
            this.arA_Rectangle1.TabIndex = 8;
            this.arA_Rectangle1.Text = "arA_Rectangle1";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 266);
            this.panel2.TabIndex = 11;
            // 
            // arA_Text1
            // 
            this.arA_Text1.BackgroundColor = System.Drawing.Color.White;
            this.arA_Text1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.arA_Text1.Location = new System.Drawing.Point(11, 0);
            this.arA_Text1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Text1.Name = "arA_Text1";
            this.arA_Text1.Size = new System.Drawing.Size(728, 23);
            this.arA_Text1.TabIndex = 7;
            this.arA_Text1.Text = "Exposed Persons";
            this.arA_Text1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lG_Analysis_DatabaseDataSet
            // 
            this.lG_Analysis_DatabaseDataSet.DataSetName = "LG_Analysis_DatabaseDataSet";
            this.lG_Analysis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tbl_BLOB_StorageTableAdapter = null;
            this.tableAdapterManager.Tbl_Component_GroupTableAdapter = null;
            this.tableAdapterManager.Tbl_Component_TypeTableAdapter = null;
            this.tableAdapterManager.Tbl_Danger_ResultTableAdapter = null;
            this.tableAdapterManager.Tbl_Danger_SourceTableAdapter = null;
            this.tableAdapterManager.Tbl_DangerTableAdapter = null;
            this.tableAdapterManager.Tbl_ExposedPersons_In_RiskTableAdapter = this.tbl_ExposedPersons_In_RiskTableAdapter;
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
            // ARA_EditRiskExposedPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ARA_EditRiskExposedPersons";
            this.Size = new System.Drawing.Size(761, 266);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ExposedPersons_In_RiskBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ARA_Rectangle arA_Rectangle1;
        private ARA_Text arA_Text1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private System.Windows.Forms.BindingSource tbl_ExposedPersons_In_RiskBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_ExposedPersons_In_RiskTableAdapter tbl_ExposedPersons_In_RiskTableAdapter;
        private LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
