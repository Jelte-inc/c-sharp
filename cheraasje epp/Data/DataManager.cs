using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using cheraasje_epp.Models;

namespace cheraasje_epp.Data
{
    internal class DataManager
    {
        private string dbPath = Path.Combine(Application.StartupPath, "Data", "database.db");
        private string connectionString;

        public DataManager()
        {
            connectionString = $"Data Source={dbPath};Version=3;";
        }

        public User AuthenticateUser(string userID, string password)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Users WHERE Id=@id AND Password=@password";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", userID);
                cmd.Parameters.AddWithValue("@password", password);

                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Password = reader["Password"].ToString(),
                        BranchId = Convert.ToInt32(reader["BranchId"])
                    };
                }
            }
            return null; // login mislukt
        }
        public Branch GetBranchById(int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Branches WHERE Id=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Branch
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString()
                    };
                }
            }
            return null;
        }
        public User GetUser(int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Users WHERE Id=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        BranchId = Convert.ToInt32(reader["BranchId"]) 
                    };
                }
            }
            return null;
        }
    }
}
