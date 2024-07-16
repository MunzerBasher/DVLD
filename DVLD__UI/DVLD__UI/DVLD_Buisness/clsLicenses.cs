using System;
using System.Data;
using System.Runtime.Remoting.Messaging;

using DVLD_DataAccess;

namespace DVLD_Buisness
{
    public class clsLicenses
    {
        public int LicenseID
        { get; set; }
        public int ApplicationID
        { get; set; }
        public int DriverID
        { get; set; }
        public int LicenseClassID
        { get; set; }
        public DateTime IssueDate
        { get; set; }
        public DateTime ExpirationDate
        { get; set; }
        public string Node
        { get; set; }
        public int PaidFees
        { get; set; }
        public int IsActive
        { get; set; }
        public int IssueReason
        { get; set; }
        public int CreateBy
        { get; set; }

        public static bool AddLicense(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, int PaidFees, int IsActive, int IssueReason, int CreatedByUserID)
        {
            return Licenses.AddLicense(ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);

        }

        public static int AddLicenses(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, int PaidFees, int IsActive, int IssueReason, int CreatedByUserID)
        {
            return Licenses.AddLicenses(ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
        }

        public static DataTable GetInternationalLicensesHistory(int DriverID)
        {
            return Licenses.GetInternationalLicensesHistory(DriverID);
        }

        private static clsLicenses _ConvertToClsLicenses(int LicenseID)
        {
            DataTable dataTable = Licenses.GetLicense(LicenseID);
            clsLicenses _License = new clsLicenses();
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    _License.LicenseID = (int)row[0];
                    _License.ApplicationID = (int)row[1];
                    _License.DriverID = (int)row[2];
                    _License.LicenseClassID = (int)row[3];
                    _License.IssueDate = (DateTime)row[4];
                    _License.ExpirationDate = (DateTime)row[5];
                    _License.Node = (row[6] == System.DBNull.Value ? "" : (string)row[6]);
                    _License.PaidFees = (int)row[7];
                    _License.IsActive = (int)row[8];
                    _License.IssueReason = (int)row[9];
                    _License.CreateBy = (int)row[10];
                    return _License;
                }
            }
            return null;
        }

        public static clsLicenses GetLicenseByLicenseID(int LicenseID)
        {
            if (Licenses.CheckExistsLicenseID(LicenseID))
                return _ConvertToClsLicenses(LicenseID);
            return null;
        }



        public static DataTable GetLocalLicensesHistory(int DriverID)
        {
            bool value = Licenses.CheckExistsDriverID(DriverID);
            if (value)
            {
                return Licenses.GetLocalLicensesHistory(DriverID);
            }
            return null;
        }


        public static bool UpdateLicenseActivationByDriverID(int DriverID, int IsActive)
        {
            return Licenses.UpdateLicenseActivationByDriverID(DriverID, IsActive);
        }


        public static clsLicenses GetLicenseByApplicationID(int ApplicationID)
        {
            int LicenseID = Licenses.GetLicenseID(ApplicationID);
            if (Licenses.CheckExistsLicenseID(LicenseID))
                return _ConvertToClsLicenses(LicenseID);
            return null;
        }

        public static int GetApplicationID(int LicenseID)
        {
            return Licenses.GetApplicationID(LicenseID);
        }

        public static int GetApplicationIDByDriverID(int DriverID)
        {
            return Licenses.GetApplicationIDByDriverID((int)DriverID);
        }

        public static int GetLicenseID(int ApplicationID)
        {
            return Licenses.GetLicenseID(ApplicationID);
        }

        public static int GetLicenseIDByDriverID(int DriverID)
        {
            return Licenses.GetLicenseIDByDriverID(DriverID);
        }

        public static int GetDriverID(int ApplicationID)
        {
            return Licenses.GetDriverID(ApplicationID);
        }


        public static bool CheckExistsLicenseID(int LicenseID)
        {
            return Licenses.CheckExistsLicenseID(LicenseID);
        }

        public static bool CheckExistsApplicationID(int ApplicationID)
        {
            return Licenses.CheckExistsApplicationID(ApplicationID);
        }


        public static bool CheckLicenseIDIsReleased(int LicenseID)
        {
            return Licenses.CheckLicenseIDIsReleased(LicenseID);
        }

        public class clsDetainedLicenses
        {

            public static int DetainedLicense(int LicenseID, DateTime DetainDate, int FineFees, int CreatedByUserID, string guid)
            {
                return Licenses.DetainedLicenses.DetainedLicense(LicenseID, DetainDate, FineFees, CreatedByUserID, guid);
            }

            public static DataTable GetDetainIDAndDetainDate(int DetainID)
            {
                return Licenses.DetainedLicenses.GetDetainIDAndDetainDate(DetainID);
            }

            public static DataTable GetDetainDateByLicenseID(int LicenseID)
            {
                return Licenses.DetainedLicenses.GetDetainDateByLicenseID(LicenseID);
            }

            public static DataTable GetDetainIDAndDetainDateByLicenseID(int LicenseID)
            {
                return Licenses.DetainedLicenses.GetDetainIDAndDetainDateByLicenseID(LicenseID);
            }
            public static DataTable DetainedLicensesInfo()
            {
                return Licenses.DetainedLicenses.DetainedLicensesInfo();
            }

            public static DataTable GetIssueDateAndLicenseClass(int LicenseID)
            {
                return Licenses.DetainedLicenses.GetIssueDateAndLicenseClass(LicenseID);
            }

            public static DataTable DetainedLicensesHistory()
            {
                return Licenses.DetainedLicenses.DetainedLicensesHistory();
            }

            public static DataTable ManageDetainedLicenses()
            {
                return Licenses.DetainedLicenses.ManageDetainedLicenses();
            }
            public static int DetainedLicenseHistory(int LicenseID, int LicenseClassID,
                string IssueDate, string ExpirationDate, int IsActive,
            string DetainDate, int IsReleased, string ReleasedDate)
            {
                return Licenses.DetainedLicenses.DetainedLicenseHistory(LicenseID, LicenseClassID, IssueDate, ExpirationDate, IsActive, DetainDate, IsReleased, ReleasedDate);

            }


            public static string GetReleaseLicenseDate(int LicenseID)
            {
                return Licenses.DetainedLicenses.GetReleaseLicenseDate(LicenseID);
            }

            public static bool UpDataDetainedLicensesForReleased(int LicenseID, string Date, string ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
            {
                return Licenses.DetainedLicenses.UpDateDetainedLicensesForReleased(LicenseID, Date, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }

            public static bool UpDateLicenseHistory(int LicenseID, string guid, string ReleaseDate)
            {
                return Licenses.DetainedLicenses.UpDateLicenseHistory(LicenseID, guid, ReleaseDate);
            }

        }

        public class clsInternationalLicenses
        {
            public int InternationalLicenseID
            { get; set; }
            public int ApplicationID
            { get; set; }
            public int DriverID
            { get; set; }
            public int IssuedUsingLocalLicenseID
            { get; set; }
            public DateTime IssueDate
            { get; set; }
            public DateTime ExpirationDate
            { get; set; }
            public int CreatedByUserID
            { get; set; }
            public int IsActive
            { get; set; }

            private static clsInternationalLicenses _ConvertToClsInternationalLicenses(int DriverID)
            {
                DataTable dataTable = Licenses.InternationalLicenses.GetInternationalLicenseByDriverID(DriverID);
                clsInternationalLicenses _License = new clsInternationalLicenses();
                if (dataTable != null)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        _License.InternationalLicenseID = (int)row[0];
                        _License.ApplicationID = (int)row[1];
                        _License.DriverID = (int)row[2];
                        _License.IssuedUsingLocalLicenseID = (int)row[3];
                        _License.IssueDate = (DateTime)row[4];
                        _License.ExpirationDate = (DateTime)row[5];
                        _License.IsActive = (int)row[6];
                        _License.CreatedByUserID = (int)row[7];
                        return _License;
                    }
                }
                return null;
            }

            public static bool CheckExistsDriverID(int DriverID)
            {
                return Licenses.InternationalLicenses.CheckExistsDriverID(DriverID);
            }

            public static clsInternationalLicenses FindInternationalLicenses(int DriverID)
            {
                if (Licenses.InternationalLicenses.CheckExistsDriverID(DriverID))
                    return _ConvertToClsInternationalLicenses(DriverID);
                return null;
            }

            private int _AddInternationalLicense()
            {
                return Licenses.InternationalLicenses.AddInternationalLicense(this.ApplicationID,
                this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate,
                this.ExpirationDate, this.IsActive, this.CreatedByUserID);
            }

            public static int GetInternationalLicenseID(int ApplicationID)
            {
                return Licenses.InternationalLicenses.GetInternationalLicenseID(ApplicationID);
            }

            public bool Save()
            {
                this.InternationalLicenseID = _AddInternationalLicense();
                return this.InternationalLicenseID != 0;
            }

            public static DataTable GetInternationalLicensesHistory(int DriverID)
            {
                bool value = Licenses.CheckExistsDriverID(DriverID);
                if (value)
                {
                    return Licenses.InternationalLicenses.GetInternationalLicensesHistory(DriverID);
                }
                return null;
            }

        }


    }
}