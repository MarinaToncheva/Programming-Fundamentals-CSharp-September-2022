namespace _01._Smallest_of_Three_Numbers
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result= PrintSmallest(firstNumber,secondNumber,thirdNumber);
            Console.WriteLine(result);
            
            static int PrintSmallest(int firstNumber, int secondNumber, int thirdNumber)
            {
                int smallest = Math.Min(Math.Min(firstNumber, secondNumber), thirdNumber);
                return smallest;
            }
        }
    }
}
