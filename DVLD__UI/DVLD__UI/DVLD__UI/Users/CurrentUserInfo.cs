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
    public partial class CurrentUserInfo : Form
    {
        private int UserID;
        public CurrentUserInfo(int userID)
        {
            InitializeComponent();
            UserID = userID;
        }

        private void usCoChangePassword1_OnSave(bool obj)
        {
            if (obj) 
            {
                string Password = clsUsers.GetUserPassword(UserID);
                bool value = usCoChangePassword1.NewPassword == usCoChangePassword1.ConFirmPassword;
                if (Password == usCoChangePassword1.UserPassword&& value)
                {
                    Login.CurrentUsers.Password = usCoChangePassword1.NewPassword;
                    Login.CurrentUsers.Save();
                    MessageBox.Show("Password Change Successfully !");
                    this.Close();
                } 
                else 
                { MessageBox.Show("Password is InCorrect !"); }
            }
        }

        private void CurrentUserInfo_Load(object sender, EventArgs e)
        {
            usCoChangePassword1.Title = "Change Password ";
            usCoChangePassword1.Description = "Enter Your Data ~ ";
        }
    }
}

