using Applicatie_Risicoanalyse.Globals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
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

            //Init logger.
            Logger logger = Logger.Instance;

            //Set application version.
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ARA_Globals.ApplicationVersion = string.Format("v{0}.{1}.{2}.{3}",
                    ApplicationDeployment.CurrentDeployment.CurrentVersion.Major,
                    ApplicationDeployment.CurrentDeployment.CurrentVersion.Minor,
                    ApplicationDeployment.CurrentDeployment.CurrentVersion.Build,
                    ApplicationDeployment.CurrentDeployment.CurrentVersion.Revision);
            }

            //Set application scale button text.
            this.loadingScreenButtonChangeScale.Text = "Application scale: " + Applicatie_Risicoanalyse.Properties.Settings.Default.ApplicationScale.ToString();
            this.loadingScreenButtonChangeScale.Invalidate();

            //Set background worker parameters.
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = false;
            backgroundWorker1.DoWork += backgroundWorkerDoWork;
            backgroundWorker1.ProgressChanged += backgroundWorkerReportProgress;
            backgroundWorker1.RunWorkerCompleted += backgroundWorkerCompleted;

            //Set form scaling.
            this.Font = new Font(ARA_Globals.ARA_Font, ARA_Globals.ARA_BaseFontSize, FontStyle.Regular);
            this.loadingScreenInputUsername.Font = this.Font;
            Debug.WriteLine(this.loadingScreenInputUsername.Font.ToString());
        }

        /// <summary>
        /// When our form loads, start the backgroundworker.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ARA_LoadingScreen_Load(object sender, EventArgs e)
        {
            //Set username from system.
            ARA_Login login = new ARA_Login();
            this.loadingScreenInputUsername.Text = login.getLoggedInUserName();
            this.loadingScreenInputUsername.Invalidate();

            //Start checking stuff on the backgroundworker.
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
            backgroundWorker1.ReportProgress(0, (object)"Checking database connection.");
            if(!isServerConnected())
            {
                e.Cancel = true;
                backgroundWorker1.ReportProgress(1, (object)"Couldn't connect to database.");
                return;
            }

            //Can we load the ACL.
            backgroundWorker1.ReportProgress(0, (object)"Checking Permissions File.");
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
            using (var l_oConnection = new SqlConnection(Applicatie_Risicoanalyse.Properties.Settings.Default.LG_Analysis_DatabaseConnectionStringProduction))
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
            if (this.loadingScreenInputUsername.Text.Length > 0)
            {
                //Convert password to a hash.
                ARA_Login loginHandler = new ARA_Login();

                //Try to login the user.
                if(loginHandler.login())
                {
                    loginHandler = null;

                    //Add log message.
                    ARA_Events.triggerUserLoggedInEvent();

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

        /// <summary>
        /// Handler when the user clicks the application scale button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadingScreenButtonChangeScale_Click(object sender, EventArgs e)
        {
            //Did we exceed our maximum size?
            if(Applicatie_Risicoanalyse.Properties.Settings.Default.ApplicationScale + 1F >= 30F)
            {
                Applicatie_Risicoanalyse.Properties.Settings.Default.ApplicationScale = 15F;
            }
            else
            {
                Applicatie_Risicoanalyse.Properties.Settings.Default.ApplicationScale += 1F;
            }

            //Save the setting.
            Applicatie_Risicoanalyse.Properties.Settings.Default.Save();

            //Set the text so the user knows what scale its set to.
            this.loadingScreenButtonChangeScale.Text = "Application scale: " + Applicatie_Risicoanalyse.Properties.Settings.Default.ApplicationScale.ToString() + " (Will take affect after restart!)";
            this.loadingScreenButtonChangeScale.Invalidate();
        }
    }
}
