using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD__UI.LocalLicense
{
    public partial class FormApplicationDetails : Form
    {
        private int _ApplicationID;
        public FormApplicationDetails(int applicationID)
        {
            InitializeComponent();
            _ApplicationID = applicationID;
        }
        

        private void FormApplicationDetails_Load(object sender, EventArgs e)
        {
            userApplicationDetails1.FullUserControlByData(_ApplicationID);
        }

        private void userApplicationDetails1_OnClose(bool obj)
        {
            this.Close();   
        }
    }
}
