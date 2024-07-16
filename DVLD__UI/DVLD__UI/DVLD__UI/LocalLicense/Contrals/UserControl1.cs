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
    public partial class UserConLicenseDetails : UserControl
    {
        public UserConLicenseDetails()
        {
            InitializeComponent();
        }

        private void _SetImage(int PersonID)
        {
            string imagePath = clsPeople.GetPersonImagePath(PersonID);
            if (string.IsNullOrEmpty(imagePath))
            {
                pictureBox1.Image = Properties.Resources.journalist;
            }
            else 
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }

        private void _FullDriverData(int DriverID)
        {
            if(DriverID != 0) 
            {
                clsDrivers _Driver = clsDrivers.GetDriverByID(DriverID);
                if(_Driver != null) 
                {
                    lbDriverID.Text = _Driver.DriverID.ToString();
                    lbFullName.Text = _Driver.DriverName.ToString();
                    lbNationalNo.Text = _Driver.PersonNationalNo.ToString();
                    lbDriverIsActive.Text = _Driver.NumberOfActiveLicense >0 ? "True" : "False";
                    int UserCreatedDriver = clsDrivers.GetDriverCreatedByUserID(_Driver.DriverID);
                    lbDriverCreatedBy.Text = clsUsers.GetUserName(UserCreatedDriver);
                    lbDriverCreatedDate.Text = _Driver.CreatedDate.ToString();
                    int PersonID = _Driver.PersonID;
                    _SetImage(_Driver.PersonID);
                }

            }

        }

        public void FullLicenseData(int ApplicationID)
        {
            if (ApplicationID != 0) 
            {
                int LicenseID = clsLicenses.GetLicenseID(ApplicationID);
                lbLicenseID.Text = LicenseID.ToString();
                clsLicenses _License = clsLicenses.GetLicenseByLicenseID(LicenseID);
                if (_License != null)
                {
                    lbIssueDate.Text = _License.IssueDate.ToString();
                    lbExpirationDate.Text = _License.ExpirationDate.ToString();
                    lbLicenseIsActive.Text = _License.IsActive == 1 ? "True" : "False";
                    lbClassName.Text = clsLicenseClasses.GetLicenseClassName(_License.LicenseClassID);
                    lbLicenseCreatedDate.Text = DateTime.Now.ToString();
                    lbLicenseCreatedBy.Text = clsUsers.GetUserName(_License.CreateBy);
                    _FullDriverData(_License.DriverID);
                }
            }
         }

        public void InternationalLicenses(int ApplicationID)
        {
            if(ApplicationID != 0) 
            {
                lbTitle.Text = "International Licenses Info";
                FullLicenseData(ApplicationID);
                lbApplicationID.Visible = true;
                lbILicenseID.Visible = true;
                IApplicationID.Visible = true;
                ILicenseID.Visible = true;
                lbILicenseID.Text = clsLicenses.clsInternationalLicenses.GetInternationalLicenseID(ApplicationID).ToString();
                lbApplicationID.Text = ApplicationID.ToString();
            }

        }


    }
}