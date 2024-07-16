
using System.Data.SqlClient;
using System.Data;
using System;


namespace DVLD_DataAccess
{

    public class People
    {
        public static int AddPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
            DateTime DateOfBirth, int Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int Person = 0;
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = @"INSERT INTO People(NationalNo,FirstName,SecondName,ThirdName,LastName,
            DateOfBirth,Gender,Address,Phone,Email,NationalityCountryID,ImagePath)
            VALUES(@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,
            @Gender,@Address,@Phone,@Email,@NationalityCountryID,@ImagePath);SELECT SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);
            cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            try
            {
                connection.Open();
                object row = cmd.ExecuteScalar();
                if (row != null) { Person = int.Parse(row.ToString()); }

            }
            catch { }
            finally { connection.Close(); }
            return Person;
        }

        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
            DateTime DateOfBirth, int Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = @"UPDATE People SET NationalNo = @NationalNo,FirstName = @FirstName,
        SecondName = @SecondName,ThirdName = @ThirdName,LastName = @LastName,DateOfBirth = @DateOfBirth, 
        Gender = @Gender,Address = @Address,Phone = @Phone,Email = @Email,NationalityCountryID
            = @NationalityCountryID ,ImagePath = @ImagePath WHERE PersonID = @PersonID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);
            cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
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
        public static bool DeletePerson(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = @"DELETE FROM People WHERE PersonID = @PersonID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
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

        public static int FindPersonNationalityCountryID(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT NationalityCountryID FROM People WHERE PersonID = @PersonID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            int NationalityCountryID = 1;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                { NationalityCountryID = reader.GetInt32(0); }

            }
            catch { }
            finally { connection.Close(); }
            return NationalityCountryID;
        }

        public static bool CheckExistsNationalNo(string NationalNo)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT FOUND = 1 WHERE EXISTS (SELECT NationalNo FROM People WHERE NationalNo = @NationalNo)";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            int NationalNoID = 0;
            try
            {
                connection.Open();
                object value = cmd.ExecuteScalar();
                if (value != null) { NationalNoID = int.Parse(value.ToString()); }

            }
            catch { }
            finally { connection.Close(); }
            return NationalNoID != 0;
        }

        public static DataTable FindPerson(int PersonID)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "Select * from People where PersonID=@PersonID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
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

        public static DataTable FindPeople(string Column, string value)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = $"Select * from People where {Column} like '{value}%'";
            SqlCommand cmd = new SqlCommand(Query, connection);
            //cmd.Parameters.AddWithValue("@value", value);
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


        public static DataTable FindPerson(string NationalNo)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT * FROM People WHERE NationalNo = @NationalNo";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
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

        public static DataTable GetAllPeople()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT *FROM People";
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

        public static bool CheckExistsPersonID(string NationalNo)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT PersonID FROM  People WHERE  NationalNo = @NationalNo ";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
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
            return PersonID > 0;
        }

        public static string GetPersonNationalNo(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "Select NationalNo from People where PersonID=@PersonID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            string Password = "";
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                { Password = (string)reader[0]; }
            }
            catch { }
            finally { connection.Close(); }
            return Password;
        }

        public static string GetPersonImagePath(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "Select ImagePath from People where PersonID=@PersonID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            string Password = "";
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    object value = (object)reader[0];
                    if (value != System.DBNull.Value)
                    {
                        Password = value.ToString();
                    }

                }
            }
            catch { }
            finally { connection.Close(); }
            return Password;
        }


        public static int GetPersonIDByNationalNo(string NationalNo)
        {
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "Select PersonID from People where NationalNo=@NationalNo";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
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


        public static DataTable GetPersonDetainLicense(int PersonID)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsCommand.ConnectionString());
            string Query = "SELECT * FROM PersonDetainLicense WHERE PersonID=@PersonID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
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