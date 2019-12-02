using System;
using System.Collections;
using System.Collections.Generic;

namespace ComparableCar
{
    public class PetNameComparer : IComparer<Car>
    {
        public int Compare(Car t1, Car t2)
        {
            return string.Compare(t1.PetName, t2.PetName);
        }
    }
}