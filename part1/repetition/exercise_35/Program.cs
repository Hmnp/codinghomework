using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
       while (true)
      {
        Console.WriteLine("Give a number:");
        string number = Console.ReadLine();
        int input_num = Convert.ToInt32(number);

        if (input_num == 42)
      {
        break; 
      }

      // Write your code here:

      }
    }
  }
}
