namespace _03._Gaming_Store

{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());

            string input;

            double gameOne = 39.99;
            double gameTwo = 15.99;
            double gameThree = 19.99;
            double gameFour = 59.99;
            double gameFive = 29.99;
            double gameSix = 39.99;
            double moneyLeft = currentBalance;

            while ((input=Console.ReadLine())!= "Game Time")
            {
                if (input=="OutFall 4")
                {
                    if (moneyLeft==0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    else if (moneyLeft<gameOne)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    else
                    {
                        moneyLeft -= gameOne;
                        Console.WriteLine("Bought OutFall 4");
                        continue;
                    }
                }
                else if (input == "CS: OG")
                {
                    if (moneyLeft == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    else if (moneyLeft < gameTwo)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    else
                    {
                        moneyLeft-= gameTwo;
                        Console.WriteLine("Bought CS: OG");
                        continue;
                    }
                }
                else if (input == "Zplinter Zell")
                {
                    if (moneyLeft == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    else if (moneyLeft < gameThree)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    else
                    {
                        moneyLeft-=gameThree;
                        Console.WriteLine("Bought Zplinter Zell");
                        continue;
                    }
                }
                else if (input == "Honored 2")
                {
                    if (moneyLeft == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    else if (moneyLeft < gameFour)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    else
                    {
                        moneyLeft -=gameFour;
                        Console.WriteLine("Bought Honored 2");
                        continue;
                    }
                }
                else if (input == "RoverWatch")
                {
                    if (moneyLeft == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    else if (moneyLeft < gameFive)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    else
                    {
                        moneyLeft -=gameFive;
                        Console.WriteLine("Bought RoverWatch");
                        continue;
                    }
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    if (moneyLeft == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    else if (moneyLeft < gameSix)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    else
                    {
                        moneyLeft -=gameSix;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                    continue;
                }
            }
            if (input=="Game Time")
            {
                Console.WriteLine($"Total spent: ${(currentBalance-moneyLeft):f2}. Remaining: ${moneyLeft:f2}");
            }
        }
    }
}
