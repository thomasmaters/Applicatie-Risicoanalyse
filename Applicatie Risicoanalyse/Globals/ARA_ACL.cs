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

        /// <summary>
        /// Loads the ACL.xml file and loads it into memory.
        /// </summary>
        public void loadPermissionsFromXML()
        {
            //Create xml document instance.
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(Applicatie_Risicoanalyse.Properties.Resources.ACL);

            //Loop through permission groups.
            foreach (XmlNode node in xml.FirstChild.ChildNodes)
            {
                //Loop through individual permissions.
                foreach (XmlNode value in node)
                {
                    //Dit we not already load the permission for that group into memory?
                    if (appPermissions.Find(x => x.PermissionName == value.Attributes[0].Value.ToString()) == null)
                    {
                        appPermissions.Add(new Permission(value.Attributes[0].Value.ToString()));
                    }
                    else
                    {
                        //We did already loaded the permission into memory, but we have a different group.
                        appPermissions.Find(x => x.PermissionName == value.Attributes[0].Value.ToString()).addGroupPermission
                            (node.Attributes[0].Value.ToString().ToLower(), ARA_Globals.getPermissionLevelFromString(value.Attributes[1].Value.ToString()));
                    }
                }
            }
        }

        /// <summary>
        /// Checks if a specific permission has been loaded and if the user has permissions for it.
        /// Returns PermissionLevel.None if the permission was not found our the permissiongroup is not found.
        /// </summary>
        /// <param name="permissionName">Permission name to check for.</param>
        /// <returns></returns>
        public static ARA_Globals.PermissionLevel getPermissionLevel(string permissionName)
        {
            Permission permission = appPermissions.Find(x => x.PermissionName == permissionName);
            
            //We did not found our permission.
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

    /// <summary>
    /// Class that stores individual permissions.
    /// This will look like this:
    /// "PermissionName"(General.ClickOnButton)
    /// ->PermissionGroup(Default)
    /// --->PermissionLevel(None)
    /// ->PermissionGroup(Admin)
    /// --->PermissionLevel(all)
    /// </summary>
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

            //Always load default permission.
            this.addGroupPermission("Default", ARA_Globals.PermissionLevel.None);
        }

        /// <summary>
        /// Adds permissions for a specific group in a permission name.
        /// </summary>
        /// <param name="groupName"></param>
        /// <param name="permissionLevel"></param>
        public void addGroupPermission(string groupName, ARA_Globals.PermissionLevel permissionLevel)
        {
            //Check if our dictionary contains a specific group.
            if (this.PermissionData.ContainsKey(groupName))
            {
                //It already exists in the dictionary, overwrite permissionLevel.
                this.PermissionData[groupName] = permissionLevel;
            }
            else
            {
                //We didn't find it, add it to the dictionary.
                this.PermissionData.Add(groupName, permissionLevel);
            }
        }

        /// <summary>
        /// Checks if a specific group has a permissionLevel for this permission.
        /// </summary>
        /// <param name="groupName">GPermission group to get the permission of.</param>
        /// <returns>Returns PermissionLevel.None if the group was not found.</returns>
        public ARA_Globals.PermissionLevel getPermissionLevel(string groupName)
        {
            //Check if our dictonary contains a specific group.
            if(this.PermissionData.ContainsKey(groupName))
            {
                return this.PermissionData[groupName];
            }
            //Couldn't find permission level.
            return ARA_Globals.PermissionLevel.None;
        }
    }
}
