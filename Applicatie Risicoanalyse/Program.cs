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
using System.Runtime.InteropServices;
using System.Drawing;

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
            Application.AddMessageFilter(new MessageFilter());
            Application.Run(new ARA_LoadingScreen());
        }
    }

    /// <summary>
    /// Class that fixes the scrolling issues on windows 7.
    /// </summary>
    public class MessageFilter : IMessageFilter
    {
        //ARA_InputDialogPopupForm test = null;
        //int messageCount = 0;
        public MessageFilter()
        {
            //test = new ARA_InputDialogPopupForm("Debug", "");
            //test.Show();
        }

        [DllImport("user32.dll")]
        static extern IntPtr WindowFromPoint(Point p);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);


        public bool PreFilterMessage(ref Message m)
        {
            //if(m.Msg != 15 && m.Msg != 512)
            //{
            //    test.inputDialogTextboxInput.Text += m.Msg.ToString()+ ',';
            //    messageCount++;
            //        if(messageCount > 10)
            //    {
            //        messageCount = 0;
            //        test.inputDialogTextboxInput.Text = "";
            //    }
            //    Debug.WriteLine(m.Msg.ToString());
            //}
            switch (m.Msg)
            {
                case 0x020E:   // 0x020A
                    
                    //MessageBox.Show(m.Msg.ToString());
                    return false;
                case 0x020A:  // 0x020E
                    //MessageBox.Show(m.Msg.ToString());
                    IntPtr hControlUnderMouse = WindowFromPoint(new Point((int)m.LParam));
                    if (hControlUnderMouse == m.HWnd)
                        return false; // already headed for the right control
                    else
                    {

                        uint u = Convert.ToUInt32(m.Msg);
                        SendMessage(hControlUnderMouse, u, m.WParam, m.LParam);
                        return true;
                    }
                default:
                    return false;
            }
        }
    }
}
