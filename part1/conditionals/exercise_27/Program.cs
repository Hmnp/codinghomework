using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
      int number = 0;

      Console.WriteLine("Give a number:");
      string input_num = Console.ReadLine();
      int input_value = Convert.ToInt32(input_num);

      if (input_value > number)

      {
        Console.WriteLine("It is positive");
      }

      else

      {
        Console.WriteLine("It is not positive");
      }
      // Write your code here:

    }
  }
}
