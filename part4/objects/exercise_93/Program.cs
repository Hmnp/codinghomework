using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
       Account hasanAccount = new Account("Hasan's account", 100.0);
      
      hasanAccount.Deposit(20);

      Console.WriteLine(hasanAccount.balance);
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!

    }
  }
}



