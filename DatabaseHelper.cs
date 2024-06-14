using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ISIK_Group
{
    public static class DatabaseHelper
    {
        private static string connectionStringTemplate = "Server=localhost;Database={0};User ID=root;Password=YUv*2[@Ay@lqZCpCTiRWzpf0^kq1F|;";
        private static string agencyDatabase = "ISIKGroupDB";

        public static void SetAgencyDatabase(string agencyName)
        {
            agencyDatabase = agencyName;
        }

        public static MySqlConnection GetConnection()
        {
            string connectionString = string.Format(connectionStringTemplate, agencyDatabase);
            return new MySqlConnection(connectionString);
        }

        public static void InitializeDatabase(string agencyName)
        {
            using var connection = GetConnection();
            connection.Open();

            string createProcedure = @"
                DELIMITER //
                CREATE PROCEDURE IF NOT EXISTS CreateAgencyDatabase(IN agencyName VARCHAR(255))
                BEGIN
                    SET @createDatabase = CONCAT('CREATE DATABASE IF NOT EXISTS ', agencyName, ';');
                    PREPARE stmt FROM @createDatabase;
                    EXECUTE stmt;
                    DEALLOCATE PREPARE stmt;

                    SET @useDatabase = CONCAT('USE ', agencyName, ';');
                    PREPARE stmt FROM @useDatabase;
                    EXECUTE stmt;
                    DEALLOCATE PREPARE stmt;

                    CREATE TABLE IF NOT EXISTS admin (
                        UserID INT AUTO_INCREMENT PRIMARY KEY,
                        Username VARCHAR(255) NOT NULL UNIQUE,
                        Password VARCHAR(255) NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Customers (
                        CustomerID INT AUTO_INCREMENT PRIMARY KEY,
                        FirstName VARCHAR(255) NOT NULL,
                        LastName VARCHAR(255) NOT NULL,
                        CustomerNumber VARCHAR(255) NOT NULL UNIQUE,
                        IsBlocked BOOLEAN NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Bookings (
                        BookingID INT AUTO_INCREMENT PRIMARY KEY,
                        BookingNumber VARCHAR(255) NOT NULL UNIQUE,
                        Date DATE NOT NULL,
                        CustomerID INT,
                        Participants VARCHAR(255),
                        Organizer VARCHAR(255),
                        TotalPrice DECIMAL(10, 2),
                        OpenPrice DECIMAL(10, 2),
                        FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
                    );

                    CREATE TABLE IF NOT EXISTS TravelAgencies (
                        AgencyID INT AUTO_INCREMENT PRIMARY KEY,
                        AgencyName VARCHAR(255) NOT NULL UNIQUE
                    );

                    INSERT INTO admin (Username, Password) VALUES ('admin', 'admin');
                END //
                DELIMITER ;";

            using (var command = new MySqlCommand(createProcedure, connection))
            {
                command.ExecuteNonQuery();
            }

            using (var command = new MySqlCommand("CALL CreateAgencyDatabase(@agencyName)", connection))
            {
                command.Parameters.AddWithValue("@agencyName", agencyName);
                command.ExecuteNonQuery();
            }
        }

        public static MySqlDataReader GetBookings()
        {
            var connection = GetConnection();
            var command = new MySqlCommand("SELECT * FROM Bookings", connection);
            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public static void AddBooking(string bookingNumber, DateTime date, int customerId, string participants, string organizer, decimal totalPrice, decimal openPrice)
        {
            using var connection = GetConnection();
            string query = "INSERT INTO Bookings (BookingNumber, Date, CustomerID, Participants, Organizer, TotalPrice, OpenPrice) VALUES (@BookingNumber, @Date, @CustomerID, @Participants, @Organizer, @TotalPrice, @OpenPrice)";
            using var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookingNumber", bookingNumber);
            command.Parameters.AddWithValue("@Date", date);
            command.Parameters.AddWithValue("@CustomerID", customerId);
            command.Parameters.AddWithValue("@Participants", participants);
            command.Parameters.AddWithValue("@Organizer", organizer);
            command.Parameters.AddWithValue("@TotalPrice", totalPrice);
            command.Parameters.AddWithValue("@OpenPrice", openPrice);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public static void DeleteBooking(int bookingId)
        {
            using var connection = GetConnection();
            string query = "DELETE FROM Bookings WHERE BookingID = @BookingID";
            using var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookingID", bookingId);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public static MySqlDataReader GetAgencies()
        {
            var connection = GetConnection();
            var command = new MySqlCommand("SELECT * FROM TravelAgencies", connection);
            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public static void AddAgency(string agencyName)
        {
            using var connection = GetConnection();
            string query = "INSERT INTO TravelAgencies (AgencyName) VALUES (@AgencyName)";
            using var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@AgencyName", agencyName);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public static void DeleteAgency(string agencyName)
        {
            using var connection = GetConnection();
            string query = "DELETE FROM TravelAgencies WHERE AgencyName = @AgencyName";
            using var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@AgencyName", agencyName);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public static MySqlDataReader GetCustomers()
        {
            var connection = GetConnection();
            var command = new MySqlCommand("SELECT * FROM Customers", connection);
            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public static void AddCustomer(string firstName, string lastName, string customerNumber, bool isBlocked)
        {
            using var connection = GetConnection();
            string query = "INSERT INTO Customers (FirstName, LastName, CustomerNumber, IsBlocked) VALUES (@FirstName, @LastName, @CustomerNumber, @IsBlocked)";
            using var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@CustomerNumber", customerNumber);
            command.Parameters.AddWithValue("@IsBlocked", isBlocked);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public static bool AuthenticateUser(string username, string password)
        {
            using var connection = GetConnection();
            string query = "SELECT COUNT(1) FROM admin WHERE Username = @Username AND Password = @Password";
            using var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            connection.Open();
            int result = Convert.ToInt32(command.ExecuteScalar());
            return result > 0;
        }
    }
}
