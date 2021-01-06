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
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }

        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2OOIK8A\SQLEXPRESS;Initial Catalog=AyuboDrive;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        //Fill data

        private void datafill()
        {
            dgvLogs.DataSource = null;
            con.Open();
            DateTime From = Convert.ToDateTime(dtpFrom.Text);
            DateTime To = Convert.ToDateTime(dtpTo.Text); 
            String getData = "SELECT Date, Management.Fname+' '+Management.Lname AS Name, LoginTime, LogoutTime FROM Log JOIN Management ON Log.ManID = Management.ManID WHERE Date BETWEEN @from AND @to";
            cmd = new SqlCommand(getData, con);
            cmd.Parameters.Add("@from", SqlDbType.Date).Value = From;
            cmd.Parameters.Add("@to", SqlDbType.Date).Value = To;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable getDataTable = new DataTable();
                getDataTable.Load(reader);
                dgvLogs.DataSource = getDataTable;
            }
            con.Close();
        }

        //Load data

        private void log_Load(object sender, EventArgs e)
        {
            dtpFrom.Text = "2020/09/01";
            datafill();
        }

        //Filter data

        private void btnFilter_Click(object sender, EventArgs e)
        {
            datafill();
        }
    }
}
