﻿namespace _02._Pascal_Triangle
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            //Solution from Softuni forum
            int rows = int.Parse(Console.ReadLine());

            int[] currentArray = { 1 };
            for (int row = 1; row < rows; row++)
            {
                int[] nextArray = new int[currentArray.Length + 1];

                for (int i = 0; i < currentArray.Length; i++)
                {
                    nextArray[i] += currentArray[i];
                    nextArray[i + 1] += currentArray[i];
                }
                Console.WriteLine(string.Join(' ', currentArray));
                currentArray = nextArray;
            }
            Console.WriteLine(string.Join(' ', currentArray));
        }
    }
}
