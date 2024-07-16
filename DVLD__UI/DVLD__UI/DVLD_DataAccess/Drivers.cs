using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_DataAccess
{
    public class Drivers
    {
        public static int GetPersonID(int DriverID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT PersonID FROM  Drivers WHERE DriverID = @DriverID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            int PersonID = 0;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                { PersonID = (int)reader[0]; }
            }
            catch { }
            finally { connection.Close(); }
            return PersonID;
        }

        public static int GetDriverExpirationDate(int DriverID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT CreatedDate FROM  Drivers WHERE DriverID = @DriverID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            int PersonID = 0;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                { PersonID = (int)reader[0]; }
            }
            catch { }
            finally { connection.Close(); }
            return PersonID;
        }

        public static int AddDriver(int PersonID, int UserID, DateTime Date)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = @"INSERT INTO Drivers(PersonID,CreatedByUserID,CreatedDate)
        VALUES(@PersonID,@UserID,@Date);SELECT SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@Date", Date);
            int DriverID = 0;
            try
            {
                connection.Open();
                object _ID = cmd.ExecuteScalar();
                if (_ID != null)
                {
                    DriverID = int.Parse(_ID.ToString());
                }
            }
            catch { }
            finally { connection.Close(); }
            return DriverID;
        }

        public static DataTable GetDriverByID(int DriverID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT * FROM Drivers_View WHERE DriverID = @DriverID ";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }
            catch { }
            finally { connection.Close(); }
            return dataTable;
        }

        public static int GetDriverCreatedByUserID(int DriverID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT CreatedByUserID FROM  Drivers WHERE DriverID = @DriverID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            int PersonID = 0;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                { PersonID = (int)reader[0]; }
            }
            catch { }
            finally { connection.Close(); }
            return PersonID;
        }

        public static DataTable GetDrivers()
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT * FROM Drivers_View  ";
            SqlCommand cmd = new SqlCommand(Query, connection);
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }
            catch { }
            finally { connection.Close(); }
            return dataTable;
        }

        public static bool CheckActivation(int DriverID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT FOUND=1 WHERE EXISTS(SELECT DriverID " +
            "FROM Licenses WHERE DriverID=@DriverID AND IsActive=@IsActive)";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@IsActive", 1);
            int NationalNoID = 0;
            try
            {
                connection.Open();
                object value = cmd.ExecuteScalar();
                if (value != null && int.TryParse(value.ToString(), out int value2))
                {
                    NationalNoID = value2;
                }
            }
            catch { }
            finally { connection.Close(); }
            return NationalNoID != 0;
        }

        public static bool CheckPersonID(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT FOUND=1 WHERE EXISTS(SELECT DriverID " +
            "FROM Drivers WHERE PersonID=@PersonID)";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            int NationalNoID = 0;
            try
            {
                connection.Open();
                object value = cmd.ExecuteScalar();
                if (value != null && int.TryParse(value.ToString(), out int value2))
                {
                    NationalNoID = value2;
                }
            }
            catch { }
            finally { connection.Close(); }
            return NationalNoID != 0;
        }

        public static int GetDriverID(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT DriverID FROM  Drivers WHERE PersonID = @PersonID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            int DriverID = 0;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                { DriverID = (int)reader[0]; }
            }
            catch { }
            finally { connection.Close(); }
            return DriverID;
        }

    }
}