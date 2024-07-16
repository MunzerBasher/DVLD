using System;
using System.Data;


using DVLD_DataAccess;

namespace DVLD_Buisness
{
    public class clsDrivers
    {
        public int DriverID
        { get; set; }
        public string DriverName
        { get; set; }
        public int PersonID
        { get; set; }
        public string PersonNationalNo
        { get; set; }
        public string CreatedDate
        { get; set; }
        public int NumberOfActiveLicense
        { get; set; }


        public static int GetPersonID(int DriverID)
        {
            return Drivers.GetPersonID(DriverID);
        }

        public static int GetDriverCreatedByUserID(int DriverID)
        {
            return Drivers.GetDriverCreatedByUserID(DriverID);
        }

        public static int GetDriverExpirationDate(int DriverID)
        {
            return Drivers.GetDriverExpirationDate(DriverID);
        }

        public static int AddDriver(int PersonID, int UserID, DateTime Date)
        {
            return Drivers.AddDriver(PersonID, UserID, Date);
        }

        private static clsDrivers _ConvertToClsDrivers(int LicenseID)
        {
            DataTable dataTable = Drivers.GetDriverByID(LicenseID);
            clsDrivers _Driver = new clsDrivers();
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    _Driver.DriverID = (int)row[0];
                    _Driver.PersonID = (int)row[1];
                    _Driver.PersonNationalNo = (string)row[2];
                    _Driver.DriverName = (string)row[3];
                    _Driver.CreatedDate = ((DateTime)row[4]).ToString();
                    _Driver.NumberOfActiveLicense = (int)row[5];
                    return _Driver;
                }
            }
            return null;
        }



        public static clsDrivers GetDriverByID(int DriverID)
        {
            return _ConvertToClsDrivers(DriverID);
        }


        public static DataTable GetDrivers()
        {
            return Drivers.GetDrivers();
        }


        public static bool CheckActivation(int DriverID)
        {
            return Drivers.CheckActivation(DriverID);
        }

        public static bool CheckPersonID(int PersonID)
        {
            return Drivers.CheckPersonID(PersonID);
        }


        public static int GetDriverID(int PersonID)
        {
            return Drivers.GetDriverID(PersonID);
        }



    }
}