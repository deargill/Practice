using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD2
{
    class Program
    {
        static void Main()
        {
            double[] arr = new double[20];
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                arr[i] = rnd.NextDouble() * 10;
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            for (int i = 0; i < 10; i++)
            {
                double max = Math.Max(arr[i], arr[10 + i]);
                double min = Math.Min(arr[i], arr[10 + i]);
                arr[i] = max;
                arr[10 + i] = min;
            }

            Array.Sort(arr);

            Console.Write("Введите число k для поиска: ");
            double k = double.Parse(Console.ReadLine());

            int index = Array.BinarySearch(arr, k);
            if (index < 0)
            {
                Console.WriteLine($"Число {k} не найдено в массиве.");
            }
            else
            {
                Console.WriteLine($"Число {k} найдено в массиве. Индекс: {index}");
            }
        }
    }
}
