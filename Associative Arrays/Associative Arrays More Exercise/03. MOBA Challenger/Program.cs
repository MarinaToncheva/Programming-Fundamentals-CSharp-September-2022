using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new Dictionary<string, Dictionary<string, int>>();

            ProcessInput(players);

            PrintResult(players);
        }
        static void FillPlayersList(Dictionary<string, Dictionary<string, int>> players, string player, string position, int points)
        {
            if (!players.ContainsKey(player))
            {
                players[player] = new Dictionary<string, int>();
            }
            if (!players[player].ContainsKey(position))
            {
                players[player].Add(position, points);
            }

            else if (players[player][position] < points)
            {
                players[player][position] = points;
            }
        }
        static void ProcessBattle(Dictionary<string, Dictionary<string, int>> players, string firstPlayer, string secondPlayer)
        {
            if (players.ContainsKey(firstPlayer) && players.ContainsKey(secondPlayer))
            {
                bool defeated = false;
                foreach (var firstPlayersPositions in players[firstPlayer])
                {
                    foreach (var secondPlayersPositions in players[secondPlayer])
                    {
                        if (firstPlayersPositions.Key == secondPlayersPositions.Key)
                        {
                            if (players[firstPlayer].Values.Sum() > players[secondPlayer].Values.Sum())
                            {
                                players.Remove(secondPlayer);
                                defeated = true;
                                break;
                            }
                            else
                            {
                                players.Remove(firstPlayer);
                                defeated = true;
                                break;
                            }
                        }
                    }
                    if (defeated)
                    {
                        break;
                    }
                }
            }
        }
        static void ProcessInput(Dictionary<string, Dictionary<string, int>> players)
        {
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Season end")
            {
                string[] separators = new string[] { " -> ", " vs " };
                string[] cmdArg = command
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries);

                if (cmdArg.Length == 3)
                {
                    string player = cmdArg[0];
                    string position = cmdArg[1];
                    int points = int.Parse(cmdArg[2]);

                    FillPlayersList(players, player, position, points);
                }

                else if (cmdArg.Length == 2)
                {
                    string firstPlayer = cmdArg[0];
                    string secondPlayer = cmdArg[1];

                    ProcessBattle(players, firstPlayer, secondPlayer);
                }

            }
        }
        static void PrintResult(Dictionary<string, Dictionary<string, int>> players)
        {
            foreach (var kvp in players
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenBy(x => x.Key))
            {
                string player = kvp.Key;
                int points = kvp.Value.Values.Sum();
                Console.WriteLine($"{player}: {points} skill");

                foreach (var pair in kvp.Value
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    string position = pair.Key;
                    int eachPositionsPoints = pair.Value;
                    Console.WriteLine($"- {position} <::> {eachPositionsPoints}");
                }
            }
        }
    }
}
