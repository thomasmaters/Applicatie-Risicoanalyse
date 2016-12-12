using Applicatie_Risicoanalyse.Globals;

namespace Applicatie_Risicoanalyse.Forms
{
    partial class ARA_CreateProjectRevision
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
            this.projectRevisionDataGrid = new System.Windows.Forms.DataGridView();
            this.getProjectsForProjectRevisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.get_Projects_For_ProjectRevisionTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Get_Projects_For_ProjectRevisionTableAdapter();
            this.queriesTableAdapter1 = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.QueriesTableAdapter();
            this.projectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevisionOf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectRevisionButtonCreateRevision = new Applicatie_Risicoanalyse.Controls.ARA_Button();
            ((System.ComponentModel.ISupportInitialize)(this.projectRevisionDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProjectsForProjectRevisionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // projectRevisionDataGrid
            // 
            this.projectRevisionDataGrid.AllowUserToAddRows = false;
            this.projectRevisionDataGrid.AllowUserToDeleteRows = false;
            this.projectRevisionDataGrid.AllowUserToResizeColumns = false;
            this.projectRevisionDataGrid.AllowUserToResizeRows = false;
            this.projectRevisionDataGrid.AutoGenerateColumns = false;
            this.projectRevisionDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.projectRevisionDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.projectRevisionDataGrid.Font = new System.Drawing.Font(ARA_Globals.ARA_Font, 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectRevisionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectRevisionDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectIDDataGridViewTextBoxColumn,
            this.Revision,
            this.machineNumberDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.RevisionOf});
            this.projectRevisionDataGrid.DataSource = this.getProjectsForProjectRevisionBindingSource;
            this.projectRevisionDataGrid.Location = new System.Drawing.Point(0, 0);
            this.projectRevisionDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.projectRevisionDataGrid.MultiSelect = false;
            this.projectRevisionDataGrid.Name = "projectRevisionDataGrid";
            this.projectRevisionDataGrid.ReadOnly = true;
            this.projectRevisionDataGrid.RowHeadersVisible = false;
            this.projectRevisionDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projectRevisionDataGrid.Size = new System.Drawing.Size(741, 232);
            this.projectRevisionDataGrid.TabIndex = 0;
            // 
            // getProjectsForProjectRevisionBindingSource
            // 
            this.getProjectsForProjectRevisionBindingSource.DataMember = "Get_Projects_For_ProjectRevision";
            this.getProjectsForProjectRevisionBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // lG_Analysis_DatabaseDataSet
            // 
            this.lG_Analysis_DatabaseDataSet.DataSetName = "LG_Analysis_DatabaseDataSet";
            this.lG_Analysis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // get_Projects_For_ProjectRevisionTableAdapter
            // 
            this.get_Projects_For_ProjectRevisionTableAdapter.ClearBeforeFill = true;
            // 
            // projectIDDataGridViewTextBoxColumn
            // 
            this.projectIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.projectIDDataGridViewTextBoxColumn.DataPropertyName = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn.FillWeight = 40F;
            this.projectIDDataGridViewTextBoxColumn.HeaderText = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn.Name = "projectIDDataGridViewTextBoxColumn";
            this.projectIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectIDDataGridViewTextBoxColumn.Width = 126;
            // 
            // Revision
            // 
            this.Revision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Revision.DataPropertyName = "Revision";
            this.Revision.FillWeight = 30F;
            this.Revision.HeaderText = "Revision";
            this.Revision.Name = "Revision";
            this.Revision.ReadOnly = true;
            this.Revision.Width = 118;
            // 
            // machineNumberDataGridViewTextBoxColumn
            // 
            this.machineNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.machineNumberDataGridViewTextBoxColumn.DataPropertyName = "MachineNumber";
            this.machineNumberDataGridViewTextBoxColumn.FillWeight = 80F;
            this.machineNumberDataGridViewTextBoxColumn.HeaderText = "MachineNumber";
            this.machineNumberDataGridViewTextBoxColumn.Name = "machineNumberDataGridViewTextBoxColumn";
            this.machineNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.machineNumberDataGridViewTextBoxColumn.Width = 195;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RevisionOf
            // 
            this.RevisionOf.DataPropertyName = "RevisionOf";
            this.RevisionOf.HeaderText = "RevisionOf";
            this.RevisionOf.Name = "RevisionOf";
            this.RevisionOf.ReadOnly = true;
            // 
            // projectRevisionButtonCreateRevision
            // 
            this.projectRevisionButtonCreateRevision.BaseColor = ARA_Colors.ARA_Turkois;
            this.projectRevisionButtonCreateRevision.CanButtonBeToggled = false;
            this.projectRevisionButtonCreateRevision.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.projectRevisionButtonCreateRevision.HoverColor = ARA_Colors.ARA_Gray2;
            this.projectRevisionButtonCreateRevision.Location = new System.Drawing.Point(0, 241);
            this.projectRevisionButtonCreateRevision.Margin = new System.Windows.Forms.Padding(0);
            this.projectRevisionButtonCreateRevision.Name = "projectRevisionButtonCreateRevision";
            this.projectRevisionButtonCreateRevision.Selected = false;
            this.projectRevisionButtonCreateRevision.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.projectRevisionButtonCreateRevision.SelectedTextColor = System.Drawing.Color.White;
            this.projectRevisionButtonCreateRevision.Size = new System.Drawing.Size(741, 40);
            this.projectRevisionButtonCreateRevision.TabIndex = 1;
            this.projectRevisionButtonCreateRevision.Text = "Create revision";
            this.projectRevisionButtonCreateRevision.TextColor = System.Drawing.Color.White;
            this.projectRevisionButtonCreateRevision.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.projectRevisionButtonCreateRevision.Click += new System.EventHandler(this.projectRevisionButtonCreateRevision_Click);
            // 
            // ARA_CreateProjectRevision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 285);
            this.Controls.Add(this.projectRevisionButtonCreateRevision);
            this.Controls.Add(this.projectRevisionDataGrid);
            this.Font = new System.Drawing.Font(ARA_Globals.ARA_Font, 15F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(750, 285);
            this.Name = "ARA_CreateProjectRevision";
            this.Text = "testForm";
            this.Load += new System.EventHandler(this.createProjectRevision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectRevisionDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProjectsForProjectRevisionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView projectRevisionDataGrid;
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private Controls.ARA_Button projectRevisionButtonCreateRevision;
        private System.Windows.Forms.BindingSource getProjectsForProjectRevisionBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Get_Projects_For_ProjectRevisionTableAdapter get_Projects_For_ProjectRevisionTableAdapter;
        private LG_Analysis_DatabaseDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Revision;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevisionOf;
    }
}