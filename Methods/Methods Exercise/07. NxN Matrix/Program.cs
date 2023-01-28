namespace _07._NxN_Matrix
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            CreateMatrix(input);

            static void CreateMatrix(int input)
            {
                for (int i = 0; i < input; i++)
                {
                    for (int j = 0; j < input; j++)
                    {
                        Console.Write(input + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
