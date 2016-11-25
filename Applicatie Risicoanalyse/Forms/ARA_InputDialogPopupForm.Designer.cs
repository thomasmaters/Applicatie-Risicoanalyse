using Applicatie_Risicoanalyse.Globals;

namespace Applicatie_Risicoanalyse.Forms
{
    partial class ARA_InputDialogPopupForm
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
            this.inputDialogCancel = new Applicatie_Risicoanalyse.Controls.ARA_Button();
            this.inputDialogOK = new Applicatie_Risicoanalyse.Controls.ARA_Button();
            this.inputDialogTextboxInput = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            this.inputDialogText = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.SuspendLayout();
            // 
            // inputDialogCancel
            // 
            this.inputDialogCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(9)))), ((int)(((byte)(56)))));
            this.inputDialogCancel.CanButtonBeToggled = true;
            this.inputDialogCancel.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.inputDialogCancel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(9)))), ((int)(((byte)(56)))));
            this.inputDialogCancel.Location = new System.Drawing.Point(196, 106);
            this.inputDialogCancel.Name = "inputDialogCancel";
            this.inputDialogCancel.Selected = false;
            this.inputDialogCancel.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(9)))), ((int)(((byte)(56)))));
            this.inputDialogCancel.SelectedTextColor = System.Drawing.Color.White;
            this.inputDialogCancel.Size = new System.Drawing.Size(172, 26);
            this.inputDialogCancel.TabIndex = 3;
            this.inputDialogCancel.Text = "Cancel";
            this.inputDialogCancel.TextColor = System.Drawing.Color.White;
            this.inputDialogCancel.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.inputDialogCancel.Click += new System.EventHandler(this.inputDialogCancel_Click);
            // 
            // inputDialogOK
            // 
            this.inputDialogOK.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(185)))), ((int)(((byte)(72)))));
            this.inputDialogOK.CanButtonBeToggled = true;
            this.inputDialogOK.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.inputDialogOK.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(185)))), ((int)(((byte)(72)))));
            this.inputDialogOK.Location = new System.Drawing.Point(16, 106);
            this.inputDialogOK.Name = "inputDialogOK";
            this.inputDialogOK.Selected = false;
            this.inputDialogOK.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(185)))), ((int)(((byte)(72)))));
            this.inputDialogOK.SelectedTextColor = System.Drawing.Color.White;
            this.inputDialogOK.Size = new System.Drawing.Size(172, 26);
            this.inputDialogOK.TabIndex = 2;
            this.inputDialogOK.Text = "OK";
            this.inputDialogOK.TextColor = System.Drawing.Color.White;
            this.inputDialogOK.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.inputDialogOK.Click += new System.EventHandler(this.inputDialogOK_Click);
            // 
            // inputDialogTextboxInput
            // 
            this.inputDialogTextboxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.inputDialogTextboxInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.inputDialogTextboxInput.BorderSize = 1;
            this.inputDialogTextboxInput.Location = new System.Drawing.Point(16, 44);
            this.inputDialogTextboxInput.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.inputDialogTextboxInput.MaxLength = 512;
            this.inputDialogTextboxInput.Name = "inputDialogTextboxInput";
            this.inputDialogTextboxInput.Size = new System.Drawing.Size(352, 53);
            this.inputDialogTextboxInput.TabIndex = 1;
            this.inputDialogTextboxInput.Text = "";
            // 
            // inputDialogText
            // 
            this.inputDialogText.BackgroundColor = System.Drawing.Color.White;
            this.inputDialogText.Font = new System.Drawing.Font("Gotham Light", 13F);
            this.inputDialogText.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.inputDialogText.Location = new System.Drawing.Point(16, 4);
            this.inputDialogText.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.inputDialogText.Name = "inputDialogText";
            this.inputDialogText.Size = new System.Drawing.Size(352, 41);
            this.inputDialogText.TabIndex = 0;
            this.inputDialogText.Text = "DUMMY TEXT";
            this.inputDialogText.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ARA_InputDialogPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 138);
            this.Controls.Add(this.inputDialogCancel);
            this.Controls.Add(this.inputDialogOK);
            this.Controls.Add(this.inputDialogTextboxInput);
            this.Controls.Add(this.inputDialogText);
            this.Font = new System.Drawing.Font("Gotham Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.Name = "ARA_InputDialogPopupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DUMMY TEXT";
            this.Load += new System.EventHandler(this.ARA_InputDialogPopupForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ARA_Text inputDialogText;
        public Controls.ARA_TextBox inputDialogTextboxInput;
        private Controls.ARA_Button inputDialogOK;
        private Controls.ARA_Button inputDialogCancel;
    }
}