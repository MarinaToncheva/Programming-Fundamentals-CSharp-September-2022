using System;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstX = double.Parse(Console.ReadLine());
            double firstY = double.Parse(Console.ReadLine());
            double secondX = double.Parse(Console.ReadLine());
            double secondy = double.Parse(Console.ReadLine());

            double thirdX = double.Parse(Console.ReadLine());
            double thirdY = double.Parse(Console.ReadLine());
            double fourthX = double.Parse(Console.ReadLine());
            double fourthY = double.Parse(Console.ReadLine());

            FindTheLongerLine(firstX, firstY, secondX, secondy, thirdX, thirdY, fourthX, fourthY);

            static void FindTheLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
            {
                double firstLine= Math.Sqrt(Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2));
                double secondLine = Math.Sqrt(Math.Pow(Math.Abs(x3 - x4), 2) + Math.Pow(Math.Abs(y3 - y4), 2));

                if (firstLine>=secondLine)
                {
                    CloserToZero(x1, y1, x2, y2);
                }
                else
                {
                    CloserToZero(x3, y3, x4, y4);
                }
            }
            static void CloserToZero(double x1, double y1, double x2, double y2)
            {
               double firstDiagonal = Math.Sqrt(Math.Pow(Math.Abs(x1), 2) + Math.Pow(Math.Abs(y1), 2));
               double secondDiagonal = Math.Sqrt(Math.Pow(Math.Abs(x2), 2) + Math.Pow(Math.Abs(y2), 2));

                if (firstDiagonal > secondDiagonal)
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
                else
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
            }
        }
    }
}
