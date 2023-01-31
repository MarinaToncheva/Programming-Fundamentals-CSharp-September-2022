namespace _01._Train
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<int>wagons= Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            while (input!="end")
            {
                string[] inputArgs = input.Split();

                if (inputArgs[0] == "Add")
                {
                    int addedPassengers = int.Parse(inputArgs[1]);
                    wagons.Add(addedPassengers);
                }
                else
                {
                    int value = int.Parse(inputArgs[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + value <= maxCapacity)
                        {
                            wagons[i] += value;
                            break;
                        }
                    }
                }
                input =Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
