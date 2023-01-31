using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double timeOfTheLeftCar = 0;
            double timeOfTheRightCar = 0;

            int length = numbers.Count / 2;
            for (int i = 0; i < length; i++)
            {
                int currentTime = numbers[i];
                if (currentTime==0)
                {
                    timeOfTheLeftCar = timeOfTheLeftCar * 0.80;
                }
                else
                {
                    timeOfTheLeftCar += currentTime;
                }
            }
            for (int j = numbers.Count-1; j > length; j--)
            {
                int currentTime = numbers[j];
                if (currentTime == 0)
                {
                    timeOfTheRightCar =timeOfTheRightCar * 0.8;
                }
                else
                {
                    timeOfTheRightCar += currentTime;
                }
            }
            if (timeOfTheLeftCar<timeOfTheRightCar)
            {
                Console.WriteLine($"The winner is left with total time: {timeOfTheLeftCar}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {timeOfTheRightCar}");
            }
        }
    }
}
