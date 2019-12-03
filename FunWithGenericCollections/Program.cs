using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            UseGenericList();
            Console.WriteLine();

            UseGenericStack();
            Console.WriteLine();

            UseGenericQueue();
            Console.WriteLine();

            UseSortedList();

            Console.ReadLine();
        }

        #region класс List<T>
        static void UseGenericList()
        {
            List<Person> people = new List<Person>()
            {
                new Person("Homer", "Simpson", 40),
                new Person("Marge", "Simpson", 38),
                new Person("Lisa", "Simpson", 9),
                new Person("Bart", "Simpson", 7)
            };
            Console.WriteLine("Items in list: {0}", people.Count);

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }

            // вставить новую персону
            Console.WriteLine("\n->Inserting new person");
            people.Insert(2, new Person("Maggie", "Simpson", 2));
            Console.WriteLine("Items in list: {0}", people.Count);

            // скопировать данные в новый массив
            Person[] arrayOfPeople = people.ToArray();

            for (int i = 0; i < arrayOfPeople.Length; i++)
            {
                Console.WriteLine("First Names: {0}", arrayOfPeople[i].FirstName);
            }
        }
        #endregion

        #region класс Stack<T>
        static void UseGenericStack()
        {
            Stack<Person> stackOfPeople = new Stack<Person>();
            stackOfPeople.Push(new Person
            { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            stackOfPeople.Push(new Person
            { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            stackOfPeople.Push(new Person
            { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            // Просмотреть верхний элемент, вытолкнуть его и просмотреть снова
            Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            Console.WriteLine("\nFirst person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            Console.WriteLine("\nFirst person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());

            try
            {
                Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
                Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("\nError! {0}", ex.Message); // ошибка стек пуст
            }
        }
        #endregion

        #region класс Queue<T>
        static void UseGenericQueue()
        {
            Queue<Person> people = new Queue<Person>();
            people.Enqueue(new Person
            { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            people.Enqueue(new Person
            { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            people.Enqueue(new Person
            { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            // кто первый в очереди?
            Console.WriteLine("{0} is first in line!", people.Peek().FirstName);

            // удалить всех из очереди
            GetCoffee(people.Dequeue());
            GetCoffee(people.Dequeue());
            GetCoffee(people.Dequeue());

            // попробовать извлечь кого то из очереди
            try
            {
                GetCoffee(people.Dequeue());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("\nError! {0}", ex.Message); // ошибка очередь пуста
            }
        }
        static void GetCoffee(Person p)
        {
            Console.WriteLine("{0} got coffee!", p.FirstName);
        }
        #endregion

        #region класс SortedSet<T>
        static void UseSortedList()
        {
            SortedSet<Person> people = new SortedSet<Person>(new Person())
            {
                new Person("Homer", "Simpson", 47),
                new Person("Marge", "Simpson", 45),
                new Person("Lisa", "Simpson", 9),
                new Person("Bart", "Simpson", 8)
            };
            
            // элементы будут отсортированы по имени
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();

            people.Add(new Person { FirstName = "Saku", LastName = "Jones", Age = 1 });
            people.Add(new Person { FirstName = "Mikko", LastName = "Jones", Age = 32 });

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
        #endregion
    }
}
