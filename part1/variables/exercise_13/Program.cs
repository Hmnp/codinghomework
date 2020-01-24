using System;

namespace exercise_13
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number!");
      String userinput = Console.ReadLine();

      double doublevalue = Convert.ToDouble(userinput);
      Console.WriteLine("You gave " + doublevalue);

      // Write your code here:

    }
  }
}
