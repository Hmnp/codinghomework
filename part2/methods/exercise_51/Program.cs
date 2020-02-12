using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
       PrintUntilNumber(10);


    }

    // Write your method here:
    public static void PrintUntilNumber(int number)
    {
      int Column = 1;
      
      while (Column <= number)
      {
        
          Console.WriteLine(Column);
          Column = Column + 1;
          
      
        
          
      }
    }

    // Write your method here:

  }
}
