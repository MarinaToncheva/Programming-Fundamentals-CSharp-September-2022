namespace _04._List_Operations
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputParams = input.Split();

                if (inputParams[0] == "Add")
                {
                    int value = int.Parse(inputParams[1]);
                    numbers.Add(value);
                }
                else if (inputParams[0] == "Insert")
                {
                    int numbersToInsert = int.Parse(inputParams[1]);
                    int indexToInsert = int.Parse(inputParams[2]);

                    if (indexToInsert < 0 || indexToInsert > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(indexToInsert, numbersToInsert);
                }
                else if (inputParams[0] == "Remove")
                {
                    int indexToRemove = int.Parse(inputParams[1]);

                    if (indexToRemove < 0 || indexToRemove > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(indexToRemove);
                }
                else if (inputParams[0] == "Shift")
                {
                    string leftOrRight = inputParams[1];
                    int countForMove = int.Parse(inputParams[2]);

                    if (inputParams[1] == "left")
                    {
                        for (int i = 0; i < countForMove; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                    }
                    else if (inputParams[1] == "right")
                    {

                        for (int i = 0; i < countForMove; i++)
                        {
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }
             }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}