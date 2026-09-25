namespace Receptionist
{
    partial class Cancel_Appointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cancel_Appointments));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            btnLogout = new Button();
            btnEmergency = new Button();
            btnCancel = new Button();
            btnManageAppointments = new Button();
            btnBookAppointment = new Button();
            btnDashBoard = new Button();
            dvgAppointments = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            btnSearch = new Button();
            label5 = new Label();
            txtSearch = new TextBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            btnClear = new Button();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgAppointments).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1057, 132);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Campus_Health_Service.Properties.Resources.cardiogram;
            pictureBox1.Location = new Point(32, 20);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 89);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(153, 65);
            label4.Name = "label4";
            label4.Size = new Size(149, 18);
            label4.TabIndex = 1;
            label4.Text = "Appointment System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(153, 20);
            label3.Name = "label3";
            label3.Size = new Size(434, 44);
            label3.TabIndex = 0;
            label3.Text = "Campus Health Service";
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
            panel2.Size = new Size(228, 521);
            panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.Image = Campus_Health_Service.Properties.Resources.user_logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(-2, 450);
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
            btnEmergency.Location = new Point(-2, 309);
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
            btnCancel.Location = new Point(-2, 237);
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
            btnManageAppointments.Location = new Point(-2, 165);
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
            btnBookAppointment.Location = new Point(-2, 93);
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
            btnDashBoard.Location = new Point(-2, 21);
            btnDashBoard.Margin = new Padding(3, 4, 3, 4);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(229, 64);
            btnDashBoard.TabIndex = 0;
            btnDashBoard.Text = "Dashboard";
            btnDashBoard.UseVisualStyleBackColor = true;
            btnDashBoard.Click += btnHome_Click;
            // 
            // dvgAppointments
            // 
            dvgAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgAppointments.Location = new Point(248, 362);
            dvgAppointments.Margin = new Padding(3, 4, 3, 4);
            dvgAppointments.Name = "dvgAppointments";
            dvgAppointments.RowHeadersWidth = 51;
            dvgAppointments.Size = new Size(796, 219);
            dvgAppointments.TabIndex = 2;
            dvgAppointments.CellClick += dvgAppointments_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(104, 12);
            label1.Name = "label1";
            label1.Size = new Size(270, 32);
            label1.TabIndex = 3;
            label1.Text = "Booked Appointments";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Book Antiqua", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Image = Campus_Health_Service.Properties.Resources.x_button;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(838, 609);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(206, 47);
            button1.TabIndex = 4;
            button1.Text = "Cancel Appointments";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Blue;
            btnSearch.Font = new Font("Book Antiqua", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = Campus_Health_Service.Properties.Resources.magnifying_glass;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(530, 21);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 41);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 12);
            label5.Name = "label5";
            label5.Size = new Size(241, 19);
            label5.TabIndex = 7;
            label5.Text = "Search by student/Staff Number :";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(3, 35);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(521, 27);
            txtSearch.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 192);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(249, 588);
            panel3.Name = "panel3";
            panel3.Size = new Size(558, 85);
            panel3.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Campus_Health_Service.Properties.Resources.alert;
            pictureBox2.Location = new Point(3, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(83, 47);
            label6.Name = "label6";
            label6.Size = new Size(242, 20);
            label6.TabIndex = 1;
            label6.Text = "\"Cancel Appointment \" to cancel it ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(83, 20);
            label2.Name = "label2";
            label2.Size = new Size(350, 20);
            label2.TabIndex = 0;
            label2.Text = "Select an appointment form the list above and click";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 192, 255);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnClear);
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(btnSearch);
            panel4.Location = new Point(249, 270);
            panel4.Name = "panel4";
            panel4.Size = new Size(822, 75);
            panel4.TabIndex = 10;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(659, 21);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 41);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 192, 255);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(248, 157);
            panel5.Name = "panel5";
            panel5.Size = new Size(820, 107);
            panel5.TabIndex = 11;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Campus_Health_Service.Properties.Resources.cancel_booking;
            pictureBox3.Location = new Point(25, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(73, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(104, 54);
            label7.Name = "label7";
            label7.Size = new Size(525, 20);
            label7.TabIndex = 4;
            label7.Text = "View and manage the booked appointments.Select to cancel an appointment ";
            // 
            // Cancel_Appointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 691);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(dvgAppointments);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cancel_Appointments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cancel_Appointments";
            Load += Cancel_Appointments_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgAppointments).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
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
        private DataGridView dvgAppointments;
        private Label label1;
        private Button button1;
        private Label label4;
        private Label label3;
        private Button btnSearch;
        private Label label5;
        private TextBox txtSearch;
        private PictureBox pictureBox1;
        private Button btnLogout;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Label label6;
        private Panel panel5;
        private Label label7;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnClear;
    }
}