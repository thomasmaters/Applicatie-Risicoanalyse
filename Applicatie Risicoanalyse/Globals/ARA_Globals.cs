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
        private static float aRA_BaseFontSize       = 18F;
        private static String aRa_Date              = DateTime.Now.ToString("dd-MM-yyyy");
        private static string applicationVersion    = "?.?.?.?";

        private static string userPermissionGroup   = "Default";
        private static int userID                   = 1;
        private static string loggedInUsername      = "";

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
            ARA_Events.NewProjectCreatedEventHandler          += ARA_Events_NewProjectCreatedEventHandler;
            ARA_Events.RiskAddedToProjectEventHandler         += ARA_Events_RiskAddedToProjectEventHandler;
            ARA_Events.ProjectOpendEventHandler               += ARA_Events_ProjectOpendEventHandler;
            ARA_Events.ProjectClosedEventHandler              += ARA_Events_ProjectClosedEventHandler;
            ARA_Events.UserLoggedInEventHandler               += ARA_Events_UserLoggedInEventHandler;
            ARA_Events.ProjectStateChangedEventHandler        += ARA_Events_ProjectStateChangedEventHandler;
            ARA_Events.NewProjectRevisionEventHandler         += ARA_Events_NewProjectRevisionEventHandler;
            ARA_Events.ProjectSpecificRiskCreatedEventHandler += ARA_Events_ProjectSpecificRiskCreatedEventHandler;
            ARA_Events.NewRiskAddedToStandardEventHandler     += ARA_Events_NewRiskAddedToStandardEventHandler;
            ARA_Events.NewRiskVersionEventHandler             += ARA_Events_NewRiskVersionEventHandler;
        }

        private void ARA_Events_NewRiskVersionEventHandler(object sender, NewRiskVersionEvent e)
        {
            this.log(string.Format("{0} created version {2} of risk {1}.",ARA_Globals.LoggedInUsername,e.riskID,e.version));
        }

        private void ARA_Events_NewRiskAddedToStandardEventHandler(object sender, NewRiskAddedToStandardEvent e)
        {
            this.log(string.Format("{0} added risk {1} to the standard.", ARA_Globals.LoggedInUsername, e.riskID));
        }

        private void ARA_Events_ProjectSpecificRiskCreatedEventHandler(object sender, ProjectSpecificRiskCreatedEvent e)
        {
            this.log(string.Format("{0} made risk {2} in project {1} project specific.", ARA_Globals.LoggedInUsername, e.projectID, e.riskID));
        }

        private void ARA_Events_NewProjectRevisionEventHandler(object sender, NewProjectRevisionEvent e)
        {
            this.log(string.Format("{0} created revsion {1} of project {2}.", ARA_Globals.LoggedInUsername, e.revision, e.revisionOfProjectID));
        }

        private void ARA_Events_ProjectStateChangedEventHandler(object sender, ProjectStateChangedEvent e)
        {
            this.log(string.Format("{0} changed the state of project {1} to the state {2}.", ARA_Globals.LoggedInUsername, e.projectID, e.state));
        }

        private void ARA_Events_UserLoggedInEventHandler(object sender, UserLoggedInEvent e)
        {
            this.log(string.Format("{0} logged in on {1} with application version {2}.", ARA_Globals.LoggedInUsername,ARA_Globals.ARa_Date,ARA_Globals.ApplicationVersion));
        }

        private void ARA_Events_ProjectClosedEventHandler(object sender, ProjectClosedEvent e)
        {
            this.log(string.Format("{0} closed a project.", ARA_Globals.LoggedInUsername));
        }

        private void ARA_Events_ProjectOpendEventHandler(object sender, ProjectOpendEvent e)
        {
            this.log(string.Format("{0} opened project {1}.", ARA_Globals.LoggedInUsername, e.projectID));
        }

        private void ARA_Events_RiskAddedToProjectEventHandler(object sender, RiskAddedToProjectEvent e)
        {
            this.log(string.Format("{0} added a risk to project {1}.", ARA_Globals.LoggedInUsername, e.projectID));
        }

        private void ARA_Events_NewProjectCreatedEventHandler(object sender, NewProjectCreatedEvent e)
        {
            this.log(string.Format("{0} created a new project.", ARA_Globals.LoggedInUsername));
        }

        public void log(string logMessage)
        {
            try
            {
                logTableAdapter.Insert(DateTime.Now, logMessage, ARA_Globals.UserID);
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
