using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

//EXCEL IMPORT
using ClosedXML.Excel;

//PDF IMPORT 
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campus_Health_Service.Manager
{
    public partial class Generate_Report : Form
    {
        public Generate_Report()
        {
            InitializeComponent();
        }
        DBConnection dB = new DBConnection();
        //============================================================================================================================================

        //============================================================================================================================================
        private void Generate_Report_Load(object sender, EventArgs e)
        {
            btnReport.BackColor = Color.Blue;
            cmbReportType.SelectedIndex = 0;


            rbExcel.Checked = true;
            rbPDF.Checked = false;

            dtpDateFrom.Value = DateTime.Today;
            dtpDateTo.Value = DateTime.Today;

            LoadPatients();

            cmbPatient.Enabled = false;
        }

        //============================================================================================================================================

        //============================================================================================================================================
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            Manager_DashBoard manager_DashBoard = new Manager_DashBoard();
            manager_DashBoard.Show();
            this.Hide();
        }

        //============================================================================================================================================

        //============================================================================================================================================
        private void btnAppointments_Click(object sender, EventArgs e)
        {
            Appointments appointments = new Appointments();
            appointments.Show();
            this.Hide();
        }

        //============================================================================================================================================

        //============================================================================================================================================
        private void btnPatients_Click(object sender, EventArgs e)
        {
            Patients patients = new Patients();
            patients.Show();
            this.Hide();
        }

        //============================================================================================================================================

        //============================================================================================================================================
        private void btnStaff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
            this.Hide();
        }

        //============================================================================================================================================

        //============================================================================================================================================
        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnLogout.Text = "Loading...";
            btnLogout.Enabled = false;

            btnLogout.BackColor = Color.Red;

            // Reset the View Appointments button color
            btnReport.BackColor = Color.White;

            // Ask the user to confirm logout
            DialogResult result = MessageBox.Show(
                "Do you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Continue only if the user selects Yes
            if (result == DialogResult.Yes)
            {


                // Open the Login form
                LogIn loginForm = new LogIn();
                loginForm.Show();

                // Hide the current form
                this.Hide();
            }
            else
            {
                btnLogout.Text = "Log Out";
                btnLogout.Enabled = true;
                btnLogout.BackColor = Color.White;
                // If the user selects No, reset the button color
                btnReport.BackColor = Color.Blue;
            }
        }

        //============================================================================================================================================
        // Handles the selected report type.
        //============================================================================================================================================
        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string reportType = cmbReportType.SelectedItem?.ToString();

            if (reportType == "Daily Appointment Schedule")
            {
                // Daily report is for today only.
                dtpDateFrom.Value = DateTime.Today;
                dtpDateTo.Value = DateTime.Today;

                dtpDateFrom.Enabled = false;
                dtpDateTo.Enabled = false;
            }
            else if (reportType == "Patient Report")
            {
                // Patient Report is PDF only.
                rbPDF.Checked = true;
                rbExcel.Checked = false;

                rbExcel.Enabled = false;
                rbPDF.Enabled = true;
                cmbPatient.Enabled = true;

                dtpDateFrom.Enabled = true;
                dtpDateTo.Enabled = true;
            }
            else
            {
                // Other reports can use a date range.
                dtpDateFrom.Enabled = true;
                dtpDateTo.Enabled = true;

                rbExcel.Enabled = true;
                rbPDF.Enabled = true;

                rbExcel.Checked = true;
                rbPDF.Checked = false;

                cmbPatient.Enabled = false;
                cmbPatient.SelectedIndex = -1;
            }
        }

        //============================================================================================================================================

        //============================================================================================================================================
        private void dtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateFrom.Value.Date > dtpDateTo.Value.Date)
            {
                dtpDateTo.Value = dtpDateFrom.Value.Date;
            }
        }

        //============================================================================================================================================

        //============================================================================================================================================
        private void dtpDateTo_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateTo.Value.Date < dtpDateFrom.Value.Date)
            {
                dtpDateFrom.Value = dtpDateTo.Value.Date;
            }
        }


        //==============================================================THIS PHASE IS FOR SAVING THE EXCEL ==============================================================================
        //============================================================================================================================================
        //============================================================================================================================================
        // Opens the Save File Dialog and prepares an Excel report.
        //============================================================================================================================================
        //============================================================================================================================================
        //============================================================================================================================================


        private void SaveExcelReport(string reportType)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Save Excel Report";
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                saveFileDialog.DefaultExt = "xlsx";
                saveFileDialog.AddExtension = true;

                saveFileDialog.FileName =
                    reportType.Replace(" ", "_") + "_" +
                    DateTime.Now.ToString("yyyyMMdd");

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                        if (reportType == "Daily Appointment Schedule")
                        {
                            GenerateDailyAppointmentExcel(filePath);
                        }
                        else if (reportType == "Cancellation, Rescheduling & Follow-Up Report")
                        {
                           GenerateCancellationReport(filePath);
                        }
                        else if (reportType == "Urgent Appointment Report")
                        {
                           GenerateUrgentAppointmentReport(filePath);
                        }
                        else if (reportType == "All Records")
                        {
                          GenerateAllRecordsReport(filePath);
                        }
                }
            }
        }

        //============================================================================================================================================
        // Retrieves the Daily Appointment Schedule from MySQL.
        //============================================================================================================================================

        private void GenerateDailyAppointmentExcel(string filePath)
        {
            string query = @"
        SELECT
            a.Appointment_ID,
            p.StudentORStaff_Number,
            p.Full_Name,
            p.Contact_Number,
            p.Email,
            aps.Slot_date,
            aps.Start_Time,
            aps.End_Time,
            aps.Services,
            a.Appointment_Type,
            a.Appointment_Status
        FROM appointments a
        INNER JOIN patients p
            ON a.Patient_ID = p.Patient_ID
        INNER JOIN appointment_slots aps
            ON a.Slot_ID = aps.Slot_ID
       WHERE DATE(aps.Slot_date) = CURDATE()
        ORDER BY aps.Slot_date, aps.Start_Time;
    ";

            try
            {
                DataTable table = new DataTable();

             
                using (MySqlConnection conn = dB.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@DateFrom",
                            dtpDateFrom.Value.Date);

                        cmd.Parameters.AddWithValue(
                            "@DateTo",
                            dtpDateTo.Value.Date);

                        using (MySqlDataAdapter adapter =
                               new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }
                    }
                }

                // Create the Excel workbook.
                using (XLWorkbook workbook = new XLWorkbook())
                {
                    // Create the worksheet.
                    IXLWorksheet worksheet =
                        workbook.Worksheets.Add("Appointment Schedule");

                    // Add report title.
                    worksheet.Cell("A1").Value =
                        "CAMPUS HEALTH SERVICE";

                    worksheet.Cell("A2").Value =
                        "Daily Appointment Schedule";

                    worksheet.Cell("A3").Value =
                        $"Report Period: {dtpDateFrom.Value:dd/MM/yyyy} - " +
                        $"{dtpDateTo.Value:dd/MM/yyyy}";

                    // Add the DataTable starting at row 5.
                    worksheet.Cell("A5").InsertTable(table);

                    // Format the title.
                    worksheet.Range("A1:K1").Merge();
                    worksheet.Range("A2:K2").Merge();
                    worksheet.Range("A3:K3").Merge();

                    worksheet.Cell("A1").Style.Font.Bold = true;
                    worksheet.Cell("A1").Style.Font.FontSize = 18;

                    worksheet.Cell("A2").Style.Font.Bold = true;
                    worksheet.Cell("A2").Style.Font.FontSize = 14;

                    worksheet.Cell("A3").Style.Font.Italic = true;

                    // Make the columns fit their contents.
                    worksheet.Columns().AdjustToContents();

                    // Save the Excel file.
                    workbook.SaveAs(filePath);
                }

                MessageBox.Show(
                    "Excel report created successfully.",
                    "Report Generated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error generating Excel report:\n\n" + ex.Message,
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        //========================================================================================================================================================
        // Creates the Cancellation & Rescheduling Report as an Excel file.
        //=============================================================================================================================================================================
        private void GenerateCancellationReport(string filePath)
        {
            string query = @"
        SELECT
            ah.History_ID,
            ah.Appointment_ID,
            p.StudentORStaff_Number,
            p.Full_Name,
            ah.Action_Type,
            ah.Action_Date,
            ah.Created_By,
            aps.Slot_date,
            aps.Start_Time,
            aps.End_Time,
            aps.Services
        FROM appointment_history ah

        INNER JOIN appointments a
            ON ah.Appointment_ID = a.Appointment_ID

        INNER JOIN patients p
            ON a.Patient_ID = p.Patient_ID

        INNER JOIN appointment_slots aps
            ON a.Slot_ID = aps.Slot_ID

        WHERE UPPER(TRIM(ah.Action_Type)) IN
        (
            'CANCELLED',
            'RESCHEDULED',
            'FOLLOW-UP SCHEDULED'
        )

        AND DATE(ah.Action_Date) BETWEEN @DateFrom AND @DateTo

        ORDER BY ah.Action_Date DESC;
    ";

            try
            {
                DataTable table = new DataTable();

                using (MySqlConnection conn = dB.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@DateFrom",
                            dtpDateFrom.Value.Date);

                        cmd.Parameters.AddWithValue(
                            "@DateTo",
                            dtpDateTo.Value.Date);

                        using (MySqlDataAdapter adapter =
                               new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }
                    }
                }

                using (XLWorkbook workbook = new XLWorkbook())
                {
                    IXLWorksheet worksheet =
                        workbook.Worksheets.Add("Appointment Changes");

                    worksheet.Cell("A1").Value =
                        "CAMPUS HEALTH SERVICE";

                    worksheet.Cell("A2").Value =
                        "Cancellation, Rescheduling & Follow-Up Report";

                    worksheet.Cell("A3").Value =
                        $"Report Period: {dtpDateFrom.Value:dd/MM/yyyy} - " +
                        $"{dtpDateTo.Value:dd/MM/yyyy}";

                    worksheet.Range("A1:K1").Merge();
                    worksheet.Range("A2:K2").Merge();
                    worksheet.Range("A3:K3").Merge();

                    worksheet.Cell("A1").Style.Font.Bold = true;
                    worksheet.Cell("A1").Style.Font.FontSize = 18;

                    worksheet.Cell("A2").Style.Font.Bold = true;
                    worksheet.Cell("A2").Style.Font.FontSize = 14;

                    worksheet.Cell("A3").Style.Font.Italic = true;

                    worksheet.Cell("A5").InsertTable(table);

                    worksheet.Columns().AdjustToContents();

                    workbook.SaveAs(filePath);
                }

                MessageBox.Show(
                    "Cancellation, Rescheduling & Follow-Up Report created successfully.",
                    "Report Generated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error generating report:\n\n" + ex.Message,
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //=======================================================================================================================================================
        // Generates the Urgent Appointment Report in Excel.
        //===================================================================================================================================================================
        private void GenerateUrgentAppointmentReport(string filePath)
        {
            string query = @"
        SELECT
            e.Emergency_ID,
            e.Appointment_ID,
            p.StudentORStaff_Number,
            p.Full_Name,
            p.Contact_Number,
            p.Email,
            e.Urgent_Classification,
            aps.Slot_date,
            aps.Start_Time,
            aps.End_Time,
            aps.Services,
            e.Recorded_By,
            e.Date_recorded
        FROM emergency e

        INNER JOIN appointments a
            ON e.Appointment_ID = a.Appointment_ID

        INNER JOIN patients p
            ON a.Patient_ID = p.Patient_ID

        INNER JOIN appointment_slots aps
            ON a.Slot_ID = aps.Slot_ID

        WHERE DATE(e.Date_recorded)
        BETWEEN @DateFrom AND @DateTo

        ORDER BY e.Date_recorded DESC;
    ";

            try
            {
                DataTable table = new DataTable();

                using (MySqlConnection conn = dB.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@DateFrom",
                            dtpDateFrom.Value.Date);

                        cmd.Parameters.AddWithValue(
                            "@DateTo",
                            dtpDateTo.Value.Date);

                        using (MySqlDataAdapter adapter =
                               new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }
                    }
                }

                using (XLWorkbook workbook = new XLWorkbook())
                {
                    IXLWorksheet worksheet =
                        workbook.Worksheets.Add("Urgent Appointments");

                    worksheet.Cell("A1").Value =
                        "CAMPUS HEALTH SERVICE";

                    worksheet.Cell("A2").Value =
                        "Urgent Appointment Report";

                    worksheet.Cell("A3").Value =
                        $"Report Period: {dtpDateFrom.Value:dd/MM/yyyy} - " +
                        $"{dtpDateTo.Value:dd/MM/yyyy}";

                    worksheet.Range("A1:M1").Merge();
                    worksheet.Range("A2:M2").Merge();
                    worksheet.Range("A3:M3").Merge();

                    worksheet.Cell("A1").Style.Font.Bold = true;
                    worksheet.Cell("A1").Style.Font.FontSize = 18;

                    worksheet.Cell("A2").Style.Font.Bold = true;
                    worksheet.Cell("A2").Style.Font.FontSize = 14;

                    worksheet.Cell("A3").Style.Font.Italic = true;

                    worksheet.Cell("A5").InsertTable(table);

                    worksheet.Columns().AdjustToContents();

                    workbook.SaveAs(filePath);
                }

                MessageBox.Show(
                    "Urgent Appointment Report created successfully.",
                    "Report Generated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error generating urgent appointment report:\n\n" +
                    ex.Message,
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        //==================================================================================================================================================================
        // Generates the All Records Report in Excel.
        //========================================================================================================================================================================
        private void GenerateAllRecordsReport(string filePath)
        {
            string query = @"
        SELECT
            a.Appointment_ID,
            p.StudentORStaff_Number,
            p.Full_Name,
            p.Contact_Number,
            p.Email,
            aps.Slot_date,
            aps.Start_Time,
            aps.End_Time,
            aps.Services,
            a.Appointment_Type,
            a.Appointment_Status,
            a.Date_Created
        FROM appointments a

        INNER JOIN patients p
            ON a.Patient_ID = p.Patient_ID

        INNER JOIN appointment_slots aps
            ON a.Slot_ID = aps.Slot_ID

        WHERE DATE(a.Date_Created)
        BETWEEN @DateFrom AND @DateTo

        ORDER BY a.Date_Created DESC;
    ";

            try
            {
                DataTable table = new DataTable();

                using (MySqlConnection conn = dB.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@DateFrom",
                            dtpDateFrom.Value.Date);

                        cmd.Parameters.AddWithValue(
                            "@DateTo",
                            dtpDateTo.Value.Date);

                        using (MySqlDataAdapter adapter =
                               new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }
                    }
                }

                using (XLWorkbook workbook = new XLWorkbook())
                {
                    IXLWorksheet worksheet =
                        workbook.Worksheets.Add("All Records");

                    worksheet.Cell("A1").Value =
                        "CAMPUS HEALTH SERVICE";

                    worksheet.Cell("A2").Value =
                        "All Appointment Records";

                    worksheet.Cell("A3").Value =
                        $"Report Period: {dtpDateFrom.Value:dd/MM/yyyy} - " +
                        $"{dtpDateTo.Value:dd/MM/yyyy}";

                    worksheet.Range("A1:L1").Merge();
                    worksheet.Range("A2:L2").Merge();
                    worksheet.Range("A3:L3").Merge();

                    worksheet.Cell("A1").Style.Font.Bold = true;
                    worksheet.Cell("A1").Style.Font.FontSize = 18;

                    worksheet.Cell("A2").Style.Font.Bold = true;
                    worksheet.Cell("A2").Style.Font.FontSize = 14;

                    worksheet.Cell("A3").Style.Font.Italic = true;

                    worksheet.Cell("A5").InsertTable(table);

                    worksheet.Columns().AdjustToContents();

                    workbook.SaveAs(filePath);
                }

                MessageBox.Show(
                    "All Records Report created successfully.",
                    "Report Generated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error generating All Records report:\n\n" +
                    ex.Message,
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        //===================================================================THIS IS THE PHASE FOR PDF =========================================================================
        //============================================================================================================================================
        //============================================================================================================================================
        // Opens the Save File Dialog and prepares a PDF report.
        //============================================================================================================================================
        //============================================================================================================================================
        //============================================================================================================================================
        private void SavePdfReport(string reportType)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Save PDF Report";
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.DefaultExt = "pdf";
                saveFileDialog.AddExtension = true;

                saveFileDialog.FileName =
                    reportType.Replace(" ", "_") + "_" +
                    DateTime.Now.ToString("yyyyMMdd");

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    if (reportType == "Daily Appointment Schedule")
                    {
                        GenerateDailyAppointmentPDF(filePath);
                    }
                    else if (reportType == "Cancellation, Rescheduling & Follow-Up Report")
                    {
                        GenerateCancellationPDF(filePath);
                    }
                    else if (reportType == "Urgent Appointment Report")
                    {
                        GenerateUrgentPDF(filePath);
                    }
                    else if (reportType == "All Records")
                    {
                        GenerateAllRecordsPDF(filePath);
                    }
                    else if (reportType == "Patient Report")
                    {
                        GeneratePatientReportPDF(filePath);
                    }
                }
            }
        }

        //====================================================================================================================================================
        // Creates the Daily Appointment Schedule as a PDF.
        //================================================================================================================================================================
        private void GenerateDailyAppointmentPDF(string filePath)
        {
            string query = @"
        SELECT
            a.Appointment_ID,
            p.StudentORStaff_Number,
            p.Full_Name,
            p.Contact_Number,
            p.Email,
            aps.Slot_date,
            aps.Start_Time,
            aps.End_Time,
            aps.Services,
            a.Appointment_Type,
            a.Appointment_Status
        FROM appointments a
        INNER JOIN patients p
            ON a.Patient_ID = p.Patient_ID
        INNER JOIN appointment_slots aps
            ON a.Slot_ID = aps.Slot_ID
        WHERE DATE(aps.Slot_date) = CURDATE()
        ORDER BY aps.Start_Time;
    ";

            try
            {
                DataTable table = new DataTable();

                using (MySqlConnection conn = dB.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter =
                               new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }
                    }
                }

                Document document = new Document(
                    PageSize.A4.Rotate(),
                    20,
                    20,
                    20,
                    20);

                PdfWriter.GetInstance(
                    document,
                    new FileStream(filePath, FileMode.Create));

                document.Open();

                Paragraph title = new Paragraph(
                    "CAMPUS HEALTH SERVICE",
                    FontFactory.GetFont(
                        FontFactory.HELVETICA_BOLD,
                        18));

                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);

                Paragraph reportTitle = new Paragraph(
                    "Daily Appointment Schedule",
                    FontFactory.GetFont(
                        FontFactory.HELVETICA_BOLD,
                        14));

                reportTitle.Alignment = Element.ALIGN_CENTER;
                document.Add(reportTitle);

                document.Add(new Paragraph(
                    $"Date: {DateTime.Today:dd/MM/yyyy}"));

                document.Add(new Paragraph(" "));

                PdfPTable pdfTable =
                    new PdfPTable(table.Columns.Count);

                pdfTable.WidthPercentage = 100;

                foreach (DataColumn column in table.Columns)
                {
                    pdfTable.AddCell(
                        new Phrase(column.ColumnName));
                }

                foreach (DataRow row in table.Rows)
                {
                    foreach (object value in row.ItemArray)
                    {
                        pdfTable.AddCell(
                            new Phrase(value?.ToString() ?? ""));
                    }
                }

                document.Add(pdfTable);

                document.Close();

                MessageBox.Show(
                    "Daily Appointment Schedule PDF created successfully.",
                    "Report Generated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error generating PDF:\n\n" + ex.Message,
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //========================================================================================================================================================
        // Creates the Cancellation, Rescheduling and Follow-Up report as a PDF.
        //===================================================================================================================================================================
        private void GenerateCancellationPDF(string filePath)
        {
            string query = @"
        SELECT
            ah.History_ID,
            ah.Appointment_ID,
            p.StudentORStaff_Number,
            p.Full_Name,
            ah.Action_Type,
            ah.Action_Date,
            ah.Created_By,
            aps.Slot_date,
            aps.Start_Time,
            aps.End_Time,
            aps.Services
        FROM appointment_history ah
        INNER JOIN appointments a
            ON ah.Appointment_ID = a.Appointment_ID
        INNER JOIN patients p
            ON a.Patient_ID = p.Patient_ID
        INNER JOIN appointment_slots aps
            ON a.Slot_ID = aps.Slot_ID
        WHERE UPPER(TRIM(ah.Action_Type)) IN
        (
            'CANCELLED',
            'RESCHEDULED',
            'FOLLOW-UP SCHEDULED'
        )
        AND DATE(ah.Action_Date)
            BETWEEN @DateFrom AND @DateTo
        ORDER BY ah.Action_Date DESC;
    ";

            try
            {
                DataTable table = new DataTable();

                using (MySqlConnection conn = dB.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@DateFrom",
                            dtpDateFrom.Value.Date);

                        cmd.Parameters.AddWithValue(
                            "@DateTo",
                            dtpDateTo.Value.Date);

                        using (MySqlDataAdapter adapter =
                               new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }
                    }
                }

                CreatePDFTable(
                    filePath,
                    "Cancellation, Rescheduling & Follow-Up Report",
                    table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error generating PDF:\n\n" + ex.Message,
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        //====================================================================================================================================================================================
        // Creates a standard PDF containing the supplied report data.This prevents us from writing the same PDF formatting code four times
        //======================================================================================================================================================
        private void CreatePDFTable(
            string filePath,
            string reportTitle,
            DataTable table)
        {
            Document document = new Document(
                PageSize.A4.Rotate(),
                20,
                20,
                20,
                20);

            try
            {
                PdfWriter.GetInstance(
                    document,
                    new FileStream(filePath, FileMode.Create));

                document.Open();

                Paragraph title = new Paragraph(
                    "CAMPUS HEALTH SERVICE",
                    FontFactory.GetFont(
                        FontFactory.HELVETICA_BOLD,
                        18));

                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);

                Paragraph heading = new Paragraph(
                    reportTitle,
                    FontFactory.GetFont(
                        FontFactory.HELVETICA_BOLD,
                        14));

                heading.Alignment = Element.ALIGN_CENTER;
                document.Add(heading);

                document.Add(new Paragraph(
                    $"Report Period: {dtpDateFrom.Value:dd/MM/yyyy} - " +
                    $"{dtpDateTo.Value:dd/MM/yyyy}"));

                document.Add(new Paragraph(" "));

                PdfPTable pdfTable =
                    new PdfPTable(table.Columns.Count);

                pdfTable.WidthPercentage = 100;

                foreach (DataColumn column in table.Columns)
                {
                    PdfPCell headerCell =
                        new PdfPCell(
                            new Phrase(column.ColumnName));

                    headerCell.HorizontalAlignment =
                        Element.ALIGN_CENTER;

                    pdfTable.AddCell(headerCell);
                }

                foreach (DataRow row in table.Rows)
                {
                    foreach (object value in row.ItemArray)
                    {
                        pdfTable.AddCell(
                            new Phrase(value?.ToString() ?? ""));
                    }
                }

                document.Add(pdfTable);
            }
            finally
            {
                document.Close();
            }

            MessageBox.Show(
                reportTitle + " PDF created successfully.",
                "Report Generated",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        //====================================================================================================================================================
        // Creates the Urgent Appointment Report as a PDF.
        //====================================================================================================================================================
        private void GenerateUrgentPDF(string filePath)
        {
            string query = @"
        SELECT
            e.Emergency_ID,
            e.Appointment_ID,
            p.StudentORStaff_Number,
            p.Full_Name,
            p.Contact_Number,
            p.Email,
            e.Urgent_Classification,
            e.Recorded_By,
            e.Date_recorded,
            aps.Slot_date,
            aps.Start_Time,
            aps.End_Time,
            aps.Services,
            a.Appointment_Status
        FROM emergency e
        INNER JOIN appointments a
            ON e.Appointment_ID = a.Appointment_ID
        INNER JOIN patients p
            ON a.Patient_ID = p.Patient_ID
        INNER JOIN appointment_slots aps
            ON a.Slot_ID = aps.Slot_ID
        WHERE DATE(e.Date_recorded)
            BETWEEN @DateFrom AND @DateTo
        ORDER BY e.Date_recorded DESC;
    ";

            try
            {
                DataTable table = new DataTable();

                using (MySqlConnection conn = dB.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@DateFrom",
                            dtpDateFrom.Value.Date);

                        cmd.Parameters.AddWithValue(
                            "@DateTo",
                            dtpDateTo.Value.Date);

                        using (MySqlDataAdapter adapter =
                               new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }
                    }
                }

                CreatePDFTable(
                    filePath,
                    "Urgent Appointment Report",
                    table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error generating PDF:\n\n" + ex.Message,
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //====================================================================================================================================================
        // Creates the All Records Report as a PDF.
        //====================================================================================================================================================
        private void GenerateAllRecordsPDF(string filePath)
        {
            string query = @"
        SELECT
            a.Appointment_ID,
            p.StudentORStaff_Number,
            p.Full_Name,
            p.Contact_Number,
            p.Email,
            aps.Slot_date,
            aps.Start_Time,
            aps.End_Time,
            aps.Services,
            a.Appointment_Type,
            a.Appointment_Status,
            a.Date_Created
        FROM appointments a
        INNER JOIN patients p
            ON a.Patient_ID = p.Patient_ID
        INNER JOIN appointment_slots aps
            ON a.Slot_ID = aps.Slot_ID
        WHERE DATE(aps.Slot_date)
            BETWEEN @DateFrom AND @DateTo
        ORDER BY aps.Slot_date ASC,
                 aps.Start_Time ASC;
    ";

            try
            {
                DataTable table = new DataTable();

                using (MySqlConnection conn = dB.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@DateFrom",
                            dtpDateFrom.Value.Date);

                        cmd.Parameters.AddWithValue(
                            "@DateTo",
                            dtpDateTo.Value.Date);

                        using (MySqlDataAdapter adapter =
                               new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }
                    }
                }

                CreatePDFTable(
                    filePath,
                    "All Appointment Records Report",
                    table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error generating PDF:\n\n" + ex.Message,
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        //====================================================================================================================================================
        // Loads patients into the Patient ComboBox.
        //====================================================================================================================================================
        private void LoadPatients()
        {
            try
            {
                cmbPatient.Items.Clear();

                string query = @"
            SELECT
                Patient_ID,
                StudentORStaff_Number,
                Full_Name
            FROM patients
            ORDER BY Full_Name ASC;
        ";

                using (MySqlConnection conn = dB.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbPatient.Items.Add(
                                    new PatientItem
                                    {
                                        PatientID = Convert.ToInt32(
                                            reader["Patient_ID"]),

                                        StudentStaffNumber =
                                            reader["StudentORStaff_Number"].ToString(),

                                        FullName =
                                            reader["Full_Name"].ToString()
                                    });
                            }
                        }
                    }
                }

                cmbPatient.DisplayMember = "FullName";
                cmbPatient.ValueMember = "PatientID";
                cmbPatient.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading patients:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private class PatientItem
        {
            public int PatientID { get; set; }
            public string StudentStaffNumber { get; set; }
            public string FullName { get; set; }

            public override string ToString()
            {
                return $"{StudentStaffNumber} - {FullName}";
            }
        }


        //====================================================================================================================================================
        // Creates the Patient Report as a PDF.
        // Displays patient information at the top and the patient's appointments below.
        //====================================================================================================================================================
        private void GeneratePatientReportPDF(string filePath)
        {
            if (cmbPatient.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a patient.",
                    "Patient Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            PatientItem selectedPatient =
                (PatientItem)cmbPatient.SelectedItem;

            string query = @"
        SELECT
            a.Appointment_ID,
            aps.Slot_date,
            aps.Start_Time,
            aps.End_Time,
            aps.Services,
            a.Appointment_Type,
            a.Appointment_Status
        FROM appointments a
        INNER JOIN appointment_slots aps
            ON a.Slot_ID = aps.Slot_ID
        WHERE a.Patient_ID = @PatientID
        AND DATE(aps.Slot_date)
            BETWEEN @DateFrom AND @DateTo
        ORDER BY
            aps.Slot_date ASC,
            aps.Start_Time ASC;
    ";

            string patientQuery = @"
        SELECT
            StudentORStaff_Number,
            Full_Name,
            Contact_Number,
            Email
        FROM patients
        WHERE Patient_ID = @PatientID;
    ";

            try
            {
                DataTable appointmentTable = new DataTable();
                DataTable patientTable = new DataTable();

                using (MySqlConnection conn = dB.GetConnection())
                {
                    conn.Open();

                    //====================================================================================
                    // Get patient information.
                    //====================================================================================
                    using (MySqlCommand patientCmd =
                           new MySqlCommand(patientQuery, conn))
                    {
                        patientCmd.Parameters.AddWithValue(
                            "@PatientID",
                            selectedPatient.PatientID);

                        using (MySqlDataAdapter adapter =
                               new MySqlDataAdapter(patientCmd))
                        {
                            adapter.Fill(patientTable);
                        }
                    }

                    //====================================================================================
                    // Get patient's appointments.
                    //====================================================================================
                    using (MySqlCommand appointmentCmd =
                           new MySqlCommand(query, conn))
                    {
                        appointmentCmd.Parameters.AddWithValue(
                            "@PatientID",
                            selectedPatient.PatientID);

                        appointmentCmd.Parameters.AddWithValue(
                            "@DateFrom",
                            dtpDateFrom.Value.Date);

                        appointmentCmd.Parameters.AddWithValue(
                            "@DateTo",
                            dtpDateTo.Value.Date);

                        using (MySqlDataAdapter adapter =
                               new MySqlDataAdapter(appointmentCmd))
                        {
                            adapter.Fill(appointmentTable);
                        }
                    }
                }

                if (patientTable.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Patient information could not be found.",
                        "Patient Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (appointmentTable.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No appointments were found for the selected patient " +
                        "within the selected date range.",
                        "No Records",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                //====================================================================================
                // Create PDF.
                //====================================================================================
                Document document = new Document(
                    PageSize.A4.Rotate(),
                    20,
                    20,
                    20,
                    20);

                try
                {
                    PdfWriter.GetInstance(
                        document,
                        new FileStream(filePath, FileMode.Create));

                    document.Open();

                    //================================================================================
                    // Main title.
                    //================================================================================
                    Paragraph title = new Paragraph(
                        "CAMPUS HEALTH SERVICE",
                        FontFactory.GetFont(
                            FontFactory.HELVETICA_BOLD,
                            18));

                    title.Alignment = Element.ALIGN_CENTER;
                    document.Add(title);

                    Paragraph reportTitle = new Paragraph(
                        "Patient Report",
                        FontFactory.GetFont(
                            FontFactory.HELVETICA_BOLD,
                            14));

                    reportTitle.Alignment = Element.ALIGN_CENTER;
                    document.Add(reportTitle);

                    document.Add(new Paragraph(
                        $"Report Period: {dtpDateFrom.Value:dd/MM/yyyy} - " +
                        $"{dtpDateTo.Value:dd/MM/yyyy}"));

                    document.Add(new Paragraph(" "));

                    //================================================================================
                    // Patient Information heading.
                    //================================================================================
                    Paragraph patientHeading = new Paragraph(
                        "Patient Information",
                        FontFactory.GetFont(
                            FontFactory.HELVETICA_BOLD,
                            12));

                    document.Add(patientHeading);

                    document.Add(new Paragraph(
                        "Student/Staff Number: " +
                        patientTable.Rows[0]["StudentORStaff_Number"].ToString()));

                    document.Add(new Paragraph(
                        "Full Name: " +
                        patientTable.Rows[0]["Full_Name"].ToString()));

                    document.Add(new Paragraph(
                        "Contact Number: " +
                        patientTable.Rows[0]["Contact_Number"].ToString()));

                    document.Add(new Paragraph(
                        "Email: " +
                        patientTable.Rows[0]["Email"].ToString()));

                    document.Add(new Paragraph(" "));

                    //================================================================================
                    // Appointment History heading.
                    //================================================================================
                    Paragraph appointmentHeading = new Paragraph(
                        "Appointment History",
                        FontFactory.GetFont(
                            FontFactory.HELVETICA_BOLD,
                            12));

                    document.Add(appointmentHeading);

                    document.Add(new Paragraph(" "));

                    //================================================================================
                    // Appointment table.
                    //================================================================================
                    PdfPTable pdfTable =
                        new PdfPTable(7);

                    pdfTable.WidthPercentage = 100;

                    string[] headers =
                    {
                "Appointment ID",
                "Date",
                "Start Time",
                "End Time",
                "Service",
                "Appointment Type",
                "Status"
            };

                    foreach (string header in headers)
                    {
                        PdfPCell headerCell =
                            new PdfPCell(
                                new Phrase(header));

                        headerCell.HorizontalAlignment =
                            Element.ALIGN_CENTER;

                        pdfTable.AddCell(headerCell);
                    }

                    foreach (DataRow row in appointmentTable.Rows)
                    {
                        pdfTable.AddCell(
                            new Phrase(
                                row["Appointment_ID"].ToString()));

                        pdfTable.AddCell(
                            new Phrase(
                                Convert.ToDateTime(
                                    row["Slot_date"])
                                    .ToString("dd/MM/yyyy")));

                        pdfTable.AddCell(
                            new Phrase(
                                row["Start_Time"].ToString()));

                        pdfTable.AddCell(
                            new Phrase(
                                row["End_Time"].ToString()));

                        pdfTable.AddCell(
                            new Phrase(
                                row["Services"].ToString()));

                        pdfTable.AddCell(
                            new Phrase(
                                row["Appointment_Type"].ToString()));

                        pdfTable.AddCell(
                            new Phrase(
                                row["Appointment_Status"].ToString()));
                    }

                    document.Add(pdfTable);
                }
                finally
                {
                    document.Close();
                }

                MessageBox.Show(
                    "Patient Report PDF created successfully.",
                    "Report Generated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error generating PDF:\n\n" + ex.Message,
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        //============================================================================================================================================
        // Handles the Generate Report button.
        //============================================================================================================================================
        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbReportType.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a report type.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (dtpDateFrom.Value.Date > dtpDateTo.Value.Date)
            {
                MessageBox.Show(
                    "The From Date cannot be after the To Date.",
                    "Invalid Date Range",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!rbExcel.Checked && !rbPDF.Checked)
            {
                MessageBox.Show(
                    "Please select a report format.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string reportType = cmbReportType.SelectedItem.ToString();

            if (rbExcel.Checked)
            {
                SaveExcelReport(reportType);
            }
            else if (rbPDF.Checked)
            {
                SavePdfReport(reportType);
            }
        }
    }
}
