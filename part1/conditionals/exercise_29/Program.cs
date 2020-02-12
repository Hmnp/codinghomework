using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give the first number!");
      string input_num = Console.ReadLine();
      int input_value = Convert.ToInt32(input_num);

      Console.WriteLine("Give the second number!");
      string input_num2 = Console.ReadLine();
      int input_value2 = Convert.ToInt32(input_num2);

      if (input_value < input_value2)

      {
        Console.WriteLine("The larger number is " + input_num2 + "!");
      }

      else if (input_value > input_value2)

      {
        Console.WriteLine("The larger number is " + input_num + "!");
      }

      else 
      {
        Console.WriteLine("They are equal!");



      }
      // Write your code here:

    }
  }
}
