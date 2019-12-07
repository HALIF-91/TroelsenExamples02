using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereKeyword
{
    class FirstGenericClass<T> where T: new()
    {
        /*Класс унаследован от object, причем содержащиеся в нем
         элементы должны иметь стандартный конструктор*/
    }
    class SecondGenericClass<T> where T: class, IComparable, new()
    {
        /*Класс унаследован от object, причем содержащиеся в нем
         элементы должны относиться к классу, реализующему IComparable,
         и поддерживать стандартный конструктор
         !Ограничение new() должно быть последним в списке*/
    }
    class ThirdGenericClass<K, T> where K: Shape, new() where T: IComparable<T>
    {
        /*<K> должен расширять базовый класс <Shape> и иметь стандартный конструктор
         <T> должен реализовывать обобщенный интерфейс IComparable
         */
        public K Shape { get; set; }
        public T Numb { get; set; }
        public ThirdGenericClass(K shape, T numb)
        {
            Shape = shape;
            Numb = numb;
        }
    }
    public delegate int BinaryOp(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Hexagon hexagon = new Hexagon();

            ThirdGenericClass<Circle, Hexagon> third = new ThirdGenericClass<Circle, Hexagon>(circle, hexagon);
        }

        static void Swap<T>(ref T a, ref T b) where T: struct
        {
            // Этот метод обменяет местами любые структуры, но не классы
        }
    }
}
