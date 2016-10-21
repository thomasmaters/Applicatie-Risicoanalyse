namespace Applicatie_Risicoanalyse.Forms
{
    partial class ARA_EditRiskBaseForm
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
            this.arA_EditRiskRiskEstimation1 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskRiskEstimation();
            this.arA_EditRiskHazardIndentification1 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskHazardIndentification();
            this.arA_EditRiskExposedPersons1 = new Applicatie_Risicoanalyse.Controls.ARA_EditRiskExposedPersons();
            this.SuspendLayout();
            // 
            // arA_EditRiskRiskEstimation1
            // 
            this.arA_EditRiskRiskEstimation1.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_EditRiskRiskEstimation1.Location = new System.Drawing.Point(3, 237);
            this.arA_EditRiskRiskEstimation1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_EditRiskRiskEstimation1.Name = "arA_EditRiskRiskEstimation1";
            this.arA_EditRiskRiskEstimation1.Size = new System.Drawing.Size(750, 300);
            this.arA_EditRiskRiskEstimation1.TabIndex = 2;
            // 
            // arA_EditRiskHazardIndentification1
            // 
            this.arA_EditRiskHazardIndentification1.AutoScroll = true;
            this.arA_EditRiskHazardIndentification1.BackColor = System.Drawing.Color.White;
            this.arA_EditRiskHazardIndentification1.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_EditRiskHazardIndentification1.HasControlBeenChanged = true;
            this.arA_EditRiskHazardIndentification1.Location = new System.Drawing.Point(3, 67);
            this.arA_EditRiskHazardIndentification1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_EditRiskHazardIndentification1.MaximumSize = new System.Drawing.Size(750, 170);
            this.arA_EditRiskHazardIndentification1.Name = "arA_EditRiskHazardIndentification1";
            this.arA_EditRiskHazardIndentification1.Size = new System.Drawing.Size(750, 170);
            this.arA_EditRiskHazardIndentification1.TabIndex = 1;
            // 
            // arA_EditRiskExposedPersons1
            // 
            this.arA_EditRiskExposedPersons1.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arA_EditRiskExposedPersons1.Location = new System.Drawing.Point(3, 3);
            this.arA_EditRiskExposedPersons1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_EditRiskExposedPersons1.Name = "arA_EditRiskExposedPersons1";
            this.arA_EditRiskExposedPersons1.Size = new System.Drawing.Size(750, 64);
            this.arA_EditRiskExposedPersons1.TabIndex = 0;
            // 
            // ARA_EditRiskBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 726);
            this.Controls.Add(this.arA_EditRiskRiskEstimation1);
            this.Controls.Add(this.arA_EditRiskHazardIndentification1);
            this.Controls.Add(this.arA_EditRiskExposedPersons1);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(750, 1500);
            this.Name = "ARA_EditRiskBaseForm";
            this.Text = "ARA_EditRiskInProject";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ARA_EditRiskExposedPersons arA_EditRiskExposedPersons1;
        private Controls.ARA_EditRiskHazardIndentification arA_EditRiskHazardIndentification1;
        private Controls.ARA_EditRiskRiskEstimation arA_EditRiskRiskEstimation1;
    }
}