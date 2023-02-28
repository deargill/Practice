using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double H = (B - A) / M;

            Console.WriteLine("Вычисление значений функции F(x) на отрезке [{0}, {1}] в {2} точках:", A, B, M);

            for (int i = 0; i <= M; i++)
            {
                double x = A + i * H;
                double fx = Math.Cos(1 / x);
                Console.WriteLine("F({0:f2}) = {1:f2}", x, fx);
            }

            Console.ReadLine();
        }
    }
}
