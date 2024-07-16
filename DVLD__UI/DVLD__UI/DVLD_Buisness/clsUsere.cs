

using System;
using System.Data;

using DVLD_DataAccess;

namespace DVLD_Buisness
{

    public class clsUsers
    {
        public int PersonID { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public clsUsers()
        {
            this.PersonID = -1;
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
        }
        private clsUsers(int personID, int userID, string userName, string password, bool isActive)
        {
            PersonID = personID;
            UserID = userID;
            UserName = userName;
            Password = password;
            IsActive = isActive;
        }

        public static DataTable GetAllUsers()
        {
            return Users.GetAllUsers();
        }

        private int _AddUsers()
        {
            return Users.AddUsers(this.PersonID, this.UserName, this.Password, this.IsActive);
        }

        private bool _UpdateUsers()
        {
            return Users.UpdateUser(this.UserID, this.UserName, this.Password, this.IsActive);
        }

        public static bool DeleteUser(int UserID)
        {
            return Users.DeleteUser(UserID);
        }


        private static clsUsers _ConvertDataTableToUser(DataTable dt)
        {
            if (dt != null)
            {
                clsUsers _users = new clsUsers();
                foreach (DataRow dataRow in dt.Rows)
                {
                    _users.PersonID = (int)dataRow[1];
                    _users.UserID = (int)dataRow[0];
                    _users.UserName = dataRow[2].ToString();
                    _users.IsActive = (bool)dataRow[4];
                }
                return _users;
            }
            return (null);
        }

        public static clsUsers FindUser(int UserID)
        {
            DataTable dataTable = Users.FindUser(UserID);
            if (dataTable != null)
                return _ConvertDataTableToUser(dataTable);
            return null;
        }

        public static clsUsers FindUser(string UserName, string Password)
        {
            DataTable dataTable = Users.FindUser(UserName, Password);
            if (dataTable != null)
                return _ConvertDataTableToUser(dataTable);
            return null;
        }

        public bool Save()
        {
            bool value = false;
            if (this.UserID == -1)
            {
                this.UserID = _AddUsers();
                value = this.UserID > 0 ? true : false;
            }
            else
            {
                value = _UpdateUsers();
            }
            return value;
        }

        public static string GetUserPassword(int UserID)
        {
            return Users.GetUserPassword(UserID);
        }

        public static string GetUserName(int UserID)
        {
            return Users.GetUserName(UserID);
        }

        public static DataTable FindUsers(string Column, int value)
        {
            return Users.FindUsers(Column, value);
        }

        public static DataTable FindUsers(string Column, string value)
        {
            return Users.FindUsers(Column, value);
        }

    }
}