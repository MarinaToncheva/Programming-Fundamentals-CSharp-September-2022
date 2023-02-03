using System;
using System.Collections.Generic;

namespace _03._Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            List<Car> listWithCars = new List<Car>();

            for (int i = 0; i < lines; i++)
            {
                string input =Console.ReadLine();
                string[] cmdArgs = input
                    .Split(" ");
                Car currentCar = new Car(cmdArgs[0], double.Parse(cmdArgs[1]), double.Parse(cmdArgs[2]), 0);
                listWithCars.Add(currentCar);
            }
            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(" ");
                if (command[0]=="End")
                {
                    break;
                }

                string model = command[1];
                double distance = double.Parse(command[2]);

                listWithCars
                    .Find(x => x.Model == model)
                    .Drive(distance);
            }
            Console.WriteLine(string.Join(Environment.NewLine, listWithCars));
        }
    }
    public class Car
    {
        public Car(string model, double fuel, double fuelPerKM, double distance)
        {
            this.Model = model;
            this.Fuel = fuel;
            this.FuelPerKM = fuelPerKM;
            this.Distance = 0;
        }
        public string Model { get; set; }
        public double Fuel { get; set; }
        public double FuelPerKM { get; set; }   
        public double Distance { get; set; }
        public override string ToString() => $"{Model} {Fuel:f2} {Distance}";

        public void Drive(double km)
        {
            if (FuelPerKM*km<=Fuel)
            {
                Fuel -= FuelPerKM * km;
                Distance += km;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive") ;
            }
        }
    }
}
