namespace _10._Multiply_Evens_by_Odds
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string input =Console.ReadLine(); //123456
            int absValue =Math.Abs(int.Parse(input));
            int sumOfEvenDigits = GetSumOfEvenDigits(absValue.ToString());
            int sumOfOddDigits = GetSumOfOddDigits(absValue.ToString());
            int result = sumOfEvenDigits * sumOfOddDigits;
            Console.WriteLine(result);
        }
        static int GetSumOfEvenDigits(string value)
        {
            int sum = 0;
            for (int i = 0; i < value.Length; i++)
            {
                //"1234" 
                //input[0]='1'
                //'1'.ToString()=>"1"
                int currentNumber =(int.Parse(value[i].ToString()));
                if (currentNumber%2==0)
                {
                    sum += currentNumber;
                }
            }
            return sum;
        }
        static int GetSumOfOddDigits(string value)
        {
            int sum = 0;
            for (int i = 0; i < value.Length; i++)
            {
                //"1234" 
                //input[0]='1'
                //'1'.ToString()=>"1"
                int currentNumber =(int.Parse(value[i].ToString()));
                if (currentNumber % 2 != 0)
                {
                    sum += currentNumber;
                }
            }
            return sum;
        }
    }
}
