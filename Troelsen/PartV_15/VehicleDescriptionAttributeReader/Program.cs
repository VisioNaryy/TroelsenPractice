// Reflecting on attributes using early binding.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AttributedCarLibrary;

namespace VehicleDescriptionAttributeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Value of VehicleDescnptionAttribute *****\n");
            ReflectOnAttributesUsingEarlyBinding();
            Console.ReadLine();
        }

        private static void ReflectOnAttributesUsingEarlyBinding()
        {
            //get type of Winnebago
            Type t = typeof(Winnebago);
            //get all Winebago attributes
            object[] customAtts = t.GetCustomAttributes(false);
            //get description
            foreach (VehicleDescriptionAttribute v in customAtts)
            {
                Console.WriteLine($"->{v.Description}\n");
            }
        }
    }
}
