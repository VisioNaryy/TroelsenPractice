using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceHierarchy
{
    interface IAdvancedDraw: IDrawable
    {
        void DrawInBoundingBox(int top, int left, int bottom, int right);
        void DrawUpsideDown();
    }
}
