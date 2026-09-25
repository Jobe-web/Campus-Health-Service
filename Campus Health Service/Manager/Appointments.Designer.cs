
namespace Campus_Health_Service.Manager
{
    partial class Appointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointments));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnLogout = new Button();
            btnDashBoard = new Button();
            btnStaff = new Button();
            btnReport = new Button();
            btnPatients = new Button();
            btnAppointments = new Button();
            label3 = new Label();
            dtpDateSearch = new DateTimePicker();
            dgvAppointments = new DataGridView();
            chartAppointmentStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnShowAllAppointments = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartAppointmentStatus).BeginInit();
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
            panel1.Size = new Size(1286, 125);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cardiogram;
            pictureBox1.Location = new Point(27, 26);
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
            label2.Location = new Point(173, 65);
            label2.Name = "label2";
            label2.Size = new Size(191, 23);
            label2.TabIndex = 1;
            label2.Text = "View All appointments ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 15);
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
            panel2.Controls.Add(btnStaff);
            panel2.Controls.Add(btnReport);
            panel2.Controls.Add(btnPatients);
            panel2.Controls.Add(btnAppointments);
            panel2.Location = new Point(12, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 520);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLogout.Image = Properties.Resources.user_logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(-2, 465);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(250, 48);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDashBoard
            // 
            btnDashBoard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDashBoard.Image = Properties.Resources.data;
            btnDashBoard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashBoard.Location = new Point(-2, 32);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(250, 48);
            btnDashBoard.TabIndex = 2;
            btnDashBoard.Text = "DashBoard";
            btnDashBoard.UseVisualStyleBackColor = true;
            btnDashBoard.Click += btnDashBoard_Click;
            // 
            // btnStaff
            // 
            btnStaff.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnStaff.Image = Properties.Resources.staff;
            btnStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnStaff.Location = new Point(-2, 194);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(250, 48);
            btnStaff.TabIndex = 5;
            btnStaff.Text = "Staff";
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // btnReport
            // 
            btnReport.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnReport.Image = Properties.Resources.generate_report;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(-2, 248);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(250, 48);
            btnReport.TabIndex = 6;
            btnReport.Text = "Generate Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnPatients
            // 
            btnPatients.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnPatients.Image = Properties.Resources.patients;
            btnPatients.ImageAlign = ContentAlignment.MiddleLeft;
            btnPatients.Location = new Point(-2, 140);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(250, 48);
            btnPatients.TabIndex = 4;
            btnPatients.Text = "Patients";
            btnPatients.UseVisualStyleBackColor = true;
            btnPatients.Click += btnPatients_Click;
            // 
            // btnAppointments
            // 
            btnAppointments.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAppointments.Image = Properties.Resources.medical_appointment;
            btnAppointments.ImageAlign = ContentAlignment.MiddleLeft;
            btnAppointments.Location = new Point(-2, 86);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(250, 48);
            btnAppointments.TabIndex = 3;
            btnAppointments.Text = "Appointments";
            btnAppointments.UseVisualStyleBackColor = true;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(279, 165);
            label3.Name = "label3";
            label3.Size = new Size(264, 23);
            label3.TabIndex = 2;
            label3.Text = "Search Appointment  by Date : ";
            // 
            // dtpDateSearch
            // 
            dtpDateSearch.Location = new Point(279, 198);
            dtpDateSearch.Name = "dtpDateSearch";
            dtpDateSearch.Size = new Size(286, 27);
            dtpDateSearch.TabIndex = 3;
            dtpDateSearch.ValueChanged += dtpDateSearch_ValueChanged;
            // 
            // dgvAppointments
            // 
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(279, 253);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.Size = new Size(632, 405);
            dgvAppointments.TabIndex = 4;
            // 
            // chartAppointmentStatus
            // 
            chartArea1.Name = "StatusArea";
            chartAppointmentStatus.ChartAreas.Add(chartArea1);
            legend1.Alignment = StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            chartAppointmentStatus.Legends.Add(legend1);
            chartAppointmentStatus.Location = new Point(923, 253);
            chartAppointmentStatus.Name = "chartAppointmentStatus";
            series1.ChartArea = "StatusArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.Label = "#VALX: #VALY";
            series1.Legend = "Legend1";
            series1.LegendText = "#VALX";
            series1.Name = "Appointment Status";
            chartAppointmentStatus.Series.Add(series1);
            chartAppointmentStatus.Size = new Size(375, 405);
            chartAppointmentStatus.TabIndex = 5;
            chartAppointmentStatus.Text = "chart1";
            // 
            // btnShowAllAppointments
            // 
            btnShowAllAppointments.BackColor = Color.Blue;
            btnShowAllAppointments.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAllAppointments.ForeColor = Color.White;
            btnShowAllAppointments.Location = new Point(791, 188);
            btnShowAllAppointments.Name = "btnShowAllAppointments";
            btnShowAllAppointments.Size = new Size(94, 37);
            btnShowAllAppointments.TabIndex = 6;
            btnShowAllAppointments.Text = "Show All";
            btnShowAllAppointments.UseVisualStyleBackColor = false;
            btnShowAllAppointments.Click += btnShowAllAppointments_Click;
            // 
            // Appointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 675);
            Controls.Add(btnShowAllAppointments);
            Controls.Add(chartAppointmentStatus);
            Controls.Add(dgvAppointments);
            Controls.Add(dtpDateSearch);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Appointments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointments";
            Load += Appointments_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartAppointmentStatus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnDashBoard;
        private Button btnAppointments;
        private Button btnPatients;
        private Button btnStaff;
        private Button btnReport;
        private Button btnLogout;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private DateTimePicker dtpDateSearch;
        private DataGridView dgvAppointments;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAppointmentStatus;
        private Button btnShowAllAppointments;
    }
}