namespace _12._Refactor_Special_Numbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());

            for (int currentNumber = 1; currentNumber <= integer; currentNumber++)
            {
                int current = 0;
                int sum = 0;
                current = currentNumber;

                bool isSpecial = false;
                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }

                isSpecial = (sum == 5) || ( sum== 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}", current, isSpecial);

                sum = 0;
                currentNumber = current;
            }
            
           

        }
    }
}
