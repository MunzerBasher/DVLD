


using System.Data.SqlClient;
using System.Data;


namespace DVLD_DataAccess
{
    public class TestTypes
    {
        public static DataTable GetAllTestTypes()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT *FROM  TestTypes  ";
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

        public static DataTable FindTestTypeByID(int TestTypeID)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT *FROM  TestTypes WHERE TestTypeID = @TestTypeID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
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

        public static bool UpdateTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, int TestTypeFees)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "UPDATE TestTypes SET TestTypeTitle=@TestTypeTitle,TestTypeDescription=@TestTypeDescription," +
                "TestTypeFees=@TestTypeFees WHERE TestTypeID=@TestTypeID";
            SqlCommand cmd = new SqlCommand(@Query, connection);
            int rows = 0;
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            cmd.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            cmd.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
            try
            {
                connection.Open();
                rows = cmd.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }
            return rows > 0;
        }

    }

}