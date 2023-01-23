namespace _05._Decrypting_Message
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());

            StringBuilder message = new StringBuilder();

            for (int i = 0; i < numberOfLines; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                message.Append((char)(currentChar + key));
            }
            Console.WriteLine(message);
        }
    }
}