namespace AyuboDrive
{
    partial class pack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pack));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbid = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaxDis = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPack = new System.Windows.Forms.DataGridView();
            this.lblerror = new System.Windows.Forms.Label();
            this.dtpMaxTime = new System.Windows.Forms.DateTimePicker();
            this.btndel = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.pbup = new System.Windows.Forms.PictureBox();
            this.pbadd = new System.Windows.Forms.PictureBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncl = new System.Windows.Forms.Button();
            this.btnch = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTourType = new System.Windows.Forms.ComboBox();
            this.dtpMaxDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPack)).BeginInit();
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
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Package Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Package Number*";
            // 
            // cmbid
            // 
            this.cmbid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbid.FormattingEnabled = true;
            this.cmbid.Location = new System.Drawing.Point(171, 74);
            this.cmbid.Name = "cmbid";
            this.cmbid.Size = new System.Drawing.Size(179, 24);
            this.cmbid.TabIndex = 14;
            this.cmbid.SelectedIndexChanged += new System.EventHandler(this.cmbid_SelectedIndexChanged);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(171, 74);
            this.txtid.MaxLength = 30;
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(179, 23);
            this.txtid.TabIndex = 15;
            this.txtid.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name*";
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(171, 110);
            this.txtname.MaxLength = 30;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(179, 23);
            this.txtname.TabIndex = 17;
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Maximum Distance*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Maximum Time*";
            // 
            // txtMaxDis
            // 
            this.txtMaxDis.Enabled = false;
            this.txtMaxDis.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxDis.Location = new System.Drawing.Point(171, 149);
            this.txtMaxDis.MaxLength = 9;
            this.txtMaxDis.Name = "txtMaxDis";
            this.txtMaxDis.Size = new System.Drawing.Size(179, 23);
            this.txtMaxDis.TabIndex = 21;
            this.txtMaxDis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxDis_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPack);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 150);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package List";
            // 
            // dgvPack
            // 
            this.dgvPack.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvPack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPack.Location = new System.Drawing.Point(6, 25);
            this.dgvPack.Name = "dgvPack";
            this.dgvPack.ReadOnly = true;
            this.dgvPack.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPack.Size = new System.Drawing.Size(439, 119);
            this.dgvPack.TabIndex = 0;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(23, 414);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(252, 16);
            this.lblerror.TabIndex = 29;
            this.lblerror.Text = "Please check validity of data you entered!..";
            this.lblerror.Visible = false;
            // 
            // dtpMaxTime
            // 
            this.dtpMaxTime.CustomFormat = "HH:mm:ss";
            this.dtpMaxTime.Enabled = false;
            this.dtpMaxTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMaxTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMaxTime.Location = new System.Drawing.Point(171, 232);
            this.dtpMaxTime.Name = "dtpMaxTime";
            this.dtpMaxTime.Size = new System.Drawing.Size(179, 23);
            this.dtpMaxTime.TabIndex = 43;
            this.dtpMaxTime.Value = new System.DateTime(2020, 8, 8, 0, 0, 0, 0);
            this.dtpMaxTime.ValueChanged += new System.EventHandler(this.dtpMaxTime_ValueChanged);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.Crimson;
            this.btndel.Enabled = false;
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.Color.White;
            this.btndel.Image = ((System.Drawing.Image)(resources.GetObject("btndel.Image")));
            this.btndel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndel.Location = new System.Drawing.Point(462, 433);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(98, 44);
            this.btndel.TabIndex = 42;
            this.btndel.Text = " Delete";
            this.btndel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Orange;
            this.btnreset.Enabled = false;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.White;
            this.btnreset.Image = ((System.Drawing.Image)(resources.GetObject("btnreset.Image")));
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.Location = new System.Drawing.Point(25, 438);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(93, 39);
            this.btnreset.TabIndex = 35;
            this.btnreset.Text = "Reset";
            this.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnup
            // 
            this.btnup.BackColor = System.Drawing.Color.Orange;
            this.btnup.Enabled = false;
            this.btnup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnup.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnup.ForeColor = System.Drawing.Color.White;
            this.btnup.Image = ((System.Drawing.Image)(resources.GetObject("btnup.Image")));
            this.btnup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnup.Location = new System.Drawing.Point(240, 438);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(101, 39);
            this.btnup.TabIndex = 34;
            this.btnup.Text = "Update";
            this.btnup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnup.UseVisualStyleBackColor = false;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // pbup
            // 
            this.pbup.Image = ((System.Drawing.Image)(resources.GetObject("pbup.Image")));
            this.pbup.Location = new System.Drawing.Point(432, 131);
            this.pbup.Name = "pbup";
            this.pbup.Size = new System.Drawing.Size(128, 128);
            this.pbup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbup.TabIndex = 41;
            this.pbup.TabStop = false;
            // 
            // pbadd
            // 
            this.pbadd.Image = ((System.Drawing.Image)(resources.GetObject("pbadd.Image")));
            this.pbadd.Location = new System.Drawing.Point(432, 131);
            this.pbadd.Name = "pbadd";
            this.pbadd.Size = new System.Drawing.Size(128, 128);
            this.pbadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbadd.TabIndex = 37;
            this.pbadd.TabStop = false;
            this.pbadd.Visible = false;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(240, 438);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(101, 39);
            this.btnsave.TabIndex = 38;
            this.btnsave.Text = "Save";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Visible = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncl
            // 
            this.btncl.BackColor = System.Drawing.Color.DodgerBlue;
            this.btncl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncl.ForeColor = System.Drawing.Color.White;
            this.btncl.Image = ((System.Drawing.Image)(resources.GetObject("btncl.Image")));
            this.btncl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncl.Location = new System.Drawing.Point(25, 438);
            this.btncl.Name = "btncl";
            this.btncl.Size = new System.Drawing.Size(93, 39);
            this.btncl.TabIndex = 39;
            this.btncl.Text = " Clear";
            this.btncl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncl.UseVisualStyleBackColor = false;
            this.btncl.Visible = false;
            this.btncl.Click += new System.EventHandler(this.btncl_Click);
            // 
            // btnch
            // 
            this.btnch.BackColor = System.Drawing.Color.Peru;
            this.btnch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnch.ForeColor = System.Drawing.Color.White;
            this.btnch.Image = ((System.Drawing.Image)(resources.GetObject("btnch.Image")));
            this.btnch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnch.Location = new System.Drawing.Point(395, 75);
            this.btnch.Name = "btnch";
            this.btnch.Size = new System.Drawing.Size(165, 39);
            this.btnch.TabIndex = 40;
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
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(395, 76);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(165, 39);
            this.btnadd.TabIndex = 36;
            this.btnadd.Text = "   Add Package";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "Tour Type*";
            // 
            // cmbTourType
            // 
            this.cmbTourType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTourType.Enabled = false;
            this.cmbTourType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTourType.FormattingEnabled = true;
            this.cmbTourType.Items.AddRange(new object[] {
            "--SELECT TYPE--",
            "DAY TOUR",
            "LONG TOUR"});
            this.cmbTourType.Location = new System.Drawing.Point(171, 189);
            this.cmbTourType.Name = "cmbTourType";
            this.cmbTourType.Size = new System.Drawing.Size(179, 24);
            this.cmbTourType.TabIndex = 46;
            this.cmbTourType.SelectedIndexChanged += new System.EventHandler(this.cmbTourType_SelectedIndexChanged);
            // 
            // dtpMaxDate
            // 
            this.dtpMaxDate.CustomFormat = "yyyy/MM/dd";
            this.dtpMaxDate.Enabled = false;
            this.dtpMaxDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMaxDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMaxDate.Location = new System.Drawing.Point(171, 232);
            this.dtpMaxDate.MinDate = new System.DateTime(2020, 9, 13, 0, 0, 0, 0);
            this.dtpMaxDate.Name = "dtpMaxDate";
            this.dtpMaxDate.Size = new System.Drawing.Size(179, 23);
            this.dtpMaxDate.TabIndex = 47;
            this.dtpMaxDate.Value = new System.DateTime(2020, 9, 13, 0, 0, 0, 0);
            this.dtpMaxDate.Visible = false;
            this.dtpMaxDate.ValueChanged += new System.EventHandler(this.dtpMaxDate_ValueChanged);
            // 
            // pack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(583, 505);
            this.Controls.Add(this.dtpMaxDate);
            this.Controls.Add(this.cmbTourType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpMaxTime);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMaxDis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbup);
            this.Controls.Add(this.pbadd);
            this.Controls.Add(this.cmbid);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btncl);
            this.Controls.Add(this.btnch);
            this.Controls.Add(this.btnadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pack";
            this.Text = "pack";
            this.Load += new System.EventHandler(this.pack_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPack)).EndInit();
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
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaxDis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPack;
        private System.Windows.Forms.PictureBox pbup;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.PictureBox pbadd;
        private System.Windows.Forms.Button btncl;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnch;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.DateTimePicker dtpMaxTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTourType;
        private System.Windows.Forms.DateTimePicker dtpMaxDate;
    }
}