using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueWithNongenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleBoxUnboxOperation();

            Console.ReadLine();
        }

        static void SimpleBoxUnboxOperation()
        {
            int myInt = 25;

            // Упаковать int в ссылку на object
            object boxedInt = myInt;

            try
            {
                // Запрещено распаковывать в неверный тип данных после упаковки в ссылку на object
                long unboxedInt = (long)boxedInt;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
