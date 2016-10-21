namespace Applicatie_Risicoanalyse.Controls
{
    partial class ARA_EditRiskRiskReductionMesures
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
            this.HazardPanelSpacerRight = new System.Windows.Forms.Panel();
            this.arA_Rectangle2 = new Applicatie_Risicoanalyse.Controls.ARA_Rectangle();
            this.HarzardTextTitle = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.SuspendLayout();
            // 
            // HazardPanelSpacerRight
            // 
            this.HazardPanelSpacerRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.HazardPanelSpacerRight.Location = new System.Drawing.Point(739, 0);
            this.HazardPanelSpacerRight.Margin = new System.Windows.Forms.Padding(0);
            this.HazardPanelSpacerRight.Name = "HazardPanelSpacerRight";
            this.HazardPanelSpacerRight.Size = new System.Drawing.Size(11, 267);
            this.HazardPanelSpacerRight.TabIndex = 35;
            // 
            // arA_Rectangle2
            // 
            this.arA_Rectangle2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.arA_Rectangle2.Location = new System.Drawing.Point(11, 23);
            this.arA_Rectangle2.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Rectangle2.Name = "arA_Rectangle2";
            this.arA_Rectangle2.Size = new System.Drawing.Size(4, 138);
            this.arA_Rectangle2.TabIndex = 34;
            this.arA_Rectangle2.Text = "arA_Rectangle2";
            // 
            // HarzardTextTitle
            // 
            this.HarzardTextTitle.BackgroundColor = System.Drawing.Color.White;
            this.HarzardTextTitle.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.HarzardTextTitle.Location = new System.Drawing.Point(11, 0);
            this.HarzardTextTitle.Margin = new System.Windows.Forms.Padding(0);
            this.HarzardTextTitle.Name = "HarzardTextTitle";
            this.HarzardTextTitle.Size = new System.Drawing.Size(728, 23);
            this.HarzardTextTitle.TabIndex = 33;
            this.HarzardTextTitle.Text = "Hazard Identification";
            this.HarzardTextTitle.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ARA_EditRiskRiskReductionMesures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HazardPanelSpacerRight);
            this.Controls.Add(this.arA_Rectangle2);
            this.Controls.Add(this.HarzardTextTitle);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(750, 0);
            this.Name = "ARA_EditRiskRiskReductionMesures";
            this.Size = new System.Drawing.Size(750, 267);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HazardPanelSpacerRight;
        private ARA_Rectangle arA_Rectangle2;
        private ARA_Text HarzardTextTitle;
    }
}
