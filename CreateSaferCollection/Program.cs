using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateSaferCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            PeopleCollection people = new PeopleCollection();
            people.AddPerson(new Person("Homer", "Simpson", 40));
            people.AddPerson(new Person("Marge", "Simpson", 38));
            people.AddPerson(new Person("Lisa", "Simpson", 9));
            people.AddPerson(new Person("Bart", "Simpson", 7));
            people.AddPerson(new Person("Maggie", "Simpson", 2));

            // Это вызовет ошибку при компиляции!
            // people.AddPerson(new Car());

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
            Console.ReadLine();
        }
    }
}