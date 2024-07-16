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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using DVLD_Buisness;


namespace DVLD__UI.People
{
    public partial class UserConInternationalLicenses : UserControl
    {
        private bool _value = false;
        private int _DriverID;
        private int _ApplicationID;
        private int _IsActive;
        private clsLicenses.clsInternationalLicenses _InterLicense;
        public UserConInternationalLicenses()
        {
            InitializeComponent();
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
                    if (clsLicenses.clsInternationalLicenses.CheckExistsDriverID(_DriverID))
                    {
                        _SetLicenseData();
                        MessageBox.Show("You Have International License !");
                    }
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
                    lbLocalLicenseID.Text = _License.LicenseID.ToString();
                    lbIssueReason.Text = _License.IssueReason.ToString();
                    lbDriverIssueDate.Text = _License.IssueDate.ToString();
                    lbDriverExpirationDate.Text = _License.ExpirationDate.ToString();
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

        private void _SetLicenseData()
        {
            _InterLicense = clsLicenses.clsInternationalLicenses.FindInternationalLicenses(_DriverID);
            lbILApplicationID.Text = _InterLicense.ApplicationID.ToString();
            lbIssueDate.Text = _InterLicense.IssueDate.ToString();
            lbInterLicenseExpirationDate.Text = _InterLicense.ExpirationDate.ToString();
            lbCreatedBy.Text = clsUsers.GetUserName(_InterLicense.CreatedByUserID);
            lbInterLicenseID.Text = _InterLicense.InternationalLicenseID.ToString();
            lbApplicationDate.Text = clsApplications.GetApplicationDate(_InterLicense.ApplicationID).ToString();   
            int PersonID = clsDrivers.GetPersonID(_DriverID);
            _SetImage(PersonID);
            btnIssue.Enabled = false;
            linkLabelInfo.Enabled = true;
            linkLabelHistory.Enabled = true;
        }
        
        private void _IfLicenseIDNoExists()
        {
            _value = false;
            MessageBox.Show("License Not Found  ?");
            btnIssue.Enabled = false;
            linkLabelInfo.Enabled = false;
            linkLabelHistory.Enabled = false;
        }

        private bool _AddInternationalLicense()
        {
            _InterLicense = new clsLicenses.clsInternationalLicenses();
            _InterLicense.IsActive = 1;
            _InterLicense.DriverID = _DriverID;
            _InterLicense.IssueDate = DateTime.Now;
            _InterLicense.ApplicationID = _ApplicationID;
            _InterLicense.CreatedByUserID = Login.CurrentUsers.UserID;
            _InterLicense.ExpirationDate = _InterLicense.IssueDate.AddYears(6);
            _InterLicense.IssuedUsingLocalLicenseID  = int.Parse(lbLicenseID.Text);
            if (_InterLicense.Save())
            {
                return true;
            }
            return false;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (_value)
            {
                if (_IsActive == 1)
                {
                    if (_AddInternationalLicense())
                    {
                        _SetLicenseData();
                        btnIssue.Enabled = false;
                        linkLabelInfo.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Error ! License is  Not Active  ?","Message");
                }
            }
        }

        private void PBSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() != "" && int.TryParse(txtSearch.Text, out int LicenseID))
            {
                if (clsLicenses.CheckExistsLicenseID(LicenseID))
                {
                    _value = true;
                    linkLabelHistory.Enabled = true;
                    _FullContainersByData(LicenseID);
                    if (clsLicenses.clsInternationalLicenses.CheckExistsDriverID(_DriverID))
                    {
                        _SetLicenseData();
                        MessageBox.Show("You Have International License !");
                    }
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (OnClose != null)
                Close(true);
        }

        private void UserConInternationalLicenses_Load(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.journalist;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnIssue.Enabled = false;
            linkLabelInfo.Enabled = false;
            linkLabelHistory.Enabled = false;
        }

        private void linkLabelInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int ApplicationID = clsLicenses.GetApplicationID(_ApplicationID);
            FormShowDriverLicense InternationalLicense = new FormShowDriverLicense(ApplicationID,"",true);  
            InternationalLicense.ShowDialog();
        }

        private void linkLabelHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int ApplicationID = clsLicenses.GetApplicationID(_ApplicationID);
            FormUserConLicensesHistory LicensesHistory = new FormUserConLicensesHistory(ApplicationID,true);
            LicensesHistory.ShowDialog();
        }

    }
}