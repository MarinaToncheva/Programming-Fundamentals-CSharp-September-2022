using System;
using System.Collections.Generic;

namespace _04._Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            List<Car> listWithCars = new List<Car>();

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                string[] cmdArgs = input
                    .Split(" ");
                Engine engine = new Engine();
                Cargo cargo = new Cargo();
                string model = cmdArgs[0];
                engine.Speed = int.Parse(cmdArgs[1]);
                engine.Power = int.Parse(cmdArgs[2]);
                cargo.Weight = int.Parse(cmdArgs[3]);
                cargo.Type = cmdArgs[4];
                Car currentCar = new Car(model, engine, cargo);
                listWithCars.Add(currentCar);
            }
            string command =Console.ReadLine();
            if (command == "fragile")
            {
                DisplayFragile(listWithCars);
                   
            }
            else//flamable
            {
                DisplayFlamable(listWithCars);
            }
        }
        static void DisplayFragile(List<Car> cars)
        {
            foreach (var car in cars)
            {
                if (car.Cargo.Type== "fragile" && car.Cargo.Weight < 1000)
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
        static void DisplayFlamable(List<Car> cars)
        {
            foreach (var car in cars)
            {
                if (car.Cargo.Type == "flamable" && car.Engine.Power >250)
                
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
    }
    class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
                  
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
       
    }
    class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }
    }
    class Cargo
    {
        public int Weight { get; set; }
        public string Type { get; set; }
    }