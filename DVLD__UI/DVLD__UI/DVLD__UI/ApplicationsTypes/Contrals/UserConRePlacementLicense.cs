using DVLD__UI.LocalLicense;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DVLD_Buisness;


namespace DVLD__UI.People
{
    public partial class UserConRePlacementLicense : UserControl
    {
        private bool _value = false;
        private int _DriverID;
        private int _ApplicationID;
        private int _IsActive;
        private int _PersonID;
        private DateTime _ExpirationDate;
        private int _Fees;
        private int _LicenseID;
        private int _OldLicenseID;


        public UserConRePlacementLicense()
        {
            InitializeComponent();
        }

        private void _SetLicenseData()
        {   
            int PersonID = clsDrivers.GetPersonID(_DriverID);
            _PersonID = PersonID;
            _SetImage(PersonID);
           // btnIssue.Enabled = false;
            linkLabelInfo.Enabled = true;
            linkLabelHistory.Enabled = true;
        }

        public void FullContainersByData(int _LicenseID)
        {
            if (int.TryParse(_LicenseID.ToString(), out int LicenseID))
            {
                txtSearch.Text = LicenseID.ToString();
                if (clsLicenses.CheckExistsLicenseID(LicenseID))
                {
                    _value = true;
                    linkLabelHistory.Enabled = true;
                    _FullContainersByData(LicenseID);
                   
                    if (OnPBSearch != null)
                        PicBSearch(true);
                }
                else
                {
                    _IfLicenseIDNoExists();
                    if (OnPBSearch != null)
                        PicBSearch(false);
                }
            }
        }

        private void _FullContainersByData(int _LicenseID)
        {
            if (int.TryParse(_LicenseID.ToString(), out int LicenseID))
            {
                clsLicenses _License = new clsLicenses();
                _License = clsLicenses.GetLicenseByLicenseID(LicenseID);
                if (_License != null)
                {
                    lbClassName.Text = clsLicenseClasses.GetLicenseClassName(_License.LicenseClassID);
                    lbLicenseID.Text = _License.LicenseID.ToString();
                    lbOldLicenseID.Text = _License.LicenseID.ToString();
                    lbIssueReason.Text = _License.IssueReason.ToString();
                    lbDriverIssueDate.Text = _License.IssueDate.ToString();
                    lbDriverExpirationDate.Text = _License.ExpirationDate.ToString();
                    _ExpirationDate = _License.ExpirationDate;
                    lbNotes.Text = _License.Node != null ? _License.Node : "No Notes";
                    lbIsActive.Text = _License.IsActive == 1 ? "True" : "False";
                    _IsActive = _License.IsActive;
                    lbDriverID.Text = _License.DriverID.ToString();
                    _DriverID = _License.DriverID;
                    _ApplicationID = _License.ApplicationID;
                    lbFees.Text = "$ 50";
                    int PersonID = clsDrivers.GetPersonID(_License.DriverID);
                    DataTable dataTable = clsPeople.GetPersonDetainLicense(PersonID);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        lbNationalNo.Text = (string)row[1];
                        lbDriverName.Text = (string)row[2];
                        lbGender.Text = (int)row[3] == 1 ? "Male" : "Female";
                        lbDateOfBrith.Text = ((DateTime)row[5]).ToString();
                    }
                    _SetLicenseData();
                }
            }
        }

        public event Action<bool> OnPBSearch;

        protected virtual void PicBSearch(bool value)
        {
            Action<bool> handler = OnPBSearch;
            if (handler != null)
            { handler(value); }
        }

        public event Action<bool> OnClose;
        protected virtual void Close(bool value)
        {
            Action<bool> handler = OnClose;
            if (handler != null)
            { handler(value); }
        }

        private void _SetImage(int PersonID)
        {
            string imagePath = clsPeople.GetPersonImagePath(PersonID);
            if (string.IsNullOrEmpty(imagePath))
            {
                pictureBox9.Image = Properties.Resources.journalist;
            }
            else
            {
                pictureBox9.Image = System.Drawing.Image.FromFile(imagePath);
            }
        }

        private void _IfLicenseIDNoExists()
        {
            _value = false;
            MessageBox.Show("License Not Found  ?");
            btnIssue.Enabled = false;
            linkLabelInfo.Enabled = false;
            linkLabelHistory.Enabled = false;
        }

        private void UserConReNewLicense_Load(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.journalist;
        }

        private void PBSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() != "" && int.TryParse(txtSearch.Text, out int LicenseID))
            {
                if (clsLicenses.CheckExistsLicenseID(LicenseID))
                {
                    _OldLicenseID = LicenseID;
                    _value = true;
                    _LicenseID = LicenseID;
                    linkLabelHistory.Enabled = true;
                    _FullContainersByData(LicenseID);
                    if (OnPBSearch != null)
                    {
                        PicBSearch(true);
                        btnIssue.Enabled = true;
                    }
                    if(_IsActive == 0)
                    {
                        btnIssue.Enabled = false;
                        linkLabelHistory.Enabled= false;
                        linkLabelInfo.Enabled= false;
                        MessageBox.Show("You Can't Replacements InActive Licenses ?");
                    }
                }
                else
                {
                    _IfLicenseIDNoExists();
                    if (OnPBSearch != null)
                        PicBSearch(false);
                }
            }
        }

        private void linkLabelInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowDriverLicense InternationalLicense = new FormShowDriverLicense(_ApplicationID, "", true);
            InternationalLicense.ShowDialog();
        }

        private void linkLabelHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUserConLicensesHistory LicensesHistory = new FormUserConLicensesHistory(_ApplicationID);
            LicensesHistory.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (OnClose != null)
                Close(true);
        }

        private void _AddNewLicense()
        {
            int _Local = clsApplications.clsLocalDrivingLicenseApplications.GetLocalDrivingLicenseApplicationID(_ApplicationID);
            if (_Local!= 0)
            {
                string _National = clsPeople.GetPersonNationalNo(_PersonID);
                int PersonID = _PersonID;
                int _UserID = Login.CurrentUsers.UserID;
                DateTime _Date = DateTime.Now;
                int _ApplicationID;
                int _LicenseClassID;
                DataTable dataTable = clsApplications.clsLocalDrivingLicenseApplications.GetLocalDrivingLicenseApplicationByID(_Local);
                foreach (DataRow row in dataTable.Rows)
                {
                    _ApplicationID = (int)row[1];
                    _LicenseClassID = (int)row[2];

                    DateTime _ExpirationDate = _Date.AddYears(6);
                    clsLicenses.UpdateLicenseActivationByDriverID(_DriverID, 0);
                    _LicenseID = clsLicenses.AddLicenses(_ApplicationID, _DriverID, _LicenseClassID, _Date, _ExpirationDate, "", 20, 1, 1, _UserID);
                    if (_LicenseID != 0)
                    {
                        MessageBox.Show("New License Issued Successfully !");
                        _FullLabels();
                    }
                }
            }
        }

        private void _FullLabels()
        {
            lbILApplicationID.Text = _ApplicationID.ToString(); 
            lbApplicationDate.Text = DateTime.Now.ToString();
            lbFees.Text = _Fees.ToString();
            lbOldLicenseID.Text = _OldLicenseID.ToString();
            lbCreatedBy.Text = clsUsers.GetUserName(Login.CurrentUsers.UserID);
            lbreplacerLicenseID.Text = _LicenseID.ToString();

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            _AddNewLicense();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnIssue.Enabled = true;
        }

        private void RBDamag_CheckedChanged(object sender, EventArgs e)
        {
            lbFees.Text = "5 $";
            _Fees = 5;
        }

        private void RBLoss_CheckedChanged(object sender, EventArgs e)
        {
            lbFees.Text = "10 $";
            _Fees = 10;
        }
    }
}
