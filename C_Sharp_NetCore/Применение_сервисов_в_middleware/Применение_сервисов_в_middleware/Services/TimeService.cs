using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Применение_сервисов_в_middleware.Services
{
    public class TimeService
    {
        public string Time { get; }
        public TimeService()
        {
            Time = System.DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
