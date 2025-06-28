using DataAccessLayer_OfBank;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_OfBank
{
    public class clsLoginRegisters
    {

        public static DataTable GetAllRegisters()
        {
            return clsLoginRegistersData.GetAllLoginRegisters();
        }

        public static bool AddNewLoginRegiste(string UserName,string Password,short Permissions,DateTime datetime)
        {
          return  clsLoginRegistersData.AddNewLoginRegisters(UserName, Password, Permissions, datetime);
        }

    }
}
