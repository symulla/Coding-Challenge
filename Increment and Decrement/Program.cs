using System;

class Program
{
    static void Main()
    {
        int x = 10;
        Console.WriteLine("value x: " + x);

        int valueIncrement = x++;
        Console.WriteLine("Value-Increment: " + valueIncrement);
        Console.WriteLine("x after Value-Increment: " + x);

        x = 10;
        int NoIncrement = ++x;
        Console.WriteLine("No-Increment: " + NoIncrement);
        Console.WriteLine("x after No-Increment: " + x);

        // Decrement
        int y = 10;
        Console.WriteLine("\nValue y: " + y);

        int ValueDecrement = y--;
        Console.WriteLine("Value-Decrement: " + ValueDecrement);
        Console.WriteLine("y after Value-Decrement: " + y);

        y = 10;
        int NoDecrement = --y;
        Console.WriteLine("No-Decrement: " + NoDecrement);
        Console.WriteLine("y after No-Decrement: " + y);
    }
}