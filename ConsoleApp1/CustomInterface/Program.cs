using Customlnterface;
using System;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Hexagon hex = new Hexagon();
            Console.WriteLine($"Hex points: {hex.Points}");

            // Перехватить возможное исключение InvalidCastException.
            Circle c = new Circle("Lisa");
            IPointy ltfPt = null;
            try
            {
                ltfPt = (IPointy)c;
                Console.WriteLine(ltfPt.Points);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            //получение ссылок на интерфейс с помощью слова as
            // Можно ли hex2 трактовать как IPointy?
            Hexagon hex2 = new Hexagon("Peter");
            IPointy ltfPt2 = hex2 as IPointy;
            if(ltfPt2 != null)
            {
                Console.WriteLine($"Points: {ltfPt2.Points}");
            } else
            {
                Console.WriteLine("Problem with retrieving points");
            }
            Console.WriteLine();
            //получение ссылок на интерфейс с помощью слова is
            // Создать массив элементов Shape.
            Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo") };
            for (int i=0; i< myShapes.Length; i++)
            {
                // Вспомните, что базовый класс Shape определяет абстрактный
                // член Draw(), поэтому все фигуры знают, как себя рисовать.
                myShapes[i].Draw();
                //У каких фигур есть вершины?
                if (myShapes[i] is IPointy ip)
                    Console.WriteLine("-> Points: {0}", ip.Points); // есть вершины
                    else
                    Console.WriteLine("-> {0}\'s not pointy!", myShapes[i].PetName);
                    // нет вершин
                //если фигура реализует интерфейс IDraw3D, то вызывается метод IDrawIn3d()
                if (myShapes[i] is IDraw3D)
                    DrawIn3D((IDraw3D)myShapes[i]);
                Console.WriteLine();
            }
            Console.WriteLine();
            //Использование интерфейсов в качестве параметров
            DrawIn3D(hex);

            // Получить первый элемент, имеющий вершины.
            // В целях безопасности не помешает проверить firstPointyltem на равенство null.
            IPointy firstPointyltem = FindFirstPointyShape(myShapes);
            Console.WriteLine("The item has {0} points", firstPointyltem.Points);

        }

        static void DrawIn3D(IDraw3D draw3D)
        {
            draw3D.Draw3D();
        }
        static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach (var s in shapes)
            {
                if(s is IPointy ip)
                {
                    return ip;
                }
               
            }
            return null;
        }
    }
}
