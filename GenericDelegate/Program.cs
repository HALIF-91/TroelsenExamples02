using System;

namespace GenericDelegate
{
    public delegate void MyGenericDelegate<T>(T arg);
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericDelegate<string> strTarget = StringTarget;
            strTarget("Some string data");

            MyGenericDelegate<int> intTarget = new MyGenericDelegate<int>(IntTarget);
            intTarget(9);

            Console.ReadLine();
        }

        private static void StringTarget(string arg)
        {
            Console.WriteLine("arg in uppercase is {0}", arg.ToUpper());
        }
        private static void IntTarget(int arg)
        {
            Console.WriteLine("++arg is: {0}", ++arg);
        }
    }
}
