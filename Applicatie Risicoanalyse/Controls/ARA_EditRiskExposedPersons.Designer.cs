namespace Applicatie_Risicoanalyse.Controls
{
    partial class ARA_EditRiskExposedPersons
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.arA_Rectangle1 = new Applicatie_Risicoanalyse.Controls.ARA_Rectangle();
            this.arA_Text1 = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(750, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 266);
            this.panel1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.arA_Rectangle1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.arA_Text1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(761, 266);
            this.panel3.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 23);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(724, 28);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 266);
            this.panel2.TabIndex = 11;
            // 
            // arA_Rectangle1
            // 
            this.arA_Rectangle1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.arA_Rectangle1.Location = new System.Drawing.Point(11, 23);
            this.arA_Rectangle1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Rectangle1.Name = "arA_Rectangle1";
            this.arA_Rectangle1.Size = new System.Drawing.Size(4, 28);
            this.arA_Rectangle1.TabIndex = 8;
            this.arA_Rectangle1.Text = "arA_Rectangle1";
            // 
            // arA_Text1
            // 
            this.arA_Text1.BackgroundColor = System.Drawing.Color.White;
            this.arA_Text1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.arA_Text1.Location = new System.Drawing.Point(11, 0);
            this.arA_Text1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Text1.Name = "arA_Text1";
            this.arA_Text1.Size = new System.Drawing.Size(728, 23);
            this.arA_Text1.TabIndex = 7;
            this.arA_Text1.Text = "Exposed Persons";
            this.arA_Text1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ARA_EditRiskExposedPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ARA_EditRiskExposedPersons";
            this.Size = new System.Drawing.Size(761, 266);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ARA_Rectangle arA_Rectangle1;
        private ARA_Text arA_Text1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
