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
    public partial class assignPack : Form
    {
        public assignPack()
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
            String getassignid = "SELECT AssID FROM AssignPack";
            con.Open();
            SqlDa = new SqlDataAdapter(getassignid, con);
            DataTable AssignIDTable = new DataTable();
            SqlDa.Fill(AssignIDTable);
            con.Close();
            if (AssignIDTable.Rows.Count == 0)
            {
                cmbid.Items.Add("-NO ASSIGN PACK STILL EXITS-");
                cmbid.SelectedIndex = 0;
            }
            else
            {
                cmbid.Items.Add("--SELECT NO--");
                cmbid.SelectedIndex = 0;
                foreach (DataRow row in AssignIDTable.Rows)
                {
                    cmbid.Items.Add(row["AssID"]);
                }
            }

            cmbtype.Items.Clear();
            String gettypeid = "SELECT Name FROM VehicleType";
            con.Open();
            SqlDa = new SqlDataAdapter(gettypeid, con);
            DataTable vehTypeIDTable = new DataTable();
            SqlDa.Fill(vehTypeIDTable);
            con.Close();
            if (vehTypeIDTable.Rows.Count == 0)
            {
                cmbtype.Items.Add("-NO VEHICLE TYPE STILL EXITS-");
                cmbtype.SelectedIndex = 0;
            }
            else
            {
                cmbtype.Items.Add("--SELECT NO--");
                cmbtype.SelectedIndex = 0;
                foreach (DataRow row in vehTypeIDTable.Rows)
                {
                    cmbtype.Items.Add(row["Name"]);
                }
            }

            cmbpack.Items.Clear();
            String getpackid = "SELECT Name FROM Pack";
            con.Open();
            SqlDa = new SqlDataAdapter(getpackid, con);
            DataTable packnoTable = new DataTable();
            SqlDa.Fill(packnoTable);
            con.Close();
            if (packnoTable.Rows.Count == 0)
            {
                cmbpack.Items.Add("-NO PACKAGE STILL EXITS-");
                cmbpack.SelectedIndex = 0;
            }
            else
            {
                cmbpack.Items.Add("--SELECT NO--");
                cmbpack.SelectedIndex = 0;
                foreach (DataRow row in packnoTable.Rows)
                {
                    cmbpack.Items.Add(row["Name"]);
                }
            }
        }

        //Get new id

        String maxID;
        private void getNextAssNo()
        {
            String getAssID = "SELECT AssID FROM AssignPack";
            String getMaxAssNo = "SELECT MAX(AssID) PackNo FROM AssignPack";
            con.Open();
            SqlDa = new SqlDataAdapter(getAssID, con);
            con.Close();
            DataTable assIDTable = new DataTable();
            SqlDa.Fill(assIDTable);
            if (assIDTable.Rows.Count == 0)
            {
                txtid.Text = "ASS-0001";
            }
            else
            {
                con.Open();
                cmd = new SqlCommand(getMaxAssNo, con);
                SqlDataReader readAssMaxNo = cmd.ExecuteReader();
                while (readAssMaxNo.Read())
                {
                    maxID = readAssMaxNo.GetValue(0).ToString();
                }
                txtid.Text = maxID.Substring(0, 4) + String.Format("{0:0000}", (int.Parse(maxID.Substring(4)) + 1));
            }
            con.Close();
        }

        private void Clear()
        {
            txtBaseHireCharge.Text = "";
            txtExtraKM.Text = "";
            txtExtraHour.Text = "";
            txtextraday.Text = "";
            cmbpack.Focus();
        }

        private void fill()
        {
            if (cmbid.SelectedIndex != 0)
            {
                String id = cmbid.Text;
                String getassign = "SELECT AssignPack.BaseHireCharge, AssignPack.ExtraKMCharge, AssignPack.ExtraHourCharge, Pack.Name, VehicleType.Name, ExtraDayCharge FROM AssignPack JOIN Pack ON Pack.PackNo = AssignPack.PackNo JOIN VehicleType ON VehicleType.VehTypeID = AssignPack.VehTypeID WHERE AssID=@ID";
                con.Open();
                cmd = new SqlCommand(getassign, con);
                cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = cmbid.Text;
                SqlDataReader readassign = cmd.ExecuteReader();
                while (readassign.Read())
                {
                    cmbpack.Text = readassign.GetValue(3).ToString();
                    cmbtype.Text = readassign.GetValue(4).ToString();
                    txtBaseHireCharge.Text = readassign.GetValue(0).ToString();
                    txtExtraKM.Text = readassign.GetValue(1).ToString();
                    txtExtraHour.Text = readassign.GetValue(2).ToString();
                    txtextraday.Text = readassign.GetValue(5).ToString();
                }
                con.Close();
            }
        }

        private void enableInput()
        {
            cmbpack.Enabled = true;
            cmbtype.Enabled = true;
            txtBaseHireCharge.Enabled = true;
            txtExtraHour.Enabled = true;
            txtExtraKM.Enabled = true;
            btnreset.Enabled = true;
            btnup.Enabled = true;
            btndel.Enabled = true;
            txtextraday.Enabled = true;
        }

        private void blockInput()
        {
            cmbpack.Enabled = false;
            cmbtype.Enabled = false;
            txtBaseHireCharge.Enabled = false;
            txtExtraHour.Enabled = false;
            txtExtraKM.Enabled = false;
            btnreset.Enabled = false;
            btnup.Enabled = false;
            btndel.Enabled = false;
            txtextraday.Enabled = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
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
            getid();
            getNextAssNo();
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
            btndel.Visible = true;
            cmbid.Visible = true;
            txtid.Visible = false;
            pbadd.Visible = false;
            pbup.Visible = true;
            blockInput();
            getid();
            Clear();
        }

        private void assignPack_Load(object sender, EventArgs e)
        {
            cmbpack.Focus();
            getid();
        }

        private void cmbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            fill();
            if (cmbid.SelectedIndex == 0) { Clear(); blockInput(); }
            else { enableInput(); }
        }

        //Save information

        Regex baseHire = new Regex(@"^([\d+]{1,8})$|^([\d+]{1,8}\.[\d+]{2})$");
        Regex extraKM = new Regex(@"^([\d+]{1,4})$|^([\d+]{1,4}\.[\d+]{2})$");
        Regex extraHour = new Regex(@"^([\d+]{1,4})$|^([\d+]{1,4}\.[\d+]{2})$");

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbtype.SelectedIndex != 0 && cmbpack.SelectedIndex != 0 && baseHire.IsMatch(txtBaseHireCharge.Text) && extraKM.IsMatch(txtExtraKM.Text) && extraHour.IsMatch(txtExtraHour.Text))
                {
                    lblerror.Visible = false;
                    DialogResult confirmSave = MessageBox.Show("Are you want to SAVE Assign Package " + txtid.Text + "?..", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmSave == DialogResult.Yes)
                    {
                        String saveAssignPack = "INSERT INTO AssignPack VALUES(@ID, (SELECT PackNo FROM Pack WHERE Name=@PackName), (SELECT VehTypeID FROM VehicleType WHERE Name=@VehTypeName), @Base, @ExtraKM, @ExtraHour, @ExtraDayCharge)";
                        con.Open();
                        cmd = new SqlCommand(saveAssignPack, con);
                        cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = txtid.Text;
                        cmd.Parameters.Add("@PackName", SqlDbType.VarChar, 30).Value = cmbpack.Text;
                        cmd.Parameters.Add("@VehTypeName", SqlDbType.VarChar, 30).Value = cmbtype.Text;
                        cmd.Parameters.Add("@Base", SqlDbType.Decimal).Value = txtBaseHireCharge.Text;
                        cmd.Parameters.Add("@ExtraKM", SqlDbType.Decimal).Value = txtExtraKM.Text;
                        cmd.Parameters.Add("@ExtraHour", SqlDbType.Decimal).Value = txtExtraHour.Text;
                        cmd.Parameters.Add("ExtraDayCharge", SqlDbType.Decimal).Value = txtextraday.Text;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Clear();
                        getid();
                        getNextAssNo();
                        MessageBox.Show("Assign Pack NO : " + txtid.Text + " SAVED Successfully..!", "Successfully Saved!..", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            getid();
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
                if (cmbtype.SelectedIndex != 0 && cmbpack.SelectedIndex != 0 && baseHire.IsMatch(txtBaseHireCharge.Text) && extraKM.IsMatch(txtExtraKM.Text) && extraHour.IsMatch(txtExtraHour.Text) && extraHour.IsMatch(txtextraday.Text))
                {
                    lblerror.Visible = false;
                    DialogResult confirmUpdate = MessageBox.Show("Are you want to UPDATE Assign Package NO" + cmbid.Text + "?..", "Confirm Update..!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmUpdate == DialogResult.Yes)
                    {
                        Decimal Base = Convert.ToDecimal(txtBaseHireCharge.Text);
                        Decimal ExtraKM = Convert.ToDecimal(txtExtraKM.Text);
                        Decimal ExtraHour = Convert.ToDecimal(txtExtraHour.Text);
                        String updateAssignPackage = "UPDATE AssignPack SET PackNo=(SELECT PackNo FROM Pack WHERE Name=@PackName), VehTypeID=(SELECT VehTypeID FROM VehicleType WHERE Name=@VehTypeName), BaseHireCharge=@Base, ExtraKMCharge=@ExtraKM, ExtraHourCharge=@ExtraHour, ExtraDayCharge=@ExtraDayCharge WHERE AssID=@ID";
                        con.Open();
                        cmd = new SqlCommand(updateAssignPackage, con);
                        cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = cmbid.Text;
                        cmd.Parameters.Add("@PackName", SqlDbType.VarChar, 30).Value = cmbpack.Text;
                        cmd.Parameters.Add("@VehTypeName", SqlDbType.VarChar, 30).Value = cmbtype.Text;
                        cmd.Parameters.Add("@Base", SqlDbType.Decimal).Value = txtBaseHireCharge.Text;
                        cmd.Parameters.Add("@ExtraKM", SqlDbType.Decimal).Value = txtExtraKM.Text;
                        cmd.Parameters.Add("@ExtraHour", SqlDbType.Decimal).Value = txtExtraHour.Text;
                        cmd.Parameters.Add("ExtraDayCharge", SqlDbType.Decimal).Value = txtextraday.Text;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmbid.SelectedIndex = 0;
                        Clear();
                        getid();
                        MessageBox.Show("Assign Package NO : " + txtid.Text + " UPDATE Successfully..!", "Successfully Updated!..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Updating Data..!" + Environment.NewLine + ex);
            }
        }

        //Delete information

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirmDelete = MessageBox.Show("Are you want to DELETE Package NO " + cmbid.Text + "?..", "Confirm Delete..!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmDelete == DialogResult.Yes)
                {
                    String deleteAssignPackage = "DELETE FROM AssignPack WHERE AssID = @ID";
                    con.Open();
                    cmd = new SqlCommand(deleteAssignPackage, con);
                    cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = cmbid.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    cmbid.SelectedIndex = 0;
                    Clear();
                    getid();
                    MessageBox.Show("Assign Pack NO " + cmbid.Text + " deleted successfully!", "DELETE Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error While Deleting Data..!" + Environment.NewLine + ex);
            }
        }

        private void txtBaseHireCharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"[\d\.]").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtExtraKM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"[\d\.]").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtExtraHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"[\d\.]").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtextraday_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"[\d\.]").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }
    }
}

