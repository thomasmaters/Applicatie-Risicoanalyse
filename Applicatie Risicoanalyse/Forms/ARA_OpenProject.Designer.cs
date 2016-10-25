namespace Applicatie_Risicoanalyse.Forms
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
            this.OpenRiskInProjectDataGrid = new System.Windows.Forms.DataGridView();
            this.arA_TextBox1 = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OpenRiskInProjectDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenRiskInProjectDataGrid
            // 
            this.OpenRiskInProjectDataGrid.AllowUserToAddRows = false;
            this.OpenRiskInProjectDataGrid.AllowUserToDeleteRows = false;
            this.OpenRiskInProjectDataGrid.AllowUserToResizeColumns = false;
            this.OpenRiskInProjectDataGrid.AllowUserToResizeRows = false;
            this.OpenRiskInProjectDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OpenRiskInProjectDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.OpenRiskInProjectDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OpenRiskInProjectDataGrid.GridColor = System.Drawing.Color.Silver;
            this.OpenRiskInProjectDataGrid.Location = new System.Drawing.Point(0, 32);
            this.OpenRiskInProjectDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.OpenRiskInProjectDataGrid.Name = "OpenRiskInProjectDataGrid";
            this.OpenRiskInProjectDataGrid.ReadOnly = true;
            this.OpenRiskInProjectDataGrid.RowHeadersVisible = false;
            this.OpenRiskInProjectDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.OpenRiskInProjectDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OpenRiskInProjectDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OpenRiskInProjectDataGrid.Size = new System.Drawing.Size(750, 309);
            this.OpenRiskInProjectDataGrid.TabIndex = 4;
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
            this.arA_TextBox1.TabIndex = 3;
            this.arA_TextBox1.Text = "";
            // 
            // ARA_OpenProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 350);
            this.Controls.Add(this.OpenRiskInProjectDataGrid);
            this.Controls.Add(this.arA_TextBox1);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximumSize = new System.Drawing.Size(750, 350);
            this.Name = "ARA_OpenProject";
            this.Text = "ARA_OpenProject";
            ((System.ComponentModel.ISupportInitialize)(this.OpenRiskInProjectDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OpenRiskInProjectDataGrid;
        private Controls.ARA_TextBox arA_TextBox1;
    }
}