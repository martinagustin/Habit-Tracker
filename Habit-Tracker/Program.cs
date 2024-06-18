using System.Collections.Generic;
using Microsoft.Data.Sqlite;

string connectionString=@"Data source=habit-tracker.db";
    using (var connection = new SqliteConnection(connectionString))
    {
        connection.Open();
        var tableCmd=connection.CreateCommand();

        tableCmd.CommandText = 
        @"CREATE TABLE IF NOT EXISTS drinking_water (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            Date TEXT,
            Quantity INTEGER
        )";

        tableCmd.ExecuteNonQuery();
    }

static void GetUserInput()
{
    Console.Clear();
    bool closeapp= false;
    while(closeapp == false ){
        System.Console.WriteLine("\n\n MAIN MENU");
        System.Console.WriteLine("\nWhat would you like to do?");
        System.Console.WriteLine("\nType '0' to Close Application.");
        System.Console.WriteLine("\nType '1' to View All Records.");
        System.Console.WriteLine("\nType '2' to Insert Records.");
        System.Console.WriteLine("\nType '3' to Delete Records.");
        System.Console.WriteLine("\nType '4' to Update Records.");
    }
}