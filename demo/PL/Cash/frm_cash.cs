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
using demo.BL.Accounts;
namespace demo.PL.Cash
{
    public partial class frm_cash : Form
    {
        private int Bank_Cash;
         demo.BL.Cashes.Cash cash = new demo.BL.Cashes.Cash();
        demo.BL.Banks.Bank bank = new demo.BL.Banks.Bank();
        demo.BL.Accounts.Account account = new demo.BL.Accounts.Account();

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
            this.Close();
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtAccNo.Text = String.Empty;
            txtAccName.Text = String.Empty;
            txtAccEName.Text = String.Empty;
            txtAccNo.Enabled = true;
            txtAccNo.Focus();
        }

        private void txtAccNo_KeyDown(object sender, KeyEventArgs e)
        {
            //txtAccName.Text = txtAccNo.Text;
        }

        private void txtAccNo_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAccNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAccNo_KeyUp(object sender, KeyEventArgs e)
        {

            if(txtAccNo.Text != "")
            {
                int acc_no = Convert.ToInt32(txtAccNo.Text);
                string acc_name = account.getAccName(acc_no);
                txtAccName.Text = acc_name;
            }
           
        }
    }
}
