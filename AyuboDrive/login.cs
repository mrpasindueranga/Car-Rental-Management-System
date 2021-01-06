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
using System.Text.RegularExpressions;

namespace AyuboDrive
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        // initializing database connection
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2OOIK8A\SQLEXPRESS;Initial Catalog=AyuboDrive;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        //Get next ManID

        String maxID;
        public static String LogNo;
        private void getNextLogID()
        {
            String getLogID = "SELECT LogNo FROM Log";
            String getMaxLogID = "SELECT MAX(LogNo) LogNo FROM Log";
            con.Open();
            SqlDa = new SqlDataAdapter(getLogID, con);
            con.Close();
            DataTable logIDTable = new DataTable();
            SqlDa.Fill(logIDTable);

            if (logIDTable.Rows.Count == 0)
            {
                LogNo = "LOG-0001";
            }
            else
            {
                con.Open();
                cmd = new SqlCommand(getMaxLogID, con);
                SqlDataReader readLogMaxID = cmd.ExecuteReader();
                while (readLogMaxID.Read())
                {
                    maxID = readLogMaxID.GetValue(0).ToString();
                }
                LogNo = maxID.Substring(0, 4) + String.Format("{0:0000}", (int.Parse(maxID.Substring(4)) + 1));
                con.Close();
            }
        }

        // Application exit
        private void linkCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult cancel = MessageBox.Show("Are you want to EXIT?..","Confirm to exit!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (cancel == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Application login

        public static String ManID;
        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                String Cred = "SELECT ManID, [Username], [Password], Type FROM Account WHERE [Username]= @Username AND [Password]= @Password";
                con.Open();
                SqlDa = new SqlDataAdapter(Cred, con);
                SqlDa.SelectCommand.Parameters.Add("@Username", SqlDbType.VarChar,20).Value = txtusername.Text;
                SqlDa.SelectCommand.Parameters.Add("@Password", SqlDbType.VarChar, 20).Value = txtpassword.Text;
                con.Close();
                DataTable CredTable = new DataTable();
                SqlDa.Fill(CredTable);
                if (CredTable.Rows.Count == 0)
                {
                    lblmessage.Visible = true;
                }

                else
                {
                    String AccType;

                    AccType = CredTable.Rows[0]["Type"].ToString();
                    ManID = CredTable.Rows[0]["ManID"].ToString();

                    if (AccType.Equals("Admin"))
                    {
                        admin AdminFrm = new admin();
                        AdminFrm.Show();
                        this.Hide();
                    }
                    else if (AccType.Equals("Moderator"))
                    {
                        mod ModFrm = new mod();
                        ModFrm.Show();
                        this.Hide();
                    }

                    // Save login info to log
                    getNextLogID();
                    String Log = "INSERT INTO Log(LogNo, Date, LoginTime, ManID) VALUES(@LogNo, @Date, @LoginTime, @ManID)";
                    con.Open();
                    cmd = new SqlCommand(Log, con);
                    cmd.Parameters.Add("@LogNo", SqlDbType.VarChar, 8).Value = LogNo;
                    cmd.Parameters.Add("@Date", SqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("@LoginTime", SqlDbType.Time).Value = DateTime.Now.ToString("HH:mm:ss");
                    cmd.Parameters.Add("@ManID", SqlDbType.VarChar, 8).Value = ManID;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Login!!" + Environment.NewLine + ex);
            }
        }

        // Checking vaild data is in the input
        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            lblmessage.Visible = false;
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            lblmessage.Visible = false;
        }

        private void login_Load(object sender, EventArgs e)
        {
            txtusername.Focus();
        }

        // Restricted unwanted keys
        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"\w").IsMatch(e.KeyChar.ToString()) || e.KeyChar==8)
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"\w").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }
        
    }
}
