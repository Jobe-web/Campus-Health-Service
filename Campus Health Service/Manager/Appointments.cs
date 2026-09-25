using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Campus_Health_Service.Manager
{
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            btnAppointments.BackColor = Color.Blue;
            LoadAppointmentsByDate(dtpDateSearch.Value);
            // SetupAppointmentStatusChart();

        }

        //===========================================================================================================================
        // Event handler for the "Dashboard" button click
        //===========================================================================================================================
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            Manager_DashBoard manager_DashBoard = new Manager_DashBoard();
            manager_DashBoard.Show();
            this.Hide();
        }

        //===========================================================================================================================
        // Event handler for the "Appointments" button click
        //===========================================================================================================================
        private void btnAppointments_Click(object sender, EventArgs e)
        {

        }

        //===========================================================================================================================
        // Event handler for the "Patients" button click
        //===========================================================================================================================
        private void btnPatients_Click(object sender, EventArgs e)
        {
            Patients patients = new Patients();
            patients.Show();
            this.Hide();
        }

        //===========================================================================================================================
        // Event handler for the "Reports" button click
        //===========================================================================================================================
        private void btnStaff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
            this.Hide();
        }

        //===========================================================================================================================
        // Event handler for the "Staff" button click
        //===========================================================================================================================
        private void btnReport_Click(object sender, EventArgs e)
        {
            Generate_Report Report = new Generate_Report();
            Report.Show();
            this.Hide();
        }

        //======================================================================================================================================
        //log out of the system and open login
        //===============================================================================================================================================
        private void btnLogout_Click(object sender, EventArgs e)
        {

            btnLogout.Text = "Loading...";
            btnLogout.Enabled = false;

            btnLogout.BackColor = Color.Red;

            // Reset the View Appointments button color
            btnAppointments.BackColor = Color.White;

            // Ask the user to confirm logout
            DialogResult result = MessageBox.Show(
                "Do you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Continue only if the user selects Yes
            if (result == DialogResult.Yes)
            {


                // Open the Login form
                LogIn loginForm = new LogIn();
                loginForm.Show();

                // Hide the current form
                this.Hide();
            }
            else
            {
                btnLogout.Text = "Log Out";
                btnLogout.Enabled = true;
                btnLogout.BackColor = Color.White;
                // If the user selects No, reset the button color
                btnAppointments.BackColor = Color.Blue;
            }
        }

        //================================================================================================================================================================
        //load all appointments 
        //=================================================================================================================================================================

        private void LoadAllAppointments()
        {
            try
            {
                DBConnection db = new DBConnection();

                string query = @"
            SELECT 
                a.Appointment_ID,
                a.Patient_ID,
                a.Slot_ID,
                a.Appointment_Type,
                a.Appointment_Status,
                a.Date_Created,
                s.Slot_date,
                s.Services,
                s.Start_Time,
                s.End_Time
            FROM appointments a
            INNER JOIN appointment_slots s
                ON a.Slot_ID = s.Slot_ID
            ORDER BY s.Slot_date, s.Start_Time";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        adapter.Fill(dt);

                        // Load ALL appointments into the DGV
                        dgvAppointments.DataSource = dt;

                        // Load statuses of ALL appointments into the donut
                        LoadAppointmentStatusChart(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading all appointments: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //========================================================================================================================================================
        //load appointments by date 
        //====================================================================================================================================================================
        private void LoadAppointmentsByDate(DateTime selectedDate)
        {
            try
            {
                DBConnection db = new DBConnection();

                string query = @"
            SELECT 
                a.Appointment_ID,
                a.Patient_ID,
                a.Slot_ID,
                a.Appointment_Type,
                a.Appointment_Status,
                a.Date_Created,
                s.Slot_date,
                s.Services,
                s.Start_Time,
                s.End_Time
            FROM appointments a
            INNER JOIN appointment_slots s
                ON a.Slot_ID = s.Slot_ID
            WHERE s.Slot_date = @SelectedDate
            ORDER BY s.Start_Time";

                // Use your existing DB connection here
                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@SelectedDate", selectedDate.Date);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        adapter.Fill(dt);

                        // Load appointments into DGV
                        dgvAppointments.DataSource = dt;

                        // Load the SAME appointments into the chart
                        LoadAppointmentStatusChart(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading appointments: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //=========================================================================================================================================================
        //set up the ctatus to the chart
        //====================================================================================================================================================================
        private void LoadAppointmentStatusChart(DataTable dt)
        {
            try
            {
                Series series = chartAppointmentStatus.Series["Appointment Status"];

                // Remove old chart data
                series.Points.Clear();

                // Count each appointment status
                Dictionary<string, int> statusCounts = new Dictionary<string, int>();

                foreach (DataRow row in dt.Rows)
                {
                    string status = row["Appointment_Status"].ToString();

                    if (string.IsNullOrWhiteSpace(status))
                    {
                        status = "Unknown";
                    }

                    if (statusCounts.ContainsKey(status))
                    {
                        statusCounts[status]++;
                    }
                    else
                    {
                        statusCounts.Add(status, 1);
                    }
                }

                // Add the status counts to the donut chart
                foreach (var item in statusCounts)
                {
                    int pointIndex = series.Points.AddXY(item.Key, item.Value);

                    series.Points[pointIndex].LegendText = item.Key;
                    series.Points[pointIndex].Label = item.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading appointment status chart: " + ex.Message,
                    "Chart Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dtpDateSearch_ValueChanged(object sender, EventArgs e)
        {
            LoadAppointmentsByDate(dtpDateSearch.Value);
        }

        //==================================================================================================================================================
        //load all appoint when button click
        //==========================================================================================================================================================
        private void btnShowAllAppointments_Click(object sender, EventArgs e)
        {
            LoadAllAppointments();
        }
    }
}
