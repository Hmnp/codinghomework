using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
      // Write your code here:
      
      while (true)
      {
        Console.WriteLine("Give a number:");
        string input_num = Console.ReadLine();
        int input_ent = Convert.ToInt32(input_num);

        if (input_ent == 0)
        {
          break;
        }
        else
        {
          sum = sum + 1;
        }
      }
      
        {
          Console.WriteLine("Total amount of numbers: " + sum);
        }
      
 
    }
  }
}
