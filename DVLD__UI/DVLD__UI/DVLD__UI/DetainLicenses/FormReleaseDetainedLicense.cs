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
    public partial class FormReleaseDetainedLicense : Form
    {
        private int _LicenseID;
        private string _Date;
        private bool _value;
        public FormReleaseDetainedLicense(string Date="" , int licenseID=0)
        {
            InitializeComponent();
            _LicenseID = licenseID;
            _Date = Date;
        }

        private void _SetStartedData()
        {
            if (_LicenseID == 0)
            {
                userConDetainLicense1.HideButtons();
            }
            else 
            {
                _value = true;
                userConDetainLicense1.HidedItemsAndFullContainersByData(_LicenseID, "Release Detained License");
            }

        }

        private void FormReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            _SetStartedData();
        }

        private void userConDetainLicense1_OnPBSearch(bool obj)
        {
            _value = obj;
            if(_value) 
            {
                _LicenseID = int.Parse(userConDetainLicense1.txtSearch.Text);
                userConDetainLicense1.SomeReleaseData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _ReleaseLicense(int _LicenseID) 
        {
            int UserID = Login.CurrentUsers.UserID;
            int ApplicationID = clsLicenses.GetApplicationID(_LicenseID);
            bool value = clsLicenses.clsDetainedLicenses.UpDataDetainedLicensesForReleased(_LicenseID,_Date, DateTime.Now.ToString(), UserID, ApplicationID);
            bool value1 = clsLicenses.clsDetainedLicenses.UpDateLicenseHistory(_LicenseID,_Date,DateTime.Now.ToString());
            
            if (value)
            {
                userConDetainLicense1.ReleaseDate = DateTime.Now.ToString();
                return true;
            }
            return false;
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if(!_value) 
            {
                MessageBox.Show("No License Found !");
            }
            else
            {
                bool value = _ReleaseLicense(_LicenseID);
                if(value) 
                {
                    btnRelease.Enabled = false;
                    MessageBox.Show("License Released Successfully !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("License Released Fill !");
                }
            }

        }
   
    
    }
}