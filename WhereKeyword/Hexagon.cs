using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereKeyword
{
    class Hexagon : Shape, IComparable<Hexagon>
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }

        public int CompareTo(Hexagon hexagon)
        {
            throw new NotImplementedException();
        }

        // реализовать абстрактный метод из базового класса
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }
    }
}
