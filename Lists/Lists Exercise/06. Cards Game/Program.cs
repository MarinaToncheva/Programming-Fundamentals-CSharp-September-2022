namespace _06._Cards_Game
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayersDeck = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> secondPlayersDeck = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (firstPlayersDeck.Count > 0 && secondPlayersDeck.Count > 0)
            {
                if (firstPlayersDeck[0] == secondPlayersDeck[0])
                {
                    firstPlayersDeck.RemoveAt(0);
                    secondPlayersDeck.RemoveAt(0);
                }
                else if (firstPlayersDeck[0] > secondPlayersDeck[0])
                {
                    firstPlayersDeck.Add(secondPlayersDeck[0]);
                    firstPlayersDeck.Add(firstPlayersDeck[0]);
                    firstPlayersDeck.RemoveAt(0);
                    secondPlayersDeck.RemoveAt(0);
                }
                else if (firstPlayersDeck[0] < secondPlayersDeck[0])
                {
                    secondPlayersDeck.Add(firstPlayersDeck[0]);
                    secondPlayersDeck.Add(secondPlayersDeck[0]);
                    firstPlayersDeck.RemoveAt(0);
                    secondPlayersDeck.RemoveAt(0);
                }
            }
            if (firstPlayersDeck.Count == 0)
            {
                int secondPlayersSum = secondPlayersDeck.Sum();
                Console.WriteLine($"Second player wins! Sum: {secondPlayersSum}");
            }
            else if (secondPlayersDeck.Count == 0)
            {
                int firstPlayersSum = firstPlayersDeck.Sum();
                Console.WriteLine($"First player wins! Sum: {firstPlayersSum}");
            }
        }
    }
}