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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        // initializing database connection
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2OOIK8A\SQLEXPRESS;Initial Catalog=AyuboDrive;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        //Clock
        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblclock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        //Log out
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

        //Package button
        private void btnpackage_Click(object sender, EventArgs e)
        {
            panelLoad.Controls.Clear();
            pack packfrm = new pack();
            packfrm.TopLevel = false;
            panelLoad.Controls.Add(packfrm);
            packfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            packfrm.Dock = DockStyle.Fill;
            packfrm.Show();
        }

        //Vehicle button
        private void btnVehicleType_Click(object sender, EventArgs e)
        {
            panelLoad.Controls.Clear();
            vehicleType vehicleTypefrm = new vehicleType();
            vehicleTypefrm.TopLevel = false;
            panelLoad.Controls.Add(vehicleTypefrm);
            vehicleTypefrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            vehicleTypefrm.Dock = DockStyle.Fill;
            vehicleTypefrm.Show();
        }

        //Assign button
        private void btnassign_Click(object sender, EventArgs e)
        {
            panelLoad.Controls.Clear();
            assignPack AssignPackfrm = new assignPack();
            AssignPackfrm.TopLevel = false;
            panelLoad.Controls.Add(AssignPackfrm);
            AssignPackfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            AssignPackfrm.Dock = DockStyle.Fill;
            AssignPackfrm.Show();
        }

        //Account button
        private void btnacc_Click(object sender, EventArgs e)
        {
            panelLoad.Controls.Clear();
            account accountfrm = new account();
            accountfrm.TopLevel = false;
            panelLoad.Controls.Add(accountfrm);
            accountfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            accountfrm.Dock = DockStyle.Fill;
            accountfrm.Show();
        }

        //Employee button
        private void btnemp_Click(object sender, EventArgs e)
        {
            panelLoad.Controls.Clear();
            employee employeefrm = new employee();
            employeefrm.TopLevel = false;
            panelLoad.Controls.Add(employeefrm);
            employeefrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            employeefrm.Dock = DockStyle.Fill;
            employeefrm.Show();
        }

        private void btnlogs_Click(object sender, EventArgs e)
        {
            panelLoad.Controls.Clear();
            log logfrm = new log();
            logfrm.TopLevel = false;
            panelLoad.Controls.Add(logfrm);
            logfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            logfrm.Dock = DockStyle.Fill;
            logfrm.Show();
        }

        private void btndash_Click(object sender, EventArgs e)
        {
            panelLoad.Controls.Clear();
            adminDash adminDashfrm = new adminDash();
            adminDashfrm.TopLevel = false;
            panelLoad.Controls.Add(adminDashfrm);
            adminDashfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            adminDashfrm.Dock = DockStyle.Fill;
            adminDashfrm.Show();
        }

        private void panelLoad_Paint(object sender, PaintEventArgs e)
        {
            adminDash adminDashfrm = new adminDash();
            adminDashfrm.TopLevel = false;
            panelLoad.Controls.Add(adminDashfrm);
            adminDashfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            adminDashfrm.Dock = DockStyle.Fill;
            adminDashfrm.Show();
        }
    }
}
