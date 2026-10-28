// See https://aka.ms/new-console-template for more information
using ClassDemoDBUSer.database;
using Microsoft.Data.SqlClient;

Console.WriteLine("lidt om databaser");
string GetHotel = "SELECT * FROM Hotel";
string GetCustomer = "SELECT * FROM Customer";

DBConnect dbConnect = new DBConnect();

Console.WriteLine(">>>> Læser data fra Hotel");
using (var connection = dbConnect.GetOpenDBConnection("Peter", "123!#aswdASWD"))
{
    Console.WriteLine("Database connection established successfully.");
    // You can perform database operations here using the 'connection' object.

    SqlCommand command = new SqlCommand(GetHotel, connection);
    SqlDataReader reader = command.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"Hotel ID: {reader["Id"]}, Name: {reader["Name"]}, Address: {reader["Address"]}");
    }
}


Console.WriteLine(">>>> Læser data fra Customer");
using (var connection = dbConnect.GetOpenDBConnection("Peter", "123!#aswdASWD"))
{
    Console.WriteLine("Database connection established successfully.");
    // You can perform database operations here using the 'connection' object.
    try
    {
        SqlCommand command = new SqlCommand(GetCustomer, connection);
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine($"Customer ID: {reader["Id"]}, Name: {reader["Name"]}, Phone: {reader["Phone"]}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
    }
}
