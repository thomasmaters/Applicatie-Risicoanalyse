using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;
using Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters;
using Applicatie_Risicoanalyse.Globals;
using System.Diagnostics;

namespace Applicatie_Risicoanalyse.Globals
{
    public class ARA_ACL
    {
        private static ARA_ACL instance;
        private static List<Permission> appPermissions;

        private ARA_ACL()
        {
            appPermissions = new List<Permission>();

            loadPermissionsFromXML();
        }

        private void loadPermissionsFromXML()
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(Applicatie_Risicoanalyse.Properties.Resources.ACL);

            foreach (XmlNode node in xml.FirstChild.ChildNodes)
            {
                foreach (XmlNode value in node)
                {
                    if (appPermissions.Find(x => x.PermissionName == value.Attributes[0].Value.ToString()) == null)
                    {
                        appPermissions.Add(new Permission(value.Attributes[0].Value.ToString()));
                    }
                    else
                    {
                        appPermissions.Find(x => x.PermissionName == value.Attributes[0].Value.ToString()).addGroupPermission
                            (node.Attributes[0].Value.ToString(), ARA_Globals.getPermissionLevelFromString(value.Attributes[1].Value.ToString()));
                    }
                }
            }
        }

        public static ARA_Globals.PermissionLevel getPermissionLevel(string permissionName)
        {
            Permission permission = appPermissions.Find(x => x.PermissionName == permissionName);
            
            if(permission == null)
            {
                //throw new NullReferenceException();
                Debug.WriteLine("Could not find a permission named: " + permissionName + " returning None.");
                return ARA_Globals.PermissionLevel.None;
            }
            return permission.getPermissionLevel(ARA_Globals.UserPermissionGroup);
        }

        public static ARA_ACL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ARA_ACL();
                }
                return instance;
            }
        }
    }

    public class Permission
    {

        private string permissionName;
        private Dictionary<string, ARA_Globals.PermissionLevel> permissionData;
        public string PermissionName
        {
            get
            {
                return permissionName;
            }
            set
            {
                this.permissionName = value;
            }
        }

        private Dictionary<string, ARA_Globals.PermissionLevel> PermissionData
        {
            get
            {
                return permissionData;
            }
            set
            {
                this.permissionData = value;
            }
        }
        public Permission(string permissionName)
        {
            this.permissionName = permissionName;
            this.permissionData = new Dictionary<string, ARA_Globals.PermissionLevel>();
            this.addGroupPermission("Default", ARA_Globals.PermissionLevel.None);
        }

        public void addGroupPermission(string groupName, ARA_Globals.PermissionLevel permissionLevel)
        {
            if (this.PermissionData.ContainsKey(groupName))
            {
                this.PermissionData[groupName] = permissionLevel;
            }
            else
            {
                this.PermissionData.Add(groupName, permissionLevel);
            }
        }

        public ARA_Globals.PermissionLevel getPermissionLevel(string groupName)
        {
            if(this.PermissionData.ContainsKey(groupName))
            {
                return this.PermissionData[groupName];
            }
            //Couldn't find permission level.
            return ARA_Globals.PermissionLevel.None;
        }
    }
}
