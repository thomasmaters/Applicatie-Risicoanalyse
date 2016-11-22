namespace Applicatie_Risicoanalyse.Forms
{
    partial class ARA_TopBar
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
            this.arA_Text2 = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.arA_Text1 = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.SuspendLayout();
            // 
            // arA_Text2
            // 
            this.arA_Text2.BackgroundColor = System.Drawing.Color.White;
            this.arA_Text2.HorizontalAlignment = System.Drawing.StringAlignment.Far;
            this.arA_Text2.Location = new System.Drawing.Point(375, 0);
            this.arA_Text2.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Text2.Name = "arA_Text2";
            this.arA_Text2.Size = new System.Drawing.Size(400, 52);
            this.arA_Text2.TabIndex = 1;
            this.arA_Text2.Text = "sdfgsdfg";
            this.arA_Text2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // arA_Text1
            // 
            this.arA_Text1.BackgroundColor = System.Drawing.Color.White;
            this.arA_Text1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.arA_Text1.Location = new System.Drawing.Point(0, 0);
            this.arA_Text1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Text1.Name = "arA_Text1";
            this.arA_Text1.Size = new System.Drawing.Size(375, 52);
            this.arA_Text1.TabIndex = 0;
            this.arA_Text1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ARA_EditRiskBaseTopBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 52);
            this.Controls.Add(this.arA_Text2);
            this.Controls.Add(this.arA_Text1);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "ARA_EditRiskBaseTopBar";
            this.Text = "ARA_EditRiskBaseTopBar";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ARA_Text arA_Text1;
        private Controls.ARA_Text arA_Text2;
    }
}