using System;

namespace Inheritance_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();

            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();
            Console.WriteLine("\n");
            Employee emp = new Manager("MoonUnit Zappa", 2, 3001, 20000,"101-11-1321", 1);
            GivePromotion(emp);
            object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
            GivePromotion((Manager)frank);

            
        }

        public static void GivePromotion(Employee emp)
        {
            // Повысить зарплату...
            // Предоставить место на парковке компании...
            Console.WriteLine("emp was promoted!");
        }
        
    }
}
