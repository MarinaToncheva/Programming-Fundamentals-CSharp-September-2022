namespace _07._Equal_Arrays
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = Console.ReadLine()
                .Split().
                Select(int.Parse).
                ToArray();

            int sum = 0;
            for (int i = 0; i <firstArray.Length; i++)
            {
                if (firstArray[i]!=secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                else if (firstArray[i]==secondArray[i])
                {
                    int currentNumber = firstArray[i];
                    sum += currentNumber;
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
