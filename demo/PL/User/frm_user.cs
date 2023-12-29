using demo.PL.Message;
using demo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.PL.Users
{
    public partial class frm_user : Form
    {
        
        Users.Cls_User Cls_Users = new Users.Cls_User();
        public frm_user()
        {
            InitializeComponent();
            RefreshDataGridView();
        }
        public void RefreshDataGridView()
        {
            try
            {
                DataTable usersTable = Cls_Users.SelectAllUsers();

                dgv_users.DataSource = usersTable;

                if (dgv_users.Columns["UserIDColumn"] != null &&
                    dgv_users.Columns["UserNameColumn"] != null &&
                    dgv_users.Columns["UserPhoneColumn"] != null)
                {
                    dgv_users.Columns["UserIDColumn"].DataPropertyName = usersTable.Columns["u_no"].ColumnName;
                    dgv_users.Columns["UserNameColumn"].DataPropertyName = usersTable.Columns["u_name"].ColumnName;
                    dgv_users.Columns["UserPhoneColumn"].DataPropertyName = usersTable.Columns["u_tel"].ColumnName;
                }
                dgv_users.Columns["u_no"].Visible = false;
                dgv_users.Columns["u_fname"].Visible = false;
                dgv_users.Columns["u_name"].Visible = false;
                dgv_users.Columns["u_password"].Visible = false;
                dgv_users.Columns["u_tel"].Visible = false;
                dgv_users.Columns["u_email"].Visible = false;
                dgv_users.Columns["u_img"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            foreach (var c in this.groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
            }
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_user));
            pb_Image.Image = ((System.Drawing.Image)(resources.GetObject("pb_Image.Image"))); btn_Save.Enabled = true;
            txt_ID.Text= Cls_Users.GenerateUID().Rows[0][0].ToString();
            txt_FName.Focus();

        }

        private void txt_EMail_Validated(object sender, EventArgs e)
        {
            string emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(emailPattern);
            if (!regex.IsMatch(txt_EMail.Text))
            {
                MessageBox.Show("البريد الإلكتروني غير صحيح");
                txt_EMail.Focus();
            }
        }

        private void btn_SelectProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string imagePath = openFileDialog.FileName;
                    Image image = Image.FromFile(imagePath);

                    pb_Image.Image = image;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_ClearProfile_Click(object sender, EventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_user));
            pb_Image.Image = ((System.Drawing.Image)(resources.GetObject("pb_Image.Image")));

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_FName.Text) || string.IsNullOrWhiteSpace(txt_UserName.Text) || string.IsNullOrWhiteSpace(txt_Password.Text))
                {
                    MessageBox.Show("يرجى اكمال البيانات");
                    return;
                }
                byte[] imageBytes = ImageToByteArray(pb_Image.Image);
                Cls_User clsUsers = new Cls_User();
                clsUsers.AddUser(int.Parse(txt_ID.Text), txt_FName.Text, txt_UserName.Text, txt_Password.Text, txt_PhoneNumber.Text, txt_EMail.Text, imageBytes);
                MessageBox.Show("تم انشاء مستخدم جديد");
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void dgv_users_DoubleClick(object sender, EventArgs e)
        {
            txt_ID.Text = dgv_users.CurrentRow.Cells["u_no"].Value.ToString();
            txt_FName.Text = dgv_users.CurrentRow.Cells["u_fname"].Value.ToString();
            txt_UserName.Text = dgv_users.CurrentRow.Cells["u_name"].Value.ToString();
            txt_Password.Text = dgv_users.CurrentRow.Cells["u_password"].Value.ToString();
            txt_PhoneNumber.Text = dgv_users.CurrentRow.Cells["u_tel"].Value.ToString();
            txt_EMail.Text = dgv_users.CurrentRow.Cells["u_email"].Value.ToString();
            if (dgv_users.CurrentRow.Cells["u_img"].Value.ToString()=="")
            {
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_user));
                pb_Image.Image = ((System.Drawing.Image)(resources.GetObject("pb_Image.Image")));
            }
            else
            {
                byte[] bimg = (byte[])dgv_users.CurrentRow.Cells["u_img"].Value;
                MemoryStream memoryStream = new MemoryStream(bimg);
                pb_Image.Image = Image.FromStream(memoryStream);
            }
            
            
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] imageBytes = ImageToByteArray(pb_Image.Image);
                Cls_User clsUsers = new Cls_User();
                clsUsers.EditUser(int.Parse(txt_ID.Text), txt_FName.Text, txt_UserName.Text, txt_Password.Text, txt_PhoneNumber.Text, txt_EMail.Text, imageBytes);
                MessageBox.Show("تم تعديل المستخدم ");
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MyMessageBox.ShowMessage("هل تريد حزف المستخدم؟", "حذف مستخدم", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int u_no;
                    if (int.TryParse(txt_ID.Text, out u_no))
                    {
                        Cls_Users.DeleteUser(u_no);
                        MessageBox.Show("تم حذف المستخدم");
                    }
                    else
                    {
                        MyMessageBox.ShowMessage("يرجى تحديد المستخدم لحذفه", "رساله", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    RefreshDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        

        
    }
}