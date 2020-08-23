using CustomInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Customlnterface
{
    // Этот класс расширяет Circle и скрывает унаследованный метод Draw().
    class ThreeDCircle :Circle, IDraw3D
    {
        public new string PetName { get; set; }
        public ThreeDCircle()
        {
                
        }

        // Скрыть любую реализацию Draw(), находящуюся выше в иерархии,
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D circle");
        }
        public void Draw3D()
        {
            Console.WriteLine("Drawing a Circle in 3D");
        }
    }
}
