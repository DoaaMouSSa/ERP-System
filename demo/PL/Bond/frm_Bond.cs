using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.PL.Bond
{
    public partial class frm_Bond : Form
    {
        private int _frmId;
        public frm_Bond(int frmId)
        {
            InitializeComponent();
            _frmId = frmId;
            setDefaultScreen();
        }
        private void setDefaultScreen()
        {
            if(_frmId == 1)
            {
                lblHeading.Text = "سند الصرف";
                gbBox.Text = "بيانات سند الصرف";
                txtBondType.Text = "1";
            }
            else if(_frmId== 2)
            {
                lblHeading.Text = "سند القبض";
                gbBox.Text = "بيانات سند القبض";
                txtBondType.Text = "2";
            }
            else
            {
                MessageBox.Show("not valid");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }
    }
}
