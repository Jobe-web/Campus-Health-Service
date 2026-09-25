using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campus_Health_Service.Nurse
{
    public partial class Patient_Records : Form
    {
        public Patient_Records()
        {
            InitializeComponent();
        }

        //=====================================================================================================================================================================================
        // Form Load Event
        //=====================================================================================================================================================================================
        private void Patient_Records_Load(object sender, EventArgs e)
        {
            btnPatientRecords.BackColor = Color.Blue;
        }

        //=====================================================================================================================================================================================
        // Load Medical History
        //allows the nurse to view the medical history of a patient based on their student or staff number
        //=====================================================================================================================================================================================
        private void LoadMedicalHistory(string studentStaffNumber)
        {
            try
            {
                DBConnection dbConnection = new DBConnection();
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT
                    a.Appointment_ID AS 'Appointment ID',
                    s.Slot_date AS 'Date',
                    s.Start_Time AS 'Start Time',
                    s.End_Time AS 'End Time',
                    s.Services AS 'Service',
                    a.Appointment_Status AS 'Status'
                FROM appointments a
                INNER JOIN patients p
                    ON a.Patient_ID = p.Patient_ID
                INNER JOIN appointment_slots s
                    ON a.Slot_ID = s.Slot_ID
                WHERE p.StudentORStaff_Number = @StudentStaffNumber
                ORDER BY s.Slot_date DESC, s.Start_Time DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@StudentStaffNumber",
                            studentStaffNumber);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();

                            adapter.Fill(dt);

                            dgvMedicalH.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading medical history:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //=====================================================================================================================================================================================
        // Navigation Buttons
        //=====================================================================================================================================================================================
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            NursesOrDoctor_DashBoard nursesDashBoardForm = new NursesOrDoctor_DashBoard();
            nursesDashBoardForm.Show();
            this.Hide();
        }

        //=====================================================================================================================================================================================
        // view Appointments Button
        //=====================================================================================================================================================================================
        private void btnViewAppointments_Click(object sender, EventArgs e)
        {
            View_Appointments viewAppointmentsForm = new View_Appointments();
            viewAppointmentsForm.Show();
            this.Hide();
        }

        //=====================================================================================================================================================================================
        // Follow Up Button
        //=====================================================================================================================================================================================
        private void btnFollowUp_Click(object sender, EventArgs e)
        {
            Follow_Up followUpForm = new Follow_Up();
            followUpForm.Show();
            this.Hide();
        }

        //=====================================================================================================================================================================================
        // Logout Button
        //=====================================================================================================================================================================================
        private void btnLogout_Click(object sender, EventArgs e)
        {

            btnLogout.Text = "Loading...";
            btnLogout.Enabled = false;

            btnLogout.BackColor = Color.Red;

            // Reset the View Appointments button color
            btnPatientRecords.BackColor = Color.White;

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
                btnPatientRecords.BackColor = Color.Blue;
            }
        }

        //=====================================================================================================================================================================================
        // Search Button
        //=====================================================================================================================================================================================
        private void button1_Click(object sender, EventArgs e)
        {

            string studentStaffNumber = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(studentStaffNumber))
            {
                MessageBox.Show(
                    "Please enter a student or staff number.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSearch.Focus();
                return;
            }

            try
            {
                DBConnection dbConnection = new DBConnection(); 
                using (MySqlConnection conn = dbConnection.GetConnection())
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
                WHERE StudentORStaff_Number = @StudentStaffNumber";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@StudentStaffNumber",
                            studentStaffNumber);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtName.Text = reader["Full_Name"].ToString();
                                txtStudentStaffNumber.Text =
                                    reader["StudentORStaff_Number"].ToString();
                                txtPhoneNumber.Text =
                                    reader["Contact_Number"].ToString();
                                txtEmail.Text =
                                    reader["Email"].ToString();

                                LoadMedicalHistory(studentStaffNumber);
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Patient not found.",
                                    "Search Result",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                txtName.Clear();
                                txtStudentStaffNumber.Clear();
                                txtPhoneNumber.Clear();
                                txtEmail.Clear();

                                txtSearch.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error searching for patient:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
