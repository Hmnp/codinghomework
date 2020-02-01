using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {
      int total = 0;
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
          total = total + 1;
        }
        
      }
      {
        Console.WriteLine("Total sum of numbers: " + sum);
        Console.WriteLine("Total amount of numbers: " + total);
        
      }

      // Write your code here:
    }
  }
}
