namespace _01._Encrypt__Sort_and_Print_Array
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int[] arrayOfSums = new int[numberOfLines];

            for (int i = 0; i < numberOfLines; i++)
            {
                string input =Console.ReadLine();
                char[] word = input.ToCharArray();
                int sum = 0;

                for (int j = 0; j < word.Length; j++)
                {
                    char currentChar =word[j];
                    if (currentChar == 65 ||currentChar == 69 || currentChar == 73 || currentChar == 79 || currentChar == 85 ||
                        currentChar == 97 || currentChar == 101 || currentChar == 105 || currentChar == 111 || currentChar == 117)
                    {
                        sum += currentChar * word.Length;
                    }
                    else
                    {
                        sum += currentChar / word.Length;
                    }
                }
                arrayOfSums[i] = sum;
            }
            Array.Sort(arrayOfSums);
            for (int i = 0; i <arrayOfSums.Length; i++)
            {
                Console.WriteLine(arrayOfSums[i]);
            }
        }
    }
}