
using System.Data;

using DVLD_DataAccess;

namespace DVLD_Buisness
{

    public class clsCountries
    {

        public static int GetCountryID(string countryName)
        {
            return Countries.GetCountryID(countryName);
        }


        public static string GetCountryName(int CountryID)
        {
            return Countries.GetCountryName(CountryID);
        }

        public static DataTable GetAllCountries()
        {
            return Countries.GeTAllCountries();
        }

    }
}