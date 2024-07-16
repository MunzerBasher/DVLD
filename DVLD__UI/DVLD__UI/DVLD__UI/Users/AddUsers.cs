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
    public partial class AddUsers : Form
    {
        int UserID;
        private clsPeople people = new clsPeople();
        public AddUsers(int userID)
        {
            InitializeComponent();
            UserID = userID;
        }
        private void FullPerson()
        {
            people.First = userData1.userControl11.First;
            people.Second = userData1.userControl11.Second;
            people.Third = userData1.userControl11.Third;
            people.Last = userData1.userControl11.Last;
            people.Email = userData1.userControl11.Email;
            people.Address = userData1.userControl11.Address;
            people.BirthDay = userData1.userControl11.BirthDay;
            people.Country = userData1.userControl11.Country;
            people.Gender = userData1.userControl11.Gender;
            people.Phone = userData1.userControl11.Phone;
            people.ImagePath = userData1.userControl11.ImagePath;
            people.National = userData1.userControl11.National;
        }

        private void userData1_GoNext(bool obj)
        {
            if (obj) 
            {
                // MessageBox.Show("Go Next");
                Next next = new Next(userData1.PersonID);
                //clsCommand.ShowForm(next, panel1);
            }
            
        }

        private void AddUsers_Load(object sender, EventArgs e)
        {

        }

        private void userData1_Load(object sender, EventArgs e)
        {

        }

        private void userData1_OnClose(bool obj)
        {
            if (obj) 
            {
                this.Close();
            }
        }
    }
}
