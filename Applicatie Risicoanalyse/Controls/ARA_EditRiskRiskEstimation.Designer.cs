namespace Applicatie_Risicoanalyse.Controls
{
    partial class ARA_EditRiskRiskEstimation
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
            this.arA_Rectangle2 = new Applicatie_Risicoanalyse.Controls.ARA_Rectangle();
            this.arA_Text6 = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.get_RiskEstimationItems_From_GroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RiskEstimationTextTitle = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.get_RiskEstimationItems_From_GroupTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskEstimationItems_From_GroupTableAdapter();
            this.tableAdapterManager = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.tbl_RiskEstimation_GroupTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_RiskEstimation_GroupTableAdapter();
            this.tbl_RiskEstimation_GroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arA_EditRiskRiskEstimationItem1 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskRiskEstimationItem();
            this.arA_EditRiskRiskEstimationItem2 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskRiskEstimationItem();
            this.arA_EditRiskRiskEstimationItem3 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskRiskEstimationItem();
            this.arA_EditRiskRiskEstimationItem4 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskRiskEstimationItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskEstimationItems_From_GroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_RiskEstimation_GroupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.arA_EditRiskRiskEstimationItem4);
            this.panel1.Controls.Add(this.arA_EditRiskRiskEstimationItem3);
            this.panel1.Controls.Add(this.arA_EditRiskRiskEstimationItem2);
            this.panel1.Controls.Add(this.arA_EditRiskRiskEstimationItem1);
            this.panel1.Controls.Add(this.arA_Rectangle2);
            this.panel1.Controls.Add(this.arA_Text6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 356);
            this.panel1.TabIndex = 0;
            // 
            // arA_Rectangle2
            // 
            this.arA_Rectangle2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.arA_Rectangle2.Location = new System.Drawing.Point(11, 23);
            this.arA_Rectangle2.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Rectangle2.Name = "arA_Rectangle2";
            this.arA_Rectangle2.Size = new System.Drawing.Size(4, 280);
            this.arA_Rectangle2.TabIndex = 61;
            this.arA_Rectangle2.Text = "arA_Rectangle2";
            // 
            // arA_Text6
            // 
            this.arA_Text6.BackgroundColor = System.Drawing.Color.White;
            this.arA_Text6.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.arA_Text6.Location = new System.Drawing.Point(15, 274);
            this.arA_Text6.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Text6.Name = "arA_Text6";
            this.arA_Text6.Size = new System.Drawing.Size(724, 29);
            this.arA_Text6.TabIndex = 60;
            this.arA_Text6.Text = "DUMMYTEXT";
            this.arA_Text6.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // get_RiskEstimationItems_From_GroupBindingSource
            // 
            this.get_RiskEstimationItems_From_GroupBindingSource.DataMember = "Get_RiskEstimationItems_From_Group";
            this.get_RiskEstimationItems_From_GroupBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // lG_Analysis_DatabaseDataSet
            // 
            this.lG_Analysis_DatabaseDataSet.DataSetName = "LG_Analysis_DatabaseDataSet";
            this.lG_Analysis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(770, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 356);
            this.panel2.TabIndex = 35;
            // 
            // RiskEstimationTextTitle
            // 
            this.RiskEstimationTextTitle.BackgroundColor = System.Drawing.Color.White;
            this.RiskEstimationTextTitle.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.RiskEstimationTextTitle.Location = new System.Drawing.Point(11, 0);
            this.RiskEstimationTextTitle.Margin = new System.Windows.Forms.Padding(0);
            this.RiskEstimationTextTitle.Name = "RiskEstimationTextTitle";
            this.RiskEstimationTextTitle.Size = new System.Drawing.Size(728, 23);
            this.RiskEstimationTextTitle.TabIndex = 33;
            this.RiskEstimationTextTitle.Text = "Risk Estimation";
            this.RiskEstimationTextTitle.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // get_RiskEstimationItems_From_GroupTableAdapter
            // 
            this.get_RiskEstimationItems_From_GroupTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Tbl_Risk_AnalysisTableAdapter = null;
            this.tableAdapterManager.Tbl_Risk_DataTableAdapter = null;
            this.tableAdapterManager.Tbl_Risk_Project_StateTableAdapter = null;
            this.tableAdapterManager.Tbl_RiskEstimation_GroupTableAdapter = this.tbl_RiskEstimation_GroupTableAdapter;
            this.tableAdapterManager.Tbl_RiskEstimation_In_Risk_AfterTableAdapter = null;
            this.tableAdapterManager.Tbl_RiskEstimation_In_Risk_BeforeTableAdapter = null;
            this.tableAdapterManager.Tbl_RiskEstimation_ItemTableAdapter = null;
            this.tableAdapterManager.Tbl_RiskReduction_In_RiskTableAdapter = null;
            this.tableAdapterManager.Tbl_RiskReductionMesuresTableAdapter = null;
            this.tableAdapterManager.Tbl_Risks_In_ProjectTableAdapter = null;
            this.tableAdapterManager.Tbl_RiskTableAdapter = null;
            this.tableAdapterManager.Tbl_User_PermissionsTableAdapter = null;
            this.tableAdapterManager.Tbl_UserTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_RiskEstimation_GroupTableAdapter
            // 
            this.tbl_RiskEstimation_GroupTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_RiskEstimation_GroupBindingSource
            // 
            this.tbl_RiskEstimation_GroupBindingSource.DataMember = "Tbl_RiskEstimation_Group";
            this.tbl_RiskEstimation_GroupBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // arA_EditRiskRiskEstimationItem1
            // 
            this.arA_EditRiskRiskEstimationItem1.ButtonWeights = new int[] {
        0};
            this.arA_EditRiskRiskEstimationItem1.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_EditRiskRiskEstimationItem1.Location = new System.Drawing.Point(15, 23);
            this.arA_EditRiskRiskEstimationItem1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_EditRiskRiskEstimationItem1.MaximumSize = new System.Drawing.Size(724, 63);
            this.arA_EditRiskRiskEstimationItem1.Name = "arA_EditRiskRiskEstimationItem1";
            this.arA_EditRiskRiskEstimationItem1.Size = new System.Drawing.Size(724, 63);
            this.arA_EditRiskRiskEstimationItem1.TabIndex = 72;
            // 
            // arA_EditRiskRiskEstimationItem2
            // 
            this.arA_EditRiskRiskEstimationItem2.ButtonWeights = new int[] {
        0};
            this.arA_EditRiskRiskEstimationItem2.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_EditRiskRiskEstimationItem2.Location = new System.Drawing.Point(15, 86);
            this.arA_EditRiskRiskEstimationItem2.Margin = new System.Windows.Forms.Padding(0);
            this.arA_EditRiskRiskEstimationItem2.MaximumSize = new System.Drawing.Size(724, 63);
            this.arA_EditRiskRiskEstimationItem2.Name = "arA_EditRiskRiskEstimationItem2";
            this.arA_EditRiskRiskEstimationItem2.Size = new System.Drawing.Size(724, 63);
            this.arA_EditRiskRiskEstimationItem2.TabIndex = 73;
            // 
            // arA_EditRiskRiskEstimationItem3
            // 
            this.arA_EditRiskRiskEstimationItem3.ButtonWeights = new int[] {
        0};
            this.arA_EditRiskRiskEstimationItem3.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_EditRiskRiskEstimationItem3.Location = new System.Drawing.Point(15, 149);
            this.arA_EditRiskRiskEstimationItem3.Margin = new System.Windows.Forms.Padding(0);
            this.arA_EditRiskRiskEstimationItem3.MaximumSize = new System.Drawing.Size(724, 63);
            this.arA_EditRiskRiskEstimationItem3.Name = "arA_EditRiskRiskEstimationItem3";
            this.arA_EditRiskRiskEstimationItem3.Size = new System.Drawing.Size(724, 63);
            this.arA_EditRiskRiskEstimationItem3.TabIndex = 74;
            // 
            // arA_EditRiskRiskEstimationItem4
            // 
            this.arA_EditRiskRiskEstimationItem4.ButtonWeights = new int[] {
        0};
            this.arA_EditRiskRiskEstimationItem4.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_EditRiskRiskEstimationItem4.Location = new System.Drawing.Point(15, 212);
            this.arA_EditRiskRiskEstimationItem4.Margin = new System.Windows.Forms.Padding(0);
            this.arA_EditRiskRiskEstimationItem4.MaximumSize = new System.Drawing.Size(724, 63);
            this.arA_EditRiskRiskEstimationItem4.Name = "arA_EditRiskRiskEstimationItem4";
            this.arA_EditRiskRiskEstimationItem4.Size = new System.Drawing.Size(724, 63);
            this.arA_EditRiskRiskEstimationItem4.TabIndex = 75;
            // 
            // ARA_EditRiskRiskEstimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RiskEstimationTextTitle);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ARA_EditRiskRiskEstimation";
            this.Size = new System.Drawing.Size(781, 356);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.get_RiskEstimationItems_From_GroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_RiskEstimation_GroupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ARA_Text RiskEstimationTextTitle;
        private ARA_Text arA_Text6;
        private ARA_Rectangle arA_Rectangle2;
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private System.Windows.Forms.BindingSource get_RiskEstimationItems_From_GroupBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_RiskEstimationItems_From_GroupTableAdapter get_RiskEstimationItems_From_GroupTableAdapter;
        private LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_RiskEstimation_GroupTableAdapter tbl_RiskEstimation_GroupTableAdapter;
        private System.Windows.Forms.BindingSource tbl_RiskEstimation_GroupBindingSource;
        private ARA_EditRiskRiskEstimationItem arA_EditRiskRiskEstimationItem4;
        private ARA_EditRiskRiskEstimationItem arA_EditRiskRiskEstimationItem3;
        private ARA_EditRiskRiskEstimationItem arA_EditRiskRiskEstimationItem2;
        private ARA_EditRiskRiskEstimationItem arA_EditRiskRiskEstimationItem1;
    }
}
