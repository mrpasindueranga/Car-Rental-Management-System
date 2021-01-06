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
    public partial class vehicleType : Form
    {
        public vehicleType()
        {
            InitializeComponent();
        }

        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2OOIK8A\SQLEXPRESS;Initial Catalog=AyuboDrive;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        // Get vehicle id information
        private void getid()
        {
            cmbid.Items.Clear();
            String gettypeid = "SELECT VehTypeID FROM VehicleType";
            con.Open();
            SqlDa = new SqlDataAdapter(gettypeid, con);
            con.Close();
            DataTable vehTypeIDTable = new DataTable();
            SqlDa.Fill(vehTypeIDTable);
            if (vehTypeIDTable.Rows.Count == 0)
            {
                cmbid.Items.Add("-NO VEHICLE TYPE STILL EXITS-");
                cmbid.SelectedIndex = 0;
            }
            else
            {
                cmbid.Items.Add("--SELECT NO--");
                cmbid.SelectedIndex = 0;
                foreach (DataRow row in vehTypeIDTable.Rows)
                {
                    cmbid.Items.Add(row["VehTypeID"]);
                }
            }
        }

        private void getVehID()
        {
            cmbVehID.Items.Clear();
            String getVehID = "SELECT VehID FROM Vehicle";
            con.Open();
            SqlDa = new SqlDataAdapter(getVehID, con);
            con.Close();
            DataTable vehIDTable = new DataTable();
            SqlDa.Fill(vehIDTable);
            if(vehIDTable.Rows.Count == 0)
            {
                cmbVehID.Items.Add("-NO VEHICLE STILL EXITS-");
                cmbVehID.SelectedIndex = 0;
            }
            else
            {
                cmbVehID.Items.Add("--SELECT NO--");
                cmbVehID.SelectedIndex = 0;
                foreach (DataRow row in vehIDTable.Rows)
                {
                    cmbVehID.Items.Add(row["VehID"]);
                }
            }
        }

        private void getVehTypeName()
        {
            cmbTypeName.Items.Clear();
            String getVehTypeName = "SELECT VehTypeID, Name FROM VehicleType";
            con.Open();
            SqlDa = new SqlDataAdapter(getVehTypeName, con);
            con.Close();
            DataTable vehTypeNameTable = new DataTable();
            SqlDa.Fill(vehTypeNameTable);
            if (vehTypeNameTable.Rows.Count == 0)
            {
                cmbTypeName.Items.Clear();
                cmbTypeName.Items.Add("-NO VEHICLE STILL EXITS -");
                cmbTypeName.SelectedIndex = 0;
            }
            else
            {
                cmbTypeName.Items.Add("--SELECT NAME--");
                cmbTypeName.SelectedIndex = 0;
                foreach (DataRow row in vehTypeNameTable.Rows)
                {
                    cmbTypeName.Items.Add(row["Name"]);
                }
            }
        }

        //Create new id

        String maxTypeID;
        private void getNextVehTypeID()
        {
            String getVehTypeID = "SELECT VehTypeID FROM VehicleType";
            String getMaxVehTypeID = "SELECT MAX(VehTypeID) PackNo FROM VehicleType";
            con.Open();
            SqlDa = new SqlDataAdapter(getVehTypeID, con);
            con.Close();
            DataTable VehTypeIDTable = new DataTable();
            SqlDa.Fill(VehTypeIDTable);
            if (VehTypeIDTable.Rows.Count == 0)
            {
                txtid.Text = "TYP-0001";
            }
            else
            {
                con.Open();
                cmd = new SqlCommand(getMaxVehTypeID, con);
                SqlDataReader readVehTypeMaxID = cmd.ExecuteReader();
                while (readVehTypeMaxID.Read())
                {
                    maxTypeID = readVehTypeMaxID.GetValue(0).ToString();
                }
                con.Close();
                txtid.Text = maxTypeID.Substring(0, 4) + String.Format("{0:0000}", (int.Parse(maxTypeID.Substring(4)) + 1));
            }
        }

        String maxVehID;

        private void getNextVehID()
        {
            String getVehID = "SELECT VehID FROM Vehicle";
            String getMaxVehID = "SELECT MAX(VehID) PackNo FROM Vehicle";
            con.Open();
            SqlDa = new SqlDataAdapter(getVehID, con);
            con.Close();
            DataTable vehIDTable = new DataTable();
            SqlDa.Fill(vehIDTable);
            if (vehIDTable.Rows.Count == 0)
            {
                txtVehID.Text = "VEH-0001";
            }
            else
            {
                con.Open();
                cmd = new SqlCommand(getMaxVehID, con);
                SqlDataReader readVehMaxID = cmd.ExecuteReader();
                while(readVehMaxID.Read())
                {
                    maxVehID = readVehMaxID.GetValue(0).ToString();
                }
                con.Close();
                txtVehID.Text = maxVehID.Substring(0, 4) + String.Format("{0:0000}", (int.Parse(maxVehID.Substring(4)) + 1));
            }
        }

        //Clear form

        private void Clear()
        {
            txtname.Text = "";
            txtPerDay.Text = "";
            txtPerWeek.Text = "";
            txtPerMonth.Text = "";
            txtNightPark.Text = "";
            txtDailyDriver.Text = "";
            txtname.Focus();
        }

        private void VehClear()
        {
            cmbTypeName.SelectedIndex = 0;
            txtBrand.Text = "";
            txtModel.Text = "";
            txtColor.Text = "";
            txtCost.Text = "";
            dtpHiredDate.Text = DateTime.Now.ToString();
            txtRegNumber.Text = "";
        }

        //Fill form according to the given id

        private void fill()
        {
            if (cmbid.SelectedIndex != 0)
            {
                String id = cmbid.Text;
                String gettype = "SELECT * FROM VehicleType WHERE VehTypeID=@ID";
                con.Open();
                cmd = new SqlCommand(gettype, con);
                cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = cmbid.Text;
                SqlDataReader readtype = cmd.ExecuteReader();
                while (readtype.Read())
                {
                    txtname.Text = readtype.GetValue(1).ToString();
                    txtPerDay.Text = readtype.GetValue(2).ToString();
                    txtPerWeek.Text = readtype.GetValue(3).ToString();
                    txtPerMonth.Text = readtype.GetValue(4).ToString();
                    txtNightPark.Text = readtype.GetValue(5).ToString();
                    txtDailyDriver.Text = readtype.GetValue(6).ToString();
                }
                con.Close();
            }
        }

        private void VehFill()
        {
            if (cmbVehID.SelectedIndex != 0)
            {
                String id = cmbVehID.Text;
                String getveh = "SELECT Vehicle.BrandName, Vehicle.ModelName, Vehicle.Color, Vehicle.Cost, Vehicle.HiredDate, Vehicle.RegNo, VehicleType.Name FROM Vehicle JOIN VehicleType ON Vehicle.VehTypeID = VehicleType.VehTypeID Where VehID=@ID";
                con.Open();
                cmd = new SqlCommand(getveh, con);
                cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = cmbVehID.Text;
                SqlDataReader readVeh = cmd.ExecuteReader();
                while(readVeh.Read())
                {
                    txtBrand.Text = readVeh.GetValue(0).ToString();
                    txtModel.Text = readVeh.GetValue(1).ToString();
                    txtColor.Text = readVeh.GetValue(2).ToString();
                    txtCost.Text = readVeh.GetValue(3).ToString();
                    dtpHiredDate.Text = readVeh.GetValue(4).ToString();
                    txtRegNumber.Text = readVeh.GetValue(5).ToString();
                    cmbTypeName.Text = readVeh.GetValue(6).ToString();
                }
                con.Close();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            enableInput();
            btnadd.Visible = false;
            btnch.Visible = true;
            btnreset.Visible = false;
            btncl.Visible = true;
            btnup.Visible = false;
            btnsave.Visible = true;
            btndel.Visible = false;
            cmbid.Visible = false;
            txtid.Visible = true;
            pbadd.Visible = true;
            pbup.Visible = false;
            Clear();
            getNextVehTypeID();
        }

        private void btnVehAdd_Click(object sender, EventArgs e)
        {
            btnVehAdd.Visible = false;
            btnVehCh.Visible = true;
            btnVehReset.Visible = false;
            btnVehUp.Visible = false;
            btnVehDel.Visible = false;
            btnVehCl.Visible = true;
            btnVehSave.Visible = true;
            cmbVehID.Visible = false;
            txtVehID.Visible = true;
            pictureVehAdd.Visible = true;
            pictureVehUp.Visible = false;
            getVehID();
            VehClear();
            enableInputVeh();
            getNextVehID();
        }

        private void btnch_Click(object sender, EventArgs e)
        {
            btnadd.Visible = true;
            btnch.Visible = false;
            btnreset.Visible = true;
            btncl.Visible = false;
            btnup.Visible = true;
            btnsave.Visible = false;
            btndel.Visible = true;
            cmbid.Visible = true;
            txtid.Visible = false;
            pbadd.Visible = false;
            pbup.Visible = true;
            getid();
            Clear();
        }

        private void btnVehCh_Click(object sender, EventArgs e)
        {
            btnVehAdd.Visible = true;
            btnVehCh.Visible = false;
            btnVehReset.Visible = true;
            btnVehUp.Visible = true;
            btnVehDel.Visible = true;
            btnVehCl.Visible = false;
            btnVehSave.Visible = false;
            cmbVehID.Visible = true;
            txtVehID.Visible = false;
            pictureVehAdd.Visible = false;
            pictureVehUp.Visible = true;
            getVehID();
            VehClear();
            blockInputVeh();
        }


        // Fill chart
        private void fillDataToChart()
        {
            String getDataForChart = "SELECT VehicleType.Name, COUNT(Vehicle.VehTypeID) FROM VehicleType JOIN Vehicle ON VehicleType.VehTypeID = Vehicle.VehTypeID GROUP BY VehicleType.Name";
            con.Open();
            SqlDa = new SqlDataAdapter(getDataForChart, con);
            con.Close();
            DataTable chartTable = new DataTable();
            SqlDa.Fill(chartTable);
            chartVehicle.Series["VT1"].Points.Clear();
            if (chartTable.Rows.Count > 0)
            {
                for (int row = 0; row < chartTable.Rows.Count; row++)
                {
                    chartVehicle.Series["VT1"].Points.AddXY(chartTable.Rows[row][0].ToString() + Environment.NewLine + chartTable.Rows[row][1].ToString(), chartTable.Rows[row][1]);
                }
            }
        }
        private void vehicleType_Load(object sender, EventArgs e)
        {
            cmbVehID.Focus();
            getVehID();
            getVehTypeName();
            fillDataToChart();
        }

        private void blockInput()
        {
            txtname.Enabled = false;
            txtPerDay.Enabled = false;
            txtPerWeek.Enabled = false;
            txtPerMonth.Enabled = false;
            txtNightPark.Enabled = false;
            txtDailyDriver.Enabled = false;
            btnreset.Enabled = false;
            btnup.Enabled = false;
            btndel.Enabled = false;
        }

        private void blockInputVeh()
        {
            cmbTypeName.Enabled = false;
            txtBrand.Enabled = false;
            txtModel.Enabled = false;
            txtColor.Enabled = false;
            txtCost.Enabled = false;
            dtpHiredDate.Enabled = false;
            txtRegNumber.Enabled = false;
            btnVehReset.Enabled = false;
            btnVehUp.Enabled = false;
            btnVehDel.Enabled = false;
        }

        private void enableInput()
        {
            txtname.Enabled = true;
            txtPerDay.Enabled = true;
            txtPerWeek.Enabled = true;
            txtPerMonth.Enabled = true;
            txtNightPark.Enabled = true;
            txtDailyDriver.Enabled = true;
            btnreset.Enabled = true;
            btnup.Enabled = true;
            btndel.Enabled = true;
        }

        private void enableInputVeh()
        {
            cmbTypeName.Enabled = true;
            txtBrand.Enabled = true;
            txtModel.Enabled = true;
            txtColor.Enabled = true;
            txtCost.Enabled = true;
            dtpHiredDate.Enabled = true;
            txtRegNumber.Enabled = true;
            btnVehReset.Enabled = true;
            btnVehUp.Enabled = true;
            btnVehDel.Enabled = true;
        }

        private void cmbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            fill();
            if (cmbid.SelectedIndex == 0) { Clear(); blockInput(); }
            else { enableInput(); }
        }

        private void cmbVehID_SelectedIndexChanged(object sender, EventArgs e)
        {
            VehFill();
            if (cmbVehID.SelectedIndex == 0) { VehClear(); blockInputVeh(); }
            else { enableInputVeh(); }
        }

        // Save information

        Regex PerDayPat = new Regex(@"^([\d+]{1,5})$|^([\d+]{1,5}\.[\d+]{2})$");
        Regex PerWeekPat = new Regex(@"^([\d+]{1,6})$|^([\d+]{1,6}\.[\d+]{2})$");
        Regex PerMonPat = new Regex(@"^([\d+]{1,8})$|^([\d+]{1,8}\.[\d+]{2})$");
        Regex NightParkCostPat = new Regex(@"^([\d+]{1,4})$|^([\d+]{1,4}\.[\d+]{2})$");
        Regex DriverCostPat = new Regex(@"^([\d+]{1,5})$|^([\d+]{1,5}\.[\d+]{2})$");
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtname.Text) && PerDayPat.IsMatch(txtDailyDriver.Text) && PerWeekPat.IsMatch(txtPerWeek.Text) && PerMonPat.IsMatch(txtPerMonth.Text) && NightParkCostPat.IsMatch(txtNightPark.Text) && DriverCostPat.IsMatch(txtDailyDriver.Text))
                {
                    lblerror.Visible = false;
                    DialogResult confirmSave = MessageBox.Show("Are you want to SAVE Vehicle Type NO " + txtid.Text + "?..", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmSave == DialogResult.Yes)
                    {
                        Double PerDay = Double.Parse(txtPerDay.Text);
                        Double PerWeek = Double.Parse(txtPerWeek.Text);
                        Double PerMon = Double.Parse(txtPerMonth.Text);
                        Double NightParkCost = Double.Parse(txtNightPark.Text);
                        Double DriverCost = Double.Parse(txtDailyDriver.Text);
                        String saveVehicleType = "INSERT INTO VehicleType VALUES(@ID, @Name, @PerDay, @PerWeek, @PerMonth, @NightParkCost, @DriverCost)";
                        con.Open();
                        cmd = new SqlCommand(saveVehicleType, con);
                        cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = txtid.Text;
                        cmd.Parameters.Add("@Name", SqlDbType.VarChar, 30).Value = txtname.Text;
                        cmd.Parameters.Add("@PerDay", SqlDbType.Decimal).Value = PerDay;
                        cmd.Parameters.Add("@PerWeek", SqlDbType.Decimal).Value = PerWeek;
                        cmd.Parameters.Add("@PerMonth", SqlDbType.Decimal).Value = PerMon;
                        cmd.Parameters.Add("@NightParkCost", SqlDbType.Decimal).Value = NightParkCost;
                        cmd.Parameters.Add("@DriverCost", SqlDbType.Decimal).Value = DriverCost;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Clear();
                        getNextVehTypeID();
                        MessageBox.Show("Vehicle Type NO : " + txtid.Text + " SAVED Successfully..!", "Successfully Saved!..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getVehTypeName();
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

        Regex Cost = new Regex(@"^([\d+]{1,14})$|^([\d+]{1,14}\.[\d+]{2})$");
        Regex RegNo = new Regex(@"^[A-Z]{1,3}-[0-9]{4}$");

        String VehTypeID;
        private void btnVehSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtBrand.Text) && !String.IsNullOrEmpty(txtModel.Text) && !String.IsNullOrEmpty(txtColor.Text) && Cost.IsMatch(txtCost.Text) && RegNo.IsMatch(txtRegNumber.Text))
                {
                    lblVehError.Visible = false;
                    DialogResult confirmSave = MessageBox.Show("Are you want to SAVE Vehicle NO " + txtVehID.Text + "?..", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmSave == DialogResult.Yes)
                    {
                        String getVehTypeID = "SELECT VehTypeID FROM VehicleType WHERE Name=@Name";
                        con.Open();
                        cmd = new SqlCommand(getVehTypeID, con);
                        cmd.Parameters.Add("@Name", SqlDbType.VarChar, 30).Value = cmbTypeName.Text;
                        SqlDataReader readTypeID = cmd.ExecuteReader();
                        while (readTypeID.Read())
                        {
                            VehTypeID = readTypeID.GetValue(0).ToString();
                        }
                        con.Close();

                        Double cost = Double.Parse(txtCost.Text);
                        String saveVehicle = "INSERT INTO Vehicle VALUES(@ID, @VehTypeID, @Brand, @Model, @Color, @Cost, @HiredDate, @RegNo, @Availability)";
                        con.Open();
                        cmd = new SqlCommand(saveVehicle, con);
                        cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = txtVehID.Text;
                        cmd.Parameters.Add("@VehTypeID", SqlDbType.VarChar, 8).Value = VehTypeID;
                        cmd.Parameters.Add("@Brand", SqlDbType.VarChar, 30).Value = txtBrand.Text;
                        cmd.Parameters.Add("@Model", SqlDbType.VarChar, 30).Value = txtModel.Text;
                        cmd.Parameters.Add("@Color", SqlDbType.VarChar, 30).Value = txtColor.Text;
                        cmd.Parameters.Add("@Cost", SqlDbType.Decimal).Value = txtCost.Text;
                        cmd.Parameters.Add("@HiredDate", SqlDbType.Date).Value = dtpHiredDate.Text;
                        cmd.Parameters.Add("@RegNo", SqlDbType.VarChar, 8).Value = txtRegNumber.Text;
                        cmd.Parameters.Add("@Availability", SqlDbType.Char, 1).Value = 'A';
                        cmd.ExecuteNonQuery();
                        con.Close();
                        VehClear();
                        getNextVehID();
                        MessageBox.Show("Vehicle NO : " + txtVehID.Text + " SAVED Successfully..!", "Successfully Saved!..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    lblVehError.Visible = true;
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

        private void btnVehCl_Click(object sender, EventArgs e)
        {
            VehClear();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            fill();
        }

        private void btnVehReset_Click(object sender, EventArgs e)
        {
            VehFill();
        }


        //Update information
        private void btnup_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtname.Text) && PerDayPat.IsMatch(txtDailyDriver.Text) && PerWeekPat.IsMatch(txtPerWeek.Text) && PerMonPat.IsMatch(txtPerMonth.Text) && NightParkCostPat.IsMatch(txtNightPark.Text) && DriverCostPat.IsMatch(txtDailyDriver.Text))
                {
                    lblerror.Visible = false;
                    DialogResult confirmUpdate = MessageBox.Show("Are you want to UPDATE Vehicle Type NO" + txtid.Text + "?..", "Confirm Update..!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmUpdate == DialogResult.Yes)
                    {
                        Double PerDay = Double.Parse(txtPerDay.Text);
                        Double PerWeek = Double.Parse(txtPerWeek.Text);
                        Double PerMon = Double.Parse(txtPerMonth.Text);
                        Double NightParkCost = Double.Parse(txtNightPark.Text);
                        Double DriverCost = Double.Parse(txtDailyDriver.Text);
                        String updateVehicleID = "UPDATE VehicleType SET Name=@Name, PerDay=@PerDay, PerWeek=@PerWeek, PerMonth=@PerMonth, NightParkCost=@NightParkCost, DriverCost=@DriverCost WHERE VehTypeID=@ID";
                        con.Open();
                        cmd = new SqlCommand(updateVehicleID, con);
                        cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = cmbid.Text;
                        cmd.Parameters.Add("@Name", SqlDbType.VarChar, 30).Value = txtname.Text;
                        cmd.Parameters.Add("@PerDay", SqlDbType.Decimal).Value = PerDay;
                        cmd.Parameters.Add("@PerWeek", SqlDbType.Decimal).Value = PerWeek;
                        cmd.Parameters.Add("@PerMonth", SqlDbType.Decimal).Value = PerMon;
                        cmd.Parameters.Add("@NightParkCost", SqlDbType.Decimal).Value = NightParkCost;
                        cmd.Parameters.Add("@DriverCost", SqlDbType.Decimal).Value = DriverCost;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmbid.SelectedIndex = 0;
                        Clear();
                        MessageBox.Show("Vehicle Type NO : " + txtid.Text + " UPDATE Successfully..!", "Successfully Updated!..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getVehTypeName();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Updating Data..!" + Environment.NewLine + ex);
            }
        }

        private void btnVehUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtBrand.Text) && !String.IsNullOrEmpty(txtModel.Text) && !String.IsNullOrEmpty(txtColor.Text) && Cost.IsMatch(txtCost.Text) && RegNo.IsMatch(txtRegNumber.Text))
                {
                    lblVehError.Visible = false;
                    DialogResult confirmUpdate = MessageBox.Show("Are you want to UPDATE Vehicle NO" + txtVehID.Text + "?..", "Confirm Update..!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmUpdate == DialogResult.Yes)
                    {
                        Double cost = Double.Parse(txtCost.Text);
                        String updateVehicle = "UPDATE Vehicle SET BrandName=@Brand, ModelName=@Model, Color=@Color, Cost=@Cost, HiredDate=@HiredDate, RegNo=@RegNo WHERE VehID=@ID";
                        con.Open();
                        cmd = new SqlCommand(updateVehicle, con);
                        cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = cmbVehID.Text;
                        cmd.Parameters.Add("@Brand", SqlDbType.VarChar, 30).Value = txtBrand.Text;
                        cmd.Parameters.Add("@Model", SqlDbType.VarChar, 30).Value = txtModel.Text;
                        cmd.Parameters.Add("@Color", SqlDbType.VarChar, 30).Value = txtColor.Text;
                        cmd.Parameters.Add("@Cost", SqlDbType.Decimal).Value = txtCost.Text;
                        cmd.Parameters.Add("@HiredDate", SqlDbType.Date).Value = dtpHiredDate.Text;
                        cmd.Parameters.Add("@RegNo", SqlDbType.VarChar, 8).Value = txtRegNumber.Text;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmbVehID.SelectedIndex = 0;
                        VehClear();
                        MessageBox.Show("Vehicle NO : " + txtVehID.Text + " UPDATE Successfully..!", "Successfully Updated!..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Updating Data..!" + Environment.NewLine + ex);
            }
        }

        int exitsVehCount;

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                String checkVehicleExits = "SELECT COUNT(VehTypeID) FROM Vehicle WHERE VehTypeID=@TypeID";
                con.Open();
                cmd = new SqlCommand(checkVehicleExits, con);
                cmd.Parameters.Add("@TypeID", SqlDbType.VarChar, 8).Value = cmbid.Text;
                SqlDataReader readExitsVeh = cmd.ExecuteReader();
                while (readExitsVeh.Read())
                {
                    exitsVehCount = int.Parse(readExitsVeh.GetValue(0).ToString());
                }
                con.Close();
                if (exitsVehCount==0)
                {
                    DialogResult confirmDelete = MessageBox.Show("Are you want to DELETE Vehicle Type NO " + cmbid.Text + "?..", "Confirm Delete..!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmDelete == DialogResult.Yes)
                    {
                        String deleteVehicleType = "DELETE FROM VehicleType WHERE VehTypeID = @ID";
                        con.Open();
                        cmd = new SqlCommand(deleteVehicleType, con);
                        cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = cmbid.Text;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmbid.SelectedIndex = 0;
                        Clear();
                        MessageBox.Show("Vehicle Type NO " + cmbid.Text + " deleted successfully!", "DELETE Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getid();
                    }
                }
                else
                {
                    MessageBox.Show("Vehicle still exits under this type", "Warning...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error While Deleting Data..!" + Environment.NewLine + ex);
                getVehTypeName();
            }
        }

        private void btnVehDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirmDelete = MessageBox.Show("Are you want to DELETE Vehicle NO " + cmbVehID.Text + "?..", "Confirm Delete..!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmDelete == DialogResult.Yes)
                {
                    String deleteVehicle = "DELETE FROM Vehicle WHERE VehID=@ID";
                    con.Open();
                    cmd = new SqlCommand(deleteVehicle, con);
                    cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = cmbVehID.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    cmbVehID.SelectedIndex = 0;
                    VehClear();
                    MessageBox.Show("Vehicle NO " + cmbVehID.Text + " deleted successfully!", "DELETE Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getVehID();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Deleting Data..!" + Environment.NewLine + ex);
            }
        }

        Regex money = new Regex(@"[\d\.]");

        private void txtPerDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (money.IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8){ e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtPerWeek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(money.IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else{ e.Handled = true; }
        }

        private void txtPerMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (money.IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtNightPark_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (money.IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtDailyDriver_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (money.IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        Regex text = new Regex(@"[\w\s]");
        private void txtBrand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (text.IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (text.IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (text.IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"[\d\.]").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtRegNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"[A-Z\d\-]").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void pictureVeh_Click(object sender, EventArgs e)
        {
            tabVehicle.SelectedTab = tabVehicleReg;
        }

        private void pictureType_Click(object sender, EventArgs e)
        {
            cmbid.Focus();
            getid();
            tabVehicle.SelectedTab = tabVehType;
        }

        private void btnVehHome_Click(object sender, EventArgs e)
        {
            tabVehicle.SelectedTab = tabMenu;
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            tabVehicle.SelectedTab = tabMenu;
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            fillDataToChart();
        }
    }
}
