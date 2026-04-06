using System;

class Student
{
    // Fields
    private string studentName;
    private string rollNumber;
    private int[] marks = new int[5];

    // Constructor
    public Student(string name, string roll, int[] m)
    {
        studentName = name;
        rollNumber = roll;

        for (int i = 0; i < 5; i++)
        {
            marks[i] = m[i];
        }
    }

    // Method to calculate average
    public double CalculateAverage()
    {
        int sum = 0;

        for (int i = 0; i < 5; i++)
        {
            sum += marks[i];
        }

        return sum / 5.0;
    }

    // Method to calculate grade
    public string CalculateGrade()
    {
        double avg = CalculateAverage();

        if (avg >= 90 && avg <= 10) return "Grade A+";
        else if (avg >= 80) return "Grade A";
        else if (avg >= 70) return "Grade B";
        else if (avg >= 60) return "Grade C";
        else if (avg >= 50) return "Grade D";
        else return "Fail";
    }

    // Method to print student report
    public void PrintReport()
    {
        Console.WriteLine("Student Name : " + studentName);
        Console.WriteLine("Roll Number  : " + rollNumber);

        Console.WriteLine("Marks in 5 Subjects:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Subject " + (i + 1) + ": " + marks[i]);
        }

        Console.WriteLine("Average Marks: " + CalculateAverage());
        Console.WriteLine("Grade        : " + CalculateGrade());
    }
}

