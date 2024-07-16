using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Buisness
{
    public class clsApplications
    {
        public class clsLocalDrivingLicenseApplications
        {
            public int _LocalDrivingLicenseApplicationID;
            public int _ApplicationID;
            public int _LicenseClassID;

            public clsLocalDrivingLicenseApplications(int ApplicationID, int LicenseClassID)
            {
                this._ApplicationID = ApplicationID;
                this._LicenseClassID = LicenseClassID;
            }

            private clsLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
            {
                this._LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
                this._ApplicationID = ApplicationID;
                this._LicenseClassID = LicenseClassID;
            }

            private bool _AddLocalDrivingLicenseApplication()
            {
                return Applications.LocalDrivingLicenseApplications.AddLocalDrivingLicenseApplication(this._ApplicationID, this._LicenseClassID);
            }
            public bool Save()
            {
                bool value = _AddLocalDrivingLicenseApplication();
                return value;
            }
            public static DataTable GetAllLocalDrivingLicenseApplications()
            {
                return Applications.LocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplications();
            }

            public static DataTable GetLocalDrivingLicenseApplicationByID(int LocalDrivingLicenseApplicationID)
            {
                return Applications.LocalDrivingLicenseApplications.GetLocalDrivingLicenseApplicationByID(LocalDrivingLicenseApplicationID);
            }

            public static clsLocalDrivingLicenseApplications FindLocalDrivingLicenseApplication(int ApplicationID)
            {
                DataTable dataTable = Applications.LocalDrivingLicenseApplications.FindLocalDrivingLicenseApplication(ApplicationID);
                if (dataTable != null)
                {
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        return (new clsLocalDrivingLicenseApplications((int)dataRow[0], (int)dataRow[1], (int)dataRow[2]));
                    }
                }
                return null;
            }

            public static bool CheckAbilityToAddClient(string LicenseClass, string NationalNo)
            {
                return Applications.LocalDrivingLicenseApplications.CheckAbilityToAddClient(LicenseClass, NationalNo);
            }

            public static int GetApplicationID(int LocalDrivingLicenseApplicationID)
            {
                return Applications.LocalDrivingLicenseApplications.GetApplicationID(LocalDrivingLicenseApplicationID);
            }

            public static int GetLocalDrivingLicenseApplicationID(int ApplicationID)
            {
                return Applications.LocalDrivingLicenseApplications.GetLocalDrivingLicenseApplicationID((ApplicationID));
            }

        }

        public class clsInternationalLicenses
        {

        }

        public enum _DrivingLicenseApplicationsMode { Local, International };
        public _DrivingLicenseApplicationsMode Mode;
        public int ApplicationID { get; set; }
        public int PersonID
        { get; set; }
        public DateTime Date { get; set; }
        public int ApplicationTypeID { get; set; }
        public int ApplicationStatusID { get; set; }
        public DateTime LastStatusDate { get; set; }
        public int PaidFees { get; set; }
        public int CreatedByUserID { get; set; }


        public clsApplications(int PersonID, DateTime Date, int ApplicationTypeID, int ApplicationStatusID, DateTime LastStatusDate
         , int PaidFees, int CreatedByUserID)
        {
            Mode = _DrivingLicenseApplicationsMode.Local;
            ApplicationID = -1;
            this.PersonID = PersonID;
            this.Date = Date;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatusID = ApplicationStatusID;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
        }

        private clsApplications() { }

        private int _AddApplication()
        {
            return Applications.AddApplication(this.PersonID, this.Date, this.ApplicationTypeID, this.ApplicationStatusID, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
        }
        private bool _UpdateApplication()
        {
            return false;
        }

        public bool Save()
        {
            bool value = false;
            if ((this.ApplicationID == -1) && (Mode == _DrivingLicenseApplicationsMode.Local))
            {
                this.ApplicationID = _AddApplication();
                value = this.ApplicationID != -1 ? true : false;
            }
            else
            {
                value = _UpdateApplication();
            }
            return value;
        }

        public static string GetApplicationStatusTitle(int StatusID)
        {
            return Applications.GetApplicationStatusTitle(StatusID);
        }

        public static DateTime GetApplicationDate(int ApplicationID)
        {
            return Applications.GetApplicationDate(ApplicationID);
        }


        public static int GetPassedTest(int LocalDrivingLicenseApplicationID)
        {
            return Applications.GetPassedTest(LocalDrivingLicenseApplicationID);
        }

        public static string GetApplicationApplicant(int LocalDrivingLicenseApplicationID)
        {
            return Applications.GetApplicationApplicant(LocalDrivingLicenseApplicationID);
        }

        private static clsApplications _ConvertToApplications(DataTable dataTable)
        {
            if (dataTable != null)
            {
                clsApplications _Application = new clsApplications();
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    _Application.ApplicationID = (int)dataRow[0];
                    _Application.PersonID = (int)dataRow[1];
                    _Application.Date = (DateTime)dataRow[2];
                    _Application.ApplicationTypeID = (int)dataRow[3];
                    _Application.ApplicationStatusID = (int)dataRow[4];
                    _Application.LastStatusDate = (DateTime)dataRow[5];
                    _Application.PaidFees = (int)dataRow[6];
                    _Application.CreatedByUserID = (int)dataRow[7];
                }
                return _Application;
            }
            return null;
        }

        public static clsApplications FindApplication(int ApplicationID)
        {
            return (_ConvertToApplications(Applications.FindApplication(ApplicationID)));
        }
        public static bool UpdateApplicationStatus(int ApplicationID, int ApplicationStatusID)
        {
            return Applications.UpdateApplicationStatus(ApplicationID, ApplicationStatusID);
        }

    }
}