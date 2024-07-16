using System.Data;

using DVLD_DataAccess;

namespace DVLD_Buisness
{
    public class clsLicenseClasses
    {
        public static DataTable GetAllLicenseClasses()
        {
            return LicenseClasses.GetAllLicenseClasses();
        }

        public static int GetLicenseFees(int LicenseClassID)
        {
            return LicenseClasses.GetLicenseFees(LicenseClassID);
        }

        public static int GetLicenseClassID(string ClassName)
        {
            return LicenseClasses.GetLicenseClassID(ClassName);
        }

        public static string GetLicenseClassName(int LicenseClassID)
        {
            return LicenseClasses.GetLicenseClassName(LicenseClassID);
        }
    }
}