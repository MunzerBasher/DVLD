

using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class Countries
    {


        public static int GetCountryID(string countryName)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT CountryID FROM Countries WHERE CountryName = @countryName";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@countryName", countryName);
            int CountryID = 1;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                { CountryID = (int)reader[0]; }
            }
            catch { }
            finally { connection.Close(); }
            return CountryID;
        }

        public static string GetCountryName(int CountryID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT CountryName FROM Countries WHERE CountryID = @CountryID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@CountryID", CountryID);
            string CountryName = "";
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                { CountryName = (string)reader[0]; }
            }
            catch { }
            finally { connection.Close(); }
            return CountryName;
        }

        public static DataTable GeTAllCountries()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = @"SELECT CountryName FROM Countries";
            SqlCommand cmd = new SqlCommand(Query, connection);
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


    }
}