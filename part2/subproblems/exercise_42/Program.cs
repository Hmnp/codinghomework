using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {
      string input_num1 = Console.ReadLine();
      int enter_input1 = Convert.ToInt32(input_num1);

      string input_num2 = Console.ReadLine();
      int enter_input2 = Convert.ToInt32(input_num2);

      int sum = enter_input1 + enter_input2;

      double sqroot = Math.Sqrt(sum);


      Console.WriteLine(sqroot);

      // Write your code here:
    
    }
  }
}
