using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo.BL.Users;
using demo.PL.Dashboard;

namespace demo.PL.Authentication
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void checkEmptyText()
        {
           
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "") lblUserNameRequired.Text = "من فضلك ادخل اسم المستخدم";
            if (txtPassword.Text == "") lblPwdRequired.Text = "من فضلك ادخل كلمه المرور";
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {

                DataTable dt = new DataTable();
                Auth auth = new Auth();


                dt = auth.Login(txtUserName.Text, txtPassword.Text);
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    frm_Main frmMain = new frm_Main();
                    Program.user_name = txtUserName.Text;
                    frmMain.Show();
                }
                else
                {
                    userNameWarnig.Text = "اسم المستخدم أو كلمه المرور غير صحيح";
                }
            }
        }
        private void clearWarningMsg()
        {
            lblUserNameRequired.Text = "";
            lblPwdRequired.Text = "";
            userNameWarnig.Text="";
        }
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            clearWarningMsg();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            clearWarningMsg();
        }
    }
}
