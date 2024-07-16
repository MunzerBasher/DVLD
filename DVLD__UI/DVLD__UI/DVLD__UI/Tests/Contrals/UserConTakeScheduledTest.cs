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
    public partial class UserConTakeScheduledTest : UserControl
    {
        public UserConTakeScheduledTest()
        {
            InitializeComponent();
        }
        public int AppointmentID
        { get; set; }
        public string TestName
        {
            set { lbTestName.Text = value; }
        }    
        public string ApplicationID
        {
            set { lbID.Text = value; }
            get { return lbID.Text; }
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
        public string Date
        {
            set { lbDate.Text = value; }
            get { return lbDate.Text; }
        }
        public string Fees
        {
            set { lbFeees.Text = value; }
            get { return lbFeees.Text; }
        }
        public string TestID
        {
            set { lbTestID.Text = value; }
        }
        public string ClassName
        {
            set { lbClass.Text = value; }
            get { return lbClass.Text; }
        }
        public string NodeText
        {
            get { return txtNode.Text; }
            set { txtNode.Text = value; }
        }
        
        
        public void FullUserControlByData(int LocalLicenseID)
        {
            clsApplications.clsLocalDrivingLicenseApplications LocalApplication = clsApplications.clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplication(LocalLicenseID);
            if (LocalApplication != null)
            {
                ApplicationID = LocalApplication._LocalDrivingLicenseApplicationID.ToString();
                ClassName = clsLicenseClasses.GetLicenseClassName(LocalApplication._LicenseClassID);
            }
            clsApplications application = clsApplications.FindApplication(LocalApplication._ApplicationID);
            
            if (application != null)
            {
                PersonName = clsApplications.GetApplicationApplicant(LocalApplication._LocalDrivingLicenseApplicationID).ToString();
                Track = "0";
                Date = application.Date.ToString();
                Fees = application.PaidFees.ToString();
                TestID = "No Taken Yet";
            }

        }
        private void UserConAddScheduledTest_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int value = rbPass.Checked ? 1 : 0;
            if (clsTests.AddTest(AppointmentID,value, NodeText,Login.CurrentUsers.UserID))
            {
                if(clsTests.UpdateLockedAppointment(AppointmentID))
                    MessageBox.Show("Test Complete Successfully !");
                if (OnClose != null)
                    Close(true);
            }
            else
            {
                MessageBox.Show("Error in Test Data !");
            }
        }
        public event Action<bool> OnClose;

        protected virtual void Close(bool person)
        {
            Action<bool> handler = OnClose;
            if (handler != null)
            { handler(person); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (OnClose != null)
                Close(true);
        }
    }
}






