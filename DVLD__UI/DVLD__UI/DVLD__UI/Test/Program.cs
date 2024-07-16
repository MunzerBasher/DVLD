using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        private static string connectionString = "Server=.;Database=DVLD;User" +
               " Id=sa;Password=sa123456;";
      
        public static bool AddPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
        DateTime DateOfBirth, int Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            string Query = @"INSERT INTO People(NationalNo,FirstName,SecondName,ThirdName,LastName,
            DateOfBirth,Gender,Address,Phone,Email,NationalityCountryID,ImagePath)
            VALUES(@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,
            @Gender,@Address,@Phone,@Email,@NationalityCountryID,@ImagePath)";
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
            int row = 0;
            try
            {
                connection.Open();
                row = cmd.ExecuteNonQuery();

            }
            catch(Exception ex) { Console.WriteLine("Erorr + " + ex); }
            finally { connection.Close(); }
            return row > 0;
        }
        static void Main(string[] args)
        {
            bool value = Program.AddPerson("1", "2", "3", "4", "5", DateTime.Now,1,"q","q","q",1,"kk");
            if (value) 
            {
                Console.WriteLine("kkkkkkkkk ");
            }
            Console.WriteLine("nnnnnnnn ");
            Console.ReadKey();
        }
    }
}
