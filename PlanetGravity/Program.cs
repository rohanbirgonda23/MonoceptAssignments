using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your weight on Earth (kg): ");
        double earthWeight = Convert.ToDouble(Console.ReadLine());

        PlanetCalculator calculator = new PlanetCalculator();
        calculator.DisplayWeights(earthWeight);
    }
}