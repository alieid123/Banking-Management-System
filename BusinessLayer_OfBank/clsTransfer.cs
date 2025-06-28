using DataAccessLayer_OfBank;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_OfBank
{
    public class clsTransfer
    {
       public static DataTable GetAllTrnafer()
        {
           return clsTransferData.GetAllTransformations();
        }

        public static void AddNewTransfer(string SourceAccNo, string DestinationAccNo, string UserName, decimal Amount, DateTime dateTime)
        {
            clsClients SourceClient = clsClients.Find(SourceAccNo);
            clsClients DestinationClient = clsClients.Find(DestinationAccNo);

            if (SourceClient != null && DestinationClient != null && Amount > 0&& SourceClient.Balance>=Amount)
            {
                SourceClient.Balance -= Amount;
                DestinationClient.Balance+=Amount;
                SourceClient.Save();
                DestinationClient.Save();
                clsTransferData.AddNewTransfer(SourceAccNo, DestinationAccNo, SourceClient.Balance, DestinationClient.Balance, UserName, Amount, dateTime);
            }

        }


    }
}
