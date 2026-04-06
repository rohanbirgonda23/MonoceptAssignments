using System;

class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new Manager(1, "Rohan", 50000);
        Employee emp2 = new Developer(2, "Amit", 40000);
        Employee emp3 = new Tester(3, "Sneha", 30000);

        emp1.Display();
        emp2.Display();
        emp3.Display();
    }
}