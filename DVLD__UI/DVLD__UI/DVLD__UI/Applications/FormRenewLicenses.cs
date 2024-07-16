using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD__UI.People
{
    public partial class FormRenewLicenses : Form
    {
        public FormRenewLicenses()
        {
            InitializeComponent();
        }

        private void userConReNewLicenses1_OnClose(bool obj)
        {
            this.Close();
        }
    }
}