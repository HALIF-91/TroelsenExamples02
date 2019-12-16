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
            Console.WriteLine("\nptOne + ptTwo: {0}", ptOne + ptTwo);

            // Вычесть одну точку из другой чтобы получить меньшую
            Console.WriteLine("ptOne - ptTwo: {0}", ptOne - ptTwo);

            // Выводит [110, 110]
            Point biggerPoint = ptOne + 10;
            Console.WriteLine("\nptOne + 10 = {0}", biggerPoint);

            // Смена слагаемых, выводит [110, 110]
            Point biggerPoint2 = 10 + ptOne;
            Console.WriteLine("10 + ptOne = {0}", biggerPoint2);

            // Если в классе Point перегружены операции + и -
            // Операция += автоматически перегружена
            Point ptThree = new Point(90,5);
            Console.WriteLine("\nptThree = {0}", ptThree);
            Console.WriteLine("ptThree += ptTwo: {0}", ptThree += ptTwo);

            // Если в классе Point перегружены операции + и -
            // Операция -= автоматически перегружена
            Point ptFour = new Point(0, 500);
            Console.WriteLine("ptFour = {0}", ptFour);
            Console.WriteLine("ptFour -= ptThree: {0}", ptFour -= ptThree);

            Point ptFive = new Point(1, 1);
            Console.WriteLine("\nptFive = {0}", ptFive);
            Console.WriteLine("++ptFive = {0}", ++ptFive); // [2,2]
            Console.WriteLine("--ptFive = {0}", --ptFive); // [1,1]

            Point ptSix = new Point(20, 20);
            Console.WriteLine("\nptSix = {0}", ptSix);
            Console.WriteLine("ptSix++ = {0}", ptSix++); // [20,20]
            Console.WriteLine("ptSix-- = {0}", ptSix--); // [21,21]

            Console.WriteLine("\nptOne == ptTwo : {0}", ptOne == ptTwo);
            Console.WriteLine("ptOne != ptTwo : {0}", ptOne != ptTwo);

            Console.WriteLine("\nptOne > ptTwo: {0}", ptOne > ptTwo);
            Console.WriteLine("ptOne < ptTwo: {0}", ptOne < ptTwo);
            Console.ReadLine();
        }
    }
}
