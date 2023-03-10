using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD5
{
    class Program
    {
        static double Factorial(int n)
        {
            if (n == 0)
            {
                return 1; // базовый случай - факториал 0 равен 1
            }
            else
            {
                return n * Factorial(n - 1); // рекурсивный случай
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            double fn = (n - 1) / Factorial(n);

            Console.WriteLine($"f({n}) = {fn}");
        }
    }
}
