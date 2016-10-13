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
            this.riskProjectOverviewButtonRecentProjects = new Applicatie_Risicoanalyse.Controls.ARA_DropDownButton();
            this.riskProjectOverviewPanelRecentProjects = new System.Windows.Forms.FlowLayoutPanel();
            this.ProjectOverviewButtonSpacer1 = new System.Windows.Forms.Panel();
            this.riskProjectOverviewButtonOpenProject = new Applicatie_Risicoanalyse.Controls.ARA_DropDownButton();
            this.riskProjectOverviewPanelOpenProject = new System.Windows.Forms.FlowLayoutPanel();
            this.projectOverviewButtonSpacer2 = new System.Windows.Forms.Panel();
            this.riskProjectOverviewButtonCreateProject = new Applicatie_Risicoanalyse.Controls.ARA_DropDownButton();
            this.riskProjectOverviewPanelCreateProject = new System.Windows.Forms.FlowLayoutPanel();
            this.projectOverviewButtonSpacer3 = new System.Windows.Forms.Panel();
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.get_Newest_Added_ProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_Newest_Added_ProjectTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_Newest_Added_ProjectTableAdapter();
            this.tableAdapterManager = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Newest_Added_ProjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewButtonRecentProjects);
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewPanelRecentProjects);
            this.flowLayoutPanel1.Controls.Add(this.ProjectOverviewButtonSpacer1);
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewButtonOpenProject);
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewPanelOpenProject);
            this.flowLayoutPanel1.Controls.Add(this.projectOverviewButtonSpacer2);
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewButtonCreateProject);
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewPanelCreateProject);
            this.flowLayoutPanel1.Controls.Add(this.projectOverviewButtonSpacer3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(750, 488);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // riskProjectOverviewButtonRecentProjects
            // 
            this.riskProjectOverviewButtonRecentProjects.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.riskProjectOverviewButtonRecentProjects.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.riskProjectOverviewButtonRecentProjects.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.riskProjectOverviewButtonRecentProjects.Location = new System.Drawing.Point(0, 0);
            this.riskProjectOverviewButtonRecentProjects.Margin = new System.Windows.Forms.Padding(0);
            this.riskProjectOverviewButtonRecentProjects.MaximumSize = new System.Drawing.Size(750, 40);
            this.riskProjectOverviewButtonRecentProjects.Name = "riskProjectOverviewButtonRecentProjects";
            this.riskProjectOverviewButtonRecentProjects.PaddingFirstTriangle = 250;
            this.riskProjectOverviewButtonRecentProjects.PaddingSecondTriangle = 700;
            this.riskProjectOverviewButtonRecentProjects.Selected = false;
            this.riskProjectOverviewButtonRecentProjects.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.riskProjectOverviewButtonRecentProjects.Size = new System.Drawing.Size(750, 40);
            this.riskProjectOverviewButtonRecentProjects.TabIndex = 0;
            this.riskProjectOverviewButtonRecentProjects.Text = "Edit project details";
            this.riskProjectOverviewButtonRecentProjects.TextColor = System.Drawing.Color.White;
            this.riskProjectOverviewButtonRecentProjects.TriangleSize = 20;
            this.riskProjectOverviewButtonRecentProjects.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // riskProjectOverviewPanelRecentProjects
            // 
            this.riskProjectOverviewPanelRecentProjects.Location = new System.Drawing.Point(0, 40);
            this.riskProjectOverviewPanelRecentProjects.Margin = new System.Windows.Forms.Padding(0);
            this.riskProjectOverviewPanelRecentProjects.Name = "riskProjectOverviewPanelRecentProjects";
            this.riskProjectOverviewPanelRecentProjects.Size = new System.Drawing.Size(750, 43);
            this.riskProjectOverviewPanelRecentProjects.TabIndex = 1;
            this.riskProjectOverviewPanelRecentProjects.Visible = false;
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
            // riskProjectOverviewButtonOpenProject
            // 
            this.riskProjectOverviewButtonOpenProject.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.riskProjectOverviewButtonOpenProject.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.riskProjectOverviewButtonOpenProject.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.riskProjectOverviewButtonOpenProject.Location = new System.Drawing.Point(0, 95);
            this.riskProjectOverviewButtonOpenProject.Margin = new System.Windows.Forms.Padding(0);
            this.riskProjectOverviewButtonOpenProject.MaximumSize = new System.Drawing.Size(750, 40);
            this.riskProjectOverviewButtonOpenProject.Name = "riskProjectOverviewButtonOpenProject";
            this.riskProjectOverviewButtonOpenProject.PaddingFirstTriangle = 250;
            this.riskProjectOverviewButtonOpenProject.PaddingSecondTriangle = 700;
            this.riskProjectOverviewButtonOpenProject.Selected = false;
            this.riskProjectOverviewButtonOpenProject.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.riskProjectOverviewButtonOpenProject.Size = new System.Drawing.Size(750, 40);
            this.riskProjectOverviewButtonOpenProject.TabIndex = 2;
            this.riskProjectOverviewButtonOpenProject.Text = "Add risks to project";
            this.riskProjectOverviewButtonOpenProject.TextColor = System.Drawing.Color.White;
            this.riskProjectOverviewButtonOpenProject.TriangleSize = 20;
            this.riskProjectOverviewButtonOpenProject.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // riskProjectOverviewPanelOpenProject
            // 
            this.riskProjectOverviewPanelOpenProject.Location = new System.Drawing.Point(0, 135);
            this.riskProjectOverviewPanelOpenProject.Margin = new System.Windows.Forms.Padding(0);
            this.riskProjectOverviewPanelOpenProject.Name = "riskProjectOverviewPanelOpenProject";
            this.riskProjectOverviewPanelOpenProject.Size = new System.Drawing.Size(750, 340);
            this.riskProjectOverviewPanelOpenProject.TabIndex = 5;
            this.riskProjectOverviewPanelOpenProject.Visible = true;

            this.addFormToPanel(this.riskProjectOverviewPanelOpenProject, new ARA_AddRisksToProject(1));
            // 
            // projectOverviewButtonSpacer2
            // 
            this.projectOverviewButtonSpacer2.Location = new System.Drawing.Point(0, 475);
            this.projectOverviewButtonSpacer2.Margin = new System.Windows.Forms.Padding(0);
            this.projectOverviewButtonSpacer2.MaximumSize = new System.Drawing.Size(800, 12);
            this.projectOverviewButtonSpacer2.Name = "projectOverviewButtonSpacer2";
            this.projectOverviewButtonSpacer2.Size = new System.Drawing.Size(750, 12);
            this.projectOverviewButtonSpacer2.TabIndex = 8;
            // 
            // riskProjectOverviewButtonCreateProject
            // 
            this.riskProjectOverviewButtonCreateProject.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.riskProjectOverviewButtonCreateProject.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.riskProjectOverviewButtonCreateProject.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.riskProjectOverviewButtonCreateProject.Location = new System.Drawing.Point(0, 487);
            this.riskProjectOverviewButtonCreateProject.Margin = new System.Windows.Forms.Padding(0);
            this.riskProjectOverviewButtonCreateProject.MaximumSize = new System.Drawing.Size(750, 40);
            this.riskProjectOverviewButtonCreateProject.Name = "riskProjectOverviewButtonCreateProject";
            this.riskProjectOverviewButtonCreateProject.PaddingFirstTriangle = 250;
            this.riskProjectOverviewButtonCreateProject.PaddingSecondTriangle = 700;
            this.riskProjectOverviewButtonCreateProject.Selected = false;
            this.riskProjectOverviewButtonCreateProject.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.riskProjectOverviewButtonCreateProject.Size = new System.Drawing.Size(750, 40);
            this.riskProjectOverviewButtonCreateProject.TabIndex = 3;
            this.riskProjectOverviewButtonCreateProject.Text = "Create new risk";
            this.riskProjectOverviewButtonCreateProject.TextColor = System.Drawing.Color.White;
            this.riskProjectOverviewButtonCreateProject.TriangleSize = 20;
            this.riskProjectOverviewButtonCreateProject.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // riskProjectOverviewPanelCreateProject
            // 
            this.riskProjectOverviewPanelCreateProject.Location = new System.Drawing.Point(0, 527);
            this.riskProjectOverviewPanelCreateProject.Margin = new System.Windows.Forms.Padding(0);
            this.riskProjectOverviewPanelCreateProject.MaximumSize = new System.Drawing.Size(750, 190);
            this.riskProjectOverviewPanelCreateProject.Name = "riskProjectOverviewPanelCreateProject";
            this.riskProjectOverviewPanelCreateProject.Size = new System.Drawing.Size(750, 47);
            this.riskProjectOverviewPanelCreateProject.TabIndex = 2;
            this.riskProjectOverviewPanelCreateProject.Visible = true;
            // 
            // projectOverviewButtonSpacer3
            // 
            this.projectOverviewButtonSpacer3.Location = new System.Drawing.Point(0, 574);
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
            this.get_Newest_Added_ProjectBindingSource.Position = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Newest_Added_ProjectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controls.ARA_DropDownButton riskProjectOverviewButtonRecentProjects;
        private System.Windows.Forms.FlowLayoutPanel riskProjectOverviewPanelRecentProjects;
        private Controls.ARA_DropDownButton riskProjectOverviewButtonOpenProject;
        private System.Windows.Forms.FlowLayoutPanel riskProjectOverviewPanelOpenProject;
        private Controls.ARA_DropDownButton riskProjectOverviewButtonCreateProject;
        private System.Windows.Forms.FlowLayoutPanel riskProjectOverviewPanelCreateProject;
        private System.Windows.Forms.Panel ProjectOverviewButtonSpacer1;
        private System.Windows.Forms.Panel projectOverviewButtonSpacer2;
        private System.Windows.Forms.Panel projectOverviewButtonSpacer3;
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private System.Windows.Forms.BindingSource get_Newest_Added_ProjectBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_Newest_Added_ProjectTableAdapter get_Newest_Added_ProjectTableAdapter;
        private LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}