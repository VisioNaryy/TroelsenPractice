using System;
using System.Linq;
using System.Diagnostics;

namespace ProcessManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            ListAllRunningProcesses();
            GetSpecificProcess(41372);
            EnumThreadsForPid(41372);

            Console.WriteLine("*****Enter PID of process to investigate *****");
            Console.Write("PID: ");
            string pID = Console.ReadLine();
            int theProcID = int.Parse(pID);
            EnumThreadsForPid(theProcID);

            EnumModsForPid(41372);

            StartAndKillProcess();

            Console.ReadLine();
        }

        private static void StartAndKillProcess()
        {
            Process ffProc = null;
            // Launch Firefox, and go to Facebook!
            try
            {
                //ffProc = Process.Start("firefox.exe", "www.facebook.com");
                ProcessStartInfo startInfo = new ProcessStartInfo("FireFox.exe", "www.facebook.com");
                startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                ffProc = Process.Start(startInfo);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("--> Hit enter to kill {0}...", ffProc.ProcessName);
            Console.ReadLine();
            // Kill the iexplore.exe process.
            try
            {
                ffProc.Kill();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void EnumModsForPid(int pID)
        {
            Process theProc = null;
            try
            {
                theProc = Process.GetProcessById(pID);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"Here are the loaded modules for: {theProc.ProcessName}");
            ProcessModuleCollection theMods = theProc.Modules;
            foreach (ProcessModule pm in theMods)
            {
                Console.WriteLine($"Mod name: {pm.ModuleName}\t Mod memory size: {pm.ModuleMemorySize}");
            }
            Console.WriteLine("************************************\n");
        }

        private static void GetSpecificProcess(int id)
        {
            Process theProc = null;
            try
            {
                theProc = Process.GetProcessById(id);
                Console.WriteLine($"Specific process with {theProc.Id} PID is {theProc.ProcessName}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("*************");
        }

        private static void ListAllRunningProcesses()
        {
            // "." - is a local computer
            var runningProcs = from proc in Process.GetProcesses(".")
                               orderby proc.Id
                               select proc;
            foreach (var p in runningProcs)
            {
                Console.WriteLine($"PID: {p.Id}\tName: {p.ProcessName}");
            }
            Console.WriteLine("*************");
        }

        static void EnumThreadsForPid(int pID)
        {
            Process theProc = null;
            try
            {
                theProc = Process.GetProcessById(pID);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            // List out stats for each thread in the specified process.
            Console.WriteLine("Here are the threads used by: {0}", theProc.ProcessName);
            ProcessThreadCollection theThreads = theProc.Threads;
            foreach (ProcessThread pt in theThreads)
            {
                string info =
                $"-> Thread ID: {pt.Id}\tStart Time: {pt.StartTime.ToShortTimeString()}\tPriority:{ pt.PriorityLevel}";
            Console.WriteLine(info);
            }
            Console.WriteLine("************************************\n");
        }
    }
}
