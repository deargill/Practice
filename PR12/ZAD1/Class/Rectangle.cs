using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryClasses
{
    class Rectangle : Quadrilateral
    {
        private double length;
        private double width;

        public Rectangle(string name, double length, double width) : base(name)
        {
            this.length = length;
            this.width = width;
        }

        public override double Area()
        {
            return length * width;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Длина: " + length);
            Console.WriteLine("Ширина: " + width);
            Console.WriteLine("Площадь: " + Area());
        }
    }
}