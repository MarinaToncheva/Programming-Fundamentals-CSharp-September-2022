namespace _10._Top_Number
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= endNum; i++)
            {
                if (HasOddDigit(i)&&IsDigitSumDivisibleByEight(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool HasOddDigit(int endNum)
        {
            while (endNum>0)
            {
                if ((endNum % 10) % 2 == 1)
                {
                    return true;
                }
                endNum /= 10;
            }
            return false;
        }

        static bool IsDigitSumDivisibleByEight(int endNum)
        {
            int digitSum = 0;
            while (endNum>0)
            {
                digitSum += endNum % 10;
                endNum /= 10;
            }
            if (digitSum%8==0)
            {
                return true;
            }
            return false;
        }
    }
}
