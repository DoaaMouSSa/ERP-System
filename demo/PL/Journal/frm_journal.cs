using demo.BL.Currency;
using demo.BL.Journal;
using demo.PL.Message;
using demo.PL.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.PL.Journal
{
    public partial class frm_journal : Form
    {
        private cls_Journal journalManager;
        private cls_Currency currencyManager;

        public frm_journal()
        {
            InitializeComponent();
            InitializeManagers();
            LoadDropdownLists();
            SetDefaultExchangeRate();
        }

        private void InitializeManagers()
        {
            journalManager = new cls_Journal();
            currencyManager = new cls_Currency();
        }

        private void LoadDropdownLists()
        {
            try
            {
                db_currency.DataSource = currencyManager.get_all_currency();
                db_currency.ValueMember = "curr_no";
                db_currency.DisplayMember = "curr_aname";
            }
            catch
            {
                MyMessageBox.ShowMessage("يوجد خطأ في تحميل العملات", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetDefaultExchangeRate()
        {
            if (db_currency.SelectedIndex != -1)
            {
                DataTable dataTable = currencyManager.get_currency_exchange(db_currency.Text);
                if (dataTable.Rows.Count > 0)
                {
                    txt_exch.Text = dataTable.Rows[0][2].ToString();
                    txt_note.Focus();
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt_exch.Text, out double exchangeRate))
            {
                double TD = 0;
                double TC = 0;

                if (!string.IsNullOrEmpty(txt_crdit.Text))
                {
                    TC = Convert.ToDouble(txt_crdit.Text) * exchangeRate;
                }

                if (!string.IsNullOrEmpty(txt_debit.Text))
                {
                    TD = Convert.ToDouble(txt_debit.Text) * exchangeRate;
                }

                string accountNumber = txt_acc_no.Text;

                if (!IsAccountNumberExists(accountNumber))
                {
                    dgv_Journal.Rows.Add(
                        txt_journal_no.Text, 
                        accountNumber, 
                        txt_acc_name.Text, 
                        txt_debit.Text, 
                        txt_crdit.Text, 
                        db_currency.SelectedValue, 
                        db_currency.Text, 
                        txt_exch.Text, 
                        txt_note.Text, 
                        TD, 
                        TC
                    );

                    cleaning();
                    cal();
                }
                else
                {
                    MyMessageBox.ShowMessage("تم إدخال رقم الحساب مسبقًا.", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MyMessageBox.ShowMessage("يوجد خطأ في تحويل العملات", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsAccountNumberExists(string accountNumber)
        {
            foreach (DataGridViewRow row in dgv_Journal.Rows)
            {
                if (row.Cells["AccountNumberColumn"].Value != null && row.Cells["AccountNumberColumn"].Value.ToString() == accountNumber)
                {
                    return true;
                }
            }
            return false;
        }

        private void cleaning()
        {
            txt_acc_no.Text = string.Empty;
            txt_acc_name.Text = string.Empty;
            txt_debit.Text = string.Empty;
            txt_crdit.Text = string.Empty;
            db_currency.SelectedIndex = -1;
            txt_exch.Text = string.Empty;
            txt_note.Text = string.Empty;
        }

        private void cal()
        {
            double TD = 0;
            double TC = 0;

            for (int i = 0; i < dgv_Journal.Rows.Count; i++)
            {
                TD += Convert.ToDouble(dgv_Journal.Rows[i].Cells["TotalDebitColumn"].Value);
                TC += Convert.ToDouble(dgv_Journal.Rows[i].Cells["TotalCrditColumn"].Value);
            }

            txt_Tcrdit.Text = TC.ToString(/*"0.00"*/);
            txt_Tdebit.Text = TD.ToString(/*"0.00"*/);
            txt_deff.Text = (TD - TC).ToString(/*"0.00"*/);
        }

        private void db_currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDefaultExchangeRate();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_Journal.Rows.RemoveAt(dgv_Journal.CurrentRow.Index);
            cal();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit_dvg();
            dgv_Journal.Rows.RemoveAt(dgv_Journal.CurrentRow.Index);
        }

        private void edit_dvg()
        {
            txt_acc_no.Text = dgv_Journal.CurrentRow.Cells["AccountNumberColumn"].Value.ToString();
            txt_acc_name.Text = dgv_Journal.CurrentRow.Cells["AccountNameColumn"].Value.ToString();
            txt_debit.Text = dgv_Journal.CurrentRow.Cells["DebitColumn"].Value.ToString();
            txt_crdit.Text = dgv_Journal.CurrentRow.Cells["CrditColumn"].Value.ToString();
            db_currency.SelectedValue = dgv_Journal.CurrentRow.Cells["CurrencyNumberColumn"].Value.ToString();
            txt_exch.Text = dgv_Journal.CurrentRow.Cells["ExchangeColumn"].Value.ToString();
            txt_note.Text = dgv_Journal.CurrentRow.Cells["NotesColumn"].Value.ToString();

        }

        private void dgv_Journal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            edit_dvg();
            dgv_Journal.Rows.RemoveAt(dgv_Journal.CurrentRow.Index);
        }


        private void btn_new_Click(object sender, EventArgs e)
        {
            journalManager = new cls_Journal();
            btn_Save.Enabled = true;
            txt_journal_no.Text = journalManager.Generate_JNo().Rows[0][0].ToString();
            txt_JNotes.Text = string.Empty;
            txt_JNotes.Focus();
            cal();
            cleaning();
            dgv_Journal.Rows.Clear();

        }

        private void Add_Journal_hdr()
        {
            DateTime Jdate = Convert.ToDateTime(db_Jdate.Value.ToLongDateString());
            DateTime Adate = DateTime.Now;
            int jType = rb_general.Checked ? 1 : (rb_stuck.Checked ? 4 : 0);
            int jPost = cb_post.Checked ? 1 : 0;

            journalManager.Journal_hdr_add(
                Convert.ToInt32(txt_journal_no.Text),
                Jdate,
                txt_JNotes.Text,
                jType,
                jPost,
                Convert.ToDouble(txt_Tdebit.Text),
                Convert.ToDouble(txt_Tcrdit.Text),
                Convert.ToDouble(txt_deff.Text),
                1,//userID
                Adate,
                Convert.ToInt32(db_currency.SelectedValue)
            );

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Add_Journal_hdr();
            Add_Journal_details();
            MyMessageBox.ShowMessage("تم الحفظ بنجاح", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Add_Journal_details()
        {
            foreach (DataGridViewRow row in dgv_Journal.Rows)
            {
                if (!row.IsNewRow)
                    journalManager = new cls_Journal();
                int accno = Convert.ToInt32(row.Cells["AccountNumberColumn"].Value.ToString());
                int j_no_hdr_id = Convert.ToInt32(row.Cells["JournalNumberColumn"].Value.ToString());

                if (double.TryParse(row.Cells["DebitColumn"].Value.ToString(), out double acc_debit))
                {
                }
                else
                {
                    acc_debit = 0.0;
                }

                if (double.TryParse(row.Cells["CrditColumn"].Value.ToString(), out double acc_credit))
                {
                }
                else
                {
                    acc_credit = 0.0;
                }

                int acc_currency = Convert.ToInt32(row.Cells["CurrencyNumberColumn"].Value.ToString());
                string acc_not = Convert.ToString(row.Cells["NotesColumn"].Value.ToString());
                double acc_currency_exchange = Convert.ToDouble(row.Cells["ExchangeColumn"].Value.ToString());

                if (double.TryParse(row.Cells["TotalDebitColumn"].Value.ToString(), out double acc_total_debit))
                {
                }
                else
                {
                    acc_total_debit = 0.0;
                }

                if (double.TryParse(row.Cells["TotalCrditColumn"].Value.ToString(), out double acc_total_credit))
                {
                }
                else
                {
                    acc_total_credit = 0.0;
                }
                
                journalManager.Journal_details_add(accno, acc_debit, acc_credit, acc_currency, acc_not, j_no_hdr_id, acc_currency_exchange, acc_total_debit, acc_total_credit);

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_search.Text, out int j))
            {
                try
                {
                    SJ_Header(j);
                    SJ_Details(j);
                }
                catch
                {

                    MyMessageBox.ShowMessage("يرجى المحاوله مره اخرى", "عملية خاطئة", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MyMessageBox.ShowMessage("يرجى التحقق من رقم القيد.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SJ_Header(int j_no)
        {
            try
            {
                journalManager = new cls_Journal();
                DataTable dataTable = journalManager.select_Journal_hdr(j_no);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow firstRow = dataTable.Rows[0];

                    txt_journal_no.Text = firstRow["j_no"].ToString();
                    txt_Tdebit.Text = firstRow["t_debit"].ToString();
                    txt_Tcrdit.Text = firstRow["t_credit"].ToString();
                    txt_deff.Text = firstRow["t_balance"].ToString();
                    txt_JNotes.Text = firstRow["j_note"].ToString();
                    db_currency.SelectedValue = Convert.ToInt32(firstRow["curr_no"]);
                    db_Jdate.Value = Convert.ToDateTime(firstRow["j_date"]);

                    int jType = Convert.ToInt32(firstRow["j_type"]);
                    rb_stuck.Checked = (jType == 4);
                    rb_general.Checked = (jType == 1);

                    cb_post.Checked = Convert.ToInt32(firstRow["j_post"]) == 1;

                }
                else
                {
                    MyMessageBox.ShowMessage("يرجى التحقق من رقم القيد", "لا يوجد", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch
            {
                MyMessageBox.ShowMessage("يوجد خطأ اثناء تحميل البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SJ_Details(int j_no)
        {
            dgv_Journal.Rows.Clear();
            journalManager = new cls_Journal();
            DataTable dataTable = journalManager.select_Journal_details(j_no);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    dgv_Journal.Rows.Add(
                        dr["j_no_hdr_id"],
                        dr["acc_no"],
                        dr["acc_name"],
                        dr["acc_debit"],
                        dr["acc_credit"],
                        dr["acc_currency"],
                        dr["curr_aname"],
                        dr["acc_currency_exchange"],
                        dr["acc_not"],
                        dr["acc_total_debit"],
                        dr["acc_total_credit"]
                    );
                }
            }

        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_acc_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_debit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txt_crdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txt_exch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Edit_Journal_hdr();
            Edit_Journal_details();
            MyMessageBox.ShowMessage("تم التعديل بنجاح", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Edit_Journal_hdr()
        {
            journalManager = new cls_Journal();
            DateTime Jdate = Convert.ToDateTime(db_Jdate.Value.ToLongDateString());
            DateTime Adate = DateTime.Now;
            int jType = rb_general.Checked ? 1 : (rb_stuck.Checked ? 4 : 0);
            int jPost = cb_post.Checked ? 1 : 0;

            journalManager.Journal_hdr_Update(
                Convert.ToInt32(txt_journal_no.Text),
                Jdate,
                txt_JNotes.Text,
                jType,
                jPost,
                Convert.ToDouble(txt_Tdebit.Text),
                Convert.ToDouble(txt_Tcrdit.Text),
                Convert.ToDouble(txt_deff.Text),
                1,//userID
                Adate,
                Convert.ToInt32(db_currency.SelectedValue)
            );

         }

        private void Edit_Journal_details()
        {
            foreach (DataGridViewRow row in dgv_Journal.Rows)
            {
                if (!row.IsNewRow)
                    journalManager = new cls_Journal();
                int accno = Convert.ToInt32(row.Cells["AccountNumberColumn"].Value.ToString());
                int j_no_hdr_id = Convert.ToInt32(row.Cells["JournalNumberColumn"].Value.ToString());

                if (double.TryParse(row.Cells["DebitColumn"].Value.ToString(), out double acc_debit))
                {
                }
                else
                {
                    acc_debit = 0.0;
                }

                if (double.TryParse(row.Cells["CrditColumn"].Value.ToString(), out double acc_credit))
                {
                }
                else
                {
                    acc_credit = 0.0;
                }

                int acc_currency = Convert.ToInt32(row.Cells["CurrencyNumberColumn"].Value.ToString());
                string acc_not = Convert.ToString(row.Cells["NotesColumn"].Value.ToString());
                double acc_currency_exchange = Convert.ToDouble(row.Cells["ExchangeColumn"].Value.ToString());
                if (double.TryParse(row.Cells["TotalDebitColumn"].Value.ToString(), out double acc_total_debit))
                {
                }
                else
                {
                    acc_total_debit = 0.0;
                }

                if (double.TryParse(row.Cells["TotalCrditColumn"].Value.ToString(), out double acc_total_credit))
                {
                }
                else
                {
                    acc_total_credit = 0.0;
                }

                journalManager.Journal_details_Update(accno, acc_debit, acc_credit, acc_currency, acc_not, j_no_hdr_id, acc_currency_exchange, acc_total_debit, acc_total_credit);


            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_journal_no.Text))
            {
                DialogResult = MyMessageBox.ShowMessage("", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    journalManager = new cls_Journal();
                    cls_Journal cls_Journal = new cls_Journal();
                    int jo_no = Convert.ToInt32(txt_journal_no.Text);
                    journalManager.Journal_hdr_Delete(jo_no);
                    cls_Journal.Journal_details_Delete(jo_no);
                    MyMessageBox.ShowMessage("تم المسح بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cal();
                    cleaning();
                    dgv_Journal.Rows.Clear();
                    txt_journal_no.Text = string.Empty;
                    txt_JNotes.Text = string.Empty;
                    cb_post.Checked = false;
                    rb_general.Checked = true;
                    txt_search.Text = string.Empty;
                    db_Jdate.Value = DateTime.Now;
                }
            }
            else
            {
                MyMessageBox.ShowMessage("","",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            
        }

        private void txt_acc_no_KeyUp(object sender, KeyEventArgs e)
        {
            BL.Account.cls_accounts cls_Accounts = new BL.Account.cls_accounts();
            if (txt_acc_no.Text != "")
            {
                int acc_no = Convert.ToInt32(txt_acc_no.Text);
                var acc_name = cls_Accounts.getAccName(acc_no);
                txt_acc_name.Text = acc_name.ToString();
            }
            if (txt_acc_no.Text == string.Empty)
            {
                txt_acc_name.Text = string.Empty;
            }
        }

        
    }
}