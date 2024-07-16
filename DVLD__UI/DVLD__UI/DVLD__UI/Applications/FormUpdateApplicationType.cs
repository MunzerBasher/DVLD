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


namespace DVLD__UI.DVLD__DataAccess
{
    public partial class FormUpdateApplicationType : Form
    {
        private int ApplicationTypeID;
        private clsApplicationTypes _Application;
        public FormUpdateApplicationType(int applicationTypeID)
        {
            InitializeComponent();
            ApplicationTypeID = applicationTypeID;
            _Application = clsApplicationTypes.FindApplicationTypesByID(ApplicationTypeID);
        }
        private void FullContainers()
        {
            if (_Application != null)
            {
                txtID.Text = _Application.ApplicationTypesID.ToString();  
                txtTitle.Text = _Application.ApplicationTypesTitle.ToString();
                txtFees.Text = _Application.ApplicationFees.ToString();
            }
        }

        private void FormUpdateApplicationType_Load(object sender, EventArgs e)
        {
            FullContainers();
        }

        private void FullApplication()
        {
            _Application.ApplicationTypesTitle = txtTitle.Text.ToString();
            _Application.ApplicationFees = int.Parse(txtFees.Text);  
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                e.Cancel = true;
                txtTitle.Focus();
                errorProvider1.SetError(txtTitle, "You Can't Save Without Value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTitle, "");
            }
        }

        private void txtFees_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text))
            {
                e.Cancel = true;
                txtFees.Focus();
                errorProvider1.SetError(txtFees, "You Can't Save Without Value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFees, "");
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FullApplication();
            if (_Application.Save())
            {
                MessageBox.Show("Update Successful ~");
            }
        }
    }
}