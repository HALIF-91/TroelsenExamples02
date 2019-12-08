using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimAndProperCarEvents
{
    public class CarEventArgs : EventArgs
    {
        public readonly string _msg;
        public CarEventArgs(string msg)
        {
            _msg = msg;
        }
    }
}
