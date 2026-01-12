using CheraasjeEpp.Models.Entities;
using CheraasjeEpp.Models.Filters;
using System.Data;
using System.Data.SQLite;

namespace CheraasjeEpp.Data
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

        /// <summary>
        /// Creates and opens a new SQLite connection.
        /// </summary>
        /// <returns>An open SQLiteConnection.</returns>
        private SQLiteConnection GetConnection()
        {
            var conn = new SQLiteConnection(connectionString);
            conn.Open();
            return conn;
        }

        /// <summary>
        /// Authenticates a user based on their ID and password.
        /// </summary>
        public bool AuthenticateUser(string userID, string password)
        {
            using var conn = GetConnection();

            using var cmd = new SQLiteCommand(
                "SELECT * FROM Users WHERE Id=@id AND Password=@password", conn);
            cmd.Parameters.AddWithValue("@id", userID);
            cmd.Parameters.AddWithValue("@password", password);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read()) return false;
            return true;
        }

        /// <summary>
        /// Retrieves a user by their ID.
        /// </summary>
        public User GetUser(int id)
        {
            using var conn = GetConnection();

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

        /// <summary>
        /// Retrieves a branch by its ID.
        /// </summary>
        public Branch GetBranchById(int id)
        {
            using var conn = GetConnection();

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
                Owner = Convert.ToInt32(reader["OwnerId"])
            };
        }

        /// <summary>
        /// Retrieves a list of cars based on the provided filter.
        /// </summary>
        public List<Car> GetCars(CarFilter filter, bool companyWide = false)
        {
            var cars = new List<Car>();
            var where = new List<string>();

            using var conn = GetConnection();

            using var cmd = new SQLiteCommand();
            cmd.Connection = conn;

            if (!companyWide)
            {
                var user = GetUser(Session.UserId);
                where.Add("BranchId=@BranchId");
                cmd.Parameters.AddWithValue("@BranchId", user.BranchId);
            }

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

            if (filter.AmountOfDoors > 0 && filter.AmountOfDoors != null)
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

            string sql = "SELECT * FROM Cars";
            if (where.Count > 0)
            {
                sql += " WHERE " + string.Join(" AND ", where);
            }
            cmd.CommandText = sql;

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

            // Fetch images per car
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

            using var conn = GetConnection();

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

            using var conn = GetConnection();

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
            using var conn = GetConnection();

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

        public List<Branch> GetBranches()
        {
            var branches = new List<Branch>();

            using var conn = GetConnection();

            // Fetch all columns from the Branches table
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
                    // Note: in GetBranchById the database column is named 'OwnerId'
                    // but it is stored in the property 'Owner'.
                    Owner = Convert.ToInt32(reader["OwnerId"])
                });
            }

            return branches;
        }

        public List<User> GetUsers()
        {
            var users = new List<User>();
            using var conn = GetConnection();

            // Fetch all users from the database
            using var cmd = new SQLiteCommand("SELECT * FROM Users", conn);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                users.Add(new User
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString()!,
                    // We also fetch the password, just like in AuthenticateUser
                    Password = reader["Password"].ToString()!,
                    BranchId = Convert.ToInt32(reader["BranchId"])
                });
            }

            return users;
        }

        public void DeleteUser(int id)
        {
            using var conn = GetConnection();

            using var cmd = new SQLiteCommand("DELETE FROM Users WHERE Id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }

        public void DeleteBranch(int id)
        {
            using var conn = GetConnection();

            using var cmd = new SQLiteCommand("DELETE FROM Branches WHERE Id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }

        public void AddUser(User user)
        {
            using var conn = GetConnection();

            using var cmd = new SQLiteCommand(@"
        INSERT INTO Users 
        (Name, Password, BranchId, IsAdmin) 
        VALUES 
        (@Name, @Password, @BranchId, @IsAdmin)
    ", conn);

            cmd.Parameters.AddWithValue("@Name", user.Name);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@BranchId", user.BranchId);
            cmd.Parameters.AddWithValue("@IsAdmin", user.IsAdmin ? 1 : 0);

            cmd.ExecuteNonQuery();
        }

        public void UpdateUser(User user)
        {
            using var conn = GetConnection();

            // Update the fields for the user where the Id matches
            using var cmd = new SQLiteCommand(@"
        UPDATE Users 
        SET Name = @Name, 
            Password = @Password, 
            BranchId = @BranchId, 
            IsAdmin = @IsAdmin
        WHERE Id = @Id
    ", conn);

            cmd.Parameters.AddWithValue("@Name", user.Name);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@BranchId", user.BranchId);
            // SQLite uses 1 for true and 0 for false
            cmd.Parameters.AddWithValue("@IsAdmin", user.IsAdmin ? 1 : 0);
            cmd.Parameters.AddWithValue("@Id", user.Id);

            cmd.ExecuteNonQuery();
        }

        public void AddBranch(Branch branch)
        {
            using var conn = GetConnection();

            using var cmd = new SQLiteCommand(@"
        INSERT INTO Branches 
        (Name, Location, Adress, PhoneNumber, PostalCode, OwnerId) 
        VALUES 
        (@Name, @Location, @Adress, @PhoneNumber, @PostalCode, @OwnerId)
    ", conn);

            cmd.Parameters.AddWithValue("@Name", branch.Name);
            cmd.Parameters.AddWithValue("@Location", branch.Location);
            cmd.Parameters.AddWithValue("@Adress", branch.Adress);
            cmd.Parameters.AddWithValue("@PhoneNumber", branch.PhoneNumber);
            cmd.Parameters.AddWithValue("@PostalCode", branch.PostalCode);
            cmd.Parameters.AddWithValue("@OwnerId", branch.Owner);

            cmd.ExecuteNonQuery();
        }

        public void UpdateBranch(Branch branch)
        {
            using var conn = GetConnection();

            using var cmd = new SQLiteCommand(@"
        UPDATE Branches 
        SET Name = @Name, 
            Location = @Location, 
            Adress = @Adress, 
            PhoneNumber = @PhoneNumber, 
            PostalCode = @PostalCode, 
            OwnerId = @OwnerId
        WHERE Id = @Id
    ", conn);

            cmd.Parameters.AddWithValue("@Name", branch.Name);
            cmd.Parameters.AddWithValue("@Location", branch.Location);
            cmd.Parameters.AddWithValue("@Adress", branch.Adress);
            cmd.Parameters.AddWithValue("@PhoneNumber", branch.PhoneNumber);
            cmd.Parameters.AddWithValue("@PostalCode", branch.PostalCode);
            cmd.Parameters.AddWithValue("@OwnerId", branch.Owner);
            cmd.Parameters.AddWithValue("@Id", branch.Id);

            cmd.ExecuteNonQuery();
        }

        public bool DeleteCar(int carId)
        {
            using var conn = GetConnection();

            using var transaction = conn.BeginTransaction();

            try
            {
                // 1. Delete images of the car
                using var deleteImagesCmd = new SQLiteCommand(
                    "DELETE FROM CarImages WHERE CarId = @CarId",
                    conn,
                    transaction
                );
                deleteImagesCmd.Parameters.AddWithValue("@CarId", carId);
                deleteImagesCmd.ExecuteNonQuery();

                // 2. Delete the car itself
                using var deleteCarCmd = new SQLiteCommand(
                    "DELETE FROM Cars WHERE Id = @Id",
                    conn,
                    transaction
                );
                deleteCarCmd.Parameters.AddWithValue("@Id", carId);
                deleteCarCmd.ExecuteNonQuery();

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
