using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            bool isResultFromNumbersPositive = IsResultPositive(firstNumber, secondNumber, thirdNumber);
            bool isResultEqualToZero = IsResultZero(firstNumber, secondNumber, thirdNumber);

            if (isResultEqualToZero)
            {
                Console.WriteLine("zero");
            }
            else
            {
                if (isResultFromNumbersPositive)
                {
                    Console.WriteLine("positive");
                }
                else
                {
                    Console.WriteLine("negative");
                }
            }
            static bool IsResultPositive(int numberOne, int numberTwo, int numberThree)
            {
                if ((numberOne > 0 && numberTwo > 0 && numberThree > 0) || (numberOne < 0 && numberTwo < 0 && numberThree > 0) || (numberOne < 0 && numberTwo > 0 && numberThree < 0) || (numberOne > 0 && numberTwo < 0 && numberThree < 0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            static bool IsResultZero(int numberOne, int numberTwo, int numberThree)
            {
                if (numberOne == 0 || numberTwo==0 || numberThree==0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
