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
    public partial class NewLocalLicensePerson : Form
    {
        public NewLocalLicensePerson()
        {
            InitializeComponent();
        }

        private void searchForPerson1_GoNext(bool obj)
        {
            if (obj) 
            {
                NewLocalLicenseData newLocalLicenseData = new NewLocalLicenseData(searchForPerson1.PersonID);
                newLocalLicenseData.ShowDialog();
            }
        }

        private void searchForPerson1_OnClose(bool obj)
        {
            if(obj) 
            { 
                this.Close();
            }
        }
    }
}