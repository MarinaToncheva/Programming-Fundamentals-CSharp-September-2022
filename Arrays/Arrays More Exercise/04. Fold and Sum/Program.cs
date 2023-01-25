namespace _04._Fold_and_Sum
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            //Solution from Softuni forum

            int[] arr = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray(); // 1 2 3 4 5 6 7 8

            int foldPoint = arr.Length / 2 / 2; // ->8/2/2 => index = 2 (number 3)

            int[] resultArr = new int[foldPoint * 2]; // new int[4];

            for (int i = 0; i < foldPoint; i++)
            {
                resultArr[i] = arr[i + foldPoint] + arr[foldPoint - 1 - i]; // resultArr[0] = 5;  resultArr[1] = 5; 

                resultArr[i + foldPoint] = arr[i + 2 * foldPoint] + arr[arr.Length - 1 - i]; //resultArr[2] = 13;  resultArr[3] = 13; 

            }
            Console.WriteLine(String.Join(' ', resultArr)); // 5 5 13 13
        }
    }
}