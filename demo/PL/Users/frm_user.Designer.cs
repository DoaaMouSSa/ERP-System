namespace demo.PL.Users
{
    partial class frm_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_user));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SelectProfile = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_ClearProfile = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pb_Image = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_FName = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_EMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_users = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_new = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Save = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.UserIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Edit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_delete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(807, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم المستخدم";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_SelectProfile);
            this.groupBox1.Controls.Add(this.btn_ClearProfile);
            this.groupBox1.Controls.Add(this.pb_Image);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.txt_FName);
            this.groupBox1.Controls.Add(this.txt_UserName);
            this.groupBox1.Controls.Add(this.txt_Password);
            this.groupBox1.Controls.Add(this.txt_PhoneNumber);
            this.groupBox1.Controls.Add(this.txt_EMail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Cairo Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(934, 307);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البيانات";
            // 
            // btn_SelectProfile
            // 
            this.btn_SelectProfile.AllowAnimations = true;
            this.btn_SelectProfile.AllowMouseEffects = true;
            this.btn_SelectProfile.AllowToggling = false;
            this.btn_SelectProfile.AnimationSpeed = 200;
            this.btn_SelectProfile.AutoGenerateColors = false;
            this.btn_SelectProfile.AutoRoundBorders = false;
            this.btn_SelectProfile.AutoSizeLeftIcon = true;
            this.btn_SelectProfile.AutoSizeRightIcon = true;
            this.btn_SelectProfile.BackColor = System.Drawing.Color.Transparent;
            this.btn_SelectProfile.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_SelectProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SelectProfile.BackgroundImage")));
            this.btn_SelectProfile.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_SelectProfile.ButtonText = "رفع صورة";
            this.btn_SelectProfile.ButtonTextMarginLeft = 0;
            this.btn_SelectProfile.ColorContrastOnClick = 45;
            this.btn_SelectProfile.ColorContrastOnHover = 45;
            this.btn_SelectProfile.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_SelectProfile.CustomizableEdges = borderEdges1;
            this.btn_SelectProfile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_SelectProfile.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_SelectProfile.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_SelectProfile.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_SelectProfile.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_SelectProfile.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectProfile.ForeColor = System.Drawing.Color.White;
            this.btn_SelectProfile.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SelectProfile.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_SelectProfile.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_SelectProfile.IconMarginLeft = 11;
            this.btn_SelectProfile.IconPadding = 10;
            this.btn_SelectProfile.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SelectProfile.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_SelectProfile.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_SelectProfile.IconSize = 25;
            this.btn_SelectProfile.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_SelectProfile.IdleBorderRadius = 1;
            this.btn_SelectProfile.IdleBorderThickness = 1;
            this.btn_SelectProfile.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_SelectProfile.IdleIconLeftImage = null;
            this.btn_SelectProfile.IdleIconRightImage = null;
            this.btn_SelectProfile.IndicateFocus = false;
            this.btn_SelectProfile.Location = new System.Drawing.Point(224, 230);
            this.btn_SelectProfile.Name = "btn_SelectProfile";
            this.btn_SelectProfile.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_SelectProfile.OnDisabledState.BorderRadius = 1;
            this.btn_SelectProfile.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_SelectProfile.OnDisabledState.BorderThickness = 1;
            this.btn_SelectProfile.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_SelectProfile.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_SelectProfile.OnDisabledState.IconLeftImage = null;
            this.btn_SelectProfile.OnDisabledState.IconRightImage = null;
            this.btn_SelectProfile.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_SelectProfile.onHoverState.BorderRadius = 1;
            this.btn_SelectProfile.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_SelectProfile.onHoverState.BorderThickness = 1;
            this.btn_SelectProfile.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_SelectProfile.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_SelectProfile.onHoverState.IconLeftImage = null;
            this.btn_SelectProfile.onHoverState.IconRightImage = null;
            this.btn_SelectProfile.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_SelectProfile.OnIdleState.BorderRadius = 1;
            this.btn_SelectProfile.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_SelectProfile.OnIdleState.BorderThickness = 1;
            this.btn_SelectProfile.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_SelectProfile.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_SelectProfile.OnIdleState.IconLeftImage = null;
            this.btn_SelectProfile.OnIdleState.IconRightImage = null;
            this.btn_SelectProfile.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_SelectProfile.OnPressedState.BorderRadius = 1;
            this.btn_SelectProfile.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_SelectProfile.OnPressedState.BorderThickness = 1;
            this.btn_SelectProfile.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_SelectProfile.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_SelectProfile.OnPressedState.IconLeftImage = null;
            this.btn_SelectProfile.OnPressedState.IconRightImage = null;
            this.btn_SelectProfile.Size = new System.Drawing.Size(150, 39);
            this.btn_SelectProfile.TabIndex = 4;
            this.btn_SelectProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SelectProfile.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_SelectProfile.TextMarginLeft = 0;
            this.btn_SelectProfile.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_SelectProfile.UseDefaultRadiusAndThickness = true;
            this.btn_SelectProfile.Click += new System.EventHandler(this.btn_SelectProfile_Click);
            // 
            // btn_ClearProfile
            // 
            this.btn_ClearProfile.AllowAnimations = true;
            this.btn_ClearProfile.AllowMouseEffects = true;
            this.btn_ClearProfile.AllowToggling = false;
            this.btn_ClearProfile.AnimationSpeed = 200;
            this.btn_ClearProfile.AutoGenerateColors = false;
            this.btn_ClearProfile.AutoRoundBorders = false;
            this.btn_ClearProfile.AutoSizeLeftIcon = true;
            this.btn_ClearProfile.AutoSizeRightIcon = true;
            this.btn_ClearProfile.BackColor = System.Drawing.Color.Transparent;
            this.btn_ClearProfile.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_ClearProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ClearProfile.BackgroundImage")));
            this.btn_ClearProfile.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_ClearProfile.ButtonText = "مسح الصورة";
            this.btn_ClearProfile.ButtonTextMarginLeft = 0;
            this.btn_ClearProfile.ColorContrastOnClick = 45;
            this.btn_ClearProfile.ColorContrastOnHover = 45;
            this.btn_ClearProfile.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_ClearProfile.CustomizableEdges = borderEdges2;
            this.btn_ClearProfile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ClearProfile.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_ClearProfile.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_ClearProfile.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_ClearProfile.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_ClearProfile.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.btn_ClearProfile.ForeColor = System.Drawing.Color.White;
            this.btn_ClearProfile.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ClearProfile.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_ClearProfile.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_ClearProfile.IconMarginLeft = 11;
            this.btn_ClearProfile.IconPadding = 10;
            this.btn_ClearProfile.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ClearProfile.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_ClearProfile.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_ClearProfile.IconSize = 25;
            this.btn_ClearProfile.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_ClearProfile.IdleBorderRadius = 1;
            this.btn_ClearProfile.IdleBorderThickness = 1;
            this.btn_ClearProfile.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_ClearProfile.IdleIconLeftImage = null;
            this.btn_ClearProfile.IdleIconRightImage = null;
            this.btn_ClearProfile.IndicateFocus = false;
            this.btn_ClearProfile.Location = new System.Drawing.Point(31, 230);
            this.btn_ClearProfile.Name = "btn_ClearProfile";
            this.btn_ClearProfile.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_ClearProfile.OnDisabledState.BorderRadius = 1;
            this.btn_ClearProfile.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_ClearProfile.OnDisabledState.BorderThickness = 1;
            this.btn_ClearProfile.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_ClearProfile.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_ClearProfile.OnDisabledState.IconLeftImage = null;
            this.btn_ClearProfile.OnDisabledState.IconRightImage = null;
            this.btn_ClearProfile.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_ClearProfile.onHoverState.BorderRadius = 1;
            this.btn_ClearProfile.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_ClearProfile.onHoverState.BorderThickness = 1;
            this.btn_ClearProfile.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_ClearProfile.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_ClearProfile.onHoverState.IconLeftImage = null;
            this.btn_ClearProfile.onHoverState.IconRightImage = null;
            this.btn_ClearProfile.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_ClearProfile.OnIdleState.BorderRadius = 1;
            this.btn_ClearProfile.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_ClearProfile.OnIdleState.BorderThickness = 1;
            this.btn_ClearProfile.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_ClearProfile.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_ClearProfile.OnIdleState.IconLeftImage = null;
            this.btn_ClearProfile.OnIdleState.IconRightImage = null;
            this.btn_ClearProfile.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_ClearProfile.OnPressedState.BorderRadius = 1;
            this.btn_ClearProfile.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_ClearProfile.OnPressedState.BorderThickness = 1;
            this.btn_ClearProfile.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_ClearProfile.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_ClearProfile.OnPressedState.IconLeftImage = null;
            this.btn_ClearProfile.OnPressedState.IconRightImage = null;
            this.btn_ClearProfile.Size = new System.Drawing.Size(150, 39);
            this.btn_ClearProfile.TabIndex = 4;
            this.btn_ClearProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ClearProfile.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ClearProfile.TextMarginLeft = 0;
            this.btn_ClearProfile.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_ClearProfile.UseDefaultRadiusAndThickness = true;
            this.btn_ClearProfile.Click += new System.EventHandler(this.btn_ClearProfile_Click);
            // 
            // pb_Image
            // 
            this.pb_Image.AllowFocused = false;
            this.pb_Image.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_Image.AutoSizeHeight = true;
            this.pb_Image.BorderRadius = 71;
            this.pb_Image.Image = ((System.Drawing.Image)(resources.GetObject("pb_Image.Image")));
            this.pb_Image.IsCircle = true;
            this.pb_Image.Location = new System.Drawing.Point(119, 32);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(143, 143);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Image.TabIndex = 2;
            this.pb_Image.TabStop = false;
            this.pb_Image.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Font = new System.Drawing.Font("Cairo Medium", 10F, System.Drawing.FontStyle.Bold);
            this.txt_ID.Location = new System.Drawing.Point(467, 32);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(279, 39);
            this.txt_ID.TabIndex = 1;
            // 
            // txt_FName
            // 
            this.txt_FName.Location = new System.Drawing.Point(467, 77);
            this.txt_FName.Name = "txt_FName";
            this.txt_FName.Size = new System.Drawing.Size(279, 39);
            this.txt_FName.TabIndex = 1;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(467, 122);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(279, 39);
            this.txt_UserName.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Cairo Medium", 10F, System.Drawing.FontStyle.Bold);
            this.txt_Password.Location = new System.Drawing.Point(467, 167);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(279, 39);
            this.txt_Password.TabIndex = 1;
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(467, 212);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(279, 39);
            this.txt_PhoneNumber.TabIndex = 1;
            // 
            // txt_EMail
            // 
            this.txt_EMail.Location = new System.Drawing.Point(467, 257);
            this.txt_EMail.Name = "txt_EMail";
            this.txt_EMail.Size = new System.Drawing.Size(279, 39);
            this.txt_EMail.TabIndex = 1;
            this.txt_EMail.Validated += new System.EventHandler(this.txt_EMail_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(799, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "البريد الالكترونى";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(863, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "الجوال";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(837, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "المستخدم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(826, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "كلمه المرور";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(824, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "الاسم رباعي";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_users, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(940, 626);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dgv_users
            // 
            this.dgv_users.AllowUserToAddRows = false;
            this.dgv_users.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_users.BackgroundColor = System.Drawing.Color.White;
            this.dgv_users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_users.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_users.ColumnHeadersHeight = 40;
            this.dgv_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIDColumn,
            this.UserNameColumn,
            this.UserPhoneColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cairo Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_users.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_users.DoubleBuffered = true;
            this.dgv_users.EnableHeadersVisualStyles = false;
            this.dgv_users.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_users.HeaderBgColor = System.Drawing.Color.Gray;
            this.dgv_users.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_users.Location = new System.Drawing.Point(3, 316);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.ReadOnly = true;
            this.dgv_users.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_users.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_users.RowHeadersVisible = false;
            this.dgv_users.RowHeadersWidth = 51;
            this.dgv_users.RowTemplate.DividerHeight = 1;
            this.dgv_users.RowTemplate.Height = 30;
            this.dgv_users.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_users.Size = new System.Drawing.Size(934, 244);
            this.dgv_users.TabIndex = 24;
            this.dgv_users.DoubleClick += new System.EventHandler(this.dgv_users_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_new);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_Edit);
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 566);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(934, 57);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // btn_new
            // 
            this.btn_new.AllowAnimations = true;
            this.btn_new.AllowMouseEffects = true;
            this.btn_new.AllowToggling = false;
            this.btn_new.AnimationSpeed = 200;
            this.btn_new.AutoGenerateColors = false;
            this.btn_new.AutoRoundBorders = false;
            this.btn_new.AutoSizeLeftIcon = true;
            this.btn_new.AutoSizeRightIcon = true;
            this.btn_new.BackColor = System.Drawing.Color.Transparent;
            this.btn_new.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_new.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_new.BackgroundImage")));
            this.btn_new.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_new.ButtonText = "جديد";
            this.btn_new.ButtonTextMarginLeft = 0;
            this.btn_new.ColorContrastOnClick = 45;
            this.btn_new.ColorContrastOnHover = 45;
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_new.CustomizableEdges = borderEdges3;
            this.btn_new.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_new.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_new.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_new.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_new.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_new.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_new.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_new.IconMarginLeft = 11;
            this.btn_new.IconPadding = 10;
            this.btn_new.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_new.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_new.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_new.IconSize = 25;
            this.btn_new.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_new.IdleBorderRadius = 1;
            this.btn_new.IdleBorderThickness = 1;
            this.btn_new.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_new.IdleIconLeftImage = null;
            this.btn_new.IdleIconRightImage = null;
            this.btn_new.IndicateFocus = false;
            this.btn_new.Location = new System.Drawing.Point(765, 12);
            this.btn_new.Name = "btn_new";
            this.btn_new.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_new.OnDisabledState.BorderRadius = 1;
            this.btn_new.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_new.OnDisabledState.BorderThickness = 1;
            this.btn_new.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_new.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_new.OnDisabledState.IconLeftImage = null;
            this.btn_new.OnDisabledState.IconRightImage = null;
            this.btn_new.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_new.onHoverState.BorderRadius = 1;
            this.btn_new.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_new.onHoverState.BorderThickness = 1;
            this.btn_new.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_new.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_new.onHoverState.IconLeftImage = null;
            this.btn_new.onHoverState.IconRightImage = null;
            this.btn_new.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_new.OnIdleState.BorderRadius = 1;
            this.btn_new.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_new.OnIdleState.BorderThickness = 1;
            this.btn_new.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_new.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_new.OnIdleState.IconLeftImage = null;
            this.btn_new.OnIdleState.IconRightImage = null;
            this.btn_new.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_new.OnPressedState.BorderRadius = 1;
            this.btn_new.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_new.OnPressedState.BorderThickness = 1;
            this.btn_new.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_new.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_new.OnPressedState.IconLeftImage = null;
            this.btn_new.OnPressedState.IconRightImage = null;
            this.btn_new.Size = new System.Drawing.Size(150, 39);
            this.btn_new.TabIndex = 4;
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_new.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_new.TextMarginLeft = 0;
            this.btn_new.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_new.UseDefaultRadiusAndThickness = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.AllowAnimations = true;
            this.btn_Save.AllowMouseEffects = true;
            this.btn_Save.AllowToggling = false;
            this.btn_Save.AnimationSpeed = 200;
            this.btn_Save.AutoGenerateColors = false;
            this.btn_Save.AutoRoundBorders = false;
            this.btn_Save.AutoSizeLeftIcon = true;
            this.btn_Save.AutoSizeRightIcon = true;
            this.btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Save.BackgroundImage")));
            this.btn_Save.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Save.ButtonText = "حفظ";
            this.btn_Save.ButtonTextMarginLeft = 0;
            this.btn_Save.ColorContrastOnClick = 45;
            this.btn_Save.ColorContrastOnHover = 45;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btn_Save.CustomizableEdges = borderEdges6;
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Save.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Save.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Save.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Save.Enabled = false;
            this.btn_Save.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Save.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Save.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Save.IconMarginLeft = 11;
            this.btn_Save.IconPadding = 10;
            this.btn_Save.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Save.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Save.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Save.IconSize = 25;
            this.btn_Save.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Save.IdleBorderRadius = 1;
            this.btn_Save.IdleBorderThickness = 1;
            this.btn_Save.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Save.IdleIconLeftImage = null;
            this.btn_Save.IdleIconRightImage = null;
            this.btn_Save.IndicateFocus = false;
            this.btn_Save.Location = new System.Drawing.Point(513, 12);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Save.OnDisabledState.BorderRadius = 1;
            this.btn_Save.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Save.OnDisabledState.BorderThickness = 1;
            this.btn_Save.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Save.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Save.OnDisabledState.IconLeftImage = null;
            this.btn_Save.OnDisabledState.IconRightImage = null;
            this.btn_Save.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Save.onHoverState.BorderRadius = 1;
            this.btn_Save.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Save.onHoverState.BorderThickness = 1;
            this.btn_Save.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Save.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Save.onHoverState.IconLeftImage = null;
            this.btn_Save.onHoverState.IconRightImage = null;
            this.btn_Save.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Save.OnIdleState.BorderRadius = 1;
            this.btn_Save.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Save.OnIdleState.BorderThickness = 1;
            this.btn_Save.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Save.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Save.OnIdleState.IconLeftImage = null;
            this.btn_Save.OnIdleState.IconRightImage = null;
            this.btn_Save.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Save.OnPressedState.BorderRadius = 1;
            this.btn_Save.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Save.OnPressedState.BorderThickness = 1;
            this.btn_Save.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Save.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Save.OnPressedState.IconLeftImage = null;
            this.btn_Save.OnPressedState.IconRightImage = null;
            this.btn_Save.Size = new System.Drawing.Size(150, 39);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Save.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Save.TextMarginLeft = 0;
            this.btn_Save.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Save.UseDefaultRadiusAndThickness = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // UserIDColumn
            // 
            this.UserIDColumn.HeaderText = "رقم المستخدم";
            this.UserIDColumn.MinimumWidth = 6;
            this.UserIDColumn.Name = "UserIDColumn";
            this.UserIDColumn.ReadOnly = true;
            // 
            // UserNameColumn
            // 
            this.UserNameColumn.HeaderText = "اسم المستخدم";
            this.UserNameColumn.MinimumWidth = 6;
            this.UserNameColumn.Name = "UserNameColumn";
            this.UserNameColumn.ReadOnly = true;
            // 
            // UserPhoneColumn
            // 
            this.UserPhoneColumn.HeaderText = "رقم الهاتف";
            this.UserPhoneColumn.MinimumWidth = 6;
            this.UserPhoneColumn.Name = "UserPhoneColumn";
            this.UserPhoneColumn.ReadOnly = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.AllowAnimations = true;
            this.btn_Edit.AllowMouseEffects = true;
            this.btn_Edit.AllowToggling = false;
            this.btn_Edit.AnimationSpeed = 200;
            this.btn_Edit.AutoGenerateColors = false;
            this.btn_Edit.AutoRoundBorders = false;
            this.btn_Edit.AutoSizeLeftIcon = true;
            this.btn_Edit.AutoSizeRightIcon = true;
            this.btn_Edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Edit.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Edit.BackgroundImage")));
            this.btn_Edit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Edit.ButtonText = "تعديل";
            this.btn_Edit.ButtonTextMarginLeft = 0;
            this.btn_Edit.ColorContrastOnClick = 45;
            this.btn_Edit.ColorContrastOnHover = 45;
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btn_Edit.CustomizableEdges = borderEdges5;
            this.btn_Edit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Edit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Edit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Edit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Edit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Edit.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Edit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Edit.IconMarginLeft = 11;
            this.btn_Edit.IconPadding = 10;
            this.btn_Edit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Edit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Edit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Edit.IconSize = 25;
            this.btn_Edit.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Edit.IdleBorderRadius = 1;
            this.btn_Edit.IdleBorderThickness = 1;
            this.btn_Edit.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Edit.IdleIconLeftImage = null;
            this.btn_Edit.IdleIconRightImage = null;
            this.btn_Edit.IndicateFocus = false;
            this.btn_Edit.Location = new System.Drawing.Point(261, 12);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Edit.OnDisabledState.BorderRadius = 1;
            this.btn_Edit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Edit.OnDisabledState.BorderThickness = 1;
            this.btn_Edit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Edit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Edit.OnDisabledState.IconLeftImage = null;
            this.btn_Edit.OnDisabledState.IconRightImage = null;
            this.btn_Edit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Edit.onHoverState.BorderRadius = 1;
            this.btn_Edit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Edit.onHoverState.BorderThickness = 1;
            this.btn_Edit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Edit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.onHoverState.IconLeftImage = null;
            this.btn_Edit.onHoverState.IconRightImage = null;
            this.btn_Edit.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Edit.OnIdleState.BorderRadius = 1;
            this.btn_Edit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Edit.OnIdleState.BorderThickness = 1;
            this.btn_Edit.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Edit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.OnIdleState.IconLeftImage = null;
            this.btn_Edit.OnIdleState.IconRightImage = null;
            this.btn_Edit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Edit.OnPressedState.BorderRadius = 1;
            this.btn_Edit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Edit.OnPressedState.BorderThickness = 1;
            this.btn_Edit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Edit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.OnPressedState.IconLeftImage = null;
            this.btn_Edit.OnPressedState.IconRightImage = null;
            this.btn_Edit.Size = new System.Drawing.Size(150, 39);
            this.btn_Edit.TabIndex = 4;
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Edit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Edit.TextMarginLeft = 0;
            this.btn_Edit.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Edit.UseDefaultRadiusAndThickness = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AllowAnimations = true;
            this.btn_delete.AllowMouseEffects = true;
            this.btn_delete.AllowToggling = false;
            this.btn_delete.AnimationSpeed = 200;
            this.btn_delete.AutoGenerateColors = false;
            this.btn_delete.AutoRoundBorders = false;
            this.btn_delete.AutoSizeLeftIcon = true;
            this.btn_delete.AutoSizeRightIcon = true;
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_delete.ButtonText = "حذف";
            this.btn_delete.ButtonTextMarginLeft = 0;
            this.btn_delete.ColorContrastOnClick = 45;
            this.btn_delete.ColorContrastOnHover = 45;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btn_delete.CustomizableEdges = borderEdges4;
            this.btn_delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_delete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_delete.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_delete.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_delete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_delete.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_delete.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_delete.IconMarginLeft = 11;
            this.btn_delete.IconPadding = 10;
            this.btn_delete.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_delete.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_delete.IconSize = 25;
            this.btn_delete.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_delete.IdleBorderRadius = 1;
            this.btn_delete.IdleBorderThickness = 1;
            this.btn_delete.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_delete.IdleIconLeftImage = null;
            this.btn_delete.IdleIconRightImage = null;
            this.btn_delete.IndicateFocus = false;
            this.btn_delete.Location = new System.Drawing.Point(9, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_delete.OnDisabledState.BorderRadius = 1;
            this.btn_delete.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_delete.OnDisabledState.BorderThickness = 1;
            this.btn_delete.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_delete.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_delete.OnDisabledState.IconLeftImage = null;
            this.btn_delete.OnDisabledState.IconRightImage = null;
            this.btn_delete.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_delete.onHoverState.BorderRadius = 1;
            this.btn_delete.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_delete.onHoverState.BorderThickness = 1;
            this.btn_delete.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_delete.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_delete.onHoverState.IconLeftImage = null;
            this.btn_delete.onHoverState.IconRightImage = null;
            this.btn_delete.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_delete.OnIdleState.BorderRadius = 1;
            this.btn_delete.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_delete.OnIdleState.BorderThickness = 1;
            this.btn_delete.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_delete.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_delete.OnIdleState.IconLeftImage = null;
            this.btn_delete.OnIdleState.IconRightImage = null;
            this.btn_delete.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_delete.OnPressedState.BorderRadius = 1;
            this.btn_delete.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_delete.OnPressedState.BorderThickness = 1;
            this.btn_delete.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_delete.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_delete.OnPressedState.IconLeftImage = null;
            this.btn_delete.OnPressedState.IconRightImage = null;
            this.btn_delete.Size = new System.Drawing.Size(150, 39);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_delete.TextMarginLeft = 0;
            this.btn_delete.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_delete.UseDefaultRadiusAndThickness = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // frm_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 626);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "frm_user";
            this.Text = "frm_user";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_FName;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_EMail;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.TextBox txt_Password;
        private Bunifu.UI.WinForms.BunifuPictureBox pb_Image;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_SelectProfile;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_ClearProfile;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_users;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_new;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPhoneColumn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Edit;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_delete;
    }
}