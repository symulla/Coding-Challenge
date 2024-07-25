using System;

class Program
{
    static void Main()
    {
        int[] array = { 1345, 334, 1234, 7894, 62 };
        
        Console.WriteLine("Original array:");
        PrintArray(array);
        
        Array.Sort(array);
        Console.WriteLine("Sorted array:");
        PrintArray(array);
        
        Array.Reverse(array);
        Console.WriteLine("Reversed array:");
        PrintArray(array);
    }
    
    static void PrintArray(int[] array)
    {
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}