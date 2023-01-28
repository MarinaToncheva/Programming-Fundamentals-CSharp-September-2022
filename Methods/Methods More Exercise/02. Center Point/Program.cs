using System;

namespace _02._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstX = double.Parse(Console.ReadLine());
            double firstY = double.Parse(Console.ReadLine());
            double secondX = double.Parse(Console.ReadLine());
            double secondy = double.Parse(Console.ReadLine());

            PrintNearestCoordinates(firstX, firstY, secondX, secondy);

            static void PrintNearestCoordinates(double x1, double y1, double x2, double y2)
            {
                double firstDiagonal = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
                double secondDiagonal = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

                if (firstDiagonal < secondDiagonal)
                {
                    Console.WriteLine($"({x1}, {y1})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})");
                }
            }
        }
    }
}