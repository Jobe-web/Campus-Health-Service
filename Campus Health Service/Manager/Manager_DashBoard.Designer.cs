namespace Campus_Health_Service.Manager
{
    partial class Manager_DashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_DashBoard));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            btnLogout = new Button();
            btnReport = new Button();
            btnStaff = new Button();
            btnPatients = new Button();
            btnAppointments = new Button();
            btnDashBoard = new Button();
            pnlTotalPatients = new Panel();
            pbPatients = new PictureBox();
            lblTPatients = new Label();
            label1 = new Label();
            pnlTotalAppointments = new Panel();
            pbAppointment = new PictureBox();
            lblTAppointments = new Label();
            label2 = new Label();
            pnlEmergencyCase = new Panel();
            pbEmergency = new PictureBox();
            lblEmergency = new Label();
            label3 = new Label();
            pnlFollowUP = new Panel();
            pbFollowUp = new PictureBox();
            lblFollowUp = new Label();
            label4 = new Label();
            chartAppointments = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartAppointmentStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            pnlTotalPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPatients).BeginInit();
            pnlTotalAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAppointment).BeginInit();
            pnlEmergencyCase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEmergency).BeginInit();
            pnlFollowUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFollowUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartAppointmentStatus).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1593, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cardiogram;
            pictureBox1.Location = new Point(64, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(206, 76);
            label8.Name = "label8";
            label8.Size = new Size(168, 23);
            label8.TabIndex = 1;
            label8.Text = "Manager DashBoard";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(195, 16);
            label7.Name = "label7";
            label7.Size = new Size(484, 50);
            label7.TabIndex = 0;
            label7.Text = "CAMPUS HEALTH SERVICE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnReport);
            panel2.Controls.Add(btnStaff);
            panel2.Controls.Add(btnPatients);
            panel2.Controls.Add(btnAppointments);
            panel2.Controls.Add(btnDashBoard);
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
            btnLogout.Location = new Point(-2, 533);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(250, 48);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReport
            // 
            btnReport.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnReport.Image = Properties.Resources.generate_report;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(-2, 258);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(250, 48);
            btnReport.TabIndex = 4;
            btnReport.Text = "Generate Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnStaff
            // 
            btnStaff.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnStaff.Image = Properties.Resources.staff;
            btnStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnStaff.Location = new Point(-2, 204);
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
            btnPatients.Location = new Point(-2, 150);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(250, 48);
            btnPatients.TabIndex = 2;
            btnPatients.Text = "Patients";
            btnPatients.UseVisualStyleBackColor = true;
            btnPatients.Click += btnPatients_Click;
            // 
            // btnAppointments
            // 
            btnAppointments.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAppointments.Image = Properties.Resources.medical_appointment;
            btnAppointments.ImageAlign = ContentAlignment.MiddleLeft;
            btnAppointments.Location = new Point(-2, 96);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(250, 48);
            btnAppointments.TabIndex = 1;
            btnAppointments.Text = "Appointments";
            btnAppointments.UseVisualStyleBackColor = true;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // btnDashBoard
            // 
            btnDashBoard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDashBoard.Image = Properties.Resources.data;
            btnDashBoard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashBoard.Location = new Point(-2, 42);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(250, 48);
            btnDashBoard.TabIndex = 0;
            btnDashBoard.Text = "DashBoard";
            btnDashBoard.UseVisualStyleBackColor = true;
            btnDashBoard.Click += btnDashBoard_Click;
            // 
            // pnlTotalPatients
            // 
            pnlTotalPatients.BackColor = Color.FromArgb(192, 192, 255);
            pnlTotalPatients.BorderStyle = BorderStyle.Fixed3D;
            pnlTotalPatients.Controls.Add(pbPatients);
            pnlTotalPatients.Controls.Add(lblTPatients);
            pnlTotalPatients.Controls.Add(label1);
            pnlTotalPatients.Location = new Point(268, 153);
            pnlTotalPatients.Name = "pnlTotalPatients";
            pnlTotalPatients.Size = new Size(296, 142);
            pnlTotalPatients.TabIndex = 2;
            // 
            // pbPatients
            // 
            pbPatients.Image = Properties.Resources.medical_assistance;
            pbPatients.Location = new Point(14, 58);
            pbPatients.Name = "pbPatients";
            pbPatients.Size = new Size(125, 62);
            pbPatients.SizeMode = PictureBoxSizeMode.Zoom;
            pbPatients.TabIndex = 2;
            pbPatients.TabStop = false;
            // 
            // lblTPatients
            // 
            lblTPatients.AutoSize = true;
            lblTPatients.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTPatients.Location = new Point(210, 71);
            lblTPatients.Name = "lblTPatients";
            lblTPatients.Size = new Size(0, 23);
            lblTPatients.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(147, 18);
            label1.Name = "label1";
            label1.Size = new Size(142, 28);
            label1.TabIndex = 0;
            label1.Text = "Total Patients";
            // 
            // pnlTotalAppointments
            // 
            pnlTotalAppointments.BackColor = Color.FromArgb(192, 255, 192);
            pnlTotalAppointments.BorderStyle = BorderStyle.Fixed3D;
            pnlTotalAppointments.Controls.Add(pbAppointment);
            pnlTotalAppointments.Controls.Add(lblTAppointments);
            pnlTotalAppointments.Controls.Add(label2);
            pnlTotalAppointments.Location = new Point(612, 153);
            pnlTotalAppointments.Name = "pnlTotalAppointments";
            pnlTotalAppointments.Size = new Size(296, 142);
            pnlTotalAppointments.TabIndex = 3;
            // 
            // pbAppointment
            // 
            pbAppointment.Image = Properties.Resources.schedule;
            pbAppointment.Location = new Point(16, 58);
            pbAppointment.Name = "pbAppointment";
            pbAppointment.Size = new Size(125, 62);
            pbAppointment.SizeMode = PictureBoxSizeMode.Zoom;
            pbAppointment.TabIndex = 2;
            pbAppointment.TabStop = false;
            // 
            // lblTAppointments
            // 
            lblTAppointments.AutoSize = true;
            lblTAppointments.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTAppointments.Location = new Point(221, 71);
            lblTAppointments.Name = "lblTAppointments";
            lblTAppointments.Size = new Size(0, 23);
            lblTAppointments.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(90, 18);
            label2.Name = "label2";
            label2.Size = new Size(199, 28);
            label2.TabIndex = 0;
            label2.Text = "Total Appointments";
            // 
            // pnlEmergencyCase
            // 
            pnlEmergencyCase.BackColor = Color.FromArgb(255, 192, 192);
            pnlEmergencyCase.BorderStyle = BorderStyle.Fixed3D;
            pnlEmergencyCase.Controls.Add(pbEmergency);
            pnlEmergencyCase.Controls.Add(lblEmergency);
            pnlEmergencyCase.Controls.Add(label3);
            pnlEmergencyCase.Location = new Point(960, 153);
            pnlEmergencyCase.Name = "pnlEmergencyCase";
            pnlEmergencyCase.Size = new Size(296, 142);
            pnlEmergencyCase.TabIndex = 4;
            // 
            // pbEmergency
            // 
            pbEmergency.Image = Properties.Resources.emergency;
            pbEmergency.Location = new Point(35, 58);
            pbEmergency.Name = "pbEmergency";
            pbEmergency.Size = new Size(125, 62);
            pbEmergency.SizeMode = PictureBoxSizeMode.Zoom;
            pbEmergency.TabIndex = 2;
            pbEmergency.TabStop = false;
            // 
            // lblEmergency
            // 
            lblEmergency.AutoSize = true;
            lblEmergency.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblEmergency.Location = new Point(226, 71);
            lblEmergency.Name = "lblEmergency";
            lblEmergency.Size = new Size(0, 23);
            lblEmergency.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(118, 18);
            label3.Name = "label3";
            label3.Size = new Size(171, 28);
            label3.TabIndex = 0;
            label3.Text = "Emergency Case ";
            // 
            // pnlFollowUP
            // 
            pnlFollowUP.BackColor = Color.FromArgb(255, 224, 192);
            pnlFollowUP.BorderStyle = BorderStyle.Fixed3D;
            pnlFollowUP.Controls.Add(pbFollowUp);
            pnlFollowUP.Controls.Add(lblFollowUp);
            pnlFollowUP.Controls.Add(label4);
            pnlFollowUP.Location = new Point(1309, 153);
            pnlFollowUP.Name = "pnlFollowUP";
            pnlFollowUP.Size = new Size(296, 142);
            pnlFollowUP.TabIndex = 5;
            // 
            // pbFollowUp
            // 
            pbFollowUp.Image = Properties.Resources.follow_up3;
            pbFollowUp.Location = new Point(78, 58);
            pbFollowUp.Name = "pbFollowUp";
            pbFollowUp.Size = new Size(76, 62);
            pbFollowUp.SizeMode = PictureBoxSizeMode.Zoom;
            pbFollowUp.TabIndex = 2;
            pbFollowUp.TabStop = false;
            // 
            // lblFollowUp
            // 
            lblFollowUp.AutoSize = true;
            lblFollowUp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblFollowUp.Location = new Point(238, 71);
            lblFollowUp.Name = "lblFollowUp";
            lblFollowUp.Size = new Size(0, 23);
            lblFollowUp.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(181, 18);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 0;
            label4.Text = "Follow-Up";
            // 
            // chartAppointments
            // 
            chartArea1.AxisX.Title = " Appointment Type";
            chartArea1.AxisY.Title = "Number of Appointments";
            chartArea1.Name = "ServicesArea";
            chartAppointments.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartAppointments.Legends.Add(legend1);
            chartAppointments.Location = new Point(268, 368);
            chartAppointments.Name = "chartAppointments";
            series1.BorderWidth = 2;
            series1.ChartArea = "ServicesArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.CustomProperties = "DrawSideBySide=True";
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Appointment Types";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartAppointments.Series.Add(series1);
            chartAppointments.Size = new Size(700, 350);
            chartAppointments.TabIndex = 6;
            chartAppointments.Text = "chart1";
            // 
            // chartAppointmentStatus
            // 
            chartArea2.AxisX.Title = "Appointment Status";
            chartArea2.AxisY.Title = "Number of Appointments";
            chartArea2.Name = "StatusArea";
            chartAppointmentStatus.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartAppointmentStatus.Legends.Add(legend2);
            chartAppointmentStatus.Location = new Point(1041, 368);
            chartAppointmentStatus.Name = "chartAppointmentStatus";
            series2.ChartArea = "StatusArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Appointment Status";
            chartAppointmentStatus.Series.Add(series2);
            chartAppointmentStatus.Size = new Size(375, 350);
            chartAppointmentStatus.TabIndex = 7;
            chartAppointmentStatus.Text = "chart1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1041, 317);
            label5.Name = "label5";
            label5.Size = new Size(336, 31);
            label5.TabIndex = 8;
            label5.Text = "Appointment Status Overview";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(268, 317);
            label6.Name = "label6";
            label6.Size = new Size(339, 31);
            label6.TabIndex = 9;
            label6.Text = "Appointments by Service Type";
            // 
            // Manager_DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1641, 743);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(chartAppointmentStatus);
            Controls.Add(chartAppointments);
            Controls.Add(pnlFollowUP);
            Controls.Add(pnlEmergencyCase);
            Controls.Add(pnlTotalAppointments);
            Controls.Add(pnlTotalPatients);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Manager_DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manager_DashBoard";
            Load += Manager_DashBoard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            pnlTotalPatients.ResumeLayout(false);
            pnlTotalPatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPatients).EndInit();
            pnlTotalAppointments.ResumeLayout(false);
            pnlTotalAppointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAppointment).EndInit();
            pnlEmergencyCase.ResumeLayout(false);
            pnlEmergencyCase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEmergency).EndInit();
            pnlFollowUP.ResumeLayout(false);
            pnlFollowUP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFollowUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartAppointmentStatus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel pnlTotalPatients;
        private Label label1;
        private Panel pnlTotalAppointments;
        private Label label2;
        private Panel pnlEmergencyCase;
        private Panel pnlFollowUP;
        private Label lblTPatients;
        private Label lblTAppointments;
        private Label lblEmergency;
        private Label label3;
        private Label lblFollowUp;
        private Label label4;
        private PictureBox pbPatients;
        private PictureBox pbAppointment;
        private PictureBox pbEmergency;
        private PictureBox pbFollowUp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAppointments;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAppointmentStatus;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label8;
        private Button btnLogout;
        private Button btnReport;
        private Button btnStaff;
        private Button btnPatients;
        private Button btnAppointments;
        private Button btnDashBoard;
    }
}