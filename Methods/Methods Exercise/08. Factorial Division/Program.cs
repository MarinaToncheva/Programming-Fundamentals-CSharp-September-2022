namespace _08._Factorial_Division
{
    using System;
    class Program
    {
        static void Main(string[] args)
        { 
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            double factorialOne = GetFactorialDivison(firstNum);
            double factorialTwo = GetFactorialDivison(secondNum);

            double result = factorialOne / factorialTwo;

            Console.WriteLine($"{result:f2}");
 
            static double GetFactorialDivison(int num)
        {
            double factorial = 1;
            double factorialSum = 0;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i; //factorial=factorial*i;
            }
            factorialSum += factorial;
            return factorialSum;
        }
        }
    }
}
