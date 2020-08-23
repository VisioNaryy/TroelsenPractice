using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExtensions
{
    public static class AnnoyingExtensions
    {
        public static void PrintDataNadBeep(this IEnumerable iterator)
        {
            foreach (var i in iterator)
            {
                Console.WriteLine(i);
                Console.Beep();
            }
        }
    }
}
