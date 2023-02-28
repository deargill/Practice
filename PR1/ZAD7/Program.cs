using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("z1 = " + ((Math.Sin(2 * a) + Math.Sin(5 * a) - Math.Sin(3*a))/(Math.Cos(a) + 1 - 2 * Math.Pow(Math.Sin(2 * a), 2))));
            Console.WriteLine("z2 = " + (2 * Math.Sin(a)));

            Console.ReadLine();
        }
    }
}
