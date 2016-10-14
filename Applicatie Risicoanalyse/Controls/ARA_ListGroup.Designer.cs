namespace Applicatie_Risicoanalyse.Controls
{
    partial class ARA_ListGroup
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
            this.ARA_ListGroupText = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.ARA_ListGroupPanelButton = new System.Windows.Forms.FlowLayoutPanel();
            this.ARA_ListGroupContentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ARA_ListGroupDropDownButton = new Applicatie_Risicoanalyse.Controls.ARA_DropDownButton();
            this.ARA_ListGroupContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ARA_ListGroupText
            // 
            this.ARA_ListGroupText.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.ARA_ListGroupText.Font = new System.Drawing.Font("Gotham Light", 15F);
            this.ARA_ListGroupText.ForeColor = System.Drawing.Color.White;
            this.ARA_ListGroupText.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.ARA_ListGroupText.Location = new System.Drawing.Point(656, 0);
            this.ARA_ListGroupText.Margin = new System.Windows.Forms.Padding(0);
            this.ARA_ListGroupText.Name = "ARA_ListGroupText";
            this.ARA_ListGroupText.Size = new System.Drawing.Size(94, 37);
            this.ARA_ListGroupText.TabIndex = 2;
            this.ARA_ListGroupText.Text = "-1/-1";
            this.ARA_ListGroupText.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ARA_ListGroupPanelButton
            // 
            this.ARA_ListGroupPanelButton.AutoSize = true;
            this.ARA_ListGroupPanelButton.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARA_ListGroupPanelButton.Location = new System.Drawing.Point(750, 0);
            this.ARA_ListGroupPanelButton.Margin = new System.Windows.Forms.Padding(0);
            this.ARA_ListGroupPanelButton.Name = "ARA_ListGroupPanelButton";
            this.ARA_ListGroupPanelButton.Size = new System.Drawing.Size(0, 0);
            this.ARA_ListGroupPanelButton.TabIndex = 3;
            this.ARA_ListGroupPanelButton.Visible = false;
            // 
            // ARA_ListGroupContentPanel
            // 
            this.ARA_ListGroupContentPanel.AutoSize = true;
            this.ARA_ListGroupContentPanel.BackColor = System.Drawing.Color.Maroon;
            this.ARA_ListGroupContentPanel.Controls.Add(this.ARA_ListGroupDropDownButton);
            this.ARA_ListGroupContentPanel.Controls.Add(this.ARA_ListGroupText);
            this.ARA_ListGroupContentPanel.Controls.Add(this.ARA_ListGroupPanelButton);
            this.ARA_ListGroupContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ARA_ListGroupContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ARA_ListGroupContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ARA_ListGroupContentPanel.MaximumSize = new System.Drawing.Size(750, 0);
            this.ARA_ListGroupContentPanel.Name = "ARA_ListGroupContentPanel";
            this.ARA_ListGroupContentPanel.Size = new System.Drawing.Size(750, 355);
            this.ARA_ListGroupContentPanel.TabIndex = 0;
            // 
            // ARA_ListGroupDropDownButton
            // 
            this.ARA_ListGroupDropDownButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.ARA_ListGroupDropDownButton.Font = new System.Drawing.Font("Gotham Light", 15F);
            this.ARA_ListGroupDropDownButton.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.ARA_ListGroupDropDownButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.ARA_ListGroupDropDownButton.Location = new System.Drawing.Point(0, 0);
            this.ARA_ListGroupDropDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.ARA_ListGroupDropDownButton.Name = "ARA_ListGroupDropDownButton";
            this.ARA_ListGroupDropDownButton.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.ARA_ListGroupDropDownButton.PaddingFirstTriangle = 5;
            this.ARA_ListGroupDropDownButton.PaddingSecondTriangle = -1;
            this.ARA_ListGroupDropDownButton.Selected = false;
            this.ARA_ListGroupDropDownButton.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(160)))), ((int)(((byte)(198)))));
            this.ARA_ListGroupDropDownButton.Size = new System.Drawing.Size(656, 37);
            this.ARA_ListGroupDropDownButton.TabIndex = 1;
            this.ARA_ListGroupDropDownButton.TextColor = System.Drawing.Color.White;
            this.ARA_ListGroupDropDownButton.TriangleSize = 18;
            this.ARA_ListGroupDropDownButton.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ARA_ListGroup
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ARA_ListGroupContentPanel);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ARA_ListGroup";
            this.Size = new System.Drawing.Size(750, 355);
            this.Load += new System.EventHandler(this.onListGroupLoad);
            this.ARA_ListGroupContentPanel.ResumeLayout(false);
            this.ARA_ListGroupContentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ARA_Text ARA_ListGroupText;
        private System.Windows.Forms.FlowLayoutPanel ARA_ListGroupPanelButton;
        private System.Windows.Forms.FlowLayoutPanel ARA_ListGroupContentPanel;
        public ARA_DropDownButton ARA_ListGroupDropDownButton;
    }
}
