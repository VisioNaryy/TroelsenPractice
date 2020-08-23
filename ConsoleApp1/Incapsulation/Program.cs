using System;

namespace Incapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle m = new Motorcycle("Honda");
            Console.WriteLine(m.driverName);
            //
            AnotherMotorcycle am = new AnotherMotorcycle();
            Console.WriteLine($"{am._driverlntensity} : {am._driverName}");
            AnotherMotorcycle am1 = new AnotherMotorcycle(driverName:"Kawasaki");
            Console.WriteLine($"{am1._driverlntensity} : {am1._driverName}");
            AnotherMotorcycle am2 = new AnotherMotorcycle(driverIntensity: 20);
            Console.WriteLine($"{am2._driverlntensity} : {am2._driverName}");
        }
        class Motorcycle
        {
            public int driverlntensity;
            public string driverName;
            // Связывание конструкторов в цепочку.
            public Motorcycle() { }
            public Motorcycle(int intensity)
            : this(intensity, "") { }
            public Motorcycle(string name)
            : this(0, name) { }
            // Это 'главный' конструктор, выполняющий всю реальную работу,
            public Motorcycle(int intensity, string name)
            {
                if (intensity > 10)
                {
                    intensity = 10;
                }
                driverlntensity = intensity;
                driverName = name;
            }
        }

        public class AnotherMotorcycle
        {
            public int _driverlntensity;
            public string _driverName;
            public AnotherMotorcycle(int driverIntensity=0, string driverName="")
            {
                if (driverIntensity > 10)
                {
                    driverIntensity = 10;
                }
                _driverlntensity = driverIntensity;
                _driverName = driverName;
            }
        }
    }
}
