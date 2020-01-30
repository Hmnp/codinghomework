using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first string:");
      string first_str = Console.ReadLine();

      Console.WriteLine("Give the second string:");
      string Second_str = Console.ReadLine();

      if (first_str == Second_str)
      {
        Console.WriteLine("Echo!");
      }
      else
      {
        Console.WriteLine("Nope!");
      }
      // Write your code here:

    }
  }
}
