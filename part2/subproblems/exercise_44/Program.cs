using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {
      string input_num1 = Console.ReadLine();
      int enter_input1 = Convert.ToInt32(input_num1);

      string input_num2 = Console.ReadLine();
      int enter_input2 = Convert.ToInt32(input_num2);

      if (enter_input1 > enter_input2)
      {

        Console.WriteLine(enter_input1 + " is greater than " + enter_input2 + ".");

      }
      else if (enter_input1 < enter_input2)
      {

         Console.WriteLine(enter_input1 + " is less than " + enter_input2 + "."); 

      }
      else
      {

        Console.WriteLine(enter_input1 + " is equal to " + enter_input2 + ".");
      
      }
      // Write your code here:

    }
  }
}
