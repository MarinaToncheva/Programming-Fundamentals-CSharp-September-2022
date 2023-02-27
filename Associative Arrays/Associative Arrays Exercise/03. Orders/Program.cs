namespace _03._Orders
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> orders = new Dictionary<string, List<double>> ();

            string command;
            while ((command=Console.ReadLine()) != "buy")
            {
                if (command=="buy")
                {
                    break;
                }
                string[] cmdArg = command
                    .Split(" ");
                string product = cmdArg[0];
                double price = double.Parse(cmdArg[1]);
                double quantity = double.Parse(cmdArg[2]);

                if (!orders.ContainsKey(product))
                {
                    orders[product] = new List<double>() { price, quantity };
                }
                else
                {
                    orders[product][0] = price;
                    orders[product][1] += quantity;
                }
            }
            foreach (var product in orders)
            {
                Console.WriteLine($"{product.Key} -> {(product.Value[0] * product.Value[1]):f2}");
            }
        }
    }
}