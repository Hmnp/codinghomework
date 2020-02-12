using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
      string input_num = Console.ReadLine();
      int n = Convert.ToInt32(input_num);

      if (n % 2 == 0)
      {
        Console.WriteLine("It is even.");
      }

      else
      {
        Console.WriteLine("It is odd.");
      }
      // Write your code here:

    }
  }
}
