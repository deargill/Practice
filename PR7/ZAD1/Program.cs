using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ZAD1
{
    internal class Program
    {
        public static void Main()
        {
            string input = "Это пример строки с цифрами 123 и без цифр";

            Regex regex = new Regex(@"\b\w*\d\w*\b");

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
