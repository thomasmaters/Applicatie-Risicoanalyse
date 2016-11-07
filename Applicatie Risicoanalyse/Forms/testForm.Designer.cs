namespace Applicatie_Risicoanalyse.Forms
{
    partial class testForm
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
            this.lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            this.tblRiskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_RiskTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_RiskTableAdapter();
            this.arA_DropDownButton1 = new Applicatie_Risicoanalyse.Controls.ARA_DropDownButton();
            this.arA_TextBox1 = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            this.arA_EditRiskRiskEstimation1 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskRiskEstimation();
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRiskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lG_Analysis_DatabaseDataSet
            // 
            this.lG_Analysis_DatabaseDataSet.DataSetName = "LG_Analysis_DatabaseDataSet";
            this.lG_Analysis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRiskBindingSource
            // 
            this.tblRiskBindingSource.DataMember = "Tbl_Risk";
            this.tblRiskBindingSource.DataSource = this.lG_Analysis_DatabaseDataSet;
            // 
            // tbl_RiskTableAdapter
            // 
            this.tbl_RiskTableAdapter.ClearBeforeFill = true;
            // 
            // arA_DropDownButton1
            // 
            this.arA_DropDownButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.arA_DropDownButton1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.arA_DropDownButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.arA_DropDownButton1.Location = new System.Drawing.Point(184, 54);
            this.arA_DropDownButton1.Name = "arA_DropDownButton1";
            this.arA_DropDownButton1.PaddingFirstTriangle = -1;
            this.arA_DropDownButton1.PaddingSecondTriangle = 200;
            this.arA_DropDownButton1.Selected = false;
            this.arA_DropDownButton1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.arA_DropDownButton1.SelectedTextColor = System.Drawing.Color.White;
            this.arA_DropDownButton1.Size = new System.Drawing.Size(722, 23);
            this.arA_DropDownButton1.TabIndex = 0;
            this.arA_DropDownButton1.Text = "xfgcvbjnhjk";
            this.arA_DropDownButton1.TextColor = System.Drawing.Color.White;
            this.arA_DropDownButton1.TriangleSize = 22;
            this.arA_DropDownButton1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // arA_TextBox1
            // 
            this.arA_TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.arA_TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.arA_TextBox1.BorderSize = 1;
            this.arA_TextBox1.Location = new System.Drawing.Point(353, 171);
            this.arA_TextBox1.Name = "arA_TextBox1";
            this.arA_TextBox1.Size = new System.Drawing.Size(352, 96);
            this.arA_TextBox1.TabIndex = 1;
            this.arA_TextBox1.Text = "";
            // 
            // arA_EditRiskRiskEstimation1
            // 
            this.arA_EditRiskRiskEstimation1.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_EditRiskRiskEstimation1.HasControlBeenChanged = false;
            this.arA_EditRiskRiskEstimation1.IndicatorRectangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.arA_EditRiskRiskEstimation1.Location = new System.Drawing.Point(104, 121);
            this.arA_EditRiskRiskEstimation1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_EditRiskRiskEstimation1.Name = "arA_EditRiskRiskEstimation1";
            this.arA_EditRiskRiskEstimation1.Size = new System.Drawing.Size(770, 311);
            this.arA_EditRiskRiskEstimation1.TabIndex = 2;
            this.arA_EditRiskRiskEstimation1.TitleText = "Risk Estimation";
            // 
            // testForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 491);
            this.Controls.Add(this.arA_EditRiskRiskEstimation1);
            this.Controls.Add(this.arA_TextBox1);
            this.Controls.Add(this.arA_DropDownButton1);
            this.Name = "testForm";
            this.Text = "testForm";
            ((System.ComponentModel.ISupportInitialize)(this.lG_Analysis_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRiskBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet;
        private System.Windows.Forms.BindingSource tblRiskBindingSource;
        private LG_Analysis_DatabaseDataSetTableAdapters.Tbl_RiskTableAdapter tbl_RiskTableAdapter;
        private Controls.ARA_DropDownButton arA_DropDownButton1;
        private Controls.ARA_TextBox arA_TextBox1;
        private Controls.ARA_EditRiskRiskEstimation arA_EditRiskRiskEstimation1;
    }
}