using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("Cindy");
            circle.Draw();
            Console.WriteLine();
            Hexagon hexagon = new Hexagon("Beth");
            hexagon.Draw();
            Console.WriteLine("\n");
            Shape[] shapes = { new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth"), new Hexagon("Linda") };
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
            Console.WriteLine("\n");
            ThreeDCircle td = new ThreeDCircle();
            td.Draw();
            // Здесь вызывается метод Draw(), определенный в родительском классе!
            ((Circle)td).Draw();

            Console.ReadKey();
        }
    }
}
