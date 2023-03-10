using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD1
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            double[] arr = new double[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.NextDouble() * 5;
            }

            Console.WriteLine("Индексы элементов массива, удовлетворяющих условию 0 < x(i) < 3.2:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0 && arr[i] < 3.2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}