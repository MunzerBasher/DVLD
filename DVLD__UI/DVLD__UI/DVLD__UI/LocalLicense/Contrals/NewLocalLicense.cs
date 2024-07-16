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
    public partial class NewLocalLicense : UserControl
    {
        public NewLocalLicense()
        {
            InitializeComponent();
        }

        private void UserControlLocalLicense_Load(object sender, EventArgs e)
        {
            FullComboCountries();
            lbDate.Text = DateTime.Now.ToString();
            lbUser.Text = Login.CurrentUsers.UserName.ToString();
            lbDlID.Text = "[ ??? ]";
            lbFees.Text = clsLicenseClasses.GetLicenseFees(ComLicensesClass.SelectedIndex).ToString();
        }


        public int Fees
        {
            get { return (int.Parse(lbFees.Text)); }
        }
        public int ApplicationID
        {  get; set; }
        public string ApplicationDate
        { get; }
        public string LicenseName
        { get { return ComLicensesClass.SelectedItem.ToString(); } }
        public int CreateByUserID
        { get { return Login.CurrentUsers.UserID; } }



        public event Action<bool> OnSave;

        protected virtual void Save(bool value)
        {
            Action<bool> handler = OnSave;
            if (handler != null)
            { handler(value); }
        }
        public event Action<bool> OnClose;

        protected virtual void Close(bool value)
        {
            Action<bool> handler = OnClose;
            if (handler != null)
            { handler(value); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (OnSave != null)
                Save(true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (OnClose != null)
                Close(true);
        }

        private void FullComboCountries()
        {
            DataTable dataTable = clsLicenseClasses.GetAllLicenseClasses();
            foreach (DataRow row in dataTable.Rows)
            {
                ComLicensesClass.Items.Add(row[0].ToString());
            }
            ComLicensesClass.SelectedIndex = 0;
        }

        private void ComLicensesClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbFees.Text = clsLicenseClasses.GetLicenseFees(ComLicensesClass.SelectedIndex).ToString();
        }
    }
}
