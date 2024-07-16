using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DVLD_Buisness;

namespace DVLD__UI.People
{
    public partial class PeopleData : UserControl
    {
        clsPeople People = new clsPeople();
        public PeopleData()
        {
            InitializeComponent();
        }

        private int _Gender = 0;
        private string _ImagePath = "";
        
        public int ID
        { get; set; }
        public string First
        {
            get { return txtFirst.Text; }
            set { txtFirst.Text = value; }
        }

        public string Second
        {
            get { return txtSecond.Text; }
            set { txtSecond.Text = value; }
        }

        public string Third
        {
            get { return txtThird.Text; }
            set { txtThird.Text = value; }
        }

        public string Last
        {
            get { return txtLast.Text; }
            set { txtLast.Text = value; }
        }

        public string National
        {
            get { return txtNational.Text; }
            set { txtNational.Text = value; }
        }

        public DateTime BirthDay
        {
            get { return txtDate.Value; }
            set { txtDate.Value = value; }
        }

        public int Gender
        {
            get 
            { 
                _Gender = rdFemale.Checked ? 1 : 0;  
                return _Gender; 
            }
            set 
            {
                _Gender = value;
                
            }
        }

        public string Phone
        {
            get { return txtPhone.Text; }
            set { txtPhone.Text = value; }
        }
        public string Email
        {
            get { return txtEmail.Text;}
            set { txtEmail.Text = value; }  
        }

        public int Country
        {
            get; set;
        }

        public string Address
        {
            get { return txtAddress.Text; } 
            set { txtAddress.Text = value; }
        }

        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; } 
        }


        public event Action<bool> OnSave;

        protected virtual void Save(bool person)
        {
            Action<bool> handler = OnSave;
            if (handler != null)
            { handler(person); }
        }
        public event Action<bool> OnClose;

        protected virtual void Close(bool person)
        {
            Action<bool> handler = OnClose;
            if (handler != null)
            { handler(person); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(OnClose != null)
                Close(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool value = Check();
            if (!value)
            {
                MessageBox.Show("There Empty Field ~");
            }
            if (OnSave != null)
                Save(value);
        }
      
        private void SetImage()
        {
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "This is Title";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 0;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _ImagePath = (saveFileDialog1.FileName);
                if (!string.IsNullOrEmpty(_ImagePath)) 
                {
                    MessageBox.Show(_ImagePath);
                    pictureBox1.Image = Image.FromFile(_ImagePath);
                }
            }
        }
        public void SetCurrentImage(string  image)
        {
            if(!string.IsNullOrEmpty(image))
            {
                pictureBox1.Image = Image.FromFile(image);
            }
        }
        public void SetCurrentCountry(int image)
        {
            if (image > 0)
            {
                cmbCountry.SelectedIndex =image;
            }
        }
        public void FocusIn()
        {
            txtFirst.Focus();
        }
        private void SetDefault()
        {
            if (_ImagePath == "")
            {
                pictureBox1.Image = Properties.Resources.journalist;
            }
            if (_Gender == 0)
                rdMale.Checked = true;
            else rdFemale.Checked = true;
        }
        
        private void linkLSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetImage();
        }

        private void linkLRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ImagePath = "";
            SetDefault();
        }
        
        private void FullComboCountries()
        {
            DataTable dataTable = clsCountries.GetAllCountries();
            foreach (DataRow row in dataTable.Rows)
            {
                cmbCountry.Items.Add(row[0].ToString());
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            SetDefault();
            FullComboCountries();
        }

        private void _Validating(System.Windows.Forms.TextBox Text, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Text.Text))
            {
                e.Cancel = true;
                txtAddress.Focus();
                errorProvider1.SetError(Text, "You Can't Save Without Value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Text, "");
            }
        }
        
        public bool Check()
        {
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        control.Focus();
                        errorProvider1.SetError(control, "You Can't Save Without Value");
                        return false;
                    }
                }
            }
            return true;
        }


        public void ReadOnly()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label)
                    continue;
                control.Enabled = false;
                linkLSetImage.Visible = false;
                linkLRemove.Visible = false;
            }
        }

        private void txtNational_Validating_1(object sender, CancelEventArgs e)
        {
            bool value = clsPeople.CheckExistsNationalNo(txtNational.Text);
            if (value)
            {
                e.Cancel = true;
                txtAddress.Focus();
                errorProvider1.SetError(txtNational, "NationalNo is Exists");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNational, "");
            }
        }

        public void FullPerson()
        {
            People.First = First;
            People.Second = Second;
            People.Third = Third;
            People.Last = Last;
            People.Email = Email;
            People.Address = Address;
            People.BirthDay = BirthDay;
            People.Country = cmbCountry.SelectedIndex;
            People.Gender = Gender;
            People.Phone = Phone;
            People.ImagePath = ImagePath;
            People.National = National;

        }

    }
}
