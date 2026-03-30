using System;

// Base Class
class Employee
{
    public int Id;
    public string Name;
    public double BasicSalary;

    public Employee(int id, string name, double basic)
    {
        Id = id;
        Name = name;
        BasicSalary = basic;
    }

    // Polymorphic method
    public virtual double CalculateSalary()
    {
        return BasicSalary;
    }

    public void Display()
    {
        double monthlySalary = CalculateSalary();
        double annualCTC = monthlySalary * 12;

        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Basic Salary: " + BasicSalary);
        Console.WriteLine("Total Monthly Salary: " + monthlySalary);
        Console.WriteLine("Annual CTC: " + annualCTC);
        Console.WriteLine("---------------------------");
    }
}

// Manager Class
class Manager : Employee
{
    public Manager(int id, string name, double basic) : base(id, name, basic) { }

    public override double CalculateSalary()
    {
        double ta = 0.5 * BasicSalary;   // 50%
        double da = 0.4 * BasicSalary;   // 40%

        return BasicSalary + ta + da;
    }
}

// Developer Class
class Developer : Employee
{
    public Developer(int id, string name, double basic) : base(id, name, basic) { }

    public override double CalculateSalary()
    {
        double pa = 0.4 * BasicSalary;   // 40%

        return BasicSalary + pa;
    }
}

// Tester Class
class Tester : Employee
{
    public Tester(int id, string name, double basic) : base(id, name, basic) { }

    public override double CalculateSalary()
    {
        double perks = 0.3 * BasicSalary;   // 30%

        return BasicSalary + perks;
    }
}

// Main Program
class Program
{
    static void Main()
    {
        // Polymorphism (same reference, different objects)
        Employee e1 = new Manager(1, "Rohan", 50000);
        Employee e2 = new Developer(2, "Amit", 40000);
        Employee e3 = new Tester(3, "Neha", 30000);

        e1.Display();
        e2.Display();
        e3.Display();
    }
}