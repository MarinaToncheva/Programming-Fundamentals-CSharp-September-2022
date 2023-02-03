using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            //help from softuni forum
            int lines = int.Parse(Console.ReadLine());

            var family = new Family();

            for (int i = 0; i < lines; i++)
            {
                var line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var person = new Person(line[0], int.Parse(line[1]));

                family.AddMember(person);
            }
            var oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
        public class Person
        {
            public string Name { get; set; } 
            public int Age { get; set; }    
            public Person(string name, int age) //constructor
            {
                this.Name = name;
                this.Age = age;
            }
        }
        public class Family
        {
            public List<Person> MembersList { get; set; }
          
            public Family()
            {
                this.MembersList = new List<Person>();
            }

            public void AddMember(Person member)
            {
                this.MembersList.Add(member);
            }

            public Person GetOldestMember()
            {
                return this.MembersList
                    .OrderByDescending(p => p.Age)
                    .FirstOrDefault();
            }
        }
    }
}
