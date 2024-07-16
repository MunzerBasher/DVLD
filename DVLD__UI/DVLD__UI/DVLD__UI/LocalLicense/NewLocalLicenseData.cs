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
    public partial class NewLocalLicenseData : Form
    {
        int PersonID;
        public NewLocalLicenseData(int personID)
        {
            InitializeComponent();
            PersonID = personID;
        }

        private void AddDataToApplication()
        {
            string NationalNo = clsPeople.GetPersonNationalNo(PersonID);
            int Fees = newLocalLicense1.Fees;
            int UserID = Login.CurrentUsers.UserID;
            int LicenseClassID = clsLicenseClasses.GetLicenseClassID(newLocalLicense1.LicenseName);
            bool value = clsApplications.clsLocalDrivingLicenseApplications.CheckAbilityToAddClient(newLocalLicense1.LicenseName, NationalNo);
            if (!value)
            {
                clsApplications applications = new clsApplications(PersonID, DateTime.Now, 1, 1, DateTime.Now, Fees, UserID);
                if (applications.Save())
                {
                    clsApplications.clsLocalDrivingLicenseApplications LocalLicense = new clsApplications.clsLocalDrivingLicenseApplications(applications.ApplicationID, LicenseClassID);
                    if (LocalLicense.Save())
                    {
                        MessageBox.Show("Local Driving License Application Added Successfully !");
                    }
                }
                else
                {
                    MessageBox.Show("Application Added Filled !");
                }
            }
            else
            {
                MessageBox.Show("Added Filled ? Client Having Old  Application From This Type !");
            }
        }
        private void newLocalLicense1_OnSave(bool obj)
        {
            if(obj) 
            {
                AddDataToApplication();
            }
            
        }

        private void newLocalLicense1_OnClose(bool obj)
        {
            this.Close();
        }
    }
}