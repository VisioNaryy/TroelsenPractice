using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //petrol version
            Car car = new Car(5, "Chevrolet Taha", new PetrolEngine());
            car.Move();
            //electric version
            car.Movable = new ElectricEngine();
            car.Move();

            Console.ReadKey();
        }

        //interface and classes, which are implementing interface
        interface IMovable
        {
            void Move();
        }

        class ElectricEngine : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Moving on electricity");
            }
        }
        class PetrolEngine : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Moving on petrol");
            }
        }

        //class
        class Car
        {
            private int _passengers { get; set; }
            private string _model { get; set; }
            public IMovable Movable { private get; set; }

            public Car(int pass, string model, IMovable move)
            {
                _passengers = pass;
                _model = model;
                Movable = move;
            }
            public void Move()
            {
                Movable.Move();
            }
        }
    }
}
