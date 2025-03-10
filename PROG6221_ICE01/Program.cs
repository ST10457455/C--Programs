using System;

class UserDetails
{
    public string Name { get; set; } = "Not Entered";
    public string CellNumber { get; set; } = "Not Entered";
    public string Age { get; set; } = "Not Entered";

    public void EnterName()
    {
        Console.Write("Enter your Name: ");
        Name = Console.ReadLine();
    }

    public void EnterCellNumber()
    {
        Console.Write("Enter your Cell Number: ");
        CellNumber = Console.ReadLine();
    }

    public void EnterAge()
    {
        Console.Write("Enter your Age: ");
        Age = Console.ReadLine();
    }

    public void PrintSummary()
    {
        Console.Clear();
        Console.WriteLine("\n--- User Details ---");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Cell Number: {CellNumber}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }
}

class Program
{
    static void Main()
    {
        UserDetails userDetails = new UserDetails();
        ConsoleKey key;
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome!");
            Console.WriteLine("Press F1 to enter your name.");
            Console.WriteLine("Press F2 to enter your Cell Number.");
            Console.WriteLine("Enter 3 into the console to enter your Age.");
            Console.WriteLine("Enter 4 to print a summary of your details.");
            Console.WriteLine("Press Esc to exit.");
            
            key = Console.ReadKey(true).Key;
            
            switch (key)
            {
                case ConsoleKey.F1:
                    userDetails.EnterName();
                    break;
                case ConsoleKey.F2:
                    userDetails.EnterCellNumber();
                    break;
                case ConsoleKey.D3:
                    userDetails.EnterAge();
                    break;
                case ConsoleKey.D4:
                    userDetails.PrintSummary();
                    break;
            }
        } while (key != ConsoleKey.Escape);
    }
}


