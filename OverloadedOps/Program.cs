using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Point ptOne = new Point(100, 100);
            Point ptTwo = new Point(40, 40);

            Console.WriteLine("ptOne = {0}", ptOne);
            Console.WriteLine("ptTwo = {0}", ptTwo);

            // Сложить две точки чтобы получить большую
            Console.WriteLine("ptOne + ptTwo: {0}", ptOne + ptTwo);

            // Вычесть одну точку из другой чтобы получить меньшую
            Console.WriteLine("ptOne - ptTwo: {0}", ptOne - ptTwo);

            // Выводит [110, 110]
            Point biggerPoint = ptOne + 10;
            Console.WriteLine("ptOne + 10 = {0}", biggerPoint);

            // Смена слагаемых, выводит [110, 110]
            Point biggerPoint2 = 10 + ptOne;
            Console.WriteLine("10 + ptOne = {0}", biggerPoint2);
            Console.ReadLine();
        }
    }
}
