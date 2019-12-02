using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    public class Car : IComparable<Car>
    {
        public string PetName { get; set; }
        public int CurrentSpeed { get; set; }
        public int CarID { get; set; }
        public Car(string name, int currSp, int id)
        {
            CurrentSpeed = currSp;
            PetName = name;
            CarID = id;
        }

        public int CompareTo(Car temp)
        {
            if (this.CarID > temp.CarID)
                return 1;
            else if (this.CarID < temp.CarID)
                return -1;
            else
                return 0;
        }

        // CompareTo() можно усовершенствовать так как тип данных int
        // реализует интерфейс IComparable
        //int IComparable.CompareTo(Car temp)
        //{
        //      return this.CarID.CompareTo(temp.CarID);
        //}
    }
}
