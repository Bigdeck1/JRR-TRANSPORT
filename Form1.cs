using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Jrr_Transport_Management_System
{
    public partial class login_Form : Form
    {
        private string dbFile = "jrr_transport_data.db";

        public login_Form()
        {
            InitializeComponent();
            CreateDatabaseIfNotExists();
            acc_Create.Click += acc_Create_Click;
            login_Btn.Click += login_Btn_Click;
        }

        private void CreateDatabaseIfNotExists()
        {
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);

                using (var conn = new SQLiteConnection($"Data Source={dbFile};Version=3;"))
                {
                    conn.Open();

                    string createUsersTable = @"
                        CREATE TABLE Users (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Username TEXT NOT NULL UNIQUE,
                            Password TEXT NOT NULL
                        );
                        INSERT INTO Users (Username, Password) VALUES ('admin', '1234');
                    ";

                    using (var cmd = new SQLiteCommand(createUsersTable, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void login_Btn_Click(object? sender, EventArgs e)
        {
            string username = user_name.Text.Trim();
            string password = pass_word.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            if (VerifyLogin(username, password))
            {
                MessageBox.Show("Login successful!");
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
        private void acc_Create_Click(object? sender, EventArgs e)
        {
            CreateAccount_Form createForm = new CreateAccount_Form();
            this.Hide();
            createForm.FormClosed += (s, args) => this.Show();
            createForm.Show();
        }

        private bool VerifyLogin(string username, string password)
        {
            using (var conn = new SQLiteConnection($"Data Source={dbFile};Version=3;"))
            {
                conn.Open();
                string query = "SELECT COUNT(1) FROM Users WHERE Username=@user AND Password=@pass";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count == 1;
                }
            }
        }
    }
}