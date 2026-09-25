namespace Receptionist
{
    partial class Manage_Appointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Appointments));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnLogout = new Button();
            btnEmergency = new Button();
            btnCancel = new Button();
            btnManageAppointments = new Button();
            btnBookAppointment = new Button();
            btnDashBoard = new Button();
            dgvAppointments = new DataGridView();
            label3 = new Label();
            btnReschedule = new Button();
            label4 = new Label();
            dtpDate = new DateTimePicker();
            label5 = new Label();
            cmbTime = new ComboBox();
            txtSearch = new TextBox();
            label6 = new Label();
            btnSearch = new Button();
            btnClear = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
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
            panel1.Size = new Size(863, 132);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Campus_Health_Service.Properties.Resources.cardiogram;
            pictureBox1.Location = new Point(16, 15);
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
            label2.Location = new Point(137, 60);
            label2.Name = "label2";
            label2.Size = new Size(149, 18);
            label2.TabIndex = 1;
            label2.Text = "Appointment System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(137, 15);
            label1.Name = "label1";
            label1.Size = new Size(434, 44);
            label1.TabIndex = 0;
            label1.Text = "Campus Health Service";
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
            panel2.Size = new Size(228, 524);
            panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.Image = Campus_Health_Service.Properties.Resources.user_logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(-2, 453);
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
            btnEmergency.Location = new Point(-2, 304);
            btnEmergency.Margin = new Padding(3, 4, 3, 4);
            btnEmergency.Name = "btnEmergency";
            btnEmergency.Size = new Size(229, 64);
            btnEmergency.TabIndex = 4;
            btnEmergency.Text = "Emergency";
            btnEmergency.UseVisualStyleBackColor = true;
            btnEmergency.Click += btnEmergency_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.Image = Campus_Health_Service.Properties.Resources.calendar__1_;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(-2, 232);
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
            btnManageAppointments.Location = new Point(-2, 160);
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
            btnBookAppointment.Location = new Point(-2, 88);
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
            btnDashBoard.Location = new Point(-2, 16);
            btnDashBoard.Margin = new Padding(3, 4, 3, 4);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(229, 64);
            btnDashBoard.TabIndex = 0;
            btnDashBoard.Text = "Dashboard";
            btnDashBoard.UseVisualStyleBackColor = true;
            btnDashBoard.Click += btnHome_Click;
            // 
            // dgvAppointments
            // 
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(249, 305);
            dgvAppointments.Margin = new Padding(3, 4, 3, 4);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.Size = new Size(629, 200);
            dgvAppointments.TabIndex = 2;
            dgvAppointments.CellClick += dgvAppointments_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(249, 157);
            label3.Name = "label3";
            label3.Size = new Size(252, 31);
            label3.TabIndex = 3;
            label3.Text = "Booked Appointments";
            // 
            // btnReschedule
            // 
            btnReschedule.BackColor = Color.Blue;
            btnReschedule.Font = new Font("Book Antiqua", 9F, FontStyle.Bold);
            btnReschedule.ForeColor = Color.White;
            btnReschedule.Image = Campus_Health_Service.Properties.Resources.reschedule;
            btnReschedule.ImageAlign = ContentAlignment.MiddleLeft;
            btnReschedule.Location = new Point(656, 579);
            btnReschedule.Margin = new Padding(3, 4, 3, 4);
            btnReschedule.Name = "btnReschedule";
            btnReschedule.Size = new Size(221, 48);
            btnReschedule.TabIndex = 4;
            btnReschedule.Text = "Reschedule Appointment";
            btnReschedule.TextAlign = ContentAlignment.MiddleRight;
            btnReschedule.UseVisualStyleBackColor = false;
            btnReschedule.Click += btnReschedule_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(249, 521);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "Date :";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dtpDate.Location = new Point(313, 513);
            dtpDate.Margin = new Padding(3, 4, 3, 4);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(258, 27);
            dtpDate.TabIndex = 6;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(577, 517);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 7;
            label5.Text = "Time :";
            // 
            // cmbTime
            // 
            cmbTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbTime.FormattingEnabled = true;
            cmbTime.Items.AddRange(new object[] { "08:00 - 09:00", "09:00 - 10:00", "10:00 - 11:00", "11:00 - 12:00", "13:00 - 14:00", "14:00 - 15:00", "15:00 - 16:00", "16:00 - 17:00" });
            cmbTime.Location = new Point(631, 513);
            cmbTime.Margin = new Padding(3, 4, 3, 4);
            cmbTime.Name = "cmbTime";
            cmbTime.Size = new Size(246, 28);
            cmbTime.TabIndex = 8;
            cmbTime.SelectedIndexChanged += cmbTime_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(249, 267);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(473, 27);
            txtSearch.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(262, 231);
            label6.Name = "label6";
            label6.Size = new Size(241, 19);
            label6.TabIndex = 10;
            label6.Text = "Search by student/Staff Number :";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Blue;
            btnSearch.Font = new Font("Book Antiqua", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = Campus_Health_Service.Properties.Resources.magnifying_glass;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(752, 256);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(126, 41);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(493, 579);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 48);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear Search";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Manage_Appointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 694);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(label6);
            Controls.Add(txtSearch);
            Controls.Add(cmbTime);
            Controls.Add(label5);
            Controls.Add(dtpDate);
            Controls.Add(label4);
            Controls.Add(btnReschedule);
            Controls.Add(label3);
            Controls.Add(dgvAppointments);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Manage_Appointments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage_Appointments";
            Load += Manage_Appointments_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnEmergency;
        private Button btnCancel;
        private Button btnManageAppointments;
        private Button btnBookAppointment;
        private Button btnDashBoard;
        private Label label2;
        private Label label1;
        private DataGridView dgvAppointments;
        private Label label3;
        private Button btnReschedule;
        private Label label4;
        private DateTimePicker dtpDate;
        private Label label5;
        private ComboBox cmbTime;
        private TextBox txtSearch;
        private Label label6;
        private Button btnSearch;
        private PictureBox pictureBox1;
        private Button btnLogout;
        private Button btnClear;
    }
}