﻿using demo.DAL;
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
            TreeNode treeNode = new TreeNode($"{dataRowView["acc_no"]} {dataRowView["acc_aname"]}");
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
                DataTable dt = Accounts.get_Account(Convert.ToInt32(txt_accNo.Text));
                if (dt.Rows.Count > 0)
                {
                    txt_acc_parent_no.Text = dt.Rows[0]["acc_parent_no"].ToString();
                    txt_acc_name.Text = dt.Rows[0]["acc_aname"].ToString();
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving account details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {

        }
    }
}