using Campus_Health_Service;

namespace Receptionist
{
    public partial class Reception_DashBoard : Form
    {
        public Reception_DashBoard()
        {
            InitializeComponent();
        }

        //==============================================================================================================================================================
        private void btnBook_Click(object sender, EventArgs e)
        {
            // Open the CheckPatient form
            CheckPatient check = new CheckPatient();
            check.Show();
            this.Hide();
        }

        //==============================================================================================================================================================
        private void btnManage_Click(object sender, EventArgs e)
        {
            Manage_Appointments manage = new Manage_Appointments();
            manage.Show();
            this.Hide();
        }

        //==============================================================================================================================================================
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel_Appointments cancel = new Cancel_Appointments();
            cancel.Show();
            this.Hide();
        }

        //==============================================================================================================================================================
        private void btnEmergency_Click(object sender, EventArgs e)
        {
            Emegency em = new Emegency();
            em.Show();
            this.Hide();
        }

        //==============================================================================================================================================================
        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnLogout.Text = "Loading...";
            btnLogout.Enabled = false;

            btnLogout.BackColor = Color.Red;

            // Reset the View Appointments button color
            btnDashBoard.BackColor = Color.White;

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
                btnDashBoard.BackColor = Color.Blue;
            }
        }

        //==============================================================================================================================================================
        private void Reception_DashBoard_Load(object sender, EventArgs e)
        {
            btnDashBoard.BackColor = Color.Blue;
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {

        }
    }
}
