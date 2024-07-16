using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Buisness;


namespace DVLD__UI.LocalLicense
{
    public partial class UserConAddScheduleTestAppointment : UserControl
    {
        private clsAppointments appointments;
        public int AppointmentID = 0;
        private int _LicenseClassID;
        public UserConAddScheduleTestAppointment()
        {
            InitializeComponent();

        }
        public int TestID
        { get; set; }
        public string TestName
        {
            set { lbTestName.Text = value; }
        }
        public string ApplicationID
        {
            get { return lbID.Text; }
            set { lbID.Text = value; }
        }
        public string PersonName
        {
            set { lbName.Text = value; }
            get { return lbName.Text; }
        }
        public string Track
        {
            set { lbTract.Text = value; }
        }
        public DateTime Date
        {
            set { dateTimePicker1.Value = value; }
            get { return dateTimePicker1.Value; }
        }
        public string Fees
        {
            set { lbFeees.Text = value; }
            get { return lbFeees.Text; }
        }
        public string ClassName
        {
            set { lbClass.Text = value; }
        }

        public void _FullUserControlByDataForNewAppointment(int LocalLicenseID)
        {
            clsApplications.clsLocalDrivingLicenseApplications LocalApplication = clsApplications.clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplication(LocalLicenseID);
            if (LocalApplication != null)
            {
                ApplicationID = LocalApplication._LocalDrivingLicenseApplicationID.ToString();
                ClassName = clsLicenseClasses.GetLicenseClassName(LocalApplication._LicenseClassID);
                _LicenseClassID = LocalApplication._LicenseClassID;
            }
            else
                return;
            clsApplications application = clsApplications.FindApplication(LocalApplication._ApplicationID);

            if (application != null)
            {
                PersonName = clsApplications.GetApplicationApplicant(LocalApplication._LocalDrivingLicenseApplicationID).ToString();
                Track = "0";
                Date = application.Date;
                Fees = application.PaidFees.ToString();
            }
        }

        private void _FullUserControlByDataForUpdateAppointment(int AppointmentID)
        {
            if(this.AppointmentID != 0)
            {
                int LocalLicenseID = clsAppointments.GetLocalDrivingLicenseApplicationID(AppointmentID);
                _FullUserControlByDataForNewAppointment(LocalLicenseID);
                Date = clsAppointments.GetAppointmentDate(AppointmentID);
            }
        }

        private void _FullNewAppointment()
        {
            appointments = clsAppointments.GetNewAppointment();
            appointments.TestTypeID = TestID;
            appointments.AppointmentDate =  Date;
            appointments.LocalDrivingLicenseApplicationID = int.Parse(ApplicationID);
            appointments.PaidFees = int.Parse(Fees);
            appointments.CreatedByUserID = Login.CurrentUsers.UserID;
            appointments.IsLocked = 0;
        }

        private void _AddAppointment()
        {
            if(AppointmentID == 0) 
            {
                _FullNewAppointment();
            }
            else
            {
                appointments = clsAppointments.FindAppointment(AppointmentID);
                appointments.AppointmentDate = Date;
            }

            if (appointments.Save())
            {
                MessageBox.Show("Appointment Saved Successfully !");
            }
            else
            {
                MessageBox.Show("Appointment Saved Filled !");
            }
        }

        public event Action<bool> OnClose;
        protected virtual void Close(bool person)
        {
            Action<bool> handler = OnClose;
            if (handler != null)
            { handler(person); }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _AddAppointment();
            if (OnClose != null)
                Close(true);
        }

        private void UserConAddScheduleTestAppointment_Load(object sender, EventArgs e)
        {
            if(AppointmentID != 0) 
            {
                _FullUserControlByDataForUpdateAppointment(AppointmentID);
            }
        }
    }


}