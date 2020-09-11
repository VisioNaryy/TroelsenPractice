using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMEethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Фабричный метод(Factory Method) -это паттерн, который определяет интерфейс для создания объектов некоторого класса,
            //но непосредственное решение о том, объект какого класса создавать происходит в подклассах. 
            //То есть паттерн предполагает, что базовый класс делегирует создание объектов классам-наследникам.

            //abstract class Product
            //{ }

            //class ConcreteProductA : Product
            //{ }

            //class ConcreteProductB : Product
            //{ }

            //abstract class Creator
            //{
            //    public abstract Product FactoryMethod();
            //}

            //class ConcreteCreatorA : Creator
            //{
            //    public override Product FactoryMethod() { return new ConcreteProductA(); }
            //}

            //class ConcreteCreatorB : Creator
            //{
            //    public override Product FactoryMethod() { return new ConcreteProductB(); }
            //}

            Developer dev = new PanelDeveloper("ООО КирпичСтрой");
            House house2 = dev.Create();

            dev = new WoodDeveloper("Частный застройщик");
            House house = dev.Create();

            Console.ReadKey();
        }

        //***//
        abstract class House { }

        class PanelHouse : House
        {
            public PanelHouse()
            {
                Console.WriteLine("Панельный дом построен");
            }
        }
        class WoodHouse : House
        {
            public WoodHouse()
            {
                Console.WriteLine("Деревянный дом построен");
            }
        }

        //***//
        abstract class Developer
        {
            public string Name { get; set; }
            public Developer(string n)
            {
                Name = n;
            }
            // фабричный метод
            abstract public House Create();
        }
        // строит панельные дома
        class PanelDeveloper : Developer
        {
            public PanelDeveloper (string n) : base(n) { }
            public override House Create()
            {
                return new PanelHouse();
            }
        }
        //строит деревянные дома
        class WoodDeveloper : Developer
        {
            public WoodDeveloper (string n) : base(n) { }
            public override House Create()
            {
                return new WoodHouse();
            }
        }

    }
}
