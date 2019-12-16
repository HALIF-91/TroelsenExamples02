using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            PeopleCollection people = new PeopleCollection();

            // Добавить объекты с применением синтаксиса индексатора
            people[0] = new Person("Homer", "Simpson", 40);
            people[1] = new Person("Marge", "Simpson", 38);
            people[2] = new Person("Lisa", "Simpson", 9);
            people[3] = new Person("Bart", "Simpson", 7);
            people[4] = new Person("Maggie", "Simpson", 2);

            // Получить и отобразить каждый элемент с использованием индексатора
            for (int i = 0; i < people.Count(); i++)
            {
                Console.WriteLine("Person number: {0}", i);
                Console.WriteLine("Name: {0} {1}", people[i].FirstName, people[i].LastName);
                Console.WriteLine("Age: {0}", people[i].Age);
                Console.WriteLine();
            }
            UseGenericListOfPeople();
            Console.ReadLine();
        }
        static void UseGenericListOfPeople()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("Lisa", "Simpson", 9));
            people.Add(new Person("Bart", "Simpson", 7));

            // Изменить первую персону с помощью индексатора
            people[0] = new Person("Maggie", "Simpson", 2);

            // Получить и отобразить каждый элемент с использованием индексатора
            for (int i = 0; i < people.Count(); i++)
            {
                Console.WriteLine("Person number: {0}", i);
                Console.WriteLine("Name: {0} {1}", people[i].FirstName, people[i].LastName);
                Console.WriteLine("Age: {0}", people[i].Age);
                Console.WriteLine();
            }
        }
    }
}
