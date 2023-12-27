using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo.BL.company;
namespace demo.PL.Company
{
    public partial class frm_Company : Form
    {
        demo.BL.company.Company company = new demo.BL.company.Company();

        public frm_Company()
        {
            InitializeComponent();
            //dgvTbl();
        }
        void dgvTbl()
        {
            dgvCompany.DataSource = company.getAll();
            dgvCompany.Columns[0].HeaderText = "رقم الشركه";
            dgvCompany.Columns[1].HeaderText = "اسم الشركه";
            dgvCompany.Columns[2].HeaderText = "اسم الشركة بالانجليزى";
            dgvCompany.Columns[3].HeaderText = "العنوان";
            dgvCompany.Columns[4].HeaderText = "العنوان انجليزى";
            dgvCompany.Columns[5].HeaderText = "التليفون";
            dgvCompany.Columns[6].HeaderText = "الفاكس ";
            dgvCompany.Columns[7].HeaderText = "البريد الالكترونى";
            dgvCompany.Columns[8].HeaderText = "الموقع الالكترونى";
            //error here with image
            // dgvCompany.Columns[9].HeaderText = "الصوره";
            dgvCompany.Columns[2].Visible = false;
            dgvCompany.Columns[4].Visible = false;
            dgvCompany.Columns[9].Visible = false;
            dgvCompany.Columns[10].Visible = false;
        }
        private void btnDisplayPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "All Files|*.png;*.jpg;*.jpeg";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                picCompany.Image=Image.FromFile(ofd.FileName);  
            }
        }

        private void btnDeletePic_Click(object sender, EventArgs e)
        {
            picCompany.Image = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            controlTxts(true);
            btnSave.Enabled = true;
            btnDisplayPic.Enabled = true;
            txtCompanyAName.Focus();
        }
        private void controlTxts(bool status)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    //((TextBox)control).Text = String.Empty;
                    ((TextBox)control).Enabled = status;
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtCompanyAName.Text=="")
            {
                lblWarnigName.Text = "هذا الحقل مطلوب";
            }
            if(txtCompanyPhone.Text == "")
            {
                lblWarningPhone.Text = "هذا الحقل مطلوب";
            }
            if(txtCompanyAName.Text != "" && txtCompanyPhone.Text != "")
            {
                byte[] image= new byte[200];
                if (picCompany.Image!=null)
                {
                    MemoryStream ms = new MemoryStream();
                    picCompany.Image.Save(ms, picCompany.Image.RawFormat);
                    image = ms.ToArray();
                }
                company.Add(txtCompanyAName.Text,
                    txtCompanyEName.Text,
                    txtCompanyAAddress.Text,
                    txtCompanyEAddress.Text,
                    txtCompanyPhone.Text,
                    txtCompanyFax.Text,
                    txtCompanyEmail.Text,
                    txtCompanyWebsite.Text,
                    image
                    );
                MessageBox.Show("تمت الاضافه بنجاح");
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        ((TextBox)control).Text = String.Empty;
                        ((TextBox)control).Enabled = false;
                    }
                }
                btnSave.Enabled = false;
                btnDisplayPic.Enabled = false;
                btnSave.Enabled = false;
                picCompany.Image = null;
                clearWarningMsg();
                dgvTbl();
            }
        }
        private void clearWarningMsg()
        {
            lblWarnigName.Text = "";
            lblWarningPhone.Text = "";
        }
        private void txtCompanyAName_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage=InputLanguage.FromCulture(new CultureInfo("ar-eg"));
        }

        private void txtCompanyEName_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));
        }

        private void txtCompanyAAddress_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-eg"));
        }

        private void txtCompanyEAddress_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));
        }

        private void txtCompanyEmail_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));
        }

        private void txtCompanyWebsite_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));
        }

        private void txtCompanyAName_TextChanged(object sender, EventArgs e)
        {
            clearWarningMsg();
        }

        private void txtCompanyPhone_TextChanged(object sender, EventArgs e)
        {
            clearWarningMsg();
        }

        private void dgvCompany_DoubleClick(object sender, EventArgs e)
        {
            txtCompanyAName.Text = dgvCompany.CurrentRow.Cells[1].Value.ToString();
            txtCompanyEName.Text = dgvCompany.CurrentRow.Cells[2].Value.ToString();
            txtCompanyAAddress.Text = dgvCompany.CurrentRow.Cells[3].Value.ToString();
            txtCompanyEAddress.Text = dgvCompany.CurrentRow.Cells[4].Value.ToString();
            txtCompanyPhone.Text = dgvCompany.CurrentRow.Cells[5].Value.ToString();
            txtCompanyFax.Text = dgvCompany.CurrentRow.Cells[6].Value.ToString();
            txtCompanyEmail.Text = dgvCompany.CurrentRow.Cells[7].Value.ToString();
            txtCompanyWebsite.Text = dgvCompany.CurrentRow.Cells[8].Value.ToString();
            if(dgvCompany.CurrentRow.Cells[9].Value.ToString() !="")
            {
                byte[] imgCompany = (byte[])dgvCompany.CurrentRow.Cells[9].Value;
                MemoryStream ms = new MemoryStream(imgCompany);
                picCompany.Image = Image.FromStream(ms);
            }
            controlTxts(true);
            btnSave.Enabled = true;
            btnDisplayPic.Enabled = true;
            txtCompanyAName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCompanyAName.Text == "")
            {
                lblWarnigName.Text = "هذا الحقل مطلوب";
            }
            if (txtCompanyPhone.Text == "")
            {
                lblWarningPhone.Text = "هذا الحقل مطلوب";
            }
            if (txtCompanyAName.Text != "" && txtCompanyPhone.Text != "")
            {
                byte[] image = new byte[200];
                if (picCompany.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    picCompany.Image.Save(ms, picCompany.Image.RawFormat);
                    image = ms.ToArray();
                }
                int compnyNo =Convert.ToInt32(dgvCompany.CurrentRow.Cells[0].Value);
                company.update(
                    compnyNo,
                    txtCompanyAName.Text,
                    txtCompanyEName.Text,
                    txtCompanyAAddress.Text,
                    txtCompanyEAddress.Text,
                    txtCompanyPhone.Text,
                    txtCompanyFax.Text,
                    txtCompanyEmail.Text,
                    txtCompanyWebsite.Text,
                    image
                    );
                MessageBox.Show("تمت التعديل بنجاح");
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        ((TextBox)control).Text = String.Empty;
                        ((TextBox)control).Enabled = false;
                    }
                }
                btnSave.Enabled = false;
                btnDisplayPic.Enabled = false;
                btnSave.Enabled = false;
                picCompany.Image = null;
                clearWarningMsg();
                dgvTbl();
            }
            }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //add message to confirm delete
            int compnyNo = Convert.ToInt32(dgvCompany.CurrentRow.Cells[0].Value);
            company.Delete(compnyNo);
            lblConfirmDelete.Text = "تم الحذف بنجاح";
            btnSave.Enabled = false;
            btnDisplayPic.Enabled = false;
            btnSave.Enabled = false;
            picCompany.Image = null;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = String.Empty;
                    ((TextBox)control).Enabled = false;
                }
            }
            dgvTbl();
        }

        private void frm_Company_Load(object sender, EventArgs e)
        {

        }
    }
}
