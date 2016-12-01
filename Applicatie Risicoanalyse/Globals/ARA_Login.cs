﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Applicatie_Risicoanalyse.Globals
{
    class ARA_Login
    {
        SHA512 cryptographyInstance;
        public ARA_Login()
        {
            this.cryptographyInstance = System.Security.Cryptography.SHA512.Create();
        }

        /// <summary>
        /// Gets users table out of database and tries too compare the users login data.
        /// </summary>
        /// <param name="username">Users username.</param>
        /// <param name="passwordHash">A hash representing the users password.</param>
        /// <returns></returns>
        public bool login(string username, byte[] passwordHash)
        {
            //Loop through users table.
            Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_UserTableAdapter userTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_UserTableAdapter();
            foreach (DataRow row in userTableAdapter.GetData().Rows)
            {
                //Do the usernames match?
                if(row["UserName"].ToString() == username)
                {
                    //Does his password match?
                    if(compareHashes((byte[])row["PasswordHash"], passwordHash))
                    {
                        //Set userid.
                        ARA_Globals.UserID = (Int32)row["UserID"];

                        //Set permission level.
                        try
                        {
                            Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_User_PermissionsTableAdapter permissionTableAdapter = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_User_PermissionsTableAdapter();
                            ARA_Globals.UserPermissionGroup = permissionTableAdapter.GetData().FindByPermissionID((Int32)row["PermissionID"])["PermissionName"].ToString();
                        }
                        catch (Exception)
                        {
                            //We didnt get his permission level, set it to default.
                            ARA_Globals.UserPermissionGroup = "Default";
                        }
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// Uses the sha512 instance to compute a password hash.
        /// </summary>
        /// <param name="byteArrayToHash"></param>
        /// <returns></returns>
        public byte[] getHashFromByteArray(byte[] byteArrayToHash)
        {
            return this.cryptographyInstance.ComputeHash(byteArrayToHash);
        }

        /// <summary>
        /// Generates a random password of a specific length.
        /// </summary>
        /// <param name="length"></param>
        /// <returns>String containing the random password.</returns>
        public string generateRandomPassword(int length)
        {
            Random random = new Random((Int32)DateTime.Now.Ticks);
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvw";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        /// <summary>
        /// Function to check if 2 hashes are equal.
        /// </summary>
        /// <param name="a1">Byte array to compare.</param>
        /// <param name="b1">Other byte array to compare.</param>
        /// <returns></returns>
        private bool compareHashes(byte[] a1, byte[] b1)
        {
            int i;
            if (a1.Length == b1.Length)
            {
                i = 0;
                while (i < a1.Length && (a1[i] == b1[i])) //Earlier it was a1[i]!=b1[i]
                {
                    i++;
                }
                if (i == a1.Length)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Converts a string to a byte array.
        /// </summary>
        /// <param name="str">String to convert.</param>
        /// <returns></returns>
        public byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        /// <summary>
        /// Turns a byte array into a string.
        /// </summary>
        /// <param name="bytes">Byte array to convert.</param>
        /// <returns></returns>
        public string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

        //------------------------------------------------------------------------------------------
        //Alternative 'Experimental' login function.
        //------------------------------------------------------------------------------------------

        [System.Runtime.InteropServices.DllImport("advapi32.dll")]
        public static extern bool LogonUser(string userName, string domainName, string password, int LogonType, int LogonProvider, ref IntPtr phToken);

        private void windowsAuthenticationLogin(string aUsername, string aDomain, string aPassword)
        {
            bool issuccess = false;
            string username = GetloggedinUserName();
            Debug.WriteLine(username);
            if (username.ToLowerInvariant().Contains(aUsername.Trim().ToLowerInvariant()) && username.ToLowerInvariant().Contains(aDomain.Trim().ToLowerInvariant()))
            {
                issuccess = IsValidateCredentials(aUsername.Trim(), aPassword.Trim(), aDomain.Trim());
            }

            if (issuccess)
                MessageBox.Show("Successfuly Login !!!");
            else
                MessageBox.Show("User Name / Password / Domain is invalid !!!");
        }

        private string GetloggedinUserName()
        {
            System.Security.Principal.WindowsIdentity currentUser = System.Security.Principal.WindowsIdentity.GetCurrent();
            return currentUser.Name;
        }

        private bool IsValidateCredentials(string userName, string password, string domain)
        {
            IntPtr tokenHandler = IntPtr.Zero;
            bool isValid = LogonUser(userName, domain, password, 2, 0, ref tokenHandler);
            return isValid;
        }
        //-------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Destructor for cleaning resources.
        /// </summary>
        ~ARA_Login()
        {
            if(this.cryptographyInstance != null)
            {
                cryptographyInstance.Clear();
                cryptographyInstance = null;
            }
        }
    }
}
