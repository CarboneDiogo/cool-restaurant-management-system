using Microsoft.Data.SqlClient;

namespace cool_restaurant_management_system.Data
{
    public class DbServer
    {
        // Connection string for the database
        private static string databaseConnectionString = "Data Source=localhost;Initial Catalog=Restaurant;Integrated Security=True; TrustServerCertificate=True; Encrypt=false";

        // Method to add a new reservation to the database
        public void AddNewReservation(string phone, string guestName, int table_Id, int numberOfGuests, DateTime reservationDate)
        {
            using (SqlConnection localConn = new SqlConnection(databaseConnectionString))
            {
                localConn.Open();
                // Create a SQL command to insert data into the 'Reservations' table
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Reservations " +
                    "(Phone_Number, " +
                    "Guest_Name, " +
                    "Table_Id," +
                    "Number_of_Guests," +
                    "Reservation_Date)" +
                    "VALUES " +
                    "(@Phone_Number, " +
                    "@Guest_Name, " +
                    "@Table_Id," +
                    "@Number_of_Guests," +
                    "@Reservation_Date)", localConn);

                // Set parameter values to prevent SQL injection
                cmd.Parameters.AddWithValue("@Phone_Number", phone);
                cmd.Parameters.AddWithValue("@Guest_Name", guestName);
                cmd.Parameters.AddWithValue("@Table_Id", table_Id);
                cmd.Parameters.AddWithValue("@Number_Of_Guests", numberOfGuests);
                cmd.Parameters.AddWithValue("@Reservation_Date", reservationDate);

                cmd.ExecuteNonQuery();  // Execute the SQL command
            }
        }

        // Method to retrieve all reservations from the database
        public List<Reservations> GetAllReservations()
        {
            List<Reservations> reservations = new List<Reservations>();  // List to store reservations
            string sqlQuery = "SELECT * FROM Reservations";  // SQL query to retrieve reservations

            using (SqlConnection localConn = new SqlConnection(databaseConnectionString))
            {
                localConn.Open();  // Open the database connection
                using (SqlCommand command = new SqlCommand(sqlQuery, localConn))  // Create a SQL command
                using (SqlDataReader reader = command.ExecuteReader())  // Execute the command and retrieve data
                {
                    while (reader.Read())  // Loop through retrieved data
                    {
                        // Create a 'Reservations' object from data and add to the list
                        Reservations reservation = new Reservations()
                        {
                            Phone_Number = reader.GetString(reader.GetOrdinal("Phone_Number")),
                            Table_Id = reader.GetInt32(reader.GetOrdinal("Table_Id")),
                            Guest_Name = reader.GetString(reader.GetOrdinal("Guest_Name")),
                            Number_of_Guests = reader.GetInt32(reader.GetOrdinal("Number_of_Guests")),
                            Reservation_Date = reader.GetDateTime(reader.GetOrdinal("Reservation_Date"))
                        };
                        reservations.Add(reservation);
                    }
                }
            }

            return reservations;  // Return the list of reservations
        }

        // Method to retrieve all tables from the database
        public List<RestaurantTables> GetAllTables()
        {
            List<RestaurantTables> tables = new List<RestaurantTables>();  // List to store tables
            string sqlQuery = "SELECT * FROM RestaurantTables";  // SQL query to retrieve tables

            using (SqlConnection localConn = new SqlConnection(databaseConnectionString))
            {
                localConn.Open();  // Open the database connection
                using (SqlCommand command = new SqlCommand(sqlQuery, localConn))  // Create a SQL command
                using (SqlDataReader reader = command.ExecuteReader())  // Execute the command and retrieve data
                {
                    while (reader.Read())  // Loop through retrieved data
                    {
                        // Create a 'RestaurantTables' object from data and add to the list
                        RestaurantTables table = new RestaurantTables()
                        {
                            Table_Id = reader.GetInt32(reader.GetOrdinal("Table_Id")),
                            Is_Available = reader.GetInt32(reader.GetOrdinal("Is_Available")),
                            Capacity = reader.GetInt32(reader.GetOrdinal("Capacity"))
                        };
                        tables.Add(table);
                    }
                }
            }

            return tables;  // Return the list of tables
        }

        // Method to retrieve a table by its ID
        public List<RestaurantTables> GetTableById(int tableId)
        {
            List<RestaurantTables> tables = new List<RestaurantTables>();  // List to store tables
            string sqlQuery = "SELECT * FROM RestaurantTables WHERE Table_Id = @tableId";  // SQL query to retrieve a specific table

            using (SqlConnection connection = new SqlConnection(databaseConnectionString))
            {
                connection.Open();  // Open the database connection
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))  // Create a SQL command
                {
                    command.Parameters.AddWithValue("@tableId", tableId);  // Set parameter value

                    using (SqlDataReader reader = command.ExecuteReader())  // Execute the command and retrieve data
                    {
                        while (reader.Read())  // Loop through retrieved data
                        {
                            // Create a 'RestaurantTables' object from data and add to the list
                            RestaurantTables table = new RestaurantTables()
                            {
                                Table_Id = reader.GetInt32(reader.GetOrdinal("Table_Id")),
                                Is_Available = reader.GetInt32(reader.GetOrdinal("Is_Available")),
                                Capacity = reader.GetInt32(reader.GetOrdinal("Capacity"))
                            };
                            tables.Add(table);
                        }
                    }
                }
            }

            return tables;  // Return the list of tables
        }

        // Method to update a reservation
        public void UpdateReservation(string phone, string newName, int newTableId, int newPartySize, DateTime newDate)
        {
            string updateQuery = @"UPDATE Reservations SET 
                           Guest_Name = @newName,
                           Table_Id = @newTableId,
                           Number_of_Guests = @newPartySize,
                           Reservation_Date = @newDate 
                           WHERE Phone_Number = @phone";  // SQL query to update a reservation

            using (SqlConnection localConn = new SqlConnection(databaseConnectionString))
            {
                localConn.Open();  // Open the database connection
                using SqlCommand updateCommand = new SqlCommand(updateQuery, localConn);  // Create a SQL command
                updateCommand.Parameters.AddWithValue("@newName", newName);  // Set parameter values
                updateCommand.Parameters.AddWithValue("@newTableId", newTableId);
                updateCommand.Parameters.AddWithValue("@newPartySize", newPartySize);
                updateCommand.Parameters.AddWithValue("@newDate", newDate);
                updateCommand.Parameters.AddWithValue("@phone", phone);
                updateCommand.ExecuteNonQuery();  // Execute the SQL command
            }
        }

        // Method to delete a reservation by phone number
        public void DeleteReservationByPhone(string phone)
        {
            string deleteQuery = "DELETE FROM Reservations WHERE Phone_Number = @phone";  // SQL query to delete a reservation

            using (SqlConnection localConn = new SqlConnection(databaseConnectionString))
            {
                localConn.Open();  // Open the database connection
                using SqlCommand deleteCommand = new SqlCommand(deleteQuery, localConn);  // Create a SQL command
                deleteCommand.Parameters.AddWithValue("@phone", phone);  // Set parameter value
                deleteCommand.ExecuteNonQuery();  // Execute the SQL command
            }
        }
    }
}
