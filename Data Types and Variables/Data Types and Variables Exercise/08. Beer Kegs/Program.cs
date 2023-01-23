namespace _08._Beer_Kegs
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int numKegs = int.Parse(Console.ReadLine());
            double volume = 0;
            double maxVolume = double.MinValue;
            string winKeg = string.Empty;
            for (int i = 1; i <=numKegs; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                volume = Math.PI * ((Math.Pow(radius, 2)) * height);
                if (volume>maxVolume)
                {
                    maxVolume = volume;
                    winKeg = model;
                }
                volume = 0;
            }
            Console.WriteLine(winKeg);
        }
    }
}
