using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsafeCode
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            int myInt = 10;
            SquareIntPointer(&myInt);
            Console.WriteLine("myInt: {0}", myInt);

            PrintValueAndAddress();

            int i = 10, j = 20;

            Console.WriteLine("\n****** Safe Swap *****");
            Console.WriteLine("Values before safe swap: i = {0}, j = {1}", i, j);
            SafeSwap(ref i, ref j);
            Console.WriteLine("Values after safe swap: i = {0}, j = {1}", i, j);

            Console.WriteLine("\n****** Unsafe Swap *****");
            Console.WriteLine("Values before unsafe swap: i = {0}, j = {1}", i, j);
            UnsafeSwap(&i, &j);
            Console.WriteLine("Values after unsafe swap: i = {0}, j = {1}\n", i, j);

            UsePointerToPoint();
            UnsafeStackalloc();
            UseAndPinPoint();
            UseSizeofOperator();
            Console.ReadLine();
        }
        unsafe static void SquareIntPointer(int* myIntPointer)
        {
            *myIntPointer *= *myIntPointer;
        }
        unsafe static void PrintValueAndAddress()
        {
            int myInt;
            int* ptrToMyInt = &myInt;
            *ptrToMyInt = 123;

            Console.WriteLine("Value of myInt: {0}", myInt);
            Console.WriteLine("Address of myInt: {0}", (int)&ptrToMyInt);
        }
        unsafe public static void UnsafeSwap(int* i, int* j)
        {
            int temp = *i;
            *i = *j;
            *j = temp;
        }
        public static void SafeSwap(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }
        unsafe static void UsePointerToPoint()
        {
            // доступ к членам через указатель ->
            Point point;
            Point* p = &point;
            p->x = 100;
            p->y = 200;
            Console.WriteLine(p->ToString());

            // доступ к членам через разыменованный указатель
            Point point2;
            Point* p2 = &point2;
            (*p2).x = 100;
            (*p2).y = 200;
            Console.WriteLine((*p2).ToString());

            Console.WriteLine();
        }
        unsafe static void UnsafeStackalloc()
        {
            char* p = stackalloc char[128];
            for (int i = 0; i < 128; i++)
            {
                p[i] = (char)i;
                Console.Write(p[i] + ", ");
            }
            Console.WriteLine("\n");
        }
        unsafe public static void UseAndPinPoint()
        {
            PointRef pt = new PointRef();
            pt.x = 5;
            pt.y = 6;

            fixed(int* p = &pt.x)
            {
                // Использовать здесь переменную int*
                *p = 10;
            }
            fixed(int* p = &pt.y)
            {
                // Использовать здесь переменную int*
                *p = 12;
            }

            // объект pt теперь не закреплен и готов к сборке мусора
            Console.WriteLine("PointRef is: {0}", pt);
            Console.WriteLine();
        }
        unsafe static void UseSizeofOperator()
        {
            // ключевое слово sizeof служит для получения размера в байтах
            // типа значения (но никогда - ссылочного типа)
            Console.WriteLine("The size of Point is {0}", sizeof(Point));
            Console.WriteLine("The size of int is {0}", sizeof(int));
        }
    }
}
