using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // обмен двух значений int
            int a = 10, b = 90;
            Console.WriteLine("Before swap: {0}, {1}", a, b);
            Swap(ref a, ref b);
            Console.WriteLine("After swap: {0}, {1}", a, b);
            Console.WriteLine();

            // обмен двух строк
            string s1 = "Hello", s2 = "There";
            Console.WriteLine("Before swap: {0}, {1}", s1, s2);
            Swap(ref s1, ref s2);
            Console.WriteLine("After swap: {0}, {1}", s1, s2);
            Console.WriteLine();

            // Необходимо указать параметр типа,
            // если метод не принимает параметров
            DisplayBaseClass<int>();
            DisplayBaseClass<string>();

            // Ошибка на этапе компиляции
            // DisplayBaseClass();
            Console.ReadLine();
        }
        static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("You sent the Swap() method a {0}", typeof(T));
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void DisplayBaseClass<T>()
        {
            // BaseType - это метод используемый в рефлексии;
            Console.WriteLine("Base class of {0} is: {1}.", typeof(T), typeof(T).BaseType);
        }
    }
}
