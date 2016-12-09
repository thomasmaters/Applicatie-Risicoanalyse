using Applicatie_Risicoanalyse.Globals;

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
            this.riskProjectOverviewButtonEditProjectDetails = new Applicatie_Risicoanalyse.Controls.ARA_DropDownButton();
            this.riskProjectOverviewPanelEditProjectDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.ProjectOverviewButtonSpacer1 = new System.Windows.Forms.Panel();
            this.riskProjectOverviewButtonAddRiskToProject = new Applicatie_Risicoanalyse.Controls.ARA_DropDownButton();
            this.riskProjectOverviewPanelAddRiskToProject = new System.Windows.Forms.FlowLayoutPanel();
            this.projectOverviewButtonSpacer2 = new System.Windows.Forms.Panel();
            this.riskProjectOverviewButtonOpenRisk = new Applicatie_Risicoanalyse.Controls.ARA_DropDownButton();
            this.riskProjectOverviewPanelOpenRisk = new System.Windows.Forms.FlowLayoutPanel();
            this.projectOverviewButtonSpacer3 = new System.Windows.Forms.Panel();
            this.riskProjectOverviewButtonGenerateReports = new Applicatie_Risicoanalyse.Controls.ARA_DropDownButton();
            this.riskProjectOverviewPanelGenerateReports = new System.Windows.Forms.FlowLayoutPanel();
            this.panel = new System.Windows.Forms.Panel();
            this.riskProjectOverviewButtonCopyRisk = new Applicatie_Risicoanalyse.Controls.ARA_DropDownButton();
            this.riskProjectOverviewPanelCopyRisk = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.riskProjectOverviewButtonMarkReview = new Applicatie_Risicoanalyse.Controls.ARA_Button();
            this.riskProjectOverviewButtonMarkDoneReview = new Applicatie_Risicoanalyse.Controls.ARA_Button();
            this.riskProjectOverviewButtonMarkClose = new Applicatie_Risicoanalyse.Controls.ARA_Button();
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.get_Newest_Added_ProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_Newest_Added_ProjectTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_Newest_Added_ProjectTableAdapter();
            this.tableAdapterManager = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.tbl_Risk_AnalysisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Risk_AnalysisTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_AnalysisTableAdapter();
            this.queriesTableAdapter1 = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.QueriesTableAdapter();
            this.is_ProjectReview_AcceptedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.is_ProjectReview_AcceptedTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Is_ProjectReview_AcceptedTableAdapter();
            this.tbl_ProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ProjectTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_ProjectTableAdapter();
            this.get_All_RiskProject_InfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_All_RiskProject_InfoTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_All_RiskProject_InfoTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Newest_Added_ProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Risk_AnalysisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.is_ProjectReview_AcceptedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_All_RiskProject_InfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewButtonEditProjectDetails);
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewPanelEditProjectDetails);
            this.flowLayoutPanel1.Controls.Add(this.ProjectOverviewButtonSpacer1);
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewButtonAddRiskToProject);
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewPanelAddRiskToProject);
            this.flowLayoutPanel1.Controls.Add(this.projectOverviewButtonSpacer2);
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewButtonOpenRisk);
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewPanelOpenRisk);
            this.flowLayoutPanel1.Controls.Add(this.projectOverviewButtonSpacer3);
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewButtonGenerateReports);
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewPanelGenerateReports);
            this.flowLayoutPanel1.Controls.Add(this.panel);
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewButtonCopyRisk);
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewPanelCopyRisk);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewButtonMarkReview);
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewButtonMarkDoneReview);
            this.flowLayoutPanel1.Controls.Add(this.riskProjectOverviewButtonMarkClose);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(750, 488);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // riskProjectOverviewButtonEditProjectDetails
            // 
            this.riskProjectOverviewButtonEditProjectDetails.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.riskProjectOverviewButtonEditProjectDetails.CanButtonBeToggled = true;
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
            // riskProjectOverviewPanelEditProjectDetails
            // 
            this.riskProjectOverviewPanelEditProjectDetails.AutoSize = true;
            this.riskProjectOverviewPanelEditProjectDetails.Location = new System.Drawing.Point(750, 0);
            this.riskProjectOverviewPanelEditProjectDetails.Margin = new System.Windows.Forms.Padding(0);
            this.riskProjectOverviewPanelEditProjectDetails.Name = "riskProjectOverviewPanelEditProjectDetails";
            this.riskProjectOverviewPanelEditProjectDetails.Size = new System.Drawing.Size(0, 0);
            this.riskProjectOverviewPanelEditProjectDetails.TabIndex = 1;
            this.riskProjectOverviewPanelEditProjectDetails.Visible = false;
            // 
            // ProjectOverviewButtonSpacer1
            // 
            this.ProjectOverviewButtonSpacer1.Location = new System.Drawing.Point(0, 40);
            this.ProjectOverviewButtonSpacer1.Margin = new System.Windows.Forms.Padding(0);
            this.ProjectOverviewButtonSpacer1.MaximumSize = new System.Drawing.Size(800, 12);
            this.ProjectOverviewButtonSpacer1.Name = "ProjectOverviewButtonSpacer1";
            this.ProjectOverviewButtonSpacer1.Size = new System.Drawing.Size(750, 12);
            this.ProjectOverviewButtonSpacer1.TabIndex = 7;
            // 
            // riskProjectOverviewButtonAddRiskToProject
            // 
            this.riskProjectOverviewButtonAddRiskToProject.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.riskProjectOverviewButtonAddRiskToProject.CanButtonBeToggled = true;
            this.riskProjectOverviewButtonAddRiskToProject.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.riskProjectOverviewButtonAddRiskToProject.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.riskProjectOverviewButtonAddRiskToProject.Location = new System.Drawing.Point(0, 52);
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
            // riskProjectOverviewPanelAddRiskToProject
            // 
            this.riskProjectOverviewPanelAddRiskToProject.AutoSize = true;
            this.riskProjectOverviewPanelAddRiskToProject.Location = new System.Drawing.Point(750, 52);
            this.riskProjectOverviewPanelAddRiskToProject.Margin = new System.Windows.Forms.Padding(0);
            this.riskProjectOverviewPanelAddRiskToProject.Name = "riskProjectOverviewPanelAddRiskToProject";
            this.riskProjectOverviewPanelAddRiskToProject.Size = new System.Drawing.Size(0, 0);
            this.riskProjectOverviewPanelAddRiskToProject.TabIndex = 5;
            // 
            // projectOverviewButtonSpacer2
            // 
            this.projectOverviewButtonSpacer2.Location = new System.Drawing.Point(0, 92);
            this.projectOverviewButtonSpacer2.Margin = new System.Windows.Forms.Padding(0);
            this.projectOverviewButtonSpacer2.MaximumSize = new System.Drawing.Size(800, 12);
            this.projectOverviewButtonSpacer2.Name = "projectOverviewButtonSpacer2";
            this.projectOverviewButtonSpacer2.Size = new System.Drawing.Size(750, 12);
            this.projectOverviewButtonSpacer2.TabIndex = 8;
            // 
            // riskProjectOverviewButtonOpenRisk
            // 
            this.riskProjectOverviewButtonOpenRisk.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.riskProjectOverviewButtonOpenRisk.CanButtonBeToggled = true;
            this.riskProjectOverviewButtonOpenRisk.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.riskProjectOverviewButtonOpenRisk.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.riskProjectOverviewButtonOpenRisk.Location = new System.Drawing.Point(0, 104);
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
            // riskProjectOverviewPanelOpenRisk
            // 
            this.riskProjectOverviewPanelOpenRisk.AutoSize = true;
            this.riskProjectOverviewPanelOpenRisk.Location = new System.Drawing.Point(750, 104);
            this.riskProjectOverviewPanelOpenRisk.Margin = new System.Windows.Forms.Padding(0);
            this.riskProjectOverviewPanelOpenRisk.MaximumSize = new System.Drawing.Size(750, 500);
            this.riskProjectOverviewPanelOpenRisk.Name = "riskProjectOverviewPanelOpenRisk";
            this.riskProjectOverviewPanelOpenRisk.Size = new System.Drawing.Size(0, 0);
            this.riskProjectOverviewPanelOpenRisk.TabIndex = 2;
            // 
            // projectOverviewButtonSpacer3
            // 
            this.projectOverviewButtonSpacer3.Location = new System.Drawing.Point(0, 144);
            this.projectOverviewButtonSpacer3.Margin = new System.Windows.Forms.Padding(0);
            this.projectOverviewButtonSpacer3.MaximumSize = new System.Drawing.Size(800, 12);
            this.projectOverviewButtonSpacer3.Name = "projectOverviewButtonSpacer3";
            this.projectOverviewButtonSpacer3.Size = new System.Drawing.Size(750, 12);
            this.projectOverviewButtonSpacer3.TabIndex = 9;
            // 
            // riskProjectOverviewButtonGenerateReports
            // 
            this.riskProjectOverviewButtonGenerateReports.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.riskProjectOverviewButtonGenerateReports.CanButtonBeToggled = true;
            this.riskProjectOverviewButtonGenerateReports.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.riskProjectOverviewButtonGenerateReports.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.riskProjectOverviewButtonGenerateReports.Location = new System.Drawing.Point(0, 156);
            this.riskProjectOverviewButtonGenerateReports.Margin = new System.Windows.Forms.Padding(0);
            this.riskProjectOverviewButtonGenerateReports.MaximumSize = new System.Drawing.Size(750, 40);
            this.riskProjectOverviewButtonGenerateReports.Name = "riskProjectOverviewButtonGenerateReports";
            this.riskProjectOverviewButtonGenerateReports.PaddingFirstTriangle = 250;
            this.riskProjectOverviewButtonGenerateReports.PaddingSecondTriangle = 700;
            this.riskProjectOverviewButtonGenerateReports.Selected = false;
            this.riskProjectOverviewButtonGenerateReports.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.riskProjectOverviewButtonGenerateReports.SelectedTextColor = System.Drawing.Color.White;
            this.riskProjectOverviewButtonGenerateReports.Size = new System.Drawing.Size(750, 40);
            this.riskProjectOverviewButtonGenerateReports.TabIndex = 10;
            this.riskProjectOverviewButtonGenerateReports.Text = "Generate Reports";
            this.riskProjectOverviewButtonGenerateReports.TextColor = System.Drawing.Color.White;
            this.riskProjectOverviewButtonGenerateReports.TriangleSize = 20;
            this.riskProjectOverviewButtonGenerateReports.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // riskProjectOverviewPanelGenerateReports
            // 
            this.riskProjectOverviewPanelGenerateReports.AutoSize = true;
            this.riskProjectOverviewPanelGenerateReports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.riskProjectOverviewPanelGenerateReports.Location = new System.Drawing.Point(0, 196);
            this.riskProjectOverviewPanelGenerateReports.Margin = new System.Windows.Forms.Padding(0);
            this.riskProjectOverviewPanelGenerateReports.Name = "riskProjectOverviewPanelGenerateReports";
            this.riskProjectOverviewPanelGenerateReports.Size = new System.Drawing.Size(2, 2);
            this.riskProjectOverviewPanelGenerateReports.TabIndex = 12;
            this.riskProjectOverviewPanelGenerateReports.Visible = false;
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(0, 198);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.MaximumSize = new System.Drawing.Size(800, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(750, 12);
            this.panel.TabIndex = 11;
            // 
            // riskProjectOverviewButtonCopyRisk
            // 
            this.riskProjectOverviewButtonCopyRisk.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.riskProjectOverviewButtonCopyRisk.CanButtonBeToggled = true;
            this.riskProjectOverviewButtonCopyRisk.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.riskProjectOverviewButtonCopyRisk.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.riskProjectOverviewButtonCopyRisk.Location = new System.Drawing.Point(0, 210);
            this.riskProjectOverviewButtonCopyRisk.Margin = new System.Windows.Forms.Padding(0);
            this.riskProjectOverviewButtonCopyRisk.MaximumSize = new System.Drawing.Size(750, 40);
            this.riskProjectOverviewButtonCopyRisk.Name = "riskProjectOverviewButtonCopyRisk";
            this.riskProjectOverviewButtonCopyRisk.PaddingFirstTriangle = 300;
            this.riskProjectOverviewButtonCopyRisk.PaddingSecondTriangle = 700;
            this.riskProjectOverviewButtonCopyRisk.Selected = false;
            this.riskProjectOverviewButtonCopyRisk.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.riskProjectOverviewButtonCopyRisk.SelectedTextColor = System.Drawing.Color.White;
            this.riskProjectOverviewButtonCopyRisk.Size = new System.Drawing.Size(750, 40);
            this.riskProjectOverviewButtonCopyRisk.TabIndex = 16;
            this.riskProjectOverviewButtonCopyRisk.Text = "Add risks from other project";
            this.riskProjectOverviewButtonCopyRisk.TextColor = System.Drawing.Color.White;
            this.riskProjectOverviewButtonCopyRisk.TriangleSize = 20;
            this.riskProjectOverviewButtonCopyRisk.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // riskProjectOverviewPanelCopyRisk
            // 
            this.riskProjectOverviewPanelCopyRisk.AutoSize = true;
            this.riskProjectOverviewPanelCopyRisk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.riskProjectOverviewPanelCopyRisk.Location = new System.Drawing.Point(0, 250);
            this.riskProjectOverviewPanelCopyRisk.Margin = new System.Windows.Forms.Padding(0);
            this.riskProjectOverviewPanelCopyRisk.Name = "riskProjectOverviewPanelCopyRisk";
            this.riskProjectOverviewPanelCopyRisk.Size = new System.Drawing.Size(2, 2);
            this.riskProjectOverviewPanelCopyRisk.TabIndex = 17;
            this.riskProjectOverviewPanelCopyRisk.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 252);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(800, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 12);
            this.panel1.TabIndex = 18;
            // 
            // riskProjectOverviewButtonMarkReview
            // 
            this.riskProjectOverviewButtonMarkReview.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.riskProjectOverviewButtonMarkReview.CanButtonBeToggled = false;
            this.riskProjectOverviewButtonMarkReview.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.riskProjectOverviewButtonMarkReview.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.riskProjectOverviewButtonMarkReview.Location = new System.Drawing.Point(0, 264);
            this.riskProjectOverviewButtonMarkReview.Margin = new System.Windows.Forms.Padding(0);
            this.riskProjectOverviewButtonMarkReview.Name = "riskProjectOverviewButtonMarkReview";
            this.riskProjectOverviewButtonMarkReview.Selected = false;
            this.riskProjectOverviewButtonMarkReview.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.riskProjectOverviewButtonMarkReview.SelectedTextColor = System.Drawing.Color.White;
            this.riskProjectOverviewButtonMarkReview.Size = new System.Drawing.Size(750, 40);
            this.riskProjectOverviewButtonMarkReview.TabIndex = 13;
            this.riskProjectOverviewButtonMarkReview.Text = "Mark project for review.";
            this.riskProjectOverviewButtonMarkReview.TextColor = System.Drawing.Color.White;
            this.riskProjectOverviewButtonMarkReview.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.riskProjectOverviewButtonMarkReview.Click += new System.EventHandler(this.riskProjectOverviewButtonMarkReview_Click);
            // 
            // riskProjectOverviewButtonMarkDoneReview
            // 
            this.riskProjectOverviewButtonMarkDoneReview.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.riskProjectOverviewButtonMarkDoneReview.CanButtonBeToggled = false;
            this.riskProjectOverviewButtonMarkDoneReview.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.riskProjectOverviewButtonMarkDoneReview.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.riskProjectOverviewButtonMarkDoneReview.Location = new System.Drawing.Point(0, 304);
            this.riskProjectOverviewButtonMarkDoneReview.Margin = new System.Windows.Forms.Padding(0);
            this.riskProjectOverviewButtonMarkDoneReview.Name = "riskProjectOverviewButtonMarkDoneReview";
            this.riskProjectOverviewButtonMarkDoneReview.Selected = false;
            this.riskProjectOverviewButtonMarkDoneReview.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.riskProjectOverviewButtonMarkDoneReview.SelectedTextColor = System.Drawing.Color.White;
            this.riskProjectOverviewButtonMarkDoneReview.Size = new System.Drawing.Size(750, 40);
            this.riskProjectOverviewButtonMarkDoneReview.TabIndex = 14;
            this.riskProjectOverviewButtonMarkDoneReview.Text = "I\'m done reviewing this project.";
            this.riskProjectOverviewButtonMarkDoneReview.TextColor = System.Drawing.Color.White;
            this.riskProjectOverviewButtonMarkDoneReview.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.riskProjectOverviewButtonMarkDoneReview.Click += new System.EventHandler(this.riskProjectOverviewButtonMarkDoneReview_Click);
            // 
            // riskProjectOverviewButtonMarkClose
            // 
            this.riskProjectOverviewButtonMarkClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.riskProjectOverviewButtonMarkClose.CanButtonBeToggled = false;
            this.riskProjectOverviewButtonMarkClose.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.riskProjectOverviewButtonMarkClose.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.riskProjectOverviewButtonMarkClose.Location = new System.Drawing.Point(0, 344);
            this.riskProjectOverviewButtonMarkClose.Margin = new System.Windows.Forms.Padding(0);
            this.riskProjectOverviewButtonMarkClose.Name = "riskProjectOverviewButtonMarkClose";
            this.riskProjectOverviewButtonMarkClose.Selected = false;
            this.riskProjectOverviewButtonMarkClose.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.riskProjectOverviewButtonMarkClose.SelectedTextColor = System.Drawing.Color.White;
            this.riskProjectOverviewButtonMarkClose.Size = new System.Drawing.Size(750, 40);
            this.riskProjectOverviewButtonMarkClose.TabIndex = 15;
            this.riskProjectOverviewButtonMarkClose.Text = "Close Project";
            this.riskProjectOverviewButtonMarkClose.TextColor = System.Drawing.Color.White;
            this.riskProjectOverviewButtonMarkClose.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.riskProjectOverviewButtonMarkClose.Click += new System.EventHandler(this.riskProjectOverviewButtonMarkClose_Click);
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
            this.tableAdapterManager.Tbl_RiskReductionMeasuresTableAdapter = null;
            this.tableAdapterManager.Tbl_Risks_In_ProjectTableAdapter = null;
            this.tableAdapterManager.Tbl_RiskTableAdapter = null;
            this.tableAdapterManager.Tbl_User_PermissionsTableAdapter = null;
            this.tableAdapterManager.Tbl_UserTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_Risk_AnalysisBindingSource
            // 
            this.tbl_Risk_AnalysisBindingSource.DataMember = "Tbl_Risk_Analysis";
            this.tbl_Risk_AnalysisBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // tbl_Risk_AnalysisTableAdapter
            // 
            this.tbl_Risk_AnalysisTableAdapter.ClearBeforeFill = true;
            // 
            // is_ProjectReview_AcceptedBindingSource
            // 
            this.is_ProjectReview_AcceptedBindingSource.DataMember = "Is_ProjectReview_Accepted";
            this.is_ProjectReview_AcceptedBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // is_ProjectReview_AcceptedTableAdapter
            // 
            this.is_ProjectReview_AcceptedTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_ProjectBindingSource
            // 
            this.tbl_ProjectBindingSource.DataMember = "Tbl_Project";
            this.tbl_ProjectBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // tbl_ProjectTableAdapter
            // 
            this.tbl_ProjectTableAdapter.ClearBeforeFill = true;
            // 
            // get_All_RiskProject_InfoBindingSource
            // 
            this.get_All_RiskProject_InfoBindingSource.DataMember = "Get_All_RiskProject_Info";
            this.get_All_RiskProject_InfoBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // get_All_RiskProject_InfoTableAdapter
            // 
            this.get_All_RiskProject_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // ARA_RiskProjectOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font(ARA_Globals.ARA_Font, 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(750, 488);
            this.Name = "ARA_RiskProjectOverview";
            this.Text = "ProjectOverview";
            this.Load += new System.EventHandler(this.onProjectOverviewLoad);
            this.Shown += new System.EventHandler(this.ARA_RiskProjectOverview_Shown);
            this.VisibleChanged += new System.EventHandler(this.ARA_RiskProjectOverview_VisibleChanged);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_Newest_Added_ProjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Risk_AnalysisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.is_ProjectReview_AcceptedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_All_RiskProject_InfoBindingSource)).EndInit();
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
        private Controls.ARA_DropDownButton riskProjectOverviewButtonGenerateReports;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.FlowLayoutPanel riskProjectOverviewPanelGenerateReports;
        private System.Windows.Forms.BindingSource tbl_Risk_AnalysisBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_AnalysisTableAdapter tbl_Risk_AnalysisTableAdapter;
        private Controls.ARA_Button riskProjectOverviewButtonMarkReview;
        private Controls.ARA_Button riskProjectOverviewButtonMarkDoneReview;
        private Controls.ARA_Button riskProjectOverviewButtonMarkClose;
        private LG_Analysis_DatabaseDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.BindingSource is_ProjectReview_AcceptedBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Is_ProjectReview_AcceptedTableAdapter is_ProjectReview_AcceptedTableAdapter;
        private System.Windows.Forms.BindingSource tbl_ProjectBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_ProjectTableAdapter tbl_ProjectTableAdapter;
        private Controls.ARA_DropDownButton riskProjectOverviewButtonCopyRisk;
        private System.Windows.Forms.FlowLayoutPanel riskProjectOverviewPanelCopyRisk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource get_All_RiskProject_InfoBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_All_RiskProject_InfoTableAdapter get_All_RiskProject_InfoTableAdapter;
    }
}