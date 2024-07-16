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
    public partial class Next : Form
    {
        int PersonID;

        clsUsers user = new clsUsers();
        public Next(int personID)
        {
            InitializeComponent();
            PersonID = personID;
        }

        private void SetDefaultUserData()
        {
            userNext1.Title = "Add New User";
            userNext1.Description = "Enter User Information ";
            
        }

        private void FullUser()
        {
            user.PersonID = PersonID;
            user.UserName = userNext1.UserName;
            user.Password = userNext1.UserPassword;
            user.IsActive = userNext1.IsActive;
        }

        private void  FullContainers()
        {
            userNext1.UserName = user.UserName;
            userNext1.IsActive = user.IsActive;
        }

        private void Next_Load(object sender, EventArgs e)
        {
            SetDefaultUserData();
        }

        private void userNext1_OnClose(bool obj)
        {
            if (obj) { this.Close(); }
        }
        private void Main()
        {
            FullUser();
            if(user.Save())
            {
                MessageBox.Show("User Save Successfully !");
                userNext1.Title = "Update User";
                userNext1.UserID = user.UserID.ToString();
            }
            else 
            {
                MessageBox.Show("user Save Fill ?");            
            }

        }

        private void userNext1_OnSave(bool obj)
        {
            if (obj) 
            {
                Main();

            }

        }
    }
}
