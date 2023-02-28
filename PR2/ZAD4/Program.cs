using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два целых числа A и B (A <= B):");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Неверные числа!");
            }

            else
            {
                Console.WriteLine("Введите цифры X и Y:");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                int i = a;
                while (i <= b)
                {
                    if (i % 2 == 0 && (i % 10 == x || i % 10 == y))
                    {
                        Console.WriteLine(i + " ");
                    }
                    i++;
                }

                i = a;
                do
                {
                    if (i % 2 == 0 && (i % 10 == x || i % 10 == y))
                    {
                        Console.WriteLine(i + " ");
                    }
                    i++;
                } while (i <= b);

                for (i = a; i <= b; i++)
                {
                    if (i % 2 == 0 && (i % 10 == x || i % 10 == y))
                    {
                        Console.WriteLine(i + " ");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
