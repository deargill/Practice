using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ZAD2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            // Найти слова, содержащие две подряд идущие одинаковые буквы
            Regex regex = new Regex(@"\b\w*(\w)\1\w*\b");
            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
