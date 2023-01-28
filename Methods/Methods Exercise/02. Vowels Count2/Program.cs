namespace _02._Vowels_Count
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            //1 way -> vioid Method(string text)->CW()
            //2 way -> int Method(string text)->Main:CW()
            //Second way is mostly used
            string text = Console.ReadLine();
            int vowelsCount = GetVowelsCount(text);
            Console.WriteLine(vowelsCount);

        }
        static int GetVowelsCount(string text)
        {
            //Y may not be considered as vowel
            int vowelsCount = 0;
            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i', 'y' };
            foreach (char letter in text.ToLower()) //Обхожда подадения текст буква по буква - S o f t U n i 
            {
                if (MyContains(vowels, letter))
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
        static bool MyContains(char[] arr, char searchChar)
        {
            for (int i = 0; i <arr.Length; i++)
            {
                char currChar = arr[i];
                if (currChar==searchChar)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
