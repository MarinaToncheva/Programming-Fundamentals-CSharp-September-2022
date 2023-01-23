namespace _10._Lower_or_Upper
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());

            if ((int)ch>=65 && (int)ch <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else if ((int)ch >= 97 && (int)ch <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
