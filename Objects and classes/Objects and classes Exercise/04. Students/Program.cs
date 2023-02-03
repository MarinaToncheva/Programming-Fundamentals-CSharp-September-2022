namespace _04._Students
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List <Student>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = cmdArgs[0];
                string lastName = cmdArgs[1];
                double grade = double.Parse(cmdArgs[2]);

                Student currStudent = new Student(firstName, lastName, grade);
                students.Add(currStudent);
            }

            List<Student> orderedStudents = students
                .OrderByDescending(s => s.Grade)
                .ToList();
            foreach (Student student in orderedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }

        }
    }
    public class Student
    {
        //Construcotr, Property
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirstName { get; private set; } //empty
        public string LastName { get; private set; }//empty
        public double Grade { get; private set; }//0.00

    }
}
