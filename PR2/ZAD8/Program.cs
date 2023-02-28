using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число:");
            int number = int.Parse(Console.ReadLine());

            int digit1 = number / 100;
            int digit2 = (number / 10) % 10;
            int digit3 = number % 10;

            bool isAscending = (digit1 < digit2) && (digit2 < digit3);
            bool isDescending = (digit1 > digit2) && (digit2 > digit3);

            if (isAscending || isDescending)
            {
                Console.WriteLine("Высказывание истинно.");
            }
            else
            {
                Console.WriteLine("Высказывание ложно.");
            }
    }
}
