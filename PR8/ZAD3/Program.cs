using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ZAD3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            // Найти цифры от 1 до 99
            Regex regex = new Regex(@"\b([1-9]|[1-9][0-9])\b");
            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
            Console.ReadKey();
        }
    }
}