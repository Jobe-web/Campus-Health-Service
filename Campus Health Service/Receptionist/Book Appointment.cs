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
using System.Text.RegularExpressions;
using Campus_Health_Service;

namespace Receptionist
{
    public partial class Book_Appointment : Form
    {
        private int patientId;
        private bool patientExists;

        //=====================================================================================================================================================================
        // Constructor when patient already exists
        //=====================================================================================================================================================================
        public Book_Appointment(
            int patientId,
            string studentStaffNumber,
            string fullName,
            string contactNumber,
            string passwordCode,
            string email)
        {
            InitializeComponent();

            this.patientId = patientId;
            this.patientExists = true;

            txtStudentStaffNumber.Text = studentStaffNumber;
            txtFullName.Text = fullName;
            txtContactNumber.Text = contactNumber;
            txtPassword.Text = passwordCode;
            txtEmail.Text = email;
        }

        //=====================================================================================================================================================================

        // Constructor when patient does not exist
        public Book_Appointment(string studentStaffNumber)
        {
            InitializeComponent();

            this.patientId = 0;
            this.patientExists = false;

            txtStudentStaffNumber.Text = studentStaffNumber;
        }

        //=====================================================================================================================================================================

        private void Book_Appointment_Load(object sender, EventArgs e)
        {
            btnBookAppointment.BackColor = Color.Blue;
            if (patientExists)
            {
                // Patient exists.
                // Lock all patient information.

                txtStudentStaffNumber.Enabled = false;
                txtFullName.Enabled = false;
                txtContactNumber.Enabled = false;
                txtPassword.Enabled = false;
                txtEmail.Enabled = false;
            }
            else
            {
                // Patient does not exist.
                // Student/Staff Number was already checked,
                // but the other details must be entered.

                txtStudentStaffNumber.Enabled = false;

                txtFullName.Enabled = true;
                txtContactNumber.Enabled = true;
                txtPassword.Enabled = true;
                txtEmail.Enabled = true;
            }
        }

        // -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Load available appointment times based on the selected date and service
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void LoadAvailableTimes()
        {
            try
            {
                cmbTime.Items.Clear();

                // Fixed appointment times
                //---------------------------------------------------------------------------------------------------------------------------------------------------------
                string[] allTimes =
                {
            "08:00 - 09:00",
            "09:00 - 10:00",
            "10:00 - 11:00",
            "11:00 - 12:00",
            "13:00 - 14:00",
            "14:00 - 15:00",
            "15:00 - 16:00",
            "16:00 - 17:00"
        };

                // If no service is selected, show all times
                //------------------------------------------------------------------------------------------------------------------------------------
                if (string.IsNullOrWhiteSpace(cmbService.Text))
                {
                    cmbTime.Items.AddRange(allTimes);
                    return;
                }

                DateTime selectedDate = dtpDate.Value.Date;


                DBConnection db = new DBConnection();

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"
                      SELECT Start_Time, End_Time
                      FROM appointment_slots
                      WHERE Slot_date = @SlotDate";

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@SlotDate",
                            selectedDate);

                        using (MySqlDataReader reader =
                               cmd.ExecuteReader())
                        {
                            // Store booked times
                            //--------------------------------------------------------------------------------------------------------------------------------------------------
                            HashSet<string> bookedTimes =
                                new HashSet<string>();

                            while (reader.Read())
                            {
                                TimeSpan startTime =
                                    reader.GetTimeSpan("Start_Time");

                                TimeSpan endTime =
                                    reader.GetTimeSpan("End_Time");

                                string bookedTime =
                                    startTime.ToString(@"hh\:mm") +
                                    " - " +
                                    endTime.ToString(@"hh\:mm");

                                bookedTimes.Add(bookedTime);
                            }

                            // Add only times that are NOT booked
                            //-------------------------------------------------------------------------------------------------------------------------------------------------
                            foreach (string time in allTimes)
                            {
                                if (!bookedTimes.Contains(time))
                                {
                                    cmbTime.Items.Add(time);
                                }
                            }
                        }
                    }
                }

                // Select the first available time automatically
                //-------------------------------------------------------------------------------------------------------------------------------------------------------------
                if (cmbTime.Items.Count > 0)
                {
                    cmbTime.SelectedIndex = 0;
                }
                else
                {
                    cmbTime.Text = "";

                    MessageBox.Show(
                        "There are no available times for this service on the selected date.",
                        "No Available Times",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading available times:\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }




        //=====================================================================================================================================================================
        // Book the appointment when the "Book" button is clicked
        //=====================================================================================================================================================================

        private void btnBook_Click(object sender, EventArgs e)
        {

            btnBookAppointment.Text = "Loading...";
            btnBookAppointment.Enabled = false;

            // Get patient information
            string studentStaffNumber =
                txtStudentStaffNumber.Text.Trim();

            string fullName =
                txtFullName.Text.Trim();

            string contactNumber =
                txtContactNumber.Text.Trim();

            string passwordCode =
                txtPassword.Text.Trim();

            string email =
                txtEmail.Text.Trim();


            // Get selected service
            string service =
                cmbService.Text.Trim();


            // Get selected date
            DateTime appointmentDate =
                dtpDate.Value.Date;


            // Get selected time
            string selectedTime =
                cmbTime.Text.Trim();


            // Validate Student/Staff Number
            if (string.IsNullOrWhiteSpace(studentStaffNumber))
            {
                MessageBox.Show(
                    "Please enter your Student/Staff Number.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStudentStaffNumber.Focus();

                btnBookAppointment.Text = "Book Appointments";
                btnBookAppointment.Enabled = true;
                return;
            }

            //=================================================================================================================
            // Validate Full Name
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show(
                    "Please enter your full name.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtFullName.Focus();
                btnBookAppointment.Text = "Book Appointments";
                btnBookAppointment.Enabled = true;
                return;
            }

            //=================================================================================================================
            // Validate Contact Number
            if (string.IsNullOrWhiteSpace(contactNumber))
            {
                MessageBox.Show(
                    "Please enter your contact number.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtContactNumber.Focus();

                btnBookAppointment.Text = "Book Appointments";
                btnBookAppointment.Enabled = true;
                return;
            }

            //=================================================================================================================
            // Validate Password
            if (string.IsNullOrWhiteSpace(passwordCode))
            {
                MessageBox.Show(
                    "Please enter your password.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();
                btnBookAppointment.Text = "Book";
                btnBookAppointment.Enabled = true;
                return;
            }

            // Check for at least one uppercase letter
            if (!passwordCode.Any(char.IsUpper))
            {
                MessageBox.Show(
                    "Password must contain at least one uppercase letter.",
                    "Invalid Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();

                btnBookAppointment.Text = "Book Appointments";
                btnBookAppointment.Enabled = true;
                return;
            }

            // Check for at least one number
            if (!passwordCode.Any(char.IsDigit))
            {
                MessageBox.Show(
                    "Password must contain at least one number.",
                    "Invalid Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();

                btnBookAppointment.Text = "Book";
                btnBookAppointment.Enabled = true;
                return;
            }

            // Check for at least one special character
            if (!passwordCode.Any(ch => "@#$%^&*".Contains(ch)))
            {
                MessageBox.Show(
                    "Password must contain at least one special character (@, #, $, %, ^, &, or *).",
                    "Invalid Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();

                btnBookAppointment.Text = "Book Appointments";
                btnBookAppointment.Enabled = true;
                return;
            }

            //=================================================================================================================
            // Validate Email
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show(
                    "Please enter your email.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();

                btnBookAppointment.Text = "Book Appointments";
                btnBookAppointment.Enabled = true;
                return;
            }

            //====================================================================================
            // Check email format.
            // Allows MUT email: 12345678.live@mut.ac.za
            // Allows Gmail: example@gmail.com
            //====================================================================================

            string mutEmailPattern = @"^(\d{8})\.live@mut\.ac\.za$";
            string gmailPattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";

            Match mutEmailMatch = Regex.Match(
                email,
                mutEmailPattern,
                RegexOptions.IgnoreCase);

            bool isGmail = Regex.IsMatch(
                email,
                gmailPattern,
                RegexOptions.IgnoreCase);

            //====================================================================================
            // Check if the email is either a valid MUT email or Gmail.
            //====================================================================================
            if (!mutEmailMatch.Success && !isGmail)
            {
                MessageBox.Show(
                    "Please enter a valid email address.\n\n" +
                    "MUT format: 12345678.live@mut.ac.za\n" +
                    "Gmail format: example@gmail.com",
                    "Invalid Email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();
                btnBookAppointment.Text = "Book Appointments";
                btnBookAppointment.Enabled = true;
                return;
            }

            //====================================================================================
            // If it is a MUT email, check that the 8 digits match the Student/Staff Number.
            // Gmail does not need this check.
            //====================================================================================
            if (mutEmailMatch.Success)
            {
                string emailStudentNumber =
                    mutEmailMatch.Groups[1].Value;

                if (emailStudentNumber != studentStaffNumber)
                {
                    MessageBox.Show(
                        "The Student/Staff Number in the email does not match " +
                        "the Student/Staff Number entered above.",
                        "Number Mismatch",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtEmail.Focus();

                    btnBookAppointment.Text = "Book Appointments";
                    btnBookAppointment.Enabled = true;
                    return;
                }
            }

            //=================================================================================================================
            // Validate Service
            if (string.IsNullOrWhiteSpace(service))
            {
                MessageBox.Show(
                    "Please select a service.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbService.Focus();

                btnBookAppointment.Text = "Book Appointments";
                btnBookAppointment.Enabled = true;
                return;
            }

            //=================================================================================================================
            // Validate Time
            if (string.IsNullOrWhiteSpace(selectedTime))
            {
                MessageBox.Show(
                    "Please select an appointment time.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbTime.Focus();

                btnBookAppointment.Text = "Book Appointments";
                btnBookAppointment.Enabled = true;
                return;
            }


            DBConnection db = new DBConnection();

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // Start transaction.
                    // All booking operations must succeed together.
                    //--------------------------------------------------------------------------------------------------------------------------------------------------------------
                    using (MySqlTransaction transaction =
                           conn.BeginTransaction())
                    {
                        int currentPatientId = patientId;


                        // ---------------------------------------------------------------------------------------------------------------------------------------------------------
                        // STEP 1: Create patient if the patient is new
                        // ---------------------------------------------------------------------------------------------------------------------------------------------------------

                        if (!patientExists)
                        {
                            string patientQuery = @"
                              INSERT INTO patients
                              (
                                 StudentORStaff_Number,
                                 Full_Name,
                                 Contact_Number,
                                 PasswordCode,
                                 Email
                              )
                              VALUES
                              (
                                 @StudentStaffNumber,
                                 @FullName,
                                 @ContactNumber,
                                 @PasswordCode,
                                 @Email
                              );

                              SELECT LAST_INSERT_ID();";

                            using (MySqlCommand patientCmd =
                                   new MySqlCommand(
                                       patientQuery,
                                       conn,
                                       transaction))
                            {
                                patientCmd.Parameters.AddWithValue(
                                    "@StudentStaffNumber",
                                    studentStaffNumber);

                                patientCmd.Parameters.AddWithValue(
                                    "@FullName",
                                    fullName);

                                patientCmd.Parameters.AddWithValue(
                                    "@ContactNumber",
                                    contactNumber);

                                patientCmd.Parameters.AddWithValue(
                                    "@PasswordCode",
                                    passwordCode);

                                patientCmd.Parameters.AddWithValue(
                                    "@Email",
                                    email);

                                currentPatientId =
                                    Convert.ToInt32(
                                        patientCmd.ExecuteScalar());
                            }
                        }


                        // -------------------------------------------------------------------------
                        // STEP 2: Convert selected time into Start_Time and End_Time
                        // -------------------------------------------------------------------------

                        string[] timeParts =
                            selectedTime.Split('-');

                        if (timeParts.Length != 2)
                        {
                            MessageBox.Show(
                                "Please select a valid appointment time.",
                                "Invalid Time",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            transaction.Rollback();

                            btnBookAppointment.Text = "Book Appointments";
                            btnBookAppointment.Enabled = true;
                            return;
                        }

                        TimeSpan startTime =
                            TimeSpan.Parse(timeParts[0].Trim());

                        TimeSpan endTime =
                            TimeSpan.Parse(timeParts[1].Trim());


                        // ---------------------------------------------------------------------------------------------------------------------------------------------------------
                        // STEP 3: Check if this date, service and time is already booked
                        // ---------------------------------------------------------------------------------------------------------------------------------------------------------

                        string checkSlotQuery = @"
                          SELECT Slot_ID
                          FROM appointment_slots
                          WHERE Slot_date = @SlotDate
                          AND Start_Time = @StartTime
                          AND End_Time = @EndTime
                          LIMIT 1
                          FOR UPDATE;";

                        int slotId = 0;

                        using (MySqlCommand checkSlotCmd =
                               new MySqlCommand(
                                   checkSlotQuery,
                                   conn,
                                   transaction))
                        {
                            checkSlotCmd.Parameters.AddWithValue(
                                "@SlotDate",
                                appointmentDate);

                            checkSlotCmd.Parameters.AddWithValue(
                                "@StartTime",
                                startTime);

                            checkSlotCmd.Parameters.AddWithValue(
                                "@EndTime",
                                endTime);

                            object result =
                                checkSlotCmd.ExecuteScalar();

                            if (result != null)
                            {
                                MessageBox.Show(
                                    "This appointment time is already booked for the selected date.\n\n" +
                                    "Please select another time.",
                                    "Time Already Booked",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                transaction.Rollback();

                                LoadAvailableTimes();

                                btnBookAppointment.Text = "Book Appointments";
                                btnBookAppointment.Enabled = true;

                                return;
                            }
                        }


                        // ---------------------------------------------------------------------------------------------------------------------------------------------------------
                        // STEP 4: Create the appointment slot
                        // ---------------------------------------------------------------------------------------------------------------------------------------------------------

                        string slotQuery = @"
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
                            @SlotDate,
                            @Service,
                            @StartTime,
                            @EndTime,
                            'Receptionist'
                         );

                         SELECT LAST_INSERT_ID();";

                        using (MySqlCommand slotCmd =
                               new MySqlCommand(
                                   slotQuery,
                                   conn,
                                   transaction))
                        {
                            slotCmd.Parameters.AddWithValue(
                                "@SlotDate",
                                appointmentDate);

                            slotCmd.Parameters.AddWithValue(
                                "@Service",
                                service);

                            slotCmd.Parameters.AddWithValue(
                                "@StartTime",
                                startTime);

                            slotCmd.Parameters.AddWithValue(
                                "@EndTime",
                                endTime);

                            slotId =
                                Convert.ToInt32(
                                    slotCmd.ExecuteScalar());
                        }


                        // ---------------------------------------------------------------------------------------------------------------------------------------------------------
                        // STEP 5: Create the appointment as BOOKED
                        // ---------------------------------------------------------------------------------------------------------------------------------------------------------

                        string appointmentQuery = @"
                          INSERT INTO appointments
                          (
                             Patient_ID,
                             Slot_ID,
                             Appointment_Type,
                             Appointment_Status
                          )
                          VALUES
                          (
                             @PatientID,
                             @SlotID,
                             @AppointmentType,
                             'BOOKED'
                          );

                          SELECT LAST_INSERT_ID();";

                        int appointmentId;

                        using (MySqlCommand appointmentCmd =
                               new MySqlCommand(
                                   appointmentQuery,
                                   conn,
                                   transaction))
                        {
                            appointmentCmd.Parameters.AddWithValue(
                                "@PatientID",
                                currentPatientId);

                            appointmentCmd.Parameters.AddWithValue(
                                "@SlotID",
                                slotId);

                            appointmentCmd.Parameters.AddWithValue(
                                "@AppointmentType",
                                service);

                            appointmentId =
                                Convert.ToInt32(
                                    appointmentCmd.ExecuteScalar());
                        }


                        // ---------------------------------------------------------------------------------------------------------------------------------------------------------
                        // STEP 6: Save BOOKED in appointment history
                        // ---------------------------------------------------------------------------------------------------------------------------------------------------------

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
                             'BOOKED',
                             NOW(),
                            'Receptionist'
                          );";

                        using (MySqlCommand historyCmd =
                               new MySqlCommand(
                                   historyQuery,
                                   conn,
                                   transaction))
                        {
                            historyCmd.Parameters.AddWithValue(
                                "@AppointmentID",
                                appointmentId);

                            historyCmd.ExecuteNonQuery();
                        }


                        btnBookAppointment.Text = "Book Appointments";
                        btnBookAppointment.Enabled = true;

                        // --------------------------------------------------------------------------------------------------------------------------------------------------
                        // STEP 7: Save everything
                        // ----------------------------------------------------------------------------------------------------------------------------------------------------

                        transaction.Commit();


                        MessageBox.Show(
                            "Appointment booked successfully!",
                            "Appointment Booked",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error booking appointment:\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }


        // -------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Reload appointment times when the selected date changes
        // --------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadAvailableTimes();
        }

        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Reload appointment times when the selected service changes
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAvailableTimes();
        }

        //=====================================================================================================================================================================
        private void btnHome_Click(object sender, EventArgs e)
        {
            Reception_DashBoard dash = new Reception_DashBoard();
            dash.Show();
            this.Hide();
        }

        //=====================================================================================================================================================================
        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            // Open the CheckPatient form
            CheckPatient check = new CheckPatient();
            check.Show();
            this.Hide();
        }

        //=====================================================================================================================================================================
        private void btnManage_Click(object sender, EventArgs e)
        {
            Manage_Appointments manage = new Manage_Appointments();
            manage.Show();
            this.Hide();
        }

        //=====================================================================================================================================================================
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel_Appointments cancel = new Cancel_Appointments();
            cancel.Show();
            this.Hide();
        }

        //=====================================================================================================================================================================
        private void btnEmergency_Click(object sender, EventArgs e)
        {
            Emegency em = new Emegency();
            em.Show();
            this.Hide();
        }

        //=====================================================================================================================================================================
        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnLogout.Text = "Loading...";
            btnLogout.Enabled = false;

            btnLogout.BackColor = Color.Red;

            // Reset the View Appointments button color
            btnBookAppointment.BackColor = Color.White;

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
                btnBookAppointment.BackColor = Color.Blue;
            }
        }
    }
}
