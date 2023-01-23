namespace _07._Water_Overflow
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfPouring = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= numbersOfPouring; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                sum += liters;
                int currentPour = sum -liters ;
                if (sum>255)
                {
                    Console.WriteLine($"Insufficient capacity!");
                    sum = currentPour;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
