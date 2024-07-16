using DVLD__UI.People;
using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;




namespace DVLD__UI
{
    public partial class PeopleList : Form
    {
        private string _FilterColumn;
        public PeopleList()
        {
            InitializeComponent();
        }
      
        //private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
        //                                         "FirstName","SecondName","ThirdName",
        //                                         "DateOfBirth","Gender","Phone","Email");


        public static void SetForm(Form form, int x1, int y1)
        {
            //form.Size = new Size(x1, y1);
            //int x = (Screen.PrimaryScreen.Bounds.Width - form.Size.Width) / 2;
            //int y = (Screen.PrimaryScreen.Bounds.Height - form.Size.Height) / 2;
            //form.Location = new Point(x, y);
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            
             _Refreshdt(clsPeople.GetAllPeople());
            txtFilterValue.Visible = false;
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            SetForm(this, 1005, 494);
        }

        private void Form2_Move(object sender, EventArgs e)
        {
            SetForm(this, 1005, 494);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _FillByData(DataTable dataTable)
        {
            int i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());
                item.SubItems.Add(row[6].ToString());
                string Gender = (int)row[7] == 1 ? "Female" : "Male";
                item.SubItems.Add(Gender);
                item.SubItems.Add(row[9].ToString());
                item.SubItems.Add(row[10].ToString());
                if (i % 2 == 0)
                    item.BackColor = Color.CornflowerBlue;
                listView1.Items.Add(item);
                i++;
            }
        }

        private void DetailsCurrentPerson()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    int ID = int.Parse(listView1.SelectedItems[0].Text);
                    Details details = new Details(ID);
                    details.ShowDialog();
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
                    AddOrEditPerson Update = new AddOrEditPerson(ID);
                    Update.ShowDialog();
                    _Refreshdt(clsPeople.GetAllPeople());
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
                    bool value = true;
                    if (MessageBox.Show("Do You Delete This Person", "Message", MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
                    {
                        value = clsPeople.DeletePerson(ID);
                    }
                    if (!value)
                        MessageBox.Show("Can't Remove This Person, May be Using ");
                    _Refreshdt(clsPeople.GetAllPeople());
                }
            }
        }
       
        private void Add()
        {
            AddOrEditPerson Add = new AddOrEditPerson(-1);
            Add.ShowDialog();
            _Refreshdt(clsPeople.GetAllPeople());
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Add();
        }
        
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add();
        }
        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailsCurrentPerson();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCurrentPerson();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCurrentPerson();
        }

        
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || _FilterColumn == "None")
            {
                _Refreshdt(clsPeople.GetAllPeople());
                //txtFilterValue.Visible = false;
                return;
            }
            if (_FilterColumn == "PersonID")
            {
                if (int.TryParse(txtFilterValue.Text, out int value))
                {
                    _Refreshdt(clsPeople.GetPersonByID(value));                     
                }
                else
                    txtFilterValue.Text = "";
                return;
            }
            else
            {
                _Refreshdt(clsPeople.FindPeople(_FilterColumn, txtFilterValue.Text.Trim()));
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            txtFilterValue.Visible = true;
            if(cbFilterBy.Text == "None")
                txtFilterValue.Visible = false;
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gendor":
                    FilterColumn = "GendorCaption";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }
            _FilterColumn = FilterColumn;
        }
       
        private void _Refreshdt(DataTable dataTable)
        {
            listView1.Items.Clear();
            _FillByData(dataTable);
        }

       
    }
    
}