using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        // Этот метод позволяет объекту любого типа
        // отобразить сборку, в которой он определен.
        public static void DisplayDefiningAssembly(this object o)
        {
            Console.WriteLine($"{o.GetType().Name} lives here: {Assembly.GetAssembly(o.GetType()).GetName().Name}");
        }
        // Этот метод позволяет любому целочисленному значению изменить порядок
        // следования десятичных цифр на обратный. Например, для 56 возвратится 65.
        public static int ReverseDigits(this int i)
        {
            // Транслировать int в string и затем получить все его символы,
            char[] digits = i.ToString().ToCharArray();
            // Изменить порядок следования элементов массива.
            Array.Reverse(digits);
            // Поместить обратно в строку,
            string newDigits = new string(digits);
            // Возвратить модифицированную строку как int.
            return Int32.Parse(newDigits);
        }
    }
}
