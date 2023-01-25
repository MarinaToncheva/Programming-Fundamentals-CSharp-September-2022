﻿namespace _03._Zig_Zag_Arrays
{
    using System;
    using System.Linq;
        class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                int firstNum = numbers[0];
                int secondNum = numbers[1];

                if (i%2!=0)//Odd->1,3, ... 
                {
                    firstArray[i - 1] = firstNum;
                    secondArray[i - 1] = secondNum;
                }
                else //Even ->2, 4, 6...
                {
                    firstArray[i - 1] = secondNum;
                    secondArray[i - 1] = firstNum;
                }
            }
            Console.WriteLine(String.Join(" ", firstArray));
            Console.WriteLine(String.Join(" ", secondArray));
        }
    }
}