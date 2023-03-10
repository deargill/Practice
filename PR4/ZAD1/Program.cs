using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD1
{
    internal class Program
    {
        public static int f(int x)
        {
            if (x < 10 || x > 99) // Проверка на двузначность числа
                throw new ArgumentException("x должно быть двузначным числом.");

            int ones = x % 10; // Определение единиц и десятков
            int tens = x / 10;

            return ones * 10 + tens; // Обмен местами цифр и возврат результата
        }
        static void Main(string[] args)
        {
            Console.Write("Введите двузначное число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int result = f(x);
            Console.WriteLine(result);
        }
    }
}
