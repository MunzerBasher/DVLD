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

namespace DVLD__UI.Users
{
    public partial class FormUserDetails : Form
    {
        private int UserID;
        private clsPeople people;
        private clsUsers user;
        public FormUserDetails(int userID)
        {
            InitializeComponent();
            UserID = userID;
            user = clsUsers.FindUser(userID);
        }
        private void FullContainers()
        {
            people = clsPeople.FindPerson(user.PersonID);
            if (people != null)
            {
                userDetails1.peopleData1.First = people.First;
                userDetails1.peopleData1.Second = people.Second;
                userDetails1.peopleData1.Third = people.Third;
                userDetails1.peopleData1.Last = people.Last;
                userDetails1.peopleData1.Email = people.Email;
                userDetails1.peopleData1.Address = people.Address;
                userDetails1.peopleData1.BirthDay = people.BirthDay;
                userDetails1.peopleData1.Country = people.Country;
                userDetails1.peopleData1.Gender = people.Gender;
                userDetails1.peopleData1.Phone = people.Phone;
                userDetails1.peopleData1.ImagePath = people.ImagePath;
                userDetails1.peopleData1.National = people.National;
                userDetails1.peopleData1.SetCurrentImage(people.ImagePath);
                userDetails1.peopleData1.SetCurrentCountry(people.Country);
            }
        }

        private void FullData()
        {
            if (user != null) 
            {
                userDetails1.UserID = user.UserID.ToString();
                userDetails1.UserName = user.UserName;
                userDetails1.IsActive = user.IsActive;
                FullContainers();
            }
        }
        private void FormUserDetails_Load(object sender, EventArgs e)
        {
            
            FullData();
            userDetails1.ReadOnly();
        }
    }
}




