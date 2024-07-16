using DVLD__UI.People;
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
    public partial class AddOrEditPerson : Form
    {
        private int ID = -1;
        clsPeople People = new clsPeople();
        public delegate void DataBackEventHandler(object sender, bool value);

        public event DataBackEventHandler DataBack;
        
        public AddOrEditPerson(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            People.PersonID = ID;
            label1.BackColor = Color.Brown;
            if (ID == -1) 
            { 
                label1.Text = "Add New Person";
            }
            else 
            { 
                label1.Text = "Update  Person";
                PersonID.Text = ID.ToString();
                People = clsPeople.FindPerson(ID);
            }
        }
                
        private void FullPerson()
        {
            People.First =     userControl11.First;
            People.Second =    userControl11.Second;
            People.Third =     userControl11.Third;
            People.Last =      userControl11.Last;
            People.Email =     userControl11.Email;
            People.Address =   userControl11.Address;
            People.BirthDay =  userControl11.BirthDay;
            People.Country = userControl11.cmbCountry.SelectedIndex;
            People.Gender =    userControl11.Gender;
            People.Phone =     userControl11.Phone;
            People.ImagePath = userControl11.ImagePath;
            People.National =  userControl11.National;   
            
        }
        
        private void FullContainers()
        { 
            if (People.PersonID != -1)
            {
                userControl11.First = People.First;
                userControl11.Second = People.Second;
                userControl11.Third = People.Third;
                userControl11.Last = People.Last;
                userControl11.Email = People.Email;
                userControl11.Address = People.Address;
                userControl11.BirthDay = People.BirthDay;
                userControl11.Country = People.Country;
                userControl11.Gender = People.Gender;
                userControl11.Phone = People.Phone;
                userControl11.ImagePath = People.ImagePath;
                userControl11.National = People.National;
                userControl11.SetCurrentImage(People.ImagePath);
                userControl11.SetCurrentCountry(People.Country);
            }
        }
        
        private void Main()
        {
            FullPerson();
            if (People.Save()) 
            {
                MessageBox.Show("People With "+People.PersonID.ToString()+" ID Save Successfully !","Warning" );      
            }
            else 
            {
                MessageBox.Show("People With "+People.PersonID.ToString()+"ID  Save Fill ?"); 
            }
        }

        private void AddOrEditPerson_Load(object sender, EventArgs e)
        {
            FullContainers();
        }

        private void userControl11_OnCalculationComplete(bool obj)
        {
            if (obj) 
            {
                Main();
            }
        }

        private void userControl11_OnClose(bool obj)
        {
            DataBack?.Invoke(this, true);
            this.Close();
        }
    }
}