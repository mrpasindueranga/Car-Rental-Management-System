namespace AyuboDrive
{
    partial class assignPack
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbid = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExtraKM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBaseHireCharge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExtraHour = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btndel = new System.Windows.Forms.Button();
            this.btnch = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.pbup = new System.Windows.Forms.PictureBox();
            this.pbadd = new System.Windows.Forms.PictureBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.btncl = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.cmbpack = new System.Windows.Forms.ComboBox();
            this.txtextraday = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign Packages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Assign Number*";
            // 
            // cmbid
            // 
            this.cmbid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbid.FormattingEnabled = true;
            this.cmbid.Location = new System.Drawing.Point(190, 77);
            this.cmbid.Name = "cmbid";
            this.cmbid.Size = new System.Drawing.Size(179, 24);
            this.cmbid.TabIndex = 16;
            this.cmbid.SelectedIndexChanged += new System.EventHandler(this.cmbid_SelectedIndexChanged);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(190, 77);
            this.txtid.MaxLength = 30;
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(179, 23);
            this.txtid.TabIndex = 17;
            this.txtid.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Package Name*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Base Hire Charge*";
            // 
            // txtExtraKM
            // 
            this.txtExtraKM.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraKM.Location = new System.Drawing.Point(190, 235);
            this.txtExtraKM.MaxLength = 9;
            this.txtExtraKM.Name = "txtExtraKM";
            this.txtExtraKM.Size = new System.Drawing.Size(179, 23);
            this.txtExtraKM.TabIndex = 26;
            this.txtExtraKM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtraKM_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Extra Hour Charge*";
            // 
            // txtBaseHireCharge
            // 
            this.txtBaseHireCharge.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseHireCharge.Location = new System.Drawing.Point(190, 195);
            this.txtBaseHireCharge.MaxLength = 13;
            this.txtBaseHireCharge.Name = "txtBaseHireCharge";
            this.txtBaseHireCharge.Size = new System.Drawing.Size(179, 23);
            this.txtBaseHireCharge.TabIndex = 24;
            this.txtBaseHireCharge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBaseHireCharge_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Extra KM Charge*";
            // 
            // txtExtraHour
            // 
            this.txtExtraHour.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraHour.Location = new System.Drawing.Point(190, 275);
            this.txtExtraHour.MaxLength = 9;
            this.txtExtraHour.Name = "txtExtraHour";
            this.txtExtraHour.Size = new System.Drawing.Size(179, 23);
            this.txtExtraHour.TabIndex = 28;
            this.txtExtraHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtraHour_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Vehicle Type*";
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.Crimson;
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.Color.White;
            this.btndel.Image = global::AyuboDrive.Properties.Resources.cancel;
            this.btndel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndel.Location = new System.Drawing.Point(468, 428);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(98, 44);
            this.btndel.TabIndex = 54;
            this.btndel.Text = " Delete";
            this.btndel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnch
            // 
            this.btnch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(124)))), ((int)(((byte)(75)))));
            this.btnch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnch.ForeColor = System.Drawing.Color.White;
            this.btnch.Image = global::AyuboDrive.Properties.Resources.businessman;
            this.btnch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnch.Location = new System.Drawing.Point(401, 78);
            this.btnch.Name = "btnch";
            this.btnch.Size = new System.Drawing.Size(165, 39);
            this.btnch.TabIndex = 52;
            this.btnch.Text = "Manage Package";
            this.btnch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnch.UseVisualStyleBackColor = false;
            this.btnch.Visible = false;
            this.btnch.Click += new System.EventHandler(this.btnch_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Image = global::AyuboDrive.Properties.Resources.add__2_;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(401, 78);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(165, 39);
            this.btnadd.TabIndex = 50;
            this.btnadd.Text = "   Add Package";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // pbup
            // 
            this.pbup.Image = global::AyuboDrive.Properties.Resources.search__2_;
            this.pbup.Location = new System.Drawing.Point(438, 224);
            this.pbup.Name = "pbup";
            this.pbup.Size = new System.Drawing.Size(128, 128);
            this.pbup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbup.TabIndex = 53;
            this.pbup.TabStop = false;
            // 
            // pbadd
            // 
            this.pbadd.Image = global::AyuboDrive.Properties.Resources.add__5_;
            this.pbadd.Location = new System.Drawing.Point(438, 224);
            this.pbadd.Name = "pbadd";
            this.pbadd.Size = new System.Drawing.Size(128, 128);
            this.pbadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbadd.TabIndex = 51;
            this.pbadd.TabStop = false;
            this.pbadd.Visible = false;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(24, 409);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(252, 16);
            this.lblerror.TabIndex = 55;
            this.lblerror.Text = "Please check validity of data you entered!..";
            this.lblerror.Visible = false;
            // 
            // btncl
            // 
            this.btncl.BackColor = System.Drawing.Color.DodgerBlue;
            this.btncl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncl.ForeColor = System.Drawing.Color.White;
            this.btncl.Image = global::AyuboDrive.Properties.Resources.eraser;
            this.btncl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncl.Location = new System.Drawing.Point(26, 433);
            this.btncl.Name = "btncl";
            this.btncl.Size = new System.Drawing.Size(93, 39);
            this.btncl.TabIndex = 59;
            this.btncl.Text = " Clear";
            this.btncl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncl.UseVisualStyleBackColor = false;
            this.btncl.Visible = false;
            this.btncl.Click += new System.EventHandler(this.btncl_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Image = global::AyuboDrive.Properties.Resources.backup;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(241, 433);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(101, 39);
            this.btnsave.TabIndex = 58;
            this.btnsave.Text = "Save";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Visible = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Orange;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.White;
            this.btnreset.Image = global::AyuboDrive.Properties.Resources.gear;
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.Location = new System.Drawing.Point(26, 433);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(93, 39);
            this.btnreset.TabIndex = 57;
            this.btnreset.Text = "Reset";
            this.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnup
            // 
            this.btnup.BackColor = System.Drawing.Color.Orange;
            this.btnup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnup.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnup.ForeColor = System.Drawing.Color.White;
            this.btnup.Image = global::AyuboDrive.Properties.Resources.upgrade__1_;
            this.btnup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnup.Location = new System.Drawing.Point(241, 433);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(101, 39);
            this.btnup.TabIndex = 56;
            this.btnup.Text = "Update";
            this.btnup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnup.UseVisualStyleBackColor = false;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // cmbtype
            // 
            this.cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtype.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Location = new System.Drawing.Point(190, 156);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(179, 24);
            this.cmbtype.TabIndex = 60;
            // 
            // cmbpack
            // 
            this.cmbpack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpack.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpack.FormattingEnabled = true;
            this.cmbpack.Location = new System.Drawing.Point(190, 117);
            this.cmbpack.Name = "cmbpack";
            this.cmbpack.Size = new System.Drawing.Size(179, 24);
            this.cmbpack.TabIndex = 61;
            // 
            // txtextraday
            // 
            this.txtextraday.Enabled = false;
            this.txtextraday.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtextraday.Location = new System.Drawing.Point(190, 318);
            this.txtextraday.MaxLength = 9;
            this.txtextraday.Name = "txtextraday";
            this.txtextraday.Size = new System.Drawing.Size(179, 23);
            this.txtextraday.TabIndex = 63;
            this.txtextraday.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtextraday_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 18);
            this.label8.TabIndex = 62;
            this.label8.Text = "Extra Day Charge*";
            // 
            // assignPack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(583, 505);
            this.Controls.Add(this.txtextraday);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbpack);
            this.Controls.Add(this.cmbtype);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.btncl);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnch);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.pbup);
            this.Controls.Add(this.pbadd);
            this.Controls.Add(this.txtExtraHour);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtExtraKM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBaseHireCharge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbid);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "assignPack";
            this.Text = "assignPack";
            this.Load += new System.EventHandler(this.assignPack_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbadd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExtraKM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBaseHireCharge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExtraHour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnch;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.PictureBox pbup;
        private System.Windows.Forms.PictureBox pbadd;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Button btncl;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.ComboBox cmbpack;
        private System.Windows.Forms.TextBox txtextraday;
        private System.Windows.Forms.Label label8;
    }
}