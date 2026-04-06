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