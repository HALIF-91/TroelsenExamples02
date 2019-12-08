using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            TraditionalDelegateSyntax();
            AnonymousMethodSyntax();
            LambdaExpressionSyntax();

            Console.ReadLine();
        }

        #region Использование традиционного синтаксиса делегатов
        private static void TraditionalDelegateSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            Predicate<int> callback = new Predicate<int>(IsEvenNumber);
            List<int> evenNumbers = list.FindAll(callback);

            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }
            Console.WriteLine("\n");
        }
        
        private static bool IsEvenNumber(int i)
        {
            return (i % 2) == 0;
        }
        #endregion

        #region Использование анонимного метода
        private static void AnonymousMethodSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            List<int> evenNumbers = list.FindAll(delegate (int i)
            {
                return (i % 2) == 0;
            });

            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }
            Console.WriteLine("\n");
        }
        #endregion

        #region Использование лямбда-выражения
        private static void LambdaExpressionSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            // идентичные записи
            List<int> evenNumbers = list.FindAll(i => (i % 2) == 0);
            // List<int> evenNumbers = list.FindAll((int i) => (i % 2) == 0);

            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }
            Console.WriteLine("\n");

            List<int> evenNumbers2 = list.FindAll(i =>
            {
                Console.WriteLine("value if i is currently {0}", i);
                bool isEven = ((i % 2) == 0);
                return isEven;
            });

            Console.WriteLine("\nHere are your even numbers:");
            foreach (int evenNumber in evenNumbers2)
            {
                Console.Write("{0}\t", evenNumber);
            }
        }
        #endregion
    }
}
