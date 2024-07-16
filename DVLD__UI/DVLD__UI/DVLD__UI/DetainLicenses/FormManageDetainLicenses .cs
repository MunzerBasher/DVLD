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
    public partial class FormManageDetainLicenses : Form
    {
        public FormManageDetainLicenses()
        {
            InitializeComponent();
        }
        private void _FillByData()
        {
            DataTable dataTable = clsLicenses.clsDetainedLicenses.ManageDetainedLicenses();
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                string IsActive = (int)row[4] == 1 ? "True" : "False";
                item.SubItems.Add(IsActive);
                item.SubItems.Add(row[5].ToString());
                string IsReleased = (int)row[6] == 1 ? "True" : "False";
                item.SubItems.Add(IsReleased);
                item.SubItems.Add(row[7].ToString());
                listView1.Items.Add(item);
            }
        }

        private void FormManageDetainLicenses_Load(object sender, EventArgs e)
        {
            _FillByData();
        }
        
        private void CurrentDetainLicenseDetails()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    int ID = int.Parse(listView1.SelectedItems[0].Text);
                    FormDetainLicenseDetails Details = new FormDetainLicenseDetails(ID);
                    Details.ShowDialog();
                }
            }
        }

        private void _DetainLicense()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    int _LicenseID = int.Parse(listView1.SelectedItems[0].Text);
                    FormDetainLicense detainLicense = new FormDetainLicense(_LicenseID);
                    detainLicense.ShowDialog();
                    listView1.Items.Clear();
                    _FillByData();
                }
            }
        }

        private void _ReleaseDetainedLicense()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    int _LicenseID = int.Parse(listView1.SelectedItems[0].Text);
                    string guid = (listView1.SelectedItems[0].SubItems[7].Text).ToString();
                    FormReleaseDetainedLicense detainLicense = new FormReleaseDetainedLicense(guid, _LicenseID);
                    detainLicense.ShowDialog();
                    listView1.Items.Clear();
                    _FillByData();
                }
            }
        }
        
        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentDetainLicenseDetails();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DetainLicense();
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ReleaseDetainedLicense();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    int ID = int.Parse(listView1.SelectedItems[0].Text);
                    bool value = clsLicenses.CheckLicenseIDIsReleased(ID);
                    if (!value) 
                    {
                        releaseLicenseToolStripMenuItem.Enabled=false;
                        detainLicenseToolStripMenuItem.Enabled = true;
                        detailsToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        detainLicenseToolStripMenuItem.Enabled = false;
                        releaseLicenseToolStripMenuItem.Enabled = true;
                        detailsToolStripMenuItem.Enabled = true;
                    }
                }
            }
            else
            {
                detailsToolStripMenuItem.Enabled = false;
                detainLicenseToolStripMenuItem.Enabled = false;
                releaseLicenseToolStripMenuItem.Enabled = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormDetainLicense detainLicense = new FormDetainLicense();
            detainLicense.ShowDialog();
            listView1.Items.Clear();
            _FillByData();
        }
    }


}