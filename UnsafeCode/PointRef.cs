﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsafeCode
{
    class PointRef
    {
        public int x;
        public int y;
        public override string ToString()
        {
            return string.Format("({0}, {1})", x, y);
        }
    }
}
