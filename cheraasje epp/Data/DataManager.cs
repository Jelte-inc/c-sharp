using cheraasje_epp.Models.Entities;
using cheraasje_epp.Models.Filters;
using System.Data;
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

        public User AuthenticateUser(string userID, string password)
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            using var cmd = new SQLiteCommand(
                "SELECT * FROM Users WHERE Id=@id AND Password=@password", conn);
            cmd.Parameters.AddWithValue("@id", userID);
            cmd.Parameters.AddWithValue("@password", password);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read()) return null;

            return new User
            {
                Id = Convert.ToInt32(reader["Id"]),
                Name = reader["Name"].ToString()!,
                Password = reader["Password"].ToString()!,
                BranchId = Convert.ToInt32(reader["BranchId"])
            };
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
                BranchId = Convert.ToInt32(reader["BranchId"])
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

            where.Add("BranchId = @BranchId");
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
                where.Add("Doors = @Doors");
                cmd.Parameters.AddWithValue("@Doors", filter.AmountOfDoors);
            }

            if (filter.PriceRange != null)
            {
                where.Add("Price BETWEEN @Min AND @Max");
                cmd.Parameters.AddWithValue("@Min", filter.PriceRange.Min.Amount);
                cmd.Parameters.AddWithValue("@Max", filter.PriceRange.Max.Amount);
            }

            cmd.CommandText = $@"
                SELECT *
                FROM Cars
                WHERE {string.Join(" AND ", where)}
            ";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cars.Add(new Car
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Brand = reader["Brand"].ToString()!,
                    Model = reader["Model"].ToString()!,
                    Color = reader["Color"].ToString()!,
                    AmountOfDoors = Convert.ToInt32(reader["Doors"]),
                    Price = Convert.ToDecimal(reader["Price"]),
                    BuildYear = Convert.ToInt32(reader["BuildYear"]),
                    Mileage = Convert.ToDecimal(reader["Mileage"]),
                    LicensePlate = reader["LicensePlate"].ToString()!,
                    TransmissionType = reader["TransmissionType"].ToString()!,
                    ImagePaths = new List<string>()
                });
            }

            // Afbeeldingen ophalen per auto
            using var imgCmd = new SQLiteCommand(@"
                SELECT Path
                FROM CarImages
                WHERE CarId = @CarId
                ORDER BY Id
            ", conn);

            imgCmd.Parameters.Add("@CarId", DbType.Int64);

            foreach (var car in cars)
            {
                imgCmd.Parameters["@CarId"].Value = car.Id;

                using var imgReader = imgCmd.ExecuteReader();
                while (imgReader.Read())
                {
                    car.ImagePaths.Add(imgReader["Path"].ToString()!);
                }
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
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            using var transaction = conn.BeginTransaction();

            try
            {
                var user = GetUser(Session.UserId);

                // 1. Insert Car
                using var carCmd = new SQLiteCommand(@"
            INSERT INTO Cars
            (Brand, Model, Color, Doors, Price, BuildYear, Mileage, BranchId, TransmissionType, LicensePlate)
            VALUES
            (@Brand, @Model, @Color, @Doors, @Price, @BuildYear, @Mileage, @BranchId, @TransmissionType, @LicensePlate);
            SELECT last_insert_rowid();
        ", conn, transaction);

                carCmd.Parameters.AddWithValue("@Brand", car.Brand);
                carCmd.Parameters.AddWithValue("@Model", car.Model);
                carCmd.Parameters.AddWithValue("@Color", car.Color);
                carCmd.Parameters.AddWithValue("@Doors", car.AmountOfDoors);
                carCmd.Parameters.AddWithValue("@Price", car.Price);
                carCmd.Parameters.AddWithValue("@BuildYear", car.BuildYear);
                carCmd.Parameters.AddWithValue("@Mileage", car.Mileage);
                carCmd.Parameters.AddWithValue("@BranchId", user.BranchId);
                carCmd.Parameters.AddWithValue("@TransmissionType", car.TransmissionType);
                carCmd.Parameters.AddWithValue("@LicensePlate", car.LicensePlate);

                long carId = (long)carCmd.ExecuteScalar();

                // 2. Insert Car Images
                using var imageCmd = new SQLiteCommand(@"
            INSERT INTO CarImages (Path, CarId)
            VALUES (@Path, @CarId);
        ", conn, transaction);

                imageCmd.Parameters.Add("@Path", DbType.String);
                imageCmd.Parameters.Add("@CarId", DbType.Int64);

                foreach (var path in car.ImagePaths)
                {
                    imageCmd.Parameters["@Path"].Value = path;
                    imageCmd.Parameters["@CarId"].Value = carId;
                    imageCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}
