namespace _06._Balanced_Brackets
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int openingBracket = 0;
            int closingBracket = 0;
            for (int i = 1; i <= numberOfLines; i++)
            {
                string symbol =Console.ReadLine();
                if (symbol=="(")
                {
                    openingBracket++;
                }
                else if (symbol==")")
                {
                    closingBracket++;
                    if (openingBracket - closingBracket != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                } 
            }
            if (openingBracket==closingBracket)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
