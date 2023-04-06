using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryClasses
{
    abstract class Quadrilateral
    {
        protected string name;

        public Quadrilateral(string name)
        {
            this.name = name;
        }

        public abstract double Area();

        public virtual void PrintInfo()
        {
            Console.WriteLine("Название: " + name);
        }
    }
}
