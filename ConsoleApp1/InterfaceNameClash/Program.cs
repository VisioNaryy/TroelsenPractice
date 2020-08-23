using System;

namespace InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Octagon oct = new Octagon();
            oct.Draw();
            IDrawToForm idtf = oct;
            idtf.Draw();
            IDrawToMemory idtm = oct;
            idtm.Draw();
            IDrawToPrinter idtp = oct;
            idtp.Draw();
        }
    }
}
