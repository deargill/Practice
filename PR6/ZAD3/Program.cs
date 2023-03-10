using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите размерность матрицы: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите минимальное значение элемента матрицы: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите максимальное значение элемента матрицы: ");
            int b = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(a, b + 1);
                }
            }

            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        sum += matrix[i, j] * matrix[i, j];
                    }
                }
            }
            Console.WriteLine("Сумма квадратов отрицательных чисел: " + sum);

            Console.WriteLine("Наименьшие элементы в каждой строке:");
            for (int i = 0; i < n; i++)
            {
                int min = matrix[i, 0];
                for (int j = 1; j < n; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
                Console.WriteLine("В строке " + (i + 1) + " наименьший элемент: " + min);
            }
        }
    }
}
