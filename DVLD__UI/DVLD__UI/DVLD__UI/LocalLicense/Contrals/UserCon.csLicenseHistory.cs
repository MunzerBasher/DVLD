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
    public partial class UserConLicensesHistory : UserControl
    {
        private string _ClassName;
        private int _DriverID;
        public UserConLicensesHistory()
        {
            InitializeComponent();
        }

        private void _FullLocalListView(int DriverID)
        {
            DataTable dt = clsLicenses.GetLocalLicensesHistory(DriverID);
            foreach(DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                _ClassName = clsLicenseClasses.GetLicenseClassName((int)row[2]);
                item.SubItems.Add(_ClassName);
                item.SubItems.Add(((DateTime)row[3]).ToString());
                item.SubItems.Add(((DateTime)row[4]).ToString());
                string IsActive = (int)row[5] == 1 ? "True" : "False";
                item.SubItems.Add(IsActive);
                listViewLocalLicenses.Items.Add(item);
            }

        }

        private void _FullInternationalListView(int DriverID)
        {
            DataTable dt = clsLicenses.GetInternationalLicensesHistory(DriverID);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(_ClassName);
                item.SubItems.Add(((DateTime)row[2]).ToString());
                item.SubItems.Add(((DateTime)row[3]).ToString());
                string IsActive = (int)row[4] == 1 ? "True" : "False";
                item.SubItems.Add(IsActive);
                listViewInternationalLicenses.Items.Add(item);
            }
        }

        public void FullByData(int ApplicationID, bool IsInter=false)
        {
            if(ApplicationID != 0) 
            {
                if(!IsInter) 
                {
                    userConLicenseDetails1.FullLicenseData(ApplicationID);
                }
                else
                {
                    userConLicenseDetails1.InternationalLicenses(ApplicationID);
                }
                    _DriverID = clsLicenses.GetDriverID(ApplicationID);
                    _FullLocalListView(_DriverID);
                    _FullInternationalListView(_DriverID); 
            }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
           
        }
    }

}