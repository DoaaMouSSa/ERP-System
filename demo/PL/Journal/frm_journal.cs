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
                        txt_journal_no.Text, accountNumber, txt_acc_name.Text, txt_debit.Text, txt_crdit.Text, db_currency.SelectedValue, db_currency.Text, txt_exch.Text, txt_note.Text, TD, TC
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

            txt_Tcrdit.Text = TC.ToString("0.00");
            txt_Tdebit.Text = TD.ToString("0.00");
            txt_deff.Text = (TD - TC).ToString("0.00");
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
            cal();
            cleaning();
        }

        private void dgv_Journal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            edit_dvg();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
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
            //Add_Journal_hdr();
            Add_Journal_details();
            MyMessageBox.ShowMessage("تم الحفظ بنجاح", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Add_Journal_details()
        {
            if (dgv_Journal.Rows.Count > 0)
            {
                for (int i = 0; i < dgv_Journal.Rows.Count; i++)
                {
                    int accno = Convert.ToInt32(dgv_Journal.Rows[i].Cells["AccountNumberColumn"].Value.ToString());
                    int j_no_hdr_id = Convert.ToInt32(dgv_Journal.Rows[i].Cells["JournalNumberColumn"].Value.ToString());

                    if (double.TryParse(dgv_Journal.Rows[i].Cells["DebitColumn"].Value.ToString(), out double acc_debit))
                    {
                    }
                    else
                    {
                        acc_debit = 0.0;
                    }

                    if (double.TryParse(dgv_Journal.Rows[i].Cells["CrditColumn"].Value.ToString(), out double acc_credit))
                    {
                    }
                    else
                    {
                        acc_credit = 0.0;
                    }

                    int acc_currency = Convert.ToInt32(dgv_Journal.Rows[i].Cells["CurrencyNumberColumn"].Value.ToString());
                    string acc_not = Convert.ToString(dgv_Journal.Rows[i].Cells["NotesColumn"].Value.ToString());
                    //MessageBox.Show($"accno : {accno}, acc_debit : {acc_debit}, acc_credit : {acc_credit}, acc_currency : {acc_currency}, acc_not : {acc_not}, j_no_hdr_id : {j_no_hdr_id}");
                    journalManager.Journal_details_add(accno, acc_debit, acc_credit, acc_currency, acc_not, j_no_hdr_id);
                }
            }
        }
    }
}