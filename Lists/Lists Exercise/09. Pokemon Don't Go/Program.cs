namespace _09._Pokemon_Don_t_Go
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int sum = 0;
            int currSum = 0;
            while (numbers.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    currSum += numbers[0];
                    sum += currSum;
                    numbers[0] = numbers[numbers.Count - 1];

                    IncreaseAndDecreaseElements(numbers, currSum);
                    currSum = 0;
                }
                else if (index >= numbers.Count)
                {
                    currSum += numbers[numbers.Count - 1];
                    sum += currSum;
                    numbers[numbers.Count - 1] = numbers[0];

                    IncreaseAndDecreaseElements(numbers, currSum);
                    currSum = 0;
                }
                else
                {
                    int currentNum = numbers[index];
                    sum += currentNum;
                    numbers.RemoveAt(index);

                    IncreaseAndDecreaseElements(numbers, currentNum);
                }
            }
            Console.WriteLine(sum);
        }

        private static void IncreaseAndDecreaseElements(List<int> numbers, int currSum)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > currSum)
                {
                    numbers[i] -= currSum;
                }
                else if (numbers[i] <= currSum)
                {
                    numbers[i] += currSum;
                }
            }
        }
    }
}
                     