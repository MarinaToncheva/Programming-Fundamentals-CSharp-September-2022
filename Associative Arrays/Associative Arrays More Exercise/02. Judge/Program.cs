using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, Dictionary<string, int>>();
            var users = new Dictionary<string, int>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] cmdArgs = input
                    .Split(" -> ");
                string name = cmdArgs[0];
                string course = cmdArgs[1];
                int points = int.Parse(cmdArgs[2]);

                if (!students.ContainsKey(course))
                {
                    students.Add(course, new Dictionary<string, int>());
                    students[course][name] = points;
                }
                else
                {
                    if (!students[course].ContainsKey(name))
                    {
                        students[course][name] = points;
                    }
                    else
                    {
                        if (students[course][name] < points)
                        {
                            students[course][name] = points;
                        }
                    }
                }
            }

            foreach (var contest in students)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count()} participants");
                int counter = 0;
                foreach (var name in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    counter++;
                    Console.WriteLine($"{counter}. {name.Key} <::> {name.Value}");
                }
                counter = 0;
            }

            Console.WriteLine("Individual standings:");

            foreach (var contest in students)
            {
                foreach (var name in contest.Value)
                {
                    if (!users.ContainsKey(name.Key))
                    {
                        users.Add(name.Key, name.Value);
                    }
                    else
                    {
                        users[name.Key] = users[name.Key] + name.Value;
                    }
                }
            }
            int counter1 = 0;
            foreach (var name in users.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                counter1++;
                Console.WriteLine($"{counter1}. {name.Key} -> {name.Value}");
            }
        }
    }
}