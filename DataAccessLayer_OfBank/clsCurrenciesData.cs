using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_OfBank
{
    public class clsCurrenciesData
    {

        public static DataTable GetAllCurrencies()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * from Currencies Order By Country ASC";
            SqlCommand Command = new SqlCommand(Query, Connection);
            DataTable CurrenciesDataTable = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    CurrenciesDataTable.Load(Reader);
            }
            catch (Exception ex) { }
            finally { Connection.Close(); }
            return CurrenciesDataTable;
        }
        public static bool GetCurrencyByCode(ref int ID, ref string Country,  string Code, ref string Name, ref float Rate_Per_1_Dolor)
                                                        
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * from Currencies Where Code=@Code";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Code", Code);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    ID = (int)Reader["ID"];
                    Country = (string)Reader["Country"];
                    Name = (string)Reader["Name"];
                    Rate_Per_1_Dolor = Convert.ToSingle(Reader["Rate_Per_1_Dolor"]);

                    IsFound = true;
                }
                else
                    IsFound = false;

                Reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
        }
        public static bool UpdateCurrency(string Country, string Code, string Name, float Rate_Per_1_Dolor)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update Currencies 
                          set Country=@Country,
                              Code=@Code,
                              Name=@Name,
                               Rate_Per_1_Dolor=@Rate_Per_1_Dolor
                                Where Code=@Code;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Country", Country);
            Command.Parameters.AddWithValue("@Code", Code);
            Command.Parameters.AddWithValue("@Name", Name);
            Command.Parameters.AddWithValue("@Rate_Per_1_Dolor", Rate_Per_1_Dolor);         
            int RowsAffected = 0;
            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally { Connection.Close(); }
            return (RowsAffected > 0);
        }

    }
}
