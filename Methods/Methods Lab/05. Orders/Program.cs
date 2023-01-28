namespace _05._Orders
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string product =Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            
            switch (product)
            {
                
                case "coffee":
                   Coffee(quantity);
                    break;
                case "water":
                    Water(quantity);
                    break;
                case "coke":
                    Coke(quantity);
                    break;
                default:
                    Snacks(quantity);
                    break;
            }
            static void Coffee(int quantity)
            {
                double result = 1.50 * quantity;
                Console.WriteLine($"{result:f2}");
            }
            static void Water(int quantity)
            {
                double result = 1.00 * quantity;
                Console.WriteLine($"{result:f2}");
            }
            static void Coke(int quantity)
            {
                double result = 1.40 * quantity;
                Console.WriteLine($"{result:f2}");
            }
            static void Snacks(int quantity)
            {
                double result = 2.00 * quantity;
                Console.WriteLine($"{result:f2}");
            }

        }
    }
}

