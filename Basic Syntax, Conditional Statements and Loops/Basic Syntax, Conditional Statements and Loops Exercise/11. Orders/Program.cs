using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOrders = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            for (int i = 1; i <= numberOrders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCnt = int.Parse(Console.ReadLine());

                double price = days * capsulesCnt * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");

                totalPrice += price;
                price = 0;
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
