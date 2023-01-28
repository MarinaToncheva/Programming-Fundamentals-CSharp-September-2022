using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string value = Console.ReadLine();

            if (dataType == "int")
            {
                int valueOfInt = int.Parse(value);
                int result = CalculateIntValue(valueOfInt);
                Console.WriteLine(result);

            }
            else if (dataType == "real")
            {
                double valueOfDouble = double.Parse(value);
                double result = CalculateDoubleValue(valueOfDouble);
                Console.WriteLine($"{result:f2}");
            }
            else//string
            {
                PrintChangedString(value);
            }
        }

        static int CalculateIntValue(int valueOfInt)
        {
            int result = valueOfInt * 2;
            return result;
        }
        static double CalculateDoubleValue(double valueOfDouble)
        {
            double result = valueOfDouble * 1.5;
            return result;
        }
        static void PrintChangedString(string value)
        {
            Console.WriteLine("$" + value + "$");
        }
    }
}