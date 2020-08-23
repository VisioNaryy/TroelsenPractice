using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;

namespace ObservableCollections
{
    class Program
    {
        public enum NotifyCollectionChangedAction
        {
            Add = 0,
            Remove = 1,
            Replace = 2,
            Move = 3,
            Reset = 4
        }

        static void Main(string[] args)
        {
            ObservableCollection<Person> people = new ObservableCollection<Person>()
            {
                new Person(){ FirstName = "Peter", LastName = "Murphy", Age = 52 },
                new Person(){ FirstName = "Kevin", LastName = "Key", Age = 48 }
            };
            people.CollectionChanged += people_CollectionChanged;
            people.Add(new Person() { Age = 26, FirstName = "Jack", LastName = "Smith" });
          

            Console.ReadKey();
        }

        private static void people_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //Выяснить действие, которое привело к генерации события
            Console.WriteLine($"Action for this event: {e.Action}");

            //было что-то удалено
            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are OLD items:");
                foreach (var p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }
            //было что-то вставлено
            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Here are NEW items:");
                foreach (var p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }
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
            public Person()
            {

            }
        }
    }
}
