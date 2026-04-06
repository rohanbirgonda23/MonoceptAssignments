using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student("Amit", 75, 17),
                new Student("Rohan", 55, 19),
                new Student("Anjali", 82, 16),
                new Student("Kiran", 60, 18),
                new Student("Arjun", 90, 20),
                new Student("Sneha", 45, 17)
            };

            Predicate<Student> marksGreaterThan60 = s => s.studentMarks > 60;
            var highMarks = studentList.FindAll(marksGreaterThan60);

            Console.WriteLine("Students with Marks > 60:");
            Display(highMarks);

            Predicate<Student> ageLessThan18 = s => s.studentAge < 18;
            var below18 = studentList.FindAll(ageLessThan18);

            Console.WriteLine("\nStudents with Age < 18:");
            Display(below18);

            Predicate<Student> nameStartsWithA = s => s.studentName.StartsWith("A");
            var startsWithA = studentList.FindAll(nameStartsWithA);

            Console.WriteLine("\nStudents whose Name starts with 'A':");
            Display(startsWithA);
        }

        static void Display(List<Student> students)
        {
            foreach (var s in students)
            {
                Console.WriteLine($"Name: {s.studentName}, Marks: {s.studentMarks}, Age: {s.studentAge}");
            }
        }
    }
}