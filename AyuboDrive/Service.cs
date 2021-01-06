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
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }

        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2OOIK8A\SQLEXPRESS;Initial Catalog=AyuboDrive;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        //Get id information

        private void getid()
        {
            cmbrenid.Items.Clear();
            String getrenid = "SELECT RentID FROM Rent";
            con.Open();
            SqlDa = new SqlDataAdapter(getrenid, con);
            DataTable renidTable = new DataTable();
            SqlDa.Fill(renidTable);
            con.Close();
            if (renidTable.Rows.Count == 0)
            {
                cmbrenid.Items.Add("-NO RECORD STILL EXITS-");
                cmbrenid.SelectedIndex = 0;
            }
            else
            {
                cmbrenid.Items.Add("--SELECT ID--");
                cmbrenid.SelectedIndex = 0;
                foreach (DataRow row in renidTable.Rows)
                {
                    cmbrenid.Items.Add(row["RentID"]);
                }
            }

            cmbvehno.Items.Clear();
            String getVehID = "SELECT VehID FROM Vehicle";
            con.Open();
            SqlDa = new SqlDataAdapter(getVehID, con);
            con.Close();
            DataTable vehIDTable = new DataTable();
            SqlDa.Fill(vehIDTable);
            if (vehIDTable.Rows.Count == 0)
            {
                cmbvehno.Items.Add("-NO VEHICLE STILL EXITS-");
                cmbvehno.SelectedIndex = 0;
            }
            else
            {
                cmbvehno.Items.Add("--SELECT NO--");
                cmbvehno.SelectedIndex = 0;
                foreach (DataRow row in vehIDTable.Rows)
                {
                    cmbvehno.Items.Add(row["VehID"]);
                }
            }

            cmbcusid.Items.Clear();
            String getcusid = "SELECT CusID FROM Customer";
            con.Open();
            SqlDa = new SqlDataAdapter(getcusid, con);
            DataTable cusidTable = new DataTable();
            SqlDa.Fill(cusidTable);
            con.Close();
            if (cusidTable.Rows.Count == 0)
            {
                cmbcusid.Items.Add("-NO CUSTOMER STILL EXITS-");
                cmbcusid.SelectedIndex = 0;
            }
            else
            {
                cmbcusid.Items.Add("--SELECT ID--");
                cmbcusid.SelectedIndex = 0;
                foreach (DataRow row in cusidTable.Rows)
                {
                    cmbcusid.Items.Add(row["CusID"]);
                }
            }

            cmbempid.Items.Clear();
            String getempid = "SELECT EmpID FROM Employee";
            con.Open();
            SqlDa = new SqlDataAdapter(getempid, con);
            DataTable empidTable = new DataTable();
            SqlDa.Fill(empidTable);
            con.Close();
            if (empidTable.Rows.Count == 0)
            {
                cmbempid.Items.Add("-NO EMPLOYEE STILL EXITS-");
                cmbempid.SelectedIndex = 0;
            }
            else
            {
                cmbempid.Items.Add("--SELECT ID--");
                cmbempid.SelectedIndex = 0;
                foreach (DataRow row in empidTable.Rows)
                {
                    cmbempid.Items.Add(row["EmpID"]);
                }
            }
        }

        //Create new id for rent

        String maxRID;
        private void getNextRenID()
        {
            String getRenID = "SELECT RentID FROM Rent";
            String getMaxRenID = "SELECT MAX(RentID) FROM Rent";
            con.Open();
            SqlDa = new SqlDataAdapter(getRenID, con);
            con.Close();
            DataTable RentIDTable = new DataTable();
            SqlDa.Fill(RentIDTable);

            if (RentIDTable.Rows.Count == 0)
            {
                txtrenid.Text = "REN-0001";
            }
            else
            {
                con.Open();
                cmd = new SqlCommand(getMaxRenID, con);
                SqlDataReader readRenMaxID = cmd.ExecuteReader();
                while (readRenMaxID.Read())
                {
                    maxRID = readRenMaxID.GetValue(0).ToString();
                }
                con.Close();
                txtrenid.Text = maxRID.Substring(0, 4) + String.Format("{0:0000}", (int.Parse(maxRID.Substring(4)) + 1));
            }
        }

        //Clear rent form

        private void renClear()
        {
            cmbvehno.SelectedIndex = 0;
            dtprendate.Value = DateTime.Now;
            dtpretdate.Value = DateTime.Now;
            cmbwithdriver.SelectedIndex = 0;
            cmbcusid.SelectedIndex = 0;
            cmbempid.SelectedIndex = 0;
            lblvehtype.Text = "";
            lblcolor.Text = "";
            lblcus.Text = "";
            lbldriver.Text = "";
        }

        //Fill rent form information

        private void fillRen()
        {
            if (cmbrenid.SelectedIndex != 0)
            {
                String id = cmbrenid.Text;
                String getrent = "SELECT Rent.*, Vehicle.BrandName + '  ' + Vehicle.ModelName, Vehicle.Color + ' ' +  + 'Colour'   AS VehicleDetails, Customer.Fname +' '+ Customer.Lname AS CustomerName,Employee.Fname + ' ' + Employee.Lname AS EmployeeName FROM Rent JOIN Vehicle ON Rent.VehID=Vehicle.VehID JOIN Customer ON Customer.CusID=Rent.CusID JOIN Employee ON Employee.EmpID=Rent.EmpID WHERE RentID=@ID";
                con.Open();
                cmd = new SqlCommand(getrent, con);
                cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = cmbrenid.Text;
                SqlDataReader readRent = cmd.ExecuteReader();
                while (readRent.Read())
                {
                    cmbvehno.Text = readRent.GetValue(1).ToString();
                    dtprendate.Text = readRent.GetValue(2).ToString();
                    dtpretdate.Text = readRent.GetValue(3).ToString();
                    cmbwithdriver.Text = readRent.GetValue(4).ToString();
                    cmbcusid.Text = readRent.GetValue(5).ToString();
                    if (!String.IsNullOrEmpty(readRent.GetValue(6).ToString()))
                    {
                        cmbwithdriver.SelectedIndex = 1;
                        cmbempid.Text = readRent.GetValue(6).ToString();
                    }
                    else
                    {
                        cmbwithdriver.SelectedIndex = 0;
                    }
                    lblvehtype.Text = readRent.GetValue(7).ToString();
                    lblcolor.Text = readRent.GetValue(8).ToString();
                    lblcus.Text = readRent.GetValue(9).ToString();
                    lbldriver.Text = readRent.GetValue(10).ToString();
                }
                con.Close();
            }
        }

        private void available()
        {
            cmbvehno.Items.Clear();
            String getVehID = "SELECT VehID FROM Vehicle WHERE Availability='A'";
            con.Open();
            SqlDa = new SqlDataAdapter(getVehID, con);
            con.Close();
            DataTable vehIDTable = new DataTable();
            SqlDa.Fill(vehIDTable);
            if (vehIDTable.Rows.Count == 0)
            {
                cmbvehno.Items.Add("-NO VEHICLE STILL EXITS-");
                cmbvehno.SelectedIndex = 0;
            }
            else
            {
                cmbvehno.Items.Add("--SELECT NO--");
                cmbvehno.SelectedIndex = 0;
                foreach (DataRow row in vehIDTable.Rows)
                {
                    cmbvehno.Items.Add(row["VehID"]);
                }
            }

            cmbempid.Items.Clear();
            String getempid = "SELECT EmpID FROM Employee WHERE Status='A'";
            con.Open();
            SqlDa = new SqlDataAdapter(getempid, con);
            DataTable empidTable = new DataTable();
            SqlDa.Fill(empidTable);
            con.Close();
            if (empidTable.Rows.Count == 0)
            {
                cmbempid.Items.Add("-NO EMPLOYEE STILL EXITS-");
                cmbempid.SelectedIndex = 0;
            }
            else
            {
                cmbempid.Items.Add("--SELECT ID--");
                cmbempid.SelectedIndex = 0;
                foreach (DataRow row in empidTable.Rows)
                {
                    cmbempid.Items.Add(row["EmpID"]);
                }
            }
        }

        private void blockInputRen()
        {
            cmbvehno.Enabled = false;
            dtprendate.Enabled = false;
            dtpretdate.Enabled = false;
            cmbwithdriver.Enabled = false;
            cmbcusid.Enabled = false;
            cmbempid.Enabled = false;
            btnrenreset.Enabled = false;
        }

        private void enableInputRen()
        {
            cmbvehno.Enabled = true;
            dtprendate.Enabled = true;
            dtpretdate.Enabled = true;
            cmbwithdriver.Enabled = true;
            cmbcusid.Enabled = true;
            cmbempid.Enabled = true;
            btnrenreset.Enabled = true;
        }

        private void btnrenadd_Click(object sender, EventArgs e)
        {
            btnrenadd.Visible = false;
            btnrench.Visible = true;
            cmbrenid.Visible = false;
            txtrenid.Visible = true;
            enableInputRen();
            btnrenreset.Visible = false;
            btnrensave.Visible = true;
            btnrencl.Visible = true;
            available();
            getNextRenID();
            renClear();
        }

        private void btnrench_Click(object sender, EventArgs e)
        {
            btnrenadd.Visible = true;
            btnrench.Visible = false;
            cmbrenid.Visible = true;
            txtrenid.Visible = false;
            blockInputRen();
            btnrenreset.Visible = true;
            btnrensave.Visible = false;
            btnrencl.Visible = false;
            cmbrenid.SelectedIndex = 0;
            getid();
        }

        private void pictureRent_Click(object sender, EventArgs e)
        {
            tabControlService.SelectedTab = tabPageRent;
            getid();
            cmbrenid.Focus();
            blockInputRen();
        }

        private void cmbrenid_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillRen();
            if (cmbrenid.SelectedIndex == 0)
            {
                renClear();
                blockInputRen();
            }
            else
            {
                enableInputRen();
            }
        }

        private void btnrensave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirmSave = MessageBox.Show("Are you want to SAVE Rent Details " + txtrenid.Text + "?..", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmSave == DialogResult.Yes)
                {
                    String saveRent = "INSERT INTO Rent VALUES(@ID, @VehID, @RenDate, @RetDate, @WithDriver, @CusID, @EmpID)";
                    con.Open();
                    cmd = new SqlCommand(saveRent, con);
                    cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = txtrenid.Text;
                    cmd.Parameters.Add("@VehID", SqlDbType.VarChar, 8).Value = cmbvehno.Text;
                    cmd.Parameters.Add("@RenDate", SqlDbType.Date).Value = dtprendate.Text;
                    cmd.Parameters.Add("@RetDate", SqlDbType.Date).Value = dtpretdate.Text;
                    cmd.Parameters.Add("@WithDriver", SqlDbType.VarChar, 5).Value = cmbwithdriver.Text;
                    cmd.Parameters.Add("@CusID", SqlDbType.VarChar, 8).Value = cmbcusid.Text;
                    if (cmbwithdriver.Text.Equals("True"))
                    {
                        cmd.Parameters.Add("@EmpID", SqlDbType.VarChar, 8).Value = cmbempid.Text;
                    }
                    else
                    {
                        cmd.Parameters.Add("@EmpID", SqlDbType.VarChar, 8).Value = DBNull.Value;
                    }
                    cmd.ExecuteNonQuery();
                    con.Close();
                    String UpdateUVeh = "UPDATE Vehicle SET Availability='U' WHERE VehID=@ID";
                    con.Open();
                    cmd = new SqlCommand(UpdateUVeh, con);
                    cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = cmbvehno.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    String UpdateUEmp = "UPDATE Employee SET Status='U' WHERE EmpID=@ID";
                    con.Open();
                    cmd = new SqlCommand(UpdateUEmp, con);
                    cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = cmbempid.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    renClear();
                    available();
                    getNextRenID();
                    MessageBox.Show("Rent ID : " + txtrenid.Text + " SAVED Successfully..!", "Successfully Saved!..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Saving Data..!" + Environment.NewLine + ex);
            }
        }

        private void cmbvehno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtrenid.Visible == true && cmbvehno.SelectedIndex != 0)
            {
                String getVehDT = "SELECT Vehicle.BrandName + '  ' + Vehicle.ModelName, Vehicle.Color + ' ' +  + 'Colour' FROM Vehicle WHERE VehID=@ID";
                con.Open();
                cmd = new SqlCommand(getVehDT, con);
                cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = cmbvehno.Text;
                SqlDataReader readvehdt = cmd.ExecuteReader();
                while (readvehdt.Read())
                {
                    lblvehtype.Text = readvehdt.GetValue(0).ToString();
                    lblcolor.Text = readvehdt.GetValue(1).ToString();
                }
                con.Close();
            }
        }

        private void cmbcusid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtrenid.Visible == true && cmbcusid.SelectedIndex != 0)
            {
                String getCusDT = "SELECT Customer.Fname +' '+ Customer.Lname FROM Customer WHERE CusID=@ID";
                con.Open();
                cmd = new SqlCommand(getCusDT, con);
                cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = cmbcusid.Text;
                SqlDataReader readcusdt = cmd.ExecuteReader();
                while (readcusdt.Read())
                {
                    lblcus.Text = readcusdt.GetValue(0).ToString();
                }
                con.Close();
            }
        }

        private void cmbempid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtrenid.Visible == true && cmbempid.SelectedIndex != 0)
            {
                String getEmpDT = "SELECT Fname +' '+ Lname FROM Employee WHERE EmpID=@ID";
                con.Open();
                cmd = new SqlCommand(getEmpDT, con);
                cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = cmbempid.Text;
                SqlDataReader readempdt = cmd.ExecuteReader();
                while (readempdt.Read())
                {
                    lbldriver.Text = readempdt.GetValue(0).ToString();
                }
                con.Close();
            }
        }

        private void btnrencl_Click(object sender, EventArgs e)
        {
            renClear();
        }

        private void btnrenreset_Click(object sender, EventArgs e)
        {
            fillRen();
        }

        private void cmbwithdriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbwithdriver.SelectedIndex == 1) { lbldriverid.Visible = true; cmbempid.Visible = true; }
            else { lbldriverid.Visible = false; cmbempid.Visible = false; }
        }

    }
}