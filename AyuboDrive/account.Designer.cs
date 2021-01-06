namespace AyuboDrive
{
    partial class account
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAccount = new System.Windows.Forms.TabControl();
            this.tabPageMenu = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.pictureAcc = new System.Windows.Forms.PictureBox();
            this.tabPageAccount = new System.Windows.Forms.TabPage();
            this.btnLoHome = new System.Windows.Forms.Button();
            this.btnAcDel = new System.Windows.Forms.Button();
            this.lblAcError = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAcc = new System.Windows.Forms.DataGridView();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAcReset = new System.Windows.Forms.Button();
            this.cmbAcID = new System.Windows.Forms.ComboBox();
            this.txtAcID = new System.Windows.Forms.TextBox();
            this.btnAcCh = new System.Windows.Forms.Button();
            this.btnAcCl = new System.Windows.Forms.Button();
            this.pictureLoAdd = new System.Windows.Forms.PictureBox();
            this.pictureLoUp = new System.Windows.Forms.PictureBox();
            this.btnAcAdd = new System.Windows.Forms.Button();
            this.btnAcUp = new System.Windows.Forms.Button();
            this.btnAcSave = new System.Windows.Forms.Button();
            this.tabPageManagement = new System.Windows.Forms.TabPage();
            this.btnAcHome = new System.Windows.Forms.Button();
            this.pbup = new System.Windows.Forms.PictureBox();
            this.pbadd = new System.Windows.Forms.PictureBox();
            this.btnch = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.lblerror = new System.Windows.Forms.Label();
            this.dtpHiredDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNotSpecified = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbManID = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnup = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btncl = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.tabPageMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAcc)).BeginInit();
            this.tabPageAccount.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoUp)).BeginInit();
            this.tabPageManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbadd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 55);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Management";
            // 
            // tabAccount
            // 
            this.tabAccount.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabAccount.Controls.Add(this.tabPageMenu);
            this.tabAccount.Controls.Add(this.tabPageAccount);
            this.tabAccount.Controls.Add(this.tabPageManagement);
            this.tabAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAccount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAccount.ItemSize = new System.Drawing.Size(0, 1);
            this.tabAccount.Location = new System.Drawing.Point(0, 55);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.SelectedIndex = 0;
            this.tabAccount.Size = new System.Drawing.Size(583, 450);
            this.tabAccount.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabAccount.TabIndex = 5;
            // 
            // tabPageMenu
            // 
            this.tabPageMenu.BackColor = System.Drawing.Color.Snow;
            this.tabPageMenu.Controls.Add(this.label18);
            this.tabPageMenu.Controls.Add(this.label17);
            this.tabPageMenu.Controls.Add(this.pictureUser);
            this.tabPageMenu.Controls.Add(this.pictureAcc);
            this.tabPageMenu.Location = new System.Drawing.Point(4, 5);
            this.tabPageMenu.Name = "tabPageMenu";
            this.tabPageMenu.Size = new System.Drawing.Size(575, 441);
            this.tabPageMenu.TabIndex = 2;
            this.tabPageMenu.Text = "tabPage1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Enabled = false;
            this.label18.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(338, 217);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(209, 22);
            this.label18.TabIndex = 7;
            this.label18.Text = "Account Management";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(35, 217);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(176, 22);
            this.label17.TabIndex = 6;
            this.label17.Text = "User Management";
            // 
            // pictureUser
            // 
            this.pictureUser.Image = global::AyuboDrive.Properties.Resources.Accounts_User;
            this.pictureUser.Location = new System.Drawing.Point(35, 14);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(200, 200);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureUser.TabIndex = 5;
            this.pictureUser.TabStop = false;
            this.pictureUser.Click += new System.EventHandler(this.pictureUser_Click);
            // 
            // pictureAcc
            // 
            this.pictureAcc.Enabled = false;
            this.pictureAcc.Image = global::AyuboDrive.Properties.Resources.Accounts_Logins;
            this.pictureAcc.Location = new System.Drawing.Point(340, 14);
            this.pictureAcc.Name = "pictureAcc";
            this.pictureAcc.Size = new System.Drawing.Size(200, 200);
            this.pictureAcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureAcc.TabIndex = 4;
            this.pictureAcc.TabStop = false;
            this.pictureAcc.Click += new System.EventHandler(this.pictureAcc_Click);
            // 
            // tabPageAccount
            // 
            this.tabPageAccount.BackColor = System.Drawing.Color.Snow;
            this.tabPageAccount.Controls.Add(this.btnLoHome);
            this.tabPageAccount.Controls.Add(this.btnAcDel);
            this.tabPageAccount.Controls.Add(this.lblAcError);
            this.tabPageAccount.Controls.Add(this.groupBox2);
            this.tabPageAccount.Controls.Add(this.txtpass);
            this.tabPageAccount.Controls.Add(this.label11);
            this.tabPageAccount.Controls.Add(this.txtusername);
            this.tabPageAccount.Controls.Add(this.label10);
            this.tabPageAccount.Controls.Add(this.label9);
            this.tabPageAccount.Controls.Add(this.btnAcReset);
            this.tabPageAccount.Controls.Add(this.cmbAcID);
            this.tabPageAccount.Controls.Add(this.txtAcID);
            this.tabPageAccount.Controls.Add(this.btnAcCh);
            this.tabPageAccount.Controls.Add(this.btnAcCl);
            this.tabPageAccount.Controls.Add(this.pictureLoAdd);
            this.tabPageAccount.Controls.Add(this.pictureLoUp);
            this.tabPageAccount.Controls.Add(this.btnAcAdd);
            this.tabPageAccount.Controls.Add(this.btnAcUp);
            this.tabPageAccount.Controls.Add(this.btnAcSave);
            this.tabPageAccount.Location = new System.Drawing.Point(4, 5);
            this.tabPageAccount.Name = "tabPageAccount";
            this.tabPageAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccount.Size = new System.Drawing.Size(575, 441);
            this.tabPageAccount.TabIndex = 0;
            // 
            // btnLoHome
            // 
            this.btnLoHome.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLoHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoHome.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoHome.ForeColor = System.Drawing.Color.White;
            this.btnLoHome.Image = global::AyuboDrive.Properties.Resources.home;
            this.btnLoHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoHome.Location = new System.Drawing.Point(380, 70);
            this.btnLoHome.Name = "btnLoHome";
            this.btnLoHome.Size = new System.Drawing.Size(187, 45);
            this.btnLoHome.TabIndex = 133;
            this.btnLoHome.Text = " Home Page";
            this.btnLoHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoHome.UseVisualStyleBackColor = false;
            // 
            // btnAcDel
            // 
            this.btnAcDel.BackColor = System.Drawing.Color.Crimson;
            this.btnAcDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcDel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcDel.ForeColor = System.Drawing.Color.White;
            this.btnAcDel.Image = global::AyuboDrive.Properties.Resources.cancel;
            this.btnAcDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcDel.Location = new System.Drawing.Point(459, 379);
            this.btnAcDel.Name = "btnAcDel";
            this.btnAcDel.Size = new System.Drawing.Size(98, 44);
            this.btnAcDel.TabIndex = 55;
            this.btnAcDel.Text = " Delete";
            this.btnAcDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcDel.UseVisualStyleBackColor = false;
            // 
            // lblAcError
            // 
            this.lblAcError.AutoSize = true;
            this.lblAcError.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcError.ForeColor = System.Drawing.Color.Red;
            this.lblAcError.Location = new System.Drawing.Point(19, 120);
            this.lblAcError.Name = "lblAcError";
            this.lblAcError.Size = new System.Drawing.Size(252, 16);
            this.lblAcError.TabIndex = 50;
            this.lblAcError.Text = "Please check validity of data you entered!..";
            this.lblAcError.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAcc);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 221);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account List";
            this.groupBox2.Visible = false;
            // 
            // dgvAcc
            // 
            this.dgvAcc.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAcc.Location = new System.Drawing.Point(6, 22);
            this.dgvAcc.Name = "dgvAcc";
            this.dgvAcc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAcc.Size = new System.Drawing.Size(373, 193);
            this.dgvAcc.TabIndex = 0;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(188, 82);
            this.txtpass.MaxLength = 20;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(179, 23);
            this.txtpass.TabIndex = 19;
            this.txtpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpass_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Password*";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(188, 47);
            this.txtusername.MaxLength = 20;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(179, 23);
            this.txtusername.TabIndex = 17;
            this.txtusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusername_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Username*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Management Number*";
            // 
            // btnAcReset
            // 
            this.btnAcReset.BackColor = System.Drawing.Color.Orange;
            this.btnAcReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcReset.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcReset.ForeColor = System.Drawing.Color.White;
            this.btnAcReset.Image = global::AyuboDrive.Properties.Resources.gear;
            this.btnAcReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcReset.Location = new System.Drawing.Point(22, 384);
            this.btnAcReset.Name = "btnAcReset";
            this.btnAcReset.Size = new System.Drawing.Size(93, 39);
            this.btnAcReset.TabIndex = 52;
            this.btnAcReset.Text = "Reset";
            this.btnAcReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcReset.UseVisualStyleBackColor = false;
            // 
            // cmbAcID
            // 
            this.cmbAcID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcID.FormattingEnabled = true;
            this.cmbAcID.Location = new System.Drawing.Point(188, 15);
            this.cmbAcID.Name = "cmbAcID";
            this.cmbAcID.Size = new System.Drawing.Size(179, 24);
            this.cmbAcID.TabIndex = 13;
            this.cmbAcID.SelectedIndexChanged += new System.EventHandler(this.cmbAcID_SelectedIndexChanged);
            // 
            // txtAcID
            // 
            this.txtAcID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcID.Location = new System.Drawing.Point(188, 15);
            this.txtAcID.MaxLength = 30;
            this.txtAcID.Name = "txtAcID";
            this.txtAcID.ReadOnly = true;
            this.txtAcID.Size = new System.Drawing.Size(179, 23);
            this.txtAcID.TabIndex = 14;
            this.txtAcID.Visible = false;
            // 
            // btnAcCh
            // 
            this.btnAcCh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(124)))), ((int)(((byte)(75)))));
            this.btnAcCh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcCh.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcCh.ForeColor = System.Drawing.Color.White;
            this.btnAcCh.Image = global::AyuboDrive.Properties.Resources.businessman;
            this.btnAcCh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcCh.Location = new System.Drawing.Point(380, 10);
            this.btnAcCh.Name = "btnAcCh";
            this.btnAcCh.Size = new System.Drawing.Size(187, 48);
            this.btnAcCh.TabIndex = 58;
            this.btnAcCh.Text = "Manage Account";
            this.btnAcCh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcCh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcCh.UseVisualStyleBackColor = false;
            this.btnAcCh.Visible = false;
            this.btnAcCh.Click += new System.EventHandler(this.btnAcCh_Click);
            // 
            // btnAcCl
            // 
            this.btnAcCl.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAcCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcCl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcCl.ForeColor = System.Drawing.Color.White;
            this.btnAcCl.Image = global::AyuboDrive.Properties.Resources.eraser;
            this.btnAcCl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcCl.Location = new System.Drawing.Point(22, 384);
            this.btnAcCl.Name = "btnAcCl";
            this.btnAcCl.Size = new System.Drawing.Size(93, 39);
            this.btnAcCl.TabIndex = 54;
            this.btnAcCl.Text = " Clear";
            this.btnAcCl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcCl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcCl.UseVisualStyleBackColor = false;
            this.btnAcCl.Visible = false;
            // 
            // pictureLoAdd
            // 
            this.pictureLoAdd.Image = global::AyuboDrive.Properties.Resources.add__5_;
            this.pictureLoAdd.Location = new System.Drawing.Point(429, 239);
            this.pictureLoAdd.Name = "pictureLoAdd";
            this.pictureLoAdd.Size = new System.Drawing.Size(128, 128);
            this.pictureLoAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureLoAdd.TabIndex = 57;
            this.pictureLoAdd.TabStop = false;
            this.pictureLoAdd.Visible = false;
            // 
            // pictureLoUp
            // 
            this.pictureLoUp.Image = global::AyuboDrive.Properties.Resources.search__2_;
            this.pictureLoUp.Location = new System.Drawing.Point(429, 239);
            this.pictureLoUp.Name = "pictureLoUp";
            this.pictureLoUp.Size = new System.Drawing.Size(128, 128);
            this.pictureLoUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureLoUp.TabIndex = 59;
            this.pictureLoUp.TabStop = false;
            // 
            // btnAcAdd
            // 
            this.btnAcAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAcAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcAdd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcAdd.ForeColor = System.Drawing.Color.White;
            this.btnAcAdd.Image = global::AyuboDrive.Properties.Resources.add__2_;
            this.btnAcAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcAdd.Location = new System.Drawing.Point(380, 11);
            this.btnAcAdd.Name = "btnAcAdd";
            this.btnAcAdd.Size = new System.Drawing.Size(187, 47);
            this.btnAcAdd.TabIndex = 56;
            this.btnAcAdd.Text = "   Add Account";
            this.btnAcAdd.UseVisualStyleBackColor = false;
            this.btnAcAdd.Click += new System.EventHandler(this.btnAcAdd_Click);
            // 
            // btnAcUp
            // 
            this.btnAcUp.BackColor = System.Drawing.Color.Orange;
            this.btnAcUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcUp.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcUp.ForeColor = System.Drawing.Color.White;
            this.btnAcUp.Image = global::AyuboDrive.Properties.Resources.upgrade__1_;
            this.btnAcUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcUp.Location = new System.Drawing.Point(237, 384);
            this.btnAcUp.Name = "btnAcUp";
            this.btnAcUp.Size = new System.Drawing.Size(101, 39);
            this.btnAcUp.TabIndex = 51;
            this.btnAcUp.Text = "Update";
            this.btnAcUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcUp.UseVisualStyleBackColor = false;
            this.btnAcUp.Click += new System.EventHandler(this.btnAcUp_Click);
            // 
            // btnAcSave
            // 
            this.btnAcSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAcSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcSave.ForeColor = System.Drawing.Color.White;
            this.btnAcSave.Image = global::AyuboDrive.Properties.Resources.backup;
            this.btnAcSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcSave.Location = new System.Drawing.Point(237, 384);
            this.btnAcSave.Name = "btnAcSave";
            this.btnAcSave.Size = new System.Drawing.Size(101, 39);
            this.btnAcSave.TabIndex = 53;
            this.btnAcSave.Text = "Save";
            this.btnAcSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcSave.UseVisualStyleBackColor = false;
            this.btnAcSave.Visible = false;
            this.btnAcSave.Click += new System.EventHandler(this.btnAcSave_Click);
            // 
            // tabPageManagement
            // 
            this.tabPageManagement.BackColor = System.Drawing.Color.Snow;
            this.tabPageManagement.Controls.Add(this.btnAcHome);
            this.tabPageManagement.Controls.Add(this.pbup);
            this.tabPageManagement.Controls.Add(this.pbadd);
            this.tabPageManagement.Controls.Add(this.btnch);
            this.tabPageManagement.Controls.Add(this.btndel);
            this.tabPageManagement.Controls.Add(this.lblerror);
            this.tabPageManagement.Controls.Add(this.dtpHiredDate);
            this.tabPageManagement.Controls.Add(this.dtpDOB);
            this.tabPageManagement.Controls.Add(this.txtemail);
            this.tabPageManagement.Controls.Add(this.txtcon);
            this.tabPageManagement.Controls.Add(this.label8);
            this.tabPageManagement.Controls.Add(this.label7);
            this.tabPageManagement.Controls.Add(this.label5);
            this.tabPageManagement.Controls.Add(this.label4);
            this.tabPageManagement.Controls.Add(this.groupBox1);
            this.tabPageManagement.Controls.Add(this.txtLname);
            this.tabPageManagement.Controls.Add(this.txtFname);
            this.tabPageManagement.Controls.Add(this.label6);
            this.tabPageManagement.Controls.Add(this.label3);
            this.tabPageManagement.Controls.Add(this.label2);
            this.tabPageManagement.Controls.Add(this.cmbManID);
            this.tabPageManagement.Controls.Add(this.txtid);
            this.tabPageManagement.Controls.Add(this.btnup);
            this.tabPageManagement.Controls.Add(this.btnadd);
            this.tabPageManagement.Controls.Add(this.btncl);
            this.tabPageManagement.Controls.Add(this.btnreset);
            this.tabPageManagement.Controls.Add(this.btnsave);
            this.tabPageManagement.Location = new System.Drawing.Point(4, 5);
            this.tabPageManagement.Name = "tabPageManagement";
            this.tabPageManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManagement.Size = new System.Drawing.Size(575, 441);
            this.tabPageManagement.TabIndex = 1;
            // 
            // btnAcHome
            // 
            this.btnAcHome.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAcHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcHome.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcHome.ForeColor = System.Drawing.Color.White;
            this.btnAcHome.Image = global::AyuboDrive.Properties.Resources.home;
            this.btnAcHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcHome.Location = new System.Drawing.Point(385, 63);
            this.btnAcHome.Name = "btnAcHome";
            this.btnAcHome.Size = new System.Drawing.Size(187, 45);
            this.btnAcHome.TabIndex = 134;
            this.btnAcHome.Text = " Home Page";
            this.btnAcHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcHome.UseVisualStyleBackColor = false;
            this.btnAcHome.Click += new System.EventHandler(this.btnAcHome_Click);
            // 
            // pbup
            // 
            this.pbup.Image = global::AyuboDrive.Properties.Resources.search__1_;
            this.pbup.Location = new System.Drawing.Point(439, 224);
            this.pbup.Name = "pbup";
            this.pbup.Size = new System.Drawing.Size(128, 128);
            this.pbup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbup.TabIndex = 59;
            this.pbup.TabStop = false;
            // 
            // pbadd
            // 
            this.pbadd.Image = global::AyuboDrive.Properties.Resources.add_user;
            this.pbadd.Location = new System.Drawing.Point(439, 224);
            this.pbadd.Name = "pbadd";
            this.pbadd.Size = new System.Drawing.Size(128, 128);
            this.pbadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbadd.TabIndex = 57;
            this.pbadd.TabStop = false;
            this.pbadd.Visible = false;
            // 
            // btnch
            // 
            this.btnch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(124)))), ((int)(((byte)(75)))));
            this.btnch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnch.ForeColor = System.Drawing.Color.White;
            this.btnch.Image = global::AyuboDrive.Properties.Resources.businessman;
            this.btnch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnch.Location = new System.Drawing.Point(385, 11);
            this.btnch.Name = "btnch";
            this.btnch.Size = new System.Drawing.Size(187, 45);
            this.btnch.TabIndex = 58;
            this.btnch.Text = " Update User";
            this.btnch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnch.UseVisualStyleBackColor = false;
            this.btnch.Visible = false;
            this.btnch.Click += new System.EventHandler(this.btnch_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.Crimson;
            this.btndel.Enabled = false;
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.Color.White;
            this.btndel.Image = global::AyuboDrive.Properties.Resources.cancel;
            this.btndel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndel.Location = new System.Drawing.Point(458, 380);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(98, 44);
            this.btndel.TabIndex = 55;
            this.btndel.Text = " Delete";
            this.btndel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndel.UseVisualStyleBackColor = false;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(19, 361);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(252, 16);
            this.lblerror.TabIndex = 50;
            this.lblerror.Text = "Please check validity of data you entered!..";
            this.lblerror.Visible = false;
            // 
            // dtpHiredDate
            // 
            this.dtpHiredDate.CustomFormat = "yyyy-MM-dd";
            this.dtpHiredDate.Enabled = false;
            this.dtpHiredDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHiredDate.Location = new System.Drawing.Point(184, 328);
            this.dtpHiredDate.Name = "dtpHiredDate";
            this.dtpHiredDate.Size = new System.Drawing.Size(179, 23);
            this.dtpHiredDate.TabIndex = 47;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "yyyy-MM-dd";
            this.dtpDOB.Enabled = false;
            this.dtpDOB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(184, 221);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(179, 23);
            this.dtpDOB.TabIndex = 39;
            // 
            // txtemail
            // 
            this.txtemail.Enabled = false;
            this.txtemail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(184, 290);
            this.txtemail.MaxLength = 50;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(179, 23);
            this.txtemail.TabIndex = 40;
            // 
            // txtcon
            // 
            this.txtcon.Enabled = false;
            this.txtcon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcon.Location = new System.Drawing.Point(184, 256);
            this.txtcon.MaxLength = 10;
            this.txtcon.Name = "txtcon";
            this.txtcon.Size = new System.Drawing.Size(179, 23);
            this.txtcon.TabIndex = 38;
            this.txtcon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcon_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 18);
            this.label8.TabIndex = 46;
            this.label8.Text = "Email*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "Hired Date*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 44;
            this.label5.Text = "Date Of Birth*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 43;
            this.label4.Text = "Contact Number*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNotSpecified);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 77);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender*";
            // 
            // rbNotSpecified
            // 
            this.rbNotSpecified.AutoSize = true;
            this.rbNotSpecified.Enabled = false;
            this.rbNotSpecified.Location = new System.Drawing.Point(194, 27);
            this.rbNotSpecified.Name = "rbNotSpecified";
            this.rbNotSpecified.Size = new System.Drawing.Size(110, 22);
            this.rbNotSpecified.TabIndex = 6;
            this.rbNotSpecified.TabStop = true;
            this.rbNotSpecified.Text = "Not Specified";
            this.rbNotSpecified.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Enabled = false;
            this.rbFemale.Location = new System.Drawing.Point(95, 27);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(73, 22);
            this.rbFemale.TabIndex = 5;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Enabled = false;
            this.rbMale.Location = new System.Drawing.Point(5, 27);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(56, 22);
            this.rbMale.TabIndex = 4;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtLname
            // 
            this.txtLname.Enabled = false;
            this.txtLname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(184, 89);
            this.txtLname.MaxLength = 30;
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(179, 23);
            this.txtLname.TabIndex = 36;
            this.txtLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLname_KeyPress);
            // 
            // txtFname
            // 
            this.txtFname.Enabled = false;
            this.txtFname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(184, 49);
            this.txtFname.MaxLength = 30;
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(179, 23);
            this.txtFname.TabIndex = 35;
            this.txtFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFname_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "Last Name*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "First Name*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Management Number*";
            // 
            // cmbManID
            // 
            this.cmbManID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbManID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbManID.FormattingEnabled = true;
            this.cmbManID.Location = new System.Drawing.Point(184, 12);
            this.cmbManID.Name = "cmbManID";
            this.cmbManID.Size = new System.Drawing.Size(179, 24);
            this.cmbManID.TabIndex = 16;
            this.cmbManID.SelectedIndexChanged += new System.EventHandler(this.cmbManID_SelectedIndexChanged);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(184, 12);
            this.txtid.MaxLength = 30;
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(179, 23);
            this.txtid.TabIndex = 17;
            this.txtid.Visible = false;
            // 
            // btnup
            // 
            this.btnup.BackColor = System.Drawing.Color.Orange;
            this.btnup.Enabled = false;
            this.btnup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnup.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnup.ForeColor = System.Drawing.Color.White;
            this.btnup.Image = global::AyuboDrive.Properties.Resources.upgrade__1_;
            this.btnup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnup.Location = new System.Drawing.Point(262, 385);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(101, 39);
            this.btnup.TabIndex = 51;
            this.btnup.Text = "Update";
            this.btnup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnup.UseVisualStyleBackColor = false;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Image = global::AyuboDrive.Properties.Resources.add__2_;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(385, 12);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(187, 45);
            this.btnadd.TabIndex = 56;
            this.btnadd.Text = "   Add User";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btncl
            // 
            this.btncl.BackColor = System.Drawing.Color.DodgerBlue;
            this.btncl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncl.ForeColor = System.Drawing.Color.White;
            this.btncl.Image = global::AyuboDrive.Properties.Resources.eraser;
            this.btncl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncl.Location = new System.Drawing.Point(21, 385);
            this.btncl.Name = "btncl";
            this.btncl.Size = new System.Drawing.Size(93, 39);
            this.btncl.TabIndex = 54;
            this.btncl.Text = " Clear";
            this.btncl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncl.UseVisualStyleBackColor = false;
            this.btncl.Visible = false;
            this.btncl.Click += new System.EventHandler(this.btncl_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Orange;
            this.btnreset.Enabled = false;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.White;
            this.btnreset.Image = global::AyuboDrive.Properties.Resources.gear;
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.Location = new System.Drawing.Point(21, 385);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(93, 39);
            this.btnreset.TabIndex = 52;
            this.btnreset.Text = "Reset";
            this.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Image = global::AyuboDrive.Properties.Resources.backup;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(262, 385);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(101, 39);
            this.btnsave.TabIndex = 53;
            this.btnsave.Text = "Save";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Visible = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(583, 505);
            this.Controls.Add(this.tabAccount);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "account";
            this.Text = "ZZ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabAccount.ResumeLayout(false);
            this.tabPageMenu.ResumeLayout(false);
            this.tabPageMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAcc)).EndInit();
            this.tabPageAccount.ResumeLayout(false);
            this.tabPageAccount.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoUp)).EndInit();
            this.tabPageManagement.ResumeLayout(false);
            this.tabPageManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbadd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabAccount;
        private System.Windows.Forms.TabPage tabPageAccount;
        private System.Windows.Forms.TabPage tabPageManagement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbManID;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DateTimePicker dtpHiredDate;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNotSpecified;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Button btncl;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.PictureBox pbup;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.PictureBox pbadd;
        private System.Windows.Forms.Button btnch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbAcID;
        private System.Windows.Forms.TextBox txtAcID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAcc;
        private System.Windows.Forms.Button btnAcDel;
        private System.Windows.Forms.Label lblAcError;
        private System.Windows.Forms.Button btnAcCl;
        private System.Windows.Forms.Button btnAcSave;
        private System.Windows.Forms.Button btnAcReset;
        private System.Windows.Forms.Button btnAcUp;
        private System.Windows.Forms.Button btnAcAdd;
        private System.Windows.Forms.PictureBox pictureLoUp;
        private System.Windows.Forms.PictureBox pictureLoAdd;
        private System.Windows.Forms.Button btnAcCh;
        private System.Windows.Forms.TabPage tabPageMenu;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.PictureBox pictureAcc;
        private System.Windows.Forms.Button btnLoHome;
        private System.Windows.Forms.Button btnAcHome;
    }
}