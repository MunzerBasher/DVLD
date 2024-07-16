using DVLD__UI.Applications;
using DVLD__UI.DVLD__DataAccess;
using DVLD__UI.LocalLicense;
using DVLD__UI.People;
using DVLD__UI.Users;
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

namespace DVLD__UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        public delegate void DataBackEventHandler(object sender, bool value);

        public event DataBackEventHandler DataBack;

        private PeopleList form2 = new PeopleList();

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeopleList form2 = new PeopleList();
            form2.ShowDialog();
        }
        private void ShowPeopleList(object sender, bool value)
        {
            // DataBack?.Invoke(this, true);
            form2.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListUsers users = new ListUsers();
            users.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentUserInfo currentUserInfo = new CurrentUserInfo(Login.CurrentUsers.UserID);
            currentUserInfo.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Login.CurrentUsers.UserID;
            FormUserDetails User = new FormUserDetails(ID);
            User.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, true);
            this.Close();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users.NewLocalLicensePerson Local = new Users.NewLocalLicensePerson();
            Local.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormApplicationTypes formApplicationTypes = new FormApplicationTypes();
            formApplicationTypes.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTestTypes formTestTypes = new FormTestTypes();
            formTestTypes.ShowDialog();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListLocalLicense listLocalLicense = new ListLocalLicense();
            listLocalLicense.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDetainLicense formDetainLicense = new FormDetainLicense();
            formDetainLicense.ShowDialog();
        }

        private void manageDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManageDetainLicenses Manage = new FormManageDetainLicenses();
            Manage.ShowDialog();
        }

        private void releaseDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToString();
            FormReleaseDetainedLicense detainLicense = new FormReleaseDetainedLicense(now);
            detainLicense.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDriverManagement driverManagement = new FormDriverManagement();
            driverManagement.ShowDialog();
        }

        public static void SetForm(Form form, int x1, int y1)
        {
            form.Size = new Size(x1, y1);
            int x = (Screen.PrimaryScreen.Bounds.Width - form.Size.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - form.Size.Height) / 2;
            form.Location = new Point(x, y);
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            SetForm(this, 1711, 888);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetForm(this, 1711, 888);
        }

        private void internationalLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormInternationalLicenses InterationalLicenses = new FormInternationalLicenses();
            InterationalLicenses.ShowDialog();
        }

        private void replacementForLossOrDamagedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReplacement Replacement = new FormReplacement();
            Replacement.ShowDialog();
        }

        private void reNewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRenewLicenses formRenewLicenses = new FormRenewLicenses();
            formRenewLicenses.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void remakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListLocalLicense listLocalLicense = new ListLocalLicense();
            listLocalLicense.ShowDialog();
        }
    }

}