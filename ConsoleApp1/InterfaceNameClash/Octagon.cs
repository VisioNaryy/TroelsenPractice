using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceNameClash
{
    class Octagon:IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        public void Draw()
        {
            Console.WriteLine("Drawing to form, memory or printer");
        }

        //Модификатор доступа не может быть указан!
        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing to form");
        }
        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing to memory");
        }
        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing to printer");
        }
    }
}
