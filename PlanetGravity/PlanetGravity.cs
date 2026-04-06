using System;

// Define enum
enum Planet
{
    MERCURY,
    VENUS,
    EARTH,
    MARS,
    JUPITER,
    SATURN,
    URANUS,
    NEPTUNE
}

class Program
{
    // Method to get gravity relative to Earth
    static double GetGravity(Planet planet)
    {
        switch (planet)
        {
            case Planet.MERCURY: return 0.38;
            case Planet.VENUS: return 0.91;
            case Planet.EARTH: return 1.00;
            case Planet.MARS: return 0.38;
            case Planet.JUPITER: return 2.34;
            case Planet.SATURN: return 1.06;
            case Planet.URANUS: return 0.92;
            case Planet.NEPTUNE: return 1.19;
            default: return 1.0;
        }
    }

    static void Main()
    {
        Console.Write("Enter your weight on Earth (kg): ");
        double earthWeight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nWeight on Different Planets:\n");

        foreach (Planet p in Enum.GetValues(typeof(Planet)))
        {
            double weightOnPlanet = earthWeight * GetGravity(p);
            Console.WriteLine($"{p} : {weightOnPlanet:F2} kg");
        }
    }
}