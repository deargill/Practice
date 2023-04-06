using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryClasses
{
    class Square : Quadrilateral
    {
        private double side;

        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }

        public override double Area()
        {
            return side * side;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Сторона: " + side);
            Console.WriteLine("Площадь: " + Area());
        }
    }
}