using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_DataAccess
{
    public class Licenses
    {

        public static bool AddLicense(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, int PaidFees, int IsActive, int IssueReason, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "INSERT INTO Licenses(ApplicationID,DriverID,LicenseClass,IssueDate," +
            "ExpirationDate,Notes,PaidFees,IsActive,IssueReason,CreatedByUserID)" +
            "VALUES(@ApplicationID,@DriverID,@LicenseClass,@IssueDate,@ExpirationDate,@Notes," +
            "@PaidFees,@IsActive,@IssueReason,@CreatedByUserID)";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            int row = 0;
            try
            {
                if (Notes == "")
                    cmd.Parameters.AddWithValue("@Notes", System.DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@Notes", Notes);
                connection.Open();
                row = cmd.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }
            return row > 0;
        }


        public static int AddLicenses(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, int PaidFees, int IsActive, int IssueReason, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "INSERT INTO Licenses(ApplicationID,DriverID,LicenseClass,IssueDate," +
            "ExpirationDate,Notes,PaidFees,IsActive,IssueReason,CreatedByUserID)" +
            "VALUES(@ApplicationID,@DriverID,@LicenseClass,@IssueDate,@ExpirationDate,@Notes," +
            "@PaidFees,@IsActive,@IssueReason,@CreatedByUserID);SELECT SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            int LicenseID = 0;
            try
            {
                if (Notes == "")
                    cmd.Parameters.AddWithValue("@Notes", System.DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@Notes", Notes);
                connection.Open();
                object row = cmd.ExecuteScalar();
                if (row != null)
                {
                    LicenseID = int.Parse(row.ToString());
                }
            }
            catch { }
            finally { connection.Close(); }
            return LicenseID;
        }


        public static DataTable GetLicense(int LicenseID)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT * FROM Licenses WHERE LicenseID=@LicenseID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
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

        public static bool CheckExistsLicenseID(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT FOUND=1 WHERE EXISTS(SELECT LicenseID " +
            "FROM Licenses WHERE LicenseID=@LicenseID)";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
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

        public static bool CheckExistsDriverID(int DriverID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT FOUND=1 WHERE EXISTS(SELECT LicenseID " +
            "FROM Licenses WHERE DriverID=@DriverID)";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
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

        public static bool UpdateLicenseActivationByDriverID(int DriverID, int IsActive)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "UPDATE Licenses SET IsActive = @IsActive WHERE DriverID=@DriverID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
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

        public static bool CheckLicenseIDIsReleased(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT FOUND = 1 WHERE EXISTS(SELECT LicenseID " +
            "FROM DetainedLicenses WHERE LicenseID=@LicenseID AND IsReleased=0)";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            int IsReleased = 0;
            try
            {
                connection.Open();
                object value = cmd.ExecuteScalar();
                if (value != null && int.TryParse(value.ToString(), out int value2))
                {
                    IsReleased = value2;
                }
            }
            catch { }
            finally { connection.Close(); }
            return IsReleased != 0;
        }

        public static int GetApplicationID(int LocalDrivingLicenseApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT ApplicationID FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID ";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            int ApplicationID = 0;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                { ApplicationID = (int)reader[0]; }
            }
            catch { }
            finally { connection.Close(); }
            return ApplicationID;
        }

        public static int GetApplicationIDByDriverID(int DriverID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT ApplicationID FROM Licenses WHERE DriverID = @DriverID ";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            int ApplicationID = 0;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                { ApplicationID = (int)reader[0]; }
            }
            catch { }
            finally { connection.Close(); }
            return ApplicationID;
        }


        public static int GetLicenseID(int ApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT LicenseID FROM Licenses WHERE ApplicationID = @ApplicationID ";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            int LicenseID = 0;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                { LicenseID = (int)reader[0]; }
            }
            catch { }
            finally { connection.Close(); }
            return LicenseID;
        }

        public static int GetLicenseIDByDriverID(int DriverID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT LicenseID FROM Licenses WHERE DriverID = @DriverID ";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            int LicenseID = 0;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                { LicenseID = (int)reader[0]; }
            }
            catch { }
            finally { connection.Close(); }
            return LicenseID;
        }


        public static int GetDriverID(int ApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT DriverID FROM Licenses WHERE ApplicationID = @ApplicationID ";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
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



        public static bool CheckExistsApplicationID(int ApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT FOUND=1 WHERE EXISTS(SELECT ApplicationID " +
            "FROM Licenses WHERE ApplicationID=@ApplicationID)";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
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


        public static DataTable GetLicenseByApplicationID(int ApplicationID)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT * FROM Licenses WHERE ApplicationID=@ApplicationID";
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


        public static DataTable GetLocalLicensesHistory(int DriverID)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT LicenseID,ApplicationID,LicenseClass,IssueDate," +
                "ExpirationDate,IsActive FROM Licenses WHERE DriverID=@DriverID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
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






        public class DetainedLicenses
        {
            public static DataTable GetAllDetainedLicenses()
            {
                DataTable dataTable = new DataTable();
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "SELECT *FROM  DetainedLicenses  ";
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

            public static int DetainedLicense(int LicenseID, DateTime DetainDate, int FineFees, int CreatedByUserID, string guid)
            {
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "INSERT INTO DetainedLicenses(LicenseID,DetainDate,FineFees," +
                "CreatedByUserID,IsReleased,ReleaseDate,ReleasedByUserID,ReleaseApplicationID,Guid)" +
                "VALUES(@LicenseID,@DetainDate,@FineFees,@CreatedByUserID,@IsReleased," +
                "@ReleaseDate,@ReleasedByUserID,@ReleaseApplicationID,@Guid);SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
                cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
                cmd.Parameters.AddWithValue("@FineFees", FineFees);
                cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                cmd.Parameters.AddWithValue("IsReleased", 0);
                cmd.Parameters.AddWithValue("@ReleaseDate", System.DBNull.Value);
                cmd.Parameters.AddWithValue("@ReleasedByUserID", System.DBNull.Value);
                cmd.Parameters.AddWithValue("@ReleaseApplicationID", System.DBNull.Value);
                cmd.Parameters.AddWithValue("@Guid", guid);
                int DetainID = 0;
                try
                {
                    connection.Open();
                    object row = cmd.ExecuteScalar();
                    if (row != null && int.TryParse(row.ToString(), out int value))
                    {
                        DetainID = value;
                    }

                }
                catch { }
                finally { connection.Close(); }
                return DetainID;
            }

            public static DataTable GetDetainIDAndDetainDate(int DetainID)
            {
                DataTable dataTable = new DataTable();
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "SELECT DetainID,DetainDate,FineFees " +
                    "FROM DetainedLicenses WHERE DetainID=@DetainID ";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@DetainID", DetainID);
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

            public static DataTable GetDetainIDAndDetainDateByLicenseID(int LicenseID)
            {
                DataTable dataTable = new DataTable();
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "SELECT DetainID,DetainDate,FineFees " +
                    "FROM DetainedLicenses WHERE LicenseID=@LicenseID ";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
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

            public static DataTable GetDetainDateByLicenseID(int LicenseID)
            {
                DataTable dataTable = new DataTable();
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "SELECT DetainDate FROM DetainedLicenses WHERE LicenseID=@LicenseID ";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
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

            public static DataTable DetainedLicensesInfo()
            {
                DataTable dataTable = new DataTable();
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "SELECT *FROM  DetainedLicensesInfo  ";
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

            public static DataTable DetainedLicensesHistory()
            {
                DataTable dataTable = new DataTable();
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "SELECT *FROM  TbDetainedLicensesHistory  ";
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

            public static DataTable ManageDetainedLicenses()
            {
                DataTable dataTable = new DataTable();
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "SELECT * FROM  DetainedLicensesHistory  WHERE IsReleased=0 ";
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

            public static int DetainedLicenseHistory(int LicenseID, int LicenseClass,
                string IssueDate, string ExpirationDate, int IsActive,
            string DetainDate, int IsReleased, string ReleasedDate)
            {
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "INSERT INTO TbDetainedLicensesHistory(LicenseID,LicenseClass,IssueDate" +
                ",ExpirationDate,IsActive,DetainDate,IsReleased,ReleasedDate)" +
                "VALUES(@LicenseID,@LicenseClass,@IssueDate,@ExpirationDate,@IsActive,@DetainDate," +
                "@IsReleased,@ReleasedDate);SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
                cmd.Parameters.AddWithValue("@LicenseClass", LicenseClass);
                cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
                cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                cmd.Parameters.AddWithValue("@IsActive", IsActive);
                cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
                cmd.Parameters.AddWithValue("IsReleased", IsReleased);

                int DetainID = 0;
                try
                {
                    if (ReleasedDate == "")
                        cmd.Parameters.AddWithValue("ReleasedDate", System.DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("ReleasedDate", ReleasedDate);

                    connection.Open();
                    object row = cmd.ExecuteScalar();
                    if (row != null && int.TryParse(row.ToString(), out int value))
                    {
                        DetainID = value;
                    }
                }
                catch { }
                finally { connection.Close(); }
                return DetainID;
            }

            public static bool UpDateLicenseHistory(int LicenseID, string guid, string ReleaseDate)
            {
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "UPDATE DetainedLicenses SET IsReleased=@IsReleased," +
                "ReleaseDate=@ReleaseDate WHERE  Guid=@guid";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@IsReleased", 1);
                cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
                cmd.Parameters.AddWithValue("@guid", guid);

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

            public static string GetReleaseLicenseDate(int LicenseID)
            {
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "SELECT ReleaseDate FROM DetainedLicenses WHERE LicenseID = @LicenseID ";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
                string ReleaseLicenseDate = DateTime.MinValue.ToString();
                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    { ReleaseLicenseDate = (string)reader[0]; }
                }
                catch { }
                finally { connection.Close(); }
                return ReleaseLicenseDate;
            }

            public static bool UpDateDetainedLicensesForReleased(int LicenseID, string guid, string ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
            {
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "UPDATE DetainedLicenses SET IsReleased=@IsReleased," +
                "ReleaseDate=@ReleaseDate,ReleasedByUserID=@ReleasedByUserID," +
                "ReleaseApplicationID=@ReleaseApplicationID WHERE Guid=@guid";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@IsReleased", 1);
                cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
                //cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
                cmd.Parameters.AddWithValue("@guid", guid);
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

            public static DataTable GetIssueDateAndLicenseClass(int LicenseID)
            {
                DataTable dataTable = new DataTable();
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "SELECT LicenseClass,IssueDate,ExpirationDate,IsActive FROM Licenses WHERE LicenseID=@LicenseID ";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
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

        public static DataTable GetInternationalLicensesHistory(int DriverID)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT InternationalLicenseID,ApplicationID,IssueDate,ExpirationDate,IsActive FROM InternationalLicenses WHERE DriverID=@DriverID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
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


        public class InternationalLicenses
        {

            public static bool CheckExistsDriverID(int DriverID)
            {
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "SELECT FOUND=1 WHERE EXISTS(SELECT DriverID " +
                "FROM InternationalLicenses WHERE DriverID=@DriverID)";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@DriverID", DriverID);
                int Driver = 0;
                try
                {
                    connection.Open();
                    object value = cmd.ExecuteScalar();
                    if (value != null && int.TryParse(value.ToString(), out int value2))
                    {
                        Driver = value2;
                    }
                }
                catch { }
                finally { connection.Close(); }
                return Driver != 0;
            }

            public static DataTable GetInternationalLicenseByDriverID(int DriverID)
            {
                DataTable dataTable = new DataTable();
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "SELECT * FROM InternationalLicenses WHERE DriverID=@DriverID ";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@DriverID", DriverID);
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

            public static int AddInternationalLicense(int ApplicationID, int DriverID,
            int IssuedUsingLocalLicenseID, DateTime IssueDate,
            DateTime ExpirationDate, int IsActive, int CreatedByUserID)
            {
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = @"INSERT INTO InternationalLicenses(ApplicationID,DriverID,
            IssuedUsingLocalLicenseID,IssueDate,ExpirationDate,IsActive,CreatedByUserID)
            VALUES(@ApplicationID,@DriverID,@IssuedUsingLocalLicenseID,@IssueDate,
            @ExpirationDate,@IsActive,@CreatedByUserID);SELECT SCOPE_IDENTITY()";
                SqlCommand cmd = new SqlCommand(Query, connection);
                int InternationalLicenseID = 0;
                cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                cmd.Parameters.AddWithValue("@DriverID", DriverID);
                cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
                cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
                cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                cmd.Parameters.AddWithValue("@IsActive", IsActive);
                cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                try
                {
                    connection.Open();
                    object row = cmd.ExecuteScalar();
                    if (row != null)
                    {
                        InternationalLicenseID = int.Parse(row.ToString());
                    }
                }
                catch { }
                finally { connection.Close(); }
                return InternationalLicenseID;
            }


            public static int GetInternationalLicenseID(int ApplicationID)
            {
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "SELECT InternationalLicenseID FROM InternationalLicenses WHERE ApplicationID = @ApplicationID ";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
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

            public static DataTable GetInternationalLicensesHistory(int DriverID)
            {
                DataTable dataTable = new DataTable();
                SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
                string Query = "SELECT InternationalLicenseID,ApplicationID,IssueDate,ExpirationDate,IsActive FROM InternationalLicenses WHERE DriverID=@DriverID";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@DriverID", DriverID);
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
}