using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    public delegate int BinaryOp(int x, int y);
    public class SimpleMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMath simple = new SimpleMath();
            BinaryOp op = new BinaryOp(simple.Add);

            // следующие операторы кода (вызов метода) идентичны
            Console.WriteLine("10 + 10 is {0}", op.Invoke(10, 10));
            Console.WriteLine("10 + 10 is {0}", op(10, 10));
            Console.WriteLine();

            op += SimpleMath.Subtract;
            // при добавлении еще одного метода также возвращающегося значение, 
            // при вызове делегат отбрасывает значение предыдущих методов,
            // и возвращает значение с последнего метода
            Console.WriteLine("10 - 10 is {0}", op.Invoke(10, 10));
            Console.WriteLine("10 - 10 is {0}", op(10, 10));
            Console.WriteLine();

            DisplayDelegateInfo(op);

            Console.ReadLine();
        }
        static void DisplayDelegateInfo(Delegate delObj)
        {
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method name: {0}", d.Method);

                // если метод статический, возвращаемый object (d.Target) будет null
                Console.WriteLine("Type name: {0}", d.Target);
            }
        }
    }
}
