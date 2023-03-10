using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Входная строка
        string input = "Найти слова в которых встречаются более трех подряд идущих согласных например страница.";

        // Шаблон регулярного выражения для поиска слов с более чем 3 подряд идущими согласными
        string pattern = @"\b\w*[бвгджзйклмнпрстфхцчшщBCDFGHJKLMNPQRSTVWXYZ]{3,}\w*\b";

        // Создание объекта регулярного выражения
        Regex regex = new Regex(pattern);

        // Поиск и вывод слов с более чем 3 подряд идущими согласными
        MatchCollection matches = regex.Matches(input);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }

        Console.ReadKey();
    }
}