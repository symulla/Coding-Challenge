using System;
class Program
{
    static void Main()
    {
        
Console.WriteLine("Please enter the amount: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int amount))
{
    if (amount < 1000)
    {
        Console.WriteLine("Sorry, too low!!");
    }
    else if (amount < 2000)
    {
        Console.WriteLine("The system is giving you 2 weeks to pay your remaining balance.");
    }
    else
    {
        Console.WriteLine("You are good to go.");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}
        }
    }

