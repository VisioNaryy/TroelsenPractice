using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Жизненный_цикл_зависимостей
{
    public interface ICounter
    {
        int Value { get; }
    }

    public class RandomCounter : ICounter
    {
        private int _value;
        static Random rnd = new Random();
        public RandomCounter()
        {
            _value = rnd.Next(0, 1000000);
        }

        public int Value
        {
            get { return _value; }
        }
    }

    
}
