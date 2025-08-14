using System;
using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Jrr_Transport_Management_System
{
    public partial class CreateAccount_Form : Form
    {
        private string dbFile = "jrr_transport_data.db";

        public CreateAccount_Form()
        {
            InitializeComponent();
            CreateDatabaseIfNotExist();

            C_acc_btn.Click += C_acc_btn_Click;
            L_acc_link.Click += L_acc_link_Click;
            xlink.Click += xlink_Click;
        }

        private void CreateDatabaseIfNotExist()
        {
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);

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

                    // Insert default admin with hashed password
                    string adminHash = HashPassword("1234");
                    string insertAdminUser = "INSERT OR IGNORE INTO Users (Username, PasswordHash) VALUES (@user, @pass)";
                    using (var cmd = new SQLiteCommand(insertAdminUser, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", "admin");
                        cmd.Parameters.AddWithValue("@pass", adminHash);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void C_acc_btn_Click(object sender, EventArgs e)
        {
            string username = C_user_name.Text.Trim();
            string password = C_pass_word.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (SaveNewUser(username, password))
            {
                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Username already exists or an error occurred.");
            }
        }

        private bool SaveNewUser(string username, string password)
        {
            try
            {
                using (var conn = new SQLiteConnection($"Data Source={dbFile};Version=3;"))
                {
                    conn.Open();
                    string query = "INSERT INTO Users (Username, PasswordHash) VALUES (@user, @pass)";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", HashPassword(password));
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SQLiteException ex)
            {
                if (ex.ResultCode == SQLiteErrorCode.Constraint)
                    return false;
                throw;
            }
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

        private void L_acc_link_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void xlink_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
