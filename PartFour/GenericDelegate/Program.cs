using System;

namespace GenericDelegate
{
    class Program
    {
        public delegate void MyGenericDelegate<T>(T arg);
        static void Main(string[] args)
        {
            MyGenericDelegate<string> strTarget = StringTarget;
            MyGenericDelegate<int> intTarget = IntTarget;
            strTarget("Some string data");
            IntTarget(4);

            Console.ReadKey();
        }
        static void StringTarget(string arg)
        {
            Console.WriteLine("arg in uppercase is: {0}", arg.ToUpper());
        }
        static void IntTarget(int arg)
        {
            Console.WriteLine("++arg is: {0}", ++arg);
        }
    }
}
