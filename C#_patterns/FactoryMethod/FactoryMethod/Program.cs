using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer developer1 = new WoodDeveloper("Tom");
            House house1 = developer1.Create();
            Console.WriteLine(developer1.Name);
            //
            Developer developer2 = new StoneDeveloper("Sam");
            House house2 = developer2.Create();
            Console.WriteLine(developer2.Name);

            Console.ReadKey();
        }

        //houses
        public abstract class House
        {

        }

        public class WoodenHouse : House
        {
            public WoodenHouse()
            {
                Console.WriteLine("This is Wooden House!");
            }
        }

        public class StoneHouse:House
        {
            public StoneHouse()
            {
                Console.WriteLine("This is Stone House!");
            }
        }
        //Developer
        public abstract class Developer
        {
            public string Name  { get; set; }
            public Developer(string name)
            {
                Name = name;
            }
            public abstract House Create();
        }

        public class WoodDeveloper:Developer
        {
            public WoodDeveloper(string name):base(name)
            {

            }

            public override House Create()
            {
                return new WoodenHouse();
            }
        }

        public class StoneDeveloper : Developer
        {
            public StoneDeveloper(string name):base(name)
            {

            }

            public override House Create()
            {
                return new StoneHouse();
            }
        }

    }
}
