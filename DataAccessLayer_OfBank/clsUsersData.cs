using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_OfBank
{
    public class clsUsersData
    {
        public static DataTable GetAllUsers()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * from Users Order By ID ASC";
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
        public static bool GetUserByUserNameAndPassWord(ref int ID,string UserName, ref string FirstName, ref string LastName, ref string Phone,
                                                        ref string Email, string Password, ref short Permmissions)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * from Users Where UserName=@UserName And Password=@Password";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    ID = (int)Reader["ID"];
                    UserName = (string)Reader["UserName"];
                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Phone = (string)Reader["Phone"];                  
                    Email = (string)Reader["Email"];                   
                    Password = (string)Reader["Password"];
                    Permmissions = (short)Reader["Permissions"];

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
        public static int AddNewUser(string UserName,string FirstName, string LastName, string Phone, string Email, string Password,int Permissions)
        {

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert into Users (UserName,FirstName,LastName,Phone,Email,Password,Permissions)
                            values
                                  (@UserName,@FirstName,@LastName,@Phone,@Email,@Password,@Permissions);
                                   Select SCOPE_IDENTITY();  ";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Phone", Phone);           
            Command.Parameters.AddWithValue("@Email", Email);
           
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@Permissions", Permissions);

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
            catch{ }

            finally
            {
                Connection.Close();
            }

            return -1;
        }
        public static bool DeleteUser(string UserName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Delete from Users Where UserName=@UserName";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue(@"UserName", UserName);

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
        public static bool UpdateUser(string UserName,string FirstName, string LastName, string Phone, string Email, string Password, int Permissions)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update Users 
                          set UserName=@UserName,
                              FirstName=@FirstName,
                              LastName=@LastName,
                               Phone=@Phone,
                               Email=@Email,
                               Password=@Password,
                               Permissions=@Permissions
                                Where UserName=@UserName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Phone", Phone);         
            Command.Parameters.AddWithValue("@Email", Email);            
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@Permissions", Permissions);

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
        public static bool IsExist(string UserName)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select Exist=1 from Users where UserName=@UserName";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);

            bool IsFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
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
