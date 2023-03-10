using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();

            // Поменять местами первое и последнее слова
            string[] words = sentence.Split(' ');
            string temp = words[0];
            words[0] = words[words.Length - 1];
            words[words.Length - 1] = temp;
            sentence = string.Join(" ", words);
            Console.WriteLine($"1. {sentence}");

            // Склеить второе и третье слова
            words[1] = string.Concat(words[1], words[2]);
            for (int i = 2; i < words.Length - 1; i++)
            {
                words[i] = words[i + 1];
            }
            Array.Resize(ref words, words.Length - 1);
            sentence = string.Join(" ", words);
            Console.WriteLine($"2. {sentence}");

            // Вывести третье слово в обратном порядке
            char[] reverseChars = words[2].ToCharArray();
            Array.Reverse(reverseChars);
            string reverseWord = new string(reverseChars);
            Console.WriteLine($"3. {reverseWord}");

            // В первом слове вырезать первые две буквы
            words[0] = words[0].Substring(2);
            sentence = string.Join(" ", words);
            Console.WriteLine($"4. {sentence}");
        }
    }
}