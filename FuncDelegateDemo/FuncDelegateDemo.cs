using System;

namespace OrderSystem
{
    class OrderCalculator
    {
        public double CalculateDiscount(double price)
        {
            Func<double, double> calculateDiscount = p => p > 1000 ? p * 0.15 : p * 0.05;
            return calculateDiscount(price);
        }

        public double CalculateFinalPrice(double price, double discount)
        {
            Func<double, double, double> calculateFinalPrice = (p, d) => p - d;
            return calculateFinalPrice(price, discount);
        }
    }
}