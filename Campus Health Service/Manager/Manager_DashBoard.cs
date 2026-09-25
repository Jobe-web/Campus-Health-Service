using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campus_Health_Service.Manager
{
    public partial class Manager_DashBoard : Form
    {
        public Manager_DashBoard()
        {
            InitializeComponent();
        }
        DBConnection db = new DBConnection();
        private void Manager_DashBoard_Load(object sender, EventArgs e)
        {
            btnDashBoard.BackColor = Color.Blue;
            LoadDashboardCounts();
            LoadAppointmentChart();
            LoadAppointmentStatusChart();
        }
        //============================================================================================================================
        // load total to the panel card 
        //============================================================================================================================

        private void LoadDashboardCounts()
        {
            LoadTotalPatients();
            LoadBookedAppointments();
            LoadEmergencyCases();
            LoadFollowUps();
        }

        // ==========================================
        // TOTAL PATIENTS
        // ==========================================
        private void LoadTotalPatients()
        {
            try
            {

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM patients";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        int totalPatients = Convert.ToInt32(cmd.ExecuteScalar());

                        lblTPatients.Text = totalPatients.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading total patients: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ==========================================
        // BOOKED APPOINTMENTS
        // ==========================================
        private void LoadBookedAppointments()
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT COUNT(*)
                        FROM appointments
                        WHERE Appointment_Status = 'BOOKED'";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        int bookedAppointments =
                            Convert.ToInt32(cmd.ExecuteScalar());

                        lblTAppointments.Text =
                            bookedAppointments.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading booked appointments: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // ==========================================
        // TOTAL EMERGENCY CASES
        // ==========================================
        private void LoadEmergencyCases()
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM emergency";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        int totalEmergency =
                            Convert.ToInt32(cmd.ExecuteScalar());

                        lblEmergency.Text =
                            totalEmergency.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading emergency cases: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // ==========================================
        // TOTAL FOLLOW-UPS
        // ==========================================
        private void LoadFollowUps()
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM followup";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        int totalFollowUps =
                            Convert.ToInt32(cmd.ExecuteScalar());

                        lblFollowUp.Text =
                            totalFollowUps.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading follow-ups: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ==========================================
        // LOAD APPOINTMENT GRAPH
        // ==========================================
        private void LoadAppointmentChart()
        {
            Series serviceSeries =
                chartAppointments.Series["Appointment Types"];

            // Clear old points
            serviceSeries.Points.Clear();

            // Bar chart
            serviceSeries.ChartType = SeriesChartType.Bar;

            // Put each appointment type on its own bar
            // serviceSeries["DrawSideBySide"] = "True";

            //  serviceSeries.XValueType = ChartValueType.String;
            //  serviceSeries.YValueType = ChartValueType.Int32;

            // Show count on each bar
            serviceSeries.IsValueShownAsLabel = true;

            // Hide legend
            serviceSeries.IsVisibleInLegend = false;

            string query = @"
        SELECT 
            Appointment_Type,
            COUNT(*) AS AppointmentCount
        FROM appointments
        WHERE Appointment_Type IS NOT NULL
          AND Appointment_Type <> ''
        GROUP BY Appointment_Type
        ORDER BY AppointmentCount DESC;
    ";

            try
            {
                using (MySqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    using (MySqlCommand command =
                           new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader =
                               command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string appointmentType =
                                    reader["Appointment_Type"].ToString();

                                int appointmentCount =
                                    Convert.ToInt32(
                                        reader["AppointmentCount"]
                                    );

                                serviceSeries.Points.AddXY(
                                    appointmentType,
                                    appointmentCount
                                );


                                DataPoint point = serviceSeries.Points[
                                    serviceSeries.Points.Count - 1
                                ];

                                if (appointmentType == "Emergency")
                                {
                                    point.Color = Color.Red;
                                }
                                else if (appointmentType == "General Consultation (e.g Flu, cold, cough, fever)")
                                {
                                    point.Color = Color.Blue;
                                }
                                else if (appointmentType == "Minor Illness Treatment (e.g. Flu, Headache)")
                                {
                                    point.Color = Color.Green;
                                }
                                else if (appointmentType == "Medical Check (e.g. TB, HIV)")
                                {
                                    point.Color = Color.Purple;
                                }
                                else if (appointmentType == "Wound Care / Dressing")
                                {
                                    point.Color = Color.Orange;
                                }
                                else if (appointmentType == "Urgent")
                                {
                                    point.Color = Color.Gold;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading appointment chart:\n\n" +
                    ex.Message,
                    "Chart Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // ==========================================
        // LOAD APPOINTMENT STATUS PIE CHART
        // ==========================================
        private void LoadAppointmentStatusChart()
        {
            // ============================================================
            // GET EXISTING DESIGNER CHART AREA AND SERIES
            // ============================================================

            ChartArea chartArea =
                chartAppointmentStatus.ChartAreas["StatusArea"];

            Series statusSeries =
                chartAppointmentStatus.Series["Appointment Status"];

            // Clear old data
            statusSeries.Points.Clear();


            // ============================================================
            // PIE CHART SETTINGS
            // ============================================================

            statusSeries.ChartType = SeriesChartType.Pie;

            // Show labels
            statusSeries.IsValueShownAsLabel = true;

            // Show status names in legend
            statusSeries.IsVisibleInLegend = true;

            // Put labels inside the pie
            statusSeries["PieLabelStyle"] = "Inside";

            // Show ONLY the number inside each slice
            statusSeries["LabelStyle"] = "Inside";

            // Make the pie use more of the chart area
            statusSeries["PieDrawingStyle"] = "SoftEdge";


            // ============================================================
            // SQL QUERY
            // ============================================================

            string query = @"
        SELECT
            Appointment_Status,
            COUNT(*) AS StatusCount
        FROM appointments
        WHERE Appointment_Status IS NOT NULL
          AND Appointment_Status <> ''
        GROUP BY Appointment_Status
        ORDER BY StatusCount DESC;
    ";


            // ============================================================
            // LOAD DATA
            // ============================================================

            try
            {
                using (MySqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    using (MySqlCommand command =
                           new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader =
                               command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string status =
                                    reader["Appointment_Status"].ToString();

                                int statusCount =
                                    Convert.ToInt32(
                                        reader["StatusCount"]
                                    );


                                // ====================================================
                                // ADD PIE SLICE
                                // ====================================================

                                int pointIndex =
                                    statusSeries.Points.AddXY(
                                        status,
                                        statusCount
                                    );

                                DataPoint point =
                                    statusSeries.Points[pointIndex];


                                // ====================================================
                                // SHOW NUMBER ONLY
                                // ====================================================

                                point.Label = "#VALY";


                                // ====================================================
                                // SHOW STATUS NAME IN THE LEGEND
                                // ====================================================
                                point.LegendText = status;

                                // ====================================================
                                // DIFFERENT COLORS
                                // ====================================================

                                if (status == "COMPLETED")
                                {
                                    point.Color = Color.Green;
                                }
                                else if (status == "FOLLOW UP")
                                {
                                    point.Color = Color.Blue;
                                }
                                else if (status == "BOOKED")
                                {
                                    point.Color = Color.Orange;
                                }
                                else if (status == "CHECKED IN")
                                {
                                    point.Color = Color.Purple;
                                }
                                else if (status == "CANCELLED")
                                {
                                    point.Color = Color.Red;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading appointment status chart:\n\n" +
                    ex.Message,
                    "Chart Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        //============================================================================================================================
        private void btnDashBoard_Click(object sender, EventArgs e)
        {

        }
        //============================================================================================================================
        private void btnAppointments_Click(object sender, EventArgs e)
        {
            Appointments appointments = new Appointments();
            appointments.Show();
            this.Hide();
        }
        //============================================================================================================================
        private void btnPatients_Click(object sender, EventArgs e)
        {
            Patients patients = new Patients();
            patients.Show();
            this.Hide();
        }

        //============================================================================================================================
        private void btnStaff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
            this.Hide();
        }

        //============================================================================================================================
        private void btnReport_Click(object sender, EventArgs e)
        {
            Generate_Report report = new Generate_Report();
            report.Show();
            this.Hide();
        }
        //============================================================================================================================
        // LOGOUT BUTTON
        //============================================================================================================================

        private void btnLogout_Click(object sender, EventArgs e)
        {

            btnLogout.Text = "Loading...";
            btnLogout.Enabled = false;

            btnLogout.BackColor = Color.Red;

            // Reset the View Appointments button color
            btnDashBoard.BackColor = Color.White;

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
                btnDashBoard.BackColor = Color.Blue;
            }
        }
    }
}
