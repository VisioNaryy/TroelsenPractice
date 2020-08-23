using System;
using System.Collections.Generic;
using System.Text;

namespace CustomInterface
{
    class PointyTestClass : IPointy
    {
        public byte Points => throw new NotImplementedException();
    }
}
