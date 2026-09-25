// Target framework for the code: .NET 8.0
using Campus_Health_Service;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//for sending emails
using System.Net;
using System.Net.Mail;

using System.Windows.Forms;

namespace Receptionist
{
    public partial class Emegency : Form
    {
        // =========================================================
        // STORE PATIENTS WHOSE APPOINTMENTS WERE RESCHEDULED
        // =========================================================
        private List<(string Name, string Email, DateTime NewDate, TimeSpan NewTime, string Service)> movedPatients
            = new List<(string, string, DateTime, TimeSpan, string)>();


        public Emegency()
        {
            InitializeComponent();
        }


        //===================================================================================================================================================================
        //check if the patient exists in the database when the Student/Staff Number field loses focus
        //==========================================================================================================================================================
        private void CheckExistingPatient()
        {
            string studentStaffNumber = txtStudentStaffNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(studentStaffNumber))
                return;

            try
            {
                DBConnection dbConnection = new DBConnection();

                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT
                    Full_Name,
                    Contact_Number,
                    Email
                FROM patients
                WHERE StudentORStaff_Number = @StudentStaffNumber
                LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@StudentStaffNumber",
                            studentStaffNumber);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Patient exists
                                txtName.Text = reader["Full_Name"].ToString();
                                txtNumber.Text = reader["Contact_Number"].ToString();
                                txtEmail.Text = reader["Email"].ToString();

                                // Lock patient information
                                txtStudentStaffNumber.Enabled = false;
                                txtName.Enabled = false;
                                txtNumber.Enabled = false;
                                txtEmail.Enabled = false;

                                MessageBox.Show(
                                    "Existing patient found.\n\n" +
                                    "Patient information has been loaded.",
                                    "Patient Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            else
                            {
                                // New patient
                                txtStudentStaffNumber.Enabled = true;
                                txtName.Enabled = true;
                                txtNumber.Enabled = true;
                                txtEmail.Enabled = true;

                                MessageBox.Show(
                                    "Patient not found.\n\n" +
                                    "Please enter the patient's information.",
                                    "New Patient",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error checking patient:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //===================================================================================================================================================================
        private void btnHome_Click(object sender, EventArgs e)
        {
            Reception_DashBoard dashBoard = new Reception_DashBoard();
            dashBoard.Show();
            this.Hide();
        }

        //===================================================================================================================================================================
        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            CheckPatient checkPatient = new CheckPatient();
            checkPatient.Show();
            this.Hide();
        }

        //===================================================================================================================================================================
        private void btnManageAppointments_Click(object sender, EventArgs e)
        {
            Manage_Appointments manage_Appointments = new Manage_Appointments();
            manage_Appointments.Show();
            this.Hide();
        }

        //===================================================================================================================================================================
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel_Appointments cancel_Appointments = new Cancel_Appointments();
            cancel_Appointments.Show();
            this.Hide();
        }

        //===================================================================================================================================================================
        private void btnEmegency_Click(object sender, EventArgs e)
        {

        }


        //===================================================================================================================================================================
        private void btnLogout_Click(object sender, EventArgs e)
        {

            btnLogout.Text = "Loading...";
            btnLogout.Enabled = false;

            btnLogout.BackColor = Color.Red;

            // Reset the View Appointments button color
            btnEmergency.BackColor = Color.White;

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
                btnEmergency.BackColor = Color.Blue;
            }
        }

        private void Emegency_Load(object sender, EventArgs e)
        {
            btnEmergency.BackColor = Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnEmergency.Text = "Loading...";
            btnEmergency.Enabled = false;

            // Student/Staff Number
            string studentStaffNumber = txtStudentStaffNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(studentStaffNumber))
            {
                MessageBox.Show(
                    "Please enter the Student/Staff Number.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStudentStaffNumber.Focus();
                return;
            }

            // Email
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show(
                    "Please enter the patient's email.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();
                return;
            }

            string emailPattern = @"^\d{8}\.live@mut\.ac\.za$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show(
                    "Please enter a valid MUT email address.\n\n" +
                    "Format: 12345678.live@mut.ac.za",
                    "Invalid Email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();
                return;
            }

            // Full Name
            string fullName = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show(
                    "Please enter the patient's full name.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtName.Focus();
                return;
            }

            // Contact Number
            string contactNumber = txtNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(contactNumber))
            {
                MessageBox.Show(
                    "Please enter the patient's contact number.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNumber.Focus();
                return;
            }

            // Service
            if (cmbService.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a service.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbService.Focus();
                return;
            }

            // Priority Level
            if (cmbLevel.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a priority level.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbLevel.Focus();
                return;
            }

            // Get selected values
            string service = cmbService.Text;
            string priorityLevel = cmbLevel.Text;

            // Get emergency date and time
            DateTime emergencyStart =
                dtpEmergencyDate.Value.Date +
                dtpEmergencyTime.Value.TimeOfDay;

            // Emergency lasts exactly 2 hours
            DateTime emergencyEnd = emergencyStart.AddHours(2);

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
                            // =========================================================
                            // 1. FIND OR CREATE PATIENT
                            // =========================================================

                            int patientID = 0;

                            string patientQuery = @"
                              SELECT Patient_ID
                              FROM patients
                              WHERE StudentORStaff_Number = @number
                              LIMIT 1";

                            using (MySqlCommand cmdPatient =
                                new MySqlCommand(patientQuery, conn, transaction))
                            {
                                cmdPatient.Parameters.AddWithValue(
                                    "@number",
                                    studentStaffNumber);

                                object result = cmdPatient.ExecuteScalar();

                                if (result != null)
                                {
                                    patientID = Convert.ToInt32(result);
                                }
                                else
                                {
                                    string insertPatient = @"
                                      INSERT INTO patients
                                      (StudentORStaff_Number, Full_Name, Contact_Number, Email)
                                      VALUES
                                      (@number, @name, @contact, @email)";

                                    using (MySqlCommand cmdInsertPatient =
                                        new MySqlCommand(insertPatient, conn, transaction))
                                    {
                                        cmdInsertPatient.Parameters.AddWithValue(
                                            "@number", studentStaffNumber);

                                        cmdInsertPatient.Parameters.AddWithValue(
                                            "@name", fullName);

                                        cmdInsertPatient.Parameters.AddWithValue(
                                            "@contact", contactNumber);

                                        cmdInsertPatient.Parameters.AddWithValue(
                                            "@email", email);

                                        cmdInsertPatient.ExecuteNonQuery();

                                        patientID =
                                            Convert.ToInt32(cmdInsertPatient.LastInsertedId);
                                    }
                                }
                            }


                            // =========================================================
                            // 2. FIND ALL BOOKED APPOINTMENTS AFFECTED BY EMERGENCY
                            // =========================================================

                            DataTable affectedAppointments = new DataTable();

                            string affectedQuery = @"
                                     SELECT
                                        a.Appointment_ID,
                                        a.Slot_ID,
                                        p.Full_Name,
                                        p.Email,
                                        s.Services,
                                        s.Slot_date,
                                        s.Start_Time,
                                        s.End_Time
                                    FROM appointments a
                                    INNER JOIN patients p
                                       ON a.Patient_ID = p.Patient_ID
                                    INNER JOIN appointment_slots s
                                       ON a.Slot_ID = s.Slot_ID
                                    WHERE s.Slot_date = @date
                                      AND s.Start_Time >= TIME(@startDateTime)
                                      AND s.Start_Time < TIME(@endDateTime)
                                      AND a.Appointment_Status = 'BOOKED'
                                   ORDER BY s.Start_Time, a.Appointment_ID";
                            using (MySqlCommand cmdAffected =
                                new MySqlCommand(affectedQuery, conn, transaction))
                            {
                                cmdAffected.Parameters.AddWithValue(
                                     "@date",
                                     emergencyStart.Date);

                                cmdAffected.Parameters.AddWithValue(
                                    "@startDateTime",
                                    emergencyStart);

                                cmdAffected.Parameters.AddWithValue(
                                    "@endDateTime",
                                    emergencyEnd);

                                using (MySqlDataAdapter adapter =
                                    new MySqlDataAdapter(cmdAffected))
                                {
                                    adapter.Fill(affectedAppointments);
                                }
                            }


                            // =========================================================
                            // 3. CALCULATE FIRST NEW NORMAL APPOINTMENT TIME
                            //
                            // Example:
                            // Emergency ends 11:14 -> start at 11:00
                            //
                            // Emergency ends 11:35 -> start at 13:00
                            //
                            // 12:00 - 13:00 is lunch.
                            // =========================================================

                            DateTime nextSlot;

                            if (emergencyEnd.Minute < 30)
                            {
                                nextSlot = emergencyEnd.Date.AddHours(
                                    emergencyEnd.Hour);
                            }
                            else
                            {
                                nextSlot = emergencyEnd.Date.AddHours(
                                    emergencyEnd.Hour + 1);
                            }


                            // Skip lunch
                            if (nextSlot.TimeOfDay >= new TimeSpan(12, 0, 0) &&
                                nextSlot.TimeOfDay < new TimeSpan(13, 0, 0))
                            {
                                nextSlot = nextSlot.Date.AddHours(13);
                            }


                            // If we are already past 17:00,
                            // move to tomorrow at 08:00.
                            if (nextSlot.TimeOfDay >= new TimeSpan(17, 0, 0))
                            {
                                nextSlot =
                                    nextSlot.Date.AddDays(1).AddHours(8);
                            }


                            // =========================================================
                            // 4. MOVE AFFECTED APPOINTMENTS
                            // =========================================================

                            foreach (DataRow row in affectedAppointments.Rows)
                            {
                                int appointmentID =
                                    Convert.ToInt32(row["Appointment_ID"]);

                                string appointmentService =
                                    row["Services"].ToString();

                                bool moved = false;

                                while (!moved)
                                {
                                    // -------------------------------------------------
                                    // Skip lunch
                                    // -------------------------------------------------

                                    if (nextSlot.TimeOfDay >= new TimeSpan(12, 0, 0) &&
                                        nextSlot.TimeOfDay < new TimeSpan(13, 0, 0))
                                    {
                                        nextSlot =
                                            nextSlot.Date.AddHours(13);
                                    }


                                    // -------------------------------------------------
                                    // If past 17:00, go to next day 08:00
                                    // -------------------------------------------------

                                    if (nextSlot.TimeOfDay >= new TimeSpan(17, 0, 0))
                                    {
                                        nextSlot =
                                            nextSlot.Date.AddDays(1).AddHours(8);
                                    }


                                    // -------------------------------------------------
                                    // Check whether target time already has an
                                    // appointment.
                                    //
                                    // We check date + time, regardless of service.
                                    // -------------------------------------------------

                                    string occupiedQuery = @"
                                       SELECT COUNT(*)
                                       FROM appointments a
                                       INNER JOIN appointment_slots s
                                       ON a.Slot_ID = s.Slot_ID
                                       WHERE s.Slot_date = @date
                                       AND s.Start_Time = @startTime
                                       AND a.Appointment_Status <> 'CANCELLED'";

                                    bool occupied = false;

                                    using (MySqlCommand cmdOccupied =
                                        new MySqlCommand(
                                            occupiedQuery,
                                            conn,
                                            transaction))
                                    {
                                        cmdOccupied.Parameters.AddWithValue(
                                            "@date",
                                            nextSlot.Date);

                                        cmdOccupied.Parameters.AddWithValue(
                                            "@startTime",
                                            nextSlot.TimeOfDay);

                                        int count =
                                            Convert.ToInt32(
                                                cmdOccupied.ExecuteScalar());

                                        if (count > 0)
                                        {
                                            occupied = true;
                                        }
                                    }


                                    // -------------------------------------------------
                                    // If occupied, try next hourly slot.
                                    // -------------------------------------------------

                                    if (occupied)
                                    {
                                        nextSlot = nextSlot.AddHours(1);
                                        continue;
                                    }


                                    // =================================================
                                    // 5. FIND OR CREATE TARGET SLOT
                                    // =================================================

                                    int targetSlotID = 0;

                                    string findSlotQuery = @"
                                       SELECT Slot_ID
                                       FROM appointment_slots
                                       WHERE Slot_date = @date
                                       AND Start_Time = @startTime
                                       AND End_Time = @endTime
                                       LIMIT 1";

                                    using (MySqlCommand cmdFindSlot =
                                        new MySqlCommand(
                                            findSlotQuery,
                                            conn,
                                            transaction))
                                    {
                                        cmdFindSlot.Parameters.AddWithValue(
                                            "@date",
                                            nextSlot.Date);

                                        cmdFindSlot.Parameters.AddWithValue(
                                            "@startTime",
                                            nextSlot.TimeOfDay);

                                        cmdFindSlot.Parameters.AddWithValue(
                                            "@endTime",
                                            nextSlot.AddHours(1).TimeOfDay);

                                        object slotResult =
                                            cmdFindSlot.ExecuteScalar();

                                        if (slotResult != null)
                                        {
                                            targetSlotID =
                                                Convert.ToInt32(slotResult);
                                        }
                                    }


                                    // -------------------------------------------------
                                    // If the slot does not exist, create it.
                                    // Keep the original appointment's service.
                                    // -------------------------------------------------

                                    if (targetSlotID == 0)
                                    {
                                        string createSlotQuery = @"
                                          INSERT INTO appointment_slots
                                          (
                                              Slot_date,
                                              Services,
                                              Start_Time,
                                              End_Time,
                                              Created_by
                                           )
                                           VALUES
                                           (
                                              @date,
                                              @service,
                                              @startTime,
                                              @endTime,
                                              'Receptionist'
                                           )";

                                        using (MySqlCommand cmdCreateSlot =
                                            new MySqlCommand(
                                                createSlotQuery,
                                                conn,
                                                transaction))
                                        {
                                            cmdCreateSlot.Parameters.AddWithValue(
                                                "@date",
                                                nextSlot.Date);

                                            cmdCreateSlot.Parameters.AddWithValue(
                                                "@service",
                                                appointmentService);

                                            cmdCreateSlot.Parameters.AddWithValue(
                                                "@startTime",
                                                nextSlot.TimeOfDay);

                                            cmdCreateSlot.Parameters.AddWithValue(
                                                "@endTime",
                                                nextSlot.AddHours(1).TimeOfDay);

                                            cmdCreateSlot.ExecuteNonQuery();

                                            targetSlotID =
                                                Convert.ToInt32(
                                                    cmdCreateSlot.LastInsertedId);
                                        }
                                    }


                                    // =================================================
                                    // 6. MOVE APPOINTMENT TO NEW SLOT
                                    // =================================================

                                    string updateAppointmentQuery = @"
                                      UPDATE appointments
                                      SET Slot_ID = @newSlotID
                                      WHERE Appointment_ID = @appointmentID";

                                    using (MySqlCommand cmdUpdate =
                                        new MySqlCommand(
                                            updateAppointmentQuery,
                                            conn,
                                            transaction))
                                    {
                                        cmdUpdate.Parameters.AddWithValue(
                                            "@newSlotID",
                                            targetSlotID);

                                        cmdUpdate.Parameters.AddWithValue(
                                            "@appointmentID",
                                            appointmentID);

                                        cmdUpdate.ExecuteNonQuery();
                                    }
                                    // Store patient details for notification
                                    string patientName = row["Full_Name"].ToString();
                                    string patientEmail = row["Email"].ToString();

                                    movedPatients.Add(
                                        (
                                            patientName,
                                            patientEmail,
                                            nextSlot.Date,
                                            nextSlot.TimeOfDay,
                                            appointmentService
                                        )
                                    );

                                    // =================================================
                                    // 7. ADD RESCHEDULE HISTORY
                                    // =================================================

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
                                          @appointmentID,
                                         'RESCHEDULED',
                                          NOW(),
                                         'Receptionist'
                                       )";

                                    using (MySqlCommand cmdHistory =
                                        new MySqlCommand(
                                            historyQuery,
                                            conn,
                                            transaction))
                                    {
                                        cmdHistory.Parameters.AddWithValue(
                                            "@appointmentID",
                                            appointmentID);

                                        cmdHistory.ExecuteNonQuery();
                                    }


                                    // Appointment successfully moved
                                    moved = true;

                                    // Next affected appointment gets
                                    // the next hourly slot.
                                    nextSlot = nextSlot.AddHours(1);
                                }
                            }


                            // =========================================================
                            // 8. CREATE EMERGENCY SLOT
                            // =========================================================

                            int emergencySlotID = 0;

                            string emergencySlotQuery = @"
                                INSERT INTO appointment_slots
                                (
                                   Slot_date,
                                   Services,
                                   Start_Time,
                                   End_Time,
                                   Created_by
                                )
                                VALUES
                                (
                                  @date,
                                  @service,
                                  @startTime,
                                  @endTime,
                                  'Receptionist'
                                )";

                            using (MySqlCommand cmdEmergencySlot =
                                new MySqlCommand(
                                    emergencySlotQuery,
                                    conn,
                                    transaction))
                            {
                                cmdEmergencySlot.Parameters.AddWithValue(
                                    "@date",
                                    emergencyStart.Date);

                                cmdEmergencySlot.Parameters.AddWithValue(
                                    "@service",
                                    service);

                                cmdEmergencySlot.Parameters.AddWithValue(
                                    "@startTime",
                                    emergencyStart.TimeOfDay);

                                cmdEmergencySlot.Parameters.AddWithValue(
                                    "@endTime",
                                    emergencyEnd.TimeOfDay);

                                cmdEmergencySlot.ExecuteNonQuery();

                                emergencySlotID =
                                    Convert.ToInt32(
                                        cmdEmergencySlot.LastInsertedId);
                            }


                            // =========================================================
                            // 9. CREATE EMERGENCY APPOINTMENT
                            // =========================================================

                            int emergencyAppointmentID = 0;

                            string appointmentQuery = @"
                              INSERT INTO appointments
                                (
                                   Patient_ID,
                                   Slot_ID,
                                   Appointment_Type,
                                   Appointment_Status,
                                   Date_Created
                                )
                                VALUES
                                (
                                  @patientID,
                                  @slotID,
                                  @type,
                                  'CHECKED IN',
                                  NOW()
                                )";

                            using (MySqlCommand cmdAppointment =
                                new MySqlCommand(
                                    appointmentQuery,
                                    conn,
                                    transaction))
                            {
                                cmdAppointment.Parameters.AddWithValue(
                                    "@patientID",
                                    patientID);

                                cmdAppointment.Parameters.AddWithValue(
                                    "@slotID",
                                    emergencySlotID);

                                cmdAppointment.Parameters.AddWithValue(
                                    "@type",
                                    priorityLevel);

                                cmdAppointment.ExecuteNonQuery();

                                emergencyAppointmentID =
                                    Convert.ToInt32(
                                        cmdAppointment.LastInsertedId);
                            }

                            // =========================================================
                            // 9.5. RECORD EMERGENCY DETAILS
                            // =========================================================

                            string emergencyQuery = @"
                                  INSERT INTO emergency
                                 (
                                   Appointment_ID,
                                   Urgent_Classification,
                                   Recorded_By,
                                   Date_recorded
                                 )
                                  VALUES
                                 (
                                  @appointmentID,
                                  @classification,
                                 'Receptionist',
                                  NOW()
                                 )";

                            using (MySqlCommand cmdEmergency =
                                new MySqlCommand(
                                    emergencyQuery,
                                    conn,
                                    transaction))
                            {
                                cmdEmergency.Parameters.AddWithValue(
                                    "@appointmentID",
                                    emergencyAppointmentID);

                                cmdEmergency.Parameters.AddWithValue(
                                    "@classification",
                                    priorityLevel);

                                cmdEmergency.ExecuteNonQuery();
                            }


                            // =========================================================
                            // 10. ADD CHECKED IN HISTORY
                            // =========================================================

                            string emergencyHistoryQuery = @"
                              INSERT INTO appointment_history
                              (
                                  Appointment_ID,
                                  Action_Type,
                                  Action_Date,
                                  Created_By
                              )
                              VALUES
                              (
                                  @appointmentID,
                                  'CHECKED IN',
                                  NOW(),
                                 'Receptionist'
                              )";

                            using (MySqlCommand cmdEmergencyHistory =
                                new MySqlCommand(
                                    emergencyHistoryQuery,
                                    conn,
                                    transaction))
                            {
                                cmdEmergencyHistory.Parameters.AddWithValue(
                                    "@appointmentID",
                                    emergencyAppointmentID);

                                cmdEmergencyHistory.ExecuteNonQuery();
                            }


                            // =========================================================
                            // 11. SAVE EVERYTHING
                            // =========================================================

                            transaction.Commit();

                            MessageBox.Show(
                                "Emergency appointment saved successfully.\n\n" +
                                "Affected appointments were automatically rescheduled.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
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
                    "An error occurred while saving the emergency appointment:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnEmergency.Text = "Save Emergency Appointment";
                btnEmergency.Enabled = true;
            }

        }

        //===================================================================================================================================================================
        // Event handler for the TextChanged event of the Student/Staff Number textbox
        // This will check for existing patient information as the user types
        //===================================================================================================================================================================
        private void txtStudentStaffNumber_TextChanged(object sender, EventArgs e)
        {

            // Wait until the number has 8 digits
            if (txtStudentStaffNumber.Text.Length < 8)
            {
                return;
            }

            // Check the database only when 8 digits are entered
            if (txtStudentStaffNumber.Text.Length == 8)
            {
                CheckExistingPatient();
            }
        }

        private void btnNotify_Click(object sender, EventArgs e)
        {
            if (movedPatients.Count == 0)
            {
                MessageBox.Show(
                    "There are no rescheduled appointments to notify.",
                    "No Notifications",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            btnNotify.Enabled = false;
            btnNotify.Text = "Sending...";

            try
            {
                // Campus Health Service email account
                string senderEmail = "lsjobe.ys24@gmail.com";

                // Gmail App Password
                string senderPassword = "kvgz zomx sqng ifny";

                foreach (var patient in movedPatients)
                {
                    string patientName = patient.Name;
                    string patientEmail = patient.Email;
                    string service = patient.Service;

                    string newDate = patient.NewDate.ToString("dd MMMM yyyy");

                    DateTime newStartTime =
                        DateTime.Today.Add(patient.NewTime);

                    DateTime newEndTime =
                        newStartTime.AddHours(1);

                    string newTime =
                        newStartTime.ToString("HH:mm") +
                        " - " +
                        newEndTime.ToString("HH:mm");

                    string subject =
                        "Campus Health Service - Appointment Rescheduled";

                    string body =
                        "Dear " + patientName + ",\r\n\r\n" +

                        "Your Campus Health Service appointment has been " +
                        "rescheduled due to an emergency appointment that " +
                        "required the schedule to be adjusted.\r\n\r\n" +

                        "Service: " + service + "\r\n" +
                        "New Date: " + newDate + "\r\n" +
                        "New Time: " + newTime + "\r\n\r\n" +

                        "Please take note of your new appointment date and time.\r\n\r\n" +

                        "We apologise for any inconvenience caused.\r\n\r\n" +

                        "Kind regards,\r\n" +
                        "Campus Health Service";

                    using (MailMessage mail = new MailMessage())
                    {
                        mail.From = new MailAddress(senderEmail);
                        mail.To.Add(patientEmail);
                        mail.Subject = subject;
                        mail.Body = body;

                        using (SmtpClient smtp =
                            new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.EnableSsl = true;

                            smtp.Credentials =
                                new NetworkCredential(
                                    senderEmail,
                                    senderPassword);

                            smtp.Send(mail);
                        }
                    }
                }

                MessageBox.Show(
                    movedPatients.Count +
                    " patient(s) have been notified successfully.",
                    "Notification Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Prevent sending the same notification again
                movedPatients.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The notification could not be sent.\n\n" +
                    "Error: " + ex.Message,
                    "Email Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnNotify.Enabled = true;
                btnNotify.Text = "Notify Patient";
            }
        }
    }
}
