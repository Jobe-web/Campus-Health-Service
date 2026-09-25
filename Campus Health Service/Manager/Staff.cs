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

namespace Campus_Health_Service.Manager
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        DBConnection dB = new DBConnection();
        private void Staff_Load(object sender, EventArgs e)
        {
            btnStaff.BackColor = Color.Blue;
            LoadStaff();
        }

        //=========================================================================================================================================
        //==========================================================================================================================================
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            Manager_DashBoard manager_DashBoard = new Manager_DashBoard();
            manager_DashBoard.Show();
            this.Hide();
        }

        //====================================================================================================================================================
        //====================================================================================================================================================
        private void btnAppointments_Click(object sender, EventArgs e)
        {
            Appointments appointments = new Appointments();
            appointments.Show();
            this.Hide();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            Patients patients = new Patients();
            patients.Show();
            this.Hide();
        }

        //==============================================================================================================================
        //=======================================================================================================================================
        private void btnStaff_Click(object sender, EventArgs e)
        {

        }

        //==========================================================================================================================================
        //====================================================================================================================================================
        private void btnReport_Click(object sender, EventArgs e)
        {
            Generate_Report report = new Generate_Report();

            this.Hide();

            report.Show();
        }

        //=============================================================================================================================================
        //==============================================================================================================================================
        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnLogout.Text = "Loading...";
            btnLogout.Enabled = false;

            btnLogout.BackColor = Color.Red;

            // Reset the View Appointments button color
            btnStaff.BackColor = Color.White;

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
                btnStaff.BackColor = Color.Blue;
            }
        }

        //====================================================================================================================================================
        // Loads staff accounts into the Staff DataGridView.
        //====================================================================================================================================================
        private void LoadStaff()
        {
            string query = @"
        SELECT
            Staff_ID,
            Username,
            Full_Name,
            Role
        FROM staff_users
        ORDER BY Username ASC;
    ";

            try
            {
                DataTable table = new DataTable();

                using (MySqlConnection conn = dB.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter =
                               new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }
                    }
                }

                dgvStaff.DataSource = table;

                // Hide Staff_ID because it is only used internally.
                if (dgvStaff.Columns.Contains("Staff_ID"))
                {
                    dgvStaff.Columns["Staff_ID"].Visible = false;
                }

                dgvStaff.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvStaff.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvStaff.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading staff:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        //====================================================================================================================================================
        // Loads the selected staff member into the username textbox.
        //=============================================================================================================
        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvStaff.Rows[e.RowIndex];

            txtUsername.Text =
                row.Cells["Username"].Value?.ToString() ?? "";

            txtNPassword.Clear();
            txtCPassword.Clear();

            txtNPassword.Focus();
        }


        //====================================================================================================================================================
        // Changes the password of the selected staff account.
        //=============================================================================================================
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string newPassword = txtNPassword.Text;
            string confirmPassword = txtCPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(
                    "Please select a staff member first.",
                    "Staff Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show(
                    "Please enter a new password.",
                    "Missing Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show(
                    "Please confirm the new password.",
                    "Missing Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCPassword.Focus();
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show(
                    "The new password and confirmation password do not match.",
                    "Password Mismatch",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCPassword.Focus();
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to change the password for " +
                username + "?",
                "Confirm Password Change",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            string query = @"
        UPDATE staff_users
        SET PasswordCode = @PasswordCode
        WHERE Username = @Username;
    ";

            try
            {
                using (MySqlConnection conn = dB.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@PasswordCode",
                            newPassword);

                        cmd.Parameters.AddWithValue(
                            "@Username",
                            username);

                        int rowsAffected =
                            cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "Password changed successfully.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            txtNPassword.Clear();
                            txtCPassword.Clear();
                        }
                        else
                        {
                            MessageBox.Show(
                                "The password could not be changed.",
                                "Update Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error changing password:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cbShowP_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowP.Checked)
            {
                txtNPassword.PasswordChar = '\0';
                txtCPassword.PasswordChar = '\0';
            }
            else
            {
                txtNPassword.PasswordChar = '●';
                txtCPassword.PasswordChar = '●';
            }
        }
    }
}
