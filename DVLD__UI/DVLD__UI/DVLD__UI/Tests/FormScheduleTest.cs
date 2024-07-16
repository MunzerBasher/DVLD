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
    public partial class FormScheduleTest : Form
    {
        int _TestID;
        int _LocalLicenseID;
        public FormScheduleTest(int localLicenseID, int testID)
        {
            InitializeComponent();
            _TestID = testID;
            _LocalLicenseID = localLicenseID;
        }

        private void FormScheduleTest_Load(object sender, EventArgs e)
        {
            userConScheduleTest1.FullUserControlByData(_LocalLicenseID, _TestID);
            userConScheduleTest1.TestID = _TestID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}