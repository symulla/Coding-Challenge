using System;

class Program
{
    static void Main()
    {
        // Mixed Arithmetic
        int StudentMarks = 100;
        decimal AverageMark = ((StudentMarks - 29) * 5m / 9);
        Console.WriteLine("The Average Mark is " + AverageMark + " out of 100");

        // Decimal Arithmetic and Rounding
        int StudentMarks2 = 100;
        decimal AverageMark2 = ((StudentMarks2 - 29m) * 5m / 9m);
        Console.WriteLine("The Average Mark is " + Math.Round(AverageMark2) + " out of 100");
    }
}