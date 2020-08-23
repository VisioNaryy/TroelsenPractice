using Customlnterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomInterface
{
    class Triangle: Shape, IPointy
    {

        public Triangle()
        {
                
        }
        public Triangle(string name):base(name)
        {

        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing a {PetName} Triangle object");
        }

        public byte NumberOfPoints()
        {
            throw new NotImplementedException();
        }

        public byte Points { get { return 3; }}
    }
}
