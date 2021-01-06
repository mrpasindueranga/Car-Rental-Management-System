namespace AyuboDrive
{
    partial class payment
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
            this.tabControlPay = new System.Windows.Forms.TabControl();
            this.tabPageMenu = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureRent = new System.Windows.Forms.PictureBox();
            this.tabPageRenPay = new System.Windows.Forms.TabPage();
            this.panelRenLoad = new System.Windows.Forms.Panel();
            this.tabPageHire = new System.Windows.Forms.TabPage();
            this.panelHire = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tabControlPay.SuspendLayout();
            this.tabPageMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRent)).BeginInit();
            this.tabPageRenPay.SuspendLayout();
            this.tabPageHire.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(178)))));
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
            this.label1.Size = new System.Drawing.Size(222, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Management";
            // 
            // tabControlPay
            // 
            this.tabControlPay.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlPay.Controls.Add(this.tabPageMenu);
            this.tabControlPay.Controls.Add(this.tabPageRenPay);
            this.tabControlPay.Controls.Add(this.tabPageHire);
            this.tabControlPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPay.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControlPay.Location = new System.Drawing.Point(0, 55);
            this.tabControlPay.Name = "tabControlPay";
            this.tabControlPay.SelectedIndex = 0;
            this.tabControlPay.Size = new System.Drawing.Size(583, 450);
            this.tabControlPay.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlPay.TabIndex = 3;
            // 
            // tabPageMenu
            // 
            this.tabPageMenu.BackColor = System.Drawing.Color.Snow;
            this.tabPageMenu.Controls.Add(this.label2);
            this.tabPageMenu.Controls.Add(this.pictureRent);
            this.tabPageMenu.Location = new System.Drawing.Point(4, 5);
            this.tabPageMenu.Name = "tabPageMenu";
            this.tabPageMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMenu.Size = new System.Drawing.Size(575, 441);
            this.tabPageMenu.TabIndex = 0;
            this.tabPageMenu.Text = "tabPage1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rent Payment";
            // 
            // pictureRent
            // 
            this.pictureRent.Image = global::AyuboDrive.Properties.Resources.rent;
            this.pictureRent.Location = new System.Drawing.Point(24, 53);
            this.pictureRent.Name = "pictureRent";
            this.pictureRent.Size = new System.Drawing.Size(200, 200);
            this.pictureRent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureRent.TabIndex = 9;
            this.pictureRent.TabStop = false;
            this.pictureRent.Click += new System.EventHandler(this.pictureRent_Click_1);
            // 
            // tabPageRenPay
            // 
            this.tabPageRenPay.BackColor = System.Drawing.Color.Snow;
            this.tabPageRenPay.Controls.Add(this.panelRenLoad);
            this.tabPageRenPay.Location = new System.Drawing.Point(4, 5);
            this.tabPageRenPay.Name = "tabPageRenPay";
            this.tabPageRenPay.Size = new System.Drawing.Size(575, 441);
            this.tabPageRenPay.TabIndex = 1;
            this.tabPageRenPay.Text = "tabPage1";
            // 
            // panelRenLoad
            // 
            this.panelRenLoad.AutoScroll = true;
            this.panelRenLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRenLoad.Location = new System.Drawing.Point(0, 0);
            this.panelRenLoad.Name = "panelRenLoad";
            this.panelRenLoad.Size = new System.Drawing.Size(575, 441);
            this.panelRenLoad.TabIndex = 0;
            // 
            // tabPageHire
            // 
            this.tabPageHire.BackColor = System.Drawing.Color.Snow;
            this.tabPageHire.Controls.Add(this.panelHire);
            this.tabPageHire.Location = new System.Drawing.Point(4, 5);
            this.tabPageHire.Name = "tabPageHire";
            this.tabPageHire.Size = new System.Drawing.Size(575, 441);
            this.tabPageHire.TabIndex = 2;
            this.tabPageHire.Text = "tabPage1";
            // 
            // panelHire
            // 
            this.panelHire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHire.Location = new System.Drawing.Point(0, 0);
            this.panelHire.Name = "panelHire";
            this.panelHire.Size = new System.Drawing.Size(575, 441);
            this.panelHire.TabIndex = 0;
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(583, 505);
            this.Controls.Add(this.tabControlPay);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "payment";
            this.Text = "payment";
            this.Load += new System.EventHandler(this.payment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlPay.ResumeLayout(false);
            this.tabPageMenu.ResumeLayout(false);
            this.tabPageMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRent)).EndInit();
            this.tabPageRenPay.ResumeLayout(false);
            this.tabPageHire.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlPay;
        private System.Windows.Forms.TabPage tabPageMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureRent;
        private System.Windows.Forms.TabPage tabPageRenPay;
        private System.Windows.Forms.Panel panelRenLoad;
        private System.Windows.Forms.TabPage tabPageHire;
        private System.Windows.Forms.Panel panelHire;
    }
}