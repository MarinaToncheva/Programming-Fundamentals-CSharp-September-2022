using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            int largest = Math.Max(Math.Max(numOne, numTwo), numThree);
            int smallest = Math.Min(Math.Min(numOne, numTwo), numThree);
            int middle = (numOne + numTwo + numThree) - (largest + smallest);

            Console.WriteLine(largest);
            Console.WriteLine(middle);
            Console.WriteLine(smallest);
        }
    }
}
