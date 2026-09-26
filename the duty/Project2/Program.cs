using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakodah_duty
{
    class Person
    {
        public string Name;
        public string Email;

        public Person(string name, string email)
        {
            Console.WriteLine("Person constructor executed");
            Name = name;
            Email = email;
        }

        public void DisplayBasicInfo()
        {
            Console.WriteLine($"Name: {Name}, Email: {Email}");
        }
    }

    class Student : Person
    {
        public string StudentId;
        public double GPA;

        public Student(string name, string email, string studentId, double gpa)
            : base(name, email)
        {
            Console.WriteLine("Student constructor executed");
            StudentId = studentId;
            GPA = gpa;
        }

        public void DisplayStudentInfo()
        {
            DisplayBasicInfo();
            Console.WriteLine($"StudentId: {StudentId}, GPA: {GPA}");
        }
    }

    class Employee : Person
    {
        public string EmployeeId;
        public double Salary;

        public Employee(string name, string email, string employeeId, double salary)
            : base(name, email)
        {
            Console.WriteLine("Employee constructor executed");
            EmployeeId = employeeId;
            Salary = salary;
        }

        public void DisplayEmployeeInfo()
        {
            DisplayBasicInfo();
            Console.WriteLine($"EmployeeId: {EmployeeId}, Salary: {Salary}");
        }
    }

    class Teacher : Employee
    {
        public string CourseName;

        public Teacher(string name, string email, string employeeId, double salary, string courseName)
            : base(name, email, employeeId, salary)
        {
            Console.WriteLine("Teacher constructor executed");
            CourseName = courseName;
        }

        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching {CourseName}");
        }

        public void DisplayTeacherInfo()
        {
            DisplayEmployeeInfo();
            Console.WriteLine($"Course: {CourseName}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Student Object ===");
            Student s = new Student("Ali", "ali@example.com", "S123", 3.8);
            s.DisplayStudentInfo();

            Console.WriteLine("\n=== Teacher Object ===");
            Teacher t = new Teacher("Sara", "sara@example.com", "E456", 5000, "Math");
            t.DisplayTeacherInfo();
            t.Teach();
        }
    }
}
