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
    public partial class adminDash : Form
    {
        public adminDash()
        {
            InitializeComponent();
        }

        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2OOIK8A\SQLEXPRESS;Initial Catalog=AyuboDrive;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();


        // Get all information from database
        private void getInfo()
        {
            String getPackInfo = "SELECT COUNT(PackNo) FROM Pack";
            con.Open();
            SqlDa = new SqlDataAdapter(getPackInfo, con);
            con.Close();
            DataTable packInfoTable = new DataTable();
            SqlDa.Fill(packInfoTable);
            if (packInfoTable.Rows.Count > 0)
            {
                lblPack.Text = packInfoTable.Rows[0][0].ToString();
            }
            else { lblPack.Text = "0"; }

            String getRenInfo = "SELECT COUNT(RentID) FROM Rent";
            con.Open();
            SqlDa = new SqlDataAdapter(getRenInfo, con);
            con.Close();
            DataTable RenInfoTable = new DataTable();
            SqlDa.Fill(RenInfoTable);
            if (RenInfoTable.Rows.Count > 0)
            {
                lblRen.Text = RenInfoTable.Rows[0][0].ToString();
            }
            else { lblRen.Text = "0"; }

            String getCusInfo = "SELECT COUNT(CusID) FROM Customer";
            con.Open();
            SqlDa = new SqlDataAdapter(getCusInfo, con);
            con.Close();
            DataTable CusInfoTable = new DataTable();
            SqlDa.Fill(CusInfoTable);
            if (CusInfoTable.Rows.Count > 0)
            {
                lblCus.Text = CusInfoTable.Rows[0][0].ToString();
            }
            else { lblCus.Text = "0"; }

            String getEmpInfo = "SELECT COUNT(EmpID) FROM Employee";
            con.Open();
            SqlDa = new SqlDataAdapter(getEmpInfo, con);
            con.Close();
            DataTable empInfoTable = new DataTable();
            SqlDa.Fill(empInfoTable);
            if (empInfoTable.Rows.Count > 0)
            {
                lblDiver.Text = empInfoTable.Rows[0][0].ToString();
            }
            else { lblDiver.Text = "0"; }

            String getVehInfo = "SELECT COUNT(VehID) FROM Vehicle";
            con.Open();
            SqlDa = new SqlDataAdapter(getVehInfo, con);
            con.Close();
            DataTable vehInfoTable = new DataTable();
            SqlDa.Fill(vehInfoTable);
            if (vehInfoTable.Rows.Count > 0)
            {
                lblVeh.Text = vehInfoTable.Rows[0][0].ToString();
            }
            else { lblVeh.Text = "0"; }

            String getPayInfo = "SELECT SUM(Amount) FROM Payment";
            con.Open();
            SqlDa = new SqlDataAdapter(getPayInfo, con);
            con.Close();
            DataTable payInfoTable = new DataTable();
            SqlDa.Fill(payInfoTable);
            if (payInfoTable.Rows.Count > 0)
            {
                lblPay.Text = payInfoTable.Rows[0][0].ToString();
            }
            else { lblPay.Text = "0"; }
        }

        //Load dash boad
        private void adminDash_Load(object sender, EventArgs e)
        {
            getInfo();
        }
    }
}
