using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    // Этот класс расширяет Circle и скрывает унаследованный метод Draw().
    class ThreeDCircle :Circle
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
    }
}
