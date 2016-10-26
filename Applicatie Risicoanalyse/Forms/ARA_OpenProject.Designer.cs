﻿namespace Applicatie_Risicoanalyse.Forms
{
    partial class ARA_OpenProject
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
            this.OpenProjectDataGrid = new System.Windows.Forms.DataGridView();
            this.tblRiskAnalysisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.tbl_Risk_AnalysisTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_AnalysisTableAdapter();
            this.OpenProjectTextBoxSearch = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OpenProjectDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRiskAnalysisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenProjectDataGrid
            // 
            this.OpenProjectDataGrid.AllowUserToAddRows = false;
            this.OpenProjectDataGrid.AllowUserToDeleteRows = false;
            this.OpenProjectDataGrid.AllowUserToResizeColumns = false;
            this.OpenProjectDataGrid.AllowUserToResizeRows = false;
            this.OpenProjectDataGrid.AutoGenerateColumns = false;
            this.OpenProjectDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OpenProjectDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.OpenProjectDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OpenProjectDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerDataGridViewTextBoxColumn,
            this.ProjectID,
            this.StateID,
            this.machineTypeDataGridViewTextBoxColumn,
            this.machineNumberDataGridViewTextBoxColumn,
            this.orderNumberDataGridViewTextBoxColumn});
            this.OpenProjectDataGrid.DataSource = this.tblRiskAnalysisBindingSource;
            this.OpenProjectDataGrid.GridColor = System.Drawing.Color.Silver;
            this.OpenProjectDataGrid.Location = new System.Drawing.Point(0, 35);
            this.OpenProjectDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.OpenProjectDataGrid.Name = "OpenProjectDataGrid";
            this.OpenProjectDataGrid.ReadOnly = true;
            this.OpenProjectDataGrid.RowHeadersVisible = false;
            this.OpenProjectDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.OpenProjectDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OpenProjectDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OpenProjectDataGrid.Size = new System.Drawing.Size(750, 309);
            this.OpenProjectDataGrid.TabIndex = 4;
            this.OpenProjectDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OpenProjectDataGrid_CellMouseDoubleClick);
            // 
            // tblRiskAnalysisBindingSource
            // 
            this.tblRiskAnalysisBindingSource.DataMember = "Tbl_Risk_Analysis";
            this.tblRiskAnalysisBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // lG_Analysis_DatabaseDataSet
            // 
            this.lG_Analysis_DatabaseDataSet.DataSetName = "LG_Analysis_DatabaseDataSet";
            this.lG_Analysis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Risk_AnalysisTableAdapter
            // 
            this.tbl_Risk_AnalysisTableAdapter.ClearBeforeFill = true;
            // 
            // OpenProjectTextBoxSearch
            // 
            this.OpenProjectTextBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.OpenProjectTextBoxSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.OpenProjectTextBoxSearch.BorderSize = 1;
            this.OpenProjectTextBoxSearch.Location = new System.Drawing.Point(0, 3);
            this.OpenProjectTextBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.OpenProjectTextBoxSearch.Name = "OpenProjectTextBoxSearch";
            this.OpenProjectTextBoxSearch.Size = new System.Drawing.Size(750, 32);
            this.OpenProjectTextBoxSearch.TabIndex = 3;
            this.OpenProjectTextBoxSearch.Text = "";
            this.OpenProjectTextBoxSearch.TextChanged += new System.EventHandler(this.arA_TextBox1_TextChanged);
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProjectID
            // 
            this.ProjectID.DataPropertyName = "ProjectID";
            this.ProjectID.HeaderText = "ProjectID";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.ReadOnly = true;
            this.ProjectID.Visible = false;
            // 
            // StateID
            // 
            this.StateID.DataPropertyName = "StateID";
            this.StateID.HeaderText = "StateID";
            this.StateID.Name = "StateID";
            this.StateID.ReadOnly = true;
            this.StateID.Visible = false;
            // 
            // machineTypeDataGridViewTextBoxColumn
            // 
            this.machineTypeDataGridViewTextBoxColumn.DataPropertyName = "MachineType";
            this.machineTypeDataGridViewTextBoxColumn.HeaderText = "MachineType";
            this.machineTypeDataGridViewTextBoxColumn.Name = "machineTypeDataGridViewTextBoxColumn";
            this.machineTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // machineNumberDataGridViewTextBoxColumn
            // 
            this.machineNumberDataGridViewTextBoxColumn.DataPropertyName = "MachineNumber";
            this.machineNumberDataGridViewTextBoxColumn.HeaderText = "MachineNumber";
            this.machineNumberDataGridViewTextBoxColumn.Name = "machineNumberDataGridViewTextBoxColumn";
            this.machineNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ARA_OpenProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 350);
            this.Controls.Add(this.OpenProjectDataGrid);
            this.Controls.Add(this.OpenProjectTextBoxSearch);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(750, 350);
            this.Name = "ARA_OpenProject";
            this.Text = "ARA_OpenProject";
            this.Load += new System.EventHandler(this.ARA_OpenProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OpenProjectDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRiskAnalysisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OpenProjectDataGrid;
        private Controls.ARA_TextBox OpenProjectTextBoxSearch;
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private System.Windows.Forms.BindingSource tblRiskAnalysisBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_AnalysisTableAdapter tbl_Risk_AnalysisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
    }
}