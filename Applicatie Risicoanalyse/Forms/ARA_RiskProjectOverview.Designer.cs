namespace Applicatie_Risicoanalyse.Forms
{
    partial class ARA_RiskProjectOverview
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
            this.riskProjectOverviewPanelEditProjectDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.ProjectOverviewButtonSpacer1 = new System.Windows.Forms.Panel();
            this.riskProjectOverviewPanelAddRiskToProject = new System.Windows.Forms.FlowLayoutPanel();
            this.projectOverviewButtonSpacer2 = new System.Windows.Forms.Panel();
            this.riskProjectOverviewPanelOpenRisk = new System.Windows.Forms.FlowLayoutPanel();
            this.projectOverviewButtonSpacer3 = new System.Windows.Forms.Panel();
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.get_Newest_Added_ProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_Newest_Added_ProjectTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_Newest_Added_ProjectTableAdapter();
            this.tableAdapterManager = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.riskProjectOverviewButtonEditProjectDetails = new Applicatie_Risicoanalyse.Controls.ARA_DropDownButton();
            this.riskProjectOverviewButtonAddRiskToProject = new Applicatie_Risicoanalyse.Controls.ARA_DropDownButton();
            this.riskProjectOverviewButtonOpenRisk = new Applicatie_Risicoanalyse.Controls.ARA_DropDownButton();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Newest_Added_ProjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewButtonEditProjectDetails);
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewPanelEditProjectDetails);
            this.flowLayoutPanel1.Controls.Add(this.ProjectOverviewButtonSpacer1);
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewButtonAddRiskToProject);
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewPanelAddRiskToProject);
            this.flowLayoutPanel1.Controls.Add(this.projectOverviewButtonSpacer2);
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewButtonOpenRisk);
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewPanelOpenRisk);
            this.flowLayoutPanel1.Controls.Add(this.projectOverviewButtonSpacer3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(750, 488);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // riskProjectOverviewPanelRecentProjects
            // 
            this.riskProjectOverviewPanelEditProjectDetails.Location = new System.Drawing.Point(0, 40);
            this.riskProjectOverviewPanelEditProjectDetails.Margin = new System.Windows.Forms.Padding(0);
            this.riskProjectOverviewPanelEditProjectDetails.Name = "riskProjectOverviewPanelRecentProjects";
            this.riskProjectOverviewPanelEditProjectDetails.Size = new System.Drawing.Size(750, 43);
            this.riskProjectOverviewPanelEditProjectDetails.TabIndex = 1;
            this.riskProjectOverviewPanelEditProjectDetails.Visible = false;
            // 
            // ProjectOverviewButtonSpacer1
            // 
            this.ProjectOverviewButtonSpacer1.Location = new System.Drawing.Point(0, 83);
            this.ProjectOverviewButtonSpacer1.Margin = new System.Windows.Forms.Padding(0);
            this.ProjectOverviewButtonSpacer1.MaximumSize = new System.Drawing.Size(800, 12);
            this.ProjectOverviewButtonSpacer1.Name = "ProjectOverviewButtonSpacer1";
            this.ProjectOverviewButtonSpacer1.Size = new System.Drawing.Size(750, 12);
            this.ProjectOverviewButtonSpacer1.TabIndex = 7;
            // 
            // riskProjectOverviewPanelAddRiskToProject
            // 
            this.riskProjectOverviewPanelAddRiskToProject.AutoSize = true;
            this.riskProjectOverviewPanelAddRiskToProject.Location = new System.Drawing.Point(750, 95);
            this.riskProjectOverviewPanelAddRiskToProject.Margin = new System.Windows.Forms.Padding(0);
            this.riskProjectOverviewPanelAddRiskToProject.Name = "riskProjectOverviewPanelAddRiskToProject";
            this.riskProjectOverviewPanelAddRiskToProject.Size = new System.Drawing.Size(0, 0);
            this.riskProjectOverviewPanelAddRiskToProject.TabIndex = 5;
            // 
            // projectOverviewButtonSpacer2
            // 
            this.projectOverviewButtonSpacer2.Location = new System.Drawing.Point(0, 135);
            this.projectOverviewButtonSpacer2.Margin = new System.Windows.Forms.Padding(0);
            this.projectOverviewButtonSpacer2.MaximumSize = new System.Drawing.Size(800, 12);
            this.projectOverviewButtonSpacer2.Name = "projectOverviewButtonSpacer2";
            this.projectOverviewButtonSpacer2.Size = new System.Drawing.Size(750, 12);
            this.projectOverviewButtonSpacer2.TabIndex = 8;
            // 
            // riskProjectOverviewPanelOpenRisk
            // 
            this.riskProjectOverviewPanelOpenRisk.AutoSize = true;
            this.riskProjectOverviewPanelOpenRisk.Location = new System.Drawing.Point(750, 147);
            this.riskProjectOverviewPanelOpenRisk.Margin = new System.Windows.Forms.Padding(0);
            this.riskProjectOverviewPanelOpenRisk.MaximumSize = new System.Drawing.Size(750, 500);
            this.riskProjectOverviewPanelOpenRisk.Name = "riskProjectOverviewPanelOpenRisk";
            this.riskProjectOverviewPanelOpenRisk.Size = new System.Drawing.Size(0, 0);
            this.riskProjectOverviewPanelOpenRisk.TabIndex = 2;
            // 
            // projectOverviewButtonSpacer3
            // 
            this.projectOverviewButtonSpacer3.Location = new System.Drawing.Point(0, 187);
            this.projectOverviewButtonSpacer3.Margin = new System.Windows.Forms.Padding(0);
            this.projectOverviewButtonSpacer3.MaximumSize = new System.Drawing.Size(800, 12);
            this.projectOverviewButtonSpacer3.Name = "projectOverviewButtonSpacer3";
            this.projectOverviewButtonSpacer3.Size = new System.Drawing.Size(750, 12);
            this.projectOverviewButtonSpacer3.TabIndex = 9;
            // 
            // lG_Analysis_DatabaseDataSet
            // 
            this.lG_Analysis_DatabaseDataSet.DataSetName = "LG_Analysis_DatabaseDataSet";
            this.lG_Analysis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // get_Newest_Added_ProjectBindingSource
            // 
            this.get_Newest_Added_ProjectBindingSource.DataMember = "Get_Newest_Added_Project";
            this.get_Newest_Added_ProjectBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_Newest_Added_ProjectTableAdapter
            // 
            this.get_Newest_Added_ProjectTableAdapter.ClearBeforeFill = true;
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
            // riskProjectOverviewButtonEditProjectDetails
            // 
            this.riskProjectOverviewButtonEditProjectDetails.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.riskProjectOverviewButtonEditProjectDetails.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.riskProjectOverviewButtonEditProjectDetails.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.riskProjectOverviewButtonEditProjectDetails.Location = new System.Drawing.Point(0, 0);
            this.riskProjectOverviewButtonEditProjectDetails.Margin = new System.Windows.Forms.Padding(0);
            this.riskProjectOverviewButtonEditProjectDetails.MaximumSize = new System.Drawing.Size(750, 40);
            this.riskProjectOverviewButtonEditProjectDetails.Name = "riskProjectOverviewButtonEditProjectDetails";
            this.riskProjectOverviewButtonEditProjectDetails.PaddingFirstTriangle = 250;
            this.riskProjectOverviewButtonEditProjectDetails.PaddingSecondTriangle = 700;
            this.riskProjectOverviewButtonEditProjectDetails.Selected = false;
            this.riskProjectOverviewButtonEditProjectDetails.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.riskProjectOverviewButtonEditProjectDetails.SelectedTextColor = System.Drawing.Color.White;
            this.riskProjectOverviewButtonEditProjectDetails.Size = new System.Drawing.Size(750, 40);
            this.riskProjectOverviewButtonEditProjectDetails.TabIndex = 0;
            this.riskProjectOverviewButtonEditProjectDetails.Text = "Edit project details";
            this.riskProjectOverviewButtonEditProjectDetails.TextColor = System.Drawing.Color.White;
            this.riskProjectOverviewButtonEditProjectDetails.TriangleSize = 20;
            this.riskProjectOverviewButtonEditProjectDetails.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // riskProjectOverviewButtonAddRiskToProject
            // 
            this.riskProjectOverviewButtonAddRiskToProject.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.riskProjectOverviewButtonAddRiskToProject.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.riskProjectOverviewButtonAddRiskToProject.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.riskProjectOverviewButtonAddRiskToProject.Location = new System.Drawing.Point(0, 95);
            this.riskProjectOverviewButtonAddRiskToProject.Margin = new System.Windows.Forms.Padding(0);
            this.riskProjectOverviewButtonAddRiskToProject.MaximumSize = new System.Drawing.Size(750, 40);
            this.riskProjectOverviewButtonAddRiskToProject.Name = "riskProjectOverviewButtonAddRiskToProject";
            this.riskProjectOverviewButtonAddRiskToProject.PaddingFirstTriangle = 250;
            this.riskProjectOverviewButtonAddRiskToProject.PaddingSecondTriangle = 700;
            this.riskProjectOverviewButtonAddRiskToProject.Selected = false;
            this.riskProjectOverviewButtonAddRiskToProject.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.riskProjectOverviewButtonAddRiskToProject.SelectedTextColor = System.Drawing.Color.White;
            this.riskProjectOverviewButtonAddRiskToProject.Size = new System.Drawing.Size(750, 40);
            this.riskProjectOverviewButtonAddRiskToProject.TabIndex = 2;
            this.riskProjectOverviewButtonAddRiskToProject.Text = "Add risks to project";
            this.riskProjectOverviewButtonAddRiskToProject.TextColor = System.Drawing.Color.White;
            this.riskProjectOverviewButtonAddRiskToProject.TriangleSize = 20;
            this.riskProjectOverviewButtonAddRiskToProject.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // riskProjectOverviewButtonOpenRisk
            // 
            this.riskProjectOverviewButtonOpenRisk.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.riskProjectOverviewButtonOpenRisk.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.riskProjectOverviewButtonOpenRisk.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.riskProjectOverviewButtonOpenRisk.Location = new System.Drawing.Point(0, 147);
            this.riskProjectOverviewButtonOpenRisk.Margin = new System.Windows.Forms.Padding(0);
            this.riskProjectOverviewButtonOpenRisk.MaximumSize = new System.Drawing.Size(750, 40);
            this.riskProjectOverviewButtonOpenRisk.Name = "riskProjectOverviewButtonOpenRisk";
            this.riskProjectOverviewButtonOpenRisk.PaddingFirstTriangle = 250;
            this.riskProjectOverviewButtonOpenRisk.PaddingSecondTriangle = 700;
            this.riskProjectOverviewButtonOpenRisk.Selected = false;
            this.riskProjectOverviewButtonOpenRisk.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.riskProjectOverviewButtonOpenRisk.SelectedTextColor = System.Drawing.Color.White;
            this.riskProjectOverviewButtonOpenRisk.Size = new System.Drawing.Size(750, 40);
            this.riskProjectOverviewButtonOpenRisk.TabIndex = 3;
            this.riskProjectOverviewButtonOpenRisk.Text = "Edit risks";
            this.riskProjectOverviewButtonOpenRisk.TextColor = System.Drawing.Color.White;
            this.riskProjectOverviewButtonOpenRisk.TriangleSize = 20;
            this.riskProjectOverviewButtonOpenRisk.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ARA_RiskProjectOverview
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
            this.Name = "ARA_RiskProjectOverview";
            this.Text = "ProjectOverview";
            this.Load += new System.EventHandler(this.onProjectOverviewLoad);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Newest_Added_ProjectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controls.ARA_DropDownButton riskProjectOverviewButtonEditProjectDetails;
        private System.Windows.Forms.FlowLayoutPanel riskProjectOverviewPanelEditProjectDetails;
        private Controls.ARA_DropDownButton riskProjectOverviewButtonAddRiskToProject;
        private System.Windows.Forms.FlowLayoutPanel riskProjectOverviewPanelAddRiskToProject;
        private Controls.ARA_DropDownButton riskProjectOverviewButtonOpenRisk;
        private System.Windows.Forms.FlowLayoutPanel riskProjectOverviewPanelOpenRisk;
        private System.Windows.Forms.Panel ProjectOverviewButtonSpacer1;
        private System.Windows.Forms.Panel projectOverviewButtonSpacer2;
        private System.Windows.Forms.Panel projectOverviewButtonSpacer3;
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private System.Windows.Forms.BindingSource get_Newest_Added_ProjectBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_Newest_Added_ProjectTableAdapter get_Newest_Added_ProjectTableAdapter;
        private LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}