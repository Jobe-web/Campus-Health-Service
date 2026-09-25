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
using System.Windows.Forms;

namespace Receptionist
{
    public partial class Cancel_Appointments : Form
    {
        private int selectedAppointmentID = 0;
        public Cancel_Appointments()
        {
            InitializeComponent();
        }

        //===================================================================================================================================================================
        // Load all booked appointments into the DataGridView
        //===================================================================================================================================================================
        private void LoadAppointments()
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
                    a.Slot_ID,
                    p.StudentORStaff_Number,
                    p.Full_Name,
                    p.Contact_Number,
                    p.Email,
                    a.Appointment_Type,
                    a.Appointment_Status,
                    a.Date_Created
                FROM appointments a
                INNER JOIN patients p 
                    ON a.Patient_ID = p.Patient_ID
                WHERE a.Appointment_Status = 'BOOKED'
                ORDER BY a.Date_Created DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter =
                            new MySqlDataAdapter(cmd);

                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        dvgAppointments.DataSource = table;

                        // Hide Slot_ID because it is only needed internally
                        if (dvgAppointments.Columns.Contains("Slot_ID"))
                        {
                            dvgAppointments.Columns["Slot_ID"].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading appointments:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //===================================================================================================================================================================
        // Show a password input dialog and return the entered password
        //===================================================================================================================================================================

        private string ShowPasswordDialog(string title, string message)
        {
            Form passwordForm = new Form();

            passwordForm.Text = title;
            passwordForm.Size = new Size(400, 240);
            passwordForm.StartPosition = FormStartPosition.CenterParent;
            passwordForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            passwordForm.MaximizeBox = false;
            passwordForm.MinimizeBox = false;

            Label lblMessage = new Label();

            lblMessage.Text = message;
            lblMessage.Location = new Point(25, 20);
            lblMessage.Size = new Size(330, 35);

            TextBox txtPassword = new TextBox();

            txtPassword.Location = new Point(25, 65);
            txtPassword.Size = new Size(330, 30);
            txtPassword.PasswordChar = '●';

            Button btnOK = new Button();

            btnOK.Text = "OK";
            btnOK.Location = new Point(110, 150);
            btnOK.Size = new Size(75, 30);
            btnOK.DialogResult = DialogResult.OK;

            Button btnForgot = new Button();

            btnForgot.Text = "Forgot Password?";
            btnForgot.Location = new Point(195, 150);
            btnForgot.Size = new Size(125, 30);

            Button btnCancel = new Button();

            btnCancel.Text = "Cancel";
            btnCancel.Location = new Point(150, 185);
            btnCancel.Size = new Size(75, 30);
            btnCancel.DialogResult = DialogResult.Cancel;

            // Forgot Password button
            btnForgot.Click += (sender, e) =>
            {
                passwordForm.DialogResult = DialogResult.None;

                string result = ShowForgotPasswordDialog();

                if (result == "SUCCESS")
                {
                    MessageBox.Show(
                        "Your password has been reset successfully.\n\n" +
                        "Please enter your new password.",
                        "Password Reset",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            };

            passwordForm.Controls.Add(lblMessage);
            passwordForm.Controls.Add(txtPassword);
            passwordForm.Controls.Add(btnOK);
            passwordForm.Controls.Add(btnForgot);
            passwordForm.Controls.Add(btnCancel);

            passwordForm.AcceptButton = btnOK;
            passwordForm.CancelButton = btnCancel;

            DialogResult result = passwordForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                return txtPassword.Text;
            }

            return null;
        }

        //===================================================================================================================================================================
        // Show the Forgot Password dialog and return "SUCCESS" if the password was reset successfully
        //===================================================================================================================================================================
        private string ShowForgotPasswordDialog()
        {
            Form resetForm = new Form();

            resetForm.Text = "Reset Password";
            resetForm.Size = new Size(430, 350);
            resetForm.StartPosition = FormStartPosition.CenterParent;
            resetForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            resetForm.MaximizeBox = false;
            resetForm.MinimizeBox = false;

            // -------------------------------------------------
            // Student/Staff Number
            // -------------------------------------------------

            Label lblStudentNumber = new Label();

            lblStudentNumber.Text = "Student/Staff Number:";
            lblStudentNumber.Location = new Point(25, 20);
            lblStudentNumber.Size = new Size(180, 25);

            TextBox txtStudentNumber = new TextBox();

            txtStudentNumber.Location = new Point(25, 45);
            txtStudentNumber.Size = new Size(350, 30);

            // -------------------------------------------------
            // Email
            // -------------------------------------------------

            Label lblEmail = new Label();

            lblEmail.Text = "MUT Email/Gmail:";
            lblEmail.Location = new Point(25, 85);
            lblEmail.Size = new Size(180, 25);

            TextBox txtEmail = new TextBox();

            txtEmail.Location = new Point(25, 110);
            txtEmail.Size = new Size(350, 30);

            // -------------------------------------------------
            // New Password
            // -------------------------------------------------

            Label lblNewPassword = new Label();

            lblNewPassword.Text = "New Password:";
            lblNewPassword.Location = new Point(25, 150);
            lblNewPassword.Size = new Size(180, 25);

            TextBox txtNewPassword = new TextBox();

            txtNewPassword.Location = new Point(25, 175);
            txtNewPassword.Size = new Size(350, 30);
            txtNewPassword.PasswordChar = '●';

            // -------------------------------------------------
            // Confirm Password
            // -------------------------------------------------

            Label lblConfirmPassword = new Label();

            lblConfirmPassword.Text = "Confirm Password:";
            lblConfirmPassword.Location = new Point(25, 215);
            lblConfirmPassword.Size = new Size(180, 25);

            TextBox txtConfirmPassword = new TextBox();

            txtConfirmPassword.Location = new Point(25, 240);
            txtConfirmPassword.Size = new Size(350, 30);
            txtConfirmPassword.PasswordChar = '●';

            // -------------------------------------------------
            // Reset Button
            // -------------------------------------------------

            Button btnReset = new Button();

            btnReset.Text = "Reset Password";
            btnReset.Location = new Point(200, 280);
            btnReset.Size = new Size(125, 30);

            // -------------------------------------------------
            // Cancel Button
            // -------------------------------------------------

            Button btnCancel = new Button();

            btnCancel.Text = "Cancel";
            btnCancel.Location = new Point(110, 280);
            btnCancel.Size = new Size(75, 30);

            // -------------------------------------------------
            // Reset Password Click
            // -------------------------------------------------

            btnReset.Click += (sender, e) =>
            {
                string studentNumber =
                    txtStudentNumber.Text.Trim(); 

                string email =
                    txtEmail.Text.Trim();

                string newPassword =
                    txtNewPassword.Text;

                string confirmPassword =
                    txtConfirmPassword.Text;

                // Check Student/Staff Number
                if (string.IsNullOrWhiteSpace(studentNumber))
                {
                    MessageBox.Show(
                        "Please enter your Student/Staff Number.",
                        "Missing Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtStudentNumber.Focus();
                    return;
                }

                // Check email
                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show(
                        "Please enter your MUT email.",
                        "Missing Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtEmail.Focus();
                    return;
                }

                // Check email format
                string mutEmailPattern =
                    @"^\d{8}\.live@mut\.ac\.za$";

                string gmailPattern =
                    @"^[a-zA-Z0-9._%+-]+@gmail\.com$";

                if (!Regex.IsMatch(email, mutEmailPattern, RegexOptions.IgnoreCase) &&
                    !Regex.IsMatch(email, gmailPattern, RegexOptions.IgnoreCase))
                {
                    MessageBox.Show(
                        "Please enter a valid email address.\n\n" +
                        "MUT Example:\n22552331.live@mut.ac.za\n\n" +
                        "Gmail Example:\nexample@gmail.com",
                        "Invalid Email",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtEmail.Focus();
                    return;
                }
                // Check new password
                if (string.IsNullOrWhiteSpace(newPassword))
                {
                    MessageBox.Show(
                        "Please enter a new password.",
                        "Missing Password",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNewPassword.Focus();
                    return;
                }

                // Password requirements
                bool hasUppercase =
                    Regex.IsMatch(newPassword, "[A-Z]");

                bool hasNumber =
                    Regex.IsMatch(newPassword, "[0-9]");

                bool hasSpecial =
                    Regex.IsMatch(newPassword, @"[@#$%^&*!]");

                if (!hasUppercase || !hasNumber || !hasSpecial)
                {
                    MessageBox.Show(
                        "Password must contain:\n\n" +
                        "• At least one uppercase letter\n" +
                        "• At least one number\n" +
                        "• At least one special character (@ # $ % ^ & *)",
                        "Invalid Password",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNewPassword.Focus();
                    return;
                }

                // Confirm password
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show(
                        "The passwords do not match.",
                        "Password Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtConfirmPassword.Focus();
                    return;
                }

                try
                {
                    DBConnection dbConnection =
                        new DBConnection();

                    using (MySqlConnection conn =
                        dbConnection.GetConnection())
                    {
                        conn.Open();

                        // -------------------------------------------------
                        // Check Student Number + Email
                        // -------------------------------------------------

                        string checkQuery = @"
                    SELECT COUNT(*)
                    FROM patients
                    WHERE StudentORStaff_Number = @StudentNumber
                    AND Email = @Email";

                        using (MySqlCommand cmd =
                            new MySqlCommand(checkQuery, conn))
                        {
                            cmd.Parameters.AddWithValue(
                                "@StudentNumber",
                                studentNumber);

                            cmd.Parameters.AddWithValue(
                                "@Email",
                                email);

                            int count =
                                Convert.ToInt32(cmd.ExecuteScalar());

                            if (count == 0)
                            {
                                MessageBox.Show(
                                    "The Student/Staff Number and email do not match our records.",
                                    "Verification Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                                return;
                            }
                        }

                        // -------------------------------------------------
                        // Update password
                        // -------------------------------------------------

                        string updateQuery = @"
                    UPDATE patients
                    SET PasswordCode = @Password
                    WHERE StudentORStaff_Number = @StudentNumber
                    AND Email = @Email";

                        using (MySqlCommand cmd =
                            new MySqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue(
                                "@Password",
                                newPassword);

                            cmd.Parameters.AddWithValue(
                                "@StudentNumber",
                                studentNumber);

                            cmd.Parameters.AddWithValue(
                                "@Email",
                                email);

                            cmd.ExecuteNonQuery();
                        }

                        resetForm.DialogResult =
                            DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error resetting password:\n" +
                        ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            };

            // -------------------------------------------------
            // Cancel button
            // -------------------------------------------------

            btnCancel.Click += (sender, e) =>
            {
                resetForm.DialogResult =
                    DialogResult.Cancel;
            };

            // -------------------------------------------------
            // Add controls
            // -------------------------------------------------

            resetForm.Controls.Add(lblStudentNumber);
            resetForm.Controls.Add(txtStudentNumber);

            resetForm.Controls.Add(lblEmail);
            resetForm.Controls.Add(txtEmail);

            resetForm.Controls.Add(lblNewPassword);
            resetForm.Controls.Add(txtNewPassword);

            resetForm.Controls.Add(lblConfirmPassword);
            resetForm.Controls.Add(txtConfirmPassword);

            resetForm.Controls.Add(btnReset);
            resetForm.Controls.Add(btnCancel);

            resetForm.AcceptButton = btnReset;
            resetForm.CancelButton = btnCancel;

            DialogResult result =
                resetForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                return "SUCCESS";
            }

            return null;
        }


        //===================================================================================================================================================================
        private void btnHome_Click(object sender, EventArgs e)
        {
            Reception_DashBoard dash = new Reception_DashBoard();
            dash.Show();
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
            Manage_Appointments manage = new Manage_Appointments();
            manage.Show();
            this.Hide();
        }

        //===================================================================================================================================================================
        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        //===================================================================================================================================================================
        //launch the Emergency form when the Emergency button is clicked
        //===================================================================================================================================================================
        private void btnEmergency_Click(object sender, EventArgs e)
        {
            Emegency em = new Emegency();
            em.Show();
            this.Hide();
        }

        //===================================================================================================================================================================
        //launch the Login form when the Logout button is clicked
        //===================================================================================================================================================================
        private void btnLogout_Click(object sender, EventArgs e)
        {

            btnLogout.Text = "Loading...";
            btnLogout.Enabled = false;

            btnLogout.BackColor = Color.Red;

            // Reset the View Appointments button color
            btnCancel.BackColor = Color.White;

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
                btnCancel.BackColor = Color.Blue;
            }
        }

        //===================================================================================================================================================================
        //load the form and set the Cancel button color to blue
        //===================================================================================================================================================================
        private void Cancel_Appointments_Load(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.Blue;
            LoadAppointments();
        }

        //===================================================================================================================================================================
        //search for appointments based on the Student/Staff Number entered in the search box
        //===================================================================================================================================================================
        private void btnSearch_Click(object sender, EventArgs e)
        {



            string searchNumber = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchNumber))
            {
                MessageBox.Show(
                    "Please enter a Student/Staff Number.",
                    "Search",
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
                    a.Appointment_ID,
                    p.StudentORStaff_Number,
                    p.Full_Name,
                    p.Contact_Number,
                    p.Email,
                    a.Appointment_Type,
                    a.Appointment_Status,
                    a.Date_Created
                FROM appointments a
                INNER JOIN patients p 
                    ON a.Patient_ID = p.Patient_ID
                WHERE p.StudentORStaff_Number = @StudentNumber
                  AND a.Appointment_Status = 'BOOKED'
                ORDER BY a.Date_Created DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentNumber", searchNumber);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        dvgAppointments.DataSource = table;

                        if (table.Rows.Count == 0)
                        {
                            MessageBox.Show(
                                "No appointments found for Student/Staff Number: "
                                + searchNumber,
                                "Search Result",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            LoadAppointments();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error searching for appointment:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }


        //===================================================================================================================================================================
        //button click event to cancel the selected appointment after verifying the patient's password
        //===================================================================================================================================================================
        private void button1_Click(object sender, EventArgs e)
        {
            // ---------------------------------------------------------
            // Start loading
            // ---------------------------------------------------------
            button1.Text = "Loading...";
            button1.Enabled = false;

            try
            {
                // ---------------------------------------------------------
                // 1. Check if an appointment was selected
                // ---------------------------------------------------------
                if (selectedAppointmentID == 0)
                {
                    MessageBox.Show(
                        "Please select an appointment to cancel.",
                        "No Appointment Selected",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // ---------------------------------------------------------
                // 2. Create database connection
                // ---------------------------------------------------------
                DBConnection dbConnection = new DBConnection();

                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();

                    // ---------------------------------------------------------
                    // 3. Get appointment and patient information
                    // ---------------------------------------------------------
                    string studentNumber = "";
                    string patientName = "";
                    string storedPassword = "";
                    string appointmentStatus = "";

                    string query = @"
                SELECT
                    p.StudentORStaff_Number,
                    p.Full_Name,
                    p.PasswordCode,
                    a.Appointment_Status
                FROM appointments a
                INNER JOIN patients p
                    ON a.Patient_ID = p.Patient_ID
                WHERE a.Appointment_ID = @AppointmentID
                LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@AppointmentID",
                            selectedAppointmentID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // -------------------------------------------------
                            // Appointment not found
                            // -------------------------------------------------
                            if (!reader.Read())
                            {
                                MessageBox.Show(
                                    "The selected appointment could not be found.",
                                    "Appointment Not Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                return;
                            }

                            // -------------------------------------------------
                            // Read patient information
                            // -------------------------------------------------
                            studentNumber =
                                reader["StudentORStaff_Number"] == DBNull.Value
                                ? ""
                                : reader["StudentORStaff_Number"].ToString();

                            patientName =
                                reader["Full_Name"] == DBNull.Value
                                ? ""
                                : reader["Full_Name"].ToString();

                            storedPassword =
                                reader["PasswordCode"] == DBNull.Value
                                ? ""
                                : reader["PasswordCode"].ToString();

                            appointmentStatus =
                                reader["Appointment_Status"] == DBNull.Value
                                ? ""
                                : reader["Appointment_Status"].ToString();
                        }
                    }

                    // ---------------------------------------------------------
                    // 4. Check appointment status
                    // ---------------------------------------------------------
                    if (!appointmentStatus.Equals(
                            "BOOKED",
                            StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show(
                            "Only booked appointments can be cancelled.",
                            "Cannot Cancel",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    // ---------------------------------------------------------
                    // 5. Ask for patient's password
                    // ---------------------------------------------------------
                    string enteredPassword = ShowPasswordDialog(
                        "Cancel Appointment",
                        "Enter the patient's password to continue:");

                    // ---------------------------------------------------------
                    // User pressed Cancel
                    // ---------------------------------------------------------
                    if (enteredPassword == null)
                    {
                        return;
                    }

                    // ---------------------------------------------------------
                    // 6. Check password
                    // ---------------------------------------------------------
                    if (enteredPassword != storedPassword)
                    {
                        MessageBox.Show(
                            "Incorrect password.\n\n" +
                            "The appointment was not cancelled.",
                            "Incorrect Password",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }

                    // ---------------------------------------------------------
                    // 7. Ask for final confirmation
                    // ---------------------------------------------------------
                    DialogResult confirm = MessageBox.Show(
                        "Are you sure you want to cancel this appointment?\n\n" +
                        "Patient: " + patientName + "\n" +
                        "Student/Staff Number: " + studentNumber,
                        "Confirm Cancellation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirm != DialogResult.Yes)
                    {
                        return;
                    }

                    // ---------------------------------------------------------
                    // 8. Start database transaction
                    // ---------------------------------------------------------
                    using (MySqlTransaction transaction =
                           conn.BeginTransaction())
                    {
                        try
                        {
                            // -------------------------------------------------
                            // 9. Double-check appointment is still BOOKED
                            // -------------------------------------------------
                            string checkStatusQuery = @"
                        SELECT Appointment_Status
                        FROM appointments
                        WHERE Appointment_ID = @AppointmentID
                        LIMIT 1";

                            using (MySqlCommand cmd = new MySqlCommand(
                                checkStatusQuery,
                                conn,
                                transaction))
                            {
                                cmd.Parameters.AddWithValue(
                                    "@AppointmentID",
                                    selectedAppointmentID);

                                object statusResult = cmd.ExecuteScalar();

                                if (statusResult == null ||
                                    statusResult == DBNull.Value)
                                {
                                    MessageBox.Show(
                                        "The appointment could not be found.",
                                        "Appointment Not Found",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);

                                    transaction.Rollback();
                                    return;
                                }

                                string currentStatus =
                                    statusResult.ToString();

                                if (!currentStatus.Equals(
                                        "BOOKED",
                                        StringComparison.OrdinalIgnoreCase))
                                {
                                    MessageBox.Show(
                                        "This appointment is no longer booked.",
                                        "Cannot Cancel",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);

                                    transaction.Rollback();
                                    return;
                                }
                            }

                            // -------------------------------------------------
                            // 10. Change appointment status
                            // -------------------------------------------------
                            string updateQuery = @"
                        UPDATE appointments
                        SET Appointment_Status = 'CANCELLED'
                        WHERE Appointment_ID = @AppointmentID";

                            using (MySqlCommand cmd = new MySqlCommand(
                                updateQuery,
                                conn,
                                transaction))
                            {
                                cmd.Parameters.AddWithValue(
                                    "@AppointmentID",
                                    selectedAppointmentID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected == 0)
                                {
                                    throw new Exception(
                                        "The appointment could not be cancelled.");
                                }
                            }

                            // -------------------------------------------------
                            // 11. Save cancellation in appointment history
                            // -------------------------------------------------
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
                            'CANCELLED',
                            NOW(),
                            'Reception'
                        )";

                            using (MySqlCommand cmd = new MySqlCommand(
                                historyQuery,
                                conn,
                                transaction))
                            {
                                cmd.Parameters.AddWithValue(
                                    "@AppointmentID",
                                    selectedAppointmentID);

                                cmd.ExecuteNonQuery();
                            }

                            // -------------------------------------------------
                            // 12. Commit transaction
                            // -------------------------------------------------
                            transaction.Commit();

                            // -------------------------------------------------
                            // 13. Show success message
                            // -------------------------------------------------
                            MessageBox.Show(
                                "Appointment cancelled successfully.",
                                "Cancellation Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            // -------------------------------------------------
                            // 14. Clear selected appointment
                            // -------------------------------------------------
                            selectedAppointmentID = 0;

                            // -------------------------------------------------
                            // 15. Reload appointments
                            // -------------------------------------------------
                            LoadAppointments();
                        }
                        catch
                        {
                            try
                            {
                                transaction.Rollback();
                            }
                            catch
                            {
                                // Ignore rollback error
                            }

                            throw;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // ---------------------------------------------------------
                // Database error
                // ---------------------------------------------------------
                MessageBox.Show(
                    "A database error occurred.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // ---------------------------------------------------------
                // Other error
                // ---------------------------------------------------------
                MessageBox.Show(
                    "Error cancelling appointment.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                // ---------------------------------------------------------
                // ALWAYS restore the button
                // ---------------------------------------------------------
                button1.Text = "Cancel Appointment";
                button1.Enabled = true;
            }
        }

        //===================================================================================================================================================================
        //load the selected appointment ID when a cell in the DataGridView is clicked
        //===================================================================================================================================================================
        private void dvgAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            selectedAppointmentID = Convert.ToInt32(
                dvgAppointments.Rows[e.RowIndex]
                .Cells["Appointment_ID"].Value);
        }

        //===================================================================================================================================================================
        //clear the search box and reload all booked appointments when the Clear button is clicked
        //===================================================================================================================================================================
        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadAppointments(); 
        }
    }
}
