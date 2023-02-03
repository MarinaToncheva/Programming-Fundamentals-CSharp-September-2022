namespace _07._Order_by_Age
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input;

            while ((input=Console.ReadLine())!="End")
            {
                string[] personsInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = personsInfo[0];
                string idNum = personsInfo[1];
                int age = int.Parse(personsInfo[2]);

                Person person = new Person(name, idNum, age);

                bool idExists = false;

                foreach (var newPerson in people)
                {
                    if (newPerson.IdNum==person.IdNum)
                    {
                        person.Name = newPerson.Name;
                        person.Age = newPerson.Age;
                        idExists = true;
                    }
                }
                if (!idExists)
                {
                    people.Add(person);
                }  
            }
            foreach (var person in people.OrderBy(x=>x.Age))
            {

                Console.WriteLine($"{person.Name} with ID: {person.IdNum} is {person.Age} years old.");
            }
        }
    }
    public class Person
    {
        public Person(string name, string idNum, int age)
        {
            this.Name = name;
            this.IdNum = idNum;
            this.Age = age;
        }
        public string Name { get; set; }
        public string IdNum { get; set; }
        public int Age { get; set; }

    }
}
