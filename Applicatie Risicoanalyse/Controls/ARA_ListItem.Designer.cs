namespace Applicatie_Risicoanalyse.Controls
{
    partial class ARA_ListItem
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

        #region Component Designer generated code

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
            this.arA_Text2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.arA_Text2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.arA_Text2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.arA_Text2.Location = new System.Drawing.Point(76, 0);
            this.arA_Text2.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Text2.Name = "arA_Text2";
            this.arA_Text2.Size = new System.Drawing.Size(674, 32);
            this.arA_Text2.TabIndex = 1;
            this.arA_Text2.Text = "arA_Text2";
            this.arA_Text2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // arA_Text1
            // 
            this.arA_Text1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.arA_Text1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.arA_Text1.Location = new System.Drawing.Point(0, 0);
            this.arA_Text1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Text1.Name = "arA_Text1";
            this.arA_Text1.Size = new System.Drawing.Size(76, 32);
            this.arA_Text1.TabIndex = 0;
            this.arA_Text1.Text = "arA_Text1";
            this.arA_Text1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ARA_ListItem
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.arA_Text2);
            this.Controls.Add(this.arA_Text1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ARA_ListItem";
            this.Size = new System.Drawing.Size(750, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private ARA_Text arA_Text1;
        private ARA_Text arA_Text2;
    }
}
