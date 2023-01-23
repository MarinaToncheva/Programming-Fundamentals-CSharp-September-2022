namespace _02._Pounds_to_Dollars
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double result = number * 1.31;
            Console.WriteLine($"{result:f3}");
        }
    }
}
