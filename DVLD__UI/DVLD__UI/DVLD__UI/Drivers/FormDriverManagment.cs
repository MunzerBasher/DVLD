using DVLD__UI.LocalLicense;
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


namespace DVLD__UI.People
{
    public partial class FormDriverManagement : Form
    {
        public FormDriverManagement()
        {
            InitializeComponent();
        }

        private void _FillByData()
        {
            DataTable dataTable = clsDrivers.GetDrivers();
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                bool value = clsDrivers.CheckActivation((int)row[0]);
                string IsActive = value == true ? "True" : "False";
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());
                item.SubItems.Add(IsActive);
                item.SubItems.Add(row[5].ToString());
                listView1.Items.Add(item);  
            }
        }

        private void FormDriverManagement_Load(object sender, EventArgs e)
        {
            _FillByData();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Users.NewLocalLicensePerson Local = new Users.NewLocalLicensePerson();
            Local.ShowDialog();
        }

        private void _ShowDetails()
        {
            if(listView1.SelectedItems.Count > 0) 
            {
                if (listView1.SelectedItems[0] != null)
                {
                    int _DriverID = int.Parse(listView1.SelectedItems[0].Text);
                    int _ApplicationID = clsLicenses.GetApplicationIDByDriverID(_DriverID);
                    string _National = "";
                    FormShowDriverLicense Issue = new FormShowDriverLicense(_ApplicationID, _National);
                    Issue.ShowDialog();
                    listView1.Items.Clear();
                    _FillByData();
                }
            }


        }

        private void _DetainLicenses()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    int _DriverID = int.Parse(listView1.SelectedItems[0].Text);
                    int LicensesID = clsLicenses.GetLicenseIDByDriverID( _DriverID);
                    FormDetainLicense formDetainLicense = new FormDetainLicense(LicensesID);
                    formDetainLicense.ShowDialog();
                    listView1.Items.Clear();
                    _FillByData();
                }
            }


        }

        private void _EditPersonData()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    int PersonID = clsPeople.GetPersonIDByNationalNo(listView1.SelectedItems[0].SubItems[1].Text);
                    AddOrEditPerson Update = new AddOrEditPerson(PersonID);
                    Update.ShowDialog();
                    listView1.Items.Clear();
                    _FillByData();
                }
            }

        }

        private void _ActivationDriver(int IsActive)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    int _DriverID = int.Parse(listView1.SelectedItems[0].Text);
                    bool value = clsLicenses.UpdateLicenseActivationByDriverID(_DriverID, IsActive);
                    if (value)
                    {
                        if (IsActive == 0)
                        {
                            MessageBox.Show("Driver License is An Activation  ");
                        }
                        else 
                        {
                            MessageBox.Show("Driver License Activated Successfully! ");
                        }
                    }
                }
            }

        }

        private void _IssueInternationalLicense()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    int DriverID = int.Parse(listView1.SelectedItems[0].Text);
                    int LicenseID = clsLicenses.GetLicenseIDByDriverID(DriverID);
                    FormInternationalLicenses International = new FormInternationalLicenses(LicenseID);
                    International.ShowDialog();
                }
            }
        }

        private void delailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ShowDetails();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DetainLicenses();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    bool value = clsDrivers.CheckActivation(int.Parse(listView1.SelectedItems[0].Text));
                    if (value)
                    {
                        activationingToolStripMenuItem.Enabled = false;
                    }
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _EditPersonData();
        }

        private void activationingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ActivationDriver(1);
        }

        private void internationalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _IssueInternationalLicense();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");


            if (cbFilterBy.Text == "None")
            {
                txtFilterValue.Enabled = false;
            }
            else
                txtFilterValue.Enabled = true;

            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
            

                return;
            }


            if (FilterColumn != "FullName" && FilterColumn != "NationalNo")
            {
                //in this case we deal with numbers not str   _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
                return;
            }
            else
            {
                
            }

        }
    }


}