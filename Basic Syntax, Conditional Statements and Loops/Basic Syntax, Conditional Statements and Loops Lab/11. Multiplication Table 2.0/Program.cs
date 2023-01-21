using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int startNumber = int.Parse(Console.ReadLine());

            if (startNumber <= 10)
            {
                for (int i = startNumber; i <= 10; i++)
                {
                    Console.WriteLine($"{number} X {i} = {number * i}");
                }
            }
            else
            {
                Console.WriteLine($"{number} X {startNumber} = {number * startNumber}");
            }
        }
    }
}
