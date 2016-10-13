using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Applicatie_Risicoanalyse.Forms;
using Applicatie_Risicoanalyse.Globals;
using System.Data;
using System.Diagnostics;

namespace Applicatie_Risicoanalyse
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet lG_Analysis_DatabaseDataSet = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSet();
            Applicatie_Risicoanalyse.Globals.ARA_Globals_Singleton instance = Applicatie_Risicoanalyse.Globals.ARA_Globals_Singleton.Instance;
            DataRowCollection queryData = ARA_Globals_Singleton.RisksByGroupAndType;
            Debug.WriteLine(queryData[0]["TypeName"]);
            Application.Run(new Applicatie_Risicoanalyse.Forms.ARA_RiskProjectOverview());
        }
    }
}
