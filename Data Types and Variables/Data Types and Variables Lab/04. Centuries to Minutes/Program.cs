namespace _04._Centuries_to_Minutes
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days =(int)( years * 365.2422);//sae the int part
            long hours = days * 24;
            long minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
