namespace Applicatie_Risicoanalyse.Forms
{
    partial class ARA_SearchRiskStandard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OpenProjectDataGrid = new System.Windows.Forms.DataGridView();
            this.riskIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RiskDataID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hazardSituationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchRiskStandardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.search_Risk_StandardTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Search_Risk_StandardTableAdapter();
            this.OpenProjectTextBoxSearch = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OpenProjectDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchRiskStandardBindingSource)).BeginInit();
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
            this.OpenProjectDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.OpenProjectDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.OpenProjectDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OpenProjectDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.riskIDDataGridViewTextBoxColumn,
            this.VersionID,
            this.RiskDataID,
            this.hazardSituationDataGridViewTextBoxColumn,
            this.groupNameDataGridViewTextBoxColumn,
            this.typeNameDataGridViewTextBoxColumn});
            this.OpenProjectDataGrid.DataSource = this.searchRiskStandardBindingSource;
            this.OpenProjectDataGrid.GridColor = System.Drawing.Color.Silver;
            this.OpenProjectDataGrid.Location = new System.Drawing.Point(0, 37);
            this.OpenProjectDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.OpenProjectDataGrid.MultiSelect = false;
            this.OpenProjectDataGrid.Name = "OpenProjectDataGrid";
            this.OpenProjectDataGrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OpenProjectDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OpenProjectDataGrid.RowHeadersVisible = false;
            this.OpenProjectDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.OpenProjectDataGrid.RowTemplate.ReadOnly = true;
            this.OpenProjectDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OpenProjectDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OpenProjectDataGrid.ShowCellErrors = false;
            this.OpenProjectDataGrid.ShowRowErrors = false;
            this.OpenProjectDataGrid.Size = new System.Drawing.Size(728, 309);
            this.OpenProjectDataGrid.TabIndex = 6;
            this.OpenProjectDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OpenProjectDataGrid_CellMouseDoubleClick_1);
            // 
            // riskIDDataGridViewTextBoxColumn
            // 
            this.riskIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.riskIDDataGridViewTextBoxColumn.DataPropertyName = "RiskID";
            this.riskIDDataGridViewTextBoxColumn.FillWeight = 10F;
            this.riskIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.riskIDDataGridViewTextBoxColumn.Name = "riskIDDataGridViewTextBoxColumn";
            this.riskIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.riskIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.riskIDDataGridViewTextBoxColumn.Width = 56;
            // 
            // VersionID
            // 
            this.VersionID.DataPropertyName = "VersionID";
            this.VersionID.HeaderText = "VersionID";
            this.VersionID.Name = "VersionID";
            this.VersionID.ReadOnly = true;
            this.VersionID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VersionID.Visible = false;
            // 
            // RiskDataID
            // 
            this.RiskDataID.DataPropertyName = "RiskDataID";
            this.RiskDataID.HeaderText = "RiskDataID";
            this.RiskDataID.Name = "RiskDataID";
            this.RiskDataID.ReadOnly = true;
            this.RiskDataID.Visible = false;
            // 
            // hazardSituationDataGridViewTextBoxColumn
            // 
            this.hazardSituationDataGridViewTextBoxColumn.DataPropertyName = "HazardSituation";
            this.hazardSituationDataGridViewTextBoxColumn.FillWeight = 60F;
            this.hazardSituationDataGridViewTextBoxColumn.HeaderText = "Brief action description";
            this.hazardSituationDataGridViewTextBoxColumn.Name = "hazardSituationDataGridViewTextBoxColumn";
            this.hazardSituationDataGridViewTextBoxColumn.ReadOnly = true;
            this.hazardSituationDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // groupNameDataGridViewTextBoxColumn
            // 
            this.groupNameDataGridViewTextBoxColumn.DataPropertyName = "GroupName";
            this.groupNameDataGridViewTextBoxColumn.FillWeight = 20F;
            this.groupNameDataGridViewTextBoxColumn.HeaderText = "GroupName";
            this.groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
            this.groupNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.FillWeight = 20F;
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            this.typeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // searchRiskStandardBindingSource
            // 
            this.searchRiskStandardBindingSource.DataMember = "Search_Risk_Standard";
            this.searchRiskStandardBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // lG_Analysis_DatabaseDataSet
            // 
            this.lG_Analysis_DatabaseDataSet.DataSetName = "LG_Analysis_DatabaseDataSet";
            this.lG_Analysis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // search_Risk_StandardTableAdapter
            // 
            this.search_Risk_StandardTableAdapter.ClearBeforeFill = true;
            // 
            // OpenProjectTextBoxSearch
            // 
            this.OpenProjectTextBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.OpenProjectTextBoxSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.OpenProjectTextBoxSearch.BorderSize = 1;
            this.OpenProjectTextBoxSearch.Location = new System.Drawing.Point(0, 5);
            this.OpenProjectTextBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.OpenProjectTextBoxSearch.Name = "OpenProjectTextBoxSearch";
            this.OpenProjectTextBoxSearch.Size = new System.Drawing.Size(728, 32);
            this.OpenProjectTextBoxSearch.TabIndex = 5;
            this.OpenProjectTextBoxSearch.Text = "";
            this.OpenProjectTextBoxSearch.TextChanged += new System.EventHandler(this.OpenProjectTextBoxSearch_TextChanged);
            // 
            // ARA_SearchRiskStandard
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
            this.Name = "ARA_SearchRiskStandard";
            this.Text = "ARA_SearchRiskStandard";
            this.VisibleChanged += new System.EventHandler(this.ARA_SearchRiskStandard_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.OpenProjectDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchRiskStandardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OpenProjectDataGrid;
        private Controls.ARA_TextBox OpenProjectTextBoxSearch;
        private System.Windows.Forms.BindingSource searchRiskStandardBindingSource;
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private LG_Analysis_DatabaseDataSetTableAdapters.Search_Risk_StandardTableAdapter search_Risk_StandardTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn riskIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RiskDataID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hazardSituationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
    }
}