using DataAccessLayer_OfBank;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_OfBank
{
    public class clsCurrencies
    {     
        public int ID { get; set; }
        public string Country { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public float Rate_Per_1_Dolor { get; set; }   
        public clsCurrencies()
        {
            ID = -1;
            Country = "";
            Code = "";
            Name = "";
            Rate_Per_1_Dolor = -1;
           
        }
        private clsCurrencies(int ID, string Country, string Code, string Name, float Rate_Per_1_Dolor)
        {
            this.ID = ID;
            this.Country = Country;
            this.Code = Code;
            this.Name = Name;
            this.Rate_Per_1_Dolor = Rate_Per_1_Dolor;
       
        }
        static public DataTable GetAllCurrencies()
        {
            return clsCurrenciesData.GetAllCurrencies();
        }
        public static clsCurrencies Find(string Code)
        {
            int ID = -1;
            string Country = "", Name = "";
            float Rate_Per_1_Dolor = 0;

            if (clsCurrenciesData.GetCurrencyByCode(ref ID,ref  Country,  Code, ref Name, ref Rate_Per_1_Dolor))
                return new clsCurrencies(ID,Country, Code, Name, Rate_Per_1_Dolor);
            else return null;
        }             
        private bool _UpdateCurrency()
        {
            return clsCurrenciesData.UpdateCurrency(this.Country, this.Code, this.Name, this.Rate_Per_1_Dolor);
        }        
        public  static float ExchangeCurrencies(string ConvertFrom_Code,string ConvertTo_Code,float Amount)
      {

            float Result = 0;

            clsCurrencies SourceCurrency=clsCurrencies.Find(ConvertFrom_Code);
            clsCurrencies DestinationCurrency=clsCurrencies.Find(ConvertTo_Code);

            Result=(Amount/SourceCurrency.Rate_Per_1_Dolor)*DestinationCurrency.Rate_Per_1_Dolor;
            return Result;
      }

        public  bool Save()
        {
            return _UpdateCurrency();
        }

    }
}
