namespace _09._Spice_Must_Flow
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int copyStartingYield = startingYield;
            int spicesPerDay = 26;
            int daysCount = 0;
            int leftYield = 0;
            int leftSpices = 0;
            int sumSpices = 0;

            if (startingYield >= 100)
            {
                while (copyStartingYield >= 100)
                {
                    leftYield = copyStartingYield - 10;
                    leftSpices = copyStartingYield - spicesPerDay;
                    daysCount++;
                    copyStartingYield = leftYield;
                    sumSpices += leftSpices;

                }
                Console.WriteLine(daysCount);
                Console.WriteLine($"{sumSpices - spicesPerDay}");
            }
            else
            {
                Console.WriteLine(daysCount);
                Console.WriteLine(leftYield);
            }
        }
    }
}
