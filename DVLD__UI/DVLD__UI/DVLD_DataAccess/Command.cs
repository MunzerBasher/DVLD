using System.Data;

namespace DVLD_DataAccess
{

    public class clsCommand
    {

        private static string connectionString = "Server=.;Database=DVLD;User" +
                   " Id=sa;Password=sa123456;";

        public static string ConnectionString()
        {
            return connectionString;
        }

    }

}