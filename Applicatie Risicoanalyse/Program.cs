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
            ARA_ACL kaas = ARA_ACL.Instance;
            ARA_Globals.PermissionLevel test = ARA_ACL.getPermissionLevel("hendrik111111");
            ARA_Globals.PermissionLevel test2 = ARA_ACL.getPermissionLevel("jan");
            ARA_Globals.PermissionLevel test3 = ARA_ACL.getPermissionLevel("hendrik11111111111");
            Debug.WriteLine(ARA_ACL.getPermissionLevel("hendrik111111").ToString());

            /*File.Copy("C:\\Users\\Thomas\\documents\\visual studio 2015\\Projects\\Applicatie Risicoanalyse\\Applicatie Risicoanalyse\\Resources\\Gotham-Light.otf",
    Path.Combine(Environment.GetFolderPath(SpecialFolder.Windows),
        "Fonts", "Gotham-LightTest.otf"));
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts");
            key.SetValue("My Font Description", "Gotham-LightTest.otf");
            key.Close();*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ARA_BaseForm());
        }
    }
}
