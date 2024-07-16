using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using DVLD_Buisness;


namespace DVLD__UI.LocalLicense
{
    public partial class FormShowDriverLicense : Form
    {

        private int _ApplicationID;
        private string _NationalNo;
        private bool _IsInter;
        public FormShowDriverLicense(int ApplicationID, string nationalNo, bool Inter=false)
        {
            InitializeComponent();
            _ApplicationID = ApplicationID;
            _NationalNo = nationalNo;
            _IsInter = Inter;
        }

        private void StartData()
        {
            if (!_IsInter)
            {
                if (_NationalNo != "")
                {
                    int ApplicationID = clsLicenses.GetApplicationID(_ApplicationID);
                    userConLicenseDetails1.FullLicenseData(ApplicationID);
                }
                else
                {
                    userConLicenseDetails1.FullLicenseData(_ApplicationID);
                }
            }
            else
            {
                userConLicenseDetails1.InternationalLicenses(_ApplicationID);
            }
        
        }

        private void FormShowDriverLicense_Load(object sender, EventArgs e)
        {
            StartData();
        }
    }

}