using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать анонимный тип, представляющий автомобиль
            var myCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };

            // Вывести на консоль
            Console.WriteLine("My car is {0} {1}", myCar.Color, myCar.Make);

            // Вызвать вспомогательный метод
            // для построения анонимного типа посредством аргументов
            BuildAnonymousType("BMW", "Black", 90);
            Console.WriteLine();

            EqualityTest();

            // Анонимный тип содержащий другие анонимные типы
            var purchaseItem = new
            {
                TimeBought = DateTime.Now,
                ItemBought = new { Color = "Red", Make = "Saab", CurrentSpeed = 55 },
                Price = 34.000
            };
            ReflectOverAnonymousType(purchaseItem);

            Console.ReadLine();
        }
        static void BuildAnonymousType(string make, string color, int currSp)
        {
            // построить анонимный тип, используя входные аргументы
            var car = new { Make = make, Color = color, CurrentSpeed = currSp };

            // этот тип можно использовать для получения данных свойств
            Console.WriteLine("You have a {0} {1} going {2} MPH",
                car.Color, car.Make, car.CurrentSpeed);

            // Анонимные типы имеют специальные реализации каждого
            // виртуального метода System.Object
            Console.WriteLine("ToString() == {0}", car.ToString());
        }
        static void ReflectOverAnonymousType(object obj)
        {
            Console.WriteLine("obj an instance of: {0}", obj.GetType().Name);
            Console.WriteLine("Base class of {0} is {1}", 
                obj.GetType().Name, obj.GetType().BaseType);
            Console.WriteLine("obj.ToString() == {0}", obj.ToString());
            Console.WriteLine("obj.GetHashCode() == {0}", obj.GetHashCode());
            Console.WriteLine();
        }
        static void EqualityTest()
        {
            var firstCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };
            var secondCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };

            // возвращает true
            // Equals() при проверке эквивалентности использует семантику на основе значений
            if(firstCar.Equals(secondCar))
                Console.WriteLine("Same anonymous object!");
            else
                Console.WriteLine("Not the same anonymous object!");

            // возвращает false
            // == при проверке эквивалентности использует семантику на основе ссылок
            if(firstCar == secondCar)
                Console.WriteLine("Same anonymous object!");
            else
                Console.WriteLine("Not the same anonymous object!");

            // возвращает true
            // компилятор генерирует определение нового класса тогда,
            // когда анонимный тип имеет уникальные имена свойств
            if(firstCar.GetType().Name == secondCar.GetType().Name)
                Console.WriteLine("We are the both same type!");
            else
                Console.WriteLine("We are different types!");

            // отобразить все детали
            Console.WriteLine();
            ReflectOverAnonymousType(firstCar);
            ReflectOverAnonymousType(secondCar);
        }
    }
}
