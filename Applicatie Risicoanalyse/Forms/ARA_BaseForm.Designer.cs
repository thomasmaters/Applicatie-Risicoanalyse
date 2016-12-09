using Applicatie_Risicoanalyse.Globals;

namespace Applicatie_Risicoanalyse.Forms
{
    partial class ARA_BaseForm
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
        ///
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ARA_BaseForm));
            this.SidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TopBar = new System.Windows.Forms.FlowLayoutPanel();
            this.LeftPadding = new System.Windows.Forms.FlowLayoutPanel();
            this.RightPadding = new System.Windows.Forms.FlowLayoutPanel();
            this.contentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.SidePanel.MaximumSize = new System.Drawing.Size(160, 540);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(160, 540);
            this.SidePanel.TabIndex = 0;
            // 
            // TopBar
            // 
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(160, 0);
            this.TopBar.Margin = new System.Windows.Forms.Padding(0);
            this.TopBar.MaximumSize = new System.Drawing.Size(800, 52);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(800, 52);
            this.TopBar.TabIndex = 0;
            // 
            // LeftPadding
            // 
            this.LeftPadding.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPadding.Location = new System.Drawing.Point(160, 52);
            this.LeftPadding.Margin = new System.Windows.Forms.Padding(0);
            this.LeftPadding.MaximumSize = new System.Drawing.Size(25, 489);
            this.LeftPadding.Name = "LeftPadding";
            this.LeftPadding.Size = new System.Drawing.Size(25, 488);
            this.LeftPadding.TabIndex = 1;
            // 
            // RightPadding
            // 
            this.RightPadding.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPadding.Location = new System.Drawing.Point(935, 52);
            this.RightPadding.Margin = new System.Windows.Forms.Padding(0);
            this.RightPadding.MaximumSize = new System.Drawing.Size(25, 489);
            this.RightPadding.Name = "RightPadding";
            this.RightPadding.Size = new System.Drawing.Size(25, 488);
            this.RightPadding.TabIndex = 2;
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(185, 52);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(750, 488);
            this.contentPanel.TabIndex = 3;
            // 
            // ARA_BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.RightPadding);
            this.Controls.Add(this.LeftPadding);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.SidePanel);
            this.Font = new System.Drawing.Font(ARA_Globals.ARA_Font, 15F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ARA_BaseForm";
            this.Text = "ARA_BaseForm";
            this.Load += new System.EventHandler(this.onApplicationLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SidePanel;
        private System.Windows.Forms.FlowLayoutPanel TopBar;
        private System.Windows.Forms.FlowLayoutPanel LeftPadding;
        private System.Windows.Forms.FlowLayoutPanel RightPadding;
        private System.Windows.Forms.FlowLayoutPanel contentPanel;
    }
}