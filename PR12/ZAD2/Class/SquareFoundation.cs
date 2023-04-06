using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryClasses
{
    class SquareFoundation : Foundation
    {
        private double side;

        public SquareFoundation(string name, double height, double side) : base(name, height)
        {
            this.side = side;
        }

        public override double GetArea()
        {
            return side * side;
        }
    }
}