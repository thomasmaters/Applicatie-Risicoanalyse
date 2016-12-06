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
            this.topBarTextRight = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.topBarTextLeft = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.SuspendLayout();
            // 
            // arA_Text2
            // 
            this.topBarTextRight.BackgroundColor = System.Drawing.Color.White;
            this.topBarTextRight.HorizontalAlignment = System.Drawing.StringAlignment.Far;
            this.topBarTextRight.Location = new System.Drawing.Point(375, 0);
            this.topBarTextRight.Margin = new System.Windows.Forms.Padding(0);
            this.topBarTextRight.Name = "arA_Text2";
            this.topBarTextRight.Size = new System.Drawing.Size(400, 52);
            this.topBarTextRight.TabIndex = 1;
            this.topBarTextRight.Text = "sdfgsdfg";
            this.topBarTextRight.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // arA_Text1
            // 
            this.topBarTextLeft.BackgroundColor = System.Drawing.Color.White;
            this.topBarTextLeft.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.topBarTextLeft.Location = new System.Drawing.Point(0, 0);
            this.topBarTextLeft.Margin = new System.Windows.Forms.Padding(0);
            this.topBarTextLeft.Name = "arA_Text1";
            this.topBarTextLeft.Size = new System.Drawing.Size(375, 52);
            this.topBarTextLeft.TabIndex = 0;
            this.topBarTextLeft.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ARA_EditRiskBaseTopBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 52);
            this.Controls.Add(this.topBarTextRight);
            this.Controls.Add(this.topBarTextLeft);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "ARA_EditRiskBaseTopBar";
            this.Text = "ARA_EditRiskBaseTopBar";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ARA_Text topBarTextLeft;
        private Controls.ARA_Text topBarTextRight;
    }
}