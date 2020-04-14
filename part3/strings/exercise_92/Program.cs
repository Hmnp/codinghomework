using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
      string name = "";
      int longest = 0;
      int highest = 0;
      while (true) 
      {
        string input = Console.ReadLine(); 
        if (input == "") 
        {
          break;
        }
        string[] parts = input.Split(","); 
        int length = input.Length;
        int age = 2020 - Convert.ToInt32(parts[1]);
        if (length > longest) 
        {
          longest = length;
          name = parts[0];
        }
        if (age > highest) 
        {
          highest = age;
        }
      }
      Console.WriteLine("Longest name: " + name); 
      Console.WriteLine("Highest age: " + highest);   

    }
  }
}



