namespace _02._Common_Elements
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine()
                .Split(" ");
            string[] secondArray = Console.ReadLine()
            .Split(" ");

            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (secondArray[i] == firstArray[j])
                    {
                        Console.Write(secondArray[i] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}