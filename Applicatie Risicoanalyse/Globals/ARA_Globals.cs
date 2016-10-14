using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters;

namespace Applicatie_Risicoanalyse.Globals
{
    public static class ARA_Globals
    {
        private static String aRA_Version = "ALPHA-V1.001";
        private static float aRa_NoScaleFontSize = 15F;
        private static float aRA_BaseFontSize = 15F;
        private static String aRa_Date = DateTime.Now.ToString("dd-MM-yyyy");

        public static string ARA_Version
        {
            get
            {
                return aRA_Version;
            }
        }

        public static float ARA_BaseFontSize
        {
            get
            {
                return aRA_BaseFontSize;
            }
        }

        public static string ARa_Date
        {
            get
            {
                return aRa_Date;
            }

            set
            {
                aRa_Date = value;
            }
        }

        public static float ARa_NoScaleFontSize
        {
            get
            {
                return aRa_NoScaleFontSize;
            }

            set
            {
                aRa_NoScaleFontSize = value;
            }
        }
    }
}
