namespace _03._House_Party
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> listWithPeople = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] inputParams = input.Split();

                if (inputParams[2] == "going!")
                {
                    if (listWithPeople.Contains(inputParams[0]))
                    {
                        Console.WriteLine($"{inputParams[0]} is already in the list!");
                    }
                    else
                    {
                        listWithPeople.Add(inputParams[0]);
                    }
                }
                else if (inputParams[2] == "not")
                {
                    if (listWithPeople.Contains(inputParams[0]))
                    {
                        listWithPeople.Remove(inputParams[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{inputParams[0]} is not in the list!");
                    }
                }
            }
            foreach (string item in listWithPeople)
            {
                Console.WriteLine(item);
            }
        }
    }
}