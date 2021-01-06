namespace AyuboDrive
{
    partial class employee
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
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.cmbid = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNotSpecified = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcon = new System.Windows.Forms.TextBox();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblerror = new System.Windows.Forms.Label();
            this.dtpHiredDate = new System.Windows.Forms.DateTimePicker();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnch = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.pbup = new System.Windows.Forms.PictureBox();
            this.pbadd = new System.Windows.Forms.PictureBox();
            this.btncl = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbadd)).BeginInit();
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
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Last Name*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "First Name*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Employee Number*";
            // 
            // txtLname
            // 
            this.txtLname.Enabled = false;
            this.txtLname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(163, 131);
            this.txtLname.MaxLength = 30;
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(179, 23);
            this.txtLname.TabIndex = 3;
            this.txtLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLname_KeyPress);
            // 
            // txtFname
            // 
            this.txtFname.Enabled = false;
            this.txtFname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(163, 99);
            this.txtFname.MaxLength = 30;
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(179, 23);
            this.txtFname.TabIndex = 2;
            this.txtFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFname_KeyPress);
            // 
            // cmbid
            // 
            this.cmbid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbid.FormattingEnabled = true;
            this.cmbid.Location = new System.Drawing.Point(163, 66);
            this.cmbid.Name = "cmbid";
            this.cmbid.Size = new System.Drawing.Size(179, 24);
            this.cmbid.TabIndex = 1;
            this.cmbid.SelectedIndexChanged += new System.EventHandler(this.cmbid_SelectedIndexChanged);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(163, 66);
            this.txtid.MaxLength = 30;
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(179, 23);
            this.txtid.TabIndex = 1;
            this.txtid.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNotSpecified);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 77);
            this.groupBox1.TabIndex = 4;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Contact Number*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Date Of Birth*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Hired Date*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "Address*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "Salary*";
            // 
            // txtcon
            // 
            this.txtcon.Enabled = false;
            this.txtcon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcon.Location = new System.Drawing.Point(163, 254);
            this.txtcon.MaxLength = 10;
            this.txtcon.Name = "txtcon";
            this.txtcon.Size = new System.Drawing.Size(179, 23);
            this.txtcon.TabIndex = 5;
            this.txtcon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcon_KeyPress);
            // 
            // txtadd
            // 
            this.txtadd.Enabled = false;
            this.txtadd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadd.Location = new System.Drawing.Point(163, 350);
            this.txtadd.MaxLength = 100;
            this.txtadd.Multiline = true;
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(179, 51);
            this.txtadd.TabIndex = 8;
            this.txtadd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtadd_KeyPress);
            // 
            // txtsal
            // 
            this.txtsal.Enabled = false;
            this.txtsal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsal.Location = new System.Drawing.Point(163, 407);
            this.txtsal.MaxLength = 11;
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(179, 23);
            this.txtsal.TabIndex = 9;
            this.txtsal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsal_KeyPress);
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "yyyy-MM-dd";
            this.dtpDOB.Enabled = false;
            this.dtpDOB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(163, 284);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(179, 23);
            this.dtpDOB.TabIndex = 6;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(23, 435);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(252, 16);
            this.lblerror.TabIndex = 28;
            this.lblerror.Text = "Please check validity of data you entered!..";
            this.lblerror.Visible = false;
            // 
            // dtpHiredDate
            // 
            this.dtpHiredDate.CustomFormat = "yyyy-MM-dd";
            this.dtpHiredDate.Enabled = false;
            this.dtpHiredDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHiredDate.Location = new System.Drawing.Point(163, 316);
            this.dtpHiredDate.Name = "dtpHiredDate";
            this.dtpHiredDate.Size = new System.Drawing.Size(179, 23);
            this.dtpHiredDate.TabIndex = 34;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Image = global::AyuboDrive.Properties.Resources.add__2_;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(392, 67);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(165, 39);
            this.btnadd.TabIndex = 27;
            this.btnadd.Text = "   Add Employee";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnch
            // 
            this.btnch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(124)))), ((int)(((byte)(75)))));
            this.btnch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnch.ForeColor = System.Drawing.Color.White;
            this.btnch.Image = global::AyuboDrive.Properties.Resources.businessman;
            this.btnch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnch.Location = new System.Drawing.Point(392, 66);
            this.btnch.Name = "btnch";
            this.btnch.Size = new System.Drawing.Size(165, 39);
            this.btnch.TabIndex = 32;
            this.btnch.Text = "Update Employee";
            this.btnch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnch.UseVisualStyleBackColor = false;
            this.btnch.Visible = false;
            this.btnch.Click += new System.EventHandler(this.btnch_Click);
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
            this.btnreset.Location = new System.Drawing.Point(25, 458);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(93, 39);
            this.btnreset.TabIndex = 26;
            this.btnreset.Text = "Reset";
            this.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // pbup
            // 
            this.pbup.Image = global::AyuboDrive.Properties.Resources.search__3_;
            this.pbup.Location = new System.Drawing.Point(429, 296);
            this.pbup.Name = "pbup";
            this.pbup.Size = new System.Drawing.Size(128, 128);
            this.pbup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbup.TabIndex = 33;
            this.pbup.TabStop = false;
            // 
            // pbadd
            // 
            this.pbadd.Image = global::AyuboDrive.Properties.Resources.driver_license__1_;
            this.pbadd.Location = new System.Drawing.Point(429, 296);
            this.pbadd.Name = "pbadd";
            this.pbadd.Size = new System.Drawing.Size(128, 128);
            this.pbadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbadd.TabIndex = 29;
            this.pbadd.TabStop = false;
            this.pbadd.Visible = false;
            // 
            // btncl
            // 
            this.btncl.BackColor = System.Drawing.Color.DodgerBlue;
            this.btncl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncl.ForeColor = System.Drawing.Color.White;
            this.btncl.Image = global::AyuboDrive.Properties.Resources.eraser;
            this.btncl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncl.Location = new System.Drawing.Point(25, 458);
            this.btncl.Name = "btncl";
            this.btncl.Size = new System.Drawing.Size(93, 39);
            this.btncl.TabIndex = 31;
            this.btncl.Text = " Clear";
            this.btncl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncl.UseVisualStyleBackColor = false;
            this.btncl.Visible = false;
            this.btncl.Click += new System.EventHandler(this.btncl_Click);
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
            this.btnup.Location = new System.Drawing.Point(240, 458);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(101, 39);
            this.btnup.TabIndex = 25;
            this.btnup.Text = "Update";
            this.btnup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnup.UseVisualStyleBackColor = false;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Image = global::AyuboDrive.Properties.Resources.backup;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(241, 458);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(101, 39);
            this.btnsave.TabIndex = 30;
            this.btnsave.Text = "Save";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Visible = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(583, 505);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnch);
            this.Controls.Add(this.dtpHiredDate);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtsal);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.txtcon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbid);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.pbup);
            this.Controls.Add(this.pbadd);
            this.Controls.Add(this.btncl);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.btnsave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employee";
            this.Text = "employee";
            this.Load += new System.EventHandler(this.employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbadd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.ComboBox cmbid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNotSpecified;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcon;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.PictureBox pbadd;
        private System.Windows.Forms.Button btncl;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.PictureBox pbup;
        private System.Windows.Forms.Button btnch;
        private System.Windows.Forms.DateTimePicker dtpHiredDate;
    }
}