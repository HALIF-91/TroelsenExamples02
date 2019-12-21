using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    // Средство IntelliSense маркирует все расширяющие методы
    // уникальным значком с изображением стрелки вниз
    // это означает, что он определен вне исходного определения класса

    // Первый параметр расширяющего метода всегда представляет расширяемый тип

    // Если метод прототипирован для расширения System.Object 
    // к примеру DisplayDefiningAssembly(this object obj), то этот новый член имеется
    // в каждом типе, поскольку object является родителем всех типов в .NET

    // Однако к примеру метод ReverseDigits(this int i) прототипирован только для расширения int
    // если что-то другое попытается вызвать этот метод, возникнет ошибка на этапе компиляции
    static class MyExtensions
    {
        // Этот метод позволяет любому объекту отобразить
        // сборку, в которой он определен
        public static void DisplayDefiningAssembly(this object obj)
        {
            Console.WriteLine("{0} lives here: => {1}", 
                obj.GetType().Name, Assembly.GetAssembly(obj.GetType()).GetName().Name);
        }

        // Этот метод позволяет любому целому изменить порядок следования
        // десятичных цифр на обратный. Например, 56 превратится в 65
        public static int ReverseDigits(this int i)
        {
            // Транслировать int в string и затем получить все его символы
            char[] digits = i.ToString().ToCharArray();

            // изменить порядок элементов массива
            Array.Reverse(digits);

            // вставить обратно в строку
            string newDigits = new string(digits);

            // вернуть модифицированную строку как int
            return int.Parse(newDigits);
        }

        // Каждый расширяющий метод может иметь множество параметров
        // но только первый параметр может быть помечен как this
        public static void ShowWelcome(this object obj, string msg)
        {
            Console.WriteLine($"{msg} to {obj.GetType().Name}\n");
        }

        // Добавляется новый метод к любому типу реализующему интерфейс IEnumerable
        // что будет включать все массивы, необобщенные и обощенные классы коллекций
        // так как IEnumerable<T> расширяет необобщенный интерфейс IEnumerable
        public static void PrintDataAndBeep(this IEnumerable iterator)
        {
            foreach (var item in iterator)
            {
                Console.Write(item + " ");
            }
        }
    }
}
