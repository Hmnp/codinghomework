using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {
       Console.WriteLine("Give numbers:"); 
      
      int sum = 0;
      int amount_total = 0;
      int odd_num = 0;
      int even_num = 0;

      
      
      while (true)
      {
        int number = Convert.ToInt32(Console.ReadLine());
        
        if (number != -1)
        {
          sum = sum + number;
          amount_total++;
          
          if (number % 2 == 0)
          {
            even_num++;

          }
          else
          {
            odd_num++;

          }

        }
        
        else if (number == -1)
        {
          Console.WriteLine("Thx! Bye!");
          Console.WriteLine("Sum: " + sum);
          Console.WriteLine("Numbers: " + amount_total);
          Console.WriteLine("Average: " + ((double)sum / amount_total));
          Console.WriteLine("Even: " + even_num);
          Console.WriteLine("Odd: " + odd_num);
          break;
        }

      }
      // Write your code here:
 
    }
  }
}
