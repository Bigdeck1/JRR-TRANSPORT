using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Jrr_Transport_Management_System
{
    public partial class Employee_list : Form
    {
        private string dbPath = Path.Combine(Application.StartupPath, "jrr_transport_data.db");
        private string connectionString;
        private int selectedEmployeeId = -1;

        public Employee_list()
        {
            InitializeComponent();

            connectionString = $"Data Source={dbPath};Version=3;";

            // Events
            emp_save_btn.Click += emp_save_btn_Click;
            emp_update_btn.Click += emp_update_btn_Click;
            emp_del_btn.Click += emp_del_btn_Click;
            employee_data.CellDoubleClick += employee_data_CellDoubleClick;
            saveTimeInBtn.Click += saveTimeInBtn_Click;
            saveTimeOutBtn.Click += saveTimeOutBtn_Click;
            deleteAttendanceBtn.Click += deleteAttendanceBtn_Click;
            dasb_btn.Click += dasb_btn_Click;
            logoutBtn.Click += logoutBtn_Click;

            EnsureEmployeesTable();
            EnsureAttendanceTable();

            this.Load += Employee_List_Load;
            

            employee_data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employee_data.MultiSelect = false;

            timeInPicker.Value = DateTime.Now;
            timeOutPicker.Value = DateTime.Now;
            timeInPicker.Format = DateTimePickerFormat.Custom;
            timeInPicker.CustomFormat = "HH:mm:ss";
            timeInPicker.ShowUpDown = true;
            timeOutPicker.Format = DateTimePickerFormat.Custom;
            timeOutPicker.CustomFormat = "HH:mm:ss";
            timeOutPicker.ShowUpDown = true;
        }

        private void EnsureEmployeesTable()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Employees (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        FirstName TEXT NOT NULL,
                        MiddleName TEXT,
                        Surname TEXT NOT NULL,
                        Gender TEXT,
                        PhoneNumber TEXT,
                        Email TEXT,
                        JobTitle TEXT
                    );
                ";

                using (var cmd = new SQLiteCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void EnsureAttendanceTable()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string createAttendanceTable = @"
                    CREATE TABLE IF NOT EXISTS Attendance (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        EmployeeId INTEGER NOT NULL,
                        Date TEXT NOT NULL,
                        TimeIn  TEXT,
                        
                        TimeOut TEXT,
                        FOREIGN KEY(EmployeeId) REFERENCES Employees(Id)
                    );
                ";

                using (var cmd = new SQLiteCommand(createAttendanceTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }

            }
        }

        private void Employee_List_Load(object? sender, EventArgs e)
        {
            LoadEmployees();
            LoadAttendance();
        }
        private void LoadEmployees()
        {
            
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Id, FirstName, MiddleName, Surname, Gender, PhoneNumber, Email, JobTitle FROM Employees";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    employee_data.DataSource = dt;

                    
                    if (employee_data.Columns.Contains("Id"))
                        employee_data.Columns["Id"].Visible = false;
                }
            }
        }

        private void emp_save_btn_Click(object? sender, EventArgs e)
        {
            try
            {
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string insertQuery = @"
                        INSERT INTO Employees 
                        (FirstName, MiddleName, Surname, Gender, PhoneNumber, Email, JobTitle) 
                        VALUES 
                        (@fname, @mname, @sname, @gender, @phone, @email, @job)";

                    using (var cmd = new SQLiteCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@fname", f_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@mname", m_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@sname", s_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@gender", gender_b.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@phone", p_number.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", email.Text.Trim());
                        cmd.Parameters.AddWithValue("@job", job.Text.Trim());

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("✅ Employee saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                            LoadEmployees();
                        }
                        else
                        {
                            MessageBox.Show("⚠ Failed to save employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void emp_update_btn_Click(object? sender, EventArgs e)
        {
            if (selectedEmployeeId == -1)
            {
                MessageBox.Show("⚠ Please select an employee to update.");
                return;
            }

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string updateQuery = @"
                    UPDATE Employees
                    SET FirstName=@fname, MiddleName=@mname, Surname=@sname, 
                        Gender=@gender, PhoneNumber=@phone, Email=@email, JobTitle=@job
                    WHERE Id=@id";

                using (var cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@fname", f_name.Text.Trim());
                    cmd.Parameters.AddWithValue("@mname", m_name.Text.Trim());
                    cmd.Parameters.AddWithValue("@sname", s_name.Text.Trim());
                    cmd.Parameters.AddWithValue("@gender", gender_b.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", p_number.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", email.Text.Trim());
                    cmd.Parameters.AddWithValue("@job", job.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", selectedEmployeeId);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("✅ Employee updated successfully!");
                        ClearForm();
                        LoadEmployees();
                    }
                    else
                    {
                        MessageBox.Show("⚠ Failed to update employee.");
                    }
                }
            }
        }

        private void emp_del_btn_Click(object? sender, EventArgs e)
        {
            if (employee_data.SelectedRows.Count == 0)
            {
                MessageBox.Show("⚠ Please select an employee to delete.");
                return;
            }

            int id = Convert.ToInt32(employee_data.SelectedRows[0].Cells["Id"].Value);

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this employee?",
                                                   "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM Employees WHERE Id=@id";
                    using (var cmd = new SQLiteCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("✅ Employee deleted successfully!");
                            ClearForm();
                            LoadEmployees();
                        }
                        else
                        {
                            MessageBox.Show("⚠ Failed to delete employee.");
                        }
                    }
                }
            }
        }

        private void LoadAttendance()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT 
                a.Id,
                e.FirstName || ' ' || e.Surname AS Employee,
                a.Date, a.TimeIn, a.TimeOut
            FROM Attendance a
            JOIN Employees e ON e.Id = a.EmployeeId";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var da = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    attendance_data.DataSource = dt;

                    if (attendance_data.Columns.Contains("Id"))
                        attendance_data.Columns["Id"].Visible = false;
                }
            }
        }

        private void employee_data_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = employee_data.Rows[e.RowIndex];

                f_name.Text = row.Cells["FirstName"].Value?.ToString();
                m_name.Text = row.Cells["MiddleName"].Value?.ToString();
                s_name.Text = row.Cells["Surname"].Value?.ToString();
                gender_b.Text = row.Cells["Gender"].Value?.ToString();
                p_number.Text = row.Cells["PhoneNumber"].Value?.ToString();
                email.Text = row.Cells["Email"].Value?.ToString();
                job.Text = row.Cells["JobTitle"].Value?.ToString();

                if (row.Cells["Id"].Value != null)
                {
                    selectedEmployeeId = Convert.ToInt32(row.Cells["Id"].Value);
                }
            }
        }
        private void ClearForm()
        {
            f_name.Clear();
            m_name.Clear();
            s_name.Clear();
            gender_b.SelectedIndex = -1;
            p_number.Clear();
            email.Clear();
            job.Clear();
            selectedEmployeeId = -1;
        }

        private void dasb_btn_Click(object? sender, EventArgs e)
        {
            Dashboard dashForm = new Dashboard();
            this.Hide();
            dashForm.FormClosed += (s, args) => this.Close();
            dashForm.Show();
        }

        private void logoutBtn_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employee_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void job_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel13_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timein_label_Click(object sender, EventArgs e)
        {

        }

        private void saveTimeInBtn_Click(object? sender, EventArgs e)
        {
            if (employee_data.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee.");
                return;
            }

            int empId = Convert.ToInt32(employee_data.SelectedRows[0].Cells["Id"].Value);
            string timeIn = timeInPicker.Value.ToString("HH:mm:ss");
            string date = timeInPicker.Value.ToString("yyyy-MM-dd"); 

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string insertQuery = "INSERT INTO Attendance (EmployeeId, Date, TimeIn) VALUES (@id, @date, @tin)";
                using (var cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@id", empId);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@tin", timeIn);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadAttendance();
            MessageBox.Show("✅ Time-in saved!");
        }


        private void saveTimeOutBtn_Click(object? sender, EventArgs e)
        {
            if (attendance_data.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an attendance row from the bottom table.");
                return;
            }

            object? idVal = attendance_data.SelectedRows[0].Cells["Id"].Value;
            if (idVal == null)
            {
                MessageBox.Show("Invalid record selected.");
                return;
            }

            int attendanceId = Convert.ToInt32(idVal);

            string selectedDate = attendance_data.SelectedRows[0].Cells["Date"].Value?.ToString() ?? "";
            string outDate = timeOutPicker.Value.ToString("yyyy-MM-dd");

            if (selectedDate != outDate)
            {
                MessageBox.Show("⚠ The selected Time-Out date does not match the attendance date.",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string timeOut = timeOutPicker.Value.ToString("HH:mm:ss");

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string updateQuery = "UPDATE Attendance SET TimeOut=@tout WHERE Id=@attId";
                using (var cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@tout", timeOut);
                    cmd.Parameters.AddWithValue("@attId", attendanceId);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadAttendance();
            MessageBox.Show("✅ Time-Out saved!");
        }


        private void updateTimeInBtn_Click(object sender, EventArgs e)
        {
            if (attendance_data.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an attendance record to update.");
                return;
            }

            int attendanceId = Convert.ToInt32(attendance_data.SelectedRows[0].Cells["Id"].Value);
            string timeIn = timeInPicker.Value.ToString("HH:mm:ss");

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string updateQuery = "UPDATE Attendance SET TimeIn=@tin WHERE Id=@attId";
                using (var cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@tin", timeIn);
                    cmd.Parameters.AddWithValue("@attId", attendanceId);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("✅ Time-In updated!");
            LoadAttendance();
        }

        private void updateTimeOutBtn_Click(object sender, EventArgs e)
        {
            if (attendance_data.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an attendance record to update.");
                return;
            }

            int attendanceId = Convert.ToInt32(attendance_data.SelectedRows[0].Cells["Id"].Value);
            string timeOut = timeOutPicker.Value.ToString("HH:mm:ss");

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string updateQuery = "UPDATE Attendance SET TimeOut=@tout WHERE Id=@attId";
                using (var cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@tout", timeOut);
                    cmd.Parameters.AddWithValue("@attId", attendanceId);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("✅ Time-Out updated!");
            LoadAttendance();
        }

        private void deleteAttendanceBtn_Click(object? sender, EventArgs e)
        {
            if (attendance_data.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an attendance row to delete.");
                return;
            }

            int attendanceId = Convert.ToInt32(attendance_data.SelectedRows[0].Cells["Id"].Value);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this attendance record?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM Attendance WHERE Id = @id";

                    using (var cmd = new SQLiteCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", attendanceId);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadAttendance();
                MessageBox.Show("✅ Deleted successfully!");
            }
        }

    }
}
