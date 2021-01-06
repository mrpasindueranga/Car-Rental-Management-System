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
    public partial class pack : Form
    {
        public pack()
        {
            InitializeComponent();
        }

        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2OOIK8A\SQLEXPRESS;Initial Catalog=AyuboDrive;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        //Get package information
        private void getid()
        {
            cmbid.Items.Clear();
            String getpackid = "SELECT PackNo FROM Pack";
            con.Open();
            SqlDa = new SqlDataAdapter(getpackid, con);
            DataTable packnoTable = new DataTable();
            SqlDa.Fill(packnoTable);
            con.Close();
            if (packnoTable.Rows.Count == 0)
            {
                cmbid.Items.Add("-NO PACKAGE STILL EXITS-");
                cmbid.SelectedIndex = 0;
            }
            else
            {
                cmbid.Items.Add("--SELECT NO--");
                cmbid.SelectedIndex = 0;
                foreach (DataRow row in packnoTable.Rows)
                {
                    cmbid.Items.Add(row["PackNo"]);
                }
            }
        }

        //Create new ID form new package
        String maxID;
        private void getNextPackNo()
        {
            String getPackNo = "SELECT PackNo FROM Pack";
            String getMaxPackNo = "SELECT MAX(PackNo) FROM Pack";
            con.Open();
            SqlDa = new SqlDataAdapter(getPackNo, con);
            con.Close();
            DataTable packNoTable = new DataTable();
            SqlDa.Fill(packNoTable);
            if (packNoTable.Rows.Count == 0)
            {
                txtid.Text = "PAC-0001";
            }
            else
            {
                con.Open();
                cmd = new SqlCommand(getMaxPackNo, con);
                SqlDataReader readPackMaxNo = cmd.ExecuteReader();
                while (readPackMaxNo.Read())
                {
                    maxID = readPackMaxNo.GetValue(0).ToString();
                }
                txtid.Text = maxID.Substring(0, 4) + String.Format("{0:0000}", (int.Parse(maxID.Substring(4)) + 1));
                con.Close();
            }
        }

        //Clear data
        private void Clear()
        {
            txtname.Text = "";
            txtMaxDis.Text = "";
            cmbTourType.SelectedIndex = 0;
            dtpMaxTime.CustomFormat = "HH:mm:ss";
            dtpMaxTime.Text = "00:00:00";
            txtname.Focus();
        }


        // Search information
        String Day, Hour;

        private void fill()
        {
            if (cmbid.SelectedIndex != 0)
            {
                String id = cmbid.Text;
                String getpack = "SELECT * FROM Pack WHERE PackNo=@PackNo";
                con.Open();
                cmd = new SqlCommand(getpack, con);
                cmd.Parameters.Add("@PackNo", SqlDbType.VarChar, 8).Value = cmbid.Text;
                SqlDataReader readpackage = cmd.ExecuteReader();
                while (readpackage.Read())
                {
                    txtname.Text = readpackage.GetValue(1).ToString();
                    txtMaxDis.Text = readpackage.GetValue(2).ToString();
                    Hour = readpackage.GetValue(3).ToString();
                    Day = readpackage.GetValue(4).ToString();
                    if (Hour != "")
                    {
                        cmbTourType.SelectedIndex = 1;
                        dtpMaxTime.Text = HourLimit;
                    }
                    if (Day != "")
                    {
                        cmbTourType.SelectedIndex = 2;
                        dtpMaxDate.Text = DateTime.Now.AddDays((int.Parse(Day)-1)).ToString();

                    }
                }
                con.Close();
            }
        }

        //Fill data grid view with pacakage infomation
        private void datafill()
        {
            dgvPack.DataSource = null;
            con.Open();
            String getData = "SELECT * FROM Pack";
            cmd = new SqlCommand(getData, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable getDataTable = new DataTable();
                getDataTable.Load(reader);
                dgvPack.DataSource = getDataTable;
            }
            con.Close();
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
            cmbTourType.Enabled = true;
            Clear();
            getNextPackNo();
        }

        private void btnch_Click(object sender, EventArgs e)
        {
            enableInput();
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
            cmbid.Focus();
        }

        private void pack_Load(object sender, EventArgs e)
        {
            cmbid.Focus();
            getid();
            datafill();
        }

        private void blockInput()
        {
            txtname.Enabled = false;
            txtMaxDis.Enabled = false;
            dtpMaxTime.Enabled = false;
            cmbTourType.Enabled = false;
            btnreset.Enabled = false;
            btnup.Enabled = false;
            btndel.Enabled = false;
        }

        private void enableInput()
        {
            txtname.Enabled = true;
            txtMaxDis.Enabled = true;
            btnreset.Enabled = true;
            btnup.Enabled = true;
            btndel.Enabled = true;
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

        String savePack;
        Regex dis = new Regex(@"^([\d+]{1,6})$|^([\d+]{1,6}\.[\d+]{2})$");
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtname.Text) && !String.IsNullOrEmpty(txtMaxDis.Text) && dis.IsMatch(txtid.Text))
                {
                    lblerror.Visible = false;
                    DialogResult confirmSave = MessageBox.Show("Are you want to SAVE Package " + txtid.Text + "?..", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmSave == DialogResult.Yes)
                    {
                        Decimal maxDistance = Convert.ToDecimal(txtMaxDis.Text);
                        if (HourLimit != null)
                        {
                            savePack = "INSERT INTO Pack(PackNo, Name, kmLimit, HourLimit) VALUES(@PackNo, @Name, @MaxDistance, @HourLimit)";
                        }
                        else if (DayLimit != null)
                        {
                            savePack = "INSERT INTO Pack(PackNo, Name, kmLimit, DayLimit) VALUES(@PackNo, @Name, @MaxDistance, @DayLimit)";
                        }
                        con.Open();
                        cmd = new SqlCommand(savePack, con);
                        cmd.Parameters.Add("@PackNo", SqlDbType.VarChar, 8).Value = txtid.Text;
                        cmd.Parameters.Add("@Name", SqlDbType.VarChar, 30).Value = txtname.Text;
                        cmd.Parameters.Add("@MaxDistance", SqlDbType.Decimal).Value = maxDistance;
                        if (HourLimit != null) { cmd.Parameters.Add("@HourLimit", SqlDbType.Time).Value = HourLimit; }
                        if (DayLimit != null) { cmd.Parameters.Add("@DayLimit", SqlDbType.Int).Value = DayLimit; }
                        cmd.ExecuteNonQuery();
                        con.Close();
                        datafill();
                        Clear();
                        getNextPackNo();
                        MessageBox.Show("Pack NO : " + txtid.Text + " SAVED Successfully..!", "Successfully Saved!..", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        String updatePackage;


        //Update information
        private void btnup_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtname.Text) && dis.IsMatch(txtMaxDis.Text))
                {
                    lblerror.Visible = false;
                    DialogResult confirmUpdate = MessageBox.Show("Are you want to UPDATE Package NO" + cmbid.Text + "?..", "Confirm Update..!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmUpdate == DialogResult.Yes)
                    { 
                        Decimal maxDistance = Convert.ToDecimal(txtMaxDis.Text);
                        if (HourLimit != null)
                        {
                           updatePackage = "UPDATE Pack SET Name=@Name, kmLimit=@Maxdistance, HourLimit=@Hour WHERE PackNo=@PackName";
                        }
                        if (DayLimit != null)
                        {
                            updatePackage = "UPDATE Pack SET Name=@Name, kmLimit=@Maxdistance, DayLimit=@Day WHERE PackNo=@PackName";
                        }
                        con.Open();
                        cmd = new SqlCommand(updatePackage, con);
                        cmd.Parameters.Add("@PackNo", SqlDbType.VarChar, 8).Value = txtid.Text;
                        cmd.Parameters.Add("@Name", SqlDbType.VarChar, 30).Value = txtname.Text;
                        cmd.Parameters.Add("@MaxDistance", SqlDbType.Decimal).Value = maxDistance;
                        if (HourLimit != null)
                        {
                            cmd.Parameters.Add("@MaxTime", SqlDbType.Time).Value = HourLimit;
                        }
                        if (DayLimit != null)
                        {
                            cmd.Parameters.Add("@MaxTime", SqlDbType.Int).Value = DayLimit;
                        }
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmbid.SelectedIndex = 0;
                        Clear();
                        datafill();
                        MessageBox.Show("Package NO : " + cmbid.Text + " UPDATE Successfully..!", "Successfully Updated!..", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        int exitsPackCount;
        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                String checkPackAssign = "SELECT COUNT(PackNo) FROM AssignPack WHERE PackNo = @PackNo";
                con.Open();
                cmd = new SqlCommand(checkPackAssign, con);
                cmd.Parameters.Add("@PackNo", SqlDbType.VarChar, 8).Value = cmbid.Text;
                SqlDataReader readExitsPack = cmd.ExecuteReader();
                while (readExitsPack.Read())
                {
                    exitsPackCount = int.Parse(readExitsPack.GetValue(0).ToString());
                }
                con.Close();
                if (exitsPackCount == 0)
                {
                    DialogResult confirmDelete = MessageBox.Show("Are you want to DELETE Package NO " + cmbid.Text + "?..", "Confirm Delete..!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmDelete == DialogResult.Yes)
                    {
                        String deletePackage = "DELETE FROM Pack WHERE PackNo = @PackNo";
                        con.Open();
                        cmd = new SqlCommand(deletePackage, con);
                        cmd.Parameters.Add("@PackNo", SqlDbType.VarChar, 8).Value = cmbid.Text;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmbid.SelectedIndex = 0;
                        Clear();
                        datafill();
                        MessageBox.Show("Pack NO " + cmbid.Text + " deleted successfully!", "DELETE Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Some pacakeges still assigned to this package", "Warning...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error While Deleting Data..!" + Environment.NewLine + ex);
            }
        }

        int? DayLimit = null;
        String HourLimit = null;

        private void dtpMaxDate_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan dif = dtpMaxDate.Value - DateTime.Now;
            if (cmbTourType.SelectedIndex == 2) DayLimit = Math.Abs(dif.Days + 1);
        }

        private void dtpMaxTime_ValueChanged(object sender, EventArgs e)
        {
            if (cmbTourType.SelectedIndex == 1) HourLimit = dtpMaxTime.Text;
        }

        private void cmbTourType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTourType.SelectedIndex == 1)
            {
                dtpMaxDate.Visible = false;
                dtpMaxTime.Visible = true;
                dtpMaxTime.Enabled = true;
            }
            else if (cmbTourType.SelectedIndex == 2)
            {
                dtpMaxTime.Visible = false;
                dtpMaxDate.Visible = true;
                dtpMaxDate.Enabled = true;
            }
        }

        private void txtMaxDis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"[\d\.]").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (new Regex(@"[\w\d\s]").IsMatch(e.KeyChar.ToString()) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }
    }
}
