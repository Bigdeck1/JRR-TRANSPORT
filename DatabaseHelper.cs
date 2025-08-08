using System;
using System.Data.SQLite;
using System.IO;

namespace Jrr_Transport_Management_System
{
    public static class DatabaseHelper
    {
        private static string dbPath = "mydatabase.db";
        private static string connectionString = $"Data Source={dbPath};Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);

                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string createUserTable = @"
                        CREATE TABLE users (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            username TEXT NOT NULL UNIQUE,
                            password TEXT NOT NULL,
                            role TEXT NOT NULL
                        );
                    ";
                    using (var cmd = new SQLiteCommand(createUserTable, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    string insertAdmin = "INSERT INTO users (username, password, role) VALUES ('admin', 'admin123', 'Admin');";
                    using (var cmd = new SQLiteCommand(insertAdmin, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public static bool ValidateUser(string username, string password)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM users WHERE username=@username AND password=@password";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
