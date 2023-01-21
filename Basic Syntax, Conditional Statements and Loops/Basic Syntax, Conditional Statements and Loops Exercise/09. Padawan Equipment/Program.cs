using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());

            int countOfStudents = int.Parse(Console.ReadLine());
            double priceLightsabersy = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());

            double cost = 0;
            if (countOfStudents>=6)
            {
                cost = (Math.Ceiling(countOfStudents + countOfStudents * 0.1)) * priceLightsabersy + countOfStudents * priceRobes + (countOfStudents-(countOfStudents/6)) * priceBelts;
            }
            else
            {
                cost = (Math.Ceiling(countOfStudents + countOfStudents * 0.1)) * priceLightsabersy + countOfStudents * priceRobes + countOfStudents * priceBelts;
            }
            
            if (cost>amountOfMoney)
            {
                Console.WriteLine($"John will need {(cost-amountOfMoney):f2}lv more.");

            }
            else if (cost<=amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {cost:f2}lv.");
            }    
        }
    }
}
