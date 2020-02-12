using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {
     Console.WriteLine("Where to?");
      int to_num = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Where from?");
      int from_num = Convert.ToInt32(Console.ReadLine());

      for (int number = from_num; number <= to_num; number++)
      {
        Console.WriteLine(number);

     }
    }
  }
}
