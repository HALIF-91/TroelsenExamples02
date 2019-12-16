using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIndexer
{
    public class PeopleCollection : IEnumerable
    {
        private Dictionary<string, Person> listPeople = new Dictionary<string, Person>();

        // Этот индексатор возвращает персону по строковому индексу
        public Person this[string name]
        {
            get { return listPeople[name]; }
            set { listPeople.Add(name, value); }
        }
        public void ClearPeople()
        {
            listPeople.Clear();
        }
        public int Count
        {
            get { return listPeople.Count; }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return listPeople.GetEnumerator();
        }
    }
}
