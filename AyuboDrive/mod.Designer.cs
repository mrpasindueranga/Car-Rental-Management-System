namespace AyuboDrive
{
    partial class mod
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
            this.components = new System.ComponentModel.Container();
            this.paneldashboard = new System.Windows.Forms.Panel();
            this.btnpay = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btncus = new System.Windows.Forms.Button();
            this.btnservice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLoad = new System.Windows.Forms.Panel();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblclock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.paneldashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneldashboard
            // 
            this.paneldashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(178)))));
            this.paneldashboard.Controls.Add(this.btnpay);
            this.paneldashboard.Controls.Add(this.btnlogout);
            this.paneldashboard.Controls.Add(this.btncus);
            this.paneldashboard.Controls.Add(this.btnservice);
            this.paneldashboard.Controls.Add(this.label1);
            this.paneldashboard.Controls.Add(this.panel1);
            this.paneldashboard.Controls.Add(this.pictureBox1);
            this.paneldashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneldashboard.Location = new System.Drawing.Point(0, 0);
            this.paneldashboard.Name = "paneldashboard";
            this.paneldashboard.Size = new System.Drawing.Size(217, 530);
            this.paneldashboard.TabIndex = 0;
            // 
            // btnpay
            // 
            this.btnpay.FlatAppearance.BorderSize = 0;
            this.btnpay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpay.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnpay.Image = global::AyuboDrive.Properties.Resources.pay;
            this.btnpay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpay.Location = new System.Drawing.Point(0, 244);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(217, 49);
            this.btnpay.TabIndex = 9;
            this.btnpay.Text = "  Payment Management";
            this.btnpay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpay.UseVisualStyleBackColor = true;
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlogout.Image = global::AyuboDrive.Properties.Resources.logout;
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(0, 469);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(217, 49);
            this.btnlogout.TabIndex = 8;
            this.btnlogout.Text = "  Logout";
            this.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btncus
            // 
            this.btncus.FlatAppearance.BorderSize = 0;
            this.btncus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncus.Image = global::AyuboDrive.Properties.Resources.person__2_;
            this.btncus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncus.Location = new System.Drawing.Point(0, 193);
            this.btncus.Name = "btncus";
            this.btncus.Size = new System.Drawing.Size(217, 49);
            this.btncus.TabIndex = 5;
            this.btncus.Text = "  Customer Management";
            this.btncus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncus.UseVisualStyleBackColor = true;
            this.btncus.Click += new System.EventHandler(this.btncus_Click);
            // 
            // btnservice
            // 
            this.btnservice.FlatAppearance.BorderSize = 0;
            this.btnservice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnservice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnservice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnservice.Image = global::AyuboDrive.Properties.Resources.car_rental;
            this.btnservice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnservice.Location = new System.Drawing.Point(0, 142);
            this.btnservice.Name = "btnservice";
            this.btnservice.Size = new System.Drawing.Size(217, 49);
            this.btnservice.TabIndex = 4;
            this.btnservice.Text = "  Service Management";
            this.btnservice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnservice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnservice.UseVisualStyleBackColor = true;
            this.btnservice.Click += new System.EventHandler(this.btnservice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(9, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome, ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(0, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 2);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AyuboDrive.Properties.Resources.boss__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelLoad
            // 
            this.panelLoad.Location = new System.Drawing.Point(217, 0);
            this.panelLoad.Name = "panelLoad";
            this.panelLoad.Size = new System.Drawing.Size(583, 505);
            this.panelLoad.TabIndex = 1;
            this.panelLoad.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLoad_Paint);
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblclock);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(217, 505);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 25);
            this.panel2.TabIndex = 2;
            // 
            // lblclock
            // 
            this.lblclock.AutoSize = true;
            this.lblclock.Font = new System.Drawing.Font("DS-Digital", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclock.Location = new System.Drawing.Point(490, 5);
            this.lblclock.Name = "lblclock";
            this.lblclock.Size = new System.Drawing.Size(0, 19);
            this.lblclock.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome to the system, you are logged as moderator";
            // 
            // mod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLoad);
            this.Controls.Add(this.paneldashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mod";
            this.paneldashboard.ResumeLayout(false);
            this.paneldashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnservice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncus;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Panel panelLoad;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblclock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnpay;
    }
}