using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_DataAccess
{
    public class Appointments
    {

        public static bool AddAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, int PaidFees, int CreatedByUserID, int IsLocked)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = @"INSERT INTO TestAppointments(TestTypeID,LocalDrivingLicenseApplicationID,
        AppointmentDate,PaidFees,CreatedByUserID,IsLocked)VALUES(@TestTypeID,
        @LocalDrivingLicenseApplicationID,@AppointmentDate,@PaidFees,@CreatedByUserID,@IsLocked)";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@IsLocked", IsLocked);
            int Rows = 0;
            try
            {
                connection.Open();
                Rows = cmd.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }
            return Rows > 0;
        }

        public static bool DeleteAppointment(int AppointmentID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = @"DELETE FROM TestAppointments WHERE TestAppointmentID=@AppointmentID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@AppointmentID", AppointmentID);
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

        public static bool UpdateAppointment(int AppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, int PaidFees, int CreatedByUserID, int IsLocked)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = @"UPDATE TestAppointments SET TestTypeID=@TestTypeID,
        LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID,
        AppointmentDate=@AppointmentDate,PaidFees=@PaidFees,CreatedByUserID=
        @CreatedByUserID,IsLocked=@IsLocked WHERE TestAppointmentID=@AppointmentID ";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@IsLocked", IsLocked);
            int Rows = 0;
            try
            {
                connection.Open();
                Rows = cmd.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }
            return Rows > 0;
        }

        public static bool UpdateAppointmentDate(int AppointmentID, DateTime AppointmentDate)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = @"UPDATE TestAppointments SET 
        AppointmentDate=@AppointmentDate WHERE TestAppointmentID=@AppointmentID ";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);

            int Rows = 0;
            try
            {
                connection.Open();
                Rows = cmd.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }
            return Rows > 0;
        }

        public static DataTable GetAllAppointments(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT TestAppointmentID,AppointmentDate,PaidFees,IsLocked FROM " +
            "TestAppointments WHERE (LocalDrivingLicenseApplicationID=" +
            "@LocalDrivingLicenseApplicationID AND TestTypeID=@TestTypeID)";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
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

        public static int GetLocalDrivingLicenseApplicationID(int TestAppointmentID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT LocalDrivingLicenseApplicationID FROM TestAppointments " +
                "WHERE TestAppointmentID=@TestAppointmentID ";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            int LocalDrivingLicenseApplicationID = 1;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                { LocalDrivingLicenseApplicationID = (int)reader[0]; }
            }
            catch { }
            finally { connection.Close(); }
            return LocalDrivingLicenseApplicationID;
        }

        public static DateTime GetAppointmentDate(int TestAppointmentID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT AppointmentDate FROM TestAppointments " +
                "WHERE TestAppointmentID=@TestAppointmentID ";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            DateTime AppointmentDate = DateTime.Now;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                { AppointmentDate = (DateTime)reader[0]; }
            }
            catch { }
            finally { connection.Close(); }
            return AppointmentDate;
        }


        public static DataTable FindAppointment(int _AppointmentID)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT * FROM TestAppointments WHERE TestAppointmentID=@AppointmentID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@AppointmentID", _AppointmentID);
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

        public static bool CheckExistsAppointment(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT FOUND=1 WHERE EXISTS(SELECT TestAppointmentID " +
            "FROM TestAppointments WHERE TestTypeID=@TestTypeID AND " +
            "LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID)";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
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

        public static int GetAppointmentID(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT TestAppointmentID " + "FROM TestAppointments WHERE " +
            "TestTypeID=@TestTypeID AND " + "LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
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