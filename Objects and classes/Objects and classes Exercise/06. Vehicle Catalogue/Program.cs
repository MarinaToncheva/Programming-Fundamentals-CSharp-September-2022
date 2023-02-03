namespace _06._Vehicle_Catalogue
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> cars = new List<Vehicle>();
            List<Vehicle> trucks = new List<Vehicle>();

            JoinVehicle(cars, trucks);
            PrintVehicle(cars, trucks);
            PrintAvgHP(cars, trucks);

        }
        static void JoinVehicle(List<Vehicle> cars, List<Vehicle> trucks)
        {
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] vehicleInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string vehicleType = vehicleInfo[0];
                string model = vehicleInfo[1];
                string color = vehicleInfo[2];
                int value = int.Parse(vehicleInfo[3]);

                if (vehicleType == "truck")
                {
                    Vehicle newTruck = new Vehicle(vehicleType, model, color, value);
                    trucks.Add(newTruck);
                }
                else
                {
                    Vehicle newCar = new Vehicle(vehicleType, model, color, value);
                    cars.Add(newCar);
                }
            }
        }
        static void PrintVehicle(List<Vehicle> cars, List<Vehicle> trucks)
        {
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Close the Catalogue")
                {
                    break;
                }
                {
                    var carsToPrint = cars
                        .Where(x => x.Model == command);
                    var trucksToPrint = trucks
                        .Where(x => x.Model == command);
                    foreach (var veh in cars)
                    {
                        if (veh.Model == command)
                        {
                            foreach (var car in carsToPrint)
                            {
                                Console.WriteLine($"Type: Car" +
                                     $"\nModel: {car.Model}" +
                                     $"\nColor: {car.Color}" +
                                     $"\nHorsepower: {car.HorsePower}");
                            }
                        }
                    }
                    foreach (var veh in trucks)
                    {
                        if (veh.Model == command)
                        {
                            foreach (var truck in trucksToPrint)
                            {
                                Console.WriteLine($"Type: Truck" +
                                     $"\nModel: {truck.Model}" +
                                     $"\nColor: {truck.Color}" +
                                     $"\nHorsepower: {truck.HorsePower}");
                            }
                        }
                    }
                }
            }
        }
        static void PrintAvgHP(List<Vehicle> cars, List<Vehicle> trucks)
        {
            double avgHorsePowerCars = 0;
            int carsCount = 0;
            foreach (var car in cars)
            {
                avgHorsePowerCars += car.HorsePower;
                carsCount++;
            }
            avgHorsePowerCars /= carsCount;
            if (cars.Count == 0)
            {
                avgHorsePowerCars = 0.00;
            }
            Console.WriteLine($"Cars have average horsepower of: {avgHorsePowerCars:f2}.");

            double avgHorsePowerTrucks = 0;
            int trucksCount = 0;
            foreach (var truck in trucks)
            {
                avgHorsePowerTrucks += truck.HorsePower;
                trucksCount++;
            }
            avgHorsePowerTrucks /= trucksCount;
            if (trucks.Count == 0)
            {
                avgHorsePowerTrucks = 0.00;
            }
            Console.WriteLine($"Trucks have average horsepower of: {avgHorsePowerTrucks:f2}.");
        }

        public class Vehicle
        {
            public Vehicle(string type, string model, string color, int horsePower)
            {
                Type = type;
                Model = model;
                Color = color;
                HorsePower = horsePower;
            }
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }
        }
    }
}