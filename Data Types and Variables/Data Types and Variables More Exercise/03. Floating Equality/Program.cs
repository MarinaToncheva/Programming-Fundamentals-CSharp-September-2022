namespace _03._Floating_Equality
{
    using System;
        class Program
    {
        static void Main(string[] args)
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());
            decimal constant = 0.000001m;
            if (Math.Abs(firstNumber-secondNumber)<constant)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
