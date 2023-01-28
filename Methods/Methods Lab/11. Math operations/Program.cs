namespace _11._Math_operations
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string operand=Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());
            double result = Calculate(firstNum, operand, secondNum);
            Console.WriteLine(result); 
        }
        static double Calculate(int firstNum, string operand, int secondNum)
        {
            double result = 0;
            switch (operand)
            {
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "/":
                    result = firstNum / secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                default:
                    result = firstNum + secondNum;
                    break;
            }
            return result;
        }
    }
}
