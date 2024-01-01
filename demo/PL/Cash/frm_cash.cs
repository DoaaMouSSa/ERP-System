using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo.BL.Cashes;
using demo.BL.Banks;
namespace demo.PL.Cash
{
    public partial class frm_cash : Form
    {
        private int Bank_Cash;
         demo.BL.Cashes.Cash cash = new demo.BL.Cashes.Cash();
        demo.BL.Banks.Bank bank = new demo.BL.Banks.Bank();

        public frm_cash(int BankOrCash)
        {
            //cash===>1
            //bank===>2
            Bank_Cash = BankOrCash;
            InitializeComponent();
        }
        void fillCashDgv()
        {
            dgv.DataSource = cash.getAll();
            dgv.Columns[0].HeaderText = "رقم الحساب";
            dgv.Columns[1].HeaderText = "اسم الحساب";
            dgv.Columns[2].HeaderText = "اسم الحساب انجليزى";
        }
        void fillBankDgv()
        {
            dgv.DataSource = bank.getAll();
            dgv.Columns[0].HeaderText = "رقم الحساب";
            dgv.Columns[1].HeaderText = "اسم الحساب";
            dgv.Columns[2].HeaderText = "اسم الحساب انجليزى";
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
                fillCashDgv();
            }
            else if (Bank_Cash == 2)
            {
                lblHeading.Text = "البنوك";
                txtCtrl.Text = "2";
                gpMoney.Text = "البنوك";
                fillBankDgv();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
