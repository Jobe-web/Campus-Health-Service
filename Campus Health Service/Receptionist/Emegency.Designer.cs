namespace Receptionist
{
    partial class Emegency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emegency));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            label10 = new Label();
            panel2 = new Panel();
            btnLogout = new Button();
            btnEmergency = new Button();
            btnCancel = new Button();
            btnManageAppointments = new Button();
            btnBookAppointment = new Button();
            btnDashBoard = new Button();
            label1 = new Label();
            panel3 = new Panel();
            txtNumber = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtStudentStaffNumber = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            dtpEmergencyTime = new DateTimePicker();
            cmbLevel = new ComboBox();
            dtpEmergencyDate = new DateTimePicker();
            cmbService = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            button1 = new Button();
            btnNotify = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 132);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Campus_Health_Service.Properties.Resources.cardiogram;
            pictureBox1.Location = new Point(26, 17);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 89);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Book Antiqua", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(147, 61);
            label11.Name = "label11";
            label11.Size = new Size(149, 18);
            label11.TabIndex = 1;
            label11.Text = "Appointment System";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(147, 17);
            label10.Name = "label10";
            label10.Size = new Size(357, 43);
            label10.TabIndex = 0;
            label10.Text = "Campus Health Service";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnEmergency);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnManageAppointments);
            panel2.Controls.Add(btnBookAppointment);
            panel2.Controls.Add(btnDashBoard);
            panel2.Location = new Point(14, 157);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 561);
            panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.Image = Campus_Health_Service.Properties.Resources.user_logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(-2, 490);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(229, 64);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnEmergency
            // 
            btnEmergency.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEmergency.Image = Campus_Health_Service.Properties.Resources.medical_care;
            btnEmergency.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmergency.Location = new Point(-2, 323);
            btnEmergency.Margin = new Padding(3, 4, 3, 4);
            btnEmergency.Name = "btnEmergency";
            btnEmergency.Size = new Size(229, 64);
            btnEmergency.TabIndex = 4;
            btnEmergency.Text = "Emergency";
            btnEmergency.UseVisualStyleBackColor = true;
            btnEmergency.Click += btnEmegency_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.Image = Campus_Health_Service.Properties.Resources.calendar__1_;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(-2, 245);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(229, 64);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel Appointments";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnManageAppointments
            // 
            btnManageAppointments.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnManageAppointments.Image = Campus_Health_Service.Properties.Resources.scheduling;
            btnManageAppointments.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageAppointments.Location = new Point(-2, 173);
            btnManageAppointments.Margin = new Padding(3, 4, 3, 4);
            btnManageAppointments.Name = "btnManageAppointments";
            btnManageAppointments.Size = new Size(229, 64);
            btnManageAppointments.TabIndex = 2;
            btnManageAppointments.Text = "Manage Appointments";
            btnManageAppointments.TextAlign = ContentAlignment.MiddleRight;
            btnManageAppointments.UseVisualStyleBackColor = true;
            btnManageAppointments.Click += btnManageAppointments_Click;
            // 
            // btnBookAppointment
            // 
            btnBookAppointment.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBookAppointment.Image = Campus_Health_Service.Properties.Resources.calendar;
            btnBookAppointment.ImageAlign = ContentAlignment.MiddleLeft;
            btnBookAppointment.Location = new Point(-2, 101);
            btnBookAppointment.Margin = new Padding(3, 4, 3, 4);
            btnBookAppointment.Name = "btnBookAppointment";
            btnBookAppointment.Size = new Size(229, 64);
            btnBookAppointment.TabIndex = 1;
            btnBookAppointment.Text = "Book Appointment";
            btnBookAppointment.TextAlign = ContentAlignment.MiddleRight;
            btnBookAppointment.UseVisualStyleBackColor = true;
            btnBookAppointment.Click += btnBookAppointment_Click;
            // 
            // btnDashBoard
            // 
            btnDashBoard.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDashBoard.Image = Campus_Health_Service.Properties.Resources.data;
            btnDashBoard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashBoard.Location = new Point(-2, 29);
            btnDashBoard.Margin = new Padding(3, 4, 3, 4);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(229, 64);
            btnDashBoard.TabIndex = 0;
            btnDashBoard.Text = "Dashboard";
            btnDashBoard.UseVisualStyleBackColor = true;
            btnDashBoard.Click += btnHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(275, 157);
            label1.Name = "label1";
            label1.Size = new Size(112, 29);
            label1.TabIndex = 2;
            label1.Text = "Emegency";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtNumber);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtStudentStaffNumber);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(275, 192);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(705, 225);
            panel3.TabIndex = 3;
            // 
            // txtNumber
            // 
            txtNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtNumber.Location = new Point(387, 145);
            txtNumber.Margin = new Padding(3, 4, 3, 4);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(302, 27);
            txtNumber.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtName.Location = new Point(18, 140);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(277, 27);
            txtName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtEmail.Location = new Point(387, 43);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(302, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtStudentStaffNumber
            // 
            txtStudentStaffNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtStudentStaffNumber.Location = new Point(18, 45);
            txtStudentStaffNumber.Margin = new Padding(3, 4, 3, 4);
            txtStudentStaffNumber.Name = "txtStudentStaffNumber";
            txtStudentStaffNumber.Size = new Size(277, 27);
            txtStudentStaffNumber.TabIndex = 4;
            txtStudentStaffNumber.TextChanged += txtStudentStaffNumber_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(387, 112);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 3;
            label5.Text = "Contact Number :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(18, 112);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 2;
            label4.Text = "Full Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(387, 19);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 1;
            label3.Text = "Email :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(18, 21);
            label2.Name = "label2";
            label2.Size = new Size(175, 20);
            label2.TabIndex = 0;
            label2.Text = "Student/Staff Number :";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dtpEmergencyTime);
            panel4.Controls.Add(cmbLevel);
            panel4.Controls.Add(dtpEmergencyDate);
            panel4.Controls.Add(cmbService);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(275, 452);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(705, 193);
            panel4.TabIndex = 4;
            // 
            // dtpEmergencyTime
            // 
            dtpEmergencyTime.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpEmergencyTime.Format = DateTimePickerFormat.Time;
            dtpEmergencyTime.Location = new Point(18, 136);
            dtpEmergencyTime.Name = "dtpEmergencyTime";
            dtpEmergencyTime.ShowUpDown = true;
            dtpEmergencyTime.Size = new Size(277, 27);
            dtpEmergencyTime.TabIndex = 8;
            // 
            // cmbLevel
            // 
            cmbLevel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbLevel.FormattingEnabled = true;
            cmbLevel.Items.AddRange(new object[] { "", "Urgent", "Emergency" });
            cmbLevel.Location = new Point(387, 135);
            cmbLevel.Margin = new Padding(3, 4, 3, 4);
            cmbLevel.Name = "cmbLevel";
            cmbLevel.Size = new Size(302, 28);
            cmbLevel.TabIndex = 7;
            cmbLevel.Text = "Normal";
            // 
            // dtpEmergencyDate
            // 
            dtpEmergencyDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dtpEmergencyDate.Location = new Point(387, 55);
            dtpEmergencyDate.Margin = new Padding(3, 4, 3, 4);
            dtpEmergencyDate.Name = "dtpEmergencyDate";
            dtpEmergencyDate.Size = new Size(302, 27);
            dtpEmergencyDate.TabIndex = 5;
            // 
            // cmbService
            // 
            cmbService.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbService.FormattingEnabled = true;
            cmbService.Items.AddRange(new object[] { "General Consultation (e.g Flu, cold, cough, fever)", "Medical Check (e.g. TB, HIV)", "Health Screening (e.g. Blood Pressure, Glucose)", "Minor Illness Treatment (e.g. Flu, Headache)", "Medication / Prescription", "Wound Care / Dressing", "Sexual Health Services (e.g. STI Testing)", "Mental Health Consultation (e.g. Stress, Anxiety)", "Family Planning / Contraception", "Follow-up Consultation", "Vaccination / Immunisation", "Medical Certificate (e.g. Sick Note, Medical Documentation)", "Emergency / Urgent Care" });
            cmbService.Location = new Point(18, 55);
            cmbService.Margin = new Padding(3, 4, 3, 4);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(277, 28);
            cmbService.TabIndex = 4;
            cmbService.Text = "Select Service";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(393, 101);
            label9.Name = "label9";
            label9.Size = new Size(109, 20);
            label9.TabIndex = 3;
            label9.Text = "Priority Level :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(18, 101);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 2;
            label8.Text = "Time :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(393, 31);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 1;
            label7.Text = "Date :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(18, 31);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 0;
            label6.Text = "Service :";
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Campus_Health_Service.Properties.Resources.contacts;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(711, 669);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(269, 49);
            button1.TabIndex = 5;
            button1.Text = "Save  Emergency Appointment";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnNotify
            // 
            btnNotify.BackColor = Color.Lime;
            btnNotify.Image = Campus_Health_Service.Properties.Resources.message_notification;
            btnNotify.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotify.Location = new Point(479, 673);
            btnNotify.Name = "btnNotify";
            btnNotify.Size = new Size(185, 45);
            btnNotify.TabIndex = 6;
            btnNotify.Text = "Notify Patient";
            btnNotify.UseVisualStyleBackColor = false;
            btnNotify.Click += btnNotify_Click;
            // 
            // Emegency
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 735);
            Controls.Add(btnNotify);
            Controls.Add(button1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Emegency";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Emegency";
            Load += Emegency_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnHistoryReport;
        private Button btnEmergency;
        private Button btnCancel;
        private Button btnManageAppointments;
        private Button btnBookAppointment;
        private Button btnDashBoard;
        private Label label1;
        private Panel panel3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtNumber;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtStudentStaffNumber;
        private Panel panel4;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox cmbLevel;
        private DateTimePicker dtpEmergencyDate;
        private ComboBox cmbService;
        private Label label9;
        private Label label10;
        private Button button1;
        private Label label11;
        private PictureBox pictureBox1;
        private Button btnLogout;
        private DateTimePicker dtpEmergencyTime;
        private Button btnNotify;
    }
}