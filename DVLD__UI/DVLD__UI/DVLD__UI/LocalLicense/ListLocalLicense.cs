using DVLD__UI.LocalLicense;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using DVLD_Buisness;


namespace DVLD__UI
{
    public partial class ListLocalLicense: Form
    {
        private bool _value;
        public ListLocalLicense(bool value = false)
        {
            InitializeComponent();
            _value = value;
        }
        private void _FillByData()
        {
            DataTable dataTable = clsApplications.clsLocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplications();            
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());
                item.SubItems.Add(row[5].ToString());
                item.SubItems.Add(row[6].ToString());
                listView1.Items.Add(item);
            }
        }

        private void ListLocalLicense_Load(object sender, EventArgs e)
        {
            _FillByData();
        }

        private void _DetailsCurrentApplication()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    int ID = int.Parse(listView1.SelectedItems[0].Text);
                    FormApplicationDetails ApplicationDetails = new FormApplicationDetails(ID);
                    ApplicationDetails.ShowDialog();
                }
            }
        }

        private void _ScheduleTestCurrentApplication(int TestID)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    int ID = int.Parse(listView1.SelectedItems[0].Text);
                    FormScheduleTest formScheduleTest = new FormScheduleTest(ID, TestID);
                    formScheduleTest.ShowDialog();
                    if (TestID == 3)
                    {
                        clsApplications.clsLocalDrivingLicenseApplications local = clsApplications.clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplication(ID);
                        int PassedTest = clsApplications.GetPassedTest(ID);
                        if (PassedTest == 3)
                        {
                            if (clsApplications.UpdateApplicationStatus(local._ApplicationID, 3))
                            {
                                MessageBox.Show("Application Completed !");
                            }
                        }
                    }
                    listView1.Items.Clear();
                    _FillByData();
                }
            }
        }

        private void _CancelCurrentApplication()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    int ID = int.Parse(listView1.SelectedItems[0].Text);
                    clsApplications.clsLocalDrivingLicenseApplications local = clsApplications.clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplication(ID);       
                    if (local != null) 
                    {
                        if(clsApplications.UpdateApplicationStatus(local._ApplicationID, 2))
                        {
                            MessageBox.Show("Application Canceled !");
                            listView1.Items.Clear();
                            _FillByData();
                        }
                    }
                }
            }
        }

        private void applicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DetailsCurrentApplication();
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CancelCurrentApplication();
        }

        private void scheduleViewTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTestCurrentApplication(1);
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTestCurrentApplication(2);
        }

        private void schedulePracticalTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTestCurrentApplication(3);
        }

        private bool _CheckMakeEnable(int LocalID,int TestTypeID,bool value = true) 
        {
            if(clsAppointments.CheckExistsAppointment(LocalID,TestTypeID))
            {
                int AppointmentID=clsAppointments.GetAppointmentID(LocalID, TestTypeID);
                if (clsTests.CheckExistsAppointment(AppointmentID))
                {
                    if(clsTests.GetTestResultID(AppointmentID) == 1 && value)
                    { 
                        return true; 
                    }
                }
            }
            return false;
        }

        private void _MakeEnable()
        {
            int LocalID = 0;
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    LocalID = int.Parse(listView1.SelectedItems[0].Text);
                }
            }
            bool value1 = _CheckMakeEnable(LocalID, 1);
            if (value1) 
            {
                scheduleViewTestToolStripMenuItem.Enabled = false;
            }
            bool value2 = (_CheckMakeEnable(LocalID, 2, value1));
            if (value2) 
            {
                scheduleWrittenTestToolStripMenuItem.Enabled = true;
            }
            bool value3 = (_CheckMakeEnable(LocalID, 3, value2));
            if(value3)
            {
                scheduleWrittenTestToolStripMenuItem.Enabled = false;
                schedulePracticalTestToolStripMenuItem.Enabled= true;
            }
            if(value3 && value2 && value1)
            {
                scheduleViewTestToolStripMenuItem.Enabled = false;
                scheduleWrittenTestToolStripMenuItem.Enabled = false;
                schedulePracticalTestToolStripMenuItem.Enabled = false;
            }
            else
            {
                if(!value1)
                {
                    scheduleViewTestToolStripMenuItem.Enabled = true;
                    scheduleWrittenTestToolStripMenuItem.Enabled = false;
                    schedulePracticalTestToolStripMenuItem.Enabled = false;
                }
                else if (!value2)
                {
                    scheduleWrittenTestToolStripMenuItem.Enabled = true;
                    scheduleViewTestToolStripMenuItem.Enabled =false;
                    schedulePracticalTestToolStripMenuItem.Enabled = false;
                }
                else if (!value3)
                {
                    schedulePracticalTestToolStripMenuItem.Enabled = true;
                    scheduleWrittenTestToolStripMenuItem.Enabled = false;
                    scheduleViewTestToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void scheduleTestToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            _MakeEnable();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    int PassedTest = clsApplications.GetPassedTest(int.Parse(listView1.SelectedItems[0].Text));
                    if (PassedTest < 3)
                    {
                        toolStripMenuItem4.Enabled = false;
                        toolStripMenuItem5.Enabled = false;
                        showPersonLicenseHistoryToolStripMenuItem1.Enabled = false;
                        scheduleTestToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        int ApplicationID = clsApplications.clsLocalDrivingLicenseApplications.GetApplicationID(int.Parse(listView1.SelectedItems[0].Text));
                        bool value = clsLicenses.CheckExistsApplicationID(ApplicationID);
                        if (value)
                        {
                            scheduleTestToolStripMenuItem.Enabled = false;
                            toolStripMenuItem4.Enabled = false;
                            toolStripMenuItem5.Enabled = true;
                            showPersonLicenseHistoryToolStripMenuItem1.Enabled = true;
                        }
                        else
                        {
                            if (PassedTest == 3)
                            {
                                scheduleTestToolStripMenuItem.Enabled = false;
                                toolStripMenuItem4.Enabled = true;
                                toolStripMenuItem5.Enabled = false;
                            }
                        }
                    }
                }
            }

        }

        private void _ShowDrivingLicense()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int PassedTest = clsApplications.GetPassedTest(int.Parse(listView1.SelectedItems[0].Text));
                if (PassedTest == 3)
                {
                    if (listView1.SelectedItems[0] != null)
                    {
                        int _LocalID = int.Parse(listView1.SelectedItems[0].Text);
                        string _National = listView1.Items[0].SubItems[2].Text.ToString();
                        FormShowDriverLicense Issue = new FormShowDriverLicense(_LocalID, _National);
                        Issue.ShowDialog();
                        listView1.Items.Clear();
                        _FillByData();
                    }
                }
            }
        }

        private void _IssueDrivingLicense()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int PassedTest = clsApplications.GetPassedTest(int.Parse(listView1.SelectedItems[0].Text));
                if (PassedTest == 3)
                {
                    if (listView1.SelectedItems[0] != null)
                    {
                        int _LocalID = int.Parse(listView1.SelectedItems[0].Text);
                        string _National = listView1.SelectedItems[0].SubItems[2].Text.ToString();
                        int _PersonID = clsPeople.GetPersonIDByNationalNo(_National);
                        int _UserID = Login.CurrentUsers.UserID;
                        DateTime _Date = DateTime.Now;
                        int _DriverID;
                        bool value = clsDrivers.CheckPersonID(_PersonID);
                        if (value) 
                        {
                            _DriverID = clsDrivers.GetDriverID(_PersonID);
                        }
                        else 
                        {
                            _DriverID = clsDrivers.AddDriver(_PersonID, _UserID,_Date);                    
                        }

                        int _ApplicationID;
                        int _LicenseClassID;
                        DataTable dataTable = clsApplications.clsLocalDrivingLicenseApplications.GetLocalDrivingLicenseApplicationByID(_LocalID);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            _ApplicationID = (int)row[1];
                            _LicenseClassID = (int)row[2];

                            DateTime _ExpirationDate = _Date.AddYears(6);
                            bool value2 = clsLicenses.AddLicense(_ApplicationID, _DriverID, _LicenseClassID, _Date, _ExpirationDate, "", 20, 1,1,_UserID);
                            if (value2)
                            {
                                MessageBox.Show("New License Issued Successfully !");
                            }
                        }
                        listView1.Items.Clear();
                        _FillByData();
                    }
                }
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            _IssueDrivingLicense();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            _ShowDrivingLicense();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Users.NewLocalLicensePerson Local = new Users.NewLocalLicensePerson();
            Local.ShowDialog();
            listView1.Items.Clear();
            _FillByData();
        }



        private void showPersonLicenseHistoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0) 
            {
                if (listView1.SelectedItems[0] != null) 
                {
                    int _LocalID = int.Parse(listView1.SelectedItems[0].Text);
                    int _ApplicationID = clsLicenses.GetApplicationID(_LocalID);
                    FormUserConLicensesHistory history = new FormUserConLicensesHistory(_ApplicationID);
                    history.ShowDialog();
                }
            }
            
        }
    }
}