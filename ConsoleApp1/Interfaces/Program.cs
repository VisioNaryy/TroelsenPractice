using Microsoft.Data.SqlClient;
using System;
namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** A First Look at Interfaces *****\n");
            // Все эти классы поддерживают интерфейс ICloneable.
            string myStr = "Hello";
            OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
            SqlConnection sqlCnn = new SqlConnection();
            // Следовательно, все они могут быть переданы методу,
            // принимающему параметр типа ICloneable.
            CloneMe(myStr);
            CloneMe(unixOS);
            CloneMe(sqlCnn);
            Console.ReadLine();
        }

        private static void CloneMe(ICloneable c)
        {
            object theClone = c.Clone();
            Console.WriteLine($"Your clone is {theClone.GetType().Name}");
        }
    
    }
}
