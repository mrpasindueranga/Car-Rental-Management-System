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
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }

        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2OOIK8A\SQLEXPRESS;Initial Catalog=AyuboDrive;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        //Navigate around forms

        private void pictureUser_Click(object sender, EventArgs e)
        {
            txtFname.Focus();
            getid();
            tabAccount.SelectedTab = tabPageManagement;
        }

        private void pictureAcc_Click(object sender, EventArgs e)
        {
            tabAccount.SelectedTab = tabPageAccount;
            getAcid();
        }

        //Get id information

        private void getid()
        {
            cmbManID.Items.Clear();
            String getManID = "SELECT ManID FROM Management";
            con.Open();
            SqlDa = new SqlDataAdapter(getManID, con);
            con.Close();
            DataTable ManIDTable = new DataTable();
            SqlDa.Fill(ManIDTable);
            if (ManIDTable.Rows.Count == 0)
            {
                cmbManID.Items.Add("-NO USER STILL EXITS-");
                cmbManID.SelectedIndex = 0;
            }
            else
            {
                cmbManID.Items.Add("--SELECT NO--");
                cmbManID.SelectedIndex = 0;
                foreach (DataRow row in ManIDTable.Rows)
                {
                    cmbManID.Items.Add(row["ManID"]);
                }
            }
        }

        //Get new id

        String maxManID;
        private void getNextManID()
        {
            String getManID = "SELECT ManID FROM Management";
            String getMaxManID = "SELECT MAX(ManID) ManID FROM Management";
            con.Open();
            SqlDa = new SqlDataAdapter(getManID, con);
            con.Close();
            DataTable ManIDTable = new DataTable();
            SqlDa.Fill(ManIDTable);
            if (ManIDTable.Rows.Count == 0)
            {
                txtid.Text = "MAN-0001";
            }
            else
            {
                con.Open();
                cmd = new SqlCommand(getMaxManID, con);
                SqlDataReader readManMaxID = cmd.ExecuteReader();
                while (readManMaxID.Read())
                {
                    maxManID = readManMaxID.GetValue(0).ToString();
                }
                con.Close();
                txtid.Text = maxManID.Substring(0, 4) + String.Format("{0:0000}", (int.Parse(maxManID.Substring(4)) + 1));
            }
        }

        //Clear form

        private void Clear()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            rbFemale.Checked = false;
            rbMale.Checked = false;
            rbNotSpecified.Checked = false;
            dtpDOB.Value = DateTime.Now;
            txtcon.Text = "";
            txtemail.Text = "";
            dtpHiredDate.Value = DateTime.Now;
            txtFname.Focus();
        }

        //Fill form information

        String gender;
        private void fill()
        {
            if (cmbManID.SelectedIndex != 0)
            {
                String id = cmbManID.Text;
                String getman = "SELECT * FROM Management WHERE ManID=@ID";
                con.Open();
                cmd = new SqlCommand(getman, con);
                cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = cmbManID.Text;
                SqlDataReader readman = cmd.ExecuteReader();
                while (readman.Read())
                {
                    txtFname.Text = readman.GetValue(1).ToString();
                    txtLname.Text = readman.GetValue(2).ToString();
                    gender = readman.GetValue(3).ToString();
                    dtpDOB.Text = readman.GetValue(4).ToString();
                    txtcon.Text = readman.GetValue(5).ToString();
                    txtemail.Text = readman.GetValue(6).ToString();
                    dtpHiredDate.Text = readman.GetValue(7).ToString();
                }
                if (gender.Equals("M")) { rbMale.Checked = true; }
                else if (gender.Equals("F")) { rbFemale.Checked = true; }
                else if (gender.Equals("N")) { rbNotSpecified.Checked = true; }
                con.Close();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            btnadd.Visible = false;
            btnch.Visible = true;
            btnreset.Visible = false;
            btncl.Visible = true;
            btnup.Visible = false;
            btndel.Visible = false;
            btnsave.Visible = true;
            cmbManID.Visible = false;
            txtid.Visible = true;
            pbadd.Visible = true;
            pbup.Visible = false;
            Clear();
            getNextManID();
            enableInput();
        }

        private void btnch_Click(object sender, EventArgs e)
        {
            btnadd.Visible = true;
            btnch.Visible = false;
            btnreset.Visible = true;
            btncl.Visible = false;
            btnup.Visible = true;
            btndel.Visible = true;
            btnsave.Visible = false;
            cmbManID.Visible = true;
            txtid.Visible = false;
            pbadd.Visible = false;
            pbup.Visible = true;
            getid();
            Clear();
            blockInput();
        }

        private void enableInput()
        {
            txtFname.Enabled = true;
            txtLname.Enabled = true;
            rbMale.Enabled = true;
            rbFemale.Enabled = true;
            rbNotSpecified.Enabled = true;
            txtcon.Enabled = true;
            dtpDOB.Enabled = true;
            txtemail.Enabled = true;
            dtpHiredDate.Enabled = true;
            btnreset.Enabled = true;
            btnup.Enabled = true;
            btndel.Enabled = true;
        }

        private void blockInput()
        {
            txtFname.Enabled = false;
            txtLname.Enabled = false;
            rbMale.Enabled = false;
            rbFemale.Enabled = false;
            rbNotSpecified.Enabled = false;
            txtcon.Enabled = false;
            dtpDOB.Enabled = false;
            dtpHiredDate.Enabled = false;
            txtemail.Enabled = false;
            btnreset.Enabled = false;
            btnup.Enabled = false;
        }

        private void cmbManID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbManID.SelectedIndex == 0) { Clear(); blockInput(); }
            else
            {
                enableInput();
                fill();
            }
        }

        //Save information

        Regex conNo = new Regex(@"0[0-9]{9,9}");
        Regex Email = new Regex(@"^((([!#$%&'*+\-/=?^_`{|}~\w])|([!#$%&'*+\-/=?^_`{|}~\w][!#$%&'*+\-/=?^_`{|}~\.\w]{0,}[!#$%&'*+\-/=?^_`{|}~\w]))[@]\w+([-.]\w+)*\.\w+([-.]\w+)*)$");

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtFname.Text) && !String.IsNullOrEmpty(txtLname.Text) && (rbFemale.Checked || rbMale.Checked || rbNotSpecified.Checked) && conNo.IsMatch(txtcon.Text) && Email.IsMatch(txtemail.Text))
                {
                    lblerror.Visible = false;
                    DialogResult confirmSave = MessageBox.Show("Are you want to SAVE User " + txtid.Text + "?..", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmSave == DialogResult.Yes)
                    {
                        if (rbMale.Checked == true) { gender = "M"; }
                        else if (rbFemale.Checked == true) { gender = "F"; }
                        else if (rbNotSpecified.Checked == true) { gender = "N"; }
                        DateTime DOB = Convert.ToDateTime(dtpDOB.Text);
                        DateTime HiredDate = Convert.ToDateTime(dtpHiredDate.Text);
                        String saveUser = "INSERT INTO Management VALUES(@ID, @Fname, @Lname, @gender, @DOB, @ConNo, @email, @HiredDate);";
                        con.Open();
                        cmd = new SqlCommand(saveUser, con);
                        cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = txtid.Text;
                        cmd.Parameters.Add("@Fname", SqlDbType.VarChar, 30).Value = txtFname.Text;
                        cmd.Parameters.Add("@Lname", SqlDbType.VarChar, 30).Value = txtLname.Text;
                        cmd.Parameters.Add("@gender", SqlDbType.Char, 1).Value = gender;
                        cmd.Parameters.Add("@ConNo", SqlDbType.VarChar, 10).Value = txtcon.Text;
                        cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = DOB;
                        cmd.Parameters.Add("@HiredDate", SqlDbType.Date).Value = HiredDate;
                        cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = txtemail.Text;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        getNextManID();
                        MessageBox.Show("User ID : " + txtid.Text + " SAVED Successfully..!", "Successfully Saved!..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
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
                if (!String.IsNullOrEmpty(txtFname.Text) && !String.IsNullOrEmpty(txtLname.Text) && (rbFemale.Checked || rbMale.Checked || rbNotSpecified.Checked) && conNo.IsMatch(txtcon.Text) && Email.IsMatch(txtemail.Text))
                {
                    DialogResult confirmUpdate = MessageBox.Show("Are you want to UPDATE User " + txtid.Text + "?..", "Confirm Update..!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmUpdate == DialogResult.Yes)
                    {
                        if (rbMale.Checked == true) { gender = "M"; }
                        else if (rbFemale.Checked == true) { gender = "F"; }
                        else if (rbNotSpecified.Checked == true) { gender = "N"; }
                        DateTime DOB = Convert.ToDateTime(dtpDOB.Text);
                        DateTime HiredDate = Convert.ToDateTime(dtpHiredDate.Text);
                        String updateUser = "UPDATE Management SET Fname=@Fname, Lname=@Lname, Gender=@gender, ConNo=@ConNo, DOB=@DOB, HiredDate=@HiredDate, Email=@email WHERE ManID = @ID";
                        con.Open();
                        cmd = new SqlCommand(updateUser, con);
                        cmd.Parameters.Add("@Fname", SqlDbType.VarChar, 30).Value = txtFname.Text;
                        cmd.Parameters.Add("@Lname", SqlDbType.VarChar, 30).Value = txtLname.Text;
                        cmd.Parameters.Add("@gender", SqlDbType.Char, 1).Value = gender;
                        cmd.Parameters.Add("@ConNo", SqlDbType.VarChar, 10).Value = txtcon.Text;
                        cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = DOB;
                        cmd.Parameters.Add("@HiredDate", SqlDbType.Date).Value = HiredDate;
                        cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = txtemail.Text;
                        cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = cmbManID.Text;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmbManID.SelectedIndex = 0;
                        Clear();
                        MessageBox.Show("User ID : " + txtid.Text + " UPDATE Successfully..!", "Successfully Updated!..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblerror.Visible = false;
                        Clear();
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

        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"[\w]").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"[\w]").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtcon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"[\d]").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void btnAcHome_Click(object sender, EventArgs e)
        {
            tabAccount.SelectedTab = tabPageMenu;
        }

        //Get account information

        private void getAcid()
        {
            cmbAcID.Items.Clear();
            String getAccID = "SELECT ManID FROM Account";
            con.Open();
            SqlDa = new SqlDataAdapter(getAccID, con);
            con.Close();
            DataTable AccIDTable = new DataTable();
            SqlDa.Fill(AccIDTable);
            if (AccIDTable.Rows.Count == 0)
            {
                cmbAcID.Items.Add("-NO Account STILL EXITS-");
                cmbAcID.SelectedIndex = 0;
            }
            else
            {
                cmbAcID.Items.Add("--SELECT NO--");
                cmbAcID.SelectedIndex = 0;
                foreach (DataRow row in AccIDTable.Rows)
                {
                    cmbAcID.Items.Add(row["ManID"]);
                }
            }
        }

        //create new id

        String maxManIDForAcc;
        private void getNextManIDForAcc()
        {
            String getManID = "SELECT ManID FROM Account";
            String getMaxManID = "SELECT MAX(ManID) ManID FROM Account";
            con.Open();
            SqlDa = new SqlDataAdapter(getManID, con);
            con.Close();
            DataTable ManIDTable = new DataTable();
            SqlDa.Fill(ManIDTable);
            if (ManIDTable.Rows.Count == 0)
            {
                txtAcID.Text = "MAN-0001";
            }
            else
            {
                con.Open();
                cmd = new SqlCommand(getMaxManID, con);
                SqlDataReader readManMaxID = cmd.ExecuteReader();
                while (readManMaxID.Read())
                {
                    maxManIDForAcc = readManMaxID.GetValue(0).ToString();
                }
                con.Close();
                txtAcID.Text = maxManIDForAcc.Substring(0, 4) + String.Format("{0:0000}", (int.Parse(maxManIDForAcc.Substring(4)) + 1));
            }
        }

        private void accClear()
        {
            txtusername.Text = "";
            txtpass.Text = "";
            txtusername.Focus();
        }

        private void accFill()
        {
            if (cmbAcID.SelectedIndex != 0)
            {
                String id = cmbManID.Text;
                String getman = "SELECT * FROM Account WHERE ManID=@ID";
                con.Open();
                cmd = new SqlCommand(getman, con);
                cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = cmbManID.Text;
                SqlDataReader readman = cmd.ExecuteReader();
                while (readman.Read())
                {
                    txtusername.Text = readman.GetValue(1).ToString();
                    txtpass.Text = readman.GetValue(2).ToString();
                }
                con.Close();
            }
        }

        private void btnAcAdd_Click(object sender, EventArgs e)
        {
            btnAcAdd.Visible = false;
            btnAcCh.Visible = true;
            btnAcReset.Visible = false;
            btnAcCl.Visible = true;
            btnAcUp.Visible = false;
            btnAcDel.Visible = false;
            btnAcSave.Visible = true;
            cmbAcID.Visible = false;
            txtAcID.Visible = true;
            pictureLoAdd.Visible = true;
            pictureLoUp.Visible = false;
            accClear();
            getNextManIDForAcc();
            enableInputForAcc();
        }

        private void btnAcCh_Click(object sender, EventArgs e)
        {
            btnAcAdd.Visible = true;
            btnAcCh.Visible = false;
            btnAcReset.Visible = true;
            btnAcCl.Visible = false;
            btnAcUp.Visible = true;
            btnAcDel.Visible = true;
            btnAcSave.Visible = false;
            cmbAcID.Visible = true;
            txtAcID.Visible = false;
            pictureLoAdd.Visible = false;
            pictureLoUp.Visible = true;
            getAcid();
            accClear();
            blockInputForAcc();
        }

        private void enableInputForAcc()
        {
            txtusername.Enabled = true;
            txtpass.Enabled = true;
            btnAcDel.Enabled = true;
            btnAcReset.Enabled = true;
            btnAcUp.Enabled = true;
        }

        private void blockInputForAcc()
        {
            txtusername.Enabled = false;
            txtpass.Enabled = false;
            btnAcDel.Enabled = false;
            btnAcReset.Enabled = false;
            btnAcUp.Enabled = false;
        }

        private void cmbAcID_SelectedIndexChanged(object sender, EventArgs e)
        {
            accFill();
            if (cmbAcID.SelectedIndex == 0) { Clear(); blockInputForAcc(); }
            else
            {
                enableInputForAcc();
            }
        }

        //Password requires at least 1 lower case character, 1 upper case character, 
        //1 number, 1 special character and must be at least 8 characters and at most 20

        Regex pass = new Regex(@"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[\W_]).{8,20})");

        private void btnAcSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtusername.Text) && pass.IsMatch(txtpass.Text))
                {
                    lblerror.Visible = false;
                    DialogResult confirmSave = MessageBox.Show("Are you want to SAVE Account " + txtAcID.Text + "?..", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmSave == DialogResult.Yes)
                    {
                        String saveAcc = "INSERT INTO Accounts VALUES(@ID, @User, @Pass);";
                        con.Open();
                        cmd = new SqlCommand(saveAcc, con);
                        cmd.Parameters.Add("@User", SqlDbType.VarChar, 20).Value = txtusername.Text;
                        cmd.Parameters.Add("@Pass", SqlDbType.VarChar, 20).Value = txtpass.Text;
                        cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = txtAcID.Text;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        getNextManID();
                        MessageBox.Show("User ID : " + txtAcID.Text + " SAVED Successfully..!", "Successfully Saved!..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        accClear();
                    }
                }

                else
                {
                    lblAcError.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Saving Data..!" + Environment.NewLine + ex);
            }
        }

        private void btnAcUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtusername.Text) && pass.IsMatch(txtpass.Text))
                {
                    DialogResult confirmUpdate = MessageBox.Show("Are you want to UPDATE Account " + cmbAcID.Text + "?..", "Confirm Update..!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmUpdate == DialogResult.Yes)
                    {
                        String updateAcc = "UPDATE Account SET Username=@Username, Password=@Pass WHERE ManID = @ManID";
                        con.Open();
                        cmd = new SqlCommand(updateAcc, con);
                        cmd.Parameters.Add("@User", SqlDbType.VarChar, 20).Value = txtusername.Text;
                        cmd.Parameters.Add("@Pass", SqlDbType.VarChar, 20).Value = txtpass.Text;
                        cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = cmbAcID.Text;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmbAcID.SelectedIndex = 0;
                        Clear();
                        MessageBox.Show("User ID : " + cmbAcID.Text + " UPDATE Successfully..!", "Successfully Updated!..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblerror.Visible = false;
                        accClear();
                    }
                }
                else
                {
                    lblAcError.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Updating Data..!" + Environment.NewLine + ex);
            }
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"[\w\d\_]").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"[\w\W\d]").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
