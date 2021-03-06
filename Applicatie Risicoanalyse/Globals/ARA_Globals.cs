﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters;
using System.Diagnostics;
using System.Drawing.Text;
using System.Windows.Shapes;
using System.IO;
using Applicatie_Risicoanalyse.Properties;
using System.Reflection;

namespace Applicatie_Risicoanalyse.Globals
{
    public static class ARA_Globals
    {
        private static float aRA_BaseFontSize       = Applicatie_Risicoanalyse.Properties.Settings.Default.ApplicationScale;
        private static String aRa_Date              = DateTime.Now.ToString("dd-MM-yyyy");
        private static string applicationVersion    = "?.?.?.?";
        private static FontFamily aRA_Font = null;

        private static string userPermissionGroup   = "Default";
        private static int userID                   = 1;
        private static string loggedInUsername      = "";

        private static string appLocation = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), @"Resources\");

        public static byte[] RiskAssessmentFrontPageTemplate = System.IO.File.ReadAllBytes(appLocation + "RiskAssessmentFrontPageTemplate.docx");
        public static byte[] RiskAssessmentIndexPageTemplate = System.IO.File.ReadAllBytes(appLocation + "RiskAssessmentIndexPageTemplate.docx");
        public static byte[] RiskAssessmentRiskPageTemplate = System.IO.File.ReadAllBytes(appLocation + "RiskAssessmentRiskPageTemplate.docx");

        public static byte[] RemainingRiskFrontPageTemplate = System.IO.File.ReadAllBytes(appLocation + "RemainingRiskFrontPageTemplate.docx");
        public static byte[] RemainingRiskRiskPageHeaderTemplate = System.IO.File.ReadAllBytes(appLocation + "RemainingRiskRiskPageHeaderTemplate.docx");
        public static byte[] RemainingRiskRiskPageTemplate = System.IO.File.ReadAllBytes(appLocation + "RemainingRiskRiskPageTemplate.docx");

        public static byte[] PerformanceLevelFrontPageTemplate = System.IO.File.ReadAllBytes(appLocation + "PerformanceLevelFrontPageTemplate.docx");
        public static byte[] PerformanceLevelRiskPageTemplate = System.IO.File.ReadAllBytes(appLocation + "PerformanceLevelRiskPageTemplate.docx");

        //Templates for word 2013 and later.
        public static byte[] RiskAssessmentFrontPageTemplate2013 = System.IO.File.ReadAllBytes(appLocation + "Word2013/RiskAssessmentFrontPageTemplate.docx");
        public static byte[] RiskAssessmentIndexPageTemplate2013 = System.IO.File.ReadAllBytes(appLocation + "Word2013/RiskAssessmentIndexPageTemplate.docx");
        public static byte[] RiskAssessmentRiskPageTemplate2013 = System.IO.File.ReadAllBytes(appLocation + "Word2013/RiskAssessmentRiskPageTemplate.docx");

        public static byte[] RemainingRiskFrontPageTemplate2013 = System.IO.File.ReadAllBytes(appLocation + "Word2013/RemainingRiskFrontPageTemplate.docx");
        public static byte[] RemainingRiskRiskPageHeaderTemplate2013 = System.IO.File.ReadAllBytes(appLocation + "Word2013/RemainingRiskRiskPageHeaderTemplate.docx");
        public static byte[] RemainingRiskRiskPageTemplate2013 = System.IO.File.ReadAllBytes(appLocation + "Word2013/RemainingRiskRiskPageTemplate.docx");

        public static byte[] PerformanceLevelFrontPageTemplate2013 = System.IO.File.ReadAllBytes(appLocation + "Word2013/PerformanceLevelFrontPageTemplate.docx");
        public static byte[] PerformanceLevelRiskPageTemplate2013 = System.IO.File.ReadAllBytes(appLocation + "Word2013/PerformanceLevelRiskPageTemplate.docx");

        private static string[] riskClassDescription = 
        {
            "No safety measures required.",
            "Safety measures recommended!",
            "Safety measures required!!"
        };

        private static Dictionary<string,string> riskSortingOptions = new Dictionary<string,string>()
        {
            {"RiskID Descending","RiskID DESC"},
            {"RiskID Ascending","RiskID ASC"},
            {"Component Group & Type","GroupName, TypeName ASC"},
            {"Alphabetical A-Z","HazardSituation ASC"},
            {"Alphabetical Z-A","HazardSituation DESC"},
        };

        public enum PermissionLevel : byte
        {
            None = 0, ReadOnly, All
        };

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

        public static string UserPermissionGroup
        {
            get
            {
                return userPermissionGroup;
            }

            set
            {
                userPermissionGroup = value.ToLower();
            }
        }

        public static Dictionary<string,string> RiskSortingOptions
        {
            get
            {
                return riskSortingOptions;
            }
        }

        public static string[] RiskClassDescription
        {
            get
            {
                return riskClassDescription;
            }
        }

        public static int UserID
        {
            get
            {
                return userID;
            }

            set
            {
                userID = value;
            }
        }

        public static string LoggedInUsername
        {
            get
            {
                return loggedInUsername;
            }

            set
            {
                loggedInUsername = value;
            }
        }

        public static string ApplicationVersion
        {
            get
            {
                return applicationVersion;
            }

            set
            {
                applicationVersion = value;
            }
        }

        public static FontFamily ARA_Font
        {
            get
            {
                return aRA_Font;
            }

            set
            {
                aRA_Font = value;
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

    public class Logger
    {
        private static Logger instance;
        private static Tbl_LogTableAdapter logTableAdapter = new Tbl_LogTableAdapter();
        private Logger()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            Stream fontStream = this.GetType().Assembly.GetManifestResourceStream("Gotham-Light.ttf");

            byte[] fontdata = Applicatie_Risicoanalyse.Properties.Resources.Gotham_Light;
            unsafe
            {
                fixed (byte* pFontData = fontdata)
                {
                    pfc.AddMemoryFont((System.IntPtr)pFontData, fontdata.Length);
                    ARA_Globals.ARA_Font = pfc.Families[0];
                }
            }
        }

        public void log(string logMessage)
        {
            try
            {
                logTableAdapter.Insert(DateTime.Now, logMessage, ARA_Globals.UserID);
                ARA_Events.triggerNewLogMessageEvent(logMessage);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }
    }
}
