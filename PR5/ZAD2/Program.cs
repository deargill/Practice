using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите вещественное х: ");
                double x = double.Parse(Console.ReadLine());
                double f;
                if (x > -4 && x <= 1)
                {
                    f = ((3 * x + 2) / (4 * x + 4)) - 4;
                    Console.WriteLine($"f(x) = {f}");
                }
                else if (x > 1)
                    Console.WriteLine("f(x) = " + Math.Pow(x, 2));
                else throw new Exception("Ошибка: выход из диапазона допустимых значений х!");
            }
            catch (Exception fx)
            {
                Console.WriteLine(fx.Message);
            }
            finally
            {
                Console.WriteLine("Конец программы!");
            }
            Console.ReadLine();
        }
    }
}
