using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Classes
{
    class MyClass : Ix, Iy, Iz
    {
        double w;
        public MyClass(double _w)
        {
            this.w = _w;
        }
        public MyClass()
        {
            w = 100;
        }
        public void IxF0(double key)
        {
            w = key * key;
            Console.WriteLine($"IxF0({w})");
        }
        public void IxF1()
        {
            w = w * w;
            Console.WriteLine($"IxF1({w})");
        }
        public void F0(double key)
        {
            w = Math.Sqrt(key);
            Console.WriteLine($"F0({w})");
        }
        public void F1()
        {
            w = Math.Sqrt(w);
            Console.WriteLine($"F1({w})");
        }
        void Iz.F0(double key)
        {
            w = key * key + 5;
            Console.WriteLine($"Ix.F0({w})");
        }
        void Iz.F1()
        {
            w = w * w + 5;
            Console.WriteLine($"Ix.F1({w})");
        }
    }
}
