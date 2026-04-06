class Program
{
    static void Main()
    {
        int[] marks = new int[5];

        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Roll Number: ");
        string roll = Console.ReadLine();

        Console.WriteLine("Enter marks for 5 subjects:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Subject " + (i + 1) + ": ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        Student s = new Student(name, roll, marks);

        Console.WriteLine("\n--- Student Report ---");
        s.PrintReport();
    }
}