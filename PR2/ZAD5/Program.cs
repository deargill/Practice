using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два целых числа A и B (A < B):");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > b | a == b)
            {
                Console.WriteLine("Неверно указаны числа!");
                
            }
            else
            {
                int product = 1;

                for (int i = a; i <= b; i++)
                {
                    product *= i;
                }

                Console.WriteLine($"Произведение всех целых чисел от {a} до {b} равно {product}");
            }

            Console.ReadKey();
        }
    }
}
