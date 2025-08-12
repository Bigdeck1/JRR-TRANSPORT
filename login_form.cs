using System;
using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Jrr_Transport_Management_System
{
    public partial class login_Form : Form
    {
        private string dbFile = "jrr_transport_data.db";

        public login_Form()
        {
            InitializeComponent();
            EnsureDatabase();
            login_Btn.Click += login_Btn_Click;
            acc_Create.Click += acc_Create_Click;
        }

        private void EnsureDatabase()
        {
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);
            }

            using (var conn = new SQLiteConnection($"Data Source={dbFile};Version=3;"))
            {
                conn.Open();

                string createUsersTable = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL UNIQUE,
                        PasswordHash TEXT NOT NULL
                    );
                ";

                using (var cmd = new SQLiteCommand(createUsersTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void login_Btn_Click(object? sender, EventArgs e)
        {
            string username = user_name.Text?.Trim() ?? string.Empty;
            string password = pass_word.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            if (VerifyLogin(username, password))
            {
                MessageBox.Show("Login successful!");
                Dashboard dash = new Dashboard();
                this.Hide();
                dash.FormClosed += (s, args) => this.Show();
                dash.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.endl/");
            }
        }

        private bool VerifyLogin(string username, string password)
        {
            using (var conn = new SQLiteConnection($"Data Source={dbFile};Version=3;"))
            {
                conn.Open();
                string query = "SELECT PasswordHash FROM Users WHERE Username=@user LIMIT 1";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    object? result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string storedHash = result.ToString() ?? string.Empty;
                        string inputHash = HashPassword(password);
                        return storedHash == inputHash;
                    }
                }
            }
            return false;
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
        private void acc_Create_Click(object? sender, EventArgs e)
        {
            this.Hide();
            CreateAccount_Form createForm = new CreateAccount_Form();

            createForm.FormClosed += (s, args) => this.Show();
            createForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
