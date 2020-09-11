using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace CustomAppDomain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Custom AppDomains *****\n");
            // Show all loaded assemblies in default AppDomain.
            AppDomain defaultAD = AppDomain.CurrentDomain;
            defaultAD.ProcessExit += (o, s) =>
            {
                Console.WriteLine("Default AD unloaded!");
            };
            ListAllAssembliesInAppDomain(defaultAD);
            // Make a new AppDomain.
            MakeNewAppDomain();
            Console.ReadLine();
        }
        private static void MakeNewAppDomain()
        {
            // Make a new AppDomain in the current process and
            // list loaded assemblies.
            AppDomain newAD = AppDomain.CreateDomain("SecondAppDomain");
            try
            {
                newAD.Load("CarLibrary");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            ListAllAssembliesInAppDomain(newAD);
            //Unload created Domain
            AppDomain.Unload(newAD);
        }
        static void ListAllAssembliesInAppDomain(AppDomain ad)
        {
            // Now get all loaded assemblies in the default AppDomain.
            var loadedAssemblies = from a in ad.GetAssemblies()
                                   orderby a.GetName().Name
                                   select a;
            Console.WriteLine("***** Here are the assemblies loaded in {0} *****\n",
            ad.FriendlyName);
            foreach (var a in loadedAssemblies)
            {
                Console.WriteLine("-> Name: {0}", a.GetName().Name);
                Console.WriteLine("-> Version: {0}\n", a.GetName().Version);
            }
        }
    }
}
