using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOddNumbers = int.Parse(Console.ReadLine());
            int sum = 0;
            int startNumber = 1;

            while (numberOfOddNumbers>0)
            {
                Console.WriteLine(startNumber);
                sum += startNumber;
                startNumber += 2;
                numberOfOddNumbers--;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
