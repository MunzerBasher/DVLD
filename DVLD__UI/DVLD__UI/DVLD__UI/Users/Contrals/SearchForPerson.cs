
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
    public partial class SearchForPerson : UserControl
    {
        private clsPeople _People = new clsPeople();
        public int PersonID; 
        public event Action<bool> GoNext;

        protected virtual void Next(bool person)
        {
            Action<bool> handler = GoNext;
            if (handler != null)
            { 
                handler(person); 
            }
        }

        public event Action<bool> OnClose;

        protected virtual void Close(bool person)
        {
            Action<bool> handler = OnClose;
            if (handler != null)
            {
                handler(person); 
            }
        }

        public SearchForPerson()
        {
            InitializeComponent();
        }

        private void FullComboBoxByData()
        {
            foreach(string item in clsPeople.arr) 
            {
                Options.Items.Add(item);
            }
            Options.SelectedIndex = 0;
        }

        private void FullContainers()
        {
            if (_People.PersonID != -1)
            {
                userControl11.First = _People.First;
                userControl11.Second = _People.Second;
                userControl11.Third = _People.Third;
                userControl11.Last = _People.Last;
                userControl11.Email = _People.Email;
                userControl11.Address = _People.Address;
                userControl11.BirthDay = _People.BirthDay;
                userControl11.Country = _People.Country;
                userControl11.Gender = _People.Gender;
                userControl11.Phone = _People.Phone;
                userControl11.ImagePath = _People.ImagePath;
                userControl11.National = _People.National;
                userControl11.SetCurrentImage(_People.ImagePath);
                userControl11.SetCurrentCountry(_People.Country);
            }
        }

        private void UserData_Load(object sender, EventArgs e)
        {
            userControl11.btnSave.Text = "Next";
            FullComboBoxByData();
        }

        private void FullPerson()
        {
            _People.First = userControl11.First;
            _People.Second = userControl11.Second;
            _People.Third = userControl11.Third;
            _People.Last = userControl11.Last;
            _People.Email = userControl11.Email;
            _People.Address = userControl11.Address;
            _People.BirthDay = userControl11.BirthDay;
            _People.Country = 1;
            _People.Gender = userControl11.Gender;
            _People.Phone = userControl11.Phone;
            _People.ImagePath = userControl11.ImagePath;
            _People.National = userControl11.National;
        }


        private void userControl11_OnCalculationComplete(bool obj)
        {
            if (obj)
            {
                bool NewPerson = clsPeople.CheckExistsNationalNo(userControl11.National);
                if (!NewPerson)
                {
                    FullPerson();
                    _People.PersonID = -1;
                    MessageBox.Show(_People.PersonID.ToString());
                    bool value = _People.Save();
                    MessageBox.Show(_People.PersonID.ToString());
                    if (_People.PersonID > 0)
                    {
                        PersonID = _People.PersonID;
                        MessageBox.Show(PersonID.ToString() + "Person Saved Successfully ~");
                        Next(obj);
                    }
                    else
                    {   MessageBox.Show("Person Saved Filled ?");}
                }
                else 
                {  
                    Next(obj); 
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            userControl11.FocusIn();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text.Trim().Length > 0) 
            {
                if(int.TryParse(txtSearch.Text, out int ID))
                    _People = clsPeople.FindPerson(ID);
                else
                    _People = clsPeople.FindPerson(txtSearch.Text);
                
                if(_People != null) 
                {
                    PersonID = _People.PersonID;
                    FullContainers();
                }
            }
        }

        private void userControl11_OnClose(bool obj)
        {
            if (OnClose != null)
                OnClose(obj);
        }
    }
}
