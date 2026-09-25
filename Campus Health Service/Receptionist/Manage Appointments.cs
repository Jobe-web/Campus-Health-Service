using Campus_Health_Service;
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

namespace Receptionist
{
    public partial class Manage_Appointments : Form
    {
        private int selectedAppointmentID = 0;
        private int selectedSlotID = 0;
        public Manage_Appointments()
        {
            InitializeComponent();
        }

        //===================================================================================================================================================================
        // Load appointments when the form loads
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

                        dgvAppointments.DataSource = table;

                        // Hide Slot_ID because it is only needed internally
                        if (dgvAppointments.Columns.Contains("Slot_ID"))
                        {
                            dgvAppointments.Columns["Slot_ID"].Visible = false;
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

        //======================================================================================================================================================================
        // Load available reschedule times based on the selected date
        //======================================================================================================================================================================
        private void LoadAvailableRescheduleTimes()
        {
            cmbTime.Items.Clear();

            try
            {
                DBConnection dbConnection = new DBConnection();

                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    TIME(s.Start_Time) AS StartTime
                FROM appointments a
                INNER JOIN appointment_slots s
                    ON a.Slot_ID = s.Slot_ID
                WHERE DATE(s.Slot_date) = @SelectedDate
                AND a.Appointment_Status = 'BOOKED'
                AND a.Appointment_ID <> @AppointmentID";

                    List<string> bookedTimes = new List<string>();

                    using (MySqlCommand cmd =
                        new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@SelectedDate",
                            dtpDate.Value.Date);

                        cmd.Parameters.AddWithValue(
                            "@AppointmentID",
                            selectedAppointmentID);

                        using (MySqlDataReader reader =
                            cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TimeSpan startTime =
                                    reader.GetTimeSpan(
                                        reader.GetOrdinal("StartTime"));

                                bookedTimes.Add(
                                    startTime.ToString(@"hh\:mm"));
                            }
                        }
                    }

                    // 08:00 - 09:00 through 16:00 - 17:00
                    for (int hour = 8; hour < 17; hour++)
                    {
                        // Skip lunch time: 12:00 - 13:00
                        if (hour == 12)
                            continue;

                        string startTime =
                            hour.ToString("00") + ":00";

                        string endTime =
                            (hour + 1).ToString("00") + ":00";

                        string displayTime =
                            startTime + " - " + endTime;

                        // Only add if it is NOT booked
                        if (!bookedTimes.Contains(startTime))
                        {
                            cmbTime.Items.Add(displayTime);
                        }
                    }
                }

                // IMPORTANT: don't automatically pick a time
                cmbTime.SelectedIndex = -1;
                cmbTime.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading available times:\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //===================================================================================================================================================================
        // Class to represent a time item in the ComboBox
        //===================================================================================================================================================================
        private class TimeItem
        {
            public int SlotID { get; set; }
            public string Time { get; set; }

            public override string ToString()
            {
                return Time;
            }
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

        }

        //===================================================================================================================================================================
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel_Appointments cancel = new Cancel_Appointments();
            cancel.Show();
            this.Hide();
        }

        //===================================================================================================================================================================
        private void btnEmergency_Click(object sender, EventArgs e)
        {
            Emegency em = new Emegency();
            em.Show();
            this.Hide();
        }

        //===================================================================================================================================================================
        private void btnLogout_Click(object sender, EventArgs e)
        {

            btnLogout.Text = "Loading...";
            btnLogout.Enabled = false;

            btnLogout.BackColor = Color.Red;

            // Reset the View Appointments button color
            btnManageAppointments.BackColor = Color.White;

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
                btnManageAppointments.BackColor = Color.Blue;
            }
        }

        //===================================================================================================================================================================

        private void Manage_Appointments_Load(object sender, EventArgs e)
        {
            btnManageAppointments.BackColor = Color.Blue;
            LoadAppointments();
        }

        //===================================================================================================================================================================
        // Search for appointments by Student/Staff Number
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

                        dgvAppointments.DataSource = table;

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
        // Reschedule the selected appointment to a new time
        //===================================================================================================================================================================
        private void btnReschedule_Click(object sender, EventArgs e)
        {
            // =========================================================
            // START LOADING
            // =========================================================
            btnReschedule.Text = "Loading...";
            btnReschedule.Enabled = false;

            try
            {
                // =====================================================
                // 1. CHECK APPOINTMENT
                // =====================================================
                if (selectedAppointmentID == 0)
                {
                    MessageBox.Show(
                        "Please select an appointment first.",
                        "No Appointment Selected",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // =====================================================
                // 2. CHECK TIME
                // =====================================================
                if (cmbTime.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(cmbTime.Text))
                {
                    MessageBox.Show(
                        "Please select a new appointment time.",
                        "Missing Time",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbTime.Focus();
                    return;
                }

                // =====================================================
                // 3. GET DATE
                // =====================================================
                DateTime selectedDate = dtpDate.Value.Date;

                // =====================================================
                // 4. GET TIME
                // =====================================================
                string selectedTime = cmbTime.SelectedItem.ToString();

                string[] timeParts = selectedTime.Split('-');

                if (timeParts.Length != 2)
                {
                    MessageBox.Show(
                        "Invalid time format selected.",
                        "Invalid Time",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // =====================================================
                // 5. CONVERT TIME
                // =====================================================
                TimeSpan startTime;
                TimeSpan endTime;

                bool startValid = TimeSpan.TryParse(
                    timeParts[0].Trim(),
                    out startTime);

                bool endValid = TimeSpan.TryParse(
                    timeParts[1].Trim(),
                    out endTime);

                if (!startValid || !endValid)
                {

                    MessageBox.Show(
                        "Unable to read the selected appointment time.",
                        "Invalid Time",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                MessageBox.Show(
    "Selected Date: " + dtpDate.Value.Date.ToString("yyyy-MM-dd") +
    "\nStart Time: " + startTime.ToString() +
    "\nEnd Time: " + endTime.ToString(),
    "Check Selected Slot",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information);

                // =====================================================
                // 6. CONNECT TO DATABASE
                // =====================================================
                DBConnection dbConnection = new DBConnection();

                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();

                    // =================================================
                    // 7. START TRANSACTION
                    // =================================================
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // =============================================
                            // 8. CHECK THAT APPOINTMENT EXISTS
                            // =============================================
                            string getAppointmentQuery = @"
                        SELECT Appointment_Type
                        FROM appointments
                        WHERE Appointment_ID = @AppointmentID";

                            string service = "";

                            using (MySqlCommand cmd = new MySqlCommand(
                                getAppointmentQuery,
                                conn,
                                transaction))
                            {
                                cmd.Parameters.AddWithValue(
                                    "@AppointmentID",
                                    selectedAppointmentID);

                                object result = cmd.ExecuteScalar();

                                if (result == null || result == DBNull.Value)
                                {
                                    MessageBox.Show(
                                        "The selected appointment could not be found.",
                                        "Appointment Not Found",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);

                                    transaction.Rollback();
                                    return;
                                }

                                service = result.ToString();
                            }

                            // =============================================
                            // 9. CHECK IF TIME IS ALREADY BOOKED
                            // =============================================
                            string checkBookedQuery = @"
                        SELECT COUNT(*)
                        FROM appointments a
                        INNER JOIN appointment_slots s
                            ON a.Slot_ID = s.Slot_ID
                        WHERE DATE(s.Slot_date) = @SelectedDate
                        AND TIME(s.Start_Time) = @StartTime
                        AND TIME(s.End_Time) = @EndTime
                        AND a.Appointment_Status = 'BOOKED'
                        AND a.Appointment_ID <> @AppointmentID";

                            using (MySqlCommand cmd = new MySqlCommand(
                                checkBookedQuery,
                                conn,
                                transaction))
                            {
                                cmd.Parameters.AddWithValue(
                                    "@SelectedDate",
                                    selectedDate);

                                cmd.Parameters.AddWithValue(
                                    "@StartTime",
                                    startTime);

                                cmd.Parameters.AddWithValue(
                                    "@EndTime",
                                    endTime);

                                cmd.Parameters.AddWithValue(
                                    "@AppointmentID",
                                    selectedAppointmentID);

                                int bookedCount =
                                    Convert.ToInt32(cmd.ExecuteScalar());

                                if (bookedCount > 0)
                                {
                                    MessageBox.Show(
                                        "The selected date and time is already booked.\n\n" +
                                        "Please choose another available time.",
                                        "Time Already Booked",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);

                                    transaction.Rollback();
                                    return;
                                }
                            }

                            // =============================================
                            // 10. FIND THE NEW SLOT
                            // =============================================
                            string findSlotQuery = @"
                                    SELECT Slot_ID
                                    FROM appointment_slots
                                    WHERE DATE(Slot_date) = @SelectedDate
                                    AND TIME(Start_Time) = @StartTime
                                    AND TIME(End_Time) = @EndTime
                                    LIMIT 1";

                            int newSlotID = 0;

                            using (MySqlCommand cmd = new MySqlCommand(
                                findSlotQuery,
                                conn,
                                transaction))
                            {
                                cmd.Parameters.AddWithValue(
                                    "@SelectedDate",
                                    selectedDate);

                                cmd.Parameters.AddWithValue(
                                    "@StartTime",
                                    startTime);

                                cmd.Parameters.AddWithValue(
                                    "@EndTime",
                                    endTime);

                                object result = cmd.ExecuteScalar();

                                if (result != null && result != DBNull.Value)
                                {
                                    newSlotID = Convert.ToInt32(result);
                                }
                            }

                            // If no slot exists, create one for the selected date/time
                            if (newSlotID == 0)
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
                                            @SelectedDate,
                                            @Service,
                                            @StartTime,
                                            @EndTime,
                                            'Receptionist'
                                       );

                                       SELECT LAST_INSERT_ID();";

                                using (MySqlCommand cmd = new MySqlCommand(
                                    createSlotQuery,
                                    conn,
                                    transaction))
                                {
                                    cmd.Parameters.AddWithValue(
                                        "@SelectedDate",
                                        selectedDate);

                                    cmd.Parameters.AddWithValue(
                                        "@Service",
                                        service);

                                    cmd.Parameters.AddWithValue(
                                        "@StartTime",
                                        startTime);

                                    cmd.Parameters.AddWithValue(
                                        "@EndTime",
                                        endTime);

                                    newSlotID = Convert.ToInt32(cmd.ExecuteScalar());
                                }
                            }

                            // =============================================
                            // 11. UPDATE APPOINTMENT
                            // =============================================
                            string updateQuery = @"
                        UPDATE appointments
                        SET Slot_ID = @NewSlotID
                        WHERE Appointment_ID = @AppointmentID";

                            using (MySqlCommand cmd = new MySqlCommand(
                                updateQuery,
                                conn,
                                transaction))
                            {
                                cmd.Parameters.AddWithValue(
                                    "@NewSlotID",
                                    newSlotID);

                                cmd.Parameters.AddWithValue(
                                    "@AppointmentID",
                                    selectedAppointmentID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected == 0)
                                {
                                    MessageBox.Show(
                                        "The appointment could not be updated.",
                                        "Update Failed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);

                                    transaction.Rollback();
                                    return;
                                }
                            }

                            // =============================================
                            // 12. SAVE CHANGES
                            // =============================================
                            transaction.Commit();

                            // =============================================
                            // 13. SUCCESS
                            // =============================================
                            MessageBox.Show(
                                "Appointment rescheduled successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            // =============================================
                            // 14. RESET CONTROLS
                            // =============================================
                            selectedAppointmentID = 0;
                            cmbTime.SelectedIndex = -1;

                            // If you have a method to refresh your table,
                            // uncomment the next line:
                            //
                            //LoadAppointments();
                        }
                        catch (Exception ex)
                        {
                            // =============================================
                            // DATABASE ERROR
                            // =============================================
                            try
                            {
                                transaction.Rollback();
                            }
                            catch
                            {
                                // Ignore rollback error
                            }

                            MessageBox.Show(
                                "Could not reschedule the appointment.\n\n" +
                                ex.Message,
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // =====================================================
                // GENERAL ERROR
                // =====================================================
                MessageBox.Show(
                    "Something went wrong.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                // =====================================================
                // ALWAYS RESET THE BUTTON
                // =====================================================
                btnReschedule.Text = "Reschedule Appointment";
                btnReschedule.Enabled = true;
            }
        }

        //===================================================================================================================================================================
        // Handle cell click event to get the selected appointment ID
        //===================================================================================================================================================================
        private void dgvAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvAppointments.Rows[e.RowIndex];

            selectedAppointmentID = Convert.ToInt32(
                row.Cells["Appointment_ID"].Value);

            selectedSlotID = Convert.ToInt32(
                row.Cells["Slot_ID"].Value);

            // Get the appointment date
            using (MySqlConnection conn =
                new DBConnection().GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT s.Slot_date
            FROM appointment_slots s
            INNER JOIN appointments a
                ON a.Slot_ID = s.Slot_ID
            WHERE a.Appointment_ID = @AppointmentID";

                using (MySqlCommand cmd =
                    new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@AppointmentID",
                        selectedAppointmentID);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        dtpDate.Value = Convert.ToDateTime(result);
                    }
                }
            }
        }

        //===================================================================================================================================================================
        // Load available reschedule times when the date picker value changes
        //===================================================================================================================================================================
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadAvailableRescheduleTimes();
        }

        //===================================================================================================================================================================
        //clear the search box and reload all appointments
        //===================================================================================================================================================================
        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void cmbTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
