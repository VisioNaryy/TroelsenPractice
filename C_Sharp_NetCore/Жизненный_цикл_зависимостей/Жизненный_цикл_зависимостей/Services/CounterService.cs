using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Жизненный_цикл_зависимостей.Services
{
    public class CounterService
    {
        protected internal  ICounter Counter { get; }

        public CounterService(ICounter counter)
        {
            Counter = counter;
        }
    }
}
