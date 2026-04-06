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
    
}