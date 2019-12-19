using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать Rectangle
            Rectangle r = new Rectangle(15, 4);
            Console.WriteLine(r);
            r.Draw();
            Console.WriteLine();

            // Преобразовать r в Square на основе высоты Rectangle
            Square s = (Square)r;
            Console.WriteLine(s);
            s.Draw();

            // Преобразовать Rectangle в Square для вызова метода
            Rectangle rec = new Rectangle(10, 5);
            DrawSquare((Square)rec);

            // Преобразование int в Square
            Square s2 = (Square)90;
            Console.WriteLine("s2 = {0}", s2);

            // Преобразование Square в int
            int side = (int)s2;
            Console.WriteLine("Side length of s2 = {0}", side);
            Console.ReadLine();
        }
        static void DrawSquare(Square s)
        {
            Console.WriteLine(s);
            s.Draw();
        }
    }
}
