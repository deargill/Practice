using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите значения A1, B1, C1: ");
            double A1 = double.Parse(Console.ReadLine());
            double B1 = double.Parse(Console.ReadLine());
            double C1 = double.Parse(Console.ReadLine());

            Console.Write("Введите значения A2, B2, C2: ");
            double A2 = double.Parse(Console.ReadLine());
            double B2 = double.Parse(Console.ReadLine());
            double C2 = double.Parse(Console.ReadLine());

            SortInc3(ref A1, ref B1, ref C1);
            SortInc3(ref A2, ref B2, ref C2);

            Console.WriteLine("Отсортированный набор 1: {0}, {1}, {2}", A1, B1, C1);
            Console.WriteLine("Отсортированный набор 2: {0}, {1}, {2}", A2, B2, C2);
        }

        static void SortInc3(ref double A, ref double B, ref double C)
        {
            if (A > B)
            {
                double temp = A;
                A = B;
                B = temp;
            }
            if (B > C)
            {
                double temp = B;
                B = C;
                C = temp;
            }
            if (A > B)
            {
                double temp = A;
                A = B;
                B = temp;
            }
        }
    }
}
