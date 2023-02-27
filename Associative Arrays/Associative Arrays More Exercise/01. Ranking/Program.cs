using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            var users = new Dictionary<string, Dictionary<string, int>>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] firstInput = input
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = firstInput[0];
                string password = firstInput[1];
                contests.Add(contest, password);
            }

            string nextInput = string.Empty;
            while ((nextInput = Console.ReadLine()) != "end of submissions")
            {
                string[] secondInput = nextInput
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = secondInput[0];
                string pasword = secondInput[1];
                string username = secondInput[2];
                int points = int.Parse(secondInput[3]);

                if (contests.ContainsKey(contest))
                {
                    if (contests[contest] == pasword)
                    {
                        if (!users.ContainsKey(username))
                        {
                            users.Add(username, new Dictionary<string, int>());
                        }

                        if (!users[username].ContainsKey(contest))
                        {
                            users[username].Add(contest, points);
                        }

                        else if (users[username][contest] < points)
                        {
                            users[username][contest] = points;
                        }
                    }
                }
            }
            foreach (var candidate in users.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"Best candidate is {candidate.Key} with total {candidate.Value.Values.Sum()} points.");
                break;
            }

            Console.WriteLine("Ranking:");

            foreach (var candidate in users.OrderBy(x => x.Key))
            {
                var name = candidate.Key;

                Console.WriteLine(name);

                foreach (var course in candidate.Value.OrderByDescending(x => x.Value))
                {
                    var courseName = course.Key;
                    var points = course.Value;
                    Console.WriteLine($"#  {courseName} -> {points}");
                }
            }
        }
    }
}