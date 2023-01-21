using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;

            switch (dayOfWeek)
            {
                case "Friday":
                    if (type=="Students")
                    {
                        if (people>=30)
                        {
                            price = people * 8.45 - (people * 8.45) * 0.15;
                        }
                        else
                        {
                            price = people * 8.45;
                        }
                    }
                    else if (type=="Business")
                    {
                        if (people>=100)
                        {
                            price = (people-10) * 10.90;
                        }
                        else
                        {
                            price = people * 10.90;
                        }
                    }
                    else
                    {
                        if (people>=10 && people<=20)
                        {
                            price = people * 15 - (people * 15) * 0.05;
                        }
                        else
                        {
                            price = people * 15;
                        }
                    }
                    Console.WriteLine($"Total price: {price:f2}");
                    break;
                case "Saturday":
                    if (type == "Students")
                    {
                        if (people >= 30)
                        {
                            price = people * 9.80 - (people * 9.80) * 0.15;
                        }
                        else
                        {
                            price = people * 9.80;
                        }
                    }
                    else if (type == "Business")
                    {
                        if (people >= 100)
                        {
                            price = (people - 10) * 15.60;
                        }
                        else
                        {
                            price = people * 15.60;
                        }
                    }
                    else
                    {
                        if (people >= 10 && people <= 20)
                        {
                            price = people * 20 - (people * 20) * 0.05;
                        }
                        else
                        {
                            price = people * 20;
                        }
                    }
                    Console.WriteLine($"Total price: {price:f2}");
                    break;
                default: //Sunday
                    if (type == "Students")
                    {
                        if (people >= 30)
                        {
                            price = people * 10.46 - (people * 10.46) * 0.15;
                        }
                        else
                        {
                            price = people * 10.46;
                        }
                    }
                    else if (type == "Business")
                    {
                        if (people >= 100)
                        {
                            price = (people - 10) * 16;
                        }
                        else
                        {
                            price = people * 16;
                        }
                    }
                    else
                    {
                        if (people >= 10 && people <= 20)
                        {
                            price = people * 22.50 - (people * 22.50) * 0.05;
                        }
                        else
                        {
                            price = people * 22.50;
                        }
                    }
                    Console.WriteLine($"Total price: {price:f2}");
                    break;
            }
        }
    }
}
