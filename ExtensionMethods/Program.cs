using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // В int появилась новая идентичность
            int myInt = 12345678;
            int newInt = myInt.ReverseDigits();
            Console.WriteLine($"{myInt} => {newInt}\n");

            string msg = "I want to say Welcome";

            // у DataSet появилась новая идентичность
            DataSet data = new DataSet();
            data.DisplayDefiningAssembly();
            // нет необходимости отправлять расширяемый тип (первый параметр)
            data.ShowWelcome(msg);

            // у SoundPlayer также
            SoundPlayer sp = new SoundPlayer();
            sp.DisplayDefiningAssembly();
            // нет необходимости отправлять расширяемый тип (первый параметр)
            sp.ShowWelcome(msg);

            // System.Array реализует IEnumerable
            string[] words = { "Welcome", "to", "my", "world" };
            words.PrintDataAndBeep();
            Console.WriteLine("\n");

            // List<T> реализует IEnumerable
            List<int> myInts = new List<int>() { 10, 15, 20 };
            myInts.PrintDataAndBeep();
            Console.ReadLine();
        }
    }
}
