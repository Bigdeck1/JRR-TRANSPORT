using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Jrr_Transport_Management_System
{
    public partial class Dashboard : Form
    {
        private System.Windows.Forms.Timer refreshTimer;

        public Dashboard()
        {
            InitializeComponent();

            emp_btn.Click += emp_btn_Click;
            logoutL.Click += logoutL_Click;

            this.Load += Dashboard_Load;

            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 5000; // 5 seconds
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();

        }

        private void Dashboard_Load(object? sender, EventArgs e)
        {
            UpdateTotalEmployees();
        }

        private void RefreshTimer_Tick(object? sender, EventArgs e)
        {
            UpdateTotalEmployees();
        }

        private void UpdateTotalEmployees()
        {
            string dbPath = System.IO.Path.Combine(Application.StartupPath, "jrr_transport_data.db");
            using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Employees";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    long total = (long)cmd.ExecuteScalar();
                    labelTotalEmployees.Text = $"Total: {total}";
                }
            }
        }

        private void logoutL_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void emp_btn_Click(object? sender, EventArgs e)
        {
            Employee_list empListForm = new Employee_list();
            this.Hide();
            empListForm.FormClosed += (s, args) => this.Show();
            empListForm.Show();
        }
    }
}