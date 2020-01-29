using System;

namespace exercise_25
{
  class Program
  {
    public static void Main(string[] args)
    {
      int number = 1984;

      Console.WriteLine("Give a number:");
      string input_num = Console.ReadLine();
      int input_value = Convert.ToInt32(input_num);

      if (input_value == number)

      {
        Console.WriteLine("Orwell");
      }
      // Write your code here:

    }
  }
}
