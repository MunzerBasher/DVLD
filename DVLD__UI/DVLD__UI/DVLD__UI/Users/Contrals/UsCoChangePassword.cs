using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD__UI
{
    public partial class UsCoChangePassword : UserControl
    {
        public UsCoChangePassword()
        {
            InitializeComponent();
        }

        public bool Check()
        {
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        control.Focus();
                        errorProvider1.SetError(control, "You Can't Save Without Value");
                        return false;
                    }
                }
            }
            return true;
        }
        
        public bool IsEqual()
        {
            return ((txtConfirmPassword.Text == txtNewPassword.Text));
        }
        
        public string Title
        {
            get
            { return lbTitle.Text; }
            set
            { lbTitle.Text = value; }
        }
        public string Description
        {
            get { return lbAddress.Text; }
            set { lbAddress.Text = value; }
        }
        public string UserPassword
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        public string NewPassword
        {
            get { return txtNewPassword.Text; }
            set { txtNewPassword.Text = value; }
        }
        public string ConFirmPassword
        {
            get { return txtConfirmPassword.Text; }
            set { txtConfirmPassword.Text = value; }
        }

        public event Action<bool> OnSave;

        protected virtual void Save(bool person)
        {
            Action<bool> handler = OnSave;
            if (handler != null)
            { handler(person); }
        }
        public event Action<bool> OnClose;

        protected virtual void Close(bool person)
        {
            Action<bool> handler = OnClose;
            if (handler != null)
            { handler(person); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool value = Check();
            if (!value)
            { MessageBox.Show("There Empty Field ~"); }
            bool value2 = IsEqual();
            if (!value2)
            {
                if ((txtConfirmPassword.Text != txtPassword.Text))
                {
                    txtConfirmPassword.Focus();
                    errorProvider1.SetError(txtConfirmPassword, "Confirm Password not Correct !");
                }
                else
                {
                    errorProvider1.SetError(txtConfirmPassword, "");
                }
            }
            if (OnSave != null)
                Save(value);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (OnClose != null)
                Close(true);
        }
    }
}
