namespace Applicatie_Risicoanalyse.Forms
{
    partial class ARA_AddRisksToProject
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.arA_TextBox1 = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            this.addRiskToProjectPanelContent = new System.Windows.Forms.FlowLayoutPanel();
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.tbl_Component_GroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Component_GroupTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Component_GroupTableAdapter();
            this.tableAdapterManager = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.tbl_Component_TypeTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Component_TypeTableAdapter();
            this.tbl_Component_TypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.queriesTableAdapter1 = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.QueriesTableAdapter();
            this.get_Risks_In_Project_GroupTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_Risks_In_Project_GroupTableAdapter();
            this.get_Risks_In_Project_TypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_Risks_In_Project_TypeTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_Risks_In_Project_TypeTableAdapter();
            this.get_Risks_In_ProjectGroupTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_Risks_In_ProjectGroupTypeTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_Risks_In_ProjectGroupTypeTableAdapter();
            this.is_Risk_In_ProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.is_Risk_In_ProjectTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Is_Risk_In_ProjectTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Component_GroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Component_TypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Risks_In_Project_TypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Risks_In_ProjectGroupTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.is_Risk_In_ProjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.arA_TextBox1);
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(750, 38);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // arA_TextBox1
            // 
            this.arA_TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.arA_TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.arA_TextBox1.BorderSize = 1;
            this.arA_TextBox1.Location = new System.Drawing.Point(3, 3);
            this.arA_TextBox1.Name = "arA_TextBox1";
            this.arA_TextBox1.Size = new System.Drawing.Size(406, 35);
            this.arA_TextBox1.TabIndex = 0;
            this.arA_TextBox1.Text = "";
            // 
            // addRiskToProjectPanelContent
            // 

            this.addRiskToProjectPanelContent.HorizontalScroll.Maximum = 0;
            this.addRiskToProjectPanelContent.AutoScroll = false;
            this.addRiskToProjectPanelContent.VerticalScroll.Visible = false;
            this.addRiskToProjectPanelContent.AutoScroll = true;
            this.addRiskToProjectPanelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addRiskToProjectPanelContent.BackColor = System.Drawing.Color.DimGray;
            this.addRiskToProjectPanelContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.addRiskToProjectPanelContent.Location = new System.Drawing.Point(0, 38);
            this.addRiskToProjectPanelContent.Margin = new System.Windows.Forms.Padding(0);
            this.addRiskToProjectPanelContent.MaximumSize = new System.Drawing.Size(750, 301);
            this.addRiskToProjectPanelContent.Name = "addRiskToProjectPanelContent";
            this.addRiskToProjectPanelContent.Size = new System.Drawing.Size(750, 301);
            this.addRiskToProjectPanelContent.TabIndex = 1;
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
            this.tableAdapterManager.Tbl_LogTableAdapter = null;
            this.tableAdapterManager.Tbl_Project_RisksTableAdapter = null;
            this.tableAdapterManager.Tbl_ProjectTableAdapter = null;
            this.tableAdapterManager.Tbl_Risk_AnalysisTableAdapter = null;
            this.tableAdapterManager.Tbl_Risk_Project_StateTableAdapter = null;
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
            // get_Risks_In_Project_GroupTableAdapter
            // 
            this.get_Risks_In_Project_GroupTableAdapter.ClearBeforeFill = true;
            // 
            // get_Risks_In_Project_TypeBindingSource
            // 
            this.get_Risks_In_Project_TypeBindingSource.DataMember = "Get_Risks_In_Project_Type";
            this.get_Risks_In_Project_TypeBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_Risks_In_Project_TypeTableAdapter
            // 
            this.get_Risks_In_Project_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // get_Risks_In_ProjectGroupTypeBindingSource
            // 
            this.get_Risks_In_ProjectGroupTypeBindingSource.DataMember = "Get_Risks_In_ProjectGroupType";
            this.get_Risks_In_ProjectGroupTypeBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_Risks_In_ProjectGroupTypeTableAdapter
            // 
            this.get_Risks_In_ProjectGroupTypeTableAdapter.ClearBeforeFill = true;
            // 
            // is_Risk_In_ProjectBindingSource
            // 
            this.is_Risk_In_ProjectBindingSource.DataMember = "Is_Risk_In_Project";
            this.is_Risk_In_ProjectBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // is_Risk_In_ProjectTableAdapter
            // 
            this.is_Risk_In_ProjectTableAdapter.ClearBeforeFill = true;
            // 
            // ARA_AddRisksToProject
            // 
            this.onRiskProjectOverviewLoad();
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 340);
            this.Controls.Add(this.addRiskToProjectPanelContent);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(750, 340);
            this.Name = "ARA_AddRisksToProject";
            this.Text = "ARA_RiskProjectOverview";
            this.Load += new System.EventHandler(this.ARA_AddRisksToProject_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Component_GroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Component_TypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Risks_In_Project_TypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Risks_In_ProjectGroupTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.is_Risk_In_ProjectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controls.ARA_TextBox arA_TextBox1;
        private System.Windows.Forms.FlowLayoutPanel addRiskToProjectPanelContent;
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private System.Windows.Forms.BindingSource tbl_Component_GroupBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Component_GroupTableAdapter tbl_Component_GroupTableAdapter;
        private LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Component_TypeTableAdapter tbl_Component_TypeTableAdapter;
        private System.Windows.Forms.BindingSource tbl_Component_TypeBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_Risks_In_Project_GroupTableAdapter get_Risks_In_Project_GroupTableAdapter;
        private System.Windows.Forms.BindingSource get_Risks_In_Project_TypeBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_Risks_In_Project_TypeTableAdapter get_Risks_In_Project_TypeTableAdapter;
        private System.Windows.Forms.BindingSource get_Risks_In_ProjectGroupTypeBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_Risks_In_ProjectGroupTypeTableAdapter get_Risks_In_ProjectGroupTypeTableAdapter;
        private System.Windows.Forms.BindingSource is_Risk_In_ProjectBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Is_Risk_In_ProjectTableAdapter is_Risk_In_ProjectTableAdapter;
    }
}