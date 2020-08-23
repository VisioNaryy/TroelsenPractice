using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 1234567;
            myInt.DisplayDefiningAssembly();
            Console.WriteLine(myInt.ReverseDigits());

            System.Data.DataSet d = new System.Data.DataSet();
            d.DisplayDefiningAssembly();
            
           


            Console.ReadKey();
        }
    }
}
