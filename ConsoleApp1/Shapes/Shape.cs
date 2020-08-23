using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    abstract class Shape
    {
        public string PetName { get; set; }
        public Shape(string name = "NoName")
        {
            PetName = name;
        }
        public abstract void Draw();
    }
}
