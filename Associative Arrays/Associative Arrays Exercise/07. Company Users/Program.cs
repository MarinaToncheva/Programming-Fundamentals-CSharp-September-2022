namespace _07._Company_Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArg = command
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = cmdArg[0];
                string employeesId = cmdArg[1];

                if (!users.ContainsKey(companyName))
                {
                    users[companyName] = new List<string>();
                }
               if (!users[companyName].Contains(employeesId))
                {
                    users[companyName].Add(employeesId);
                }
            }
            foreach (var name in users)
            {
                Console.WriteLine(name.Key);

                foreach (var employeesId in name.Value)
                {
                    Console.WriteLine($"-- {employeesId}");
                }
            }
        }
    }
}
