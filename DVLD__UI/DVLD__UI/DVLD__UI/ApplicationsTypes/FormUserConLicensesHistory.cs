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
    public partial class FormUserConLicensesHistory : Form
    {
        private int _ApplicationID;
        private bool _IsInter;
        public FormUserConLicensesHistory(int applicationID, bool Inter=false)
        {
            InitializeComponent();
            _ApplicationID = applicationID;
            _IsInter = Inter;
        }

        private void FormUserConLicensesHistory_Load(object sender, EventArgs e)
        {
            if (!_IsInter) 
            {
                userConLicensesHistory1.FullByData(_ApplicationID);
            }
            else
            {
                userConLicensesHistory1.FullByData(_ApplicationID,_IsInter);
            }
        }
    }
}