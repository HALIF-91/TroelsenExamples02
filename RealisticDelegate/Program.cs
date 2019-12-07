using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealisticDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("SlugBug", 100, 10);

            // идентичный синтаксис
            car.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            car.RegisterWithCarEngine(OnCarEngineEvent2);

            Console.WriteLine("*****Speeding up *****");
            for (int i = 0; i < 6; i++)
            {
                car.Accelerate(20);
            }

            Console.ReadLine();
        }

        private static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message from Car object *****");
            Console.WriteLine("=> {0}", msg);
        }
        private static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("=> {0}", msg.ToUpper());
            Console.WriteLine("*************************************\n");
        }
    }
}
