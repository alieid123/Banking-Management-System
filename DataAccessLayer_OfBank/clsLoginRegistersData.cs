using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_OfBank
{
    public  class clsLoginRegistersData
    {

        public static DataTable GetAllLoginRegisters()
        {
            SqlConnection Connection=new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from Login_Registers";
            SqlCommand command = new SqlCommand(Query,Connection);
            DataTable loginRegisters=new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.HasRows)
                    loginRegisters.Load(Reader);


            }
            catch (Exception ex) { }
            finally { Connection.Close(); }

            return loginRegisters;
        }

        public static bool AddNewLoginRegisters(string UserName,string Password,short Permissions,DateTime DateTime)
        {

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert Into Login_Registers(UserName,Password,Permissions,DateTime)
                        Values  (@UserName,@Password,@Permissions,@DateTime)";
                    
            SqlCommand command= new SqlCommand(Query,Connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            command.Parameters.AddWithValue("@DateTime",DateTime);
            int RowAffected = 0;
            try
            {
                Connection.Open();
                RowAffected = command.ExecuteNonQuery();                           
            }
            catch { }
            finally{ Connection.Close(); }

            return (RowAffected > 0);
        }
    }
}
