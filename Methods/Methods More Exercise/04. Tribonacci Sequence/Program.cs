using System;
using System.Collections.Generic;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] arrayWithNumbers = new int[number];

            if (number<=4)
            {
                if (number==1)
                {
                    Console.WriteLine(1);
                }
                else if (number==2)
                {
                    Console.WriteLine($"1 1");
                }
                else if (number==3)
                {
                    Console.WriteLine("1 1 2");
                }
                else
                {
                    Console.WriteLine("1 1 2 4");
                }
            }
            else
            {
                PrintSequence(arrayWithNumbers, number);
            }
            static void PrintSequence(int[] arrayWithNumbers, int number)
            {
          
                arrayWithNumbers[0] = 1;
                arrayWithNumbers[1] = 1;
                arrayWithNumbers[2] = 2;
                arrayWithNumbers[3] = 4;

                for (int i = 4; i < arrayWithNumbers.Length; i++)
                {
                    arrayWithNumbers[i] = arrayWithNumbers[i - 3] + arrayWithNumbers[i - 2] + arrayWithNumbers[i - 1];
                }
                Console.WriteLine(string.Join(" ", arrayWithNumbers));
            }
        }
    }
}
