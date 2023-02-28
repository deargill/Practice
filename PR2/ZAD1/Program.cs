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
            double x, y;

            Console.Write("Введите значение x (от 6.7 до ∞, и от -∞ до -6.7 включительно): ");
            x = double.Parse(Console.ReadLine());

            if (x > 6.7)
            {
                y = 4 - Math.Pow(Math.E, 4 * x);
            }
            else if (x <= 6.7)
            {
                y = Math.Log(3.5 + x);
            }
            else
            {
                Console.WriteLine("Ошибка, введено число которое выходит за рамки допустимых!");
                return;
            }

            Console.WriteLine("Значение функции y = {0}", y);

            Console.ReadLine();
        }
    }
}
