namespace _02._A_Miner_Task
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
        
            Dictionary<string, int> pairs = new Dictionary<string, int>();

            string resource = Console.ReadLine();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (pairs.ContainsKey(resource))
                {
                    pairs[resource] += quantity;
                }
                else
                {
                    pairs[resource] = quantity;
                }

                resource =Console.ReadLine();
            }
            foreach (string key in pairs.Keys)
            {
                Console.WriteLine($"{key} -> {pairs[key]}");
            }
        }
    }
}
