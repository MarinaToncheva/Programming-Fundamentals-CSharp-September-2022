namespace _01._Train
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            int sum = 0;
            for (int i = 0; i <= numbers.Length-1; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                numbers[i] = currentNum;
                sum += currentNum;
            }
            Console.WriteLine(String.Join(" ", numbers));
            Console.WriteLine(sum);
        }
    }
}