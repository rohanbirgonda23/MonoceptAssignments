using System;

// Abstract base class (cannot be created directly)
abstract class Course
{
    protected string courseTitle;
    protected int maxStudents;
    protected int currentStudents;

    public Course(string title, int limit)
    {
        courseTitle = title;
        maxStudents = limit;
        currentStudents = 0;
    }

    // Abstract method
    public abstract void Enroll(string studentName);
}

// Online Course
class OnlineCourse : Course
{
    public OnlineCourse(string title, int limit) : base(title, limit) { }

    public override void Enroll(string studentName)
    {
        if (currentStudents < maxStudents)
        {
            currentStudents++;
            Console.WriteLine(studentName + " joined the online course: " + courseTitle);
        }
        else
        {
            Console.WriteLine("Cannot enroll. Online course is full.");
        }
    }
}

// In-Person Course
class ClassroomCourse : Course
{
    private string room;

    public ClassroomCourse(string title, int limit, string roomNo) : base(title, limit)
    {
        room = roomNo;
    }

    public override void Enroll(string studentName)
    {
        if (currentStudents < maxStudents)
        {
            currentStudents++;
            Console.WriteLine(studentName + " enrolled in classroom course: " + courseTitle + " (Room " + room + ")");
        }
        else
        {
            Console.WriteLine("Classroom is already full.");
        }
    }
}

// Lab Course
class LabCourse : Course
{
    public LabCourse(string title, int limit) : base(title, limit) { }

    public override void Enroll(string studentName)
    {
        Console.Write("Did " + studentName + " complete lab safety training? (yes/no): ");
        string answer = Console.ReadLine();

        if (answer.ToLower() == "yes")
        {
            if (currentStudents < maxStudents)
            {
                currentStudents++;
                Console.WriteLine(studentName + " enrolled in lab course: " + courseTitle);
            }
            else
            {
                Console.WriteLine("Lab seats are full.");
            }
        }
        else
        {
            Console.WriteLine("Enrollment denied. Safety training required.");
        }
    }
}

// Main Program
class Program
{
    static void Main()
    {
        Course c1 = new OnlineCourse("Intro to AI", 2);
        Course c2 = new ClassroomCourse("Data Structures", 2, "A101");
        Course c3 = new LabCourse("Electronics Lab", 2);

        Console.WriteLine("\n--- University Course Enrollment ---\n");

        c1.Enroll("Rahul");
        c1.Enroll("Sneha");
        c1.Enroll("Arjun");

        Console.WriteLine();

        c2.Enroll("Kiran");
        c2.Enroll("Meera");

        Console.WriteLine();

        c3.Enroll("Ravi");
    }
}