using System;

namespace exercise_54
{
  class Program
  {
    public static void Main(String[] args)
    {
      DivisibleByThreeInRange(1, 15);

    }

    // Write your method here:
    public static void DivisibleByThreeInRange(int beginning, int end)
    {
      while (beginning <= end)
      {
        if (beginning % 3 == 0)
        {
          Console.WriteLine(beginning);
          
        }
        beginning = beginning + 1;
      }
      // Call your method here:

    }

    // Write your method here:

  }
}
