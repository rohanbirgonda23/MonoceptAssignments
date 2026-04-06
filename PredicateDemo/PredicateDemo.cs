using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{

    class Student
    {
        public string studentName { get; set; }
        public int studentMarks { get; set; }
        public int studentAge { get; set; }

        public Student(string name, int marks, int age)
        {
            studentName = name;
            studentMarks = marks;
            studentAge = age;
        }

    }
    class Program
    {

        static void DisplayStudents(List<Student> studentCollection)
        {
            foreach (Student student in studentCollection)
            {
                Console.WriteLine($"Name: {student.studentName}, Marks: {student.studentMarks}, Age: {student.studentAge}");
            }
        }
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

           
            Predicate<Student> marksGreaterThan60 = student => student.studentMarks > 60;
            List<Student> studentsWithHighMarks = studentList.FindAll(marksGreaterThan60);

            Console.WriteLine("Students with Marks > 60:");
            DisplayStudents(studentsWithHighMarks);

    
            Predicate<Student> ageBelow18 = student => student.studentAge < 18;
            List<Student> studentsBelow18 = studentList.FindAll(ageBelow18);

            Console.WriteLine("\nStudents with Age < 18:");
            DisplayStudents(studentsBelow18);

            
            Predicate<Student> nameStartsWithA = student => student.studentName.StartsWith("A");
            List<Student> studentsStartingWithA = studentList.FindAll(nameStartsWithA);

            Console.WriteLine("\nStudents whose Name starts with 'A':");
            DisplayStudents(studentsStartingWithA);
        }
    }
}