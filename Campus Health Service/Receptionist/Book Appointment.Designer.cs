namespace Receptionist
{
    partial class Book_Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Appointment));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            label10 = new Label();
            panel2 = new Panel();
            btnLogout = new Button();
            btnCancel = new Button();
            btnEmergency = new Button();
            btnManage = new Button();
            btnBookAppointment = new Button();
            btnDashBoard = new Button();
            label1 = new Label();
            label2 = new Label();
            txtStudentStaffNumber = new TextBox();
            txtFullName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtContactNumber = new TextBox();
            txtPassword = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            cmbService = new ComboBox();
            label8 = new Label();
            dtpDate = new DateTimePicker();
            label9 = new Label();
            cmbTime = new ComboBox();
            btnBook = new Button();
            btnReports = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(886, 132);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Campus_Health_Service.Properties.Resources.cardiogram;
            pictureBox1.Location = new Point(3, 16);
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
            label11.Location = new Point(125, 65);
            label11.Name = "label11";
            label11.Size = new Size(149, 18);
            label11.TabIndex = 1;
            label11.Text = "Appointment System";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(125, 16);
            label10.Name = "label10";
            label10.Size = new Size(459, 46);
            label10.TabIndex = 0;
            label10.Text = "Campus Health Service";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnEmergency);
            panel2.Controls.Add(btnManage);
            panel2.Controls.Add(btnBookAppointment);
            panel2.Controls.Add(btnDashBoard);
            panel2.Location = new Point(14, 157);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 563);
            panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.Image = Campus_Health_Service.Properties.Resources.user_logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(-3, 492);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(229, 64);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.Image = Campus_Health_Service.Properties.Resources.calendar__1_;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(-2, 276);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(229, 64);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel Appointments";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEmergency
            // 
            btnEmergency.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEmergency.Image = Campus_Health_Service.Properties.Resources.medical_care;
            btnEmergency.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmergency.Location = new Point(-2, 347);
            btnEmergency.Margin = new Padding(3, 4, 3, 4);
            btnEmergency.Name = "btnEmergency";
            btnEmergency.Size = new Size(229, 64);
            btnEmergency.TabIndex = 3;
            btnEmergency.Text = "Emergency";
            btnEmergency.UseVisualStyleBackColor = true;
            btnEmergency.Click += btnEmergency_Click;
            // 
            // btnManage
            // 
            btnManage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnManage.Image = Campus_Health_Service.Properties.Resources.scheduling;
            btnManage.ImageAlign = ContentAlignment.MiddleLeft;
            btnManage.Location = new Point(-2, 204);
            btnManage.Margin = new Padding(3, 4, 3, 4);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(229, 64);
            btnManage.TabIndex = 2;
            btnManage.Text = "Manage Appointments";
            btnManage.TextAlign = ContentAlignment.MiddleRight;
            btnManage.UseVisualStyleBackColor = true;
            btnManage.Click += btnManage_Click;
            // 
            // btnBookAppointment
            // 
            btnBookAppointment.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBookAppointment.Image = Campus_Health_Service.Properties.Resources.calendar;
            btnBookAppointment.ImageAlign = ContentAlignment.MiddleLeft;
            btnBookAppointment.Location = new Point(-2, 132);
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
            btnDashBoard.Location = new Point(-2, 60);
            btnDashBoard.Margin = new Padding(3, 4, 3, 4);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(229, 64);
            btnDashBoard.TabIndex = 0;
            btnDashBoard.Text = "Dasboard";
            btnDashBoard.UseVisualStyleBackColor = true;
            btnDashBoard.Click += btnHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 157);
            label1.Name = "label1";
            label1.Size = new Size(242, 32);
            label1.TabIndex = 2;
            label1.Text = "Book Appointments";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(249, 248);
            label2.Name = "label2";
            label2.Size = new Size(175, 20);
            label2.TabIndex = 3;
            label2.Text = "Student/Staff Number :";
            // 
            // txtStudentStaffNumber
            // 
            txtStudentStaffNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtStudentStaffNumber.Location = new Point(249, 285);
            txtStudentStaffNumber.Margin = new Padding(3, 4, 3, 4);
            txtStudentStaffNumber.Name = "txtStudentStaffNumber";
            txtStudentStaffNumber.Size = new Size(268, 27);
            txtStudentStaffNumber.TabIndex = 4;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtFullName.Location = new Point(249, 383);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(268, 27);
            txtFullName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(249, 340);
            label3.Name = "label3";
            label3.Size = new Size(183, 20);
            label3.TabIndex = 6;
            label3.Text = "Patient Name & Surname :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(249, 441);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 7;
            label4.Text = "Contant Number :";
            // 
            // txtContactNumber
            // 
            txtContactNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtContactNumber.Location = new Point(249, 477);
            txtContactNumber.Margin = new Padding(3, 4, 3, 4);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(268, 27);
            txtContactNumber.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtPassword.Location = new Point(249, 567);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(268, 27);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(249, 529);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 10;
            label5.Text = "Password :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(249, 617);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 11;
            label6.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtEmail.Location = new Point(253, 653);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(265, 27);
            txtEmail.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(602, 243);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 13;
            label7.Text = "Service :";
            // 
            // cmbService
            // 
            cmbService.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbService.FormattingEnabled = true;
            cmbService.Items.AddRange(new object[] { "General Consultation (e.g Flu, cold, cough, fever)", "Medical Check (e.g. TB, HIV)", "Health Screening (e.g. Blood Pressure, Glucose)", "Minor Illness Treatment (e.g. Flu, Headache)", "Medication / Prescription", "Wound Care / Dressing", "Sexual Health Services (e.g. STI Testing)", "Mental Health Consultation (e.g. Stress, Anxiety)", "Family Planning / Contraception", "Follow-up Consultation", "Vaccination / Immunisation", "Medical Certificate (e.g. Sick Note, Medical Documentation)", "Emergency / Urgent Care" });
            cmbService.Location = new Point(602, 285);
            cmbService.Margin = new Padding(3, 4, 3, 4);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(298, 28);
            cmbService.TabIndex = 14;
            cmbService.Text = "Select Service";
            cmbService.SelectedIndexChanged += cmbService_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(602, 340);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 15;
            label8.Text = "Date :";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dtpDate.Location = new Point(602, 379);
            dtpDate.Margin = new Padding(3, 4, 3, 4);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(299, 27);
            dtpDate.TabIndex = 16;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(602, 441);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 17;
            label9.Text = "Time :";
            // 
            // cmbTime
            // 
            cmbTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbTime.FormattingEnabled = true;
            cmbTime.Items.AddRange(new object[] { "08:00 - 09:00", "09:00 - 10:00", "10:00 - 11:00", "11:00 - 12:00", "13:00 - 14:00", "14:00 - 15:00", "15:00 - 16:00", "16:00 - 17:00" });
            cmbTime.Location = new Point(602, 477);
            cmbTime.Margin = new Padding(3, 4, 3, 4);
            cmbTime.Name = "cmbTime";
            cmbTime.Size = new Size(298, 28);
            cmbTime.TabIndex = 18;
            cmbTime.Text = "Select Time";
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.Blue;
            btnBook.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.Image = Campus_Health_Service.Properties.Resources.medication;
            btnBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnBook.Location = new Point(673, 565);
            btnBook.Margin = new Padding(3, 4, 3, 4);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(229, 55);
            btnBook.TabIndex = 19;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(0, 0);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(75, 23);
            btnReports.TabIndex = 0;
            // 
            // Book_Appointment
            // 
            AcceptButton = btnBook;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 737);
            Controls.Add(btnBook);
            Controls.Add(cmbTime);
            Controls.Add(label9);
            Controls.Add(dtpDate);
            Controls.Add(label8);
            Controls.Add(cmbService);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(txtContactNumber);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtFullName);
            Controls.Add(txtStudentStaffNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Book_Appointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book_Appointment";
            Load += Book_Appointment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox txtStudentStaffNumber;
        private TextBox txtFullName;
        private Label label3;
        private Label label4;
        private TextBox txtContactNumber;
        private TextBox txtPassword;
        private Label label5;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private Button btnManage;
        private Button btnBookAppointment;
        private Button btnDashBoard;
        private ComboBox cmbService;
        private Label label8;
        private DateTimePicker dtpDate;
        private Label label9;
        private ComboBox cmbTime;
        private Button btnBook;
        private Button btnCancel;
        private Button button4;
        private Button button3;
        private Button btnReports;
        private Button btnEmergency;
        private Label label11;
        private Label label10;
        private PictureBox pictureBox1;
        private Button btnLogout;
    }
}
