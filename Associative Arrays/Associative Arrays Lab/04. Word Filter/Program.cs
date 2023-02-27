namespace _04._Word_Filter
{
    using System;
    using System.Linq;
       class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0)
                .ToArray();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            //  Console.ReadLine()
            //      .Split()
            //      .Where(x => x.Length % 2 == 0)
            //      .ToList()
            //      .ForEach(Console.WriteLine);

            //      .ForEach(x=>Console.WriteLine(x));
        }
    }
}