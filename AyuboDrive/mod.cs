using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AyuboDrive
{
    public partial class mod : Form
    {
        public mod()
        {
            InitializeComponent();
        }

        // initializing database connection
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2OOIK8A\SQLEXPRESS;Initial Catalog=AyuboDrive;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        //Logout
        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Are you want to LOGOUT?..", "Confirm to Logout!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (logout == DialogResult.Yes)
            {
                login loginfrm = new login();
                loginfrm.Show();
                this.Dispose();

                String Logout = "UPDATE Log SET LogoutTime=@Logout WHERE LogNo=@LogNo";
                con.Open();
                cmd = new SqlCommand(Logout, con);
                cmd.Parameters.Add("@Logout", SqlDbType.Time).Value = DateTime.Now.ToString("HH:mm:ss");
                cmd.Parameters.Add("@LogNo", SqlDbType.VarChar, 8).Value = login.LogNo;
                cmd.ExecuteNonQuery();
                con.Close();
                
            }
        }

        //Customer button
        private void btncus_Click(object sender, EventArgs e)
        {
            panelLoad.Controls.Clear();
            customer cusfrm = new customer();
            cusfrm.TopLevel = false;
            panelLoad.Controls.Add(cusfrm);
            cusfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cusfrm.Dock = DockStyle.Fill;
            cusfrm.Show();
        }

        //Service button
        private void btnservice_Click(object sender, EventArgs e)
        {
            panelLoad.Controls.Clear();
            Service servicefrm = new Service();
            servicefrm.TopLevel = false;
            panelLoad.Controls.Add(servicefrm);
            servicefrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            servicefrm.Dock = DockStyle.Fill;
            servicefrm.Show();
        }

        //Clock
        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblclock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        //Default open service form
        private void panelLoad_Paint(object sender, PaintEventArgs e)
        {
            Service servicefrm = new Service();
            servicefrm.TopLevel = false;
            panelLoad.Controls.Add(servicefrm);
            servicefrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            servicefrm.Dock = DockStyle.Fill;
            servicefrm.Show();
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            panelLoad.Controls.Clear();
            payment payfrm = new payment();
            payfrm.TopLevel = false;
            panelLoad.Controls.Add(payfrm);
            payfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            payfrm.Dock = DockStyle.Fill;
            payfrm.Show();
        }
    }
}
