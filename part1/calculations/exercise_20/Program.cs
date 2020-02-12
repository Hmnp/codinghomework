using System;

namespace exercise_20
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

      

      int multiplication  = First_num * Second_num;
      Console.WriteLine(First_num + " * " + Second_num + " = "  + multiplication);


      // Write your code here:

    }
  }
}
