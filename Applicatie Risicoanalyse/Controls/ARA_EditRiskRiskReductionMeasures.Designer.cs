using Applicatie_Risicoanalyse.Globals;

namespace Applicatie_Risicoanalyse.Controls
{
    partial class ARA_EditRiskRiskReductionMeasures
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RiskEstimationText = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.arA_TextBox1 = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            this.riskReductionRectangleIndicator = new Applicatie_Risicoanalyse.Controls.ARA_Rectangle();
            this.HarzardTextTitle = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 23);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(710, 500);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(710, 92);
            this.flowLayoutPanel1.TabIndex = 80;
            this.flowLayoutPanel1.SizeChanged += new System.EventHandler(this.flowLayoutPanel1_SizeChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RiskEstimationText);
            this.panel1.Controls.Add(this.arA_TextBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 72);
            this.panel1.TabIndex = 75;
            // 
            // RiskEstimationText
            // 
            this.RiskEstimationText.BackgroundColor = System.Drawing.Color.White;
            this.RiskEstimationText.Font = new System.Drawing.Font(ARA_Globals.ARA_Font, 13F, System.Drawing.FontStyle.Italic);
            this.RiskEstimationText.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.RiskEstimationText.Location = new System.Drawing.Point(0, 0);
            this.RiskEstimationText.Margin = new System.Windows.Forms.Padding(0);
            this.RiskEstimationText.Name = "RiskEstimationText";
            this.RiskEstimationText.Size = new System.Drawing.Size(724, 23);
            this.RiskEstimationText.TabIndex = 70;
            this.RiskEstimationText.Text = "Other risk reducing mesures";
            this.RiskEstimationText.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // arA_TextBox1
            // 
            this.arA_TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.arA_TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.arA_TextBox1.BorderSize = 1;
            this.arA_TextBox1.Font = new System.Drawing.Font(ARA_Globals.ARA_Font, 13F);
            this.arA_TextBox1.Location = new System.Drawing.Point(6, 23);
            this.arA_TextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_TextBox1.Name = "arA_TextBox1";
            this.arA_TextBox1.Size = new System.Drawing.Size(705, 48);
            this.arA_TextBox1.TabIndex = 71;
            this.arA_TextBox1.Text = "";
            this.arA_TextBox1.TextChanged += new System.EventHandler(this.arA_TextBox1_TextChanged);
            // 
            // riskReductionRectangleIndicator
            // 
            this.riskReductionRectangleIndicator.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.riskReductionRectangleIndicator.Location = new System.Drawing.Point(11, 23);
            this.riskReductionRectangleIndicator.Margin = new System.Windows.Forms.Padding(0);
            this.riskReductionRectangleIndicator.Name = "riskReductionRectangleIndicator";
            this.riskReductionRectangleIndicator.Size = new System.Drawing.Size(4, 50);
            this.riskReductionRectangleIndicator.TabIndex = 34;
            this.riskReductionRectangleIndicator.Text = "arA_Rectangle2";
            // 
            // HarzardTextTitle
            // 
            this.HarzardTextTitle.BackgroundColor = System.Drawing.Color.White;
            this.HarzardTextTitle.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.HarzardTextTitle.Location = new System.Drawing.Point(11, 0);
            this.HarzardTextTitle.Margin = new System.Windows.Forms.Padding(0);
            this.HarzardTextTitle.Name = "HarzardTextTitle";
            this.HarzardTextTitle.Size = new System.Drawing.Size(714, 23);
            this.HarzardTextTitle.TabIndex = 33;
            this.HarzardTextTitle.Text = "Risk reduction";
            this.HarzardTextTitle.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ARA_EditRiskRiskReductionMeasures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.riskReductionRectangleIndicator);
            this.Controls.Add(this.HarzardTextTitle);
            this.Font = new System.Drawing.Font(ARA_Globals.ARA_Font, 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(725, 2000);
            this.Name = "ARA_EditRiskRiskReductionMeasures";
            this.Size = new System.Drawing.Size(725, 178);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ARA_Rectangle riskReductionRectangleIndicator;
        private ARA_Text HarzardTextTitle;
        private ARA_Text RiskEstimationText;
        private ARA_TextBox arA_TextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}
