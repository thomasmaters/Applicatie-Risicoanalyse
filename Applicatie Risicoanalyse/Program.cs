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

namespace Applicatie_Risicoanalyse
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            ARA_ACL kaas = ARA_ACL.Instance;
            ARA_Globals.PermissionLevel test = ARA_ACL.getPermissionLevel("hendrik111111");
            ARA_Globals.PermissionLevel test2 = ARA_ACL.getPermissionLevel("jan");
            ARA_Globals.PermissionLevel test3 = ARA_ACL.getPermissionLevel("hendrik11111111111");
            Debug.WriteLine(ARA_ACL.getPermissionLevel("hendrik111111").ToString());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Applicatie_Risicoanalyse.Forms.ARA_BaseForm());
        }
    }
}
