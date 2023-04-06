using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryClasses
{
    abstract class Foundation
    {
        protected string name;
        protected double height;

        public Foundation(string name, double height)
        {
            this.name = name;
            this.height = height;
        }

        public abstract double GetArea();

        public void PrintInfo()
        {
            Console.WriteLine($"Название: {name}\nВысота: {height}\nПлощадь: {GetArea()}\n");
        }

        public double GetHeight()
        {
            return height;
        }
    }
}