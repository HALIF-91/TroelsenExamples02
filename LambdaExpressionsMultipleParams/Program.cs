using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsMultipleParams
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMath m = new SimpleMath();
            m.SetMathHandler((msg, result) =>
            {
               Console.WriteLine("Message: {0}, Result: {1}", msg, result);
            });

            m.Add(10, 10);
            Console.ReadLine();
        }
    }
}
