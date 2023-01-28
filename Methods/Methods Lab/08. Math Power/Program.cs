namespace _08._Math_Power
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            double baseNum = double.Parse(Console.ReadLine());
            int powerNum = int.Parse(Console.ReadLine());

            double result = GetRaiseToPower(baseNum, powerNum);
            Console.WriteLine(result);
            
        }
        static double GetRaiseToPower(double baseNum, int powerNum)
        {
            return Math.Pow(baseNum, powerNum);
        }
    }
}
