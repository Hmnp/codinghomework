using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("How many times?");
      int given_num = Convert.ToInt32(Console.ReadLine());
      int i = 1;

      while (i <= given_num)
      {
        PrintPhrase();
        i++;
      }

    }
    public static void PrintPhrase()
    {
      Console.WriteLine("In a hole in the ground there lived a method");
    }

     
  }
}
