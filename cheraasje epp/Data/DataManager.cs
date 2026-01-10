using cheraasje_epp.Models.Entities;
using cheraasje_epp.Models.Filters;
using System.Data.SQLite;

namespace cheraasje_epp.Data
{
    internal class DataManager
    {
        private readonly string dbPath =
            Path.Combine(Application.StartupPath, "Data", "database.db");

        private readonly string connectionString;

        public DataManager()
        {
            connectionString =
                $"Data Source={dbPath};Version=3;BusyTimeout=5000;";
        }

        public bool AuthenticateUser(string userID, string password)
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            using var cmd = new SQLiteCommand(
                "SELECT * FROM Users WHERE Id=@id AND Password=@password", conn);
            cmd.Parameters.AddWithValue("@id", userID);
            cmd.Parameters.AddWithValue("@password", password);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read()) return false;
            return true;

        }

        public User GetUser(int id)
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            using var cmd = new SQLiteCommand(
                "SELECT * FROM Users WHERE Id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read())
                throw new Exception($"User not found for id {id}");

            return new User
            {
                Id = Convert.ToInt32(reader["Id"]),
                Name = reader["Name"].ToString()!,
                BranchId = Convert.ToInt32(reader["BranchId"]),
                IsAdmin = Convert.ToBoolean(reader["IsAdmin"])
            };
        }

        public Branch GetBranchById(int id)
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            using var cmd = new SQLiteCommand(
                "SELECT * FROM Branches WHERE Id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read()) return null;

            return new Branch
            {
                Id = Convert.ToInt32(reader["Id"]),
                Name = reader["Name"].ToString()!,
                Location = reader["Location"].ToString()!,
                Adress = reader["Adress"].ToString()!,
                PhoneNumber = reader["PhoneNumber"].ToString()!,
                PostalCode = reader["PostalCode"].ToString()!,
                Owner = reader["OwnerId"].ToString()!
            };
        }

        public List<Car> GetCars(CarFilter filter)
        {
            var cars = new List<Car>();
            var where = new List<string>();

            var user = GetUser(Session.UserId);

            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            using var cmd = new SQLiteCommand();
            cmd.Connection = conn;

            where.Add("BranchId=@BranchId");
            cmd.Parameters.AddWithValue("@BranchId", user.BranchId);

            if (!string.IsNullOrWhiteSpace(filter.Brand))
            {
                where.Add("Brand LIKE @Brand");
                cmd.Parameters.AddWithValue("@Brand", $"%{filter.Brand}%");
            }

            if (!string.IsNullOrWhiteSpace(filter.Model))
            {
                where.Add("Model LIKE @Model");
                cmd.Parameters.AddWithValue("@Model", $"%{filter.Model}%");
            }

            if (!string.IsNullOrWhiteSpace(filter.Color))
            {
                where.Add("Color LIKE @Color");
                cmd.Parameters.AddWithValue("@Color", $"%{filter.Color}%");
            }

            if (filter.AmountOfDoors > 0)
            {
                where.Add("Doors=@Doors");
                cmd.Parameters.AddWithValue("@Doors", filter.AmountOfDoors);
            }

            if (filter.PriceRange != null)
            {
                where.Add("Price BETWEEN @Min AND @Max");
                cmd.Parameters.AddWithValue("@Min", filter.PriceRange.Min.Amount);
                cmd.Parameters.AddWithValue("@Max", filter.PriceRange.Max.Amount);
            }

            cmd.CommandText = $@"
                SELECT * FROM Cars
                WHERE {string.Join(" AND ", where)}
            ";

            using var reader = cmd.ExecuteReader();
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
                    Mileage = Convert.ToDecimal(reader["Mileage"]),
                    TransmissionType = reader["TransmissionType"].ToString()!
                });
            }

            return cars;
        }

        public List<Time> GetTimes(int branchId)
        {
            var times = new List<Time>();

            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            using var cmd = new SQLiteCommand(
                "SELECT * FROM OpeningTimes WHERE LocationId=@branchId", conn);
            cmd.Parameters.AddWithValue("@branchId", branchId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                times.Add(new Time
                {
                    Day = Convert.ToInt32(reader["DayOfWeek"]),
                    OpenTime = reader["OpensAt"].ToString()!,
                    CloseTime = reader["ClosesAt"].ToString()!
                });
            }

            return times;
        }

        public List<string> GetCarAttributes(string column)
        {
            var result = new List<string>();
            var user = GetUser(Session.UserId);

            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            using var cmd = new SQLiteCommand(
                $"SELECT DISTINCT {column} FROM Cars WHERE BranchId=@branch",
                conn);
            cmd.Parameters.AddWithValue("@branch", user.BranchId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result.Add(reader[column].ToString()!);
            }

            return result;
        }

        public bool AddCar(Car car)
        {
            try
            {
                var user = GetUser(Session.UserId);

                using var conn = new SQLiteConnection(connectionString);
                conn.Open();

                using var cmd = new SQLiteCommand(@"
                    INSERT INTO Cars
                    (Brand, Model, Color, Doors, Price, BuildYear, Mileage, BranchId, TransmissionType)
                    VALUES
                    (@Brand, @Model, @Color, @Doors, @Price, @BuildYear, @Mileage, @BranchId, @TransmissionType)
                ", conn);

                cmd.Parameters.AddWithValue("@Brand", car.Brand);
                cmd.Parameters.AddWithValue("@Model", car.Model);
                cmd.Parameters.AddWithValue("@Color", car.Color);
                cmd.Parameters.AddWithValue("@Doors", car.AmountOfDoors);
                cmd.Parameters.AddWithValue("@Price", car.Price);
                cmd.Parameters.AddWithValue("@BuildYear", car.BuildYear);
                cmd.Parameters.AddWithValue("@Mileage", car.Mileage);
                cmd.Parameters.AddWithValue("@BranchId", user.BranchId);
                cmd.Parameters.AddWithValue("@TransmissionType", car.TransmissionType);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public List<Branch> GetBranches()
        {
            var branches = new List<Branch>();

            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            // We halen alle kolommen op uit de tabel Branches
            using var cmd = new SQLiteCommand("SELECT * FROM Branches", conn);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                branches.Add(new Branch
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString()!,
                    Location = reader["Location"].ToString()!,
                    Adress = reader["Adress"].ToString()!,
                    PhoneNumber = reader["PhoneNumber"].ToString()!,
                    PostalCode = reader["PostalCode"].ToString()!,
                    // Let op: in je GetBranchById noem je de databasekolom 'OwnerId' 
                    // maar sla je het op in de property 'Owner'.
                    Owner = reader["OwnerId"].ToString()!
                });
            }

            return branches;
        }
        public List<User> GetUsers()
        {
            var users = new List<User>();
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            // We halen alle gebruikers op uit de database
            using var cmd = new SQLiteCommand("SELECT * FROM Users", conn);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                users.Add(new User
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString()!,
                    // We halen het wachtwoord ook op, zoals je in AuthenticateUser deed
                    Password = reader["Password"].ToString()!,
                    BranchId = Convert.ToInt32(reader["BranchId"])
                });
            }

            return users;
        }
        public void DeleteUser(int id)
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            using var cmd = new SQLiteCommand("DELETE FROM Users WHERE Id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }
        public void DeleteBranch(int id)
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            using var cmd = new SQLiteCommand("DELETE FROM Branches WHERE Id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }
    }
}
