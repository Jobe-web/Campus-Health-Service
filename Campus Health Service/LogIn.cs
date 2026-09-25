using Campus_Health_Service.Manager;
using Campus_Health_Service.Nurse;
using MySql.Data.MySqlClient;
using Receptionist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campus_Health_Service
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();


        }

        private void LoadRole()
        {
            cmbRole.Items.Clear();

            cmbRole.Items.Add("Receptionist");
            cmbRole.Items.Add("Nurse/Doctor");
            cmbRole.Items.Add("Manager");

            cmbRole.SelectedIndex = 0;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            LoadRole();
            txtPassword.PasswordChar = '*';
            cbShowP.Checked = false;
        }
        //=============================================================================================================================================================================
        //===========================================================================================================================
        // Event handler for the login button click
        // This method validates the user input and attempts to log in the user based on the provided credentials.
        // If the login is successful, it opens the appropriate dashboard based on the user's role.
        // If the login fails, it displays an error message and prompts the user to re-enter their credentials.
        //===========================================================================================================================

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Loading...";
            button1.Enabled = false;

            // Validate Username
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show(
                    "Please enter your username.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsername.Focus();

                button1.Text = "LogIn"; 
                button1.Enabled = true; 
                    return;
            }

            // Validate Password
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show(
                    "Please enter your password.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();
                return;
            }

            // Validate Role
            if (cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select your role.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbRole.Focus();
                return;
            }

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem.ToString();

            try
            {
                DBConnection db = new DBConnection();

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT Staff_ID, Full_Name, Role
                             FROM staff_users
                             WHERE Username = @username
                             AND PasswordCode = @password
                             AND Role = @role
                             LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@role", role);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string fullName = reader["Full_Name"].ToString();
                                string loggedInRole = reader["Role"].ToString();

                                MessageBox.Show(
                                    "Login successful. Welcome " + fullName + "!",
                                    "Login Successful",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                if (loggedInRole == "Receptionist")
                                {
                                    Reception_DashBoard receptionForm = new Reception_DashBoard();
                                    receptionForm.Show();
                                }
                                else if (loggedInRole == "Nurse/Doctor")
                                {
                                    NursesOrDoctor_DashBoard nurseDashboardForm = new NursesOrDoctor_DashBoard();
                                    nurseDashboardForm.Show();
                                }
                                else if (loggedInRole == "Manager")
                                {
                                    Manager_DashBoard managerForm = new Manager_DashBoard();
                                    managerForm.Show();
                                }

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Invalid username, password, or role.",
                                    "Login Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                                txtPassword.Clear();
                                txtPassword.Focus();

                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while trying to login.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            { // Always enable the Login button again
              button1.Text = "LogIn";
              button1.Enabled = true; 
            }
        }

        private void cbShowP_CheckedChanged(object sender, EventArgs e)
        {

            if (cbShowP.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
