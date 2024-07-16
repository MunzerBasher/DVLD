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
    public partial class FormDetainedLicensesInfo : Form
    {
        public FormDetainedLicensesInfo()
        {
            InitializeComponent();
        }
        private void _FillByData()
        {
            DataTable dataTable = clsLicenses.clsDetainedLicenses.DetainedLicensesInfo();
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());
                string IsActive = (int)row[5]== 1 ? "True" : "False";
                item.SubItems.Add(IsActive);
                listView1.Items.Add(item);
            }
        }


        private void FormDetainedLicensesInfo_Load(object sender, EventArgs e)
        {
            _FillByData();
        }
    }
}
