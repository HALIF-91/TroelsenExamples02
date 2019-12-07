using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereKeyword
{
    class Circle : Shape
    {
        public Circle() { }
        public Circle(string name) : base(name) { }

        // реализовать абстрактный метод из базового класса
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Circle", PetName);
        }
    }
}
