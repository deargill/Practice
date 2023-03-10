using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            Console.WriteLine("Слова, начинающиеся и заканчивающиеся на одну букву:");

            foreach (string word in words)
            {
                if (word.Length > 1 && word[0] == word[word.Length - 1])
                {
                    Console.WriteLine(word);
                }
            }

            Console.ReadLine();
        }
    }
}
