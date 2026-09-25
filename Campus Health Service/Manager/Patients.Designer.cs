namespace Campus_Health_Service.Manager
{
    partial class Patients
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnLogout = new Button();
            btnDashBoard = new Button();
            btnReport = new Button();
            btnAppointments = new Button();
            btnStaff = new Button();
            btnPatients = new Button();
            groupBox1 = new GroupBox();
            txtAppointments = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtStudentStaffNumber = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label8 = new Label();
            cmbPatient = new ComboBox();
            chartAppointmentTypes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartAppointmentTypes).BeginInit();
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
            panel1.Size = new Size(1412, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cardiogram;
            pictureBox1.Location = new Point(38, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(207, 71);
            label2.Name = "label2";
            label2.Size = new Size(176, 23);
            label2.TabIndex = 1;
            label2.Text = "View Patients records";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 21);
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
            panel2.Controls.Add(btnDashBoard);
            panel2.Controls.Add(btnReport);
            panel2.Controls.Add(btnAppointments);
            panel2.Controls.Add(btnStaff);
            panel2.Controls.Add(btnPatients);
            panel2.Location = new Point(12, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 588);
            panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLogout.Image = Properties.Resources.user_logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(-2, 524);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(250, 48);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDashBoard
            // 
            btnDashBoard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDashBoard.Image = Properties.Resources.data;
            btnDashBoard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashBoard.Location = new Point(-2, 26);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(250, 48);
            btnDashBoard.TabIndex = 0;
            btnDashBoard.Text = "DashBoard";
            btnDashBoard.UseVisualStyleBackColor = true;
            btnDashBoard.Click += btnDashBoard_Click;
            // 
            // btnReport
            // 
            btnReport.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnReport.Image = Properties.Resources.generate_report;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(-2, 242);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(250, 48);
            btnReport.TabIndex = 4;
            btnReport.Text = "Generate Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnAppointments
            // 
            btnAppointments.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAppointments.Image = Properties.Resources.medical_appointment;
            btnAppointments.ImageAlign = ContentAlignment.MiddleLeft;
            btnAppointments.Location = new Point(-2, 80);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(250, 48);
            btnAppointments.TabIndex = 1;
            btnAppointments.Text = "Appointments";
            btnAppointments.UseVisualStyleBackColor = true;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // btnStaff
            // 
            btnStaff.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnStaff.Image = Properties.Resources.staff;
            btnStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnStaff.Location = new Point(-2, 188);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(250, 48);
            btnStaff.TabIndex = 3;
            btnStaff.Text = "Staff";
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // btnPatients
            // 
            btnPatients.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnPatients.Image = Properties.Resources.patients;
            btnPatients.ImageAlign = ContentAlignment.MiddleLeft;
            btnPatients.Location = new Point(-2, 134);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(250, 48);
            btnPatients.TabIndex = 2;
            btnPatients.Text = "Patients";
            btnPatients.UseVisualStyleBackColor = true;
            btnPatients.Click += btnPatients_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAppointments);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(txtStudentStaffNumber);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(268, 235);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(658, 413);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patients Information";
            // 
            // txtAppointments
            // 
            txtAppointments.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            txtAppointments.ForeColor = Color.Black;
            txtAppointments.Location = new Point(234, 298);
            txtAppointments.Name = "txtAppointments";
            txtAppointments.ReadOnly = true;
            txtAppointments.Size = new Size(399, 30);
            txtAppointments.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(234, 237);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(399, 30);
            txtEmail.TabIndex = 8;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            txtPhoneNumber.ForeColor = Color.Black;
            txtPhoneNumber.Location = new Point(234, 177);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(399, 30);
            txtPhoneNumber.TabIndex = 7;
            // 
            // txtStudentStaffNumber
            // 
            txtStudentStaffNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            txtStudentStaffNumber.ForeColor = Color.Black;
            txtStudentStaffNumber.Location = new Point(234, 119);
            txtStudentStaffNumber.Name = "txtStudentStaffNumber";
            txtStudentStaffNumber.ReadOnly = true;
            txtStudentStaffNumber.Size = new Size(399, 30);
            txtStudentStaffNumber.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(234, 52);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(399, 30);
            txtName.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(25, 305);
            label7.Name = "label7";
            label7.Size = new Size(179, 23);
            label7.TabIndex = 4;
            label7.Text = "Total Appointments :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(25, 244);
            label6.Name = "label6";
            label6.Size = new Size(64, 23);
            label6.TabIndex = 3;
            label6.Text = "Email :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(25, 180);
            label5.Name = "label5";
            label5.Size = new Size(140, 23);
            label5.TabIndex = 2;
            label5.Text = "Phone Number :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(25, 126);
            label4.Name = "label4";
            label4.Size = new Size(203, 23);
            label4.TabIndex = 1;
            label4.Text = "Student/Staff Number :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(25, 55);
            label3.Name = "label3";
            label3.Size = new Size(129, 23);
            label3.TabIndex = 0;
            label3.Text = "Patient Name :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label8.Location = new Point(295, 180);
            label8.Name = "label8";
            label8.Size = new Size(130, 23);
            label8.TabIndex = 3;
            label8.Text = "Select Patient :";
            // 
            // cmbPatient
            // 
            cmbPatient.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            cmbPatient.FormattingEnabled = true;
            cmbPatient.Location = new Point(421, 180);
            cmbPatient.Name = "cmbPatient";
            cmbPatient.Size = new Size(274, 31);
            cmbPatient.TabIndex = 4;
            cmbPatient.Text = "Select P";
            cmbPatient.SelectedIndexChanged += cmbPatient_SelectedIndexChanged;
            // 
            // chartAppointmentTypes
            // 
            chartArea1.AxisX.Title = "Appointment Type";
            chartArea1.AxisY.Title = "Number of Appointments";
            chartArea1.Name = "ServicesArea";
            chartAppointmentTypes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartAppointmentTypes.Legends.Add(legend1);
            chartAppointmentTypes.Location = new Point(950, 235);
            chartAppointmentTypes.Name = "chartAppointmentTypes";
            series1.ChartArea = "ServicesArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.CustomProperties = "DrawSideBySide=True";
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Appointment Types";
            chartAppointmentTypes.Series.Add(series1);
            chartAppointmentTypes.Size = new Size(474, 413);
            chartAppointmentTypes.TabIndex = 5;
            chartAppointmentTypes.Text = "chart1";
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1459, 743);
            Controls.Add(chartAppointmentTypes);
            Controls.Add(cmbPatient);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Patients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patients";
            Load += Patients_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartAppointmentTypes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnLogout;
        private Button btnDashBoard;
        private Button btnReport;
        private Button btnAppointments;
        private Button btnStaff;
        private Button btnPatients;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtAppointments;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtStudentStaffNumber;
        private TextBox txtName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private ComboBox cmbPatient;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAppointmentTypes;
    }
}