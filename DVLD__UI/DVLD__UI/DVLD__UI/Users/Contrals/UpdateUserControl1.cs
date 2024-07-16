using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace DVLD__UI.Users
{
    public partial class UpdateUserControl1 : UserControl
    {
        public UpdateUserControl1()
        {
            InitializeComponent();
        }
        public event Action<bool> OnEnd;

        protected virtual void Ended(bool person)
        {
            Action<bool> handler = OnEnd;
            if (handler != null)
            { handler(person); }
        }

        public event Action<bool> OnLinkClicked;

        protected virtual void LinkClicked(bool person)
        {
            Action<bool> handler = OnLinkClicked;
            if (handler != null)
            { handler(person); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (OnEnd != null)
            {
                bool Value = peopleData1.Check();
                Ended(Value);
                
            }
               
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (OnLinkClicked != null)
                LinkClicked(true);
        }
    }
}
