using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Jrr_Transport_Management_System
{
    public partial class CreateAccount_Form : Form
    {
        private string dbFile = "jrr_transport_data.db";

        public CreateAccount_Form()
        {
            InitializeComponent();
            createAccount_Btn.Click += createAccount_Btn_Click;
        }

        private void createAccount_Btn_Click(object? sender, EventArgs e)
        {
            string username = username_TextBox.Text.Trim();
            string password = password_TextBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            bool success = SaveNewUser(username, password);

            if (success)
            {
                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // will go back to Login Form automatically
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
                    string query = "INSERT INTO Users (Username, Password) VALUES (@user, @pass)";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", password);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Error 19 = constraint violation (duplicate username)
                if (ex.ResultCode == SQLiteErrorCode.Constraint)
                {
                    return false;
                }
                throw;
            }
        }
    }
}
