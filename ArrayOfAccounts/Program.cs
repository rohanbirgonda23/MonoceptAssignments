using System;

class Program
{
    static void Main(string[] args)
    {
        Account acc1 = new Account("Rohan", 5000, "Savings");

        acc1.DisplayAccount();

        Console.WriteLine("\nDepositing 2000...");
        acc1.Deposit(2000);
        acc1.DisplayAccount();

        Console.WriteLine("\nWithdrawing 1000...");
        acc1.Withdraw(1000);
        acc1.DisplayAccount();

        Console.WriteLine("\nTrying to withdraw large amount...");
        acc1.Withdraw(6000);
        acc1.DisplayAccount();

        Console.WriteLine("\nAccount Number: " + acc1.GetAccountNumber());
        Console.WriteLine("Final Balance: " + acc1.GetBalance());
    }
}