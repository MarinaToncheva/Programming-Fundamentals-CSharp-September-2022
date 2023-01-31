namespace _07._Append_Arrays
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine() //Нов масив, където махаме разделител и обръщаме
                            .Split('|')
                            .Reverse()
                            .ToArray();

            string inputToString = string.Join(" ", input); //Правим стринг от данни в масива

            string[] result = inputToString          //Правим нов масив от данни от стрингове
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Console.WriteLine(string.Join(" ", result)); //Разпечатваме елементи от масива
        }
    }
}
