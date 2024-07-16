using DVLD__UI.Users;
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
    public partial class UserConScheduleTest : UserControl
    {
        public int TestID;
        private int _LocalLicenseID;
        public UserConScheduleTest()
        {
            InitializeComponent();
        }
        private void _FillByData(int LocalLicenseID, int TestID)
        {
            listView1.Items.Clear();
            DataTable dataTable = clsAppointments.GetAllAppointments(LocalLicenseID, TestID);
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                string value = ((int)row[3]) == 1 ? "True" : "False";
                item.SubItems.Add(value);
                item.Tag = row[0].ToString();
                listView1.Items.Add(item);
            }
        }


        public void FullUserControlByData(int LocalLicenseID, int _TestID)
        {
            userApplicationDetails1.FullUserControlByData(LocalLicenseID);
            _FillByData(LocalLicenseID, _TestID);
            _LocalLicenseID = LocalLicenseID;
            TestID = _TestID;

        }

        private void UserConScheduleTest_Load(object sender, EventArgs e)
        {
            userApplicationDetails1.HideMembers();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormAddScheduleTestAppointment fFormAddScheduleTestAppointment = new FormAddScheduleTestAppointment(_LocalLicenseID,TestID);
            fFormAddScheduleTestAppointment.ShowDialog();
            listView1.Items.Clear();
            _FillByData(_LocalLicenseID, TestID);
        }

        private void _TakeScheduledTest()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    if (int.TryParse(listView1.SelectedItems[0].Text, out int ID))
                    {
                        int LocalID = clsAppointments.GetLocalDrivingLicenseApplicationID(ID);
                        FormTakeScheduledTest formTakeScheduledTest = new FormTakeScheduledTest(LocalID, ID);
                        formTakeScheduledTest.ShowDialog();
                        listView1.Items.Clear();
                        _FillByData(_LocalLicenseID, TestID);
                    }
                }
            }
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _TakeScheduledTest();
            _MakeListViewEnabled();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
           
        }

   
        private bool _CheckAppointmentID(int AppointmentID)
        {

            if (clsTests.GetTestResultID(AppointmentID) == 1)
            { 
                listView1.Enabled = false;
                pictureBox1.Enabled = false;
                return true; 
            }  
            listView1.Enabled= true;
            pictureBox1.Enabled = true;
                return false;

        }
        
        private void _MakeListViewEnabled()
        {
            if(listView1.Items.Count != 0)
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    int AppointmentID = int.Parse(item.Tag.ToString());
                    if (_CheckAppointmentID(AppointmentID) == true)
                        return;
                }
            }
        }

        private void _UpdateAppointment()
        {
            if (listView1.SelectedItems.Count != 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    if (int.TryParse(listView1.SelectedItems[0].Text, out int ID))
                    {
                        FormAddScheduleTestAppointment fFormAddScheduleTestAppointment = new FormAddScheduleTestAppointment(_LocalLicenseID, TestID,ID);
                        fFormAddScheduleTestAppointment.ShowDialog();
                        listView1.Items.Clear();
                        _FillByData(_LocalLicenseID, TestID);
                    }
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _UpdateAppointment();
        }
    }
}
