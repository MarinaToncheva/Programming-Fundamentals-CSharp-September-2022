namespace _05._Add_and_Subtract
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine(SubtractIntegers(firstNum, secondNum, thirdNum));

             static int AddIntegers(int firstNum, int secondNum)
            {
                int sum = 0;
                sum= firstNum + secondNum;
                return sum;
            }
            static int SubtractIntegers(int firstNum, int secondNum, int thirdNum)
            {
                int sum = 0;
                sum = AddIntegers(firstNum,secondNum) - thirdNum;
                return sum;
            }

        }
    }
}
