using  System;
class Program
{
    static void Main()
    {
        Course c1 = new OnlineCourse("Programming in C#");
        Course c2 = new InPersonCourse("Java FullStack");
        Course c3 = new LabCourse("Physics Lab");

        c1.Enroll();
        Console.WriteLine();

        c2.Enroll();
        Console.WriteLine();

        c3.Enroll();
        Console.WriteLine();

        Console.WriteLine("\nCourse Details are as follows:\n");

        c1.Display();
        Console.WriteLine();

        c2.Display();
        Console.WriteLine();

        c3.Display();
    }
}