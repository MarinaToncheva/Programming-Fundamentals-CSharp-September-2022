namespace _05._Courses
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseInfo = new Dictionary<string, List<string>>();

            string command;
            while ((command=Console.ReadLine())!="end")
            {
                string[] cmdArg = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = cmdArg[0];
                string studnentName = cmdArg[1];
                if (!courseInfo.ContainsKey(courseName))
                {
                    courseInfo[courseName] = new List<string>();
                }

                courseInfo[courseName].Add(studnentName);
            }
            foreach (var kvp in courseInfo)
            {
                string courseName = kvp.Key;
                List<string> students = kvp.Value;
                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (string studentName in students )
                {
                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}
