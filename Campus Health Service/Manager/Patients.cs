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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            btnPatients.BackColor = Color.Blue;
            cmbPatient.SelectedIndexChanged -= cmbPatient_SelectedIndexChanged;

            LoadPatients();

            cmbPatient.SelectedIndexChanged += cmbPatient_SelectedIndexChanged;
        }

        //============================================================================================================================
        //open dashboard form
        //=============================================================================================================================
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            Manager_DashBoard manager = new Manager_DashBoard();
            manager.Show();
            this.Hide();
        }

        //====================================================================================================================================
        //open Appoinetments
        //===============================================================================================================
        private void btnAppointments_Click(object sender, EventArgs e)
        {
            Appointments appointments = new Appointments();
            appointments.Show();
            this.Hide();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Generate_Report report = new Generate_Report();
            report.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnLogout.Text = "Loading...";
            btnLogout.Enabled = false;

            btnLogout.BackColor = Color.Red;

            // Reset the View Appointments button color
            btnPatients.BackColor = Color.White;

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
                btnPatients.BackColor = Color.Blue;
            }
        }
        //=======================================================================================================================================
        //load patients to comboBox 
        //====================================================================================================================================================
        private void LoadPatients()
        {
            try
            {
                DBConnection db = new DBConnection();

                string query = @"
            SELECT 
                Patient_ID,
                StudentORStaff_Number,
                Full_Name
            FROM patients
            ORDER BY Full_Name";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    cmbPatient.DataSource = dt;
                    cmbPatient.DisplayMember = "Full_Name";
                    cmbPatient.ValueMember = "Patient_ID";
                    cmbPatient.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading patients:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //====================================================================================================================================
        //load patients info to texts
        //====================================================================================================================================================

        private void LoadPatientInformation(int patientID)
        {
            try
            {
                DBConnection db = new DBConnection();

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT
                    Patient_ID,
                    StudentORStaff_Number,
                    Full_Name,
                    Contact_Number,
                    Email
                FROM patients
                WHERE Patient_ID = @Patient_ID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Patient_ID", patientID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtName.Text = reader["Full_Name"].ToString();
                                txtStudentStaffNumber.Text = reader["StudentORStaff_Number"].ToString();
                                txtEmail.Text = reader["Email"].ToString();
                                txtPhoneNumber.Text = reader["Contact_Number"].ToString();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Patient was not found.",
                                    "Patient",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                    }
                }

                LoadAppointmentCount(patientID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading patient information:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //============================================================================================================================
        //Load the count for appointment each patient had
        //===============================================================================================================================

        private void LoadAppointmentCount(int patientID)
        {
            try
            {
                DBConnection db = new DBConnection();

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT COUNT(*)
                FROM appointments
                WHERE Patient_ID = @Patient_ID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Patient_ID", patientID);

                        object result = cmd.ExecuteScalar();

                        txtAppointments.Text = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading appointment count:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        //========================================================================================================================================
        //Load appointment types into the Bar Chart
        //================================================================================================================================================

        private void LoadPatientAppointmentTypes(int patientID)
        {
            try
            {
                DBConnection db = new DBConnection();

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT
                    Appointment_Type,
                    COUNT(*) AS AppointmentCount
                FROM appointments
                WHERE Patient_ID = @Patient_ID
                GROUP BY Appointment_Type
                ORDER BY AppointmentCount DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Patient_ID", patientID);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                        DataTable dt = new DataTable();

                        adapter.Fill(dt);

                        Series series =
                            chartAppointmentTypes.Series["Appointment Types"];

                        series.Points.Clear();

                        foreach (DataRow row in dt.Rows)
                        {
                            string appointmentType =
                                row["Appointment_Type"].ToString();

                            int count =
                                Convert.ToInt32(row["AppointmentCount"]);

                            int pointIndex =
                                series.Points.AddXY(
                                    appointmentType,
                                    count);

                            // Show number on the bar
                            series.Points[pointIndex].Label =
                                count.ToString();

                            // Set different color for each appointment type
                            if (appointmentType.Equals("Emergency",
                                StringComparison.OrdinalIgnoreCase))
                            {
                                series.Points[pointIndex].Color = Color.Red;
                            }
                            else if (appointmentType.Equals("Medical",
                                StringComparison.OrdinalIgnoreCase))
                            {
                                series.Points[pointIndex].Color = Color.Blue;
                            }
                            else if (appointmentType.Equals("Health",
                                StringComparison.OrdinalIgnoreCase))
                            {
                                series.Points[pointIndex].Color = Color.Green;
                            }
                            else if (appointmentType.Equals("Follow-up",
                                StringComparison.OrdinalIgnoreCase))
                            {
                                series.Points[pointIndex].Color = Color.Orange;
                            }
                            else
                            {
                                // Color for any other appointment type
                                series.Points[pointIndex].Color = Color.Gray;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading appointment chart:\n\n" + ex.Message,
                    "Chart Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //====================================================================================================================================
        //load patients that is selected in the comboBox
        //====================================================================================================================================================
        private void cmbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedIndex == -1)
                return;

            if (cmbPatient.SelectedItem == null)
                return;

            DataRowView row = cmbPatient.SelectedItem as DataRowView;

            if (row == null)
                return;

            int patientID = Convert.ToInt32(row["Patient_ID"]);

            LoadPatientInformation(patientID);
            LoadPatientAppointmentTypes(patientID);
        }
    }
}
