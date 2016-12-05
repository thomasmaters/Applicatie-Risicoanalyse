namespace Applicatie_Risicoanalyse.Forms
{
    partial class ARA_LoadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ARA_LoadingScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadingScreenButtonLogin = new Applicatie_Risicoanalyse.Controls.ARA_Button();
            this.arA_Text2 = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.loadingScreenInputUsername = new Applicatie_Risicoanalyse.Controls.ARA_TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.arA_Text4 = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.loadingScreenTextLoadState = new Applicatie_Risicoanalyse.Controls.ARA_Text();
            this.loadingScreenButtonChangeScale = new Applicatie_Risicoanalyse.Controls.ARA_Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Applicatie_Risicoanalyse.Properties.Resources.Langen_Group_Colour;
            this.pictureBox1.Location = new System.Drawing.Point(554, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.loadingScreenButtonLogin);
            this.panel1.Controls.Add(this.arA_Text2);
            this.panel1.Controls.Add(this.loadingScreenInputUsername);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(344, 224);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 125);
            this.panel1.TabIndex = 100;
            // 
            // loadingScreenButtonLogin
            // 
            this.loadingScreenButtonLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.loadingScreenButtonLogin.CanButtonBeToggled = false;
            this.loadingScreenButtonLogin.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.loadingScreenButtonLogin.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.loadingScreenButtonLogin.Location = new System.Drawing.Point(11, 85);
            this.loadingScreenButtonLogin.Margin = new System.Windows.Forms.Padding(0);
            this.loadingScreenButtonLogin.Name = "loadingScreenButtonLogin";
            this.loadingScreenButtonLogin.Selected = false;
            this.loadingScreenButtonLogin.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.loadingScreenButtonLogin.SelectedTextColor = System.Drawing.Color.White;
            this.loadingScreenButtonLogin.Size = new System.Drawing.Size(227, 31);
            this.loadingScreenButtonLogin.TabIndex = 2;
            this.loadingScreenButtonLogin.Text = "Login";
            this.loadingScreenButtonLogin.TextColor = System.Drawing.Color.White;
            this.loadingScreenButtonLogin.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.loadingScreenButtonLogin.Click += new System.EventHandler(this.loadingScreenButtonLoginClicked);
            this.loadingScreenButtonLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.arA_Button1_KeyPress);
            // 
            // arA_Text2
            // 
            this.arA_Text2.BackgroundColor = System.Drawing.Color.White;
            this.arA_Text2.Font = new System.Drawing.Font("Gotham Light", 13F);
            this.arA_Text2.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.arA_Text2.Location = new System.Drawing.Point(11, 5);
            this.arA_Text2.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Text2.Name = "arA_Text2";
            this.arA_Text2.Size = new System.Drawing.Size(227, 27);
            this.arA_Text2.TabIndex = 100;
            this.arA_Text2.Text = "Welcome";
            this.arA_Text2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // loadingScreenInputUsername
            // 
            this.loadingScreenInputUsername.BackColor = System.Drawing.Color.White;
            this.loadingScreenInputUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.loadingScreenInputUsername.BorderSize = 2;
            this.loadingScreenInputUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadingScreenInputUsername.DetectUrls = false;
            this.loadingScreenInputUsername.Location = new System.Drawing.Point(11, 33);
            this.loadingScreenInputUsername.Margin = new System.Windows.Forms.Padding(0);
            this.loadingScreenInputUsername.MaxLength = 64;
            this.loadingScreenInputUsername.Name = "loadingScreenInputUsername";
            this.loadingScreenInputUsername.ReadOnly = true;
            this.loadingScreenInputUsername.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.loadingScreenInputUsername.Size = new System.Drawing.Size(227, 38);
            this.loadingScreenInputUsername.TabIndex = 0;
            this.loadingScreenInputUsername.Text = "";
            // 
            // arA_Text4
            // 
            this.arA_Text4.BackgroundColor = System.Drawing.Color.White;
            this.arA_Text4.Font = new System.Drawing.Font("Gotham Light", 8F);
            this.arA_Text4.HorizontalAlignment = System.Drawing.StringAlignment.Far;
            this.arA_Text4.Location = new System.Drawing.Point(0, 522);
            this.arA_Text4.Margin = new System.Windows.Forms.Padding(0);
            this.arA_Text4.Name = "arA_Text4";
            this.arA_Text4.Size = new System.Drawing.Size(961, 20);
            this.arA_Text4.TabIndex = 7;
            this.arA_Text4.Text = "Application made by Thomas Maters.          When Pigs Fly Inc.     .";
            this.arA_Text4.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // loadingScreenTextLoadState
            // 
            this.loadingScreenTextLoadState.BackgroundColor = System.Drawing.Color.White;
            this.loadingScreenTextLoadState.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.loadingScreenTextLoadState.Location = new System.Drawing.Point(554, 122);
            this.loadingScreenTextLoadState.Margin = new System.Windows.Forms.Padding(0);
            this.loadingScreenTextLoadState.Name = "loadingScreenTextLoadState";
            this.loadingScreenTextLoadState.Size = new System.Drawing.Size(407, 39);
            this.loadingScreenTextLoadState.TabIndex = 100;
            this.loadingScreenTextLoadState.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // loadingScreenButtonChangeScale
            // 
            this.loadingScreenButtonChangeScale.BaseColor = System.Drawing.Color.White;
            this.loadingScreenButtonChangeScale.CanButtonBeToggled = false;
            this.loadingScreenButtonChangeScale.Font = new System.Drawing.Font("Gotham Light", 8F);
            this.loadingScreenButtonChangeScale.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.loadingScreenButtonChangeScale.HoverColor = System.Drawing.Color.Gainsboro;
            this.loadingScreenButtonChangeScale.Location = new System.Drawing.Point(0, 522);
            this.loadingScreenButtonChangeScale.Margin = new System.Windows.Forms.Padding(0);
            this.loadingScreenButtonChangeScale.Name = "loadingScreenButtonChangeScale";
            this.loadingScreenButtonChangeScale.Selected = false;
            this.loadingScreenButtonChangeScale.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.loadingScreenButtonChangeScale.SelectedTextColor = System.Drawing.Color.White;
            this.loadingScreenButtonChangeScale.Size = new System.Drawing.Size(298, 20);
            this.loadingScreenButtonChangeScale.TabIndex = 101;
            this.loadingScreenButtonChangeScale.Text = "arA_Button1";
            this.loadingScreenButtonChangeScale.TextColor = System.Drawing.Color.Black;
            this.loadingScreenButtonChangeScale.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.loadingScreenButtonChangeScale.Click += new System.EventHandler(this.loadingScreenButtonChangeScale_Click);
            // 
            // ARA_LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::Applicatie_Risicoanalyse.Properties.Resources.MooreBrabazon_with_Flying_Pig1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.loadingScreenButtonChangeScale);
            this.Controls.Add(this.arA_Text4);
            this.Controls.Add(this.loadingScreenTextLoadState);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Gotham Light", 15F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(976, 579);
            this.Name = "ARA_LoadingScreen";
            this.Text = "Application Risk Analysis";
            this.Load += new System.EventHandler(this.ARA_LoadingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Controls.ARA_Button loadingScreenButtonLogin;
        private Controls.ARA_Text arA_Text2;
        private Controls.ARA_TextBox loadingScreenInputUsername;
        private Controls.ARA_Text loadingScreenTextLoadState;
        private Controls.ARA_Text arA_Text4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Controls.ARA_Button loadingScreenButtonChangeScale;
    }
}