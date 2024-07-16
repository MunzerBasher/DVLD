using System.Data.SqlClient;
using System.Data;


namespace DVLD_DataAccess
{
    public class LicenseClasses
    {
        public static DataTable GetAllLicenseClasses()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT ClassName FROM  LicenseClasses  ";
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

        public static int GetLicenseFees(int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT ClassFees FROM LicenseClasses WHERE LicenseClassID=@LicenseClassID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID + 1);
            int Fees = 0;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) { Fees = (int)reader[0]; }
            }
            catch { }
            finally { connection.Close(); }
            return Fees;
        }

        public static int GetLicenseClassID(string ClassName)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT LicenseClassID FROM LicenseClasses WHERE ClassName=@ClassName";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@ClassName", ClassName);
            int ClassID = 0;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) { ClassID = (int)reader[0]; }
            }
            catch { }
            finally { connection.Close(); }
            return ClassID;
        }

        public static string GetLicenseClassName(int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT ClassName FROM LicenseClasses WHERE LicenseClassID=@LicenseClassID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            string LicenseClassName = string.Empty;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) { LicenseClassName = (string)reader[0]; }
            }
            catch { }
            finally { connection.Close(); }
            return LicenseClassName;
        }


    }
}