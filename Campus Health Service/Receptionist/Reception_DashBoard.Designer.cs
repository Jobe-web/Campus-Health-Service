
namespace Receptionist
{
    partial class Reception_DashBoard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reception_DashBoard));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnDashBoard = new Button();
            btnLogout = new Button();
            btnBookAppointment = new Button();
            btnEmergency = new Button();
            btnCancel = new Button();
            btnManage = new Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(886, 132);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Campus_Health_Service.Properties.Resources.cardiogram;
            pictureBox1.Location = new Point(17, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 89);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(138, 65);
            label2.Name = "label2";
            label2.Size = new Size(149, 18);
            label2.TabIndex = 1;
            label2.Text = "Appointment System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 16);
            label1.Name = "label1";
            label1.Size = new Size(459, 46);
            label1.TabIndex = 0;
            label1.Text = "Campus Health Service";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnDashBoard);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnBookAppointment);
            panel2.Controls.Add(btnEmergency);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnManage);
            panel2.Location = new Point(14, 157);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 549);
            panel2.TabIndex = 1;
            // 
            // btnDashBoard
            // 
            btnDashBoard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDashBoard.Image = Campus_Health_Service.Properties.Resources.data;
            btnDashBoard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashBoard.Location = new Point(-2, 27);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(229, 64);
            btnDashBoard.TabIndex = 5;
            btnDashBoard.Text = "Dashboard";
            btnDashBoard.UseVisualStyleBackColor = true;
            btnDashBoard.Click += btnDashBoard_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLogout.Image = Campus_Health_Service.Properties.Resources.user_logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(-2, 469);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(229, 64);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBookAppointment
            // 
            btnBookAppointment.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnBookAppointment.Image = Campus_Health_Service.Properties.Resources.calendar;
            btnBookAppointment.ImageAlign = ContentAlignment.MiddleLeft;
            btnBookAppointment.Location = new Point(-2, 98);
            btnBookAppointment.Margin = new Padding(3, 4, 3, 4);
            btnBookAppointment.Name = "btnBookAppointment";
            btnBookAppointment.Size = new Size(229, 64);
            btnBookAppointment.TabIndex = 2;
            btnBookAppointment.Text = "Book Appointments";
            btnBookAppointment.TextAlign = ContentAlignment.MiddleRight;
            btnBookAppointment.UseVisualStyleBackColor = true;
            btnBookAppointment.Click += btnBook_Click;
            // 
            // btnEmergency
            // 
            btnEmergency.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEmergency.Image = Campus_Health_Service.Properties.Resources.medical_care;
            btnEmergency.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmergency.Location = new Point(-2, 314);
            btnEmergency.Margin = new Padding(3, 4, 3, 4);
            btnEmergency.Name = "btnEmergency";
            btnEmergency.Size = new Size(229, 64);
            btnEmergency.TabIndex = 2;
            btnEmergency.Text = "Emergency";
            btnEmergency.UseVisualStyleBackColor = true;
            btnEmergency.Click += btnEmergency_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCancel.Image = Campus_Health_Service.Properties.Resources.calendar__1_;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(-2, 242);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(229, 64);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel Appointments";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnManage
            // 
            btnManage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnManage.Image = Campus_Health_Service.Properties.Resources.scheduling;
            btnManage.ImageAlign = ContentAlignment.MiddleLeft;
            btnManage.Location = new Point(-3, 170);
            btnManage.Margin = new Padding(3, 4, 3, 4);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(229, 64);
            btnManage.TabIndex = 3;
            btnManage.Text = "Manage Appointments";
            btnManage.TextAlign = ContentAlignment.MiddleRight;
            btnManage.UseVisualStyleBackColor = true;
            btnManage.Click += btnManage_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Campus_Health_Service.Properties.Resources.receptionDash;
            pictureBox2.Location = new Point(249, 186);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(651, 490);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // Reception_DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 719);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Reception_DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard";
            Load += Reception_DashBoard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnEmergency;
        private Button btnCancel;
        private Button btnManage;
        private Button btnBookAppointment;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnLogout;
        private Button btnDashBoard;
        private PictureBox pictureBox2;
    }
}
