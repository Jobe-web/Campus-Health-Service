namespace Campus_Health_Service.Nurse
{
    partial class NursesOrDoctor_DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NursesOrDoctor_DashBoard));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnLogout = new Button();
            btnDashboard = new Button();
            btnFollowUp = new Button();
            btnViewAppointments = new Button();
            btnPatientRecords = new Button();
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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cardiogram;
            pictureBox1.Location = new Point(3, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(134, 65);
            label2.Name = "label2";
            label2.Size = new Size(181, 20);
            label2.TabIndex = 1;
            label2.Text = "Nurse/Doctor Dashboard";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 15);
            label1.Name = "label1";
            label1.Size = new Size(484, 50);
            label1.TabIndex = 0;
            label1.Text = "CAMPUS HEALTH SERVICE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnDashboard);
            panel2.Controls.Add(btnFollowUp);
            panel2.Controls.Add(btnViewAppointments);
            panel2.Controls.Add(btnPatientRecords);
            panel2.Location = new Point(12, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 394);
            panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLogout.Image = Properties.Resources.user_logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(-2, 339);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(228, 48);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDashboard.Image = Properties.Resources.data;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(-2, 22);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(228, 48);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = " Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnFollowUp
            // 
            btnFollowUp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnFollowUp.Image = Properties.Resources.follow_up;
            btnFollowUp.ImageAlign = ContentAlignment.MiddleLeft;
            btnFollowUp.Location = new Point(-2, 184);
            btnFollowUp.Name = "btnFollowUp";
            btnFollowUp.Size = new Size(228, 48);
            btnFollowUp.TabIndex = 5;
            btnFollowUp.Text = "Follow-Up";
            btnFollowUp.UseVisualStyleBackColor = true;
            btnFollowUp.Click += btnFollowUp_Click;
            // 
            // btnViewAppointments
            // 
            btnViewAppointments.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnViewAppointments.Image = Properties.Resources.medical_appointment;
            btnViewAppointments.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewAppointments.Location = new Point(-2, 76);
            btnViewAppointments.Name = "btnViewAppointments";
            btnViewAppointments.Size = new Size(228, 48);
            btnViewAppointments.TabIndex = 3;
            btnViewAppointments.Text = "View Appointments";
            btnViewAppointments.UseVisualStyleBackColor = true;
            btnViewAppointments.Click += btnViewAppointments_Click;
            // 
            // btnPatientRecords
            // 
            btnPatientRecords.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnPatientRecords.Image = Properties.Resources.health_report;
            btnPatientRecords.ImageAlign = ContentAlignment.MiddleLeft;
            btnPatientRecords.Location = new Point(-2, 130);
            btnPatientRecords.Name = "btnPatientRecords";
            btnPatientRecords.Size = new Size(228, 48);
            btnPatientRecords.TabIndex = 4;
            btnPatientRecords.Text = "Patient Records";
            btnPatientRecords.UseVisualStyleBackColor = true;
            btnPatientRecords.Click += btnPatientRecords_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.NurseDash;
            pictureBox2.Location = new Point(295, 143);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(537, 394);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // NursesOrDoctor_DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 557);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NursesOrDoctor_DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nurses_DashBoard";
            Load += Nurses_DashBoard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnDashboard;
        private Button btnViewAppointments;
        private Button btnPatientRecords;
        private Button btnFollowUp;
        private Button btnLogout;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}