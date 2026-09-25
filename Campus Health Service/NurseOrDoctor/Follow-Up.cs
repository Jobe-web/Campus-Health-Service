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
    public partial class Follow_Up : Form
    {

        private int selectedAppointmentID = 0;

        // List to store all follow-up times
        private List<string> allFollowUpTimes = new List<string>();
        private HashSet<string> bookedFollowUpTimes = new HashSet<string>();
        public Follow_Up()
        {
            InitializeComponent();

            cmbPatients.SelectedIndexChanged += cmbPatients_SelectedIndexChanged;
        }

        private void Follow_Up_Load(object sender, EventArgs e)
        {

            // Store the times that you already added in the Designer
            allFollowUpTimes.Clear();

            foreach (var item in cmbFollowUpTime.Items)
            {
                allFollowUpTimes.Add(item.ToString());
            }

            // Check booked times for the selected date
            CheckBookedFollowUpTimes();

            btnFollowUp.BackColor = Color.Blue;
            LoadPatients();
        }

        //========================= Navigation Buttons ==============================================================================================================
        //===========================================================================================================================================================================
        private void btnViewAppointments_Click(object sender, EventArgs e)
        {
            View_Appointments viewAppointmentsForm = new View_Appointments();
            viewAppointmentsForm.Show();
            this.Hide();
        }

        //===========================================================================================================================================================================
        //navigation button to go to the nurse dashboard form
        //===========================================================================================================================================================================
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            NursesOrDoctor_DashBoard nursesDashBoardForm = new NursesOrDoctor_DashBoard();
            nursesDashBoardForm.Show();
            this.Hide();
        }

        //===========================================================================================================================================================================
        //navigation button to go to the patient records form
        //===========================================================================================================================================================================
        private void btnPatientRecords_Click(object sender, EventArgs e)
        {
            Patient_Records patientRecordsForm = new Patient_Records();
            patientRecordsForm.Show();
            this.Hide();
        }

        //===========================================================================================================================================================================
        //navigation button to go to the logout form
        //===========================================================================================================================================================================
        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnLogout.Text = "Loading...";
            btnLogout.Enabled = false;

            btnLogout.BackColor = Color.Red;

            // Reset the View Appointments button color
            btnFollowUp.BackColor = Color.White;

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
                btnFollowUp.BackColor = Color.Blue;
            }
        }

        //===========================================================================================================================================================================
        //load patients into the combo box from the database
        //===========================================================================================================================================================================
        private void LoadPatients()
        {
            try
            {
                DBConnection dbConnection = new DBConnection();

                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT
                    a.Appointment_ID,
                    p.Patient_ID,
                    p.Full_Name
                FROM appointments a
                INNER JOIN patients p
                    ON a.Patient_ID = p.Patient_ID
                WHERE UPPER(TRIM(a.Appointment_Status)) = 'CHECKED IN'
                ORDER BY p.Full_Name";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbPatients.Items.Clear();

                        while (reader.Read())
                        {
                            cmbPatients.Items.Add(new PatientItem
                            {
                                PatientID = Convert.ToInt32(
                                    reader["Patient_ID"]),

                                AppointmentID = Convert.ToInt32(
                                    reader["Appointment_ID"]),

                                FullName = reader["Full_Name"].ToString()
                            });
                        }
                    }
                }

                cmbPatients.SelectedIndex = -1;
                cmbPatients.Text = "Select Patient";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading checked-in patients: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private class PatientItem
        {
            public int PatientID { get; set; }

            public int AppointmentID { get; set; }

            public string FullName { get; set; }

            public override string ToString()
            {
                return FullName;
            }
        }

        //===========================================================================================================================================================================
        //load the selected patient's details into the text boxes
        //===========================================================================================================================================================================
        private void LoadPatientDetails(int patientID)
        {
            try
            {
                DBConnection dbConnection = new DBConnection();
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    Full_Name,
                    StudentORStaff_Number,
                    Contact_Number,
                    Email
                FROM patients
                WHERE Patient_ID = @PatientID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", patientID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtName.Text =
                                    reader["Full_Name"].ToString();

                                txtStudentStaffNumber.Text =
                                    reader["StudentORStaff_Number"].ToString();

                                txtPhoneNumber.Text =
                                    reader["Contact_Number"].ToString();

                                txtEmail.Text =
                                    reader["Email"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading patient details: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //===========================================================================================================================================================================
        //when a patient is selected from the combo box, load their details into the text boxes
        //===========================================================================================================================================================================
        private void cmbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbPatients.SelectedItem == null)
                return;

            PatientItem selectedPatient =
                (PatientItem)cmbPatients.SelectedItem;

            // Get the exact CHECKED IN appointment
            selectedAppointmentID = selectedPatient.AppointmentID;

            // Load patient information
            LoadPatientDetails(selectedPatient.PatientID);
        }

        //===========================================================================================================================================================================
        //when the follow-up date is changed, load the available follow-up times for that date
        //===========================================================================================================================================================================
        private void dtpFollowUpDate_ValueChanged(object sender, EventArgs e)
        {
            CheckBookedFollowUpTimes();
        }

        //===========================================================================================================================================================================
        //check the database for booked follow-up times for the selected date and update the ComboBox accordingly
        //===========================================================================================================================================================================
        private void CheckBookedFollowUpTimes()
        {
            try
            {
                DateTime selectedDate = dtpFollowUpDate.Value.Date;

                // Clear previous booked times
                bookedFollowUpTimes.Clear();

                DBConnection dbConnection = new DBConnection();
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    s.Start_Time,
                    s.End_Time
                FROM appointment_slots s
                INNER JOIN appointments a
                    ON s.Slot_ID = a.Slot_ID
                WHERE s.Slot_date = @SelectedDate
                AND a.Appointment_Status <> 'CANCELLED'";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@SelectedDate",
                            selectedDate);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TimeSpan bookedStart =
                                    (TimeSpan)reader["Start_Time"];

                                TimeSpan bookedEnd =
                                    (TimeSpan)reader["End_Time"];

                                // Compare database booking with
                                // every time in the ComboBox
                                foreach (string timeRange in allFollowUpTimes)
                                {
                                    string[] parts =
                                        timeRange.Split('-');

                                    if (parts.Length != 2)
                                        continue;

                                    TimeSpan comboStart =
                                        TimeSpan.Parse(parts[0].Trim());

                                    TimeSpan comboEnd =
                                        TimeSpan.Parse(parts[1].Trim());

                                    // Check whether the times overlap
                                    bool overlaps =
                                        comboStart < bookedEnd &&
                                        comboEnd > bookedStart;

                                    if (overlaps)
                                    {
                                        bookedFollowUpTimes.Add(timeRange);
                                    }
                                }
                            }
                        }
                    }
                }

                UpdateFollowUpTimeComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error checking booked times:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //===========================================================================================================================================================================
        // Update the ComboBox to show which times are booked
        //===========================================================================================================================================================================
        private void UpdateFollowUpTimeComboBox()
        {
            cmbFollowUpTime.Items.Clear();

            foreach (string time in allFollowUpTimes)
            {
                if (bookedFollowUpTimes.Contains(time))
                {
                    cmbFollowUpTime.Items.Add(
                        time + " (BOOKED)");
                }
                else
                {
                    cmbFollowUpTime.Items.Add(time);
                }
            }

            cmbFollowUpTime.SelectedIndex = -1;
            cmbFollowUpTime.Text = "Select Time";
        }

        private void cmbFollowUpTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFollowUpTime.SelectedIndex == -1)
                return;

            string selectedTime =
                cmbFollowUpTime.SelectedItem.ToString();

            if (selectedTime.EndsWith("(BOOKED)"))
            {
                MessageBox.Show(
                    "This time is already booked. Please select another time.",
                    "Time Not Available",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbFollowUpTime.SelectedIndex = -1;
                cmbFollowUpTime.Text = "Select Time";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Check that a checked-in appointment was selected
            if (selectedAppointmentID == 0)
            {
                MessageBox.Show(
                    "Please select a checked-in patient.",
                    "No Patient Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbPatients.Focus();
                return;
            }

            // Check follow-up date
            if (dtpFollowUpDate.Value.Date < DateTime.Today)
            {
                MessageBox.Show(
                    "Follow-up date cannot be in the past.",
                    "Invalid Date",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                dtpFollowUpDate.Focus();
                return;
            }

            // Check follow-up time
            if (cmbFollowUpTime.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a follow-up time.",
                    "Missing Time",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbFollowUpTime.Focus();
                return;
            }

            // Check note
            if (string.IsNullOrWhiteSpace(txtNote.Text))
            {
                MessageBox.Show(
                    "Please enter follow-up notes or instructions.",
                    "Missing Note",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNote.Focus();
                return;
            }

            try
            {
                DBConnection dbConnection = new DBConnection();

                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();

                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // =====================================================
                            // 1. SAVE FOLLOW-UP
                            // =====================================================

                            string followUpQuery = @"
                        INSERT INTO followup
                        (
                            Appointment_ID,
                            Followup_Date,
                            Note_Instructions,
                            Recorded_By
                        )
                        VALUES
                        (
                            @AppointmentID,
                            @FollowupDate,
                            @NoteInstructions,
                            @RecordedBy
                        )";

                            using (MySqlCommand cmd =
                                new MySqlCommand(
                                    followUpQuery,
                                    conn,
                                    transaction))
                            {
                                cmd.Parameters.AddWithValue(
                                    "@AppointmentID",
                                    selectedAppointmentID);

                                cmd.Parameters.AddWithValue(
                                    "@FollowupDate",
                                    dtpFollowUpDate.Value.Date);

                                cmd.Parameters.AddWithValue(
                                    "@NoteInstructions",
                                    txtNote.Text.Trim());

                                cmd.Parameters.AddWithValue(
                                    "@RecordedBy",
                                    "Nurse/Doctor");

                                cmd.ExecuteNonQuery();
                            }


                            // =====================================================
                            // 2. CHANGE APPOINTMENT STATUS
                            // CHECKED IN → FOLLOW-UP SCHEDULED
                            // =====================================================

                            string updateQuery = @"
                        UPDATE appointments
                        SET Appointment_Status = 'FOLLOW-UP SCHEDULED'
                        WHERE Appointment_ID = @AppointmentID
                        AND UPPER(TRIM(Appointment_Status)) = 'CHECKED IN'";

                            using (MySqlCommand cmd =
                                new MySqlCommand(
                                    updateQuery,
                                    conn,
                                    transaction))
                            {
                                cmd.Parameters.AddWithValue(
                                    "@AppointmentID",
                                    selectedAppointmentID);

                                int rowsUpdated = cmd.ExecuteNonQuery();

                                if (rowsUpdated == 0)
                                {
                                    throw new Exception(
                                        "The appointment is no longer CHECKED IN.");
                                }
                            }


                            // =====================================================
                            // 3. SAVE APPOINTMENT HISTORY
                            // =====================================================

                            string historyQuery = @"
                        INSERT INTO appointment_history
                        (
                            Appointment_ID,
                            Action_Type,
                            Action_Date,
                            Created_By
                        )
                        VALUES
                        (
                            @AppointmentID,
                            'FOLLOW-UP SCHEDULED',
                            NOW(),
                            @CreatedBy
                        )";

                            using (MySqlCommand cmd =
                                new MySqlCommand(
                                    historyQuery,
                                    conn,
                                    transaction))
                            {
                                cmd.Parameters.AddWithValue(
                                    "@AppointmentID",
                                    selectedAppointmentID);

                                cmd.Parameters.AddWithValue(
                                    "@CreatedBy",
                                    "Nurse/Doctor");

                                cmd.ExecuteNonQuery();
                            }


                            // =====================================================
                            // SAVE EVERYTHING
                            // =====================================================

                            transaction.Commit();


                            MessageBox.Show(
                                "Follow-up scheduled successfully.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);


                            // Clear the form
                            cmbPatients.SelectedIndex = -1;
                            cmbPatients.Text = "Select Patient";

                            txtName.Clear();
                            txtStudentStaffNumber.Clear();
                            txtPhoneNumber.Clear();
                            txtEmail.Clear();

                            txtNote.Clear();

                            cmbFollowUpTime.SelectedIndex = -1;
                            cmbFollowUpTime.Text = "Select Time";

                            selectedAppointmentID = 0;
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error saving follow-up:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
