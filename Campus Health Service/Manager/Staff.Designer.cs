namespace Campus_Health_Service.Manager
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnLogout = new Button();
            btnAppointments = new Button();
            btnReport = new Button();
            btnDashBoard = new Button();
            btnStaff = new Button();
            btnPatients = new Button();
            dgvStaff = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUsername = new TextBox();
            txtNPassword = new TextBox();
            txtCPassword = new TextBox();
            cbShowP = new CheckBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
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
            panel1.Size = new Size(952, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cardiogram;
            pictureBox1.Location = new Point(46, 43);
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
            label2.Location = new Point(223, 82);
            label2.Name = "label2";
            label2.Size = new Size(265, 23);
            label2.TabIndex = 1;
            label2.Text = "View Staff and edit the staff Info";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(212, 22);
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
            panel2.Controls.Add(btnAppointments);
            panel2.Controls.Add(btnReport);
            panel2.Controls.Add(btnDashBoard);
            panel2.Controls.Add(btnStaff);
            panel2.Controls.Add(btnPatients);
            panel2.Location = new Point(12, 152);
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
            // btnAppointments
            // 
            btnAppointments.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAppointments.Image = Properties.Resources.medical_appointment;
            btnAppointments.ImageAlign = ContentAlignment.MiddleLeft;
            btnAppointments.Location = new Point(-2, 78);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(250, 48);
            btnAppointments.TabIndex = 1;
            btnAppointments.Text = "Appointments";
            btnAppointments.UseVisualStyleBackColor = true;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // btnReport
            // 
            btnReport.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnReport.Image = Properties.Resources.generate_report;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(-2, 240);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(250, 48);
            btnReport.TabIndex = 4;
            btnReport.Text = "Generate Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnDashBoard
            // 
            btnDashBoard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDashBoard.Image = Properties.Resources.data;
            btnDashBoard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashBoard.Location = new Point(-2, 24);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(250, 48);
            btnDashBoard.TabIndex = 0;
            btnDashBoard.Text = "DashBoard";
            btnDashBoard.UseVisualStyleBackColor = true;
            btnDashBoard.Click += btnDashBoard_Click;
            // 
            // btnStaff
            // 
            btnStaff.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnStaff.Image = Properties.Resources.staff;
            btnStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnStaff.Location = new Point(-2, 186);
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
            btnPatients.Location = new Point(-2, 132);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(250, 48);
            btnPatients.TabIndex = 2;
            btnPatients.Text = "Patients";
            btnPatients.UseVisualStyleBackColor = true;
            btnPatients.Click += btnPatients_Click;
            // 
            // dgvStaff
            // 
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Location = new Point(268, 216);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.RowHeadersWidth = 51;
            dgvStaff.Size = new Size(682, 241);
            dgvStaff.TabIndex = 2;
            dgvStaff.CellClick += dgvStaff_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 489);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 3;
            label3.Text = "Username :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(282, 560);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 4;
            label4.Text = " New Password :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(282, 639);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 5;
            label5.Text = "Confirm Password :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(432, 489);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(384, 27);
            txtUsername.TabIndex = 6;
            // 
            // txtNPassword
            // 
            txtNPassword.Location = new Point(432, 560);
            txtNPassword.Name = "txtNPassword";
            txtNPassword.Size = new Size(384, 27);
            txtNPassword.TabIndex = 7;
            // 
            // txtCPassword
            // 
            txtCPassword.Location = new Point(432, 636);
            txtCPassword.Name = "txtCPassword";
            txtCPassword.Size = new Size(384, 27);
            txtCPassword.TabIndex = 8;
            // 
            // cbShowP
            // 
            cbShowP.AutoSize = true;
            cbShowP.Location = new Point(684, 678);
            cbShowP.Name = "cbShowP";
            cbShowP.Size = new Size(132, 24);
            cbShowP.TabIndex = 9;
            cbShowP.Text = "Show Password";
            cbShowP.UseVisualStyleBackColor = true;
            cbShowP.CheckedChanged += cbShowP_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(663, 708);
            button1.Name = "button1";
            button1.Size = new Size(153, 46);
            button1.TabIndex = 10;
            button1.Text = "Change Password";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 766);
            Controls.Add(button1);
            Controls.Add(cbShowP);
            Controls.Add(txtCPassword);
            Controls.Add(txtNPassword);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvStaff);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Staff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff";
            Load += Staff_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnAppointments;
        private Button btnDashBoard;
        private Button btnPatients;
        private Button btnStaff;
        private Button btnReport;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private DataGridView dgvStaff;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUsername;
        private TextBox txtNPassword;
        private TextBox txtCPassword;
        private CheckBox cbShowP;
        private Button button1;
    }
}