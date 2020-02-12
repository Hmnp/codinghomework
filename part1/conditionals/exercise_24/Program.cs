using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {
      int speed = 120;

      Console.WriteLine("Your speed:");
      string speed_value = Console.ReadLine();
      int speed_input = Convert.ToInt32(speed_value);

      if (speed_input > speed)

      {
        Console.WriteLine("Speeding!");
      }


      // Write your code here:
      
    }
  }
}
