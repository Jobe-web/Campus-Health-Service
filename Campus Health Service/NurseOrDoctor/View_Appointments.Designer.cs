
namespace Campus_Health_Service.Nurse
{
    partial class View_Appointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Appointments));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label13 = new Label();
            label12 = new Label();
            panel2 = new Panel();
            btnViewAppointments = new Button();
            btnLogOut = new Button();
            btnFollowUp = new Button();
            btnPatientRecords = new Button();
            btnDashboard = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtpAppointmentDate = new DateTimePicker();
            label4 = new Label();
            cmbStatus = new ComboBox();
            btnRefresh = new Button();
            dgvAppointments = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtService = new TextBox();
            txtStudentNumber = new TextBox();
            txtPatientName = new TextBox();
            txtAppointmentID = new TextBox();
            grpAppointmentDetails = new GroupBox();
            cmbStatus2 = new ComboBox();
            dtpAppointmentDate2 = new DateTimePicker();
            grpUpdateStatus = new GroupBox();
            btnSaveStatus = new Button();
            cmbNewStatus = new ComboBox();
            label11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            grpAppointmentDetails.SuspendLayout();
            grpUpdateStatus.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1364, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cardiogram;
            pictureBox1.Location = new Point(38, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 62);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(180, 67);
            label13.Name = "label13";
            label13.Size = new Size(139, 20);
            label13.TabIndex = 1;
            label13.Text = "view Appointments\r\n";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(164, 17);
            label12.Name = "label12";
            label12.Size = new Size(484, 50);
            label12.TabIndex = 0;
            label12.Text = "CAMPUS HEALTH SERVICE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnViewAppointments);
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(btnFollowUp);
            panel2.Controls.Add(btnPatientRecords);
            panel2.Controls.Add(btnDashboard);
            panel2.Location = new Point(12, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 629);
            panel2.TabIndex = 1;
            // 
            // btnViewAppointments
            // 
            btnViewAppointments.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnViewAppointments.Image = Properties.Resources.medical_appointment;
            btnViewAppointments.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewAppointments.Location = new Point(-2, 120);
            btnViewAppointments.Name = "btnViewAppointments";
            btnViewAppointments.Size = new Size(228, 48);
            btnViewAppointments.TabIndex = 6;
            btnViewAppointments.Text = "View Appointments";
            btnViewAppointments.UseVisualStyleBackColor = true;
            btnViewAppointments.Click += btnViewAppointments_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnLogOut.Image = Properties.Resources.user_logout;
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(-2, 559);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(228, 48);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnFollowUp
            // 
            btnFollowUp.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnFollowUp.Image = Properties.Resources.follow_up;
            btnFollowUp.ImageAlign = ContentAlignment.MiddleLeft;
            btnFollowUp.Location = new Point(-2, 228);
            btnFollowUp.Name = "btnFollowUp";
            btnFollowUp.Size = new Size(228, 48);
            btnFollowUp.TabIndex = 3;
            btnFollowUp.Text = "Follow-Up";
            btnFollowUp.UseVisualStyleBackColor = true;
            btnFollowUp.Click += btnFollowUp_Click;
            // 
            // btnPatientRecords
            // 
            btnPatientRecords.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnPatientRecords.Image = Properties.Resources.health_report;
            btnPatientRecords.ImageAlign = ContentAlignment.MiddleLeft;
            btnPatientRecords.Location = new Point(-2, 174);
            btnPatientRecords.Name = "btnPatientRecords";
            btnPatientRecords.Size = new Size(228, 48);
            btnPatientRecords.TabIndex = 2;
            btnPatientRecords.Text = "Patient Records";
            btnPatientRecords.UseVisualStyleBackColor = true;
            btnPatientRecords.Click += button3_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnDashboard.Image = Properties.Resources.data;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(-2, 66);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(228, 48);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = " Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 231);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 2;
            label1.Text = "Date :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(268, 143);
            label2.Name = "label2";
            label2.Size = new Size(297, 41);
            label2.TabIndex = 3;
            label2.Text = "View Appointments";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(278, 184);
            label3.Name = "label3";
            label3.Size = new Size(285, 20);
            label3.TabIndex = 4;
            label3.Text = "View and Manage today's appointments";
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Location = new Point(322, 231);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(250, 27);
            dtpAppointmentDate.TabIndex = 5;
            dtpAppointmentDate.ValueChanged += dtpAppointmentDate_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(601, 236);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 6;
            label4.Text = "Status Filter :";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "BOOKED", "CHECKED IN", "FOLLOW-UP SCHEDULED", "COMPLETED", "CANCELLED" });
            cmbStatus.Location = new Point(700, 233);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(207, 28);
            cmbStatus.TabIndex = 7;
            cmbStatus.Text = "Select Status";
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Blue;
            btnRefresh.ForeColor = Color.Transparent;
            btnRefresh.Location = new Point(931, 232);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvAppointments
            // 
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(268, 280);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.Size = new Size(757, 341);
            dgvAppointments.TabIndex = 9;
            dgvAppointments.CellClick += dgvAppointments_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(15, 48);
            label5.Name = "label5";
            label5.Size = new Size(144, 23);
            label5.TabIndex = 0;
            label5.Text = "Appointment_ID :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(15, 105);
            label6.Name = "label6";
            label6.Size = new Size(125, 23);
            label6.TabIndex = 1;
            label6.Text = "Patient_Name :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(15, 158);
            label7.Name = "label7";
            label7.Size = new Size(204, 23);
            label7.TabIndex = 2;
            label7.Text = "StudentORStaff_Number :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(15, 211);
            label8.Name = "label8";
            label8.Size = new Size(72, 23);
            label8.TabIndex = 3;
            label8.Text = "Service :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.Location = new Point(15, 278);
            label9.Name = "label9";
            label9.Size = new Size(163, 23);
            label9.TabIndex = 4;
            label9.Text = "Appointment_Date :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F);
            label10.Location = new Point(15, 341);
            label10.Name = "label10";
            label10.Size = new Size(173, 23);
            label10.TabIndex = 5;
            label10.Text = "Appointment_Status :";
            // 
            // txtService
            // 
            txtService.Enabled = false;
            txtService.Font = new Font("Segoe UI", 10.2F);
            txtService.Location = new Point(15, 241);
            txtService.Name = "txtService";
            txtService.Size = new Size(293, 30);
            txtService.TabIndex = 11;
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Enabled = false;
            txtStudentNumber.Font = new Font("Segoe UI", 10.2F);
            txtStudentNumber.Location = new Point(15, 181);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(293, 30);
            txtStudentNumber.TabIndex = 14;
            // 
            // txtPatientName
            // 
            txtPatientName.Enabled = false;
            txtPatientName.Font = new Font("Segoe UI", 10.2F);
            txtPatientName.Location = new Point(15, 128);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(293, 30);
            txtPatientName.TabIndex = 15;
            // 
            // txtAppointmentID
            // 
            txtAppointmentID.Enabled = false;
            txtAppointmentID.Font = new Font("Segoe UI", 10.2F);
            txtAppointmentID.Location = new Point(15, 75);
            txtAppointmentID.Name = "txtAppointmentID";
            txtAppointmentID.Size = new Size(293, 30);
            txtAppointmentID.TabIndex = 7;
            // 
            // grpAppointmentDetails
            // 
            grpAppointmentDetails.Controls.Add(cmbStatus2);
            grpAppointmentDetails.Controls.Add(dtpAppointmentDate2);
            grpAppointmentDetails.Controls.Add(txtPatientName);
            grpAppointmentDetails.Controls.Add(label10);
            grpAppointmentDetails.Controls.Add(txtService);
            grpAppointmentDetails.Controls.Add(label9);
            grpAppointmentDetails.Controls.Add(txtStudentNumber);
            grpAppointmentDetails.Controls.Add(label5);
            grpAppointmentDetails.Controls.Add(txtAppointmentID);
            grpAppointmentDetails.Controls.Add(label8);
            grpAppointmentDetails.Controls.Add(label6);
            grpAppointmentDetails.Controls.Add(label7);
            grpAppointmentDetails.Enabled = false;
            grpAppointmentDetails.FlatStyle = FlatStyle.System;
            grpAppointmentDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAppointmentDetails.Location = new Point(1045, 155);
            grpAppointmentDetails.Name = "grpAppointmentDetails";
            grpAppointmentDetails.Size = new Size(331, 417);
            grpAppointmentDetails.TabIndex = 0;
            grpAppointmentDetails.TabStop = false;
            grpAppointmentDetails.Text = "Appointment Details";
            grpAppointmentDetails.Enter += grpAppointmentDetails_Enter;
            // 
            // cmbStatus2
            // 
            cmbStatus2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus2.FormattingEnabled = true;
            cmbStatus2.Items.AddRange(new object[] { "BOOKED", "CHECKED IN", "FOLLOW-UP SCHEDULED", "COMPLETED", "CANCELLED" });
            cmbStatus2.Location = new Point(15, 367);
            cmbStatus2.Name = "cmbStatus2";
            cmbStatus2.Size = new Size(293, 31);
            cmbStatus2.TabIndex = 17;
            cmbStatus2.Text = "Status";
            cmbStatus2.SelectedIndexChanged += cmbStatus2_SelectedIndexChanged;
            // 
            // dtpAppointmentDate2
            // 
            dtpAppointmentDate2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpAppointmentDate2.Location = new Point(15, 304);
            dtpAppointmentDate2.Name = "dtpAppointmentDate2";
            dtpAppointmentDate2.Size = new Size(293, 31);
            dtpAppointmentDate2.TabIndex = 16;
            // 
            // grpUpdateStatus
            // 
            grpUpdateStatus.Controls.Add(btnSaveStatus);
            grpUpdateStatus.Controls.Add(cmbNewStatus);
            grpUpdateStatus.Controls.Add(label11);
            grpUpdateStatus.FlatStyle = FlatStyle.System;
            grpUpdateStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpUpdateStatus.Location = new Point(1045, 594);
            grpUpdateStatus.Name = "grpUpdateStatus";
            grpUpdateStatus.Size = new Size(331, 178);
            grpUpdateStatus.TabIndex = 10;
            grpUpdateStatus.TabStop = false;
            grpUpdateStatus.Text = "Update Appointment Status";
            // 
            // btnSaveStatus
            // 
            btnSaveStatus.BackColor = Color.Blue;
            btnSaveStatus.ForeColor = Color.Transparent;
            btnSaveStatus.Location = new Point(99, 110);
            btnSaveStatus.Name = "btnSaveStatus";
            btnSaveStatus.Size = new Size(120, 42);
            btnSaveStatus.TabIndex = 2;
            btnSaveStatus.Text = "Save Status";
            btnSaveStatus.UseVisualStyleBackColor = false;
            btnSaveStatus.Click += btnSaveStatus_Click;
            // 
            // cmbNewStatus
            // 
            cmbNewStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbNewStatus.FormattingEnabled = true;
            cmbNewStatus.Items.AddRange(new object[] { "BOOKED", "CHECKED IN", "COMPLETED", "CANCELLED" });
            cmbNewStatus.Location = new Point(6, 60);
            cmbNewStatus.Name = "cmbNewStatus";
            cmbNewStatus.Size = new Size(277, 31);
            cmbNewStatus.TabIndex = 1;
            cmbNewStatus.Text = "Select Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(6, 37);
            label11.Name = "label11";
            label11.Size = new Size(90, 20);
            label11.TabIndex = 0;
            label11.Text = "New Status :";
            // 
            // View_Appointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 796);
            Controls.Add(grpUpdateStatus);
            Controls.Add(grpAppointmentDetails);
            Controls.Add(dgvAppointments);
            Controls.Add(btnRefresh);
            Controls.Add(cmbStatus);
            Controls.Add(label4);
            Controls.Add(dtpAppointmentDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "View_Appointments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View_Appointments";
            Load += View_Appointments_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            grpAppointmentDetails.ResumeLayout(false);
            grpAppointmentDetails.PerformLayout();
            grpUpdateStatus.ResumeLayout(false);
            grpUpdateStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
       
        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpAppointmentDate;
        private Label label4;
        private ComboBox cmbStatus;
        private Button btnRefresh;
        private DataGridView dgvAppointments;
        private Panel panel3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtAppointmentID;
        private GroupBox grpAppointmentDetails;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox1;
        private Label label10;
        private TextBox txtService;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txtStudentNumber;
        private TextBox txtPatientName;
        private GroupBox grpUpdateStatus;
        private Button btnSaveStatus;
        private ComboBox cmbNewStatus;
        private Label label11;
        private PictureBox pictureBox1;
        private Label label13;
        private Label label12;
        private ComboBox cmbStatus2;
        private DateTimePicker dtpAppointmentDate2;
        private Button btnLogOut;
        private Button btnFollowUp;
        private Button btnPatientRecords;
        private Button btnDashboard;
        private Button btnViewAppointments;
    }
}