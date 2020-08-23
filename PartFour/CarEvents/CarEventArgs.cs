using System;
using System.Collections.Generic;
using System.Text;

namespace CarEvents
{
    public class CarEventArgs: EventArgs
    {
        public readonly string message;
        public CarEventArgs(string mes)
        {
            message = mes;
        }
    }
}
