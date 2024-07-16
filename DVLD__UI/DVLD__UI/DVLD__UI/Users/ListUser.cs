
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

namespace DVLD__UI
{
    public partial class ListUsers : Form
    {

        public ListUsers()
        {
            InitializeComponent();
        }
        DataTable dtAllUsers = clsUsers.GetAllUsers();
        private string _FilterColumn;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddNewUser();
        }
        
        private void _FillByData(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());
                listView1.Items.Add(item);
            }
        }

        private void ListUsers_Load(object sender, EventArgs e)
        {
            _FillByData(dtAllUsers);
            txtFilterValue.Visible = false;
            cmbActive.Visible = false;
        }


        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewUser();
        }

        private void AddNewUser(int UserID = -1)
        {
            AddUsers users = new AddUsers(UserID);
            users.ShowDialog();
            _Refreshdt(dtAllUsers);
        }

        private void DetailsCurrentPerson()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    int ID = int.Parse(listView1.SelectedItems[0].Text);
                    FormUserDetails User = new FormUserDetails(ID);
                    User.ShowDialog();
                }
            }
        }

        private void DeleteCurrentPerson()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    int ID = int.Parse(listView1.SelectedItems[0].Text);
                    clsUsers.DeleteUser(ID);
                    listView1.SelectedItems[0].Remove();
                }
            }
        }

        private void UpdateCurrentPerson()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    int ID = int.Parse(listView1.SelectedItems[0].Text);
                    UpdateUser updateUser = new UpdateUser(ID);
                    updateUser.ShowDialog();
                    _Refreshdt(dtAllUsers);
                }
            }
        }


        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailsCurrentPerson();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCurrentPerson();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCurrentPerson();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;
                case "UserName":
                    FilterColumn = "UserName";
                    break;
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Is Active":
                    FilterColumn = "IsActive";
                    break;
                default:
                        FilterColumn = "None";
                        break;
            }
            _FilterColumn = FilterColumn;
            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _Refreshdt(dtAllUsers);
                _FilterColumn = FilterColumn;
                return;
            }
            if (FilterColumn != "FullName" && FilterColumn != "UserName")
            {
                //in this case we deal with numbers not string.
                if (int.TryParse(txtFilterValue.Text, out int value))
                {
                    _Refreshdt(clsUsers.FindUsers(FilterColumn,value));
                    return;
                }
                txtFilterValue.Text = "";
            }
            else
                _Refreshdt(clsUsers.FindUsers(FilterColumn, txtFilterValue.Text.Trim()));

            //lblRecordsCount.Text = _dtAllUsers.Rows.Count.ToString();
        }
        private void _Refreshdt(DataTable dataTable)
        {
            listView1.Items.Clear();
            _FillByData(dataTable);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedItem.ToString() == "Is Active")
            {
                cmbActive.Visible = true;
                txtFilterValue.Visible = false;
                cmbActive.SelectedIndex = 0;
            }
            else
            {
                txtFilterValue.Visible = (cbFilterBy.SelectedItem.ToString() != "None");
                cmbActive.Visible = false;
            }
        }

        private void cmbActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedItem.ToString() == "Is Active")
            {
                if (cmbActive.SelectedIndex == 0)
                    _Refreshdt(clsUsers.GetAllUsers());
                else if (cmbActive.SelectedIndex == 1)
                    _Refreshdt(clsUsers.FindUsers(_FilterColumn, 1));
                else
                    _Refreshdt(clsUsers.FindUsers(_FilterColumn, 0));
            }
        }
    }

}