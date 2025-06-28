using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_OfBank
{
    public class clsClientsData
    {


        public static DataTable GetAllClients()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * from Clients Order By ID ASC";
            SqlCommand Command = new SqlCommand(Query, Connection);
            DataTable ClientDataTable = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ClientDataTable.Load(Reader);
            }
            catch (Exception ex) { }
            finally { Connection.Close(); }
           return ClientDataTable;
        }


        public static bool GetClientByAccountNO( ref int ID,ref string FirstName,ref string LastName,ref string Phone,
                                                ref string Email,string AccountNumber, ref string PinCode,ref decimal Balance )
        {
            bool IsFound=false;
            SqlConnection Connection =new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * from Clients Where AccountNumber=@AccountNumber";
            SqlCommand Command = new SqlCommand(Query,Connection);
            Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    ID = (int)Reader["ID"];
                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Phone = (string)Reader["Phone"];
                    if (Reader["Email"] != DBNull.Value)
                        Email = (string)Reader["Email"];
                    else
                        Email = "";
                    AccountNumber = (string)Reader["AccountNumber"];
                    PinCode = (string)Reader["PinCode"];
                    Balance = (decimal)Reader["Balance"];
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
        public static int AddNewClient(string FirstName,string LastName ,string Phone,string Email,string AccountNumber,string PinCode,decimal Balance)
        {
            
            SqlConnection Connection=new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query=@"Insert into Clients (FirstName,LastName,Phone,Email,AccountNumber,PinCode,Balance)
                            values
                                  (@FirstName,@LastName,@Phone,@Email,@AccountNumber,@PinCode,@Balance);
                                   Select SCOPE_IDENTITY();  ";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Phone", Phone);
            if (Email != "")
                Command.Parameters.AddWithValue("@Email", Email);
            else
                Command.Parameters.AddWithValue("@Email", DBNull.Value);

            Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            Command.Parameters.AddWithValue("@PinCode", PinCode);
            Command.Parameters.AddWithValue("@Balance", Balance);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                Connection.Close();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    return ID;
                }
                else
                    return -1;

            }
            catch (Exception ex) { }
          
            finally
            {
                Connection.Close();
            }

            return -1;
        }
        public static bool DeleteClient(string AccountNumner)
        {
            SqlConnection Connection=new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Delete from Clients Where AccountNumber=@AccountNumber";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue(@"AccountNumber", AccountNumner);

            int RowsAffected = 0;
            try
            {
                Connection.Open();
                RowsAffected = command.ExecuteNonQuery();
                Connection.Close();
            }
            catch { }
            finally { Connection.Close(); }

            return (RowsAffected > 0);
        }

        public static bool UpdateClient(string FirstName, string LastName, string Phone, string Email, string AccountNumber, string PinCode, decimal Balance)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update Clients 
                          set AccountNumber=@AccountNumber,
                              FirstName=@FirstName,
                              LastName=@LastName,
                               Phone=@Phone,
                               Email=@Email,
                               PinCode=@PinCode,
                               Balance=@Balance
                                Where AccountNumber=@AccountNumber";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Phone", Phone);
            if(Email != "")
            Command.Parameters.AddWithValue("@Email", Email);
            else
                Command.Parameters.AddWithValue("@Email", DBNull.Value);

            Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            Command.Parameters.AddWithValue("@PinCode", PinCode);
            Command.Parameters.AddWithValue("@Balance", Balance);

            int RowsAffected = 0;
            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch {
                return false;
            }
            finally { Connection.Close(); }
            return (RowsAffected > 0);
        }

        public static bool IsExist(string AccountNumber)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select Exist=1 from Clients where AccountNumber=@AccountNumber";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            bool IsFound=false;
            try
            {
                connection.Open();
                SqlDataReader reader=command.ExecuteReader();
                if (reader.HasRows)
                    IsFound = true;
                else { IsFound = false; } 
            }
            catch { return IsFound; }
            finally { connection.Close(); }
            
            return IsFound;
        }

    }
}
