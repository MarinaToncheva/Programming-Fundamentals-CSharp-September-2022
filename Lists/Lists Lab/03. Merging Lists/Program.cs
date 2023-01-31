namespace _03._Merging_Lists
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstCollection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondCollection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            //1 2 3 4 - firstColl
            //1 2 3 - secondColl

            int n = Math.Min(firstCollection.Count, secondCollection.Count);
            //Ще върне по-малката колекция 
            for (int i = 0; i < n; i++) // до тук сме завъртяли елементите до края на по-малката колекция
            {
                result.Add(firstCollection[i]); //1
                result.Add(secondCollection[i]); //1
             }
            if (firstCollection.Count>secondCollection.Count)
            {
                for (int i = n; i < firstCollection.Count; i++)
                {
                    result.Add(firstCollection[i]);
                }
            }
            else if (secondCollection.Count>firstCollection.Count)
            {
                for (int i = n; i < secondCollection.Count; i++)
                {
                    result.Add(secondCollection[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
