namespace demo.PL.Cash
{
    partial class frm_cash
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
            this.gpMoney = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.gpInput = new System.Windows.Forms.GroupBox();
            this.txtCtrl = new System.Windows.Forms.TextBox();
            this.txtAccEName = new System.Windows.Forms.TextBox();
            this.txtAccName = new System.Windows.Forms.TextBox();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpCtrl = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.gpMoney.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gpInput.SuspendLayout();
            this.gpCtrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpMoney
            // 
            this.gpMoney.Controls.Add(this.dgv);
            this.gpMoney.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpMoney.ForeColor = System.Drawing.Color.DarkRed;
            this.gpMoney.Location = new System.Drawing.Point(12, 50);
            this.gpMoney.Name = "gpMoney";
            this.gpMoney.Size = new System.Drawing.Size(602, 186);
            this.gpMoney.TabIndex = 0;
            this.gpMoney.TabStop = false;
            this.gpMoney.Text = "النقدية";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 22);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(596, 161);
            this.dgv.TabIndex = 0;
            // 
            // gpInput
            // 
            this.gpInput.Controls.Add(this.txtCtrl);
            this.gpInput.Controls.Add(this.txtAccEName);
            this.gpInput.Controls.Add(this.txtAccName);
            this.gpInput.Controls.Add(this.txtAccNo);
            this.gpInput.Controls.Add(this.label3);
            this.gpInput.Controls.Add(this.label2);
            this.gpInput.Controls.Add(this.label1);
            this.gpInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpInput.ForeColor = System.Drawing.Color.DarkRed;
            this.gpInput.Location = new System.Drawing.Point(12, 242);
            this.gpInput.Name = "gpInput";
            this.gpInput.Size = new System.Drawing.Size(602, 177);
            this.gpInput.TabIndex = 1;
            this.gpInput.TabStop = false;
            this.gpInput.Text = "المدخلات";
            // 
            // txtCtrl
            // 
            this.txtCtrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCtrl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCtrl.Location = new System.Drawing.Point(35, 32);
            this.txtCtrl.Name = "txtCtrl";
            this.txtCtrl.Size = new System.Drawing.Size(201, 19);
            this.txtCtrl.TabIndex = 6;
            this.txtCtrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAccEName
            // 
            this.txtAccEName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccEName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtAccEName.Location = new System.Drawing.Point(35, 139);
            this.txtAccEName.Name = "txtAccEName";
            this.txtAccEName.Size = new System.Drawing.Size(403, 19);
            this.txtAccEName.TabIndex = 5;
            this.txtAccEName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAccName
            // 
            this.txtAccName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtAccName.Location = new System.Drawing.Point(35, 102);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(403, 19);
            this.txtAccName.TabIndex = 4;
            this.txtAccName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAccNo
            // 
            this.txtAccNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccNo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtAccNo.Location = new System.Drawing.Point(35, 64);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(403, 19);
            this.txtAccNo.TabIndex = 3;
            this.txtAccNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "الاسم انجليزى";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم الحساب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الحساب";
            // 
            // gpCtrl
            // 
            this.gpCtrl.Controls.Add(this.btnExit);
            this.gpCtrl.Controls.Add(this.btnDelete);
            this.gpCtrl.Controls.Add(this.btnEdit);
            this.gpCtrl.Controls.Add(this.btnSave);
            this.gpCtrl.Controls.Add(this.btnNew);
            this.gpCtrl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCtrl.Location = new System.Drawing.Point(12, 425);
            this.gpCtrl.Name = "gpCtrl";
            this.gpCtrl.Size = new System.Drawing.Size(602, 93);
            this.gpCtrl.TabIndex = 2;
            this.gpCtrl.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnExit.Location = new System.Drawing.Point(4, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 41);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.Location = new System.Drawing.Point(118, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 41);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEdit.Location = new System.Drawing.Point(237, 21);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 41);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Location = new System.Drawing.Point(363, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 41);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnNew.Location = new System.Drawing.Point(486, 21);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(106, 41);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Crimson;
            this.lblHeading.Location = new System.Drawing.Point(253, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(108, 22);
            this.lblHeading.TabIndex = 3;
            this.lblHeading.Text = "البنوك او الصناديق";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_cash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 527);
            this.ControlBox = false;
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.gpCtrl);
            this.Controls.Add(this.gpInput);
            this.Controls.Add(this.gpMoney);
            this.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_cash";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_cash_Load);
            this.gpMoney.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gpInput.ResumeLayout(false);
            this.gpInput.PerformLayout();
            this.gpCtrl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox gpInput;
        private System.Windows.Forms.TextBox txtAccEName;
        private System.Windows.Forms.TextBox txtAccName;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpCtrl;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        public System.Windows.Forms.TextBox txtCtrl;
        public System.Windows.Forms.Label lblHeading;
        public System.Windows.Forms.GroupBox gpMoney;
    }
}