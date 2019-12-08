using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsMultipleParams
{
    public delegate string VerySimpleDelegate();
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

            // идентичная запись
            VerySimpleDelegate d = new VerySimpleDelegate(() =>
            {
                return "Enjoy your first string!";
            });

            VerySimpleDelegate de = () => { return "Enjoy your second string!"; };

            Console.WriteLine(d.Invoke());
            Console.WriteLine(de.Invoke());
            Console.ReadLine();
        }
    }
}
