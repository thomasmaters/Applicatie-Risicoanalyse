namespace Applicatie_Risicoanalyse.Forms
{
    partial class testForm
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
            this.arA_ListGroup1 = new Applicatie_Risicoanalyse.Controls.ARA_ListGroup();
            this.SuspendLayout();
            // 
            // arA_ListGroup1
            // 
            this.arA_ListGroup1.BackColor = System.Drawing.SystemColors.Control;
            this.arA_ListGroup1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.arA_ListGroup1.DropDownButtonFirstTrianglePadding = 5;
            this.arA_ListGroup1.DropDownButtonSecondTrianglePadding = -1;
            this.arA_ListGroup1.DropDownButtonSize = new System.Drawing.Size(690, 37);
            this.arA_ListGroup1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.arA_ListGroup1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.arA_ListGroup1.ListParent = null;
            this.arA_ListGroup1.Location = new System.Drawing.Point(31, 9);
            this.arA_ListGroup1.Margin = new System.Windows.Forms.Padding(0);
            this.arA_ListGroup1.Name = "arA_ListGroup1";
            this.arA_ListGroup1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(160)))), ((int)(((byte)(198)))));
            this.arA_ListGroup1.Size = new System.Drawing.Size(750, 415);
            this.arA_ListGroup1.TabIndex = 2;
            this.arA_ListGroup1.TextSize = new System.Drawing.Size(60, 37);
            // 
            // testForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 491);
            this.Controls.Add(this.arA_ListGroup1);
            this.Name = "testForm";
            this.Text = "testForm";
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.ARA_ListGroup arA_ListGroup1;
    }
}