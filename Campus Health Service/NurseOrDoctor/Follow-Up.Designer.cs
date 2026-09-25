namespace Campus_Health_Service.Nurse
{
    partial class Follow_Up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Follow_Up));
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
            label3 = new Label();
            cmbPatients = new ComboBox();
            groupBox1 = new GroupBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtStudentStaffNumber = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            txtNote = new TextBox();
            cmbFollowUpTime = new ComboBox();
            dtpFollowUpDate = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            panel1.Size = new Size(1128, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cardiogram;
            pictureBox1.Location = new Point(3, 18);
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
            label2.Location = new Point(134, 68);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 1;
            label2.Text = "Follow Up for the patient";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 18);
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
            panel2.Size = new Size(229, 615);
            panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.Image = Properties.Resources.user_logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(-1, 557);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(228, 48);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDashboard.Image = Properties.Resources.data;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(1, 21);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(228, 48);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnFollowUp
            // 
            btnFollowUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFollowUp.Image = Properties.Resources.follow_up;
            btnFollowUp.ImageAlign = ContentAlignment.MiddleLeft;
            btnFollowUp.Location = new Point(1, 183);
            btnFollowUp.Name = "btnFollowUp";
            btnFollowUp.Size = new Size(228, 48);
            btnFollowUp.TabIndex = 5;
            btnFollowUp.Text = "Follow-Up";
            btnFollowUp.UseVisualStyleBackColor = true;
            // 
            // btnViewAppointments
            // 
            btnViewAppointments.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewAppointments.Image = Properties.Resources.medical_appointment;
            btnViewAppointments.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewAppointments.Location = new Point(0, 75);
            btnViewAppointments.Name = "btnViewAppointments";
            btnViewAppointments.Size = new Size(228, 48);
            btnViewAppointments.TabIndex = 3;
            btnViewAppointments.Text = "View Appointments";
            btnViewAppointments.UseVisualStyleBackColor = true;
            btnViewAppointments.Click += btnViewAppointments_Click;
            // 
            // btnPatientRecords
            // 
            btnPatientRecords.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPatientRecords.Image = Properties.Resources.health_report;
            btnPatientRecords.ImageAlign = ContentAlignment.MiddleLeft;
            btnPatientRecords.Location = new Point(1, 129);
            btnPatientRecords.Name = "btnPatientRecords";
            btnPatientRecords.Size = new Size(228, 48);
            btnPatientRecords.TabIndex = 4;
            btnPatientRecords.Text = "Patient Records";
            btnPatientRecords.UseVisualStyleBackColor = true;
            btnPatientRecords.Click += btnPatientRecords_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(249, 182);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 2;
            label3.Text = "Select the Patient :";
            // 
            // cmbPatients
            // 
            cmbPatients.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbPatients.FormattingEnabled = true;
            cmbPatients.Location = new Point(410, 179);
            cmbPatients.Name = "cmbPatients";
            cmbPatients.Size = new Size(275, 28);
            cmbPatients.TabIndex = 3;
            cmbPatients.SelectedIndexChanged += cmbPatients_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(txtStudentStaffNumber);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(249, 234);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(891, 220);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patient Details";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtEmail.Location = new Point(500, 179);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(359, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtPhoneNumber.Location = new Point(18, 179);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(378, 27);
            txtPhoneNumber.TabIndex = 6;
            // 
            // txtStudentStaffNumber
            // 
            txtStudentStaffNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtStudentStaffNumber.Location = new Point(500, 82);
            txtStudentStaffNumber.Name = "txtStudentStaffNumber";
            txtStudentStaffNumber.ReadOnly = true;
            txtStudentStaffNumber.Size = new Size(359, 27);
            txtStudentStaffNumber.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtName.Location = new Point(18, 82);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(378, 27);
            txtName.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(500, 142);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 3;
            label7.Text = "Email :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(18, 142);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 2;
            label6.Text = "Phone Number :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(500, 49);
            label5.Name = "label5";
            label5.Size = new Size(175, 20);
            label5.TabIndex = 1;
            label5.Text = "Student/Staff Number :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(18, 49);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 0;
            label4.Text = "Patient Name :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(txtNote);
            groupBox2.Controls.Add(cmbFollowUpTime);
            groupBox2.Controls.Add(dtpFollowUpDate);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(247, 465);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(543, 293);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Follow Up";
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.ForeColor = Color.White;
            button1.Location = new Point(420, 237);
            button1.Name = "button1";
            button1.Size = new Size(117, 39);
            button1.TabIndex = 6;
            button1.Text = "Follow-Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtNote
            // 
            txtNote.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtNote.Location = new Point(29, 173);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(369, 103);
            txtNote.TabIndex = 5;
            // 
            // cmbFollowUpTime
            // 
            cmbFollowUpTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbFollowUpTime.FormattingEnabled = true;
            cmbFollowUpTime.Items.AddRange(new object[] { "08:00 - 09:00", "09:00 - 10:00", "10:00 - 11:00", "11:00 - 12:00", "13:00 - 14:00", "14:00 - 15:00", "15:00 - 16:00", "16:00 - 17:00" });
            cmbFollowUpTime.Location = new Point(151, 95);
            cmbFollowUpTime.Name = "cmbFollowUpTime";
            cmbFollowUpTime.Size = new Size(253, 28);
            cmbFollowUpTime.TabIndex = 4;
            cmbFollowUpTime.Text = "Select Time ";
            cmbFollowUpTime.SelectedIndexChanged += cmbFollowUpTime_SelectedIndexChanged;
            // 
            // dtpFollowUpDate
            // 
            dtpFollowUpDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dtpFollowUpDate.Location = new Point(148, 45);
            dtpFollowUpDate.Name = "dtpFollowUpDate";
            dtpFollowUpDate.Size = new Size(263, 27);
            dtpFollowUpDate.TabIndex = 3;
            dtpFollowUpDate.ValueChanged += dtpFollowUpDate_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(27, 145);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 2;
            label10.Text = "Note :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(19, 98);
            label9.Name = "label9";
            label9.Size = new Size(126, 20);
            label9.TabIndex = 1;
            label9.Text = "Follow Up Time :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(18, 45);
            label8.Name = "label8";
            label8.Size = new Size(124, 20);
            label8.TabIndex = 0;
            label8.Text = "Follow Up Date :";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.followup3;
            pictureBox2.Location = new Point(839, 486);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(250, 243);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Follow_Up
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 770);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(cmbPatients);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Follow_Up";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Follow_Up";
            Load += Follow_Up_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnDashboard;
        private Button btnViewAppointments;
        private Button btnPatientRecords;
        private Button btnFollowUp;
        private Button btnLogout;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private ComboBox cmbPatients;
        private GroupBox groupBox1;
        private TextBox txtName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtStudentStaffNumber;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private TextBox txtNote;
        private ComboBox cmbFollowUpTime;
        private DateTimePicker dtpFollowUpDate;
        private Label label10;
        private Button button1;
        private PictureBox pictureBox2;
    }
}