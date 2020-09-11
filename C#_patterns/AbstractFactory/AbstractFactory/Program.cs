using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Паттерн "Абстрактная фабрика"(Abstract Factory) предоставляет интерфейс для создания семейств взаимосвязанных объектов 
            //с определенными интерфейсами без указания конкретных типов данных объектов.
            //abstract class AbstractFactory
            //{
            //    public abstract AbstractProductA CreateProductA();
            //    public abstract AbstractProductB CreateProductB();
            //}
            //class ConcreteFactory1 : AbstractFactory
            //{
            //    public override AbstractProductA CreateProductA()
            //    {
            //        return new ProductA1();
            //    }

            //    public override AbstractProductB CreateProductB()
            //    {
            //        return new ProductB1();
            //    }
            //}
            //class ConcreteFactory2 : AbstractFactory
            //{
            //    public override AbstractProductA CreateProductA()
            //    {
            //        return new ProductA2();
            //    }

            //    public override AbstractProductB CreateProductB()
            //    {
            //        return new ProductB2();
            //    }
            //}

            //abstract class AbstractProductA
            //{ }

            //abstract class AbstractProductB
            //{ }

            //class ProductA1 : AbstractProductA
            //{ }

            //class ProductB1 : AbstractProductB
            //{ }

            //class ProductA2 : AbstractProductA
            //{ }

            //class ProductB2 : AbstractProductB
            //{ }

            //class Client
            //{
            //    private AbstractProductA abstractProductA;
            //    private AbstractProductB abstractProductB;

            //    public Client(AbstractFactory factory)
            //    {
            //        abstractProductB = factory.CreateProductB();
            //        abstractProductA = factory.CreateProductA();
            //    }
            //    public void Run()
            //    { }
            //}

            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();

            Hero warrior = new Hero(new WarriorFactory());
            warrior.Hit();
            warrior.Run();

            Console.ReadKey();
        }

        //абстрактный класс - оружие
        abstract class Weapon
        {
            public abstract void Hit();
        }
        // абстрактный класс движение
        abstract class Movement
        {
            public abstract void Move();
        }

        //***//
        // класс арбалет
        class Arbalet : Weapon
        {
            public override void Hit()
            {
                Console.WriteLine("Damaging with Arbalet");
            }
        }
        // класс меч
        class Sword : Weapon
        {
            public override void Hit()
            {
                Console.WriteLine("Damaging with Sword");
            }
        }

        // движение полета
        class FlyMovement : Movement
        {
            public override void Move()
            {
                Console.WriteLine("Flying");
            }
        }
        // движение - бег
        class RunMovement : Movement
        {
            public override void Move()
            {
                Console.WriteLine("Running");
            }
        }

        //***//
        // класс абстрактной фабрики
        abstract class HeroFactory
        {
            public abstract Movement CreateMovement();
            public abstract Weapon CreateWeapon();
        }
        // Фабрика создания летящего героя с арбалетом
        class ElfFactory : HeroFactory
        {
            public override Movement CreateMovement()
            {
                return new FlyMovement();
            }
            public override Weapon CreateWeapon()
            {
                return new Arbalet();
            }
        }
        // Фабрика создания бегущего героя с мечом
        class WarriorFactory: HeroFactory
        {
            public override Movement CreateMovement()
            {
                return new RunMovement();
            }
            public override Weapon CreateWeapon()
            {
                return new Sword();
            }
        }

        // клиент - сам супергерой
        class Hero
        {
            private Weapon weapon;
            private Movement movement;
            public Hero(HeroFactory factory)
            {
                weapon = factory.CreateWeapon();
                movement = factory.CreateMovement();
            }
            public void Run()
            {
                movement.Move();
            }
            public void Hit()
            {
                weapon.Hit();
            }
        }

    }
}
