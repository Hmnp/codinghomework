using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
         int sum = 0;
      while (true)
      {
        Console.WriteLine("Give a number:");
        string input_num= Console.ReadLine();
        int input_enter = Convert.ToInt32(input_num);

        if (input_enter == 0)
        {
          break;
        }
        else
        {
          sum = sum + input_enter;
        }
      }
      {
        Console.WriteLine("Total sum of numbers: " + sum);
      }
      // Write your code here:
    }
  }
}
