using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true)
      
      {
        Console.WriteLine("Give a number:");
        string input_num = Console.ReadLine();
        int enter_num = Convert.ToInt32(input_num);

        if (enter_num == 0)
        {
          break;
        }

        else if (enter_num < 0)
          
        {
        Console.WriteLine("That is negative");
        }

        else

        {
          Console.WriteLine(enter_num * enter_num);
        }
        
            
        
      }
      // Write your code here:

    }
  }
}
