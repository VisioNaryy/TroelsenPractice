using System;
using System.Reflection;
using System.Linq;

namespace MyTypeViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListMethods();
            //ListFields();
            //ListProps();
            //ListInterfaces();
            //ListVariousStats();

            Console.WriteLine("***** Welcome to MyTypeViewer *****");
            string typeName = "";
            do
            {
                Console.WriteLine("\nEnter a type name to evaluate");
                Console.Write("or enter Q to quit: ");
                // Get name of type.
                typeName = Console.ReadLine();
                // Does user want to quit?
                if (typeName.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                // Try to display type.
                try
                {
                    Type t = Type.GetType(typeName);
                    Console.WriteLine("");
                    ListVariousStats(t);
                    ListFields(t);
                    ListProps(t);
                    ListMethods(t);
                    ListInterfaces(t);
                }
                catch
                {
                    Console.WriteLine("Sorry, can't find type");
                }
            } while (true);
        }

        private static void ListVariousStats(Type t)
        {
            Console.WriteLine("***** Various Statistics *****");
            Console.WriteLine("Base class is: {0}", t.BaseType);
            Console.WriteLine("Is type abstract? {0}", t.IsAbstract);
            Console.WriteLine("Is type sealed? {0}", t.IsSealed);
            Console.WriteLine("Is type generic? {0}", t.IsGenericTypeDefinition);
            Console.WriteLine("Is type a class type? {0}", t.IsClass);
            Console.WriteLine();
        }

        private static void ListInterfaces(Type type)
        {
            Console.WriteLine("*****Interfaces*****");
            var interfacesName = from n in type.GetInterfaces()
                                 select n;
            foreach (Type name in interfacesName)
            {
                Console.WriteLine(name.Name);
            }
        }

        private static void ListFields(Type type)
        {
            Console.WriteLine("*****Fields*****");
            var fieldsName = from n in type.GetFields()
                             select n.Name;
            foreach (var name in fieldsName)
            {
                Console.WriteLine(name);
            }
        }
        static void ListProps(Type t)
        {
            Console.WriteLine("***** Properties *****");
            var propNames = from p in t.GetProperties() 
                            select p.Name;
            foreach (var name in propNames)
                Console.WriteLine(name);
            Console.WriteLine();
        }
        private static void ListMethods(Type t)
        {
            //MethodInfo[] mi = type.GetMethods();
            //foreach (var item in mi)
            //{
            //    Console.WriteLine("Method Name : "+ item.Name);
            //    Console.WriteLine("Is static? : "+ item.IsStatic);
            //    Console.WriteLine("Is public? : "+ item.IsPublic);
            //}
            Console.WriteLine("***** Methods *****");
            MethodInfo[] mi = t.GetMethods();
            foreach (MethodInfo m in mi)
            {
                // Get return type.
                string retVal = m.ReturnType.FullName;
                string paramInfo = "( ";
                // Get params.
                foreach (ParameterInfo pi in m.GetParameters())
                {
                    paramInfo += string.Format("{0} {1} ", pi.ParameterType, pi.Name);
                }
                paramInfo += " )";
                // Now display the basic method sig.
                Console.WriteLine("->{0} {1} {2}", retVal, m.Name, paramInfo);
            }
            Console.WriteLine();
        }
    }
}
