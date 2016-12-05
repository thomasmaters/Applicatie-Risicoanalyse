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
            this.mainMenuRecentActivityText = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.mainMenuDataGrid = new System.Windows.Forms.DataGridView();
            this.logDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getLatestActivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.get_Latest_ActivityTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_Latest_ActivityTableAdapter();
            this.mainMenuButtonOpenAdminPanel = new Applicatie_Risicoanalyse.Controls.ARA_Button();
            this.MainMenuPanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLatestActivityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuPanelTitle
            // 
            this.MainMenuPanelTitle.Controls.Add(this.mainMenuRecentActivityText);
            this.MainMenuPanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainMenuPanelTitle.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.MainMenuPanelTitle.Name = "MainMenuPanelTitle";
            this.MainMenuPanelTitle.Size = new System.Drawing.Size(750, 27);
            this.MainMenuPanelTitle.TabIndex = 0;
            // 
            // mainMenuRecentActivityText
            // 
            this.mainMenuRecentActivityText.BackgroundColor = System.Drawing.Color.White;
            this.mainMenuRecentActivityText.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.mainMenuRecentActivityText.Location = new System.Drawing.Point(0, 0);
            this.mainMenuRecentActivityText.Margin = new System.Windows.Forms.Padding(0);
            this.mainMenuRecentActivityText.Name = "mainMenuRecentActivityText";
            this.mainMenuRecentActivityText.Size = new System.Drawing.Size(750, 29);
            this.mainMenuRecentActivityText.TabIndex = 0;
            this.mainMenuRecentActivityText.Text = "Recent activity";
            this.mainMenuRecentActivityText.VerticalAlignment = System.Drawing.StringAlignment.Far;
            // 
            // mainMenuDataGrid
            // 
            this.mainMenuDataGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.mainMenuDataGrid.AllowUserToAddRows = false;
            this.mainMenuDataGrid.AllowUserToDeleteRows = false;
            this.mainMenuDataGrid.AllowUserToResizeColumns = false;
            this.mainMenuDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.mainMenuDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.mainMenuDataGrid.AutoGenerateColumns = false;
            this.mainMenuDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainMenuDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mainMenuDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.mainMenuDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainMenuDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.mainMenuDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainMenuDataGrid.ColumnHeadersVisible = false;
            this.mainMenuDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logDateDataGridViewTextBoxColumn,
            this.actionDescriptionDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.mainMenuDataGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mainMenuDataGrid.DataSource = this.getLatestActivityBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainMenuDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.mainMenuDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.mainMenuDataGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainMenuDataGrid.Location = new System.Drawing.Point(0, 29);
            this.mainMenuDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.mainMenuDataGrid.MultiSelect = false;
            this.mainMenuDataGrid.Name = "mainMenuDataGrid";
            this.mainMenuDataGrid.ReadOnly = true;
            this.mainMenuDataGrid.RowHeadersVisible = false;
            this.mainMenuDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mainMenuDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainMenuDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainMenuDataGrid.ShowCellErrors = false;
            this.mainMenuDataGrid.ShowCellToolTips = false;
            this.mainMenuDataGrid.ShowEditingIcon = false;
            this.mainMenuDataGrid.ShowRowErrors = false;
            this.mainMenuDataGrid.Size = new System.Drawing.Size(750, 250);
            this.mainMenuDataGrid.TabIndex = 0;
            this.mainMenuDataGrid.SelectionChanged += new System.EventHandler(this.onMainMenuTableSelectionChanged);
            // 
            // logDateDataGridViewTextBoxColumn
            // 
            this.logDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.logDateDataGridViewTextBoxColumn.DataPropertyName = "LogDate";
            this.logDateDataGridViewTextBoxColumn.FillWeight = 40F;
            this.logDateDataGridViewTextBoxColumn.HeaderText = "LogDate";
            this.logDateDataGridViewTextBoxColumn.Name = "logDateDataGridViewTextBoxColumn";
            this.logDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.logDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.logDateDataGridViewTextBoxColumn.Width = 5;
            // 
            // actionDescriptionDataGridViewTextBoxColumn
            // 
            this.actionDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ActionDescription";
            this.actionDescriptionDataGridViewTextBoxColumn.HeaderText = "ActionDescription";
            this.actionDescriptionDataGridViewTextBoxColumn.Name = "actionDescriptionDataGridViewTextBoxColumn";
            this.actionDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.actionDescriptionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.userIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // getLatestActivityBindingSource
            // 
            this.getLatestActivityBindingSource.DataMember = "Get_Latest_Activity";
            this.getLatestActivityBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // lG_Analysis_DatabaseDataSet
            // 
            this.lG_Analysis_DatabaseDataSet.DataSetName = "LG_Analysis_DatabaseDataSet";
            this.lG_Analysis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // get_Latest_ActivityTableAdapter
            // 
            this.get_Latest_ActivityTableAdapter.ClearBeforeFill = true;
            // 
            // mainMenuButtonOpenAdminPanel
            // 
            this.mainMenuButtonOpenAdminPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.mainMenuButtonOpenAdminPanel.CanButtonBeToggled = false;
            this.mainMenuButtonOpenAdminPanel.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.mainMenuButtonOpenAdminPanel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.mainMenuButtonOpenAdminPanel.Location = new System.Drawing.Point(0, 289);
            this.mainMenuButtonOpenAdminPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainMenuButtonOpenAdminPanel.Name = "mainMenuButtonOpenAdminPanel";
            this.mainMenuButtonOpenAdminPanel.Selected = false;
            this.mainMenuButtonOpenAdminPanel.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.mainMenuButtonOpenAdminPanel.SelectedTextColor = System.Drawing.Color.White;
            this.mainMenuButtonOpenAdminPanel.Size = new System.Drawing.Size(750, 33);
            this.mainMenuButtonOpenAdminPanel.TabIndex = 1;
            this.mainMenuButtonOpenAdminPanel.Text = "Open admin panel";
            this.mainMenuButtonOpenAdminPanel.TextColor = System.Drawing.Color.White;
            this.mainMenuButtonOpenAdminPanel.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.mainMenuButtonOpenAdminPanel.Click += new System.EventHandler(this.mainMenuButtonOpenAdminPanel_Click);
            // 
            // ARA_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.mainMenuButtonOpenAdminPanel);
            this.Controls.Add(this.mainMenuDataGrid);
            this.Controls.Add(this.MainMenuPanelTitle);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(750, 488);
            this.Name = "ARA_MainMenu";
            this.Text = "ARA_MainMenu";
            this.Load += new System.EventHandler(this.ARA_MainMenu_Load);
            this.MainMenuPanelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLatestActivityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;

        private System.Windows.Forms.FlowLayoutPanel MainMenuPanelTitle;
        private Controls.ARA_Text mainMenuRecentActivityText;

        protected System.Windows.Forms.DataGridView mainMenuDataGrid;
        private Controls.ARA_Button mainMenuButtonOpenAdminPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getLatestActivityBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_Latest_ActivityTableAdapter get_Latest_ActivityTableAdapter;
    }
}