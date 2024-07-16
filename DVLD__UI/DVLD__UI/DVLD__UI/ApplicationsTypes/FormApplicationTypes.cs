using DVLD__UI.Users;
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
    public partial class FormApplicationTypes : Form
    {
        public FormApplicationTypes()
        {
            InitializeComponent();
        }
        private void _FillByData()
        {
            DataTable dataTable = clsApplicationTypes.GetAllApplicationTypes();
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());

                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                listView1.Items.Add(item);
            }
        }

        private void FormApplicationTypes_Load(object sender, EventArgs e)
        {
            _FillByData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        private void UpdateCurrentApplicationTypes()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    int ID = int.Parse(listView1.SelectedItems[0].Text);
                    FormUpdateApplicationType updateApplicationType = new FormUpdateApplicationType(ID);
                    updateApplicationType.ShowDialog();
                    listView1.Items.Clear();
                    _FillByData();
                }
            }
        }


        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCurrentApplicationTypes();
        }
    }
}
