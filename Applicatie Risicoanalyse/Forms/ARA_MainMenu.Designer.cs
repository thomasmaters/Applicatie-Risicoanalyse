namespace Applicatie_Risicoanalyse.Forms
{
    partial class ARA_MainMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainMenuPanelTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.MainMenuRecentActivityText = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.MainMenuPanelContent = new System.Windows.Forms.FlowLayoutPanel();
            this.MainMenuTable = new System.Windows.Forms.DataGridView();
            this.logDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.arA_Button1 = new Applicatie_Risicoanalyse.Controls.ARA_Button();
            this.tbl_LogTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_LogTableAdapter();
            this.MainMenuPanelTitle.SuspendLayout();
            this.MainMenuPanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuPanelTitle
            // 
            this.MainMenuPanelTitle.Controls.Add(this.MainMenuRecentActivityText);
            this.MainMenuPanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainMenuPanelTitle.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.MainMenuPanelTitle.Name = "MainMenuPanelTitle";
            this.MainMenuPanelTitle.Size = new System.Drawing.Size(750, 27);
            this.MainMenuPanelTitle.TabIndex = 0;
            // 
            // MainMenuRecentActivityText
            // 
            this.MainMenuRecentActivityText.BackgroundColor = System.Drawing.Color.White;
            this.MainMenuRecentActivityText.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.MainMenuRecentActivityText.Location = new System.Drawing.Point(0, 0);
            this.MainMenuRecentActivityText.Margin = new System.Windows.Forms.Padding(0);
            this.MainMenuRecentActivityText.Name = "MainMenuRecentActivityText";
            this.MainMenuRecentActivityText.Size = new System.Drawing.Size(750, 29);
            this.MainMenuRecentActivityText.TabIndex = 0;
            this.MainMenuRecentActivityText.Text = "Recent activity";
            this.MainMenuRecentActivityText.VerticalAlignment = System.Drawing.StringAlignment.Far;
            // 
            // MainMenuPanelContent
            // 
            this.MainMenuPanelContent.BackColor = System.Drawing.Color.White;
            this.MainMenuPanelContent.Controls.Add(this.MainMenuTable);
            this.MainMenuPanelContent.Controls.Add(this.arA_Button1);
            this.MainMenuPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenuPanelContent.Location = new System.Drawing.Point(0, 27);
            this.MainMenuPanelContent.Margin = new System.Windows.Forms.Padding(0);
            this.MainMenuPanelContent.Name = "MainMenuPanelContent";
            this.MainMenuPanelContent.Size = new System.Drawing.Size(750, 461);
            this.MainMenuPanelContent.TabIndex = 1;
            // 
            // MainMenuTable
            // 
            this.MainMenuTable.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.MainMenuTable.AllowUserToAddRows = false;
            this.MainMenuTable.AllowUserToDeleteRows = false;
            this.MainMenuTable.AllowUserToResizeColumns = false;
            this.MainMenuTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.MainMenuTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MainMenuTable.AutoGenerateColumns = false;
            this.MainMenuTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MainMenuTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MainMenuTable.BackgroundColor = System.Drawing.Color.White;
            this.MainMenuTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainMenuTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.MainMenuTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainMenuTable.ColumnHeadersVisible = false;
            this.MainMenuTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logDateDataGridViewTextBoxColumn,
            this.actionDescriptionDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.MainMenuTable.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainMenuTable.DataSource = this.tblLogBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainMenuTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.MainMenuTable.Enabled = false;
            this.MainMenuTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.MainMenuTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainMenuTable.Location = new System.Drawing.Point(0, 0);
            this.MainMenuTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainMenuTable.Name = "MainMenuTable";
            this.MainMenuTable.ReadOnly = true;
            this.MainMenuTable.RowHeadersVisible = false;
            this.MainMenuTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MainMenuTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MainMenuTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainMenuTable.ShowCellErrors = false;
            this.MainMenuTable.ShowCellToolTips = false;
            this.MainMenuTable.ShowEditingIcon = false;
            this.MainMenuTable.ShowRowErrors = false;
            this.MainMenuTable.Size = new System.Drawing.Size(750, 183);
            this.MainMenuTable.TabIndex = 0;
            this.MainMenuTable.SelectionChanged += new System.EventHandler(this.onMainMenuTableSelectionChanged);
            // 
            // logDateDataGridViewTextBoxColumn
            // 
            this.logDateDataGridViewTextBoxColumn.DataPropertyName = "LogDate";
            this.logDateDataGridViewTextBoxColumn.HeaderText = "LogDate";
            this.logDateDataGridViewTextBoxColumn.Name = "logDateDataGridViewTextBoxColumn";
            this.logDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.logDateDataGridViewTextBoxColumn.Width = 5;
            // 
            // actionDescriptionDataGridViewTextBoxColumn
            // 
            this.actionDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ActionDescription";
            this.actionDescriptionDataGridViewTextBoxColumn.HeaderText = "ActionDescription";
            this.actionDescriptionDataGridViewTextBoxColumn.Name = "actionDescriptionDataGridViewTextBoxColumn";
            this.actionDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.actionDescriptionDataGridViewTextBoxColumn.Width = 5;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Width = 5;
            // 
            // tblLogBindingSource
            // 
            this.tblLogBindingSource.DataMember = "Tbl_Log";
            this.tblLogBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // lG_Analysis_DatabaseDataSet
            // 
            this.lG_Analysis_DatabaseDataSet.DataSetName = "LG_Analysis_DatabaseDataSet";
            this.lG_Analysis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arA_Button1
            // 
            this.arA_Button1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.arA_Button1.CanButtonBeToggled = false;
            this.arA_Button1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.arA_Button1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.arA_Button1.Location = new System.Drawing.Point(0, 183);
            this.arA_Button1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Button1.Name = "arA_Button1";
            this.arA_Button1.Selected = false;
            this.arA_Button1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.arA_Button1.SelectedTextColor = System.Drawing.Color.White;
            this.arA_Button1.Size = new System.Drawing.Size(750, 33);
            this.arA_Button1.TabIndex = 1;
            this.arA_Button1.Text = "Open admin panel";
            this.arA_Button1.TextColor = System.Drawing.Color.White;
            this.arA_Button1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.arA_Button1.Click += new System.EventHandler(this.arA_Button1_Click);
            // 
            // tbl_LogTableAdapter
            // 
            this.tbl_LogTableAdapter.ClearBeforeFill = true;
            // 
            // ARA_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.MainMenuPanelContent);
            this.Controls.Add(this.MainMenuPanelTitle);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(750, 488);
            this.Name = "ARA_MainMenu";
            this.Text = "ARA_MainMenu";
            this.Load += new System.EventHandler(this.ARA_MainMenu_Load);
            this.MainMenuPanelTitle.ResumeLayout(false);
            this.MainMenuPanelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tblLogBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_LogTableAdapter tbl_LogTableAdapter;
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;

        private System.Windows.Forms.FlowLayoutPanel MainMenuPanelTitle;
        private System.Windows.Forms.FlowLayoutPanel MainMenuPanelContent;
        private Controls.ARA_Text MainMenuRecentActivityText;

        protected System.Windows.Forms.DataGridView MainMenuTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private Controls.ARA_Button arA_Button1;
    }
}