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

class Program
{
    static void Main()
    {
        Account acc = null;
        int choice;

        do
        {
            Console.WriteLine("\n----- BANK MENU -----");
            Console.WriteLine("1. Create an Account");
            Console.WriteLine("2. View Balance");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Withdraw");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Initial Balance: ");
                    double bal = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter Account Type (Savings/Current): ");
                    string type = Console.ReadLine();

                    acc = new Account(name, bal, type);

                    Console.WriteLine("Account Created Successfully!");
                    Console.WriteLine("Your Account Number: " + acc.GetAccountNumber());
                    break;

                case 2:
                    if (acc != null)
                        Console.WriteLine("Current Balance: " + acc.GetBalance());
                    else
                        Console.WriteLine("Create an account first.");
                    break;

                case 3:
                    if (acc != null)
                    {
                        Console.Write("Enter amount to deposit: ");
                        double dep = Convert.ToDouble(Console.ReadLine());
                        acc.Deposit(dep);
                    }
                    else
                        Console.WriteLine("Create an account first.");
                    break;

                case 4:
                    if (acc != null)
                    {
                        Console.Write("Enter amount to withdraw: ");
                        double wit = Convert.ToDouble(Console.ReadLine());
                        acc.Withdraw(wit);
                    }
                    else
                        Console.WriteLine("Create an account first.");
                    break;

                case 5:
                    Console.WriteLine("Thank you for using the banking system.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 5);
    }
}