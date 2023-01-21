using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (age >= 0 && age <= 18)
            {
                if (dayOfWeek=="Weekday")
                {
                    Console.WriteLine("12$");
                }
                else if (dayOfWeek=="Weekend")
                {
                    Console.WriteLine("15$");
                }
                else
                {
                    Console.WriteLine("5$");
                }
            }
            else if (age > 18 && age <= 64)
            {
                if (dayOfWeek == "Weekday")
                {
                    Console.WriteLine("18$");
                }
                else if (dayOfWeek == "Weekend")
                {
                    Console.WriteLine("20$");
                }
                else
                {
                    Console.WriteLine("12$");
                }
            }
            else if (age > 64 && age <= 122)
            {
                if (dayOfWeek == "Weekday")
                {
                    Console.WriteLine("12$");
                }
                else if (dayOfWeek == "Weekend")
                {
                    Console.WriteLine("15$");
                }
                else
                {
                    Console.WriteLine("10$");
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
