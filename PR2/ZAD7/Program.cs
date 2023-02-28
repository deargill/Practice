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
            Console.WriteLine("Введите два числа:");

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double sum = a + b;
            double difference = a - b;
            double product = a * b;
            double quotient = a / b;

            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Разность: " + difference);
            Console.WriteLine("Произведение: " + product);
            Console.WriteLine("Частное: " + quotient);
        }
    }
}
