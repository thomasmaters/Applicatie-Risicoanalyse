namespace Applicatie_Risicoanalyse.Forms
{
    partial class ARA_GenerateReportsForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.arA_Text4 = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.arA_Button4 = new Applicatie_Risicoanalyse.Controls.ARA_Button();
            this.arA_Button3 = new Applicatie_Risicoanalyse.Controls.ARA_Button();
            this.arA_Button2 = new Applicatie_Risicoanalyse.Controls.ARA_Button();
            this.arA_Text3 = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.arA_Text2 = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.arA_Button1 = new Applicatie_Risicoanalyse.Controls.ARA_Button();
            this.arA_Text1 = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.generateReportsComboBoxSort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Applicatie_Risicoanalyse.Properties.Resources.RiskAssessmentReportIcon;
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Applicatie_Risicoanalyse.Properties.Resources.RemainingRiskReportIcon;
            this.pictureBox2.Location = new System.Drawing.Point(168, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Applicatie_Risicoanalyse.Properties.Resources.PerformanceLevelReportIcon;
            this.pictureBox3.Location = new System.Drawing.Point(310, 9);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(182, 123);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // arA_Text4
            // 
            this.arA_Text4.BackgroundColor = System.Drawing.Color.White;
            this.arA_Text4.Font = new System.Drawing.Font("Gotham Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_Text4.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.arA_Text4.Location = new System.Drawing.Point(502, 82);
            this.arA_Text4.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Text4.Name = "arA_Text4";
            this.arA_Text4.Size = new System.Drawing.Size(239, 23);
            this.arA_Text4.TabIndex = 13;
            this.arA_Text4.Text = "Sort Risks By:";
            this.arA_Text4.VerticalAlignment = System.Drawing.StringAlignment.Far;
            // 
            // arA_Button4
            // 
            this.arA_Button4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.arA_Button4.CanButtonBeToggled = true;
            this.arA_Button4.Font = new System.Drawing.Font("Gotham Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_Button4.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.arA_Button4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.arA_Button4.Location = new System.Drawing.Point(328, 172);
            this.arA_Button4.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Button4.Name = "arA_Button4";
            this.arA_Button4.Selected = false;
            this.arA_Button4.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.arA_Button4.SelectedTextColor = System.Drawing.Color.White;
            this.arA_Button4.Size = new System.Drawing.Size(151, 29);
            this.arA_Button4.TabIndex = 11;
            this.arA_Button4.Text = "Generate Report";
            this.arA_Button4.TextColor = System.Drawing.Color.White;
            this.arA_Button4.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.arA_Button4.Click += new System.EventHandler(this.arA_Button4_Click);
            // 
            // arA_Button3
            // 
            this.arA_Button3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.arA_Button3.CanButtonBeToggled = true;
            this.arA_Button3.Font = new System.Drawing.Font("Gotham Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_Button3.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.arA_Button3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.arA_Button3.Location = new System.Drawing.Point(168, 172);
            this.arA_Button3.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Button3.Name = "arA_Button3";
            this.arA_Button3.Selected = false;
            this.arA_Button3.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.arA_Button3.SelectedTextColor = System.Drawing.Color.White;
            this.arA_Button3.Size = new System.Drawing.Size(151, 29);
            this.arA_Button3.TabIndex = 10;
            this.arA_Button3.Text = "Generate Report";
            this.arA_Button3.TextColor = System.Drawing.Color.White;
            this.arA_Button3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.arA_Button3.Click += new System.EventHandler(this.arA_Button3_Click);
            // 
            // arA_Button2
            // 
            this.arA_Button2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.arA_Button2.CanButtonBeToggled = true;
            this.arA_Button2.Font = new System.Drawing.Font("Gotham Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_Button2.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.arA_Button2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.arA_Button2.Location = new System.Drawing.Point(9, 172);
            this.arA_Button2.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Button2.Name = "arA_Button2";
            this.arA_Button2.Selected = false;
            this.arA_Button2.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.arA_Button2.SelectedTextColor = System.Drawing.Color.White;
            this.arA_Button2.Size = new System.Drawing.Size(151, 29);
            this.arA_Button2.TabIndex = 9;
            this.arA_Button2.Text = "Generate Report";
            this.arA_Button2.TextColor = System.Drawing.Color.White;
            this.arA_Button2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.arA_Button2.Click += new System.EventHandler(this.arA_Button2_Click);
            // 
            // arA_Text3
            // 
            this.arA_Text3.BackgroundColor = System.Drawing.Color.White;
            this.arA_Text3.Font = new System.Drawing.Font("Gotham Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_Text3.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.arA_Text3.Location = new System.Drawing.Point(328, 135);
            this.arA_Text3.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Text3.Name = "arA_Text3";
            this.arA_Text3.Size = new System.Drawing.Size(151, 37);
            this.arA_Text3.TabIndex = 8;
            this.arA_Text3.Text = "Performance Level Report";
            this.arA_Text3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // arA_Text2
            // 
            this.arA_Text2.BackgroundColor = System.Drawing.Color.White;
            this.arA_Text2.Font = new System.Drawing.Font("Gotham Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_Text2.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.arA_Text2.Location = new System.Drawing.Point(160, 135);
            this.arA_Text2.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Text2.Name = "arA_Text2";
            this.arA_Text2.Size = new System.Drawing.Size(151, 37);
            this.arA_Text2.TabIndex = 7;
            this.arA_Text2.Text = "Remaining Risk Report";
            this.arA_Text2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // arA_Button1
            // 
            this.arA_Button1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.arA_Button1.CanButtonBeToggled = true;
            this.arA_Button1.Font = new System.Drawing.Font("Gotham Book", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_Button1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.arA_Button1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.arA_Button1.Location = new System.Drawing.Point(502, 9);
            this.arA_Button1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Button1.Name = "arA_Button1";
            this.arA_Button1.Selected = false;
            this.arA_Button1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.arA_Button1.SelectedTextColor = System.Drawing.Color.White;
            this.arA_Button1.Size = new System.Drawing.Size(225, 45);
            this.arA_Button1.TabIndex = 6;
            this.arA_Button1.Text = "Generate All Reports";
            this.arA_Button1.TextColor = System.Drawing.Color.White;
            this.arA_Button1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.arA_Button1.Click += new System.EventHandler(this.arA_Button1_Click);
            // 
            // arA_Text1
            // 
            this.arA_Text1.BackgroundColor = System.Drawing.Color.White;
            this.arA_Text1.Font = new System.Drawing.Font("Gotham Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_Text1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.arA_Text1.Location = new System.Drawing.Point(9, 135);
            this.arA_Text1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Text1.Name = "arA_Text1";
            this.arA_Text1.Size = new System.Drawing.Size(151, 37);
            this.arA_Text1.TabIndex = 3;
            this.arA_Text1.Text = "Risk Assessment Report";
            this.arA_Text1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // generateReportsComboBoxSort
            // 
            this.generateReportsComboBoxSort.Font = new System.Drawing.Font("Gotham Book", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReportsComboBoxSort.FormattingEnabled = true;
            this.generateReportsComboBoxSort.Location = new System.Drawing.Point(502, 104);
            this.generateReportsComboBoxSort.Name = "generateReportsComboBoxSort";
            this.generateReportsComboBoxSort.Size = new System.Drawing.Size(225, 28);
            this.generateReportsComboBoxSort.TabIndex = 14;
            // 
            // ARA_GenerateReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 211);
            this.Controls.Add(this.generateReportsComboBoxSort);
            this.Controls.Add(this.arA_Text4);
            this.Controls.Add(this.arA_Button4);
            this.Controls.Add(this.arA_Button3);
            this.Controls.Add(this.arA_Button2);
            this.Controls.Add(this.arA_Text3);
            this.Controls.Add(this.arA_Text2);
            this.Controls.Add(this.arA_Button1);
            this.Controls.Add(this.arA_Text1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Gotham Book", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximumSize = new System.Drawing.Size(750, 211);
            this.Name = "ARA_GenerateReportsForm";
            this.Text = "ARA_GenerateReportsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Controls.ARA_Text arA_Text1;
        private Controls.ARA_Button arA_Button1;
        private Controls.ARA_Text arA_Text2;
        private Controls.ARA_Text arA_Text3;
        private Controls.ARA_Button arA_Button2;
        private Controls.ARA_Button arA_Button3;
        private Controls.ARA_Button arA_Button4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Controls.ARA_Text arA_Text4;
        private System.Windows.Forms.ComboBox generateReportsComboBoxSort;
    }
}