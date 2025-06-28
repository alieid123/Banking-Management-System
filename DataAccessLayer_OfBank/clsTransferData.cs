using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_OfBank
{
    public class clsTransferData
    {
        static public DataTable GetAllTransformations()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * from Transformations order by ID ASC";
            SqlCommand Command = new SqlCommand(Query, Connection);

            DataTable TransferDataTable = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    TransferDataTable.Load(Reader);
            }
            catch (Exception ex) { }
            finally { Connection.Close(); }
            return TransferDataTable;
        }

        public static int AddNewTransfer(string SourceAccNo,string DestinationAccNo, decimal SourceBalance, decimal DestinationBalance, string UserName,decimal Amount,DateTime dateTime)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert Into Transformations(SourceAccNo,DestinationAccNo,SourceBalance,DestinationBalance,UserName,Amount,dateTime) values
                            (@SourceAccNo,@DestinationAccNo,@SourceBalance,@DestinationBalance,@UserName,@Amount,@DateTime);
                             Select SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@SourceAccNo", SourceAccNo);
            Command.Parameters.AddWithValue("@DestinationAccNo", DestinationAccNo);
            Command.Parameters.AddWithValue("@SourceBalance", SourceBalance);
            Command.Parameters.AddWithValue("@DestinationBalance", DestinationBalance);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Amount", Amount);
            Command.Parameters.AddWithValue("@DateTime", dateTime);           
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




    }
}
