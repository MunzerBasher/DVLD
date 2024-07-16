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


namespace DVLD__UI.Applications
{
    public partial class FormUpdateTestTypes : Form
    {
        private int TestTypeID;
        private clsTestTypes testTypes;
        public FormUpdateTestTypes(int testTypeID)
        {
            InitializeComponent();
            TestTypeID = testTypeID;
            testTypes = clsTestTypes.FindTestTypeByID(testTypeID);
        }

        private void FullContainers()
        {
            if (testTypes != null) 
            {
                txtID.Text = testTypes.TestTypeID.ToString();
                txtTitle.Text = testTypes.TestTypeTitle.ToString();
                txtDesc.Text = testTypes.TestTypeDescription.ToString();
                txtFees.Text = testTypes.TestTypeFees.ToString();
            }
        }

        private void ReFullTestTypeByData()
        {
            testTypes.TestTypeTitle = txtID.Text;
            testTypes.TestTypeDescription = txtDesc.Text;
            testTypes.TestTypeFees = int.Parse(txtFees.Text);
        }

        private void FormUpdateTestTypes_Load(object sender, EventArgs e)
        {
            FullContainers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ReFullTestTypeByData();
            if(testTypes.Save())
            {
                MessageBox.Show("Update Complete Successfully !");
            }
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

        private void txtDesc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDesc.Text))
            {
                e.Cancel = true;
                txtDesc.Focus();
                errorProvider1.SetError(txtDesc, "You Can't Save Without Value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDesc, "");
            }
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
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
    
    
    }
}
