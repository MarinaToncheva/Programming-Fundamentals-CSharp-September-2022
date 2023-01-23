namespace _09._Chars_to_String
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());

            string firstString = firstChar.ToString();
            string secondString = secondChar.ToString();
            string thirdString = thirdChar.ToString();

            Console.WriteLine($"{firstString}{secondString}{thirdString}");

            //char firstChar = char.Parse(Console.ReadLine());
            //char secondChar = char.Parse(Console.ReadLine());
            //char thirdChar = char.Parse(Console.ReadLine());
            //string result = firstChar.ToString() + secondChar.ToString() + thirdChar.ToString();
            //Console.WriteLine(result);
        }
    }
}
