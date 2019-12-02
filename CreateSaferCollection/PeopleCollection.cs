using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateSaferCollection
{
    public class PeopleCollection : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();
        public Person GetPerson(int pos)
        {
            return (Person)arPeople[pos];
        }
        public void AddPerson(Person p)
        {
            arPeople.Add(p);
        }
        public void ClearPeople()
        {
            arPeople.Clear();
        }
        public int Count()
        {
            return arPeople.Count;
        }
        public IEnumerator GetEnumerator()
        {
            return arPeople.GetEnumerator();
        }
    }
}
