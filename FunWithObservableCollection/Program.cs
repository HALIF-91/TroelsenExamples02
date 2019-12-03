using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithObservableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<Person> people = new ObservableCollection<Person>()
            {
                new Person{ FirstName = "Peter", LastName = "Murphy", Age = 52},
                new Person{ FirstName = "Kevin", LastName = "Key", Age = 48}
            };

            // Привязаться к событию CollectionChanged
            people.CollectionChanged += PeopleCollectionChanged;

            people.Add(new Person { FirstName = "Fred", LastName = "Smith", Age = 32 });

            people.Remove(people[1]);
            
            Console.ReadLine();
        }

        static void PeopleCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            // выяснить действие которое привело к генерации события
            Console.WriteLine("Action for this event: {0}", e.Action);

            // Было что-то добавлено
            if(e.Action == NotifyCollectionChangedAction.Add)
            {
                // вывести новые элементы, которые были вставлены
                Console.WriteLine("Here are the NEW items:");
                foreach (Person person in e.NewItems)
                {
                    Console.WriteLine(person);
                }
                Console.WriteLine();
            }

            // Было что-то удалено
            if(e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are the OLD items:");
                foreach (Person person in e.OldItems)
                {
                    Console.WriteLine(person);
                }
                Console.WriteLine();
            }
        }
    }
}
