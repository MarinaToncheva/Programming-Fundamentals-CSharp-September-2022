namespace _03._Characters_in_Range
{
    using System;
    class Program
    {
     static void Main(string[] args)
        {
            char firstCh = char.Parse(Console.ReadLine());
            char secondCh = char.Parse(Console.ReadLine());
            int firstChar = (int)firstCh;
            int secondChar = (int)secondCh;

            PrintAllCharacters(firstCh,secondCh);
           
        static void PrintAllCharacters(int firstChar, int secondChar)
            {
                int endChar;
                int beginChar;
                for (int i = firstChar + 1; i < secondChar; i++)
                {
                    Console.Write((char)i + " ");
                }
                Console.WriteLine();
                if (firstChar > secondChar)
                {
                    beginChar = secondChar;
                    endChar = firstChar;
                    for (int i = beginChar + 1; i < endChar; i++)
                    {
                        Console.Write((char)i + " ");
                    }
                    Console.WriteLine();
                
                }
            }
        }
    }
}
