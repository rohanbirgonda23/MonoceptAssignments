using System;

class Product
{
    // Fields
    public int id;
    public string name;
    public double price;
    public double discountPercentage;

    // Constructor
    public Product(int id, string name, double price, double discountPercentage)
    {
        this.id = id;
        this.name = name;
        this.price = price;
        this.discountPercentage = discountPercentage;
    }

    // Method to calculate price after discount
    public double GetPriceAfterDiscount()
    {
        double discountAmount = price * discountPercentage / 100;
        return price - discountAmount;
    }

    // Method to display product details
    public void DisplayProduct()
    {
        Console.WriteLine("Product ID: " + id);
        Console.WriteLine("Product Name: " + name);
        Console.WriteLine("Actual Price: " + price);
        Console.WriteLine("Discount Percentage: " + discountPercentage + "%");
        Console.WriteLine("Price After Discount: " + GetPriceAfterDiscount());
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        // Create two products
        Product p1 = new Product(101, "Laptop", 50000, 10);
        Product p2 = new Product(102, "Mobile", 20000, 5);

        // Display product details
        p1.DisplayProduct();
        p2.DisplayProduct();
    }
}