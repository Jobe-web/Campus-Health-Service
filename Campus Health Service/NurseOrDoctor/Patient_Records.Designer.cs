namespace Campus_Health_Service.Nurse
{
    partial class Patient_Records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient_Records));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnLogout = new Button();
            btnFollowUp = new Button();
            btnPatientRecords = new Button();
            btnViewAppointments = new Button();
            btnDashboard = new Button();
            txtSearch = new TextBox();
            label3 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtStudentStaffNumber = new TextBox();
            txtName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            dgvMedicalH = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicalH).BeginInit();
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
            panel1.Size = new Size(979, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cardiogram;
            pictureBox1.Location = new Point(3, 24);
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
            label2.Location = new Point(144, 66);
            label2.Name = "label2";
            label2.Size = new Size(308, 20);
            label2.TabIndex = 1;
            label2.Text = "View Patient information and appointments";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 16);
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
            panel2.Controls.Add(btnFollowUp);
            panel2.Controls.Add(btnPatientRecords);
            panel2.Controls.Add(btnViewAppointments);
            panel2.Controls.Add(btnDashboard);
            panel2.Location = new Point(12, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 594);
            panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.Image = Properties.Resources.user_logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 539);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(228, 48);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnFollowUp
            // 
            btnFollowUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFollowUp.Image = Properties.Resources.follow_up;
            btnFollowUp.ImageAlign = ContentAlignment.MiddleLeft;
            btnFollowUp.Location = new Point(0, 193);
            btnFollowUp.Name = "btnFollowUp";
            btnFollowUp.Size = new Size(228, 48);
            btnFollowUp.TabIndex = 3;
            btnFollowUp.Text = "Follow-Up";
            btnFollowUp.UseVisualStyleBackColor = true;
            btnFollowUp.Click += btnFollowUp_Click;
            // 
            // btnPatientRecords
            // 
            btnPatientRecords.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPatientRecords.Image = Properties.Resources.health_report;
            btnPatientRecords.ImageAlign = ContentAlignment.MiddleLeft;
            btnPatientRecords.Location = new Point(0, 139);
            btnPatientRecords.Name = "btnPatientRecords";
            btnPatientRecords.Size = new Size(228, 48);
            btnPatientRecords.TabIndex = 2;
            btnPatientRecords.Text = "Patient Records";
            btnPatientRecords.UseVisualStyleBackColor = true;
            // 
            // btnViewAppointments
            // 
            btnViewAppointments.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewAppointments.Image = Properties.Resources.medical_appointment;
            btnViewAppointments.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewAppointments.Location = new Point(0, 85);
            btnViewAppointments.Name = "btnViewAppointments";
            btnViewAppointments.Size = new Size(228, 48);
            btnViewAppointments.TabIndex = 1;
            btnViewAppointments.Text = "View Appointments";
            btnViewAppointments.UseVisualStyleBackColor = true;
            btnViewAppointments.Click += btnViewAppointments_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDashboard.Image = Properties.Resources.data;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 31);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(228, 48);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = " Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtSearch.Location = new Point(248, 210);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(420, 27);
            txtSearch.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(248, 176);
            label3.Name = "label3";
            label3.Size = new Size(378, 20);
            label3.TabIndex = 3;
            label3.Text = "Search patient to view By (StudentOrStaff Number) :";
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.magnifying_glass;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(688, 203);
            button1.Name = "button1";
            button1.Size = new Size(119, 40);
            button1.TabIndex = 4;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(txtStudentStaffNumber);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(248, 261);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(743, 194);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patients Details";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(330, 110);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 7;
            label7.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtEmail.Location = new Point(330, 142);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(256, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtPhoneNumber.Location = new Point(6, 142);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(252, 27);
            txtPhoneNumber.TabIndex = 5;
            // 
            // txtStudentStaffNumber
            // 
            txtStudentStaffNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtStudentStaffNumber.Location = new Point(330, 76);
            txtStudentStaffNumber.Name = "txtStudentStaffNumber";
            txtStudentStaffNumber.ReadOnly = true;
            txtStudentStaffNumber.Size = new Size(256, 27);
            txtStudentStaffNumber.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtName.Location = new Point(6, 76);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(252, 27);
            txtName.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 110);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 2;
            label6.Text = "Phone Number :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(330, 37);
            label5.Name = "label5";
            label5.Size = new Size(175, 20);
            label5.TabIndex = 1;
            label5.Text = "Student/Staff Number :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 37);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 0;
            label4.Text = "Patient Name :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvMedicalH);
            groupBox2.Location = new Point(248, 472);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(743, 265);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Medical History";
            // 
            // dgvMedicalH
            // 
            dgvMedicalH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicalH.Location = new Point(22, 26);
            dgvMedicalH.Name = "dgvMedicalH";
            dgvMedicalH.RowHeadersWidth = 51;
            dgvMedicalH.Size = new Size(644, 213);
            dgvMedicalH.TabIndex = 0;
            // 
            // Patient_Records
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 749);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(txtSearch);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Patient_Records";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient_Records";
            Load += Patient_Records_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMedicalH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Button btnLogout;
        private Button btnFollowUp;
        private Button btnPatientRecords;
        private Button btnViewAppointments;
        private Button btnDashboard;
        private PictureBox pictureBox1;
        private TextBox txtSearch;
        private Label label3;
        private Button button1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label7;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtStudentStaffNumber;
        private TextBox txtName;
        private Label label6;
        private GroupBox groupBox2;
        private DataGridView dgvMedicalH;
    }
}