using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double coinsCnt = 0;
            double priceNuts = 2.0;
            double priceCoke = 1.0;
            double priceWater = 0.7;
            double priceCrisps = 1.5;
            double priceSoda = 0.8;

            while ((input=Console.ReadLine()) != "Start")
            {
                double coins = double.Parse(input);
                
                if (coins==0.1 || coins==0.2 || coins==0.5 || coins==1 || coins==2 )
                {
                    coinsCnt += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
            }
            if (input=="Start")
            {
                string inputProducts;
                while ((inputProducts = Console.ReadLine()) != "End")
                {
                    if (inputProducts!="Coke" && inputProducts != "Soda" && inputProducts != "Water" && inputProducts != "Nuts" && inputProducts != "Crisps")
                    {
                        Console.WriteLine("Invalid product");
                        continue;
                    }
                    if (inputProducts=="Coke")
                    {
                        if (coinsCnt>=priceCoke)
                        {
                            coinsCnt -= priceCoke;
                            Console.WriteLine("Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            continue;
                        }  
                    }
                    else if (inputProducts == "Nuts")
                    {
                        if (coinsCnt >= priceNuts)
                        {
                            coinsCnt -= priceNuts;
                            Console.WriteLine("Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            continue;
                        }
                    }
                    else if (inputProducts == "Water")
                    {
                        if (coinsCnt >= priceWater)
                        {
                            coinsCnt -= priceWater;
                            Console.WriteLine("Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            continue;
                        }
                    }
                    else if (inputProducts == "Crisps")
                    {
                        if (coinsCnt >= priceCrisps)
                        {
                            coinsCnt -= priceCrisps;
                            Console.WriteLine("Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            continue;
                        }
                    }
                    else
                    {
                        if (coinsCnt >= priceSoda)
                        {
                            coinsCnt -= priceSoda;
                            Console.WriteLine("Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            continue;
                        }
                    }
                }
                if (inputProducts=="End")
                {
                    Console.WriteLine($"Change: {coinsCnt:f2}");
                }
            }
        }
    }
}
