using System;

namespace exercise_12
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number!");
      String userInput = Console.ReadLine();
      int intvalue = Convert.ToInt32(userInput);
      Console.WriteLine("You gave "+ intvalue);
      // Write your code here:

    }
  }
}
