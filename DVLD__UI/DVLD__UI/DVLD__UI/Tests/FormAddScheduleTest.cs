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
    public partial class FormAddScheduleTestAppointment : Form
    {
        private int _LocalID;
        private int _TestID;
        private int AppointmentID = 0;
        public FormAddScheduleTestAppointment(int LocalID, int testID, int appointmentID=0)
        {
            InitializeComponent();
            _LocalID = LocalID;
            _TestID = testID;
            AppointmentID = appointmentID;  
        }
        private void SetForm()
        {  
            userConAddScheduleTestAppointment1._FullUserControlByDataForNewAppointment(_LocalID);
            userConAddScheduleTestAppointment1.TestID = _TestID;
            userConAddScheduleTestAppointment1.AppointmentID = AppointmentID;
            
        }

        private void FormAddScheduleTestAppointment_Load(object sender, EventArgs e)
        {
            SetForm();
        }

        private void userConAddScheduleTestAppointment1_OnClose(bool obj)
        {
            this.Close();
        }
    }
}