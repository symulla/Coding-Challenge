using System;

class Program
{
    static void Main()
    {
        string sentence = "Studying C sharp is very interesting and educative";

        // Split the sentence into words
        string[] subs = sentence.Split(' ');

        // Iterate , reverse it, and print the result
        foreach (var sub in subs)
        {
            char[] word = sub.ToCharArray();
            Array.Reverse(word);
            string result = new string(word); // Create a new string from the reversed char array
            Console.WriteLine(result);
        }
    }
}