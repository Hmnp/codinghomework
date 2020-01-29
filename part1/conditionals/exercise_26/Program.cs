using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      int number = 1900;

      Console.WriteLine("Give your age:");
      string input_age = Console.ReadLine();
      int input_value = Convert.ToInt32(input_age);

      if (input_value < number)

      {
        Console.WriteLine("You're old");
      }
      // Write your code here:

    }
  }
}
