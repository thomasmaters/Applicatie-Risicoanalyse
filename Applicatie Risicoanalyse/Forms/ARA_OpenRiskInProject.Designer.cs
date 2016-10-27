namespace Applicatie_Risicoanalyse.Forms
{
    partial class ARA_OpenRiskInProject
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
            this.OpenRiskInProjectDataGrid = new System.Windows.Forms.DataGridView();
            this.riskIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchProjectRisksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.search_ProjectRisksTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Search_ProjectRisksTableAdapter();
            this.arA_TextBox1 = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OpenRiskInProjectDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProjectRisksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenRiskInProjectDataGrid
            // 
            this.OpenRiskInProjectDataGrid.AllowUserToAddRows = false;
            this.OpenRiskInProjectDataGrid.AllowUserToDeleteRows = false;
            this.OpenRiskInProjectDataGrid.AllowUserToResizeColumns = false;
            this.OpenRiskInProjectDataGrid.AllowUserToResizeRows = false;
            this.OpenRiskInProjectDataGrid.AutoGenerateColumns = false;
            this.OpenRiskInProjectDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OpenRiskInProjectDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.OpenRiskInProjectDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.OpenRiskInProjectDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OpenRiskInProjectDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.riskIDDataGridViewTextBoxColumn,
            this.typeNameDataGridViewTextBoxColumn});
            this.OpenRiskInProjectDataGrid.DataSource = this.searchProjectRisksBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OpenRiskInProjectDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.OpenRiskInProjectDataGrid.GridColor = System.Drawing.Color.Silver;
            this.OpenRiskInProjectDataGrid.Location = new System.Drawing.Point(0, 32);
            this.OpenRiskInProjectDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.OpenRiskInProjectDataGrid.Name = "OpenRiskInProjectDataGrid";
            this.OpenRiskInProjectDataGrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OpenRiskInProjectDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OpenRiskInProjectDataGrid.RowHeadersVisible = false;
            this.OpenRiskInProjectDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.OpenRiskInProjectDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OpenRiskInProjectDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OpenRiskInProjectDataGrid.Size = new System.Drawing.Size(750, 309);
            this.OpenRiskInProjectDataGrid.TabIndex = 2;
            this.OpenRiskInProjectDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OpenRiskInProjectDataGrid_CellMouseDoubleClick);
            // 
            // riskIDDataGridViewTextBoxColumn
            // 
            this.riskIDDataGridViewTextBoxColumn.DataPropertyName = "RiskID";
            this.riskIDDataGridViewTextBoxColumn.HeaderText = "RiskID";
            this.riskIDDataGridViewTextBoxColumn.Name = "riskIDDataGridViewTextBoxColumn";
            this.riskIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            this.typeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // searchProjectRisksBindingSource
            // 
            this.searchProjectRisksBindingSource.DataMember = "Search_ProjectRisks";
            this.searchProjectRisksBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // lG_Analysis_DatabaseDataSet
            // 
            this.lG_Analysis_DatabaseDataSet.DataSetName = "LG_Analysis_DatabaseDataSet";
            this.lG_Analysis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // search_ProjectRisksTableAdapter
            // 
            this.search_ProjectRisksTableAdapter.ClearBeforeFill = true;
            // 
            // arA_TextBox1
            // 
            this.arA_TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.arA_TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.arA_TextBox1.BorderSize = 1;
            this.arA_TextBox1.Location = new System.Drawing.Point(0, 0);
            this.arA_TextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_TextBox1.Name = "arA_TextBox1";
            this.arA_TextBox1.Size = new System.Drawing.Size(750, 32);
            this.arA_TextBox1.TabIndex = 1;
            this.arA_TextBox1.Text = "";
            this.arA_TextBox1.TextChanged += new System.EventHandler(this.arA_TextBox1_TextChanged);
            // 
            // ARA_OpenRiskInProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 350);
            this.Controls.Add(this.OpenRiskInProjectDataGrid);
            this.Controls.Add(this.arA_TextBox1);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(750, 350);
            this.Name = "ARA_OpenRiskInProject";
            this.Text = "ARA_OpenRiskInProject";
            ((System.ComponentModel.ISupportInitialize)(this.OpenRiskInProjectDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProjectRisksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.ARA_TextBox arA_TextBox1;
        private System.Windows.Forms.DataGridView OpenRiskInProjectDataGrid;
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private System.Windows.Forms.BindingSource searchProjectRisksBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Search_ProjectRisksTableAdapter search_ProjectRisksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn riskIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
    }
}