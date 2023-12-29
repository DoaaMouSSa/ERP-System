using Bunifu.Framework.UI;
using Bunifu.UI.WinForms.BunifuTextbox;
using demo.DAL;
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

namespace demo.PL.Accounts
{
    public partial class frm_accounts : Form
    {
        BL.Account.cls_accounts Accounts = new BL.Account.cls_accounts();

        public frm_accounts()
        {
            InitializeComponent();
            LoadDropdownLists();
            CreateNodes();
            txt_accNo.Text = "1";
        }

        private void LoadDropdownLists()
        {
            try
            {
                cb_report.DataSource = Accounts.get_all_finalAcc();
                cb_report.ValueMember = "acc_rep_no";
                cb_report.DisplayMember = "acc_rep_aname";

                cb_AccType.DataSource = Accounts.get_all_AccType();
                cb_AccType.ValueMember = "acc_type_no";
                cb_AccType.DisplayMember = "acc_type_aname";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dropdown lists: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateNodes()
        {
            try
            {
                tr_account.Nodes.Clear();
                DataView dv = new DataView(Accounts.get_all_Accounts());
                dv.RowFilter = "acc_parent_no = 0";

                foreach (DataRowView item in dv)
                {
                    TreeNode treeNode = CreateNode(item);
                    tr_account.Nodes.Add(treeNode);
                    AddChildNodes(treeNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating nodes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private TreeNode CreateNode(DataRowView dataRowView)
        {
            TreeNode treeNode = new TreeNode($"{dataRowView["acc_no"]} {dataRowView["acc_name"]}");
            treeNode.Tag = dataRowView["acc_no"].ToString();
            return treeNode;
        }

        private void AddChildNodes(TreeNode parentNode)
        {
            try
            {
                DataView dv = new DataView(Accounts.get_all_Accounts());
                dv.RowFilter = $"acc_parent_no = {parentNode.Tag}";

                foreach (DataRowView item in dv)
                {
                    TreeNode childNode = CreateNode(item);
                    parentNode.Nodes.Add(childNode);
                    AddChildNodes(childNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding child nodes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tr_account_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txt_accNo.Text = tr_account.SelectedNode.Tag?.ToString();
        }

        private void txt_accNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int no;
                if (int.TryParse(txt_accNo.Text, out no))
                {
                    DataTable dt = Accounts.get_Account(no);
                    if (dt.Rows.Count > 0)
                    {
                        txt_acc_parent_no.Text = dt.Rows[0]["acc_parent_no"].ToString();
                        txt_acc_name.Text = dt.Rows[0]["acc_name"].ToString();
                        txt_acc_level.Text = dt.Rows[0]["acc_level"].ToString();
                        txt_acc_debit.Text = dt.Rows[0]["acc_debit"].ToString();
                        txt_acc_credit.Text = dt.Rows[0]["acc_credit"].ToString();
                        txt_acc_balance.Text = dt.Rows[0]["acc_balance"].ToString();
                        cb_AccType.SelectedValue = dt.Rows[0]["acc_type"].ToString();
                        cb_report.SelectedValue = dt.Rows[0]["acc_report"].ToString();
                    }
                    else
                    {
                        ClearAccountControls();
                    }
                }
                else { ClearAccountControls(); }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMessage($"حدث خطأ اثناء جلب البيانات: \n{ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAccountControls()
        {
            txt_acc_parent_no.Clear();
            txt_acc_name.Clear();
            txt_acc_level.Clear();
            txt_acc_debit.Clear();
            txt_acc_credit.Clear();
            txt_acc_balance.Clear();
            cb_AccType.SelectedIndex = -1;
            cb_report.SelectedIndex = -1;
        }
        private bool chick()
        {
            DataTable dataTable = new DataTable();
            dataTable = Accounts.Account_Check(int.Parse(txt_accNo.Text));
            DataTable dataTable1 = new DataTable();
            dataTable1 = Accounts.journal_Check(int.Parse(txt_accNo.Text));
            if (dataTable.Rows.Count > 0)
            {
                return false;
            }
            if (dataTable1.Rows.Count > 0)
            {
                return false;
            }
            return true;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (chick())
                {
                    if (MyMessageBox.ShowMessage("هل تريد حزف ؟", "حذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        int acc_no;
                        if (int.TryParse(txt_accNo.Text, out acc_no))
                        {
                            Accounts.Delete_Account(acc_no);
                            MessageBox.Show("تم حذف المستخدم");
                        }
                        else
                        {
                            MyMessageBox.ShowMessage("يرجى تحديد ", "رساله", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        CreateNodes();
                    }
                }
                else
                {
                    MessageBox.Show("لا يمكن حذفه");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (chick())
                {
                    if (int.TryParse(txt_accNo.Text, out int accNo) &&
                    int.TryParse(txt_acc_parent_no.Text, out int accParentNo) &&
                    int.TryParse(cb_AccType.SelectedValue.ToString(), out int accType) &&
                    int.TryParse(cb_report.SelectedValue.ToString(), out int accReport) &&
                    int.TryParse(txt_acc_level.Text, out int accLevel) &&
                    double.TryParse(txt_acc_debit.Text, out double accDebit) &&
                    double.TryParse(txt_acc_credit.Text, out double accCredit) &&
                    double.TryParse(txt_acc_balance.Text, out double accBalance))
                    {
                        Accounts.Edit_Account(accNo, accParentNo, txt_acc_name.Text, accType, accReport, accLevel, accDebit, accCredit, accBalance);
                        MyMessageBox.ShowMessage("تم تعديل بنجاح", "عمليه ناجحه", MessageBoxButtons.OK, MessageBoxIcon.None);
                        CreateNodes();
                        btn_Save.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Invalid input. Please enter valid numeric values.");
                    }
                }
                else
                {
                    MessageBox.Show("لا يمكن تعديد");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txt_accNo.Text, out int accNo) &&
                    int.TryParse(txt_acc_parent_no.Text, out int accParentNo) &&
                    int.TryParse(cb_AccType.SelectedValue.ToString(), out int accType) &&
                    int.TryParse(cb_report.SelectedValue.ToString(), out int accReport) &&
                    int.TryParse(txt_acc_level.Text, out int accLevel) &&
                    double.TryParse(txt_acc_debit.Text, out double accDebit) &&
                    double.TryParse(txt_acc_credit.Text, out double accCredit) &&
                    double.TryParse(txt_acc_balance.Text, out double accBalance))
                {
                    Accounts.Add_Account(accNo, accParentNo, txt_acc_name.Text, accType, accReport, accLevel, accDebit, accCredit, accBalance);
                    MessageBox.Show("تم انشاء مستخدم جديد");
                    CreateNodes();
                    btn_Save.Enabled = false;
                    txt_accNo.Text = "1";
                    txt_accNo.Enabled = false;
                    btn_delete.Enabled = true;
                    btn_Edit.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter valid numeric values.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_accNo.Enabled = true;
            txt_accNo.Text = string.Empty;
            ClearAccountControls();
            btn_delete.Enabled = false;
            btn_Edit.Enabled = false;
            txt_accNo.Focus();
            btn_Save.Enabled = true;

        }

        private void txt_accNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >=48 &&e.KeyChar>=57 &&e.KeyChar==8)
            { e.Handled = true; return; }
            e.Handled = false;
        }
    }
}
