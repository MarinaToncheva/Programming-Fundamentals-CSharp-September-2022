namespace _05._Top_Integers
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];

                bool isTopInteger = true;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    int nextNum = numbers[j];
                    if (nextNum>=currentNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    Console.Write(currentNum + " ");
                }
            }
        }
    }
}
