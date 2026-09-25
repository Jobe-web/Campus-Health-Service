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
    public partial class NursesOrDoctor_DashBoard : Form
    {
        public NursesOrDoctor_DashBoard()
        {
            InitializeComponent();
        }

        private void Nurses_DashBoard_Load(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.Blue;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        //===========================================================================================================================================================================
        // View Appointments button click event handler
        //===========================================================================================================================================================================
        private void btnViewAppointments_Click(object sender, EventArgs e)
        {
            View_Appointments viewAppointmentsForm = new View_Appointments();
            viewAppointmentsForm.Show();
            this.Hide();
        }

        //===========================================================================================================================================================================
        // Patient Records button click event handler
        //===========================================================================================================================================================================
        private void btnPatientRecords_Click(object sender, EventArgs e)
        {
            Patient_Records patientRecordsForm = new Patient_Records();
            patientRecordsForm.Show();
            this.Hide();
        }

        //===========================================================================================================================================================================
        // Follow Up button click event handler
        //===========================================================================================================================================================================
        private void btnFollowUp_Click(object sender, EventArgs e)
        {
            Follow_Up followUpForm = new Follow_Up();
            followUpForm.Show();
            this.Hide();
        }

        //===========================================================================================================================================================================
        // Logout button click event handler
        //===========================================================================================================================================================================
        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnLogout.Text = "Loading...";
            btnLogout.Enabled = false;

            btnLogout.BackColor = Color.Red;

            // Reset the View Appointments button color
            btnDashboard.BackColor = Color.White;

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
                btnDashboard.BackColor = Color.Blue;
            }
        }
    }
}
