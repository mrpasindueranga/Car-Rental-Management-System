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
    public partial class employee : Form
    {
        public employee()
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
            String getempid = "SELECT EmpID FROM Employee";
            con.Open();
            SqlDa = new SqlDataAdapter(getempid, con);
            DataTable empidTable = new DataTable();
            SqlDa.Fill(empidTable);
            con.Close();
            if (empidTable.Rows.Count == 0)
            {
                cmbid.Items.Add("-NO EMPLOYEE STILL EXITS-");
                cmbid.SelectedIndex = 0;
            }
            else
            {
                cmbid.Items.Add("--SELECT ID--");
                cmbid.SelectedIndex = 0;
                foreach (DataRow row in empidTable.Rows)
                {
                    cmbid.Items.Add(row["EmpID"]);
                }
            }
        }

        //Create new id

        String maxID;
        private void getNextEmpID()
        {
            String getEmpID = "SELECT EmpID FROM Employee";
            String getMaxEmpID = "SELECT MAX(EmpID) EmpID FROM Employee";
            con.Open();
            SqlDa = new SqlDataAdapter(getEmpID, con);
            con.Close();
            DataTable employeeIDTable = new DataTable();
            SqlDa.Fill(employeeIDTable);

            if (employeeIDTable.Rows.Count == 0)
            {
                txtid.Text = "CUS-0001";
            }
            else
            {
                con.Open();
                cmd = new SqlCommand(getMaxEmpID, con);
                SqlDataReader readEmployeeMaxID = cmd.ExecuteReader();
                while (readEmployeeMaxID.Read())
                {
                    maxID = readEmployeeMaxID.GetValue(0).ToString();
                }
                txtid.Text = maxID.Substring(0, 4) + String.Format("{0:0000}", (int.Parse(maxID.Substring(4)) + 1));
                con.Close();
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
            dtpDOB.Value = DateTime.Now;
            dtpHiredDate.Value = DateTime.Now;
            txtadd.Text = "";
            txtsal.Text = "";
            txtFname.Focus();
        }

        //Fill form information

        String gender;
        private void fill()
        {
            if (cmbid.SelectedIndex != 0)
            {
                String id = cmbid.Text;
                String getemploye = "SELECT * FROM Employee WHERE EmpID=@EmpID";
                con.Open();
                cmd = new SqlCommand(getemploye, con);
                cmd.Parameters.Add("@EmpID", SqlDbType.VarChar, 8).Value = cmbid.Text;
                SqlDataReader readEmployee = cmd.ExecuteReader();
                while (readEmployee.Read())
                {
                    txtFname.Text = readEmployee.GetValue(1).ToString();
                    txtLname.Text = readEmployee.GetValue(2).ToString();
                    gender = readEmployee.GetValue(3).ToString();
                    txtcon.Text = readEmployee.GetValue(4).ToString();
                    dtpDOB.Text = readEmployee.GetValue(5).ToString();
                    dtpHiredDate.Text = readEmployee.GetValue(6).ToString();
                    txtadd.Text = readEmployee.GetValue(7).ToString();
                    txtsal.Text = readEmployee.GetValue(8).ToString();
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
            btnsave.Visible = true;
            cmbid.Visible = false;
            txtid.Visible = true;
            pbadd.Visible = true;
            pbup.Visible = false;
            Clear();
            getNextEmpID();
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

        private void employee_Load(object sender, EventArgs e)
        {
            txtFname.Focus();
            getid();
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
            dtpHiredDate.Enabled = true;
            txtadd.Enabled = true;
            txtsal.Enabled = true;
            btnreset.Enabled = true;
            btnup.Enabled = true;
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
            txtadd.Enabled = false;
            txtsal.Enabled = false;
            btnreset.Enabled = false;
            btnup.Enabled = false;
        }

        private void cmbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            fill();
            if (cmbid.SelectedIndex == 0) { Clear(); blockInput(); }
            else
            {
                enableInput();
            }
        }

        //Save information

        Regex conNo = new Regex(@"0[0-9]{9,9}");
        Regex Sal = new Regex(@"^([\d+]{1,8})$|^([\d+]{1,8}\.[\d+]{2})$");

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtFname.Text) && !String.IsNullOrEmpty(txtLname.Text) && (rbFemale.Checked || rbMale.Checked || rbNotSpecified.Checked) && conNo.IsMatch(txtcon.Text) && !String.IsNullOrEmpty(txtadd.Text) && Sal.IsMatch(txtsal.Text))
                {
                    lblerror.Visible = false;
                    DialogResult confirmSave = MessageBox.Show("Are you want to SAVE Employee " + txtid.Text + "?..", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmSave == DialogResult.Yes)
                    {
                        if (rbMale.Checked == true) { gender = "M"; }
                        else if (rbFemale.Checked == true) { gender = "F"; }
                        else if (rbNotSpecified.Checked == true) { gender = "N"; }
                        DateTime DOB = Convert.ToDateTime(dtpDOB.Text);
                        DateTime HiredDate = Convert.ToDateTime(dtpHiredDate.Text);
                        Decimal Sal = Convert.ToDecimal(txtsal.Text);
                        String saveEmployee = "INSERT INTO Employee VALUES(@EmpID, @Fname, @Lname, @gender, @ConNo, @DOB, @HiredDate, @Add, @Salary,'A');";
                        con.Open();
                        cmd = new SqlCommand(saveEmployee, con);
                        cmd.Parameters.Add("@EmpID", SqlDbType.VarChar, 8).Value = txtid.Text;
                        cmd.Parameters.Add("@Fname", SqlDbType.VarChar, 30).Value = txtFname.Text;
                        cmd.Parameters.Add("@Lname", SqlDbType.VarChar, 30).Value = txtLname.Text;
                        cmd.Parameters.Add("@gender", SqlDbType.Char, 1).Value = gender;
                        cmd.Parameters.Add("@ConNo", SqlDbType.VarChar, 10).Value = txtcon.Text;
                        cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = DOB;
                        cmd.Parameters.Add("@HiredDate", SqlDbType.Date).Value = HiredDate;
                        cmd.Parameters.Add("@Add", SqlDbType.VarChar, 100).Value = txtadd.Text;
                        cmd.Parameters.Add("@Salary", SqlDbType.Decimal).Value = Sal;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        getNextEmpID();
                        MessageBox.Show("Employee ID : " + txtid.Text + " SAVED Successfully..!","Successfully Saved!..",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
                if (!String.IsNullOrEmpty(txtFname.Text) && !String.IsNullOrEmpty(txtLname.Text) && (rbFemale.Checked || rbMale.Checked || rbNotSpecified.Checked) && conNo.IsMatch(txtcon.Text) && !String.IsNullOrEmpty(txtadd.Text) && Sal.IsMatch(txtsal.Text))
                {
                    DialogResult confirmUpdate = MessageBox.Show("Are you want to UPDATE Employee " + txtid.Text + "?..", "Confirm Update..!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmUpdate == DialogResult.Yes)
                    {
                        if (rbMale.Checked == true) { gender = "M"; }
                        else if (rbFemale.Checked == true) { gender = "F"; }
                        else if (rbNotSpecified.Checked == true) { gender = "N"; }
                        DateTime DOB = Convert.ToDateTime(dtpDOB.Text);
                        DateTime HiredDate = Convert.ToDateTime(dtpHiredDate.Text);
                        Decimal Sal = Convert.ToDecimal(txtsal.Text);
                        String updateEmployee = "UPDATE Employee SET Fname=@Fname, Lname=@Lname, Gender=@gender, ConNo=@ConNo, DOB=@DOB, HiredDate=@HiredDate, Address=@Add, Salary=@Sal WHERE EmpID = @EmpID";
                        con.Open();
                        cmd = new SqlCommand(updateEmployee, con);
                        cmd.Parameters.Add("@Fname", SqlDbType.VarChar, 30).Value = txtFname.Text;
                        cmd.Parameters.Add("@Lname", SqlDbType.VarChar, 30).Value = txtLname.Text;
                        cmd.Parameters.Add("@gender", SqlDbType.Char, 1).Value = gender;
                        cmd.Parameters.Add("@ConNo", SqlDbType.VarChar, 10).Value = txtcon.Text;
                        cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = DOB;
                        cmd.Parameters.Add("@HiredDate", SqlDbType.Date).Value = HiredDate;
                        cmd.Parameters.Add("@Add", SqlDbType.VarChar, 100).Value = txtadd.Text;
                        cmd.Parameters.Add("@Sal", SqlDbType.Decimal).Value = Sal;
                        cmd.Parameters.Add("@EmpID", SqlDbType.VarChar, 8).Value = cmbid.Text;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmbid.SelectedIndex = 0;
                        Clear();
                        MessageBox.Show("Employee ID : " + txtid.Text + " UPDATE Successfully..!", "Successfully Updated!..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblerror.Visible = false;
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

        //Validation check

        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"[a-zA-Z]").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8){ e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"[a-zA-Z]").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtcon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"[\d]").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtadd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"[\w,:;]").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8 || e.KeyChar == 32) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtsal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"[\d\.]").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }
    }
}
