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
            Console.WriteLine("Введите номер масти (1 - пик, 2 - треф, 3 - бубен, 4 - черви):");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите номер достоинства карты (6 - шестерка, 7 - семерка, 8 - восьмерка, 9 - девятка, 10 - десятка, 11 - валет, 12 - дама, 13 - король, 14 - туз):");
            int k = int.Parse(Console.ReadLine());

            string suit = "";
            string rank = "";

            switch (m)
            {
                case 1:
                    suit = "пик";
                    break;
                case 2:
                    suit = "треф";
                    break;
                case 3:
                    suit = "бубен";
                    break;
                case 4:
                    suit = "черви";
                    break;
                default:
                    Console.WriteLine("Некорректный номер масти.");
                    break;
            }

            switch (k)
            {
                case 6:
                    rank = "шестерка";
                    break;
                case 7:
                    rank = "семерка";
                    break;
                case 8:
                    rank = "восьмерка";
                    break;
                case 9:
                    rank = "девятка";
                    break;
                case 10:
                    rank = "десятка";
                    break;
                case 11:
                    rank = "валет";
                    break;
                case 12:
                    rank = "дама";
                    break;
                case 13:
                    rank = "король";
                    break;
                case 14:
                    rank = "туз";
                    break;
                default:
                    Console.WriteLine("Некорректный номер достоинства.");
                    break;
            }

            if (suit != "" && rank != "")
            {
                Console.WriteLine($"{rank} {suit}");
            }

            Console.ReadKey();
        }
    }
}