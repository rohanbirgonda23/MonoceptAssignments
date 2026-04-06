using System;

class BankAccount
{
    // Properties
    public string AccountHolder { get; set; }
    public double Balance { get; set; }

    // Constructor
    public BankAccount(string name, double balance)
    {
        AccountHolder = name;
        Balance = balance;
    }

    // Deposit Method
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine(AccountHolder + " deposited " + amount);
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    // Withdraw Method
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
        else if (amount > Balance)
        {
            Console.WriteLine(AccountHolder + " has insufficient balance.");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine(AccountHolder + " withdrew " + amount);
        }
    }

    // Display Balance
    public void DisplayBalance()
    {
        Console.WriteLine(AccountHolder + " Balance: " + Balance);
    }
}

