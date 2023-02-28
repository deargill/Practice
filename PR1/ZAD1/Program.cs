using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());

            double b = Convert.ToDouble(Console.ReadLine());

            double c = Convert.ToDouble(Console.ReadLine());

            double d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{a} / {b} + {c} / {d} = {a/b+c/d}");
            Console.ReadLine();
        }
    }
}
