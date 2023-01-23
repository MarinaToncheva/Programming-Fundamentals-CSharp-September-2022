namespace _02._From_Left_to_The_Right
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string numbers = Console.ReadLine();

                string firstNumAsString = string.Empty;
                string secondNumAsString = string.Empty;

                bool isFirstNum = true;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (isFirstNum && numbers[j] == '-')
                    {
                        firstNumAsString += numbers[j];
                    }
                    else if (isFirstNum && numbers[j] != ' ')
                    {
                        firstNumAsString += numbers[j];
                    }
                    else if (!isFirstNum && numbers[j] != ' ')
                    {
                        secondNumAsString += numbers[j];
                    }
                    else if (numbers[j] == ' ')
                    {
                        isFirstNum = false;
                    }
                }

                long firstNumber = long.Parse(firstNumAsString);
                long secondNumber = long.Parse(secondNumAsString);

                if (firstNumber >= secondNumber)
                {
                    long digitFirstNumber = 0;
                    long sumFirstNumber = 0;
                    while (Math.Abs(firstNumber) > 0)
                    {
                        firstNumber = Math.Abs(firstNumber);
                        digitFirstNumber = firstNumber % 10;
                        firstNumber /= 10;
                        sumFirstNumber += digitFirstNumber;
                    }
                    Console.WriteLine(sumFirstNumber);
                }
                else if (firstNumber < secondNumber)
                {
                    long digitSecondNumber = 0;
                    long sumSecondNumber = 0;

                    while (Math.Abs(secondNumber) > 0)
                    {
                        secondNumber = Math.Abs(secondNumber);
                        digitSecondNumber = secondNumber % 10;
                        secondNumber /= 10;
                        sumSecondNumber += digitSecondNumber;
                    }
                    Console.WriteLine(sumSecondNumber);
                }
            }
        }
    }
}
