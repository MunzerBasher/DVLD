
using System.Data.SqlClient;
using System.Data;

namespace DVLD_DataAccess
{
    public class ApplicationTypes
    {

        public static DataTable GetAllApplicationTypes()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT *FROM  ApplicationTypes  ";
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

        public static bool UpdateApplicationTypes(int ApplicationTypeID, string ApplicationTypeTitle, int ApplicationFees)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "@UPDATE ApplicationTypes SET ApplicationTypeTitle=@ApplicationTypeTitle," +
            "ApplicationFees=@ApplicationFees WHERE ApplicationTypeID = @ApplicationTypeID ";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            cmd.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
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


        public static DataTable FindApplicationTypeByID(int ApplicationTypesID)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT *FROM  ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypesID ";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@ApplicationTypesID", ApplicationTypesID);
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

        public static string GetApplicationTypeTitle(int ApplicationTypeID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT ApplicationTypeTitle FROM ApplicationTypes WHERE ApplicationTypeID=@ApplicationTypeID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            string ApplicationTypeTitle = string.Empty;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) { ApplicationTypeTitle = (string)reader[0]; }
            }
            catch { }
            finally { connection.Close(); }
            return ApplicationTypeTitle;
        }


    }
}