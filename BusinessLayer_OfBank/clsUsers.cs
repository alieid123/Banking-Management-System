using DataAccessLayer_OfBank;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_OfBank
{
    public class clsUsers
    {
        enum enMode { Update = 0, AddNew = 1 };
        enMode Mode;
        public int ID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public short Permissions { get; set; }
        public clsUsers()
        {
            ID = -1;
            UserName = "";
            FirstName = "";
            LastName = "";
            Phone = "";
            Email = "";
            Password = "";
            Permissions = 0;
            Mode = enMode.AddNew;
        }
        private clsUsers(int ID,string UserName, string FirstName, string LastName, string Phone, string Email, string Password, short Permissions)
        {
            this.ID = ID;
            this.UserName = UserName;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Email = Email;
            this.Password = Password;
            this.Permissions = Permissions;
            Mode = enMode.Update;
        }
        static public DataTable GetAllUsers()
        {
            return clsUsersData.GetAllUsers();
        }
        public static clsUsers Find(string UserName,string Password)
        {
            int ID = -1;
            string FirstName = "", LastName = "", Phone = "", Email = "";
            short Permissions = 0;

            if (clsUsersData.GetUserByUserNameAndPassWord(ref ID, UserName, ref FirstName, ref LastName, ref Phone, ref Email,  Password, ref Permissions))
                return new clsUsers(ID, UserName, FirstName, LastName, Phone, Email, Password, Permissions);
            else return null;
        }
        private bool _AddNewUser()
        {

            this.ID = clsUsersData.AddNewUser(this.UserName,this.FirstName, this.LastName, this.Phone, this.Email, this.Password,this.Permissions);
            return (ID != -1);
        }
        static public bool DeleteUser(string UserName)
        {
            return clsUsersData.DeleteUser(UserName);
        }
        private bool _UpdateUser()
        {
            return clsUsersData.UpdateUser(this.UserName,this.FirstName, this.LastName, this.Phone, this.Email, this.Password, this.Permissions);
        }
        public static bool IsExist(string UserName)
        {
            return clsUsersData.IsExist(UserName);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;
                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }
    }
}
