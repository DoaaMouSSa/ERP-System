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

namespace demo.PL.Journal
{
    public partial class frm_journal : Form
    {
        public frm_journal()
        {
            InitializeComponent();
            LoadDropdownLists();
            txt_exch.Text = "1.00";
        }




        private void LoadDropdownLists()
        {
            try
            {
                BL.Currency.cls_Currency currency = new BL.Currency.cls_Currency();
                db_currency.DataSource = currency.get_all_currency();
                db_currency.ValueMember = "curr_no";
                db_currency.DisplayMember = "curr_aname";


            }
            catch /*(Exception ex)*/
            {
                MyMessageBox.ShowMessage("يوجد خطأ في تحميل العملات", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            double exch;

            if (double.TryParse(txt_exch.Text, out exch))
            {
                double TD = 0;
                double TC = 0;

                if (!string.IsNullOrEmpty(txt_crdit.Text))
                {
                    TC = Convert.ToDouble(txt_crdit.Text) * exch;
                }

                if (!string.IsNullOrEmpty(txt_debit.Text))
                {
                    TD = Convert.ToDouble(txt_debit.Text) * exch;
                }

                dgv_Journal.Rows.Add(
                    txt_journal_no.Text, txt_acc_no.Text, txt_acc_name.Text, txt_debit.Text, txt_crdit.Text, db_currency.SelectedValue, db_currency.Text, txt_exch.Text, txt_note.Text, TD, TC
                );

                cleaning();
                cal();
            }
            else
            {
                MyMessageBox.ShowMessage("يوجد خطأ في تحويل العملات", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void cleaning()
        {
            txt_acc_no.Text = string.Empty;
            txt_acc_name.Text = string.Empty;
            txt_debit.Text = string.Empty;
            txt_crdit.Text = string.Empty;
            db_currency.SelectedIndex = 0;
            txt_exch.Text = string.Empty;
            txt_note.Text = string.Empty;
        }

        private void cal()
        {
            double TD = 0;
            double TC = 0;
            for (int i = 0; i < dgv_Journal.Rows.Count; i++)
            {
                TD = TD + Convert.ToDouble(dgv_Journal.Rows[i].Cells["TotalDebitColumn"].Value);
                TC = TC + Convert.ToDouble(dgv_Journal.Rows[i].Cells["TotalCrditColumn"].Value);
            }
            txt_Tcrdit.Text = TC.ToString("0.00");
            txt_Tdebit.Text = TD.ToString("0.00");
            txt_deff.Text = (TD - TC).ToString("0.00");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}