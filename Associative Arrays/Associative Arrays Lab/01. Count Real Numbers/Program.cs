namespace _01._Count_Real_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numberOcc = new SortedDictionary<double, int>();

            double[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (var currentNumber in inputNumbers)
            {
                if (!numberOcc.ContainsKey(currentNumber))
                {
                    numberOcc.Add(currentNumber, 0);
                }
                numberOcc[currentNumber] += 1;
            }
            foreach (var item in numberOcc)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}