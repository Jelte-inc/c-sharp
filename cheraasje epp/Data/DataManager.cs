using cheraasje_epp.Models.Entities;
using cheraasje_epp.Models.Filters;
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
                        Name = reader["Name"].ToString()!,
                        BranchId = Convert.ToInt32(reader["BranchId"])
                    };
                }
            }
            // Todo: better error handling
            throw new Exception("User not found for id: " + id);
        }

        public List<Car> GetCars(CarFilter filter)
        {
            var cars = new List<Car>();
            var whereClauses = new List<string>();

            int userId = Session.UserId;
            User user = GetUser(userId);

            using var connection = new SQLiteConnection(connectionString);
            using var command = new SQLiteCommand();
            command.Connection = connection;

            whereClauses.Add("BranchId = @BranchId");
            command.Parameters.AddWithValue("@BranchId", user.BranchId);

            if (!string.IsNullOrWhiteSpace(filter.Brand))
            {
                whereClauses.Add("Brand LIKE @Brand");
                command.Parameters.AddWithValue("@Brand", $"%{filter.Brand}%");
            }

            if (!string.IsNullOrWhiteSpace(filter.Model))
            {
                whereClauses.Add("Model LIKE @Model");
                command.Parameters.AddWithValue("@Model", $"%{filter.Model}%");
            }

            if (!string.IsNullOrWhiteSpace(filter.Color))
            {
                whereClauses.Add("Color LIKE @Color");
                command.Parameters.AddWithValue("@Color", $"%{filter.Color}%");
            }
            if (!string.IsNullOrEmpty(filter.AmountOfDoors.ToString()))
            {
                whereClauses.Add("Doors = @AmountOfDoors");
                command.Parameters.AddWithValue("@AmountOfDoors", filter.AmountOfDoors);
            }

            if (filter.PriceRange != null)
            {
                whereClauses.Add("Price BETWEEN @MinPrice AND @MaxPrice");
                command.Parameters.AddWithValue("@MinPrice", filter.PriceRange.Min.Amount);
                command.Parameters.AddWithValue("@MaxPrice", filter.PriceRange.Max.Amount);
            }

            command.CommandText = $@"
        SELECT *
        FROM Cars
        WHERE {string.Join(" AND ", whereClauses)};
    ";

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
                    Price = Convert.ToDecimal(reader["Price"]),
                    BuildYear = Convert.ToInt32(reader["BuildYear"]),
                    Mileage = Convert.ToDecimal(reader["Mileage"])
                });
            }

            return cars;
        }



        public List<string> getCarAttributes(string filter)
        {
            List<string> carAttributes = new List<string>();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                int userId = Session.UserId;
                User user = GetUser(userId);
                int branchId = user.BranchId;
                conn.Open();
                string query = $@"
                SELECT DISTINCT {filter}
                FROM Cars
                WHERE BranchId = @branchId";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@branchId", branchId);
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (filter.ToLower() == "price")
                {
                    var prices = new List<decimal>();
                    while (reader.Read())
                    {
                        prices.Add(Convert.ToDecimal(reader["Price"]));
                    }
                    int step = 10000;

                    var ranges = prices
                        .Select(p => Math.Floor(p / step) * step)
                        .Distinct()
                        .OrderBy(p => p)
                        .Select(min => $"{min}-{min + step - 1}")
                        .ToList();
                    carAttributes = ranges;

                }
                else
                {
                    while (reader.Read())
                    {
                        carAttributes.Add(reader[filter].ToString()!);
                    }
                }
            }
            return carAttributes;
        }

    }
}

