using System;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter product price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Func<double, double> calculateDiscount = p => p > 1000 ? p * 0.15 : p * 0.05;
            Func<double, double, double> calculateFinalPrice = (p, d) => p - d;

            double discount = calculateDiscount(price);
            double finalPrice = calculateFinalPrice(price, discount);

            Console.WriteLine("Discount: " + discount);
            Console.WriteLine("Final Price: " + finalPrice);
        }
    }
}