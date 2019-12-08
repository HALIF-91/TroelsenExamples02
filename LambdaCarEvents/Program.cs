using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaCarEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("SlugBug", 100, 10);

            c1.AboutToBlow += (sender, e) => { Console.WriteLine(e._msg); };
            c1.Exploded += (sender, e) => { Console.WriteLine(e._msg); };

            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            Console.ReadLine();
        }
    }
}
