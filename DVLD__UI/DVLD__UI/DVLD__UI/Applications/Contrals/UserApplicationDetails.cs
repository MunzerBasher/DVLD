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
    public partial class UserApplicationDetails : UserControl
    {
        public UserApplicationDetails()
        {
            InitializeComponent();
        }

        public string ApplicationID
        { set { lbApplicationID.Text = value; }}
        public string ApplicationClassName
        { set { lbClass.Text = value; } }
        public string PassedTest
        { set { lbPassedTests.Text = value; }}
        public string ApplicationBasicID
        { set { lbBasicApplicationID.Text = value; }}
        public string ApplicationStatus
        { set { lbStatus.Text = value; }}
        public string ApplicationFees
        {  set { lbFees.Text = value;} }
        public string ApplicationType
        { set { lbType.Text = value;} }
        public string ApplicationApplicant
        {  set { lbApplicant.Text = value;} }
        public DateTime ApplicationDate
        { set { lbDate.Text = value.ToString();}}
        public DateTime ApplicationStatusDate
        {   set { lbDateStatus.Text = value.ToString(); }}
        public string UserID
        { set { lbUser.Text = value; } }

        public event Action<bool> OnClose;

        protected virtual void Close(bool value)
        {
            Action<bool> handler = OnClose;
            if (handler != null)
            { handler(value); }
        }

        private void PBClose_Click(object sender, EventArgs e)
        {
            if (OnClose != null)
                Close(true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (OnClose != null)
                Close(true);
        }

        public void FullUserControlByData(int _ApplicationID)
        {
            if (_ApplicationID != 0)
            {
                clsApplications.clsLocalDrivingLicenseApplications LocalApplication = clsApplications.clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplication(_ApplicationID);
                if (LocalApplication != null)
                {
                    ApplicationID = LocalApplication._LocalDrivingLicenseApplicationID.ToString();
                    ApplicationClassName = clsLicenseClasses.GetLicenseClassName(LocalApplication._LicenseClassID);
                
                }
                clsApplications application = clsApplications.FindApplication(LocalApplication._ApplicationID);
                if (application != null)
                {
                    ApplicationBasicID = application.ApplicationID.ToString();
                    ApplicationFees = application.PaidFees.ToString();
                    ApplicationDate = application.Date;
                    ApplicationStatusDate = application.LastStatusDate;
                    UserID = Login.CurrentUsers.UserID.ToString();
                    ApplicationType = clsApplicationTypes.GetApplicationTypeTitle(application.ApplicationTypeID);
                    ApplicationStatus = clsApplications.GetApplicationStatusTitle(LocalApplication._LocalDrivingLicenseApplicationID);
                    PassedTest = clsApplications.GetPassedTest(LocalApplication._LocalDrivingLicenseApplicationID).ToString();
                    ApplicationApplicant = clsApplications.GetApplicationApplicant(LocalApplication._LocalDrivingLicenseApplicationID).ToString();
                }
            }
        }

        public void HideMembers()
        {
            btnClose.Visible = false;
            PBClose.Visible = false;
        }

        private void UserApplicationDetails_Load(object sender, EventArgs e)
        {

        }
    }
}