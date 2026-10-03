using System;
using System.Collections.Generic;

class Person
{
    public string Name;

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
    }
}

class Student : Person
{
    public int StudentId;

    public override void DisplayInfo()
    {
        Console.WriteLine("Student - Name: " + Name + ", Student ID: " + StudentId);
    }
}

class Employee : Person
{
    public double Salary;

    public override void DisplayInfo()
    {
        Console.WriteLine("Employee - Name: " + Name + ", Salary: " + Salary);
    }
}

class Teacher : Person
{
    public string CourseName;

    public override void DisplayInfo()
    {
        Console.WriteLine("Teacher - Name: " + Name + ", Course: " + CourseName);
    }
}

class Program
{
    static void ShowPerson(Person person)
    {
        person.DisplayInfo();
    }

    static void Main()
    {
        List<Person> people = new List<Person>();

        Student student = new Student();
        student.Name = "Ahmed";
        student.StudentId = 101;

        Employee employee = new Employee();
        employee.Name = "Ali";
        employee.Salary = 5000;

        Teacher teacher = new Teacher();
        teacher.Name = "Mohammed";
        teacher.CourseName = "C# Programming";

        people.Add(student);
        people.Add(employee);
        people.Add(teacher);

        foreach (Person person in people)
        {
            person.DisplayInfo();
            Console.WriteLine("Runtime Type: " + person.GetType());
            Console.WriteLine();
        }

        ShowPerson(student);
    }
}