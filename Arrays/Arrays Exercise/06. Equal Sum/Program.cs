namespace _06._Equal_Sum
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

            if (numbers.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                leftSum = numbers.Take(i).Sum();

                rightSum = numbers.Skip(i + 1).Sum();

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");

          // int[] numbers = Console.ReadLine()
          //     .Split()
          //     .Select(int.Parse)
          //     .ToArray();
          //
          // bool isFound = false;
          //
          // for (int i = 0; i < numbers.Length; i++)
          // {
          //     int leftSum = 0;
          //     for (int k = 0; k < i; k++)
          //     {
          //         leftSum += numbers[k];
          //     }
          //
          //     int rightSum = 0;
          //     for (int j = numbers.Length - 1; j > i; j--)
          //     {
          //         rightSum += numbers[j];
          //     }
          //
          //     if (leftSum == rightSum && !isFound)
          //     {
          //         Console.WriteLine(i);
          //         isFound = true;
          //     }
          // }
          //
          // if (!isFound)
          // {
          //     Console.WriteLine("no");
          // }
          //
        }
    }
}
