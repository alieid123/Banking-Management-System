using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer_OfBank
{
    public class clsTransactionsData
    {
        static public DataTable GetAllTransactions()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * from Transactions order by ID ASC";
            SqlCommand Command = new SqlCommand(Query, Connection);

            DataTable TransacDataTable = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    TransacDataTable.Load(Reader);
            }
            catch (Exception ex) { }
            finally { Connection.Close(); }
            return TransacDataTable;
        }
        public static int AddNewTransaction(string AccountNumber, decimal Amount, DateTime dateTime, string Transaction_Name)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert Into Transactions(AccountNumber,Amount,DateTime,Transaction_Name) values
                            (@AccountNumber,@Amount,@DateTime,@Transaction_Name);
                             Select SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            Command.Parameters.AddWithValue("@Amount", Amount);
            Command.Parameters.AddWithValue("@DateTime", dateTime);
            Command.Parameters.AddWithValue("@Transaction_Name", Transaction_Name);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                Connection.Close();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                    return ID;
                else return -1;
            }
            catch { }
            finally { Connection.Close(); }
            return -1;
          
        }
        public static decimal GetAllBalances()
        {
           
            SqlConnection Connection=new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select Sum(Balance) from Clients";
            SqlCommand command = new SqlCommand(Query, Connection);
            try
            {
                Connection.Open();
                object Result = command.ExecuteScalar();
                Connection.Close();
                if (Result != null && decimal.TryParse(Result.ToString(), out decimal TotalBalance))
                {
                    Connection.Close();
                    return TotalBalance;
                }
                else return -1;              
            }
            catch { }
            finally { Connection.Close(); }
            return -1;
        }

       
    }


}
