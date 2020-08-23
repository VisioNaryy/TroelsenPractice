using System;

namespace CustomConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 20);
            Console.WriteLine(r.ToString());
            r.Draw();

            // Преобразовать г в Square на основе высоты Rectangle.
            Square s = (Square)r;
            Console.WriteLine(s.ToString());
            s.Draw();

            Rectangle rect = new Rectangle(10, 5);
            DrawSquare((Square)rect);

            // Неявное преобразование работает!
            Square s3 = new Square { Length = 7 };
            Rectangle rect2 = s3;
            Console.WriteLine("rect2 = {0}", rect2);
            // Синтаксис явного приведения также работает!
            Square s4 = new Square { Length = 3 };
            Rectangle rect3 = (Rectangle)s4;
            Console.WriteLine("rect3 = {0}", rect3);

            Console.ReadKey();
        }
        static void DrawSquare(Square s)
        {
            Console.WriteLine(s.ToString());
            s.Draw();
        }
        public struct Rectangle
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public Rectangle(int w, int h):this()
            {
                Width = w;
                Height = h;
            }
            public void Draw()
            {
                for (int i = 0; i < Height; i++)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            public override string ToString()
            {
                return $"Width = {Width}, Height = {Height}";
            }
            public static implicit operator Rectangle(Square s)
            {
                Rectangle r = new Rectangle
                {
                    Height = s.Length,
                    Width = s.Length * 2
                };
                return r;
            }
        }

        public struct Square
        {
            public int Length { get; set; }
            public Square(int l):this()
            {
                Length = l;
            }
            public void Draw()
            {
                for (int i = 0; i < Length; i++)
                {
                    for (int j = 0; j < Length; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            public override string ToString() => $"Length = {Length}";
            // Rectangle можно явно преобразовывать в Square,
            public static explicit operator Square(Rectangle r)
            {
                Square s = new Square { Length = r.Height };
                return s;
            }
            public static explicit operator Square(int sideLength)
            {
                Square newSq = new Square { Length = sideLength };
                return newSq;
            }
            public static explicit operator int(Square s) => s.Length;
        }
    }
}
