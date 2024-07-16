using DVLD__UI.DVLD__DataAccess;
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
    public partial class FormTestTypes : Form
    {
        public FormTestTypes()
        {
            InitializeComponent();
        }

        private void _FillByData()
        {
            DataTable dataTable = clsTestTypes.GetAllTestTypes();
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                listView1.Items.Add(item);
            }
        }
        
        private void FormTestTypes_Load(object sender, EventArgs e)
        {
            _FillByData();
        }

        private void UpdateCurrentTestTypes()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    int ID = int.Parse(listView1.SelectedItems[0].Text);
                    FormUpdateTestTypes updateTestType = new FormUpdateTestTypes(ID);
                    updateTestType.ShowDialog();
                    listView1.Items.Clear();
                    _FillByData();
                }
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCurrentTestTypes();
        }
    }
}
