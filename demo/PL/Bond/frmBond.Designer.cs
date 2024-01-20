namespace demo.PL.Bond
{
    partial class frmBond
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBond));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvCompany = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblWarningPhone = new System.Windows.Forms.Label();
            this.lblWarnigName = new System.Windows.Forms.Label();
            this.btnDeletePic = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.picCompany = new System.Windows.Forms.PictureBox();
            this.txtCompanyNo = new System.Windows.Forms.TextBox();
            this.txtCompanyWebsite = new System.Windows.Forms.TextBox();
            this.txtCompanyEmail = new System.Windows.Forms.TextBox();
            this.txtCompanyFax = new System.Windows.Forms.TextBox();
            this.txtCompanyPhone = new System.Windows.Forms.TextBox();
            this.txtCompanyEAddress = new System.Windows.Forms.TextBox();
            this.txtCompanyAAddress = new System.Windows.Forms.TextBox();
            this.txtCompanyEName = new System.Windows.Forms.TextBox();
            this.txtCompanyAName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.Blue;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(220, 228);
            this.bunifuTextbox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(172, 29);
            this.bunifuTextbox1.TabIndex = 47;
            this.bunifuTextbox1.text = "Bunifu TextBox";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.CadetBlue;
            this.label10.Location = new System.Drawing.Point(317, -13);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 22);
            this.label10.TabIndex = 46;
            this.label10.Text = "الشركات";
            // 
            // dgvCompany
            // 
            this.dgvCompany.AllowUserToAddRows = false;
            this.dgvCompany.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvCompany.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCompany.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompany.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompany.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCompany.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompany.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompany.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCompany.DoubleBuffered = true;
            this.dgvCompany.EnableHeadersVisualStyles = false;
            this.dgvCompany.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCompany.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvCompany.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCompany.Location = new System.Drawing.Point(336, 16);
            this.dgvCompany.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.dgvCompany.Name = "dgvCompany";
            this.dgvCompany.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCompany.RowHeadersVisible = false;
            this.dgvCompany.RowTemplate.DividerHeight = 1;
            this.dgvCompany.RowTemplate.Height = 30;
            this.dgvCompany.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompany.Size = new System.Drawing.Size(565, 377);
            this.dgvCompany.TabIndex = 45;
            // 
            // lblWarningPhone
            // 
            this.lblWarningPhone.AutoSize = true;
            this.lblWarningPhone.ForeColor = System.Drawing.Color.IndianRed;
            this.lblWarningPhone.Location = new System.Drawing.Point(373, 415);
            this.lblWarningPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarningPhone.Name = "lblWarningPhone";
            this.lblWarningPhone.Size = new System.Drawing.Size(0, 13);
            this.lblWarningPhone.TabIndex = 44;
            // 
            // lblWarnigName
            // 
            this.lblWarnigName.AutoSize = true;
            this.lblWarnigName.ForeColor = System.Drawing.Color.IndianRed;
            this.lblWarnigName.Location = new System.Drawing.Point(277, 310);
            this.lblWarnigName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarnigName.Name = "lblWarnigName";
            this.lblWarnigName.Size = new System.Drawing.Size(0, 13);
            this.lblWarnigName.TabIndex = 43;
            // 
            // btnDeletePic
            // 
            this.btnDeletePic.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePic.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDeletePic.Location = new System.Drawing.Point(254, 178);
            this.btnDeletePic.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnDeletePic.Name = "btnDeletePic";
            this.btnDeletePic.Size = new System.Drawing.Size(55, 37);
            this.btnDeletePic.TabIndex = 42;
            this.btnDeletePic.Text = "حذف";
            this.btnDeletePic.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnExit.Location = new System.Drawing.Point(789, 415);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 49);
            this.btnExit.TabIndex = 41;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.Location = new System.Drawing.Point(651, 415);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 49);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Location = new System.Drawing.Point(438, 415);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 49);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Location = new System.Drawing.Point(520, 415);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 49);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Location = new System.Drawing.Point(336, 415);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 49);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "جديد";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // picCompany
            // 
            this.picCompany.Location = new System.Drawing.Point(-100, 16);
            this.picCompany.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.picCompany.Name = "picCompany";
            this.picCompany.Size = new System.Drawing.Size(409, 148);
            this.picCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCompany.TabIndex = 37;
            this.picCompany.TabStop = false;
            // 
            // txtCompanyNo
            // 
            this.txtCompanyNo.Enabled = false;
            this.txtCompanyNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyNo.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtCompanyNo.Location = new System.Drawing.Point(-23, 252);
            this.txtCompanyNo.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtCompanyNo.Name = "txtCompanyNo";
            this.txtCompanyNo.Size = new System.Drawing.Size(122, 26);
            this.txtCompanyNo.TabIndex = 23;
            this.txtCompanyNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCompanyWebsite
            // 
            this.txtCompanyWebsite.Enabled = false;
            this.txtCompanyWebsite.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyWebsite.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtCompanyWebsite.Location = new System.Drawing.Point(197, 342);
            this.txtCompanyWebsite.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtCompanyWebsite.Name = "txtCompanyWebsite";
            this.txtCompanyWebsite.Size = new System.Drawing.Size(122, 26);
            this.txtCompanyWebsite.TabIndex = 35;
            this.txtCompanyWebsite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCompanyEmail
            // 
            this.txtCompanyEmail.Enabled = false;
            this.txtCompanyEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyEmail.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtCompanyEmail.Location = new System.Drawing.Point(197, 292);
            this.txtCompanyEmail.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtCompanyEmail.Name = "txtCompanyEmail";
            this.txtCompanyEmail.Size = new System.Drawing.Size(122, 26);
            this.txtCompanyEmail.TabIndex = 34;
            this.txtCompanyEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCompanyFax
            // 
            this.txtCompanyFax.Enabled = false;
            this.txtCompanyFax.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyFax.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtCompanyFax.Location = new System.Drawing.Point(197, 249);
            this.txtCompanyFax.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtCompanyFax.Name = "txtCompanyFax";
            this.txtCompanyFax.Size = new System.Drawing.Size(122, 26);
            this.txtCompanyFax.TabIndex = 32;
            this.txtCompanyFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCompanyPhone
            // 
            this.txtCompanyPhone.Enabled = false;
            this.txtCompanyPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyPhone.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtCompanyPhone.Location = new System.Drawing.Point(197, 393);
            this.txtCompanyPhone.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtCompanyPhone.Name = "txtCompanyPhone";
            this.txtCompanyPhone.Size = new System.Drawing.Size(122, 26);
            this.txtCompanyPhone.TabIndex = 31;
            this.txtCompanyPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCompanyEAddress
            // 
            this.txtCompanyEAddress.Enabled = false;
            this.txtCompanyEAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyEAddress.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtCompanyEAddress.Location = new System.Drawing.Point(-32, 423);
            this.txtCompanyEAddress.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtCompanyEAddress.Name = "txtCompanyEAddress";
            this.txtCompanyEAddress.Size = new System.Drawing.Size(122, 26);
            this.txtCompanyEAddress.TabIndex = 29;
            this.txtCompanyEAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCompanyAAddress
            // 
            this.txtCompanyAAddress.Enabled = false;
            this.txtCompanyAAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyAAddress.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtCompanyAAddress.Location = new System.Drawing.Point(-32, 383);
            this.txtCompanyAAddress.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtCompanyAAddress.Name = "txtCompanyAAddress";
            this.txtCompanyAAddress.Size = new System.Drawing.Size(122, 26);
            this.txtCompanyAAddress.TabIndex = 26;
            this.txtCompanyAAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCompanyEName
            // 
            this.txtCompanyEName.Enabled = false;
            this.txtCompanyEName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyEName.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtCompanyEName.Location = new System.Drawing.Point(-23, 333);
            this.txtCompanyEName.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtCompanyEName.Name = "txtCompanyEName";
            this.txtCompanyEName.Size = new System.Drawing.Size(122, 26);
            this.txtCompanyEName.TabIndex = 25;
            this.txtCompanyEName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCompanyAName
            // 
            this.txtCompanyAName.Enabled = false;
            this.txtCompanyAName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyAName.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtCompanyAName.Location = new System.Drawing.Point(-23, 292);
            this.txtCompanyAName.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtCompanyAName.Name = "txtCompanyAName";
            this.txtCompanyAName.Size = new System.Drawing.Size(122, 26);
            this.txtCompanyAName.TabIndex = 24;
            this.txtCompanyAName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.CadetBlue;
            this.label8.Location = new System.Drawing.Point(97, 339);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "الموقع الالكترونى";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.CadetBlue;
            this.label7.Location = new System.Drawing.Point(107, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "بريد الكترونى";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CadetBlue;
            this.label6.Location = new System.Drawing.Point(107, 258);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "فاكس";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CadetBlue;
            this.label5.Location = new System.Drawing.Point(107, 399);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "تليفون";
            // 
            // frmBond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 533);
            this.Controls.Add(this.bunifuTextbox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvCompany);
            this.Controls.Add(this.lblWarningPhone);
            this.Controls.Add(this.lblWarnigName);
            this.Controls.Add(this.btnDeletePic);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.picCompany);
            this.Controls.Add(this.txtCompanyNo);
            this.Controls.Add(this.txtCompanyWebsite);
            this.Controls.Add(this.txtCompanyEmail);
            this.Controls.Add(this.txtCompanyFax);
            this.Controls.Add(this.txtCompanyPhone);
            this.Controls.Add(this.txtCompanyEAddress);
            this.Controls.Add(this.txtCompanyAAddress);
            this.Controls.Add(this.txtCompanyEName);
            this.Controls.Add(this.txtCompanyAName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "frmBond";
            this.Text = "frmBond";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCompany;
        private System.Windows.Forms.Label lblWarningPhone;
        private System.Windows.Forms.Label lblWarnigName;
        private System.Windows.Forms.Button btnDeletePic;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox picCompany;
        private System.Windows.Forms.TextBox txtCompanyNo;
        private System.Windows.Forms.TextBox txtCompanyWebsite;
        private System.Windows.Forms.TextBox txtCompanyEmail;
        private System.Windows.Forms.TextBox txtCompanyFax;
        private System.Windows.Forms.TextBox txtCompanyPhone;
        private System.Windows.Forms.TextBox txtCompanyEAddress;
        private System.Windows.Forms.TextBox txtCompanyAAddress;
        private System.Windows.Forms.TextBox txtCompanyEName;
        private System.Windows.Forms.TextBox txtCompanyAName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}