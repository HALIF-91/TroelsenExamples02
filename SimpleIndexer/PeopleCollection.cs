using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIndexer
{
    public class PeopleCollection
    {
        private ArrayList arPeople = new ArrayList();
        public Person this[int index]
        {
            get { return (Person)arPeople[index]; }
            set { arPeople.Insert(index, value); }
        }
        public void ClearPeople()
        {
            arPeople.Clear();
        }
        public int Count()
        {
            return arPeople.Count;
        }
    }
}
