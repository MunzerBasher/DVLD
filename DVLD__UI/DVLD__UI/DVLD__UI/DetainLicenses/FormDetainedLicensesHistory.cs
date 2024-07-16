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


namespace DVLD__UI.LocalLicense
{
    public partial class FormDetainedLicensesHistory : Form
    {
        public FormDetainedLicensesHistory()
        {
            InitializeComponent();
        }

        private void _FillByData()
        {
            DataTable dataTable = clsLicenses.clsDetainedLicenses.DetainedLicensesHistory();
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                string ClassName = clsLicenseClasses.GetLicenseClassName((int)row[1]);
                item.SubItems.Add(ClassName);
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                string IsActive = (int)row[4] == 1 ? "True" : "False";
                item.SubItems.Add(IsActive);
                item.SubItems.Add(row[5].ToString());
                string IsReleased = (int)row[6] == 1 ? "True" : "False";
                item.SubItems.Add(IsReleased);
                string Date = row[7].ToString();
                string ReleaseDate = Date == "" ? "NULL" : Date;
                item.SubItems.Add(ReleaseDate);
                listView1.Items.Add(item);
            }
        }

        private void FormDetainedLicensesHistory_Load(object sender, EventArgs e)
        {
            _FillByData();
        }

       
    }
}
