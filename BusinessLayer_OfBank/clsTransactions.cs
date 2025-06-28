using DataAccessLayer_OfBank;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_OfBank
{
    public class clsTransactions
    {
        public static DataTable GetAllTransactions()
        {
            return clsTransactionsData.GetAllTransactions();
        }
        public static bool Depsite(string AccountNumber,decimal Amount)
        {
            bool IsDone=false;
            clsClients Client=clsClients.Find(AccountNumber);
            if (Client == null||Amount<0) IsDone = false;
            else
            {
                Client.Balance += Amount;
                Client.Save();
                IsDone = true;
                clsTransactionsData.AddNewTransaction(AccountNumber, Amount, DateTime.Now,"Deposit");
            }     
            return IsDone;
        }
        public static bool WithDraw(string AccountNumber,decimal Amount)
        {
           bool IsDone=false;
            clsClients Client = clsClients.Find(AccountNumber);
            if (Client == null || Amount < 0||Client.Balance<Amount) IsDone = false;
            else
            {
                Client.Balance -= Amount;
                Client.Save();
                IsDone = true;
                clsTransactionsData.AddNewTransaction(AccountNumber, Amount, DateTime.Now,"WithDraw");
            }
            return IsDone;
        }  
        public static decimal GetAllBalances()
        {
            return clsTransactionsData.GetAllBalances();
        }
        
    }
}
