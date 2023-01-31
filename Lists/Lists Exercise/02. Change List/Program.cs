namespace _02._Change_List
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

            string input =Console.ReadLine();
            while (input != "end")
            {
                string[] inputParams = input.Split();
                string command = inputParams[0];
                if (command == "Delete")
                {
                    int value = int.Parse(inputParams[1]);
                    numbers.RemoveAll(x => x == value);
                }
                else if (command == "Insert")
                {
                    int value = int.Parse(inputParams[1]);
                    int index = int.Parse(inputParams[2]);
                    numbers.Insert(index, value);
                }
                input =Console.ReadLine();
            }
            if (input=="end")
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
