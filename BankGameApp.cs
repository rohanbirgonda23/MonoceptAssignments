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

class Program
{
    static void Main()
    {
        Random rand = new Random();

        // Create accounts with random starting balance
        BankAccount acc1 = new BankAccount("Alice", rand.Next(500, 1001));
        BankAccount acc2 = new BankAccount("Bob", rand.Next(500, 1001));

        Console.WriteLine("Starting Balances:");
        acc1.DisplayBalance();
        acc2.DisplayBalance();
        Console.WriteLine();

        // 3 rounds
        for (int round = 1; round <= 3; round++)
        {
            Console.WriteLine("---- Round " + round + " ----");

            // Account 1 turn
            Console.WriteLine("\n" + acc1.AccountHolder + "'s Turn");
            Console.Write("Enter amount to deposit: ");
            double dep1 = Convert.ToDouble(Console.ReadLine());
            acc1.Deposit(dep1);

            Console.Write("Enter amount to withdraw: ");
            double wit1 = Convert.ToDouble(Console.ReadLine());
            acc1.Withdraw(wit1);

            acc1.DisplayBalance();

            // Account 2 turn
            Console.WriteLine("\n" + acc2.AccountHolder + "'s Turn");
            Console.Write("Enter amount to deposit: ");
            double dep2 = Convert.ToDouble(Console.ReadLine());
            acc2.Deposit(dep2);

            Console.Write("Enter amount to withdraw: ");
            double wit2 = Convert.ToDouble(Console.ReadLine());
            acc2.Withdraw(wit2);

            acc2.DisplayBalance();

            Console.WriteLine();
        }

        // Determine Winner
        Console.WriteLine("---- Final Result ----");

        if (acc1.Balance > acc2.Balance)
        {
            Console.WriteLine(acc1.AccountHolder + " wins with balance " + acc1.Balance);
        }
        else if (acc2.Balance > acc1.Balance)
        {
            Console.WriteLine(acc2.AccountHolder + " wins with balance " + acc2.Balance);
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }
    }
}