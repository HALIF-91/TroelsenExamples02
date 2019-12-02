using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList strArray = new ArrayList();
            
            strArray.AddRange(new string[] { "First", "Second", "Third" });

            Console.WriteLine("This collection has {0} items", strArray.Count);
            Console.WriteLine();

            strArray.Add("Fourth");
            Console.WriteLine("This collection has {0} items", strArray.Count);

            foreach (var str in strArray)
            {
                Console.WriteLine("Entry: {0}", str);
            }

            Console.ReadLine();
        }
    }
}
