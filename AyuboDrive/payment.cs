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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2OOIK8A\SQLEXPRESS;Initial Catalog=AyuboDrive;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        List<string> RenIDs = new List<string>();
        List<string> HireIDs = new List<string>();
        List<string> CusNames = new List<string>();
        List<string> EmpNames = new List<string>();
        List<string> VehNames = new List<string>();
        List<string> Days = new List<string>();
        List<double> tot = new List<double>();
        List<string> EmpIDs = new List<string>();
        List<string> VehIDs = new List<string>();

        //Rent Payment

        private void getInfo()
        {
            String getInfo = "SELECT RentID, Customer.Fname+' '+Customer.Lname, Employee.Fname+' '+Employee.Lname, Vehicle.BrandName+' '+Vehicle.ModelName, RentedDate, ReturnDate, PerDay, PerWeek, PerMonth, DriverCost, WithDriver, Rent.EmpID, Rent.VehID  FROM Rent JOIN Customer ON Customer.CusID = Rent.CusID JOIN Employee ON Employee.EmpID = Rent.EmpID JOIN Vehicle ON Vehicle.VehID = Rent.VehID JOIN VehicleType ON Vehicle.VehTypeID=VehicleType.VehTypeID WHERE Rent.RentID NOT IN(SELECT RentID FROM Payment)";
            con.Open();
            SqlDa = new SqlDataAdapter(getInfo, con);
            con.Close();
            DataTable infoTable = new DataTable();
            SqlDa.Fill(infoTable);
            if (infoTable.Rows.Count > 0)
            {
                int Days;
                foreach (DataRow row in infoTable.Rows)
                {
                    RenIDs.Add(row[0].ToString());
                    CusNames.Add(row[1].ToString());
                    EmpNames.Add(row[2].ToString());
                    VehNames.Add(row[3].ToString());
                    EmpIDs.Add(row[11].ToString());
                    VehIDs.Add(row[12].ToString());
                    DateTime ren = DateTime.Parse(row[4].ToString());
                    DateTime ret = DateTime.Parse(row[5].ToString());
                    TimeSpan dif = ret - ren;
                    Days = int.Parse(dif.TotalDays.ToString()) + 1;
                    rent(Days);
                    Double total = ((Double.Parse(row[6].ToString()) * dayC) + (Double.Parse(row[7].ToString()) * weeks) + (Double.Parse(row[8].ToString()) * months));
                    if ((row[10].ToString()) == "True")
                    {
                        tot.Add(total + Double.Parse(row[9].ToString()));
                    }
                    else
                    {
                        tot.Add(total);
                    }
                }
            }
        }

        //Rent calculate function
        int months, weeks, dayC;
        private List<string> rent(int days)
        {
            months = days / 30;
            days = days % 30;
            weeks = days / 7;
            days = days % 7;
            dayC = days;
            String rent = String.Format("Months : {0} Weeks : {1} Days : {2}", months, weeks, days);
            Days.Add(rent);
            return Days;
        }

        GroupBox addGroup(int i, int groupCoord)
        {
            GroupBox group = new GroupBox();
            group.Name = "groupBox" + i.ToString();
            group.Text = "Rent ID : " + RenIDs[i];
            group.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            group.Width = 550;
            group.TabStop = false;
            group.Height = 160;
            group.TabIndex = i;
            group.Location = new Point(3, groupCoord);
            group.Margin = new Padding(7);
            return group;
        }

        Label CusName(int i)
        {
            Label cusName = new Label();
            cusName.Name = "cusName" + i.ToString();
            cusName.Text = "Customer Name : " + CusNames[i];
            cusName.Location = new Point(12, 30);
            cusName.AutoSize = true;
            return cusName;
        }

        Label EmpName(int i)
        {
            Label empName = new Label();
            empName.Name = "empName" + i.ToString();
            empName.Text = "Employee Name : " + EmpNames[i];
            empName.Location = new Point(12, 70);
            empName.AutoSize = true;
            return empName;
        }

        Label VehName(int i)
        {
            Label vehName = new Label();
            vehName.Name = "vehName" + i.ToString();
            vehName.Text = "Vehicle Name : " + VehNames[i];
            vehName.Location = new Point(12, 120);
            vehName.AutoSize = true;
            return vehName;
        }

        Label Duration(int i)
        {
            Label duration = new Label();
            duration.Name = "duration" + i.ToString();
            duration.Text = "Duration : " + Days[i];
            duration.Location = new Point(285, 30);
            duration.AutoSize = true;
            return duration;
        }

        Button Pay(int i)
        {
            Button pay = new Button();
            pay.Name = "pay" + i.ToString();
            pay.Text = "PAY";
            pay.Location = new Point(450, 120);
            pay.AutoSize = true;
            pay.BackColor = Color.FromName("MediumSeaGreen");
            pay.ForeColor = Color.FromName("White");
            pay.FlatStyle = FlatStyle.Flat;
            return pay;
        }

        private void getCard()
        {
            panelRenLoad.Controls.Clear();
            RenIDs.Clear();
            CusNames.Clear();
            EmpNames.Clear();
            VehNames.Clear();
            Days.Clear();
            EmpIDs.Clear();
            VehIDs.Clear();
            tot.Clear();
            getInfo();
            int groupCoord = 3;
            for (int i = 0; i < RenIDs.Count; i++)
            {
                GroupBox group = addGroup(i, groupCoord);
                Label cusName = CusName(i);
                Label empName = EmpName(i);
                Label vehName = VehName(i);
                Label duration = Duration(i);
                Button pay = Pay(i);
                panelRenLoad.Controls.Add(group);
                group.Controls.Add(cusName);
                group.Controls.Add(empName);
                group.Controls.Add(vehName);
                group.Controls.Add(duration);
                group.Controls.Add(pay);
                pay.Click += new System.EventHandler(pay_Click);
                groupCoord += 160;
            }
        }



        private void pictureRent_Click(object sender, EventArgs e)
        {
            tabControlPay.SelectedTab = tabPageRenPay;
            getCard();
        }

        void pay_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            getNextPayID();
            try
            {
                int index = int.Parse(currentButton.Name.Substring(currentButton.Name.Length - 1));
                DialogResult confirmSave = MessageBox.Show("Are you want to PAY Rent Details " + RenIDs[index] + "?..", "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmSave == DialogResult.Yes)
                {
                    String saveRent = "INSERT INTO Payment(PayID, RentID, Amount, PayDate) VALUES(@ID, @RentID, @Amount, @PayDate)";
                    con.Open();
                    cmd = new SqlCommand(saveRent, con);
                    cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = maxPID;
                    cmd.Parameters.Add("@RentID", SqlDbType.VarChar, 8).Value = RenIDs[index];
                    cmd.Parameters.Add("@Amount", SqlDbType.Decimal).Value = tot[index];
                    cmd.Parameters.Add("@PayDate", SqlDbType.Date).Value = DateTime.Now;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    String UpdateUVeh = "UPDATE Vehicle SET Availability='A' WHERE VehID=@ID";
                    con.Open();
                    cmd = new SqlCommand(UpdateUVeh, con);
                    cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = VehIDs[index];
                    cmd.ExecuteNonQuery();
                    con.Close();
                    String UpdateUEmp = "UPDATE Employee SET Status='A' WHERE EmpID=@ID";
                    con.Open();
                    cmd = new SqlCommand(UpdateUEmp, con);
                    cmd.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = EmpIDs[index];
                    cmd.ExecuteNonQuery();
                    con.Close();
                    getCard();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Saving Data" + Environment.NewLine + ex);
            }
        }

        private void payment_Load(object sender, EventArgs e)
        {
            getCard();
        }

        private void pictureRent_Click_1(object sender, EventArgs e)
        {
            tabControlPay.SelectedTab = tabPageRenPay;
        }

        private void pictureHire_Click(object sender, EventArgs e)
        {
            tabControlPay.SelectedTab = tabPageHire;
        }

        String maxPID;
        private String getNextPayID()
        {
            String getPayID = "SELECT PayID FROM Payment";
            String getMaxPayID = "SELECT MAX(PayID) FROM Payment";
            con.Open();
            SqlDa = new SqlDataAdapter(getPayID, con);
            con.Close();
            DataTable PayIDTable = new DataTable();
            SqlDa.Fill(PayIDTable);

            if (PayIDTable.Rows.Count == 0)
            {
                maxPID = "PAY-0001";
            }
            else
            {
                con.Open();
                cmd = new SqlCommand(getMaxPayID, con);
                SqlDataReader readPayMaxID = cmd.ExecuteReader();
                while (readPayMaxID.Read())
                {
                    maxPID = readPayMaxID.GetValue(0).ToString();
                }
                con.Close();
                maxPID = maxPID.Substring(0, 4) + String.Format("{0:0000}", (int.Parse(maxPID.Substring(4)) + 1));
            }

            return maxPID;
        }

        //Hire function
    }
}
