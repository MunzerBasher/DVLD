
using System.Data.SqlClient;
using System.Data;


namespace DVLD_DataAccess
{
    public class Users
    {

        public static DataTable GetAllUsers()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT *FROM  UsersView  ";
            SqlCommand cmd = new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    dataTable.Load(reader);
            }
            catch { }
            finally { connection.Close(); }
            return dataTable;
        }

        public static int AddUsers(int PersonID, string UserName, string Password, bool IsActive)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = @"INSERT INTO Users(PersonID,UserName,Password,IsActive)
        VALUES(@PersonID,@UserName,@Password,@IsActive);SELECT SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            int UserID = 0;
            try
            {
                connection.Open();
                object iD = cmd.ExecuteScalar();
                if (iD != null) { UserID = int.Parse(iD.ToString()); }
            }
            catch { }
            finally { connection.Close(); }
            return UserID;
        }

        public static bool UpdateUser(int UserID, string UserName, string Password, bool IsActive)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = @"UPDATE Users SET UserName=@UserName,
            Password=@Password,IsActive=@IsActive WHERE UserID =@UserID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            int row = 0;
            try
            {
                connection.Open();
                row = cmd.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }
            return row > 0;
        }

        public static bool DeleteUser(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = @"DELETE FROM Users WHERE UserID=@UserID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            int row = 0;
            try
            {
                connection.Open();
                row = cmd.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }
            return row > 0;
        }

        public static DataTable FindUser(int UserID)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT *FROM  Users WHERE  UserID = @UserID ";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    dataTable.Load(reader);
            }
            catch { }
            finally { connection.Close(); }
            return dataTable;
        }

        public static DataTable FindUser(string UserName, string Password)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT*FROM Users WHERE UserName=@UserName and Password=@Password";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    dataTable.Load(reader);
            }
            catch { }
            finally { connection.Close(); }
            return dataTable;
        }

        public static string GetUserPassword(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT Password FROM  Users WHERE  UserID = @UserID ";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            string Password = "";
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                { Password = (string)reader["Password"]; }
            }
            catch { }
            finally { connection.Close(); }
            return Password;
        }

        public static string GetUserName(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT UserName FROM  Users WHERE  UserID = @UserID ";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            string UserName = "";
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                { UserName = (string)reader[0]; }
            }
            catch { }
            finally { connection.Close(); }
            return UserName;
        }

        public static DataTable FindUsers(string Column, string value)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = $"Select * from UsersView where {Column} like '{value}%'";
            SqlCommand cmd = new SqlCommand(Query, connection);
         
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    dataTable.Load(reader);
            }
            catch { }
            finally { connection.Close(); }
            return dataTable;
        }

        public static DataTable FindUsers(string Column, int value)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = $"Select * from UsersView where {Column} ={value}";
            SqlCommand cmd = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    dataTable.Load(reader);
            }
            catch { }
            finally { connection.Close(); }
            return dataTable;
        }

    }

}