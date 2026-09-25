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
    public partial class CheckPatient : Form
    {
        public CheckPatient()
        {
            InitializeComponent();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            // =========================================================
            // START LOADING
            // =========================================================
            btnCheck.Text = "Loading...";
            btnCheck.Enabled = false;

            try
            {
                // =====================================================
                // 1. GET STUDENT/STAFF NUMBER
                // =====================================================
                string studentStaffNumber = txtCheck.Text.Trim();

                // =====================================================
                // 2. CHECK IF TEXTBOX IS EMPTY
                // =====================================================
                if (string.IsNullOrWhiteSpace(studentStaffNumber))
                {
                    MessageBox.Show(
                        "Please enter your Student/Staff Number.",
                        "Missing Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtCheck.Focus();
                    return;
                }

                // =====================================================
                // 3. CHECK IF NUMBER IS EXACTLY 8 DIGITS
                // =====================================================
                if (!Regex.IsMatch(studentStaffNumber, @"^\d{8}$"))
                {
                    MessageBox.Show(
                        "Student/Staff Number must be exactly 8 numbers.",
                        "Invalid Student/Staff Number",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtCheck.Focus();
                    return;
                }

                // =====================================================
                // 4. CREATE DATABASE CONNECTION
                // =====================================================
                DBConnection db = new DBConnection();

                string query = @"
            SELECT 
                Patient_ID,
                StudentORStaff_Number,
                Full_Name,
                Contact_Number,
                PasswordCode,
                Email
            FROM patients
            WHERE StudentORStaff_Number = @StudentStaffNumber
            LIMIT 1";

                // =====================================================
                // 5. OPEN DATABASE CONNECTION
                // =====================================================
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // =================================================
                    // 6. CREATE SQL COMMAND
                    // =================================================
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@StudentStaffNumber",
                            studentStaffNumber);

                        // =============================================
                        // 7. READ PATIENT
                        // =============================================
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // =========================================
                            // PATIENT FOUND
                            // =========================================
                            if (reader.Read())
                            {
                                int patientId =
                                    Convert.ToInt32(reader["Patient_ID"]);

                                string number =
                                    reader["StudentORStaff_Number"].ToString();

                                string fullName =
                                    reader["Full_Name"].ToString();

                                string contactNumber =
                                    reader["Contact_Number"].ToString();

                                string passwordCode =
                                    reader["PasswordCode"].ToString();

                                string email =
                                    reader["Email"].ToString();

                                // =====================================
                                // SHOW SUCCESS MESSAGE
                                // =====================================
                                MessageBox.Show(
                                    "Patient found!",
                                    "Patient Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                // =====================================
                                // OPEN BOOK APPOINTMENT
                                // =====================================
                                Book_Appointment book =
                                    new Book_Appointment(
                                        patientId,
                                        number,
                                        fullName,
                                        contactNumber,
                                        passwordCode,
                                        email);

                                book.Show();

                                // Hide current form
                                this.Hide();
                            }
                            else
                            {
                                // =====================================
                                // PATIENT NOT FOUND
                                // =====================================

                                MessageBox.Show(
                                    "Patient not found in the system.\n\n" +
                                    "Please enter your details.",
                                    "Patient Not Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                // =====================================
                                // OPEN BOOK APPOINTMENT
                                // =====================================
                                Book_Appointment book =
                                    new Book_Appointment(
                                        studentStaffNumber);

                                book.Show();

                                // Hide current form
                                this.Hide();
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // =====================================================
                // MYSQL DATABASE ERROR
                // =====================================================
                MessageBox.Show(
                    "A database error occurred.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // =====================================================
                // OTHER ERROR
                // =====================================================
                MessageBox.Show(
                    "An unexpected error occurred.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                // =====================================================
                // ALWAYS STOP LOADING
                // =====================================================
                btnCheck.Text = "Check";
                btnCheck.Enabled = true;
            }
        }
    }
        
}
    

