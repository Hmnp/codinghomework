using System;

namespace exercise_58
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Smallest(2, 7);
      Console.WriteLine("Smallest: " + answer);
    }
    public static int Smallest(int first, int second)

    {

      if (first < second)
      {
        return first;

      }
      else
      {
      return second;
      }
    }

    // Write your method here:
    
  }
}
