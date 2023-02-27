using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            //from Softuni discord - A.Vulchev

            var dragonArmy = new Dictionary<string, SortedDictionary<string, Dragon>>();
            
            int numberOfDragons = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfDragons; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();
                string type = input[0];
                string name = input[1];
                string damage = input[2];//45
                string health = input[3]; //250
                string armor = input[4]; //10

                if (!dragonArmy.ContainsKey(type))
                {
                    dragonArmy.Add(type, new SortedDictionary<string, Dragon>());
                }
                if (dragonArmy[type].ContainsKey(name))
                {
                    OverwriteStats(dragonArmy, input);
                }
                else
                {
                    dragonArmy[type].Add(name, new Dragon());
                    if (damage != "null")
                        dragonArmy[type][name].Damage = double.Parse(damage);
                    if (health != "null")
                        dragonArmy[type][name].Health = double.Parse(health);
                    if (armor != "null")
                        dragonArmy[type][name].Armor = double.Parse(armor);
                }
            }
            foreach (var dragonType in dragonArmy)
            {
                double damage = dragonType.Value.Sum(x => x.Value.Damage) / dragonType.Value.Count();
                double health = dragonType.Value.Sum(x => x.Value.Health) / dragonType.Value.Count();
                double armor = dragonType.Value.Sum(x => x.Value.Armor) / dragonType.Value.Count();

                Console.WriteLine($"{dragonType.Key}::({damage:f2}/{health:f2}/{armor:f2})");

                Console.WriteLine(String.Join("\n", dragonType.Value
                    .Select(x => $"-{x.Key} -> damage: {x.Value.Damage}, health: {x.Value.Health}, armor: {x.Value.Armor}")));
            }
        }
        static void OverwriteStats(Dictionary<string, SortedDictionary<string, Dragon>> dragonArmy, string[] input)
        {
            string type = input[0];
            string name = input[1];
            string damage = input[2];
            string health = input[3];
            string armor = input[4];

            if (damage != "null")
                dragonArmy[type][name].Damage = double.Parse(damage);
            else
                dragonArmy[type][name].Damage = 45;

            if (health != "null")
                dragonArmy[type][name].Health = double.Parse(health);
            else
                dragonArmy[type][name].Health = 250;

            if (armor != "null")
                dragonArmy[type][name].Armor = double.Parse(armor);
            else
                dragonArmy[type][name].Armor = 10;
        }
    }
    class Dragon
    {
        public double Damage { get; set; }
        public double Health { get; set; }
        public double Armor { get; set; }

        public Dragon()
        {
            Damage = 45;
            Health = 250;
            Armor = 10;
        }
    }
}
