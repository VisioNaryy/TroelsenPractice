using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceHierarchy
{
    class BitmapImage : IAdvancedDraw
    {
        public void Draw()
        {
            Console.WriteLine("Drawing");
        }

        public void DrawInBoundingBox(int top, int left, int bottom, int right)
        {
            Console.WriteLine("Drawing in box");
        }

        public void DrawUpsideDown()
        {
            Console.WriteLine("Drawing upside down");
        }
    }
}
