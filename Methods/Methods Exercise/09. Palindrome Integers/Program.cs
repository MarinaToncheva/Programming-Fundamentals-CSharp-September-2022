namespace _09._Palindrome_Integers
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string number = string.Empty;
            string reversedNumber = string.Empty;

            while ((number = Console.ReadLine()) != "END")
            {
                reversedNumber = GetReeversedNumber(number, reversedNumber);
                reversedNumber = string.Empty;
            }
         }
        static string GetReeversedNumber(string number, string reversedNumber)
        {
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversedNumber += number[i];
            }
            if (reversedNumber == number)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            return reversedNumber;
        }
    }
}
