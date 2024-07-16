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
    public partial class Details : Form
    {
        clsPeople People = new clsPeople();
        private int _PersonID = 0;

        public Details(int personID)
        {
            InitializeComponent();
            label1.BackColor = Color.Brown;
            _PersonID = personID;
            label1.Text = "Person Details";
            PersonID.Text = personID.ToString();
            People = clsPeople.FindPerson(personID);

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

        private void Details_Load(object sender, EventArgs e)
        {
            FullContainers();
            userControl11.ReadOnly();
            userControl11.btnSave.Visible = false;
            userControl11.btnClose.Visible = false;
        }
      
    }
}