using System;

class Program
{
    static void GetValues(out int x, out int y)
    {
        x = 10;
        y = 20;
    }

    static void ShowValue(in int num)
    {
        Console.WriteLine("IN Value: " + num);
    }

    static int Add(params int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        return sum;
    }

    static void Main()
    {
        int a, b;
        GetValues(out a, out b);
        Console.WriteLine("OUT Values: " + a + ", " + b);

        int x = 100;
        ShowValue(in x);

        string input = "123";
        int number;

        bool result = int.TryParse(input, out number);

        if (result)
            Console.WriteLine("TryParse Success: " + number);
        else
            Console.WriteLine("Invalid Input");

        Console.WriteLine("Sum (2 numbers): " + Add(10, 20));
        Console.WriteLine("Sum (4 numbers): " + Add(1, 2, 3, 4));
        Console.WriteLine("Sum (no args): " + Add());

        string name = "Rohan";
        int age = 22;

        Console.WriteLine("Name: {0}, Age: {1}", name, age);
    }
}