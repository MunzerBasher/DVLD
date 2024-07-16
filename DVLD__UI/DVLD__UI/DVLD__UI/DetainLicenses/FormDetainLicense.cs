using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD__UI.LocalLicense
{
    public partial class FormDetainLicense : Form
    {
        private int _LicenseID = 0;
        public FormDetainLicense(int licenseID = 0)
        {
            InitializeComponent();
            _LicenseID = licenseID;
        }

        private void userConDetainLicense1_OnClose(bool obj)
        {
            if (obj) 
            {
                this.Close();
            }
        }

        private void FormDetainLicense_Load(object sender, EventArgs e)
        {
            if(_LicenseID != 0) 
            {
                userConDetainLicense1.DetainLicense(_LicenseID);
            }
        }
    }

}