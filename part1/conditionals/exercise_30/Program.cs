using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
       Console.WriteLine("Give your percent [0 - 100]:");
      string input_percentage = Console.ReadLine();
      int value_per = Convert.ToInt32(input_percentage);

      if (value_per < 0)
      {
        Console.WriteLine("Impossible");
      }
      else if (value_per <= 49)
      {
        Console.WriteLine("Fail");
      }
      else if (value_per <= 59)
      {
        Console.WriteLine("Grade: 1");
      }
      else if (value_per <= 69)
      {
        Console.WriteLine("Grade: 2");
      }
      else if (value_per <= 79)
      {
        Console.WriteLine("Grade: 3");
      }
      else if (value_per <= 89)
      {
        Console.WriteLine("Grade: 4");
      }
      else if (value_per <= 100)
      {
        Console.WriteLine("Grade: 5");
      }
      else 
      {
        Console.WriteLine("Outstanding!");
      }


      // Write your code here:

    }
  }
} 

