using System.Data.SqlClient;



namespace DVLD_DataAccess
{
    public class Tests
    {
        public static bool AddTest(int TestAppointmentID, int TestResult, string Notes, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "INSERT INTO Tests(TestAppointmentID,TestResult,Notes,CreatedByUserID)" +
             "VALUES(@TestAppointmentID,@TestResult,@Notes,@CreatedByUserID)";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@TestResult", TestResult);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            int Rows = 0;
            try
            {
                if (Notes == "")
                    cmd.Parameters.AddWithValue("@Notes", System.DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@Notes", Notes);
                connection.Open();
                Rows = cmd.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }
            return Rows != 0;
        }

        public static bool UpdateLockedAppointment(int TestAppointmentID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "UPDATE  TestAppointments SET IsLocked =@Locked WHERE TestAppointmentID=@TestAppointmentID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@Locked", 1);
            int Rows = 0;
            try
            {
                connection.Open();
                Rows = cmd.ExecuteNonQuery();

            }
            catch { }
            finally { connection.Close(); }
            return Rows != 0;
        }


        public static bool CheckExistsAppointment(int TestAppointmentID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT FOUND=1 WHERE EXISTS(SELECT TestAppointmentID " +
            "FROM Tests WHERE TestAppointmentID=@TestAppointmentID)";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
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

        public static int GetTestID(int TestAppointmentID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT TestID FROM Tests WHERE TestAppointmentID=@AppointmentID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            int NationalNoID = 0;
            try
            {
                connection.Open();
                object value = cmd.ExecuteScalar();
                if (value != null) { NationalNoID = int.Parse(value.ToString()); }

            }
            catch { }
            finally { connection.Close(); }
            return NationalNoID;
        }

        public static int GetTestResultID(int TestAppointmentID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT TestResult FROM Tests WHERE TestAppointmentID=@TestAppointmentID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            int NationalNoID = 0;
            try
            {
                connection.Open();
                object value = cmd.ExecuteScalar();
                if (value != null) { NationalNoID = int.Parse(value.ToString()); }

            }
            catch { }
            finally { connection.Close(); }
            return NationalNoID;
        }

    }
} 