using System;

abstract class Course
{
    public string? CourseName;

    public Course(string name)
    {
        CourseName = name;
    }

    public abstract void Enroll();

    public virtual void Display()
    {
        
        Console.WriteLine("Course Name: " + CourseName);
    }
}

class OnlineCourse : Course
{
    private string? email;

    public OnlineCourse(string name) : base(name) { }

    public override void Enroll()
    {
        while (true)
        {
            Console.WriteLine("Enter email:");
            email = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(email) && email.Contains("@") && email.Contains("."))
            {
                Console.WriteLine("Valid Email!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid email, try again.");
            }
        }

        Console.WriteLine("Enrolled in Online Course");
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Course Type: Online");
        Console.WriteLine("Enrolled Email: " + email);
    }
}

class InPersonCourse : Course
{
    private string? studentName;

    public InPersonCourse(string name) : base(name) { }

    public override void Enroll()
    {
        while (true)
        {
            Console.WriteLine("Enter your name:");
            studentName = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(studentName))
            {
                Console.WriteLine("Enrolled in In-Person Course");
                break;
            }
            else
            {
                Console.WriteLine("Invalid name, try again.");
            }
        }
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Course Type: In-Person");
        Console.WriteLine("Student Name: " + studentName);
    }
}

class LabCourse : Course
{
    private string? rollNumber;

    public LabCourse(string name) : base(name) { }

    public override void Enroll()
    {
        while (true)
        {
            Console.WriteLine("Enter your roll number:");
            rollNumber = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(rollNumber))
            {
                Console.WriteLine("Enrolled in Lab Course");
                break;
            }
            else
            {
                Console.WriteLine("Invalid roll number, try again.");
            }
        }
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Course Type: Lab");
        Console.WriteLine("Roll Number: " + rollNumber);
    }
}

