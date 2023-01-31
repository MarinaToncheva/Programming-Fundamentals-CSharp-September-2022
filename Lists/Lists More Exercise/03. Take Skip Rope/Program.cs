using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialMessage =Console.ReadLine();

            List<string> charsList = new List<string>();
            List<int> DigitsList = new List<int>();

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < initialMessage.Length; i++)
            {
                char currentSymbol = (char)(initialMessage[i]);
                if (Char.IsDigit(currentSymbol))
                {
                    DigitsList.Add(currentSymbol);
                }
                else
                {
                    charsList.Add(currentSymbol.ToString());
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < DigitsList.Count; i++)
            {
                int currentDigit = DigitsList[i];
                if (i%2==0)
                {
                    takeList.Add(currentDigit-48);
                }
                else
                {
                    skipList.Add(currentDigit-48);
                }
            }

            int indexForSkip = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                List<string> temp = new List<string>(charsList);

                temp = temp.Skip(indexForSkip).Take(takeList[i]).ToList();

                result.Append(string.Join("", temp));

                indexForSkip += takeList[i] + skipList[i];
            }
            Console.WriteLine(result.ToString());

           // string input = Console.ReadLine();
           //
           // List<int> numbers = input
           //     .Where(x => char.IsDigit(x))
           //     .Select(x => x.ToString())
           //     .Select(int.Parse)
           //     .ToList();
           //
           // List<string> text = input
           //     .ToCharArray()
           //     .Where(x => x < '0' || x > '9')
           //     .Select(x => x.ToString())
           //     .ToList();
           //
           // List<int> takeList = numbers
           //     .Where((x, index) => index % 2 == 0)
           //     .ToList();
           //
           // List<int> skipList = numbers
           //     .Where((x, index) => index % 2 != 0)
           //     .ToList();
           //
           // string result = string.Empty;
           // int index = 0;
           //
           // for (int i = 0; i < takeList.Count; i++)
           // {
           //     List<string> temp = text
           //         .Skip(index)
           //         .Take(takeList[i])
           //         .ToList();
           //
           //     result += string.Concat(temp);
           //     index += takeList[i] + skipList[i];
           // }
           // Console.WriteLine(result);
        }
    }
}
