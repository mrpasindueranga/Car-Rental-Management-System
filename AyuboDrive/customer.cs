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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2OOIK8A\SQLEXPRESS;Initial Catalog=AyuboDrive;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        //Get id information

        private void getid()
        {
            cmbid.Items.Clear();
            String getcusid = "SELECT CusID FROM Customer";
            con.Open();
            SqlDa = new SqlDataAdapter(getcusid, con);
            DataTable cusidTable = new DataTable();
            SqlDa.Fill(cusidTable);
            con.Close();
            if (cusidTable.Rows.Count == 0)
            {
                cmbid.Items.Add("-NO CUSTOMER STILL EXITS-");
                cmbid.SelectedIndex = 0;
            }
            else
            {
                cmbid.Items.Add("--SELECT ID--");
                cmbid.SelectedIndex = 0;
                foreach (DataRow row in cusidTable.Rows)
                {
                    cmbid.Items.Add(row["CusID"]);
                }
            }
        }

        //Create new id

        String maxID;
        private void getNextCusID()
        {
            String getCusID = "SELECT CusID FROM Customer";
            String getMaxCusID = "SELECT MAX(CusID) FROM Customer";
            con.Open();
            SqlDa = new SqlDataAdapter(getCusID, con);
            con.Close();
            DataTable customerIDTable = new DataTable();
            SqlDa.Fill(customerIDTable);
            
             if (customerIDTable.Rows.Count == 0)
            {
                txtid.Text = "CUS-0001";
            }
           else
            {
                con.Open();
                cmd = new SqlCommand(getMaxCusID, con);
                SqlDataReader readCustomerMaxID = cmd.ExecuteReader();
                while (readCustomerMaxID.Read())
                {
                    maxID = readCustomerMaxID.GetValue(0).ToString();
                }
                con.Close();
                txtid.Text = maxID.Substring(0, 4) + String.Format("{0:0000}", (int.Parse(maxID.Substring(4)) + 1));
            }
        }

    
        //Clear form
        private void Clear()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
            rbNotSpecified.Checked = false;
            txtcon.Text = "";
            txtadd.Text = "";
            txtFname.Focus();
        }

        //Fill form information

        private void fill()
        {
            if (cmbid.SelectedIndex != 0)
            {
                String id = cmbid.Text;
                String getcustomer = "SELECT * FROM Customer WHERE CusID=@CusID";
                con.Open();
                cmd = new SqlCommand(getcustomer, con);
                cmd.Parameters.Add("@CusID", SqlDbType.VarChar, 8).Value = cmbid.Text;
                SqlDataReader readCustomer = cmd.ExecuteReader();
                while (readCustomer.Read())
                {
                    txtFname.Text = readCustomer.GetValue(1).ToString();
                    txtLname.Text = readCustomer.GetValue(2).ToString();
                    gender = readCustomer.GetValue(3).ToString();
                    txtcon.Text = readCustomer.GetValue(4).ToString();
                    txtadd.Text = readCustomer.GetValue(5).ToString();
                }
                if (gender.Equals("M")) { rbMale.Checked = true; }
                else if (gender.Equals("F")) { rbFemale.Checked = true; }
                else if (gender.Equals("N")) { rbNotSpecified.Checked = true; }
                con.Close();
            }
        }

        private void blockInput()
        {
            txtFname.Enabled = false;
            txtLname.Enabled = false;
            rbMale.Enabled = false;
            rbFemale.Enabled = false;
            rbNotSpecified.Enabled = false;
            txtcon.Enabled = false;
            txtadd.Enabled = false;
        }

        private void enableInput()
        {
            txtFname.Enabled = true;
            txtLname.Enabled = true;
            rbMale.Enabled = true;
            rbFemale.Enabled = true;
            rbNotSpecified.Enabled = true;
            txtcon.Enabled = true;
            txtadd.Enabled = true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            btnadd.Visible = false;
            btnch.Visible = true;
            btnreset.Visible = false;
            btncl.Visible = true;
            btnup.Visible = false;
            btnsave.Visible = true;
            cmbid.Visible = false;
            txtid.Visible = true;
            pbadd.Visible = true;
            pbup.Visible = false;
            Clear();
            getNextCusID();
            enableInput();
        }

        private void btnch_Click(object sender, EventArgs e)
        {
            btnadd.Visible = true;
            btnch.Visible = false;
            btnreset.Visible = true;
            btncl.Visible = false;
            btnup.Visible = true;
            btnsave.Visible = false;
            cmbid.Visible = true;
            txtid.Visible = false;
            pbadd.Visible = false;
            pbup.Visible = true;
            getid();
            Clear();
            blockInput();
        }
        private void customer_Load(object sender, EventArgs e)
        {
            txtFname.Focus();
            getid();
            blockInput();
        }

        String gender;
        private void cmbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            fill();
            if (cmbid.SelectedIndex == 0)
            {
                Clear();
                blockInput();
            }
            else
            {
                enableInput();
            }
        }

        //Save information

        Regex conNo = new Regex(@"0[0-9]{9,9}");

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtFname.Text) && !String.IsNullOrEmpty(txtLname.Text) && (rbFemale.Checked || rbMale.Checked || rbNotSpecified.Checked) && conNo.IsMatch(txtcon.Text) && !String.IsNullOrEmpty(txtadd.Text))
                {
                    lblerror.Visible = false;
                    DialogResult confirmSave = MessageBox.Show("Are you want to SAVE Customer " + txtid.Text + "?..", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmSave == DialogResult.Yes)
                    {
                        if (rbMale.Checked == true) { gender = "M"; }
                        else if (rbFemale.Checked == true) { gender = "F"; }
                        else if (rbNotSpecified.Checked == true) { gender = "N"; }
                        String saveCustomer = "INSERT INTO Customer VALUES(@CusID, @Fname, @Lname, @gender, @ConNo, @Add);";
                        con.Open();
                        cmd = new SqlCommand(saveCustomer, con);
                        cmd.Parameters.Add("@CusID",SqlDbType.VarChar,8).Value = txtid.Text;
                        cmd.Parameters.Add("@Fname", SqlDbType.VarChar, 30).Value = txtFname.Text;
                        cmd.Parameters.Add("@Lname", SqlDbType.VarChar, 30).Value = txtLname.Text;
                        cmd.Parameters.Add("@gender", SqlDbType.Char, 1).Value = gender;
                        cmd.Parameters.Add("@ConNo", SqlDbType.VarChar, 10).Value = txtcon.Text;
                        cmd.Parameters.Add("@Add", SqlDbType.VarChar, 100).Value = txtadd.Text;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Clear();
                        getNextCusID();
                        MessageBox.Show("Customer ID : "+txtid.Text+" SAVED Successfully..!", "Successfully Saved!..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
               
                else
                {
                    lblerror.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Saving Data..!" + Environment.NewLine + ex);
            }
        }

        private void btncl_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            fill();
        }

        //Update information

        private void btnup_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtFname.Text) && !String.IsNullOrEmpty(txtLname.Text) && (rbFemale.Checked || rbMale.Checked || rbNotSpecified.Checked) && conNo.IsMatch(txtcon.Text) && !String.IsNullOrEmpty(txtadd.Text))
                {
                    lblerror.Visible = false;
                    DialogResult confirmUpdate = MessageBox.Show("Are you want to UPDATE Customer " + cmbid.Text + "?..", "Confirm Update..!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmUpdate == DialogResult.Yes)
                    {
                        if (rbMale.Checked == true) { gender = "M"; }
                        else if (rbFemale.Checked == true) { gender = "F"; }
                        else if (rbNotSpecified.Checked == true) { gender = "N"; }
                        String updateCustomer = "UPDATE Customer SET Fname=@Fname, Lname=@Lname, Gender=@gender, ConNo=@ConNo, Address=@Add WHERE CusID=@CusID";
                        con.Open();
                        cmd = new SqlCommand(updateCustomer, con);
                        cmd.Parameters.Add("@Fname", SqlDbType.VarChar, 30).Value = txtFname.Text;
                        cmd.Parameters.Add("@Lname", SqlDbType.VarChar, 30).Value = txtLname.Text;
                        cmd.Parameters.Add("@gender", SqlDbType.Char, 1).Value = gender;
                        cmd.Parameters.Add("@ConNo", SqlDbType.VarChar, 10).Value = txtcon.Text;
                        cmd.Parameters.Add("@Add", SqlDbType.VarChar, 100).Value = txtadd.Text;
                        cmd.Parameters.Add("@CusID", SqlDbType.VarChar, 8).Value = cmbid.Text;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmbid.SelectedIndex = 0;
                        Clear();
                        MessageBox.Show("Customer ID : " + cmbid.Text + " UPDATE Successfully..!", "Successfully Updated!..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                 }
                else
                {
                    lblerror.Visible = true;
                }
              }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Updating Data..!" + Environment.NewLine + ex);
            }
        }

        //Validate information

        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"[a-zA-z]").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"[a-zA-z]").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtcon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex("[0-9]").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtadd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"[\w,:;]").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8 || e.KeyChar == 32) { e.Handled = false; }
            else { e.Handled = true; }
        }
    }
}