using System;

class Program
{
    static void Main()
    {
        UtilityOperations util = new UtilityOperations();

        int a, b;
        util.GetValues(out a, out b);
        Console.WriteLine("OUT Values: " + a + ", " + b);

        int x = 100;
        util.ShowValue(in x);

        string input = "123";
        int number;

        bool result = int.TryParse(input, out number);

        if (result)
            Console.WriteLine("TryParse Success: " + number);
        else
            Console.WriteLine("Invalid Input");

        Console.WriteLine("Sum (2 numbers): " + util.Add(10, 20));
        Console.WriteLine("Sum (4 numbers): " + util.Add(1, 2, 3, 4));
        Console.WriteLine("Sum (no args): " + util.Add());

        string name = "Rohan";
        int age = 22;

        Console.WriteLine("Name: {0}, Age: {1}", name, age);
    }
}