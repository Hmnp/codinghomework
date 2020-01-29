using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first number!");
      string Inputnum_first = Console.ReadLine();
      double First_num = Convert.ToDouble(Inputnum_first);

      Console.WriteLine("Give the second number!");
      string Inputnum_second = Console.ReadLine();
      double Second_num = Convert.ToDouble(Inputnum_second);


      double sum = First_num + Second_num;
      double sub = First_num - Second_num;
      double multi = First_num * Second_num;
      double division = First_num / Second_num;

      Console.WriteLine(First_num + " + " + Second_num + " = " + sum);
      Console.WriteLine(First_num + " - " + Second_num + " = " + sub);
      Console.WriteLine(First_num + " * " + Second_num + " = " + multi);
      Console.WriteLine(First_num + " / " + Second_num + " = " + division);
      

      // Write your code here:

    }
  }
}
