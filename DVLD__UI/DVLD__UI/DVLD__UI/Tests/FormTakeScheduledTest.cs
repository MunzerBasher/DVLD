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
    public partial class FormTakeScheduledTest : Form
    {
        private int LocalLicenseID;
        private int _Appointment;
        public FormTakeScheduledTest(int localLicenseID, int Appointment)
        {
            InitializeComponent();
            LocalLicenseID = localLicenseID;    
            _Appointment = Appointment;
        }

        private void FormAddScheduledTest_Load(object sender, EventArgs e)
        {
            userConAddScheduledTest1.AppointmentID = _Appointment;
            userConAddScheduledTest1.FullUserControlByData(LocalLicenseID);
        }

        private void userConAddScheduledTest1_Load(object sender, EventArgs e)
        {

        }

        private void userConAddScheduledTest1_OnClose(bool obj)
        {
            this.Close();
        }
    }
}