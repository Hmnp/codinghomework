using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a string:");
      String info = Console.ReadLine();
      
     

      Console.WriteLine("Give an integer:");
      String integ = Console.ReadLine();
      int intvalue = Convert.ToInt32(integ);     

      
      Console.WriteLine("Give a double:");
      String input = Console.ReadLine();
      Double doublevalue = Convert.ToDouble(input);
      

      Console.WriteLine("Give a boolean:");
      string userinput = Console.ReadLine();
      
      bool stat = System.Convert.ToBoolean(userinput);

      Console.WriteLine("Your string: " + info);
      Console.WriteLine("Your integer: " + intvalue);
      Console.WriteLine("Your double: " + doublevalue);
      Console.WriteLine("Your boolean: " + stat); 
      
      
      

           
       
       




      // Write your code here:

    }
  }
}
