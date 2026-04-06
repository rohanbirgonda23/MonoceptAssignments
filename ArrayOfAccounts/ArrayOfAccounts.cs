using System;

class Account
{
    private string accountNumber;
    private string name;
    private double balance;
    private string accountType;

    // Constructor
    public Account(string name, double balance, string accountType)
    {
        this.accountNumber = GenerateAccountNumber();
        this.name = name;
        this.balance = balance;
        this.accountType = accountType;
    }

    // Random Account Number Generator
    private string GenerateAccountNumber()
    {
        Random r = new Random();
        return "IDBI1000" + r.Next(100000, 999999);
    }

    // Getters
    public string GetAccountNumber()
    {
        return accountNumber;
    }

    public double GetBalance()
    {
        return balance;
    }

    // Deposit Method
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Amount deposited successfully.");
        }
        else
        {
            Console.WriteLine("Invalid amount.");
        }
    }

    // Withdraw Method with minimum balance check
    public void Withdraw(double amount)
    {
        if (balance - amount < 500)
        {
            Console.WriteLine("Withdrawal failed. Minimum balance of 500 must be maintained.");
        }
        else
        {
            balance -= amount;
            Console.WriteLine("Withdrawal successful.");
        }
    }

    // Display Account Details
    public void DisplayAccount()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Account Type: " + accountType);
        Console.WriteLine("Balance: " + balance);
    }
}

