using System;

namespace OverloadedOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 20);
            Point p2 = new Point(-5, -10);
            Point p3 = p1 + p2;
         
            Console.WriteLine(p3);
            Console.WriteLine(p3+15);

            // Операция += перегружена автоматически.
            Point ptThree = new Point(90, 5);
            Console.WriteLine("ptThree = {0}”, ptThree");
            Console.WriteLine("ptThree += ptTwo: {0}", ptThree += p2);
            // Операция -= перегружена автоматически.
            Point ptFour = new Point(0, 500);
            Console.WriteLine("ptFour = {0}", ptFour);
            Console.WriteLine("ptFour -= ptThree: {0}", ptFour -= ptThree);
            //
            Console.WriteLine("ptOne == ptTwo : {0}", p1 == p2);
            Console.WriteLine("ptOne != ptTwo : {0}", p1 != p2);
            Console.ReadKey();
        }
        public class Point: IComparable<Point>
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Point(int xPos, int yPos)
            {
                X = xPos;
                Y = yPos;
            }
            public override string ToString()
            {
                return $"[{this.X}, {this.Y}]";
            }

            public static Point operator + (Point p1, Point p2)
            {
                return new Point(p1.X + p2.X, p1.Y + p2.Y);
            }
            public static Point operator -(Point p1, Point p2) =>
                new Point(p1.X - p2.X, p1.Y - p2.Y);

            public static Point operator + (Point p1, int change) =>
                new Point(p1.X + change, p1.Y + change);
            public static Point operator + (int change, Point p1) =>
                new Point(p1.X + change, p1.Y + change);

            // Добавить 1 к значениям Х/Y входного объекта Point.
            public static Point operator ++(Point p1) => new Point(p1.X + 1, p1.Y + 1);
            // Вычесть 1 из значений X/Y входного объекта Point.
            public static Point operator --(Point p1) => new Point(p1.X - 1, p1.Y - 1);

            //
            public override bool Equals(object obj)
            {
                return obj.ToString() == this.ToString();
            }
            public override int GetHashCode()
            {
                return this.ToString().GetHashCode();
            }
            // Теперь перегрузить операции == и !=
            public static bool operator == (Point p1, Point p2) => p1.Equals(p2);
            public static bool operator !=(Point p1, Point p2) => !p1.Equals(p2);
            //
            public int CompareTo(Point other)
            {
                if((this.X> other.X)&&(this.Y>other.Y))
                        return 1;
                if((this.X<other.X)&&(this.Y<other.Y))
                        return -1;
                else return 0;
            }
            public static bool operator <(Point p1, Point p2) => p1.CompareTo(p2) < 0;
            public static bool operator >(Point p1, Point p2) => p1.CompareTo(p2) > 0;
            public static bool operator <=(Point p1, Point p2) => p1.CompareTo(p2) <= 0;
            public static bool operator >=(Point p1, Point p2) => p1.CompareTo(p2) >= 0;
        }
    }
}
