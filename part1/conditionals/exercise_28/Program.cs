using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
      int number = 18;

      Console.WriteLine("How old are you?");
      string input_age = Console.ReadLine();
      int input_value = Convert.ToInt32(input_age);

      if (input_value < number)

      {
        Console.WriteLine("You're under age!");
      }

      else

      {
        Console.WriteLine("You're an adult!");
      }
      // Write your code here:

    }
  }
}
