using System.Collections.Generic;
using System.Data;
using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.FileIO;

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
        System.Console.WriteLine("----------------------------------\n");

        int command=Convert.ToInt32( Console.ReadLine());
        switch(command){
            case 0:
            System.Console.WriteLine("\nGoodbye!\n");
            closeapp=true;
            break;

            case 1:
                GetAllRecords();
                break;

            case 2:
                Insert();
                break;

            case 3:
                Delete();
                break;

            case 4:
                Update();
                break;

            default:
                System.Console.WriteLine("\nInvalid command. Please type a number from 0 to 4.\n");
                break;
        }
    }
}

static void Update()
{
    throw new NotImplementedException();
}

static void Delete()
{
    throw new NotImplementedException();
}

static void Insert()
{
    throw new NotImplementedException();
}

static void GetAllRecords()
{
    throw new NotImplementedException();
}