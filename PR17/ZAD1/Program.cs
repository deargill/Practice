using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "f.txt";

        try
        {
            double[] numbers = File.ReadAllLines(fileName)
                                    .Select(line => double.Parse(line))
                                    .ToArray();

            double maxValue = numbers.Max();
            double minValue = numbers.Min();

            double sum = maxValue + minValue;

            // Вывод результата
            Console.WriteLine($"Сумма наибольшего ({maxValue}) и наименьшего ({minValue}) значения: {sum}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
    }
}