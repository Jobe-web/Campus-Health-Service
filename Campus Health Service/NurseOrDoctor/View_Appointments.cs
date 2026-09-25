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
    public partial class View_Appointments : Form
    {
        public View_Appointments()
        {
            InitializeComponent();
        }

        //============================================================================================================================================================


        private void LoadAppointments()
        {
            try
            {
                DBConnection dbConn = new DBConnection();
                using (MySqlConnection conn = dbConn.GetConnection())
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
                ORDER BY a.Date_Created DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        dgvAppointments.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading appointments: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //===========================================================================================================================================================

        // ============================================================
        // LOAD APPOINTMENTS FOR SELECTED DATE
        // This method loads appointments into the DataGridView
        // based on the date selected in dtpAppointmentDate.
        // ============================================================
        private void LoadAppointmentsByDate()
        {
            try
            {
                // Create a connection to the MySQL database
                DBConnection dbConn = new DBConnection();
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();

                    // SQL query to retrieve appointment and patient details
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
                WHERE DATE(a.Date_Created) = @selectedDate
                ORDER BY a.Date_Created ASC";

                    // Create the MySQL command
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Get the date selected by the nurse
                        cmd.Parameters.AddWithValue(
                            "@selectedDate",
                            dtpAppointmentDate.Value.Date);

                        // Create a data adapter
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                        // Create a table to hold the appointment records
                        DataTable table = new DataTable();

                        // Execute the query and fill the table
                        adapter.Fill(table);

                        // Display the records in the DataGridView
                        dgvAppointments.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                // Display an error message if something goes wrong
                MessageBox.Show(
                    "Error loading appointments: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //===========================================================================================================================================================

        // ============================================================
        // LOAD APPOINTMENTS BY STATUS
        // Loads appointment records into dgvAppointments based on
        // the status selected in cmbStatus.
        // ============================================================
        private void LoadAppointmentsByStatus()
        {
            try
            {
                if (cmbStatus.SelectedItem == null)
                    return;

                string selectedStatus =
                    cmbStatus.SelectedItem.ToString().Trim();

                DBConnection dbConn = new DBConnection();

                using (MySqlConnection conn = dbConn.GetConnection())
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
                LEFT JOIN followup f
                    ON a.Appointment_ID = f.Appointment_ID
                WHERE
                    (
                        UPPER(TRIM(a.Appointment_Status)) =
                        UPPER(TRIM(@status))
                    )
                    AND
                    (
                        UPPER(TRIM(@status)) <> 'FOLLOW-UP SCHEDULED'
                        OR f.Followup_Date = @followupDate
                    )
                ORDER BY a.Date_Created ASC";

                    using (MySqlCommand cmd =
                        new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@status",
                            selectedStatus);

                        cmd.Parameters.AddWithValue(
                            "@followupDate",
                            dtpAppointmentDate.Value.Date);

                        MySqlDataAdapter adapter =
                            new MySqlDataAdapter(cmd);

                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        dgvAppointments.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading appointments by status: "
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //===========================================================================================================================================================
        // ============================================================
        // LOAD APPOINTMENTS ON FORM LOAD
        // This event handler is triggered when the form loads.
        // It calls the LoadAppointments method to populate the
        // DataGridView with all appointments.
        // ============================================================
        private void View_Appointments_Load(object sender, EventArgs e)
        {
            btnViewAppointments.BackColor = Color.Blue;
            LoadAppointments();
        }
        //===========================================================================================================================================================

        private void grpAppointmentDetails_Enter(object sender, EventArgs e)
        {

        }

        //===========================================================================================================================================================
        // ============================================================
        // DATE CHANGED
        // Loads appointments when the nurse selects a date.
        // ============================================================
        private void dtpAppointmentDate_ValueChanged(object sender, EventArgs e)
        {
            LoadAppointmentsByDate();
        }

        //===========================================================================================================================================================
        // ============================================================
        // STATUS CHANGED
        // Loads appointments when the nurse selects a status.
        // ============================================================
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbStatus.SelectedIndex == -1)
                return;
            LoadAppointmentsByStatus();

        }

        //===========================================================================================================================================================
        // ============================================================
        // REFRESH BUTTON
        // Refreshes the appointment table and reloads the appointments
        // for the currently selected date.
        // ============================================================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Clear the selected status
            cmbStatus.SelectedIndex = 0;

            // Reload appointments 
            LoadAppointments();
        }

        //===========================================================================================================================================================
        // ============================================================
        // APPOINTMENT ROW CLICK
        // Loads the selected appointment information from the
        // DataGridView into the corresponding controls.
        // ============================================================
        private void dgvAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Make sure a valid row was clicked
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAppointments.Rows[e.RowIndex];

                // Load appointment details
                txtAppointmentID.Text =
                    row.Cells["Appointment_ID"].Value?.ToString();

                txtStudentNumber.Text =
                    row.Cells["StudentORStaff_Number"].Value?.ToString();

                txtPatientName.Text =
                    row.Cells["Full_Name"].Value?.ToString();

                txtService.Text =
                    row.Cells["Appointment_Type"].Value?.ToString();

                // Load the appointment status into cmbStatus
                cmbStatus2.Text =
                    row.Cells["Appointment_Status"].Value?.ToString();

                // Load the appointment date
                if (row.Cells["Date_Created"].Value != DBNull.Value)
                {
                    dtpAppointmentDate2.Value =
                        Convert.ToDateTime(row.Cells["Date_Created"].Value);
                }
            }
        }

        //===========================================================================================================================================================
        // ============================================================
        // SAVE BUTTON - UPDATE APPOINTMENT STATUS
        // Updates the selected appointment with the new status
        // chosen in cmbNewStatus.
        // ============================================================
        private void btnSaveStatus_Click(object sender, EventArgs e)
        {
            // Check that an appointment has been selected
            if (string.IsNullOrWhiteSpace(txtAppointmentID.Text))
            {
                MessageBox.Show(
                    "Please select an appointment first.",
                    "No Appointment Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Check that a status has been selected
            if (cmbNewStatus.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select an appointment status.",
                    "Missing Status",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbNewStatus.Focus();
                return;
            }

            try
            {
                DBConnection dbConn = new DBConnection();

                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();

                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Get appointment ID
                            int appointmentID =
                                Convert.ToInt32(txtAppointmentID.Text);

                            // Get selected status
                            string newStatus =
                                cmbNewStatus.SelectedItem.ToString();

                            // 1. Update appointment status
                            string updateQuery = @"
                        UPDATE appointments
                        SET Appointment_Status = @status
                        WHERE Appointment_ID = @appointmentID";

                            using (MySqlCommand cmd = new MySqlCommand(
                                updateQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue(
                                    "@appointmentID",
                                    appointmentID);

                                cmd.Parameters.AddWithValue(
                                    "@status",
                                    newStatus);

                                cmd.ExecuteNonQuery();
                            }

                            // 2. Add the action to appointment history
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
                            @actionType,
                            NOW(),
                            @createdBy
                        )";

                            using (MySqlCommand cmd = new MySqlCommand(
                                historyQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue(
                                    "@appointmentID",
                                    appointmentID);

                                cmd.Parameters.AddWithValue(
                                    "@actionType",
                                    newStatus);

                                cmd.Parameters.AddWithValue(
                                    "@createdBy",
                                    "Nurse/Doctor");

                                cmd.ExecuteNonQuery();
                            }

                            // 3. Save both changes
                            transaction.Commit();

                            MessageBox.Show(
                                "Appointment status updated and history saved successfully.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            // Refresh appointment table
                            LoadAppointments();

                            // Optional: clear the fields
                            txtAppointmentID.Clear();
                            cmbNewStatus.SelectedIndex = -1;
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
                    "Error updating appointment status:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //===========================================================================================================================================================
        //===========================================================
        // PATIENT RECORDS BUTTON
        // Navigates to the Patient Records form.
        //===========================================================
        private void button3_Click(object sender, EventArgs e)
        {
            Patient_Records patientRecordsForm = new Patient_Records();
            patientRecordsForm.Show();
            this.Hide();
        }

        //===========================================================================================================================================================
        //===========================================================
        // DASHBOARD BUTTON
        // Navigates back to the Nurse Dashboard form.
        //===========================================================
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            NursesOrDoctor_DashBoard nurseDashboardForm = new NursesOrDoctor_DashBoard();

            nurseDashboardForm.Show();
            this.Hide();
        }

        //===========================================================================================================================================================
        //===========================================================
        // LOG OUT BUTTON
        // Logs the nurse out and returns to the LogIn form.
        //===========================================================
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            btnLogOut.Text = "Loading...";
            btnLogOut.Enabled = false;

            btnLogOut.BackColor = Color.Red;

            // Reset the View Appointments button color
            btnViewAppointments.BackColor = Color.White;

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
                btnLogOut.Text = "Log Out";
                btnLogOut.Enabled = true;
                btnLogOut.BackColor = Color.White;
                // If the user selects No, reset the button color
                btnViewAppointments.BackColor = Color.Blue;
            }
        }

        private void btnViewAppointments_Click(object sender, EventArgs e)
        {

        }

        //===========================================================================================================================================================
        //===========================================================
        // FOLLOW-UP BUTTON
        // Navigates to the Follow-Up form.
        //===========================================================
        private void btnFollowUp_Click(object sender, EventArgs e)
        {
            Follow_Up followUpForm = new Follow_Up();
            followUpForm.Show();
            this.Hide();
        }

        private void cmbStatus2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
