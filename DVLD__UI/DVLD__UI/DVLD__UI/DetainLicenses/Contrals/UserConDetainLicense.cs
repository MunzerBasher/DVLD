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
    public partial class UserConDetainLicense : UserControl
    {
        public UserConDetainLicense()
        {
            InitializeComponent();
        }

        public string ReleaseDate
        {
            get { return lbReleasingDate.Text; }
            set {  lbReleasingDate.Text = value;}
        }
        private string _ImagePass;
        private int _LicenseID;
       
        private void _FullContainersByData(int _LicenseID)
        {
            if (int.TryParse(_LicenseID.ToString(), out int LicenseID))
            { 
                clsLicenses _License = new clsLicenses();
                _License = clsLicenses.GetLicenseByLicenseID(LicenseID);
                if (_License != null)
                {
                    lbClass.Text = clsLicenseClasses.GetLicenseClassName(_License.LicenseClassID);
                    this._LicenseID = _License.LicenseID;
                    lbLicenseID1.Text = _License.LicenseID.ToString();
                    lbLicenseID2.Text = _License.LicenseID.ToString();
                    lbIssueDate.Text = _License.IssueDate.ToString();
                    lbDriverExpiration.Text = _License.ExpirationDate.ToString();
                    lbNodes.Text = _License.Node != null ? _License.Node : "";
                    lbIsActive.Text = _License.IsActive == 1 ? "true" : "false";
                    lbUser.Text = clsUsers.GetUserName(_License.CreateBy);
                    lbDriverID.Text = _License.DriverID.ToString();
                    int PersonID = clsDrivers.GetPersonID(_License.DriverID);
                    DataTable dataTable = clsPeople.GetPersonDetainLicense(PersonID);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        lbNational.Text = (string)row[1];
                        lbName.Text = (string)row[2];
                        lbGender.Text = (int)row[3] == 1 ? "Male" : "Female";
                        //_ImagePass = row[4] == System.DBNull.Value  ? "" : (string)row[3];
                        lbDateOfBrith.Text = ((DateTime)row[5]).ToString();
                    }
                    bool value = clsLicenses.CheckLicenseIDIsReleased(_LicenseID);
                    if (value)
                        lbReleasingDate.Text = clsLicenses.clsDetainedLicenses.GetReleaseLicenseDate(_LicenseID);   
                }
            }
                label1.Text = "License ID";
        }

        private void PBSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text.Trim()!=""&&int.TryParse(txtSearch.Text,out int LicenseID))
            {
                
                if (clsLicenses.CheckExistsLicenseID(LicenseID))
                {
                    _FullContainersByData(LicenseID);
                    if (OnPBSearch != null)
                        PicBSearch(true);
                }
                else
                {
                    if (OnPBSearch != null)
                        PicBSearch(false);
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
       
        private bool _DetainLicense()
        {
            if (txtFees.Text.Trim() != "" && int.TryParse(txtFees.Text, out int Fees))
            {
                int UserID = Login.CurrentUsers.UserID;
                DateTime Date = DateTime.Now;
                string guid = Guid.NewGuid().ToString();
                int DetainedID = clsLicenses.clsDetainedLicenses.DetainedLicense(_LicenseID, Date, Fees, UserID,guid);
                DataTable dataTable = clsLicenses.clsDetainedLicenses.GetDetainIDAndDetainDate(DetainedID);
                foreach(DataRow row in dataTable.Rows) 
                {
                    lbDetainID.Text = row[0].ToString();
                    lbDetainDate.Text = ((string)row[1]).ToString();
                    txtFees.Text = row[2].ToString();         
                }
                DataTable dt = clsLicenses.clsDetainedLicenses.GetIssueDateAndLicenseClass(_LicenseID);
                foreach (DataRow row in dt.Rows)
                {
                    int LicenseClassID = (int)row[0];
                    string IssueDate = row[1].ToString();
                    string ExpirationDate = row[2].ToString();
                    int IsActive = (int)row[3];
                    int value = clsLicenses.clsDetainedLicenses.DetainedLicenseHistory(_LicenseID, LicenseClassID, IssueDate, ExpirationDate, IsActive, Date.ToString(), 0, "");
                }
                return true;
            }
            return false;
        }
       
        private void btnDetain_Click(object sender, EventArgs e)
        {
            bool value = _DetainLicense();
            if (value) 
            {   
                btnDetain.Enabled = false;
                txtFees.Enabled = false;
            }
            else
            {
                MessageBox.Show("Enter Fees Please");
            }
        }
   
        public event Action<bool> OnClose;

        protected virtual void Close(bool value)
        {
            Action<bool> handler = OnClose;
            if (handler != null)
            { handler(value); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (OnClose != null)
                Close(true);
        }

        private void LlbLicensesinfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDetainedLicensesInfo info = new FormDetainedLicensesInfo();
            info.ShowDialog();
        }

        private void LlbLicenseHistroy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDetainedLicensesHistory history = new FormDetainedLicensesHistory();
            history.ShowDialog();
        }
    
        public void HidedItemsAndFullContainersByData(int _LicenseID,string Title= "Detain License Details")
        {
            label13.Visible = false;
            label14.Visible = false;
            lbTitle.Text = Title;
            txtSearch.Visible = false;
            PBSearch.Visible = false;
            btnClose.Visible = false;
            btnDetain.Visible = false;
            LlbLicenseHistroy.Visible = false;
            LlbLicensesinfo.Visible = false;
            txtFees.Enabled = false;
            DataTable dataTable = clsLicenses.clsDetainedLicenses.GetDetainIDAndDetainDateByLicenseID(_LicenseID);
            foreach (DataRow row in dataTable.Rows)
            {
                lbDetainID.Text = ((int)row[0]).ToString();
                lbDetainDate.Text = ((string)row[1]).ToString();
                txtFees.Text = ((int)row[2]).ToString();
            }
            _FullContainersByData(_LicenseID);

        }

        public void DetainLicense(int _LicenseID)
        {
            label13.Visible = false;
            label14.Visible = false;
            txtSearch.Visible=false;
            PBSearch.Visible=false;
            this._LicenseID = _LicenseID;
            _FullContainersByData(_LicenseID);
        }
    
        public void HideButtons()
        {
            btnClose.Visible = false;
            btnDetain.Visible = false;
        }

        public void SomeReleaseData()
        {
            txtFees.Enabled = false;
            DataTable dataTable = clsLicenses.clsDetainedLicenses.GetDetainIDAndDetainDateByLicenseID(_LicenseID);
            foreach (DataRow row in dataTable.Rows)
            {
                lbDetainID.Text = ((int)row[0]).ToString();
                lbDetainDate.Text = (row[1]).ToString();
                txtFees.Text = ((int)row[2]).ToString();
            }
        }
    }
}