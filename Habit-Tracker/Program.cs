using System.Collections.Generic;
using System.Data;
using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.FileIO;
internal class Program

{
static string connectionString = "Data source=habit-tracker.db";

    private static void Main(string[] args)
    {
        //12:27
        GetUserInput();

        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            var tableCmd = connection.CreateCommand();

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
            bool closeapp = false;
            while (closeapp == false)
            {
                Console.WriteLine("\n\n MAIN MENU");
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("\nType '0' to Close Application.");
                Console.WriteLine("\nType '1' to View All Records.");
                Console.WriteLine("\nType '2' to Insert Records.");
                Console.WriteLine("\nType '3' to Delete Records.");
                Console.WriteLine("\nType '4' to Update Records.");
                Console.WriteLine("----------------------------------\n");

                int command = Convert.ToInt32(Console.ReadLine());
                switch (command)
                {
                    case 0:
                        Console.WriteLine("\nGoodbye!\n");
                        closeapp = true;
                        break;

                    case 1:
                        //GetAllRecords();
                        break;

                    case 2:
                        // Insert();
                        break;

                    case 3:
                        // Delete();
                        break;

                    case 4:
                        //Update();
                        break;

                    default:
                        Console.WriteLine("\nInvalid command. Please type a number from 0 to 4.\n");
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
            string date = GetDateInput();
            int quantity = GetNumberInput("\n\nPlease insert number of glasses or other measure of your choice (no decimals allowed)\n\n");
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var tableCmd = connection.CreateCommand();

                tableCmd.CommandText =
                $"INSERT INTO drinking_water(date,quantity) VALUES ('{date}',{quantity})";

                tableCmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        static string GetDateInput()
        {
            Console.WriteLine("\n\nPlease insert the date : (format: dd-mm-yy). Type 0 to return to main menu.\n\n");
            string dateInput = Console.ReadLine();
            if (dateInput == "0") GetUserInput();
            return dateInput;
        }
        static int GetNumberInput(string message)
        {
            Console.WriteLine(message);
            string numberInput = Console.ReadLine();
            if (numberInput == "0") GetUserInput();
            int finalInput = Convert.ToInt32(numberInput);
            return finalInput;
        }

        static void GetAllRecords()
        {
            throw new NotImplementedException();
        }
    }
}