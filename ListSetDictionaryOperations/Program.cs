class Program
{
    static void Main()
    {
        CollectionApp app = new CollectionApp();
        while (true)
        {
            Console.WriteLine("Choose a Collection: ");
            Console.WriteLine("1.List\n2.Set\n3.Dictionary");

            Console.WriteLine("\n");

            Console.WriteLine("Enter a Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            if (choice == 1)
            {
                Console.WriteLine("You Chose List Collection");
                app.ListOperations();
                break;
            }

            else if (choice == 2)
            {
                Console.WriteLine("You Chose Set Collection");
                app.SetOperations();
                break;
            }

            else if (choice == 3)
            {
                Console.WriteLine("You Chose Dictionary Collection");
                app.DictionaryOperations();
                break;
            }
            else
            {
                Console.WriteLine("Your Choice is Invalid! Please Choose Again.");
            }
        }
    }
}