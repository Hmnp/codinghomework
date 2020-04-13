using System;
using System.Collections.Generic;

namespace exercise_91
{
  class Program
  {
    public static void Main(string[] args)
    {
      string name = "";
      int oldest = 0; 
      while (true) 
      {
        string input = Console.ReadLine(); 
        if (input == "") 
        {
          break;
        }
        string[] parts = input.Split(","); 
        int age = Convert.ToInt32(parts[1]);
        
        if (age > oldest)
        {
          oldest = age;
          name = parts[0];
        }
      }
      Console.WriteLine("Name of the oldest: " + name); 


    }
  }
}



