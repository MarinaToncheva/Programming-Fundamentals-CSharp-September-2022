﻿namespace _04._Reverse_String
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string reversedWord = string.Empty;
            for (int i = word.Length - 1; i >= 0; i--) 
            {
                reversedWord += word[i];
            }
            Console.WriteLine(reversedWord);
        }
    }
}
