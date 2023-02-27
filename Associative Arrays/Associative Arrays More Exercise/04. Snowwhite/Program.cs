using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            //from Softuni forum
            var dwarfs = new Dictionary<string, int>();

            string input = Console.ReadLine();
            while (input != "Once upon a time")
            {
                string[] inputs = input.Split(new string[] { " <:> " }, StringSplitOptions.None);
                string name = inputs[0];
                string color = inputs[1];
                int physics = int.Parse(inputs[2]);

                string ID = name + ":" + color;
                if (!dwarfs.ContainsKey(ID))
                {
                    dwarfs.Add(ID, physics);
                }
                else
                {
                    dwarfs[ID] = Math.Max(dwarfs[ID], physics);
                }

                input = Console.ReadLine();
            }

            foreach (var dwarf in dwarfs
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x => dwarfs.Where(y => y.Key.Split(':')[1] == x.Key.Split(':')[1])
                                             .Count()))
            {
                Console.WriteLine("({0}) {1} <-> {2}",
                    dwarf.Key.Split(':')[1],
                    dwarf.Key.Split(':')[0],
                    dwarf.Value);
            }
        }
    }
}
//class Dwarf
//{
//    public string Name { get; set; }

//    public string HatColor { get; set; }

//    public int Physics { get; set; }

//    public Dwarf(string name, string hat, int physics)
//    {
//        Name = name;
//        HatColor = hat;
//        Physics = physics;
//    }
//}

//static void Main()
//{
//    List<Dwarf> dwarves = new List<Dwarf>();
//    Dictionary<string, int> hats = new Dictionary<string, int>();
//    string input;
//    while ((input = Console.ReadLine()) != "Once upon a time")
//    {
//        string[] tokens = input.Split(new string[] { " <:> " }, StringSplitOptions.None);
//        string name = tokens[0];
//        string hat = tokens[1];
//        int physics = int.Parse(tokens[2]);

//        if (!dwarves.Any(x => x.HatColor == hat && x.Name == name))
//        {
//            dwarves.Add(new Dwarf(name, hat, physics));
//            if (!hats.ContainsKey(hat))
//                hats.Add(hat, 0);
//            hats[hat]++;
//        }

//        int hatIndex = dwarves.FindIndex(x => x.HatColor == hat && x.Name == name);

//        if (dwarves[hatIndex].Name == name)
//        {
//            if (dwarves[hatIndex].Physics < physics)
//                dwarves[hatIndex].Physics = physics;
//        }
//    }

//    foreach (Dwarf dwarf in dwarves
//        .OrderByDescending(x => x.Physics)
//        .ThenByDescending(x => hats[x.HatColor]))
//        Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
//}
//}