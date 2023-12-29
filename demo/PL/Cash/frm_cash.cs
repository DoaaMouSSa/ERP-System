using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.PL.Cash
{
    public partial class frm_cash : Form
    {
        private int Bank_Cash;
        public frm_cash(int BankOrCash)
        {
            //cash===>1
            //bank===>2
            Bank_Cash = BankOrCash;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_cash_Load(object sender, EventArgs e)
        {
            if (Bank_Cash == 1)
            {
                lblHeading.Text = "الصناديق";
                txtCtrl.Text = "1";
                gpMoney.Text = "الصناديق";
            }
            else if (Bank_Cash == 2)
            {
                lblHeading.Text = "البنوك";
                txtCtrl.Text = "2";
                gpMoney.Text = "البنوك";

            }
            else
            {
                Application.Exit();
            }
        }
    }
}
