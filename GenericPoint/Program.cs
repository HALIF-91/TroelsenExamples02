using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> point = new Point<int>(5, 2);

            Point<double> point2 = new Point<double>(2.0, 1.5);

            Console.ReadLine();
        }
    }
}
