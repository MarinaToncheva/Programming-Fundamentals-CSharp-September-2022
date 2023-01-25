namespace _04._Array_Rotation
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfIntegers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int rotationsCount = int.Parse(Console.ReadLine());
            int timesToRotate = rotationsCount % arrayOfIntegers.Length;

            for (int r = 1; r <=timesToRotate; r++)
            {
                int firstElement = arrayOfIntegers[0];
                for (int i = 1; i < arrayOfIntegers.Length; i++)
                {
                    arrayOfIntegers[i - 1] = arrayOfIntegers[i];
                }
                arrayOfIntegers[arrayOfIntegers.Length - 1] = firstElement;
            }
            Console.WriteLine(String.Join(" ", arrayOfIntegers));
        }
    }
}
