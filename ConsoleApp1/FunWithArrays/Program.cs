using System;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** FunWithArrays ***");
            SimpleArrays();
            RectMultidimensionalArray();
            JaggedMultidimensionalArray();
            Console.ReadLine();
        }
        static void SimpleArrays()
        {
            Console.WriteLine(" => SimpleArrays creation");
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;
            foreach (var i in myInts)
            {
                Console.WriteLine(i);
            }

            string[] booksOnDotNet = new string[] { "book 1", "book 2", "book 3" };
            foreach (var b in booksOnDotNet)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("Reversed books array:");
            Array.Reverse(booksOnDotNet);
            foreach (var b in booksOnDotNet)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("Sorted books aray:");
            Array.Sort(booksOnDotNet);
            foreach (var b in booksOnDotNet)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("Cleared books array:");
            Array.Clear(booksOnDotNet, 1, 2);
            foreach (var b in booksOnDotNet)
            {
                Console.WriteLine(b);
            }
            

            bool[] boolArray = { false, true, true };
            foreach (var ba in boolArray)
            {
                Console.WriteLine(ba);
            }
            //при объявлении массива с помощью ключевого слова var, обязательно должно присутствовать слово new!
            Console.WriteLine();
        }

        static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array [3*4].");
            // Прямоугольный многомерный массив.
            int[,] myMatrix;
            myMatrix = new int[3, 4];
            // Заполнить массив (3 * 4) .
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    myMatrix[i, j] = i * j;
            // Вывести содержимое массива (3 * 4) .
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(myMatrix[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array.");
            // Зубчатый многомерный массив (т.е. массив массивов).
            // Здесь мы имеем массив из 5 разных массивов,
            int[][] myJagArray = new int[5][];
            // Создать зубчатый массив.
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];
            // Вывести все строки (помните, что каждый элемент имеет стандартное значение 0).
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        
    }
}
