using DVLD_DataAccess;
using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_DataAccess
{
    public class Applications
    {
        public static int AddApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID
        , int ApplicationStatus, DateTime LastStatusDate, int PaidFees, int CreatedByUserID)
        {
            int ApplicationID = 1;
            SqlConnection Connection = new SqlConnection(clsCommand.ConnectionString());

            string Query = "INSERT INTO Applications(ApplicantPersonID,ApplicationDate," +
                "ApplicationTypeID,ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID)" +
                "VALUES(@ApplicantPersonID,@ApplicationDate,@ApplicationTypeID,@ApplicationStatus," +
                "@LastStatusDate,@PaidFees,@CreatedByUserID);SELECT SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            cmd.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                Connection.Open();
                object row = cmd.ExecuteScalar();
                if (row != null) { ApplicationID = int.Parse(row.ToString()); }
            }
            catch { }
            finally { Connection.Close(); }
            return ApplicationID;
        }

        public static DataTable FindApplication(int ApplicationID)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT *FROM Applications where ApplicationID = @ApplicationID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
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

        public static string GetApplicationStatusTitle(int LocalDrivingLicenseApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT Status FROM LocalDrivingLicenseApplications_View WHERE LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            string Title = string.Empty;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) { Title = (string)reader[0]; }
            }
            catch { }
            finally { connection.Close(); }
            return Title;
        }

        public static int GetPassedTest(int LocalDrivingLicenseApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT PassedTestCount FROM LocalDrivingLicenseApplications_View WHERE LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            int PassedTestCount = 0;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) { PassedTestCount = (int)reader[0]; }
            }
            catch { }
            finally { connection.Close(); }
            return PassedTestCount;
        }

        public static string GetApplicationApplicant(int LocalDrivingLicenseApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT FullName FROM LocalDrivingLicenseApplications_View WHERE LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            string FullName = "";
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) { FullName = (string)reader[0]; }
            }
            catch { }
            finally { connection.Close(); }
            return FullName;
        }

        public static bool UpdateApplicationStatus(int ApplicationID, int ApplicationStatusID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "UPDATE Applications SET ApplicationStatus=@ApplicationStatusID where ApplicationID=@ApplicationID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@ApplicationStatusID", ApplicationStatusID);
            int rows = 0;
            try
            {
                connection.Open();
                rows = cmd.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }
            return rows > 0;
        }

        public static DateTime GetApplicationDate(int ApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT ApplicationDate FROM Applications " +
            "WHERE ApplicationID=@ApplicationID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            DateTime ApplicationDate = DateTime.Now;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) { ApplicationDate = (DateTime)reader[0]; }
            }
            catch { }
            finally { connection.Close(); }
            return ApplicationDate;
        }


        public class LocalDrivingLicenseApplications
        {
            public static DataTable GetAllLocalDrivingLicenseApplications()
            {
                DataTable dataTable = new DataTable();
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "SELECT *FROM LocalDrivingLicenseApplications_View";
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

            public static DataTable GetLocalDrivingLicenseApplicationByID(int LocalDrivingLicenseApplicationID)
            {
                DataTable dataTable = new DataTable();
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "SELECT * FROM  LocalDrivingLicenseApplications " +
                "WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
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


            public static bool AddLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID)
            {
                SqlConnection Connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "INSERT INTO LocalDrivingLicenseApplications(ApplicationID,LicenseClassID)" +
                    "VALUES(@ApplicationID,@LicenseClassID)";
                SqlCommand cmd = new SqlCommand(Query, Connection);
                cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                int rows = 0;
                try
                {
                    Connection.Open();
                    rows = cmd.ExecuteNonQuery();
                }
                catch { }
                finally { Connection.Close(); }
                return rows > 0;
            }

            public static DataTable FindLocalDrivingLicenseApplication(int ApplicationID)
            {
                DataTable dataTable = new DataTable();
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "SELECT *FROM LocalDrivingLicenseApplications " +
                    "WHERE LocalDrivingLicenseApplicationID = @ApplicationID";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
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


            public static bool CheckAbilityToAddClient(string LicenseClass, string NationalNo)
            {
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "SELECT FOUND=1 WHERE EXISTS(SELECT LocalDrivingLicenseApplicationID " +
                    "FROM LocalDrivingLicenseApplications_View WHERE NationalNo=@NationalNo AND " +
                    "ClassName=@LicenseClass AND Status <> @Status)";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
                cmd.Parameters.AddWithValue("@LicenseClass", LicenseClass);
                cmd.Parameters.AddWithValue("@Status", "COMPLETE");
                int Found = 0;
                try
                {
                    connection.Open();
                    object value = cmd.ExecuteScalar();
                    if (value != null && int.TryParse(value.ToString(), out int value2))
                    {
                        Found = value2;
                    }
                }
                catch { }
                finally { connection.Close(); }
                return Found != 0;
            }

            public static int GetApplicationID(int LocalDrivingLicenseApplicationID)
            {
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "SELECT ApplicationID FROM LocalDrivingLicenseApplications " +
                "WHERE LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                int PassedTestCount = 0;
                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read()) { PassedTestCount = (int)reader[0]; }
                }
                catch { }
                finally { connection.Close(); }
                return PassedTestCount;
            }


            public static int GetLocalDrivingLicenseApplicationID(int ApplicationID)
            {
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "SELECT LocalDrivingLicenseApplicationID FROM LocalDrivingLicenseApplications " +
                "WHERE ApplicationID=@ApplicationID";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                int PassedTestCount = 0;
                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read()) { PassedTestCount = (int)reader[0]; }
                }
                catch { }
                finally { connection.Close(); }
                return PassedTestCount;
            }

        }


    }
}