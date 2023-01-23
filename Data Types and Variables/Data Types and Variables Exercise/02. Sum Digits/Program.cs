namespace _02._Sum_Digits
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberCopy = number;
            int sum = 0;
            while (numberCopy>0)
            {
                int lastDigit = numberCopy % 10;
                numberCopy = numberCopy / 10;
                sum += lastDigit;
            }
            Console.WriteLine(sum);
        }
    }
}
