namespace Campus_Health_Service.Manager
{
    partial class Generate_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generate_Report));
            btnDashBoard = new Button();
            btnAppointments = new Button();
            btnPatients = new Button();
            btnStaff = new Button();
            btnReport = new Button();
            btnLogout = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            cmbPatient = new ComboBox();
            label7 = new Label();
            dtpDateTo = new DateTimePicker();
            dtpDateFrom = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            cmbReportType = new ComboBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            rbPDF = new RadioButton();
            rbExcel = new RadioButton();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDashBoard
            // 
            btnDashBoard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDashBoard.Image = Properties.Resources.data;
            btnDashBoard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashBoard.Location = new Point(-2, 20);
            btnDashBoard.Margin = new Padding(4, 3, 4, 3);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(312, 55);
            btnDashBoard.TabIndex = 0;
            btnDashBoard.Text = "DashBoard";
            btnDashBoard.UseVisualStyleBackColor = true;
            btnDashBoard.Click += btnDashBoard_Click;
            // 
            // btnAppointments
            // 
            btnAppointments.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAppointments.Image = Properties.Resources.medical_appointment;
            btnAppointments.ImageAlign = ContentAlignment.MiddleLeft;
            btnAppointments.Location = new Point(-2, 82);
            btnAppointments.Margin = new Padding(4, 3, 4, 3);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(312, 55);
            btnAppointments.TabIndex = 1;
            btnAppointments.Text = "Appointments";
            btnAppointments.UseVisualStyleBackColor = true;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // btnPatients
            // 
            btnPatients.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnPatients.Image = Properties.Resources.patients;
            btnPatients.ImageAlign = ContentAlignment.MiddleLeft;
            btnPatients.Location = new Point(-2, 144);
            btnPatients.Margin = new Padding(4, 3, 4, 3);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(312, 55);
            btnPatients.TabIndex = 2;
            btnPatients.Text = "Patients";
            btnPatients.UseVisualStyleBackColor = true;
            btnPatients.Click += btnPatients_Click;
            // 
            // btnStaff
            // 
            btnStaff.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnStaff.Image = Properties.Resources.staff;
            btnStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnStaff.Location = new Point(-2, 206);
            btnStaff.Margin = new Padding(4, 3, 4, 3);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(312, 55);
            btnStaff.TabIndex = 3;
            btnStaff.Text = "Staff";
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // btnReport
            // 
            btnReport.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnReport.Image = Properties.Resources.generate_report;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(-2, 268);
            btnReport.Margin = new Padding(4, 3, 4, 3);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(312, 55);
            btnReport.TabIndex = 4;
            btnReport.Text = "Generate Report";
            btnReport.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLogout.Image = Properties.Resources.user_logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(-2, 613);
            btnLogout.Margin = new Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(312, 55);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(15, 14);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1256, 143);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cardiogram;
            pictureBox1.Location = new Point(26, 33);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(190, 78);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 23);
            label2.TabIndex = 1;
            label2.Text = "Generate report ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(484, 50);
            label1.TabIndex = 0;
            label1.Text = "CAMPUS HEALTH SERVICE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnDashBoard);
            panel2.Controls.Add(btnAppointments);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnPatients);
            panel2.Controls.Add(btnReport);
            panel2.Controls.Add(btnStaff);
            panel2.Location = new Point(15, 174);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 676);
            panel2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(335, 174);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(233, 38);
            label3.TabIndex = 8;
            label3.Text = "Generate Report";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(cmbPatient);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(dtpDateTo);
            panel3.Controls.Add(dtpDateFrom);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(cmbReportType);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(335, 231);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(810, 317);
            panel3.TabIndex = 9;
            // 
            // cmbPatient
            // 
            cmbPatient.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPatient.FormattingEnabled = true;
            cmbPatient.Location = new Point(35, 130);
            cmbPatient.Name = "cmbPatient";
            cmbPatient.Size = new Size(722, 31);
            cmbPatient.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 104);
            label7.Name = "label7";
            label7.Size = new Size(161, 23);
            label7.TabIndex = 6;
            label7.Text = "Select the Patient :";
            // 
            // dtpDateTo
            // 
            dtpDateTo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            dtpDateTo.Format = DateTimePickerFormat.Short;
            dtpDateTo.Location = new Point(445, 222);
            dtpDateTo.Margin = new Padding(4, 3, 4, 3);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(312, 30);
            dtpDateTo.TabIndex = 5;
            dtpDateTo.ValueChanged += dtpDateTo_ValueChanged;
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            dtpDateFrom.Format = DateTimePickerFormat.Short;
            dtpDateFrom.Location = new Point(35, 222);
            dtpDateFrom.Margin = new Padding(4, 3, 4, 3);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(312, 30);
            dtpDateFrom.TabIndex = 4;
            dtpDateFrom.ValueChanged += dtpDateFrom_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.Location = new Point(445, 166);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 23);
            label6.TabIndex = 3;
            label6.Text = "Date To:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(35, 166);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 2;
            label5.Text = "Date From:";
            // 
            // cmbReportType
            // 
            cmbReportType.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Items.AddRange(new object[] { "Daily Appointment Schedule", "Patient Report", "Cancellation, Rescheduling & Follow-Up Report", "Urgent Appointment Report", "All Records" });
            cmbReportType.Location = new Point(35, 49);
            cmbReportType.Margin = new Padding(4, 3, 4, 3);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(722, 31);
            cmbReportType.TabIndex = 1;
            cmbReportType.Text = "Select the Type of report you want";
            cmbReportType.SelectedIndexChanged += cmbReportType_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(35, 20);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 0;
            label4.Text = "Report Type:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbPDF);
            groupBox1.Controls.Add(rbExcel);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(335, 578);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(810, 194);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Export Format :";
            // 
            // rbPDF
            // 
            rbPDF.AutoSize = true;
            rbPDF.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            rbPDF.Location = new Point(594, 77);
            rbPDF.Margin = new Padding(4, 3, 4, 3);
            rbPDF.Name = "rbPDF";
            rbPDF.Size = new Size(78, 35);
            rbPDF.TabIndex = 1;
            rbPDF.TabStop = true;
            rbPDF.Text = "PDF";
            rbPDF.UseVisualStyleBackColor = true;
            // 
            // rbExcel
            // 
            rbExcel.AutoSize = true;
            rbExcel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            rbExcel.Location = new Point(72, 77);
            rbExcel.Margin = new Padding(4, 3, 4, 3);
            rbExcel.Name = "rbExcel";
            rbExcel.Size = new Size(96, 35);
            rbExcel.TabIndex = 0;
            rbExcel.TabStop = true;
            rbExcel.Text = "Excel ";
            rbExcel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(911, 794);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(234, 46);
            button1.TabIndex = 11;
            button1.Text = "Generate Report ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Generate_Report
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 861);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Generate_Report";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generate_Report";
            Load += Generate_Report_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDashBoard;
        private Button btnAppointments;
        private Button btnPatients;
        private Button btnStaff;
        private Button btnReport;
        private Button btnLogout;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private DateTimePicker dtpDateTo;
        private DateTimePicker dtpDateFrom;
        private Label label6;
        private Label label5;
        private ComboBox cmbReportType;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton rbPDF;
        private RadioButton rbExcel;
        private Button button1;
        private ComboBox cmbPatient;
        private Label label7;
    }
}