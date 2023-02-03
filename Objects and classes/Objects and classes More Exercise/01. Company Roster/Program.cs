namespace _01._Company_Roster
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> people = new List<Employee>();
            List<string> departments = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();

                string[] employeeInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = employeeInfo[0];
                double salary = double.Parse(employeeInfo[1]);
                string department = employeeInfo[2];

                Employee employee = new Employee(name, salary, department);

                people.Add(employee);
                departments.Add(employee.Department);
            }

            string bestDepartment = string.Empty;
            double maxSalary = 0;

            for (int i = 0; i < people.Count; i++)
            {
                double salary = 0;
                int count = 0;

                for (int j = 0; j < departments.Count; j++)
                {
                    if (people[i].Department == departments[j])
                    {
                        salary += people[j].Salary;
                        count++;
                    }
                }

                salary /= count;

                if (salary > maxSalary)
                {
                    maxSalary = salary;
                    bestDepartment = people[i].Department;
                }
            }
            Console.WriteLine($"Highest Average Salary: {bestDepartment}");

            people = people.OrderByDescending(s => s.Salary).ToList();

            foreach (var employee in people)
            {
                if (employee.Department == bestDepartment)
                {
                    Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
                }
            }
        }
    }

    public class Employee
    {
        public Employee(string name, double salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
}
