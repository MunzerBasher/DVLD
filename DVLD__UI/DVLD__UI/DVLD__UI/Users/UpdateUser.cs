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
    public partial class UpdateUser : Form
    {
        int UserID;
        private clsPeople people = new clsPeople();
        private clsUsers users = new clsUsers();
        private bool value  = false;
        public UpdateUser(int userID)
        {
            InitializeComponent();
            UserID = userID;
            users = clsUsers.FindUser(userID);
        }
        private void FullPerson()
        {
            people.First = updateUserControl11.peopleData1.First;
            people.Second = updateUserControl11.peopleData1.Second;
            people.Third  = updateUserControl11.peopleData1.Third;
            people.Last = updateUserControl11.peopleData1.Last;
            people.Email = updateUserControl11.peopleData1.Email;
            people.Address = updateUserControl11.peopleData1.Address;
            people.BirthDay = updateUserControl11.peopleData1.BirthDay;
            people.Country = updateUserControl11.peopleData1.Country;
            people.Gender = updateUserControl11.peopleData1.Gender;
            people.Phone = updateUserControl11.peopleData1.Phone;
            people.ImagePath = updateUserControl11.peopleData1.ImagePath;
            people.National = updateUserControl11.peopleData1.National;
        }
        
        private void FullContainers()
        {
            people = clsPeople.FindPerson(users.PersonID);
            if (people != null)
            {
                updateUserControl11.peopleData1.First =      people.First;
                updateUserControl11.peopleData1.Second =     people.Second;
                updateUserControl11.peopleData1.Third =      people.Third;
                updateUserControl11.peopleData1.Last =       people.Last;
                updateUserControl11.peopleData1.Email =      people.Email;
                updateUserControl11.peopleData1.Address =    people.Address;
                updateUserControl11.peopleData1.BirthDay =   people.BirthDay;
                updateUserControl11.peopleData1.Country =    people.Country;
                updateUserControl11.peopleData1.Gender =     people.Gender;
                updateUserControl11.peopleData1.Phone =      people.Phone;
                updateUserControl11.peopleData1.ImagePath =  people.ImagePath;
                updateUserControl11.peopleData1.National =   people.National;
                updateUserControl11.peopleData1.SetCurrentImage(people.ImagePath);
                updateUserControl11.peopleData1.SetCurrentCountry(people.Country);
            
            }
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            userChange1.Visible = false;
            FullContainers();
        }

        private void updateUserControl11_OnEnd(bool obj)
        {
            if (obj)
            {
                FullPerson();
                people.Save();
                this.Close();
            }
            
        }


        private void updateUserControl11_OnLinkClicked(bool obj)
        {
            value = updateUserControl11.peopleData1.Check();
            if (value)
            {
                if(obj) 
                {
                    FullPerson();
                    people.Save();
                    updateUserControl11.Visible = false;
                    userChange1.Visible = true;
                    FullUserControlByUserData();
                }
            }
            else 
            {
                MessageBox.Show("Check All Data in Fields ?");
            }
            
        }
        private void FullUserControlByUserData()
        {
            userChange1.UserID = users.UserID.ToString();
            userChange1.UserName = users.UserName.ToString();
            userChange1.IsActive = users.IsActive;
        }

        private void FullUserData()
        {
            users.UserName = userChange1.UserName;
            users.Password = userChange1.NewPassword;
            users.IsActive = userChange1.IsActive;
        }

        private void userChange1_OnSave(bool obj)
        {
            if(obj)
            {
                bool Check = (userChange1.NewPassword == userChange1.ConFirmPassword) ? true : false;   
                if (clsUsers.GetUserPassword(UserID) != userChange1.UserPassword || (!Check))
                {
                    MessageBox.Show("Password Is Not Correct ?");
                }
                else 
                {
                    FullUserData();
                    users.Save(); 
                }
            }

        }

        private void userChange1_OnClose(bool obj)
        {
            this.Close();
        }
    }
}
