using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD__UI.Users
{
    public partial class UserDetails : UserControl
    {
        public UserDetails()
        {
            InitializeComponent();
        }

        public void ReadOnly()
        {
            chIsActive.Enabled = false;
            peopleData1.ReadOnly();
        }
        
        public string UserID
        { 
            get { return lbUserID.Text; }
            set { lbUserID.Text = value; }
        }
        public string UserName
        {
            get { return lbUserName.Text; } 
            set { lbUserName.Text = value; }
        }
        public bool IsActive 
        {
            get { return chIsActive.Checked; }
            set { chIsActive.Checked = value; }
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
            
        }
    }
}
