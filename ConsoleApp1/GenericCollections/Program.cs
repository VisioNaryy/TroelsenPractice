using System;
using System.Collections.Generic;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
           {
               new Person(25,"Tom","Smith"),
                new Person(22,"Michael","Tompson"),
                 new Person(27,"Sam","Brown"),
                  new Person(24,"Fred","Steels")
           };
            //foreach (var p in people)
            //{
            //    Console.WriteLine($"{p.Age} {p.FirstName} {p.LastName}");
            //}

            Dictionary<string, Person> peopleA = new Dictionary<string, Person>();
            peopleA.Add("Tom", new Person(25, "Tom", "Smith"));
            peopleA.Add("Michael", new Person(22, "Michael", "Tompson"));
            peopleA.Add("Sam", new Person(27, "Sam", "Brown"));
            peopleA.Add("Fred", new Person(24, "Fred", "Steels"));

            foreach (var p in peopleA)
            {
                Console.WriteLine($"{p.Key} : {p.Value.Age} {p.Value.FirstName} {p.Value.LastName}");
            }
            Person Sam = peopleA["Sam"];
            Console.WriteLine(Sam.Age);

        }

        protected internal class Person
        {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
            public Person(int age, string firstName, string lastName)
            {
                Age = age;
                FirstName = firstName;
                LastName = lastName;

            }
        }
    }
}
