using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD__UI.People
{
    public partial class FormInternationalLicenses : Form
    {
        private int _LicenseID;
        public FormInternationalLicenses(int licenseID = 0)
        {
            InitializeComponent();
            _LicenseID = licenseID;
        }

        private void userConInternationalLicenses1_OnClose(bool obj)
        {
            this.Close();
        }

        private void FormInternationalLicenses_Load(object sender, EventArgs e)
        {
            if(_LicenseID != 0) 
            {
                userConInternationalLicenses1.FullContainersByData(_LicenseID);
            }
        }
    }
}