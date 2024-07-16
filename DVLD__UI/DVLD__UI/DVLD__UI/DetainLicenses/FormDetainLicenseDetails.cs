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
    public partial class FormDetainLicenseDetails : Form
    {
        private int _LicenseID;
        public FormDetainLicenseDetails(int licenseID)
        {
            InitializeComponent();
            _LicenseID = licenseID;
        }

        private void FormDetainLicenseDetails_Load(object sender, EventArgs e)
        {
            userConDetainLicense1.HidedItemsAndFullContainersByData(_LicenseID);
        }
    }
}
