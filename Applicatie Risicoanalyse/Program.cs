using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Applicatie_Risicoanalyse.Forms;
using Applicatie_Risicoanalyse.Globals;
using System.Data;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Reflection;
using System.IO;
using static System.Environment;
using Applicatie_Risicoanalyse.Reports.PerformanceLevelReport;

namespace Applicatie_Risicoanalyse
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Logger.Instance.ToString();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ARA_LoadingScreen());
        }
    }
}
