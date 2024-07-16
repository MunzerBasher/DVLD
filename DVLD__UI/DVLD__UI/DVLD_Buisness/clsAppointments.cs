using System;
using System.Data;

using DVLD_DataAccess;

namespace DVLD_Buisness
{
    public class clsAppointments
    {

        private int _AppointmentID;
        public int AppointmentID
        { get { return _AppointmentID; } }
        public int TestTypeID
        { get; set; }
        public int LocalDrivingLicenseApplicationID
        { get; set; }
        public DateTime AppointmentDate
        { get; set; }
        public int PaidFees
        { get; set; }
        public int CreatedByUserID
        { get; set; }
        public int IsLocked
        { get; set; }
        public static DataTable GetAllAppointments(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return Appointments.GetAllAppointments(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        public static int GetLocalDrivingLicenseApplicationID(int TestAppointmentID)
        {
            return Appointments.GetLocalDrivingLicenseApplicationID(TestAppointmentID);
        }
        private bool _AddAppointment()
        {
            return Appointments.AddAppointment(this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked);
        }

        public static DateTime GetAppointmentDate(int TestAppointmentID)
        {
            return Appointments.GetAppointmentDate(TestAppointmentID);
        }

        private bool _UpdateAppointment()
        {
            return Appointments.UpdateAppointment(this.AppointmentID, this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked);
        }

        private bool _UpdateAddAppointment(int AppointmentID)
        {
            return Appointments.UpdateAppointment(AppointmentID, this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked);
        }

        public static clsAppointments GetNewAppointment()
        {
            clsAppointments _Appointment = new clsAppointments();
            _Appointment._AppointmentID = -1;
            _Appointment.TestTypeID = -1;
            _Appointment.LocalDrivingLicenseApplicationID = -1;
            _Appointment.IsLocked = -1;
            _Appointment.AppointmentDate = DateTime.Now;
            _Appointment.PaidFees = 0;
            _Appointment.CreatedByUserID = -1;
            return _Appointment;
        }

        private static clsAppointments _ConvertToClsAppointments(int _AppointmentID)
        {
            DataTable dataTable = Appointments.FindAppointment(_AppointmentID);
            clsAppointments _Appointment = new clsAppointments();
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    _Appointment._AppointmentID = (int)row[0];
                    _Appointment.TestTypeID = (int)row[1];
                    _Appointment.LocalDrivingLicenseApplicationID = (int)row[2];
                    _Appointment.AppointmentDate = (DateTime)row[3];
                    _Appointment.PaidFees = (int)row[4];
                    _Appointment.CreatedByUserID = (int)row[5];
                    _Appointment.IsLocked = (int)row[6];
                }
            }
            return _Appointment;
        }

        public static clsAppointments FindAppointment(int _AppointmentID)
        {
            return _ConvertToClsAppointments(_AppointmentID);
        }


        public bool Save()
        {
            if (this.AppointmentID == -1)
            {
                return _AddAppointment();
            }
            else
            {
                return _UpdateAddAppointment(this.AppointmentID);
            }
        }

        public static bool CheckExistsAppointment(int LocalDrivingLicenseApplicationID, int TestTypeD)
        {
            return Appointments.CheckExistsAppointment(LocalDrivingLicenseApplicationID, TestTypeD);
        }


        public static int GetAppointmentID(int LocalDrivingLicenseApplicationID, int TestTypeD)
        {
            return Appointments.GetAppointmentID(LocalDrivingLicenseApplicationID, TestTypeD);
        }

        public static bool UpdateAppointmentDate(int AppointmentID, DateTime AppointmentDate)
        {
            return Appointments.UpdateAppointmentDate(AppointmentID, AppointmentDate);
        }

    }
}