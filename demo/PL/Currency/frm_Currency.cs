using demo.BL.Currency;
using demo.PL.Message;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.PL.Currency
{
    public partial class frm_Currency : Form
    {
        private BL.Currency.cls_Currency CurrencyManager = new BL.Currency.cls_Currency();
        private int currencyID;

        public frm_Currency()
        {
            InitializeComponent();
            LoadCurrencyData();
            EnableOff();
        }

        private void EnableOff()
        {
            btn_Save.Enabled = false;
            rb_foreigner_currency.Enabled = false;
            rb_local_currency.Enabled = false;
            txt_currency_symbol.Enabled = false;
            txt_currency_decent.Enabled = false;
            txt_currency_ename.Enabled = false;
            txt_currency_aname.Enabled = false;
        }

        private void EnableOn()
        {
            txt_currency_aname.Focus();
            rb_foreigner_currency.Enabled = true;
            rb_local_currency.Enabled = true;
            txt_currency_symbol.Enabled = true;
            txt_currency_decent.Enabled = true;
            txt_currency_ename.Enabled = true;
            txt_currency_exchange.Enabled = true;
            txt_currency_aname.Enabled = true;
        }

        private void LoadCurrencyData()
        {
            dgv_currency.Rows.Clear();
            DataTable dt = CurrencyManager.get_all_currency();

            foreach (DataRow row in dt.Rows)
            {
                dgv_currency.Rows.Add(row["curr_no"], row["curr_aname"]);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            EnableOn();
            Clear();
            btn_Save.Enabled = true;
        }

        private void Clear()
        {
            rb_foreigner_currency.Checked = true;
            txt_currency_symbol.Text = string.Empty;
            txt_currency_decent.Text = string.Empty;
            txt_currency_ename.Text = string.Empty;
            txt_currency_exchange.Text = string.Empty;
            txt_currency_aname.Text = string.Empty;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int type = rb_foreigner_currency.Checked ? 2 : 1;

                CurrencyManager.Add_currency(
                    txt_currency_aname.Text,
                    txt_currency_ename.Text,
                    txt_currency_symbol.Text,
                    type,
                    Convert.ToDouble(txt_currency_exchange.Text),
                    txt_currency_decent.Text
                );

                MyMessageBox.ShowMessage("تم عمليه الحفظ", "عملية ناجحه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                LoadCurrencyData();
                EnableOff();
            }
            else
            {
                MyMessageBox.ShowMessage("يرجى تكملة البيانات", "بيانات ناقصه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidateInput()
        {
            if(string.IsNullOrEmpty(txt_currency_aname.Text) 
                && string.IsNullOrEmpty(txt_currency_ename.Text) 
                && string.IsNullOrEmpty(txt_currency_symbol.Text) 
                && string.IsNullOrEmpty(txt_currency_exchange.Text)
                && string.IsNullOrEmpty(txt_currency_decent.Text)) 
            {
                return false;
            }
            return true;
        }

        private void dgv_currency_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            currencyID = Convert.ToInt32(dgv_currency.Rows[e.RowIndex].Cells["CurrencyIDColumn"].Value);

            if (currencyID != 0)
            {
                DataTable dataTable = CurrencyManager.currency_select_one(currencyID);

                if (dataTable.Rows.Count > 0)
                {
                    txt_currency_symbol.Text = dataTable.Rows[0]["curr_symbol"].ToString();
                    txt_currency_decent.Text = dataTable.Rows[0]["curr_decent"].ToString();
                    txt_currency_ename.Text = dataTable.Rows[0]["curr_ename"].ToString();
                    txt_currency_exchange.Text = dataTable.Rows[0]["curr_exchng"].ToString();
                    txt_currency_aname.Text = dataTable.Rows[0]["curr_aname"].ToString();

                    if (Convert.ToInt32(dataTable.Rows[0]["curr_type"].ToString()) == 1)
                    {
                        rb_local_currency.Checked = true;
                    }
                    else
                    {
                        rb_foreigner_currency.Checked = true;
                    }
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (currencyID != 0)
            {
                if (ValidateInput())
                {
                    int type = rb_foreigner_currency.Checked ? 2 : 1;

                    CurrencyManager.currency_update(
                        currencyID,
                        txt_currency_aname.Text,
                        txt_currency_ename.Text,
                        txt_currency_symbol.Text,
                        type,
                        Convert.ToDouble(txt_currency_exchange.Text),
                        txt_currency_decent.Text
                    );

                    MyMessageBox.ShowMessage("تم عمليه التعديل", "عملية ناجحه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    LoadCurrencyData();
                    EnableOff();
                }
                else
                {
                    MyMessageBox.ShowMessage("يرجى تكملة البيانات", "بيانات ناقصه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (currencyID != 0)
            {
                int type = rb_foreigner_currency.Checked ? 2 : 1;

                DialogResult result = MyMessageBox.ShowMessage("هل تود حذف العملة المحدده", "عملية حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    CurrencyManager.currency_delete(currencyID);
                    MyMessageBox.ShowMessage("تم عمليه الحذف", "عملية ناجحه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    LoadCurrencyData();
                    EnableOff();
                }
            }
        }
    }
}