using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Count Graph Readings
        int[] GraphReading = { 5, -3, 4, -7, -3, 6 };
        int uniqueCount = CountUniqueAbsoluteValues(GraphReading);
        Console.WriteLine($"Number of unique Graph Readings: {uniqueCount}");

        // Calculate trials
        Solution solution = new Solution();
        int trials = solution.CalculateTrials(40, 62, 36);
        Console.WriteLine($"Number of trials needed: {trials}");
    }

    static int CountUniqueAbsoluteValues(int[] GraphReading)
    {
        HashSet<int> abNumbers = new HashSet<int>();

        foreach (int num in GraphReading)
        {
            abNumbers.Add(Math.Abs(num));
        }

        return abNumbers.Count;
    }
}

class Solution
{
    public int CalculateTrials(int A, int B, int D)
    {
        if (A >= B)
        {
            return 0;
        }
        return (int)Math.Ceiling((double)(B - A) / D);
    }
}