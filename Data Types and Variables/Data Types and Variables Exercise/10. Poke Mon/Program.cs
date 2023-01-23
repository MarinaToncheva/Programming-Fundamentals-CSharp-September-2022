namespace _10._Poke_Mon
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceBtwnPokeTrgs = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            double fiftyPercent = pokePower * 0.5;
            int pokesCount = 0;
            while (pokePower >= distanceBtwnPokeTrgs)
            {
                pokePower -= distanceBtwnPokeTrgs;
                pokesCount++;
                if (pokePower == fiftyPercent && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokesCount);
        }
    }
}
