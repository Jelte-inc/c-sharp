using cheraasje_epp.Models;
using System.Data.SQLite;


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
        public Models.Branch GetBranchById(int id)
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
                    return new Models.Branch
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
                        Name = reader["Name"].ToString()!,
                        BranchId = Convert.ToInt32(reader["BranchId"])
                    };
                }
            }
            // Todo: better error handling
            throw new Exception("User not found for id: " + id);
        }

        public List<Car> GetCars(Dictionary<string, object> filters)
        {
            var cars = new List<Car>();
            var whereClauses = new List<string>();

            using var connection = new SQLiteConnection(connectionString);
            using var command = new SQLiteCommand();
            command.Connection = connection;

            whereClauses.Add("BranchId = @BranchId");
            command.Parameters.AddWithValue("@BranchId", filters["BranchId"]);

            if (filters.TryGetValue("Brand", out var brand))
            {
                whereClauses.Add("Brand = @Brand");
                command.Parameters.AddWithValue("@Brand", brand);
            }

            if (filters.TryGetValue("Model", out var model))
            {
                whereClauses.Add("Model = @Model");
                command.Parameters.AddWithValue("@Model", model);
            }

            if (filters.TryGetValue("Color", out var color))
            {
                whereClauses.Add("Color = @Color");
                command.Parameters.AddWithValue("@Color", color);
            }

            if (filters.TryGetValue("Price", out var price))
            {
                whereClauses.Add("Price <= @Price");
                command.Parameters.AddWithValue("@Price", price);
            }

            command.CommandText =
                "SELECT * FROM Cars WHERE " +
                string.Join(" AND ", whereClauses);

            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                cars.Add(new Car
                {
                    Brand = reader["Brand"].ToString()!,
                    Model = reader["Model"].ToString()!,
                    Color = reader["Color"].ToString()!,
                    AmountOfDoors = Convert.ToInt32(reader["Doors"]),
                    Price = Convert.ToDouble(reader["Price"]),
                    BuildYear = Convert.ToInt32(reader["BuildYear"]),
                    Mileage = Convert.ToDouble(reader["Mileage"])
                });
            }

            return cars;
        }

    }
}

