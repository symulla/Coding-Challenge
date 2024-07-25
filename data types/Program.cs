using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int myInt = 276;
      double myDouble = 45.55;
      bool myBool = true;

      Console.WriteLine(Convert.ToString(myInt));    // Convert int to string
      Console.WriteLine(Convert.ToDouble(myInt));    // Convert int to double
      Console.WriteLine(Convert.ToInt32(myDouble));  // Convert double to int
      Console.WriteLine(Convert.ToString(myBool));   // Convert bool to string
      }
  }
}