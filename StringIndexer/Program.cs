using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            PeopleCollection people = new PeopleCollection();
            people["Homer"] = new Person("Homer", "Simpson", 40);
            people["Marge"] = new Person("Marge", "Simmson", 38);

            // Получить "Homer" и вывести данные
            Person homer = people["Homer"];
            Console.WriteLine(homer.ToString());
            Console.WriteLine();

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }
            Console.ReadLine();
        }
    }
}
