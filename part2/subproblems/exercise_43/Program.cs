using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
      string input_num1 = Console.ReadLine();
      int enter_input1 = Convert.ToInt32(input_num1);

     if (enter_input1 < 0)

     {

     Console.WriteLine(enter_input1 * (-1));  
     }
      else{

      Console.WriteLine(enter_input1);  
      }
      
      // Write your code here:
      
    }
  }
}
