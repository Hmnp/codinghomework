﻿using System;
using System.Collections.Generic;

namespace exercise_86
{
  class Program
  {
    public static void Main(string[] args)
    {
       while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        string[] parted = input.Split(" ");

        for (int i = 0; i < parted.Length; i++)
        {
          Console.WriteLine(parted[i]);
        }
      }

    }
  }
}

