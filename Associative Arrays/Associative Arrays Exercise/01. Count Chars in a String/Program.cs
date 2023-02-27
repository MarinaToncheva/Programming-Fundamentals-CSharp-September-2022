namespace _01._Count_Chars_in_a_String
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (var letter in text)
            {
                if (!counts.ContainsKey(letter))
                {
                    counts.Add(letter, 1);
                }
                else
                {
                    counts[letter]++;
                }
            }
            foreach (KeyValuePair<char, int> letter in counts.Where(a => a.Key != ' '))
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
