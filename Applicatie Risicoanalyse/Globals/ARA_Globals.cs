using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters;
using System.Diagnostics;

namespace Applicatie_Risicoanalyse.Globals
{
    public static class ARA_Globals
    {
        private static String aRA_Version = "ALPHA-V2.001";
        private static float aRa_NoScaleFontSize = 15F;
        private static float aRA_BaseFontSize = 15F;
        private static String aRa_Date = DateTime.Now.ToString("dd-MM-yyyy");

        private static string userPermissionGroup = "Engineer";
        public enum PermissionLevel : byte
        {
            None = 0, ReadOnly, All
        };

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

        public static string UserPermissionGroup
        {
            get
            {
                return userPermissionGroup;
            }

            set
            {
                userPermissionGroup = value;
            }
        }

        public static PermissionLevel getPermissionLevelFromString(string permissionLevel)
        {
            if(permissionLevel.ToLower() == "all")
            {
                return PermissionLevel.All;
            }
            else if(permissionLevel.ToLower() == "readonly")
            {
                return PermissionLevel.ReadOnly;
            }
            else if(permissionLevel.ToLower() == "none")
            {
                return PermissionLevel.None;
            }
            Debug.WriteLine("Didn't recornize permission level, pls check the ACL.");
            return PermissionLevel.None;
        }
    }
}
