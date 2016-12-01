﻿using Applicatie_Risicoanalyse.Globals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class ARA_LoadingScreen : Form
    {
        public ARA_LoadingScreen()
        {
            InitializeComponent();

            //Set background worker parameters.
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = false;
            backgroundWorker1.DoWork += backgroundWorkerDoWork;
            backgroundWorker1.ProgressChanged += backgroundWorkerReportProgress;
            backgroundWorker1.RunWorkerCompleted += backgroundWorkerCompleted;
        }

        /// <summary>
        /// When our form loads, start the backgroundworker.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ARA_LoadingScreen_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        /// <summary>
        /// Our background worker is finished checking.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Did the check succeed?
            if(!e.Cancelled)
            {
                this.panel1.Enabled = true;
            }
        }

        /// <summary>
        /// Set loading info text when the backgroundworker reports progress.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerReportProgress(object sender, ProgressChangedEventArgs e)
        {
            this.loadingScreenTextLoadState.Text = (string)e.UserState;
            //Did we receive an error, color the load state text.
            if(e.ProgressPercentage == 1)
            {
                this.loadingScreenTextLoadState.ForeColor = ARA_Colors.ARA_Red;
            }
            this.loadingScreenTextLoadState.Invalidate();
        }

        /// <summary>
        /// Background worker will check if there is a database connection and if it can load the ACL.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            //Can we connect to the database.
            System.Threading.Thread.Sleep(1000);
            backgroundWorker1.ReportProgress(0, (object)"Checking database connection.");
            if(!isServerConnected())
            {
                e.Cancel = true;
                backgroundWorker1.ReportProgress(1, (object)"Couldn't connect to database.");
                return;
            }

            //Can we load the ACL.
            backgroundWorker1.ReportProgress(0, (object)"Checking Permissions File.");
            System.Threading.Thread.Sleep(1000);
            if(!canACLBeLoaded())
            {
                e.Cancel = true;
                backgroundWorker1.ReportProgress(1, (object)"Couldn't load ACL.");
                return;
            }

            //Finished loading.
            backgroundWorker1.ReportProgress(0, (object)"Succesfully loaded all the things!");
        }

        /// <summary>
        /// Function to check if the ACL can be loaded.
        /// </summary>
        /// <returns></returns>
        private bool canACLBeLoaded()
        {
            try
            {
                ARA_ACL temp = ARA_ACL.Instance;
                ARA_ACL.Instance.loadPermissionsFromXML();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Function to check if the application can connect to the database.
        /// </summary>
        /// <returns></returns>
        private bool isServerConnected()
        {
            using (var l_oConnection = new SqlConnection(Applicatie_Risicoanalyse.Properties.Settings.Default.LG_Analysis_DatabaseConnectionString))
            {
                try
                {
                    l_oConnection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Handler when login button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadingScreenButtonLoginClicked(object sender, EventArgs e)
        {
            //Did the user put in some values.
            if (this.loadingScreenInputPassword.Text.Length > 0 && this.loadingScreenInputUsername.Text.Length > 0)
            {
                //Convert password to a hash.
                ARA_Login loginHandler = new ARA_Login();
                byte[] passwordHash = loginHandler.getHashFromByteArray(loginHandler.GetBytes(this.loadingScreenInputPassword.Text));
                loadingScreenInputPassword.Text = "";

                //Try to login the user.
                if(loginHandler.login(this.loadingScreenInputUsername.Text, passwordHash))
                {
                    loginHandler = null;

                    this.Hide();

                    ARA_BaseForm mainApp = new ARA_BaseForm();
                    mainApp.Closed += (s, args) => this.Close();
                    mainApp.Show();
                }
                else
                {
                    MessageBox.Show(ARA_Constants.messageBoxLoginFailded, ARA_Constants.messageBoxLoginFaildedHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Handler when the user selects the loginbutton with the TAB key and presses enter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arA_Button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                this.loadingScreenButtonLoginClicked(sender, e);
            }
        }

        /// <summary>
        /// Handler when the user has selected the password box and presses enter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadingScreenInputPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.loadingScreenButtonLoginClicked(sender, e);
            }
        }
    }
}