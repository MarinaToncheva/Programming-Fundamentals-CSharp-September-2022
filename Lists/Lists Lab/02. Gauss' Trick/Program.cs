namespace _02._Gauss__Trick
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            //1 2 3 4 5 - 2 операции + 1 среден елемент - нечетни случаи
            //Прави се сметка, че винаги цикълът ще е с двойно по-малко операции
            //1 2 3 4 - 2 операции - четни случаи

            for (int i = 0; i < numbers.Count/2; i++)
            {
                int currentSum = numbers[i] + numbers[numbers.Count - 1-i];
               
                result.Add(currentSum);
            }
            if (numbers.Count%2!=0)
            {
                result.Add(numbers[numbers.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
