using System;

class Book
{
    // Fields
    public string Title;
    public string Author;
    public double Price;
    public bool IsBestseller;

    // Constructor
    public Book(string title, string author, double price, bool isBestseller)
    {
        Title = title;
        Author = author;
        Price = price;
        IsBestseller = isBestseller;
    }

    // Method to calculate discounted price
    public double CalculateDiscountedPrice()
    {
        double finalPrice = Price;

        // 10% discount for bestseller
        if (IsBestseller)
        {
            finalPrice = finalPrice - (finalPrice * 0.10);
        }

        // Additional 5% discount if price > 500
        if (Price > 500)
        {
            finalPrice = finalPrice - (finalPrice * 0.05);
        }

        return finalPrice;
    }

    // Display Book Details
    public void DisplayBook()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Original Price: " + Price);
        Console.WriteLine("Discounted Price: " + CalculateDiscountedPrice());
    }
}

class Program
{
    static void Main()
    {
        Book b1 = new Book("AI Fundamentals", "John Smith", 600, true);

        b1.DisplayBook();
    }
}