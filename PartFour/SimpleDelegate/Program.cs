using System;

namespace SimpleDelegate
{
    class Program
    {
        public delegate int BinaryOp(int x, int y);
        static void Main(string[] args)
        {
            BinaryOp b = new BinaryOp(SimpleMath.Add);
            Console.WriteLine(b.Invoke(5, 5));
            b += SimpleMath.Substract;
            Console.WriteLine(b.Invoke(5, 5));

            DisplayDelegetaInfo(b);


            Console.ReadKey();
        }
        public static void DisplayDelegetaInfo(Delegate delObj)
        {
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine($"Method name: {d.Method}");
                Console.WriteLine($"Type name: {d.Target}"); //в делегате d это свойство будет равно null, т.к. делегат BinaryOp ссылается на статический метод
            }
        }
    }
   
    public class SimpleMath
    {
        public static int Add(int x, int y) => x + y;
        public static int Substract(int x, int y) => x - y;
    }
}
