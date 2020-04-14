using System;

namespace exercise_94
{
  class Program
  {
    public static void Main(string[] args)
    {
      Account HeikkisAccount = new Account ("Heikki's account", 1000.00);
      Account personalAccount = new Account ("Personal account", 0);

      HeikkisAccount.Withdrawal(100.00);
      personalAccount.Deposit(100.00);

      Console.WriteLine(HeikkisAccount);
      Console.WriteLine(personalAccount);

           // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!

    }
  }
}



