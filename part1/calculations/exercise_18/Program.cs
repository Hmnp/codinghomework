using System;

namespace exercise_18
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first number!");
      string Inputnum_first = Console.ReadLine();
      int First_num = Convert.ToInt32(Inputnum_first);

      Console.WriteLine("Give the second number!");
      string Inputnum_second = Console.ReadLine();
      int Second_num = Convert.ToInt32(Inputnum_second);

      Console.WriteLine("Give the third number!");
      string Inputnum_third = Console.ReadLine();
      int third_num = Convert.ToInt32(Inputnum_third);

      int sum = First_num + Second_num + third_num;
      Console.WriteLine("The sum is " + sum);


      // Write your code here:

    }
  }
}
