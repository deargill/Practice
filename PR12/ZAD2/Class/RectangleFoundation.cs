using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryClasses
{
    class RectangleFoundation : Foundation
    {
        private double length;
        private double width;

        public RectangleFoundation(string name, double height, double length, double width) : base(name, height)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea()
        {
            return length * width;
        }
    }
}
