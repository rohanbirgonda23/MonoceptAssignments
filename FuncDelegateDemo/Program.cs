using System;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter product price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            OrderCalculator calculator = new OrderCalculator();

            double discount = calculator.CalculateDiscount(price);
            double finalPrice = calculator.CalculateFinalPrice(price, discount);

            Console.WriteLine("Discount: " + discount);
            Console.WriteLine("Final Price: " + finalPrice);
        }
    }
}