using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DVLD_Buisness;
namespace DVLD__UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static clsUsers CurrentUsers = new clsUsers();
        private bool CheckTextBoxes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        control.Focus();
                        errorProvider1.SetError(control, "You Can't Let Without Value");
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool value = CheckTextBoxes();
            if (value) 
            {
                CurrentUsers = clsUsers.FindUser(txtUserName.Text,txtPassword.Text);
                string Password = clsUsers.GetUserPassword(CurrentUsers.UserID);
                if (CurrentUsers != null && Password == txtPassword.Text) 
                {
                    frmMain form1 = new frmMain();
                    form1.DataBack += Form2_DataBack;
                    form1.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Error in UserName Or Password ?");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        private void Form2_DataBack(object sender, bool value)
        {
            this.Visible = true;
            StartData();
        }
        private void StartData()
        {
            txtUserName.Focus();
            if (!chBReminder.Checked)
            {
                txtPassword.Text = "";
                txtUserName.Text = "";
            }
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
            StartData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
