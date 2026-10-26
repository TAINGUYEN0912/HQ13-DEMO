using System;
using System.Text;
using System.Windows.Forms;
using HQ13Demo.Models;
using HQ13Demo.Services;

namespace HQ13Demo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnOpenHQ13_Click(object sender, EventArgs e)
        {
            using (var frm = new HQ13())
            {
                frm.ShowDialog(this);
            }
        }

        private void btnOpenHQ13A_Click(object sender, EventArgs e)
        {
            using (var frm = new HQ13A())
            {
                frm.ShowDialog(this);
            }
        }
    }
}
