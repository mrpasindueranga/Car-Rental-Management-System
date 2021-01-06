namespace AyuboDrive
{
    partial class admin
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
            this.btnemp = new System.Windows.Forms.Button();
            this.btnlogs = new System.Windows.Forms.Button();
            this.btnacc = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btndash = new System.Windows.Forms.Button();
            this.btnassign = new System.Windows.Forms.Button();
            this.btnVehicleType = new System.Windows.Forms.Button();
            this.btnpackage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblclock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLoad = new System.Windows.Forms.Panel();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.paneldashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneldashboard
            // 
            this.paneldashboard.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.paneldashboard.Controls.Add(this.btnemp);
            this.paneldashboard.Controls.Add(this.btnlogs);
            this.paneldashboard.Controls.Add(this.btnacc);
            this.paneldashboard.Controls.Add(this.btnlogout);
            this.paneldashboard.Controls.Add(this.btndash);
            this.paneldashboard.Controls.Add(this.btnassign);
            this.paneldashboard.Controls.Add(this.btnVehicleType);
            this.paneldashboard.Controls.Add(this.btnpackage);
            this.paneldashboard.Controls.Add(this.label1);
            this.paneldashboard.Controls.Add(this.panel1);
            this.paneldashboard.Controls.Add(this.pictureBox1);
            this.paneldashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneldashboard.Location = new System.Drawing.Point(0, 0);
            this.paneldashboard.Name = "paneldashboard";
            this.paneldashboard.Size = new System.Drawing.Size(217, 530);
            this.paneldashboard.TabIndex = 1;
            // 
            // btnemp
            // 
            this.btnemp.FlatAppearance.BorderSize = 0;
            this.btnemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnemp.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnemp.Image = global::AyuboDrive.Properties.Resources.taxi_driver__1_;
            this.btnemp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnemp.Location = new System.Drawing.Point(0, 379);
            this.btnemp.Name = "btnemp";
            this.btnemp.Size = new System.Drawing.Size(217, 49);
            this.btnemp.TabIndex = 11;
            this.btnemp.Text = "   Employee Management";
            this.btnemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnemp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnemp.UseVisualStyleBackColor = true;
            this.btnemp.Click += new System.EventHandler(this.btnemp_Click);
            // 
            // btnlogs
            // 
            this.btnlogs.FlatAppearance.BorderSize = 0;
            this.btnlogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogs.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlogs.Image = global::AyuboDrive.Properties.Resources.log_file__1_;
            this.btnlogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogs.Location = new System.Drawing.Point(0, 428);
            this.btnlogs.Name = "btnlogs";
            this.btnlogs.Size = new System.Drawing.Size(217, 49);
            this.btnlogs.TabIndex = 10;
            this.btnlogs.Text = "   System Logs";
            this.btnlogs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlogs.UseVisualStyleBackColor = true;
            this.btnlogs.Click += new System.EventHandler(this.btnlogs_Click);
            // 
            // btnacc
            // 
            this.btnacc.FlatAppearance.BorderSize = 0;
            this.btnacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnacc.Image = global::AyuboDrive.Properties.Resources.login;
            this.btnacc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnacc.Location = new System.Drawing.Point(0, 330);
            this.btnacc.Name = "btnacc";
            this.btnacc.Size = new System.Drawing.Size(217, 49);
            this.btnacc.TabIndex = 9;
            this.btnacc.Text = "   Account Management";
            this.btnacc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnacc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnacc.UseVisualStyleBackColor = true;
            this.btnacc.Click += new System.EventHandler(this.btnacc_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlogout.Image = global::AyuboDrive.Properties.Resources.logout;
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(0, 479);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(217, 49);
            this.btnlogout.TabIndex = 8;
            this.btnlogout.Text = "   Logout";
            this.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btndash
            // 
            this.btndash.FlatAppearance.BorderSize = 0;
            this.btndash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndash.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndash.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btndash.Image = global::AyuboDrive.Properties.Resources.dashboard__3_;
            this.btndash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndash.Location = new System.Drawing.Point(0, 133);
            this.btndash.Name = "btndash";
            this.btndash.Size = new System.Drawing.Size(217, 49);
            this.btndash.TabIndex = 7;
            this.btndash.Text = "   System Dashboard";
            this.btndash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndash.UseVisualStyleBackColor = true;
            this.btndash.Click += new System.EventHandler(this.btndash_Click);
            // 
            // btnassign
            // 
            this.btnassign.FlatAppearance.BorderSize = 0;
            this.btnassign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnassign.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnassign.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnassign.Image = global::AyuboDrive.Properties.Resources.logistics;
            this.btnassign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnassign.Location = new System.Drawing.Point(0, 279);
            this.btnassign.Name = "btnassign";
            this.btnassign.Size = new System.Drawing.Size(217, 49);
            this.btnassign.TabIndex = 6;
            this.btnassign.Text = "   Assign Packages";
            this.btnassign.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnassign.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnassign.UseVisualStyleBackColor = true;
            this.btnassign.Click += new System.EventHandler(this.btnassign_Click);
            // 
            // btnVehicleType
            // 
            this.btnVehicleType.FlatAppearance.BorderSize = 0;
            this.btnVehicleType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicleType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicleType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVehicleType.Image = global::AyuboDrive.Properties.Resources.car__2_;
            this.btnVehicleType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicleType.Location = new System.Drawing.Point(0, 231);
            this.btnVehicleType.Name = "btnVehicleType";
            this.btnVehicleType.Size = new System.Drawing.Size(217, 49);
            this.btnVehicleType.TabIndex = 5;
            this.btnVehicleType.Text = "   Vehicle Management";
            this.btnVehicleType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVehicleType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVehicleType.UseVisualStyleBackColor = true;
            this.btnVehicleType.Click += new System.EventHandler(this.btnVehicleType_Click);
            // 
            // btnpackage
            // 
            this.btnpackage.FlatAppearance.BorderSize = 0;
            this.btnpackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpackage.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpackage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnpackage.Image = global::AyuboDrive.Properties.Resources.order;
            this.btnpackage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpackage.Location = new System.Drawing.Point(0, 182);
            this.btnpackage.Name = "btnpackage";
            this.btnpackage.Size = new System.Drawing.Size(217, 49);
            this.btnpackage.TabIndex = 4;
            this.btnpackage.Text = "   Package Management";
            this.btnpackage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpackage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpackage.UseVisualStyleBackColor = true;
            this.btnpackage.Click += new System.EventHandler(this.btnpackage_Click);
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
            this.pictureBox1.Image = global::AyuboDrive.Properties.Resources.database__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblclock);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(217, 505);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 25);
            this.panel2.TabIndex = 3;
            // 
            // lblclock
            // 
            this.lblclock.AutoSize = true;
            this.lblclock.Font = new System.Drawing.Font("DS-Digital", 14.25F);
            this.lblclock.Location = new System.Drawing.Point(511, 5);
            this.lblclock.Name = "lblclock";
            this.lblclock.Size = new System.Drawing.Size(0, 19);
            this.lblclock.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label3.Location = new System.Drawing.Point(6, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome to the system, you are logged as administrator";
            // 
            // panelLoad
            // 
            this.panelLoad.Location = new System.Drawing.Point(217, 0);
            this.panelLoad.Name = "panelLoad";
            this.panelLoad.Size = new System.Drawing.Size(583, 505);
            this.panelLoad.TabIndex = 4;
            this.panelLoad.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLoad_Paint);
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.panelLoad);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.paneldashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.paneldashboard.ResumeLayout(false);
            this.paneldashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldashboard;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btndash;
        private System.Windows.Forms.Button btnassign;
        private System.Windows.Forms.Button btnVehicleType;
        private System.Windows.Forms.Button btnpackage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblclock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelLoad;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Button btnlogs;
        private System.Windows.Forms.Button btnacc;
        private System.Windows.Forms.Button btnemp;
    }
}