using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите значение x для выражения y = (x+4)/(x+8): ");
                double x = double.Parse(Console.ReadLine());
                double y = (x + 4) / (x + 8);
                Console.WriteLine($"Значение выражения y = {y}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неверный формат ввода числа!");
            }

            try
            {
                Console.Write("Введите значение x для выражения y = (cos^3(x))/(x-1): ");
                double x = double.Parse(Console.ReadLine());
                double y = Math.Pow(Math.Cos(x), 3) / (x - 1);
                Console.WriteLine($"Значение выражения y = {y}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неверный формат ввода числа!");
            }

            Console.ReadLine();
        }
    }
}