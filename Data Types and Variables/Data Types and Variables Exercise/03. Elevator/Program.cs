namespace _03._Elevator
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int fullCourses = numberOfPeople / capacity;

            if (numberOfPeople>capacity)
            {
                if ((fullCourses * capacity) < numberOfPeople)
                {
                    Console.WriteLine(fullCourses+1);
                }
                else if ((fullCourses * capacity) == numberOfPeople)
                {
                    Console.WriteLine(fullCourses);
                }
            }
            else if (numberOfPeople<=capacity)
            {
                Console.WriteLine("1");
            }          
        }
    }
}
