using DataAccessLayer_OfBank;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLayer_OfBank
{
    public class clsClients
    {
        enum enMode { Update = 0, AddNew = 1 };
        enMode Mode;
        public  int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string AccountNumber { get; set; }
        public string PinCode { get; set; }
        public decimal Balance { get; set; }

        public  clsClients()
        {
            ID = -1;
            FirstName = "";
            LastName = "";
            Phone = "";
            Email = "";
            AccountNumber = "";
            PinCode = "";
            Balance = -1;
            Mode = enMode.AddNew;
        }

        private clsClients( int ID,  string FirstName,  string LastName,  string Phone,  string Email, string AccountNumber,  string PinCode,  decimal Balance)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Email = Email;
            this.AccountNumber = AccountNumber;
            this.PinCode = PinCode;
            this.Balance = Balance;
            Mode = enMode.Update;
        }


        static public DataTable GetAllClients()
        {
            return clsClientsData.GetAllClients();
        }
        public static clsClients Find(string AccountNmber)
        {
            int ID = -1;
            string FirstName = "", LastName = "", Phone = "", Email = "", PinCode = "";
            decimal Balance = -1;

            if(clsClientsData.GetClientByAccountNO(ref ID,ref FirstName,ref LastName,ref Phone,ref Email,AccountNmber,ref PinCode,ref Balance))
                return new clsClients(ID,FirstName,LastName,Phone,Email,AccountNmber,PinCode,Balance);
            else return null;
        }

        private  bool _AddNewContact()
        {

            this.ID = clsClientsData.AddNewClient(this.FirstName, this.LastName, this.Phone, this.Email, this.AccountNumber, this.PinCode, this.Balance);
            return (ID != -1);
        }

        static public bool DeleteClient(string AccountNumber)
        {
            return clsClientsData.DeleteClient(AccountNumber);
        }

        private bool _UpdateClient()
        {
            return clsClientsData.UpdateClient(this.FirstName, this.LastName, this.Phone, this.Email, this.AccountNumber, this.PinCode, this.Balance);
        }

        public static bool IsExist(string AccountNumber)
        {
            return clsClientsData.IsExist(AccountNumber);
        }
         public bool Save()
         {
            switch (Mode)
            {
               case enMode.AddNew:
                    if(_AddNewContact())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;
               case enMode.Update:
                   return _UpdateClient();                          
            }
            return false;
         }

    }
        
}
