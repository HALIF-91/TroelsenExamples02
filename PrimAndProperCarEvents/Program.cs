using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimAndProperCarEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("SlugBug", 100, 10);

            c1.AboutToBlow += CarIsAlmostDoomed;
            c1.AboutToBlow += CarAboutToBlow;

            EventHandler<CarEventArgs> d = new EventHandler<CarEventArgs>(CarExploded);
            c1.Exploded += d;

            Console.WriteLine("***** Speeding up ******");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            Console.ReadLine();
        }

        private static void CarExploded(object sender, CarEventArgs e)
        {
            Console.WriteLine(e._msg);
        }

        private static void CarAboutToBlow(object sender, CarEventArgs e)
        {
            if(sender is Car)
            {
                Car с = (Car)sender;
                Console.WriteLine("Critical message from {0}: {1}", с.PetName, e._msg);
            }
        }

        private static void CarIsAlmostDoomed(object sender, CarEventArgs e)
        {
            Console.WriteLine(e._msg);
        }
    }
}
