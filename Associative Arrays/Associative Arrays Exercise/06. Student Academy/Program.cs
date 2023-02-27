namespace _06._Student_Academy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name =Console.ReadLine();
                double grade =double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<double>();
                }
                students[name].Add(grade);
            }

            foreach (var student in students)
            {
                if (student.Value.Average()>=4.50)
                {
                    Console.WriteLine("{0} -> {1:f2}", student.Key, student.Value.Average());
                }
            }
        }
    }
}
