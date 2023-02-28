using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон треугольника:");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("Треугольник равносторонний.");
            }
            else
            {
                Console.WriteLine("Треугольник не является равносторонним.");
            }

            Console.ReadKey();
        }
    }
}
